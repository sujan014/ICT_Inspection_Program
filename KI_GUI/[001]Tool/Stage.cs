using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KI_GUI
{
	class stage
	{
		public const byte MOVE_CENTER = 252;
		public const byte MOVE_HOME = 253;
		public const byte MOVE_JOG = 254;
		public const byte BOARD_STATE = 255;

		public const byte x_axis = 1;
		public const byte y_axis = 2;
		public const byte t_axis = 3;
		public const byte all_axis = 0;

		public const int pixel_pulse_x = 4;					//1 픽셀 당 X 펄스 
		public const int pixel_pulse_y = 4;					//1 픽셀 당 Y 펄스
		public const int pixel_pulse_t = 12;				//1 픽셀 당 T 펄스

		#region TX Data Board(PC->Board)
		public static void tx_bd(byte nType, int length, byte[] data)
		{
			try
			{
				if (KI.frm.stage_serial.IsOpen == false)
					return;

				int checksum_cal = 0;
				byte[] txbuff = new byte[128 * 1024];// 131072 45337
				txbuff.Initialize();

				txbuff[0] = (byte)'S';    // stx1
				txbuff[1] = (byte)'T';    // stx2
				txbuff[2] = (byte)'X';    // stx3
				txbuff[3] = (byte)',';    // ,
				txbuff[4] = (byte)nType;  // ntype4
				txbuff[5] = (byte)((length >> 8) & 0xff);  // length high
				txbuff[6] = (byte)((length >> 0) & 0xff);  // length low
				for (int cnt = 0; cnt < length; cnt++)
				{
					txbuff[7 + cnt] = data[cnt]; //data
					checksum_cal += data[cnt];
				}
				checksum_cal = checksum_cal & 0xFFFF;
				txbuff[7 + length + 0] = (byte)((checksum_cal >> 8) & 0xff);  // length high
				txbuff[7 + length + 1] = (byte)((checksum_cal >> 0) & 0xff);  // length low
				txbuff[7 + length + 2] = (byte)',';    // ,
				txbuff[7 + length + 3] = (byte)'E';    // etx 1
				txbuff[7 + length + 4] = (byte)'T';    // etx 2
				txbuff[7 + length + 5] = (byte)'X';    // etx 3
				KI.frm.stage_serial.Write(txbuff, 0, length + 13);
			}
			catch
			{
				//state_log.Text = "tx ng";
			}
		}
		#endregion

		public static void stage_check(byte flag)
		{
			byte[] tx_buff = new byte[10];
			tx_buff[0] = flag;
			tx_bd(BOARD_STATE, 1, tx_buff);
		}

		#region Stage BOARD SERIAL
		public static int Port_Count = 0;
		public static string[] Port_List = new string[50];
		public static bool stage_conn = false;
		public static int check_send_count = 0;
		public static int change_comport = 0;

		public static void stage_serial_init()
		{
			Port_Count = 0;
			foreach (string comport in SerialPort.GetPortNames())
			{
				Port_List[Port_Count++] = comport;
			}
			KI.frm.stage_serial.BaudRate = (int)230400;// 921600  460800 230400
			KI.frm.stage_serial.DataBits = (int)8;
			KI.frm.stage_serial.Parity = Parity.None;
			KI.frm.stage_serial.StopBits = StopBits.One;
			KI.frm.stage_serial.ReadTimeout = 2000;
			KI.frm.stage_serial.ReadBufferSize = 128 * 1024 + 50;
			KI.frm.stage_serial.WriteBufferSize = 128 * 1024 + 50;
		}
		
		public static string Stage_Check_temp;
		public static string Stage_Check_buff;
		public static void check_stage(object sender, System.EventArgs e)
		{
			if (stage_conn == false)
			{
				if (check_send_count++ >= 5) // 1ms *100
				{
					check_send_count = 0;
					if (KI.frm.stage_serial.IsOpen)
						KI.frm.stage_serial.Close();

					KI.frm.stage_serial.PortName = Port_List[change_comport];
					try
					{
						KI.frm.stage_serial.Open();
						if (KI.frm.stage_serial.IsOpen)
						{
							stage_check(1);
							KI.frm.text_check_popup.Text = "Stage Connection Check";
						}
					}
					catch
					{
						check_send_count = 100;
					}

					if (change_comport++ >= Port_Count - 1)
					{
						Port_Count = 0;
						change_comport = 0;
						foreach (string comport in SerialPort.GetPortNames())
						{
							Port_List[Port_Count++] = comport;
						}
					}
				}

				if (KI.frm.stage_serial.IsOpen == true)
				{
					rx_stage();
				}
			}
		}
		static void rx_stage()
		{
			if (KI.frm.stage_serial.BytesToRead == 0)
			{
				Stage_Check_temp = Stage_Check_buff = "";
			}
			else if (KI.frm.stage_serial.BytesToRead != 0)
			{
				try
				{
					Stage_Check_temp = KI.frm.stage_serial.ReadTo("ETX");  // ext find
					Stage_Check_temp += "ETX";
				}
				catch (Exception)
				{
					KI.frm.stage_serial.DiscardInBuffer(); // rx buf init
					Stage_Check_temp = Stage_Check_buff = "";
				}

				int stx_idx = Stage_Check_temp.IndexOf("STX");    // STX 시작 배열 찾기
				int etx_idx = Stage_Check_temp.IndexOf("ETX");        // EXT 시작 배열 찾기

				if ((stx_idx <= 1) && (etx_idx > -1))
				{
					try
					{
						Stage_Check_buff = Stage_Check_temp;
						Stage_Check_temp = "";
						string[] rx_buff = Stage_Check_buff.Split(',');
						char[] stx = rx_buff[0].ToCharArray();
						char[] ext = rx_buff[2].ToCharArray();
						byte[] rx_data = util.ToByteArray(rx_buff[1]);

						int checksum_cal = 0, checksum_rx = 0;

						byte nType = 0;
						int data_length = 0;
						byte[] valid_data = new byte[128 * 1024];
						valid_data.Initialize();

						nType = (byte)rx_data[0];
						data_length = (int)(((byte)rx_data[1] << 8) + ((byte)rx_data[2]));
						checksum_rx = (int)(((byte)rx_data[data_length + 3] << 8) + ((byte)rx_data[data_length + 4]));
						checksum_cal = 0;

						for (int cnt = 0; cnt < data_length; cnt++)
						{
							valid_data[cnt] = (byte)rx_data[cnt + 3];
							checksum_cal += valid_data[cnt];
						}
						checksum_cal = checksum_cal & 0xFFFF;

						if (checksum_rx != checksum_cal)
						{
							util.dbgmsg("RX Data Checksum NG");
							return;
						}
						else
						{
							nType_Check(nType, data_length, valid_data);
						}
					}
					catch
					{
						return;
					}
				}
			}
		}
		public static string stage_ver = "";
		public static int x_pos = 0;
		public static int y_pos = 0;
		public static int t_pos = 0;
		public static byte home_sen_x = 0;
		public static byte home_sen_y = 0;
		public static byte home_sen_t = 0;
		public static byte limit_sen_x = 0;
		public static byte limit_sen_y = 0;
		public static byte limit_sen_t = 0;

		static void nType_Check(byte nType, int length, byte[] data)
		{
			switch (nType)
			{
				case (BOARD_STATE):
					string[] ver = util.ByteToString(data).Split(',');
					if (ver[0] == "MV")
					{
						stage_rx_flag = true;
						stage_rx_result = Convert.ToByte(ver[1]);

						x_pos = Convert.ToInt16(ver[2]);
						y_pos = Convert.ToInt16(ver[3]);
						t_pos = Convert.ToInt16(ver[4]);
						///////
						home_sen_x = Convert.ToByte(ver[5]);
						home_sen_y = Convert.ToByte(ver[6]);
						home_sen_t = Convert.ToByte(ver[7]);
						///////
						limit_sen_x = Convert.ToByte(ver[8]);
						limit_sen_y = Convert.ToByte(ver[9]);
						limit_sen_t = Convert.ToByte(ver[10]);

						KI.frm.text_loc_x.Text = x_pos.ToString();    // home
						KI.frm.text_loc_t.Text = t_pos.ToString();    // home
						KI.frm.text_loc_y.Text = y_pos.ToString();    // home

						if (home_sen_x == 0)
						{
							KI.frm.text_loc_x.BackColor = Color.DarkBlue;
						}
						else
						{
							KI.frm.text_loc_x.BackColor = Color.Black;
						}
						if (home_sen_y == 0)
						{
							KI.frm.text_loc_y.BackColor = Color.DarkBlue;

						}
						else
						{
							KI.frm.text_loc_y.BackColor = Color.Black;

						}
						if (home_sen_t == 0)
						{
							KI.frm.text_loc_t.BackColor = Color.DarkBlue;

						}
						else
						{
							KI.frm.text_loc_t.BackColor = Color.Black;
						}
					}
					else if (ver[0] == "OK")
					{
						stage_ver = ver[0];
						x_pos = Convert.ToInt16(ver[2]);
						y_pos = Convert.ToInt16(ver[3]);
						t_pos = Convert.ToInt16(ver[4]);
						///////
						home_sen_x = Convert.ToByte(ver[5]);
						home_sen_y = Convert.ToByte(ver[6]);
						home_sen_t = Convert.ToByte(ver[7]);
						///////
						limit_sen_x = Convert.ToByte(ver[8]);
						limit_sen_y = Convert.ToByte(ver[9]);
						limit_sen_t = Convert.ToByte(ver[10]);

						KI.frm.text_loc_x.Text = x_pos.ToString();    // home
						KI.frm.text_loc_t.Text = t_pos.ToString();    // home
						KI.frm.text_loc_y.Text = y_pos.ToString();    // home

						if (home_sen_x == 0)
						{
							KI.frm.text_loc_x.BackColor = Color.DarkBlue;
						}
						else
						{
							KI.frm.text_loc_x.BackColor = Color.Black;
						}
						if (home_sen_y == 0)
						{
							KI.frm.text_loc_y.BackColor = Color.DarkBlue;

						}
						else
						{
							KI.frm.text_loc_y.BackColor = Color.Black;

						}						
						if (home_sen_t == 0)
						{
							KI.frm.text_loc_t.BackColor = Color.DarkBlue;

						}
						else
						{
							KI.frm.text_loc_t.BackColor = Color.Black;
						}	
						///////
						stage_conn = true;
						KI.frm.text_check_popup.Text = "";
						util.dbgmsg("Stage Connection : " + KI.frm.stage_serial.PortName);
						KI.frm.Stage_Port.Text = "STAGE : " + KI.frm.stage_serial.PortName;
						KI.frm.Stage_Port.BackColor = Color.LightGreen;
						
						KI.frm.text_x_jog.Text = Properties.Settings.Default.stage_jog_x;
						KI.frm.text_y_jog.Text = Properties.Settings.Default.stage_jog_y;
						KI.frm.text_t_jog.Text = Properties.Settings.Default.stage_jog_t;
						
						stage_rx_flag = true;
						stage_rx_result = 1;

						move_all_center();
						move_home(y_axis);
					}
					else if (ver[0] == "NG")
					{
						stage_conn = false;
						stage_check(1);
					}
					break;
			}
		}
		#endregion


		static bool stage_rx_flag = false;
		static byte stage_rx_result = 0;
		static byte stage_wait()
		{
			int timecnt = 0;

			while (!stage_rx_flag)
			{
				rx_stage();

				if (timecnt++ > 1500) // 1ms * 500
				{
					MessageBox.Show("Stage Timeout", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

					break;
				}
				util.delay(1);
			}

			util.delay(100);

			return stage_rx_result;
		}

		public static byte move_jog(int xpulse, int ypulse, int tpulse)
		{
			stage_rx_flag = false;
			stage_rx_result = 0;

			byte[] tx_buff = new byte[10];
			tx_buff[0] = (byte)((xpulse >> 8)& 0xff);  // length high
			tx_buff[1] = (byte)((xpulse >> 0)& 0xff);  // length low
			tx_buff[2] = (byte)((ypulse >> 8)& 0xff);  // length high
			tx_buff[3] = (byte)((ypulse >> 0)& 0xff);  // length low
			tx_buff[4] = (byte)((tpulse >> 8)& 0xff);  // length high
			tx_buff[5] = (byte)((tpulse >> 0)& 0xff);  // length low
			tx_bd(MOVE_JOG, 6, tx_buff);
			
			return stage_wait();
		}

		public static byte move_home(byte stage)
		{
			stage_rx_flag = false;
			stage_rx_result = 0;

			byte[] tx_buff = new byte[10];
			tx_buff[0] = stage;
			tx_bd(MOVE_HOME, 1, tx_buff);

			return stage_wait();
		}

		public static void move_all_home()
		{
			if (move_home(x_axis) == 0)
			{
				MessageBox.Show("x home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (move_home(y_axis) == 0)
			{
				MessageBox.Show("y home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (move_home(t_axis) == 0)
			{
				MessageBox.Show("t home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static void move_all_center()
		{
			if (move_home(x_axis) == 0)
			{
				MessageBox.Show("x home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				util.delay(100);
				move_jog(Math.Abs(Properties.Settings.Default.stage_center_x), 0, 0);
			}

			if (move_home(y_axis) == 0)
			{
				MessageBox.Show("y home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				util.delay(100);
				move_jog(0, Math.Abs(Properties.Settings.Default.stage_center_y), 0);
			}

			if (move_home(t_axis) == 0)
			{
				util.delay(100);
				MessageBox.Show("t home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				move_jog(0, 0, Math.Abs(Properties.Settings.Default.stage_center_t));
			}
		}

		public const int t_align_retry = 5;

		public static bool move_t_align_match()
		{
			int timeout = t_align_retry;
			int dist = 0;

			while (true)
			{
				if(vision.oneshot_aling_estimation()==true)
				{
					if (Math.Abs(vision.t1_pulse) < vision.t1_margin)
					{
						break;
					}
					else
					{
						dist = vision.t1_pulse * Properties.Settings.Default.stage_dir_t;
						stage.move_jog(0, 0, dist);
						KI.frm.Refresh();
					}
				}
				util.dbgmsg(string.Format("retry t-axis {0}", timeout));
			
				if (timeout-- == 0)
				{
					return false;
				}
			}		
			return true;
		}
		public const int xy_align_retry = 5;
		public static bool move_xy_align_match()
		{
			int timeout = xy_align_retry;
			int dist1 = 0;
			int dist2 = 0;

			KI.frm.Refresh();
			while (true)
			{
				if (vision.oneshot_aling_estimation() == true)
				{
					if ((Math.Abs(vision.x1_pulse) < vision.x1_margin) && (Math.Abs(vision.y1_pulse) < vision.y1_margin))
					{
						break;
					}
					else
					{
						dist1 = vision.x1_pulse * Properties.Settings.Default.stage_dir_x;
						dist2 = vision.y1_pulse * Properties.Settings.Default.stage_dir_y;
						stage.move_jog(dist1, dist2, 0);
						KI.frm.Refresh();
					}
				}
				
				if (timeout-- == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static bool align_match()
		{
			util.delay(250);
			bool ret = false;
			//KI.frm.vision_timer.Stop();

			if (Properties.Settings.Default.dual_cam == true)
			{
				if (stage.move_t_align_match() == true)
				{
					if (stage.move_xy_align_match() == true)
					{
						util.dbgmsg("Align Match OK");
						ret = true;
					}
					else
					{
						util.dbgmsg("Align Match NG(xy)");
					}
				}
				else
				{
					util.dbgmsg("Align Match NG(t)");
				}
			}
			else
			{
				if (stage.move_xy_align_match() == true)
				{
					util.dbgmsg("Align Match OK");
					ret = true;
				}
				else
				{
					util.dbgmsg("Align Match NG");
				}
			}
			//KI.frm.vision_timer.Start();
			return ret;
		}		
	}
}
