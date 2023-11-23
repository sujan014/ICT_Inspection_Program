using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace KI_GUI
{
	class serial
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;
		#region TX Data Board(PC->Board)
		public static void tx_bd(byte nType, int length, byte[] data)
		{
			try
			{
				if (KI.frm.bd_serial.IsOpen == false)
					return;
                KI.frm.bd_serial.DiscardOutBuffer();
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
				KI.frm.bd_serial.Write(txbuff, 0, length + 13);
			}
			catch
			{
				//state_log.Text = "tx ng";
			}
		}
		#endregion

		#region TX
		public static void bd_check(byte flag)
		{
			byte[] tx_buff = new byte[10];
			tx_buff[0] = flag;
			tx_bd(ntype.CONN_CHECK, 1, tx_buff);
		}
		#endregion

		#region Init BOARD SERIAL
		public static int Port_Count = 0;
		public static string[] Port_List = new string[50];
		public static bool board_conn = false;
		public static int check_send_count = 0;
		public static int change_comport = 0;

		public static void bd_serial_init()
		{
			Port_Count = 0;
			foreach (string comport in SerialPort.GetPortNames())
			{
				Port_List[Port_Count++] = comport;
			}
			KI.frm.bd_serial.BaudRate = (int)460800;// 921600  460800 230400
			KI.frm.bd_serial.DataBits = (int)8;
			KI.frm.bd_serial.Parity = Parity.None;
			KI.frm.bd_serial.StopBits = StopBits.One;
			KI.frm.bd_serial.ReadTimeout = 2000;
			KI.frm.bd_serial.ReadBufferSize = 128 * 1024 + 50;
			KI.frm.bd_serial.WriteBufferSize = 128 * 1024 + 50;
		}

		#endregion

		#region RX BOARD DATA
		public static string BD_Check_temp;
		public static string BD_Check_buff;
		public static void check_board(object sender, System.EventArgs e)
		{
			//if (stage.stage_conn == false) return; 210513 MCH

			if (board_conn == false)
			{
				if (check_send_count++ >= 5) // 1ms *100
				{
					check_send_count = 0;
					if (KI.frm.bd_serial.IsOpen)
						KI.frm.bd_serial.Close();

					KI.frm.bd_serial.PortName = Port_List[change_comport];
					try
					{
						KI.frm.bd_serial.Open();
						if (KI.frm.bd_serial.IsOpen)
						{
							bd_check(1);
							KI.frm.text_check_popup.Text = "Board Connection Check";
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
			}
			if (KI.frm.bd_serial.IsOpen == true)
			{
				rx_check();
				key.boardkeycheck();
			}
		}
		static void rx_check()
		{
			if (KI.frm.bd_serial.BytesToRead == 0)
			{
				BD_Check_temp = BD_Check_buff = "";
			}
			else if (KI.frm.bd_serial.BytesToRead != 0)
			{
				try
				{
					BD_Check_temp = KI.frm.bd_serial.ReadTo("ETX");  // ext find
					BD_Check_temp += "ETX";
				}
				catch (Exception)
				{
					KI.frm.bd_serial.DiscardInBuffer(); // rx buf init
					BD_Check_temp = BD_Check_buff = "";
				}

				int stx_idx = BD_Check_temp.IndexOf("STX");    // STX 시작 배열 찾기
				int etx_idx = BD_Check_temp.IndexOf("ETX");        // EXT 시작 배열 찾기

				if ((stx_idx <= 1) && (etx_idx > -1))
				{
					try
					{
						BD_Check_buff = BD_Check_temp;
						BD_Check_temp = "";
						string[] rx_buff = BD_Check_buff.Split(',');
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
		static void nType_Check(byte nType, int length, byte[] data)
		{
			switch (nType)
			{
				case (ntype.CONN_CHECK):
					string[] ver = util.ByteToString(data).Split(',');

					if (ver[0] == "OK")
					{
						KI.frm.bd_ver_label.Text = KI.board_ver = ver[1];     // version
						KI.frm.bd_version.Text = KI.board_ver = ver[1];     // version
						KI.frm.text_boot_ver.Text = KI.board_ver = ver[1];     // version
						KI.frm.text_pj_data.Text = KI.board_sn = ver[2];    // serial number
						KI.boot_mode = ver[3]; // debug mode
						KI.debug_mode = Convert.ToByte(ver[4]); // debug mode
						
						KI.frm.text_log.Clear();
						util.dbgmsg("Board Connection : " + KI.frm.bd_serial.PortName);
						KI.frm.Board_Port.Text = "BOARD : " + KI.frm.bd_serial.PortName;
						KI.frm.Board_Port.BackColor = Color.LightGreen;
						board_conn = true;

						if (KI.boot_mode == KI.BOOT_FLAG)
						{
							boot.fw_read_file();

							KI.frm.run_mode_label.Text = "BOOT MODE";
							KI.frm.tab.SelectedIndex = KI.BOOT_DISP;
						}
						else if (KI.boot_mode == KI.APP_FLAG)
						{
							if (Properties.Settings.Default.ICT_Spec_Check == true)
							{
								if (specread.bd_ict_spec_read() == false)
								{
									KI.frm.text_ict.Text = "Board ICT Spec Read Fail";
								}
							}
							/*if (Properties.Settings.Default.Panel_Spec_Check == true)
							{
								if (specread.bd_panel_spec_read() == false)
								{
									KI.frm.text_panel.Text = "Board Panel Spec Read Fail";
								}
							}*/ //210514 MCH

							if (Properties.Settings.Default.Data_Check == true)
							{
								if (specread.bd_input_data_read() == false)
								{
									KI.frm.text_data.Text = "Board Input Data Read Fail";
								}
							}
							if (Properties.Settings.Default.Pmic_Check == true)
							{
								if (specread.bd_pmic_data_read_only() == false)
								{
									KI.frm.text_pmic.Text = "Board PMIC Data Read Fail";
								}
							}
                            if (Properties.Settings.Default.Tpic_Check == true)
                            {
                                if (specread.bd_tpic_data_read_only() == false)
                                {
                                    KI.frm.text_pmic.Text = "Board TPIC Data Read Fail";
                                }
                            }
                            if (Properties.Settings.Default.Eep_Check == true)
							{
								if (specread.bd_eep_data_read() == false)
								{
									KI.frm.text_eep.Text = "Board EEP Data Read Fail";
								}
							}
							KI.frm.run_mode_label.Text = "APP MODE";
							KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
						}
						KI.frm.text_check_popup.Text = "";
					}
					else if (ver[0] == "NG")
					{
						board_conn = false;

						KI.frm.tab.SelectedIndex = KI.CHECK_DISP;
						bd_check(1);
					}
					break;
				case (ntype.KEY_VALUE):
					key.KEY_RET = data[0];
					break;
				case (ntype.SAFE_VALUE):
					if (data[0] == 1)
					{
						Test.SensorCheck = false;
						KI.frm.sen_input.BackColor=Color.Red;
					}
					else if (data[0] == 0)
					{
						Test.SensorCheck = true;
						KI.frm.sen_input.BackColor=Color.LightGreen;						
					}
					break;
				case (ntype.SEN_VALUE):
					control.cly_sen_check(data[0]);
					break;
				case (ntype.QTY_VALUE):
					control.qty_count_write(data[0]);
					Test.test_result_flag = Convert.ToByte(data[0]);
					break;
				case (ntype.POPUP_DISP):
					KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
					string[] POP1 = util.ByteToString(data).Split(',');
					listview.sub_popup(Convert.ToByte(POP1[0]), POP1[1]);
					util.dbgmsg("POPUP_DISP(" + POP1[0] + "):" + POP1[1]);
					break;
				case (ntype.POPUP_RESULT):
					KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
					string[] POP2 = util.ByteToString(data).Split(',');
					listview.main_popup_result(Convert.ToByte(POP2[0]), Convert.ToByte(POP2[1]), POP2[2]);
					Test.test_result_flag = Convert.ToByte(POP2[1]);
					util.dbgmsg("POPUP_RESULT(" + POP2[0] + "):" + POP2[1] + "," + POP2[1]);
					break;
				case (ntype.STOP_WATCH):
					string[] STOP = util.ByteToString(data).Split(',');
					control.StopWatch(Convert.ToByte(STOP[0]));
					util.dbgmsg("STOP WATCH : " + STOP[0]);
					break;
					///////////////////
				case (ntype.LIST_RESULT):
					KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
					listview.listview_result(data);
					break;
				case (ntype.OPEN_STATE):
					string[] Op = util.ByteToString(data).Split(',');
					Test.Op_str_idx = Convert.ToUInt16(Op[0]);
					Test.Op_end_idx = Convert.ToUInt16(Op[1]);
					Test.op_auto_result = Convert.ToByte(Op[2]);
					Test.test_result_flag = Convert.ToByte(Op[3]);
					util.dbgmsg(String.Format("Open({0}-{1})-{2}", Test.Op_str_idx, Test.Op_end_idx, Test.op_auto_result));
					break;
				case (ntype.SHORT_STATE):
					string[] sh = util.ByteToString(data).Split(',');
					Test.Sh_str_idx = Convert.ToUInt16(sh[0]);
					Test.Sh_end_idx = Convert.ToUInt16(sh[1]);
					Test.sh_auto_result = Convert.ToByte(sh[2]);
					Test.test_result_flag = Convert.ToByte(sh[3]);
					util.dbgmsg(String.Format("Short({0}-{1})-{2}", Test.Sh_str_idx, Test.Sh_end_idx, Test.sh_auto_result));
					break;
				case (ntype.PART_STATE):
					string[] pt = util.ByteToString(data).Split(',');
					Test.Pt_str_idx = Convert.ToUInt16(pt[0]);
					Test.Pt_end_idx = Convert.ToUInt16(pt[1]);
					Test.pt_auto_result = Convert.ToByte(pt[2]);
					Test.test_result_flag = Convert.ToByte(pt[3]);
					util.dbgmsg(String.Format("Part({0}-{1})-{2}", Test.Pt_str_idx, Test.Pt_end_idx, Test.pt_auto_result));
					break;
				case (ntype.FUNC_STATE):
					string[] fn = util.ByteToString(data).Split(',');
					Test.Fn_str_idx = Convert.ToUInt16(fn[0]);
					Test.Fn_end_idx = Convert.ToUInt16(fn[1]);
					Test.fn_auto_result = Convert.ToByte(fn[2]);
					Test.test_result_flag = Convert.ToByte(fn[3]);
					util.dbgmsg(String.Format("Func({0}-{1})-{2}", Test.Fn_str_idx, Test.Fn_end_idx, Test.fn_auto_result));
					break;
				case (ntype.START_STATE):
					control.task_start_flow();
					util.dbgmsg("START Flow");
					break;

				case (ntype.END_STATE):
					control.task_end_flow(data);
					if (Test.test_result_flag == KI.TRUE)
						util.dbgmsg("END Flow PASS");
					else if (Test.test_result_flag == KI.FALSE)
						util.dbgmsg("END Flow FAIL");
					else if (Test.test_result_flag == KI.ESC_KEY)
						util.dbgmsg("END Flow ESC KEY");
					break;

				case (ntype.PANLE_DATA):
					testlog.panel_data_rx(data);
					break;
				case (ntype.SUMMARY_LOG):
					testlog.save_log(Test.test_result_flag);
					break;
				case (ntype.VISON_STATE):
					KI.frm.tab.SelectedIndex = KI.VISION_DISP;
					util.delay(250);
					KI.frm.Refresh();

					vision.align_watch.Restart();
				
					if (stage.align_match() == true)
					{
						listview.sub_popup(TRUE, "Align OK");

						KI.frm.bt_result_align1.Text = "Align Match OK";
						KI.frm.bt_result_align2.Text = "Align Match OK";
						KI.frm.bt_result_align1.BackColor = Color.Green;
						KI.frm.bt_result_align2.BackColor = Color.Green;
						
						if (data[0] == specfile.AUTO_STATE)
						{
							key.key_st1st2_send();
						}
					}
					else
					{
						listview.sub_popup(TRUE, "Align NG");

						KI.frm.bt_result_align1.Text = "Align Match NG";
						KI.frm.bt_result_align2.Text = "Align Match NG";
						KI.frm.bt_result_align1.BackColor = Color.Red;
						KI.frm.bt_result_align2.BackColor = Color.Red;

						if (data[0] == specfile.AUTO_STATE)
						{
							key.key_esc_send();
						}
					}

					vision.align_watch.Stop();
					util.dbgmsg(string.Format("Align Time : {0}ms", vision.align_watch.ElapsedMilliseconds));

					break;

				case (ntype.SEQ_STATE):

					if (data[0] == 0) // end
					{
						stage.move_home(stage.y_axis);
					}
					else if (data[0] == 1)  // start
					{
						stage.move_home(stage.y_axis);
						stage.move_jog(0, Properties.Settings.Default.stage_center_y, 0);
						listview.main_popup(0, "");
						listview.sub_popup(0, "");
					}
					break;
                case (ntype.MFS_VERIFY):
                    //MessageBox.Show("MFS_VERIFY");
                    melfas_usb.InitThread_Melfas();
                    melfas_usb.ModeChange_Read();
                    break;
                case (ntype.MFS_WRITE):
                    //MessageBox.Show("MFS_VERIFY");
                    melfas_usb.InitThread_Melfas();
                    melfas_usb.ModeChange_Write();
                    break;

            }
		}


		#endregion
	}
}
