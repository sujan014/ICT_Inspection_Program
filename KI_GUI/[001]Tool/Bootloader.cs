using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KI_GUI
{
	class boot
	{

		const byte TRUE = 1, FALSE = 0, CLEAR = 2;

		static string temp = "";
		static string buff = "";
		static bool board_rx_flag = false;
		static byte board_rx_result = 0;
		static int timeout = 0;
		static void rx_board_data()
		{
			if (KI.frm.bd_serial.BytesToRead == 0)
			{
				temp = buff = "";
			}
			else if (KI.frm.bd_serial.BytesToRead != 0)
			{
				try
				{
					temp = KI.frm.bd_serial.ReadTo("ETX");  // ext find
					temp += "ETX";
				}
				catch (Exception ex)
				{
					KI.frm.bd_serial.DiscardInBuffer(); // rx buf init
					temp = buff = "";
					util.dbgmsg("Rx Data Error:" + ex);
				}

				int stx_idx = temp.IndexOf("STX");    // STX 시작 배열 찾기
				int etx_idx = temp.IndexOf("ETX");        // EXT 시작 배열 찾기

				if ((stx_idx <= 1) && (etx_idx > -1))
				{
					try
					{
						buff = temp;
						temp = "";
						string[] rx_buff = buff.Split(',');
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
							parsing_ntype(nType, data_length, valid_data);
						}
					}
					catch
					{
						return;
					}
				}
				else
				{
					temp = "";  // 입력 값 초기화
					buff = "";  // Sum값 초기화
				}
			}
		}
		static void parsing_ntype(byte nType, int length, byte[] data)
		{
			switch (nType)
			{
				case (ntype.FULL_ERASE):
					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_fw.Text = string.Format(" - FULL Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;
				case (ntype.FW_DATA_ERASE):
					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_fw.Text = string.Format(" - F/W Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;
				case (ntype.FW_DATA_WR):
					int curpage = (int)(((byte)data[0] << 8) + ((byte)data[1]));
					int totalpage = (int)(((byte)data[2] << 8) + ((byte)data[3]));
					KI.frm.text_fw.Text = string.Format(" - F/W Write {0}kB /{1}kB ", curpage, totalpage);
					KI.frm.Refresh();

					board_rx_flag = true;
					board_rx_result = TRUE;
					break;
				case (ntype.FW_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
			}
		}
		static byte board_wait()
		{
			timeout = 0;
			while (!board_rx_flag)
			{
				rx_board_data();

				//if (timeout++ > 500) // 1ms * 500
				if (timeout++ > 1500)
				{
					MessageBox.Show("F/W Wrtie Timeout", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				}
				util.delay(1);
			}
			return board_rx_result;
		}
		public static void run_mode_change(byte flag)
		{
			byte[] tx_buff = new byte[10];
			tx_buff[0] = flag;
			serial.tx_bd(ntype.RUN_MODE, 1, tx_buff);
		}

		public const string fw_path = @"C:\KI\Spec\00.SYS_FILE\";
		public static int fw_size = 0;
		public static UInt32 fw_crc32 = 0;
		public static UInt32 board_crc32 = 0;
		public static string fw_name = "F/W File Name";
		public static byte[] FW_DATA = new byte[512 * 1024];

		public static void fw_read(string filename)
		{
			FileStream fs = new FileStream(fw_path + filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			fw_name = filename;
			fw_size = (int)fs.Length;
			FW_DATA = br.ReadBytes(fw_size);

			br.Close();
			fs.Close();
		}

		public static bool fw_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\00.SYS_FILE"))
			{
				int file_number = 0;
				string FileName = "";
				KI.frm.text_fw.Text = "";
				try
				{
					DirectoryInfo di = new DirectoryInfo(fw_path);
					foreach (FileInfo File in di.GetFiles())
					{
						if (file_number == 0)
						{
							FileName = File.Name;
						}
						file_number++;
					}

					if (file_number == 1)
					{
						fw_read(FileName);

						fw_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
						for (int i = 0; i < fw_size; i++)
						{
							fw_crc32 = util.crc32_table[(fw_crc32 >> 24) ^ FW_DATA[i]] ^ (fw_crc32 << 8);
						}

						KI.frm.text_fw.AppendText(String.Format(" - " + fw_name));
						KI.frm.text_fw.AppendText(Environment.NewLine);
						KI.frm.text_fw.AppendText(String.Format(" - Size : {0:F2} kB", fw_size / 1024));
						KI.frm.text_fw.AppendText(Environment.NewLine);
						KI.frm.text_fw.AppendText(String.Format(" - CRC32 : {0:X}", fw_crc32));
					}
					else
					{
						fw_size = 0;
						fw_crc32 = 0;
						fw_name = "F/W File Name";

						KI.frm.text_fw.AppendText(String.Format(" - " + fw_name));
						KI.frm.text_fw.AppendText(Environment.NewLine);
						KI.frm.text_fw.AppendText(String.Format(" - Size : {0:F2} kB", fw_size / 1024));
						KI.frm.text_fw.AppendText(Environment.NewLine);
						KI.frm.text_fw.AppendText(String.Format(" - CRC32 : {0:X}", fw_crc32));
						MessageBox.Show("F/W Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				catch
				{
					fw_size = 0;
					fw_crc32 = 0;
					fw_name = "F/W File Name";

					KI.frm.text_fw.AppendText(String.Format(" - " + fw_name));
					KI.frm.text_fw.AppendText(Environment.NewLine);
					KI.frm.text_fw.AppendText(String.Format(" - Size : {0:F2} kB", fw_size / 1024));
					KI.frm.text_fw.AppendText(Environment.NewLine);
					KI.frm.text_fw.AppendText(String.Format(" - CRC32 : {0:X}", fw_crc32));
					MessageBox.Show("F/W Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			else
			{
				util.dbgmsg("No F/W folder");
				MessageBox.Show("No F/W folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}





		#region Input Data WRITE BOARD(PC->Board)

		static byte fw_data_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.FW_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte fw_data_write_board()
		{
			byte[] tx_buff = new byte[1024 + 6];
			int page = fw_size / 1024;
			util.dbgmsg("name : " + fw_name);
			util.dbgmsg(string.Format("size : {0}", fw_size));

			int tx_size = 1024;
			for (int cnt = 0; cnt <= page; cnt++)
			{
				tx_buff[0] = (byte)(((cnt) >> 8) & 0xff);
				tx_buff[1] = (byte)(((cnt) >> 0) & 0xff);
				tx_buff[2] = (byte)((page >> 8) & 0xff);
				tx_buff[3] = (byte)((page >> 0) & 0xff);
				tx_buff[4] = (byte)((tx_size >> 8) & 0xff);
				tx_buff[5] = (byte)((tx_size >> 0) & 0xff);

				for (int i = 0; i < tx_size; i++)
				{
					if ((i + (cnt * tx_size)) < fw_size)
					{
						tx_buff[6 + i] = FW_DATA[i + (cnt * tx_size)];
					}
					else
					{
						tx_buff[6 + i] = 0xff;
					}
				}

				board_rx_flag = false;
				board_rx_result = 0;

				serial.tx_bd(ntype.FW_DATA_WR, 1024 + 6, tx_buff);

				if (board_wait() == FALSE) return FALSE;
			}
			return TRUE;
		}
		static byte fw_data_finsh_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string year = DateTime.Now.ToString("yy");
			string month = DateTime.Now.ToString("MM");
			string day = DateTime.Now.ToString("dd");
			string hour = DateTime.Now.ToString("hh");
			string minute = DateTime.Now.ToString("mm");
			string second = DateTime.Now.ToString("ss");

			string tx_temp = year + "," + month + "," + day + "," + hour + "," + minute + ",";
			tx_temp += fw_size.ToString() + ",";
			tx_temp += fw_name + ",";
			tx_temp += fw_crc32.ToString("X") + ",";

			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.FW_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}

		public static bool bd_fw_data_write()
		{
			if (fw_data_earse_board() == FALSE)
			{
				MessageBox.Show("Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_fw.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (fw_data_write_board() == FALSE)
			{
				MessageBox.Show("F/W Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_fw.Text = " - F/W Data Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (fw_data_finsh_board() == FALSE)
			{
				MessageBox.Show("F/W Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_fw.Text = " - F/W Data Finsh OK";
			KI.frm.Refresh();

			return true;
		}

		public static byte full_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.FULL_ERASE, 0, tx_buff);
			return board_wait();
		}

		#endregion

	}
}
