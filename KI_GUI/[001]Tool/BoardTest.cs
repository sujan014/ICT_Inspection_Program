using System;
using System.Windows.Forms;

namespace KI_GUI
{
	class boardtest
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;

		#region BOARD TEST FLOW
		static string temp;
		static string buff;
		static bool board_rx_flag = false;
		static byte board_rx_result = 0;
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
				case (specfile.SOL_RUN):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.LED_VALUE):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
			}
		}
		static byte board_wait()
		{
			int timecnt = 0;
			while (!board_rx_flag)
			{
				rx_board_data();

				if (timecnt++ > 500) // 1ms * 500
				{
					MessageBox.Show("Board Control Timeout", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				}
				util.delay(1);
			}
			return board_rx_result;
		}

		#endregion

		public static byte board_sol_test(byte no, byte state, UInt16 time)
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[4];
			tx_buff[0] = no;
			tx_buff[1] = state;
			tx_buff[2] = (byte)((time >> 8) & 0xff);  // length high
			tx_buff[3] = (byte)((time >> 0) & 0xff);  // length low
			serial.tx_bd(specfile.SOL_RUN, 4, tx_buff);

			return board_wait();
		}

		public static byte board_led_test()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[4];
			tx_buff[0] = (byte)((Properties.Settings.Default.olb_led1) & 0xff); 
			tx_buff[1] = (byte)((Properties.Settings.Default.olb_led2) & 0xff); 
			tx_buff[2] = (byte)((Properties.Settings.Default.olb_led3) & 0xff); 
			tx_buff[3] = (byte)((Properties.Settings.Default.olb_led4) & 0xff); 		   
			serial.tx_bd(ntype.LED_VALUE, 4, tx_buff);

			return board_wait();
		}

	}
}
