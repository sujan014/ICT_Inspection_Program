using System;
using System.Windows.Forms;

namespace KI_GUI
{
	class specwrite
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;
		
		#region SPEC WRITE FLOW(PC -> Board)
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
				case (ntype.SPEC_SAVE_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_SPEC_ERASE):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_PROJECT_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_TESTPOINT_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_OPEN_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_SHORTBS_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_SHORTEX_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_PART_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.ICT_FUNC_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.OP_MODE1_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.OP_MODE2_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.OP_MODE3_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.OP_MODE4_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.OP_INIT_WR):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				/*case (ntype.PANEL_DATA_ERASE):
					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_panel.Text = string.Format(" - Panel Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;*/ //210514 MCH
				/*case (ntype.PANEL_DATA_WR):
					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_panel.Text = string.Format(" - Panel Write {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;*/ //210514 MCH
				case (ntype.PANEL_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				case (ntype.INPUT_DATA_ERASE):
				
					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_data.Text = string.Format(" - Data Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;
				case (ntype.INPUT_DATA_WR):
					int curpage = (int)(((byte)data[0] << 8) + ((byte)data[1]));
					int totalpage = (int)(((byte)data[2] << 8) + ((byte)data[3]));
					KI.frm.text_data.Text = string.Format(" - Data Write {0}kB / {1}kB", curpage, totalpage);
					KI.frm.Refresh();

					board_rx_flag = true;
					board_rx_result = TRUE;
					break;
				case (ntype.INPUT_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;

				case (ntype.PMIC_DATA_ERASE):

					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_pmic.Text = string.Format(" - PMIC Data Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;
				case (ntype.PMIC_DATA_WR):
					int curpmic = (int)(((byte)data[0] << 8) + ((byte)data[1]));
					int totalpmic = (int)(((byte)data[2] << 8) + ((byte)data[3]));
					KI.frm.text_pmic.Text = string.Format(" - Data Write {0}kB / {1}kB", curpmic, totalpmic);
					KI.frm.Refresh();

					board_rx_flag = true;
					board_rx_result = TRUE;
					break;
				case (ntype.PMIC_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;

				case (ntype.EEP_DATA_ERASE):

					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_eep.Text = string.Format(" - EEP Data Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;
				case (ntype.EEP_DATA_WR):
					int cureep = (int)(((byte)data[0] << 8) + ((byte)data[1]));
					int totaleep = (int)(((byte)data[2] << 8) + ((byte)data[3]));
					KI.frm.text_eep.Text = string.Format(" - EEP Write {0}kB / {1}kB", cureep, totaleep);
					KI.frm.Refresh();

					board_rx_flag = true;
					board_rx_result = TRUE;
					break;
				case (ntype.EEP_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;
				//--------------------------------------------------------------
				case (ntype.TPIC_DATA_WR):
					int curtpic = (int)(((byte)data[0] << 8) + ((byte)data[1]));
					int totaltpic = (int)(((byte)data[2] << 8) + ((byte)data[3]));
					KI.frm.text_pmic.Text = string.Format(" - TPIC Write {0}kB / {1}kB", curtpic, totaltpic);
					KI.frm.Refresh();

					board_rx_flag = true;
					board_rx_result = TRUE;
					break;
				case (ntype.TPIC_DATA_FINSH):
					board_rx_flag = true;
					board_rx_result = data[0];
					break;

				case (ntype.TPIC_DATA_ERASE):

					if (data[0] == data[1])
					{
						board_rx_flag = true;
						board_rx_result = TRUE;
					}
					else
					{
						timeout = 0;
						KI.frm.text_pmic.Text = string.Format(" - TPIC Data Erase {0}/{1}", data[0], data[1]);
						KI.frm.Refresh();
					}
					break;

					//default: MessageBox.Show("parsing ntype error", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);break;
			}
		}
		static byte board_wait()
		{
			timeout = 0;
			while (!board_rx_flag)
			{
				rx_board_data();

				//if (timeout++ > 500) // 1ms * 500
				if (timeout++ > 1500) // 1ms * 500
				{
					MessageBox.Show("Spec Wrtie Timeout", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				}
				util.delay(1);
			}
			return board_rx_result;
		}
		#endregion
		
		#region ICT Spec WRITE BOARD(PC->Board)	
		static byte ict_spec_finsh_board()
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
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.SPEC_SAVE_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_spec_erase_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.ICT_SPEC_ERASE, 0, tx_buff);

			return board_wait();
		}
		static byte ict_info_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = "";
			tx_temp += specfile.project_name_main + ",";
			tx_temp += specfile.project_name_sub + ",";
			tx_temp += specfile.short_auto_pp.ToString() + ",";
			tx_temp += specfile.short_auto_mm.ToString() + ",";
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_PROJECT_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_tp_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.tp_count.ToString() + ",";
			for (int i = 0; i < specfile.tp_count; i++)
			{
				tx_temp += specfile.tp_name[i] + ",";
				tx_temp += specfile.tp_number[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_TESTPOINT_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_open_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.open_count.ToString() + ",";
			for (int i = 0; i < specfile.open_count; i++)
			{
				tx_temp += specfile.open_tp1[i].ToString() + ",";
				tx_temp += specfile.open_tp2[i].ToString() + ",";
				tx_temp += specfile.open_range[i].ToString() + ",";
				tx_temp += specfile.open_spec[i].ToString() + ",";
				tx_temp += specfile.open_ok_cnt[i].ToString() + ",";
				tx_temp += specfile.open_ng_cnt[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_OPEN_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_shortbs_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.short_bs_count.ToString() + ",";
			for (int i = 0; i < specfile.short_bs_count; i++)
			{
				tx_temp += specfile.short_bs_tp[i].ToString() + ",";
				tx_temp += specfile.short_bs_group[i].ToString() + ",";
				if (i == 0)
				{
					tx_temp += specfile.short_bs_range.ToString() + ",";
					tx_temp += specfile.short_bs_spec.ToString() + ",";
					tx_temp += specfile.short_bs_ok_cnt.ToString() + ",";
					tx_temp += specfile.short_bs_ng_cnt.ToString() + ",";
				}
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_SHORTBS_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_shortex_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.short_ex_count.ToString() + ",";
			for (int i = 0; i < specfile.short_ex_count; i++)
			{
				tx_temp += specfile.short_ex_tp1[i].ToString() + ",";
				tx_temp += specfile.short_ex_tp2[i].ToString() + ",";
				tx_temp += specfile.short_ex_range[i].ToString() + ",";
				tx_temp += specfile.short_ex_spec[i].ToString() + ",";
				tx_temp += specfile.short_ex_ok_cnt[i].ToString() + ",";
				tx_temp += specfile.short_ex_ng_cnt[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_SHORTEX_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_part_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.part_count.ToString() + ",";
			for (int i = 0; i < specfile.part_count; i++)
			{
				tx_temp += specfile.part_name[i] + ",";
				tx_temp += specfile.part_tp1[i].ToString() + ",";
				tx_temp += specfile.part_tp2[i].ToString() + ",";
				tx_temp += specfile.part_range[i].ToString() + ",";
				tx_temp += specfile.part_spec_hi[i].ToString() + ",";
				tx_temp += specfile.part_spec_lo[i].ToString() + ",";
				tx_temp += specfile.part_ok_cnt[i].ToString() + ",";
				tx_temp += specfile.part_ng_cnt[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_PART_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte ict_func_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.func_count.ToString() + ",";
			for (int i = 0; i < specfile.func_count; i++)
			{
				tx_temp += specfile.func_name[i] + ",";
				tx_temp += specfile.func_type[i].ToString() + ",";
				tx_temp += specfile.func_module[i].ToString() + ",";
				tx_temp += specfile.func_log_flag[i].ToString() + ",";
				tx_temp += specfile.func_panel_link[i].ToString() + ",";
				tx_temp += specfile.func_spec_dec[i].ToString() + ",";
				tx_temp += specfile.func_spec_hex[i, 0].ToString() + ",";
				tx_temp += specfile.func_spec_hex[i, 1].ToString() + ",";
				tx_temp += specfile.func_spec_hex[i, 2].ToString() + ",";
				tx_temp += specfile.func_spec_hex[i, 3].ToString() + ",";
				tx_temp += specfile.func_spec_float[i].ToString() + ",";
				tx_temp += specfile.func_spec_ascii[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.ICT_FUNC_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte op_mode1_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.mode1_sequence.ToString() + ",";
			tx_temp += specfile.mode1_name + ",";
			for (int i = 0; i < specfile.mode1_sequence; i++)
			{
				tx_temp += specfile.mode1_operation[i].ToString() + ",";
				tx_temp += specfile.mode1_number[i].ToString() + ",";
				tx_temp += specfile.mode1_status[i].ToString() + ",";
				tx_temp += specfile.mode1_time[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.OP_MODE1_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte op_mode2_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.mode2_sequence.ToString() + ",";
			tx_temp += specfile.mode2_name + ",";
			for (int i = 0; i < specfile.mode2_sequence; i++)
			{
				tx_temp += specfile.mode2_operation[i].ToString() + ",";
				tx_temp += specfile.mode2_number[i].ToString() + ",";
				tx_temp += specfile.mode2_status[i].ToString() + ",";
				tx_temp += specfile.mode2_time[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.OP_MODE2_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte op_mode3_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.mode3_sequence.ToString() + ",";
			tx_temp += specfile.mode3_name + ",";
			for (int i = 0; i < specfile.mode3_sequence; i++)
			{
				tx_temp += specfile.mode3_operation[i].ToString() + ",";
				tx_temp += specfile.mode3_number[i].ToString() + ",";
				tx_temp += specfile.mode3_status[i].ToString() + ",";
				tx_temp += specfile.mode3_time[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.OP_MODE3_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte op_mode4_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.mode4_sequence.ToString() + ",";
			tx_temp += specfile.mode4_name + ",";
			for (int i = 0; i < specfile.mode4_sequence; i++)
			{
				tx_temp += specfile.mode4_operation[i].ToString() + ",";
				tx_temp += specfile.mode4_number[i].ToString() + ",";
				tx_temp += specfile.mode4_status[i].ToString() + ",";
				tx_temp += specfile.mode4_time[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.OP_MODE4_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte op_init_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.init_sequence.ToString() + ",";
			tx_temp += specfile.init_name + ",";
			for (int i = 0; i < specfile.init_sequence; i++)
			{
				tx_temp += specfile.init_operation[i].ToString() + ",";
				tx_temp += specfile.init_number[i].ToString() + ",";
				tx_temp += specfile.init_status[i].ToString() + ",";
				tx_temp += specfile.init_time[i].ToString() + ",";
			}
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.OP_INIT_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		public static bool bd_ict_spec_write()
		{
			if (ict_spec_erase_board() == FALSE)
			{
				MessageBox.Show("Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_info_write_board() == FALSE)
			{
				MessageBox.Show("Info Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Info Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_tp_write_board() == FALSE)
			{
				MessageBox.Show("TP Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - TP Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_open_write_board() == FALSE)
			{
				MessageBox.Show("Open Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Open Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_shortbs_write_board() == FALSE)
			{
				MessageBox.Show("Short Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Short Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_shortex_write_board() == FALSE)
			{
				MessageBox.Show("Short Ex Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Short Ex Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_part_write_board() == FALSE)
			{
				MessageBox.Show("Part Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Part Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_func_write_board() == FALSE)
			{
				MessageBox.Show("Func Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Func Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (op_mode1_write_board() == FALSE)
			{
				MessageBox.Show("Mode1 Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Mode1 Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (op_mode2_write_board() == FALSE)
			{
				MessageBox.Show("Mode2 Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Mode2 Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (op_mode3_write_board() == FALSE)
			{
				MessageBox.Show("Mode3 Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Mode3 Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (op_mode4_write_board() == FALSE)
			{
				MessageBox.Show("Mode4 Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Mode4 Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (op_init_write_board() == FALSE)
			{
				MessageBox.Show("Init Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Init Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (ict_spec_finsh_board() == FALSE)
			{
				MessageBox.Show("Finsh Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_ict.Text = " - Finsh Write OK";
			KI.frm.Refresh();

			util.delay(50);

			return true;
		}
		#endregion
		
		#region Panel Spec WRITE BOARD(PC->Board)
		static byte panel_spec_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.PANEL_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte panel_spec_write_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			string tx_temp = specfile.panel_count.ToString() + ",";
			for (int cnt = 0; cnt < specfile.panel_count; cnt++)
			{
				tx_temp += specfile.panel_tx_num[cnt].ToString() + ",";
				tx_temp += specfile.panel_rx_num[cnt].ToString() + ",";
				int node = 0;
				for (int tx = 0; tx < specfile.panel_tx_num[cnt]; tx++)
				{
					for (int rx = 0; rx < specfile.panel_rx_num[cnt]; rx++)
					{
						tx_temp += specfile.panel_min[cnt, node].ToString() + ",";
						node++;
					}
				}
				node = 0;
				for (int tx = 0; tx < specfile.panel_tx_num[cnt]; tx++)
				{
					for (int rx = 0; rx < specfile.panel_rx_num[cnt]; rx++)
					{
						tx_temp += specfile.panel_max[cnt, node].ToString() + ",";
						node++;
					}
				}
			}
			byte[] tx_buff = util.StringToByte(tx_temp);
			serial.tx_bd(ntype.PANEL_DATA_WR, tx_buff.Length, tx_buff);

			return board_wait();
		}
		static byte panel_spec_finsh_board()
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
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.PANEL_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}
		/*public static bool bd_panel_spec_write()
		{
			if (panel_spec_earse_board() == FALSE)
			{
				MessageBox.Show("Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_panel.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (panel_spec_write_board() == FALSE)
			{
				MessageBox.Show("Panel Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_panel.Text = " - Panel Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (panel_spec_finsh_board() == FALSE)
			{
				MessageBox.Show("Panel Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_panel.Text = " - Panel Finsh OK";
			KI.frm.Refresh();

			return true;
		}*/ //210514 MCH
		#endregion


		#region Input Data WRITE BOARD(PC->Board)

		static byte input_data_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.INPUT_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte input_data_write_board()
		{
			byte[] tx_buff = new byte[1024+6];
			int page = specfile.data_size / 1024;
			util.dbgmsg("name : "+ specfile.data_name);
			util.dbgmsg(string.Format("size : {0}", specfile.data_size));

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
					if((i + (cnt * tx_size)) < specfile.data_size)
					{
						tx_buff[6 + i] = specfile.INPUT_DATA[i + (cnt * tx_size)];
					}
					else
					{
						tx_buff[6 + i] = 0xff;
					}
				}

				board_rx_flag = false;
				board_rx_result = 0;

				serial.tx_bd(ntype.INPUT_DATA_WR, 1024+6, tx_buff);

				if (board_wait() == FALSE) return FALSE;
			}
			return TRUE;
		}
		static byte input_data_finsh_board()
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
			tx_temp += specfile.data_size.ToString() + ",";
			tx_temp += specfile.data_name + ",";
			tx_temp += specfile.data_crc32.ToString("X") + ",";
			
			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.INPUT_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}

		public static bool bd_input_data_write()
		{
			if (input_data_earse_board() == FALSE)
			{
				MessageBox.Show("Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_data.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (input_data_write_board() == FALSE)
			{
				MessageBox.Show("Input Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_data.Text = " - Input Data Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (input_data_finsh_board() == FALSE)
			{
				MessageBox.Show("Input Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_data.Text = " - Input Data Finsh OK";
			KI.frm.Refresh();

			return true;
		}

		#endregion

		#region PMIC Data WRITE BOARD(PC->Board)
		static byte pmic_data_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.PMIC_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte pmic_data_write_board()
		{
			byte[] tx_buff = new byte[1024 + 6];
			int page = specfile.pmic_size / 1024;
			util.dbgmsg("name : " + specfile.pmic_name);
			util.dbgmsg(string.Format("size : {0}", specfile.pmic_size));

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
					if ((i + (cnt * tx_size)) < specfile.pmic_size)
					{
						tx_buff[6 + i] = specfile.INPUT_PMIC[i + (cnt * tx_size)];
						//tx_buff[6 + i] = specfile.pmic_data[i + (cnt * tx_size)];
					}
					else
					{
						tx_buff[6 + i] = 0xff;
					}
				}

				board_rx_flag = false;
				board_rx_result = 0;

				serial.tx_bd(ntype.PMIC_DATA_WR, 1024 + 6, tx_buff);

				if (board_wait() == FALSE) return FALSE;
			}
			return TRUE;
		}
		static byte pmic_data_finsh_board()
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
			tx_temp += specfile.pmic_size.ToString() + ",";
			tx_temp += specfile.pmic_name + ",";
			tx_temp += specfile.pmic_crc32.ToString("X") + ",";

			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.PMIC_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}
		public static bool bd_pmic_data_write()
		{
			if (pmic_data_earse_board() == FALSE)
			{
				MessageBox.Show("PMIC Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (pmic_data_write_board() == FALSE)
			{
				MessageBox.Show("PMIC Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - PMIC Data Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (pmic_data_finsh_board() == FALSE)
			{
				MessageBox.Show("PMIC Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - PMIC Data Finsh OK";
			KI.frm.Refresh();

			//------------
            /*
			util.delay(50);
			if (tpic_data_earse_board() == FALSE)
			{
				MessageBox.Show("TPIC Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			util.delay(50);
			if (tpic_data_write_board() == FALSE)
			{
				MessageBox.Show("TPIC Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - TPIC Data Write OK";
			KI.frm.Refresh();
            
			util.delay(50);
			if (tpic_data_finsh_board() == FALSE)
			{
				MessageBox.Show("TPIC Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - TPIC Data Finsh OK";
			KI.frm.Refresh();
            */
			//-------------------------------- TPIC
			return true;
		}
		#endregion

		#region EEP Data WRITE BOARD(PC->Board)
		static byte eep_data_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.EEP_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte eep_data_write_board()
		{
			byte[] tx_buff = new byte[1024 + 6];
			int page = specfile.eep_size / 1024;
			util.dbgmsg("name : " + specfile.eep_name);
			util.dbgmsg(string.Format("size : {0}", specfile.eep_size));

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
					if ((i + (cnt * tx_size)) < specfile.eep_size)
					{
						tx_buff[6 + i] = specfile.INPUT_EEP[i + (cnt * tx_size)];
					}
					else
					{
						tx_buff[6 + i] = 0xff;
					}
				}

				board_rx_flag = false;
				board_rx_result = 0;

				serial.tx_bd(ntype.EEP_DATA_WR, 1024 + 6, tx_buff);

				if (board_wait() == FALSE) return FALSE;
			}
			return TRUE;
		}
		static byte eep_data_finsh_board()
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
			tx_temp += specfile.eep_size.ToString() + ",";
			tx_temp += specfile.eep_name + ",";
			tx_temp += specfile.eep_crc32.ToString("X") + ",";

			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.EEP_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}
		public static bool bd_eep_data_write()
		{
			if (eep_data_earse_board() == FALSE)
			{
				MessageBox.Show("EEPROM Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_eep.Text = " - Erase OK";
			KI.frm.Refresh();

			util.delay(50);
			if (eep_data_write_board() == FALSE)
			{
				MessageBox.Show("EEP Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_eep.Text = " - EEP Data Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (eep_data_finsh_board() == FALSE)
			{
				MessageBox.Show("EEP Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_eep.Text = " - EEP Data Finsh OK";
			KI.frm.Refresh();

			return true;
		}
		#endregion

		#region TPIC Data WRITE BOARD(PC->Board)
		static byte tpic_data_earse_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;
			serial.tx_bd(ntype.TPIC_DATA_ERASE, 0, tx_buff);
			return board_wait();
		}
		static byte tpic_data_write_board()
		{
			byte[] tx_buff = new byte[1024 + 6];
			int page = specfile.tpic_size / 1024;
			util.dbgmsg("name : " + specfile.tpic_name);
			util.dbgmsg(string.Format("size : {0}", specfile.tpic_size));

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
					if ((i + (cnt * tx_size)) < specfile.tpic_size)
					{
						tx_buff[6 + i] = specfile.INPUT_TPIC[i + (cnt * tx_size)];
						//tx_buff[6 + i] = specfile.pmic_data[i + (cnt * tx_size)];
					}
					else
					{
						tx_buff[6 + i] = 0xff;
					}
				}

				board_rx_flag = false;
				board_rx_result = 0;

				serial.tx_bd(ntype.TPIC_DATA_WR, 1024 + 6, tx_buff);

				if (board_wait() == FALSE) return FALSE;
			}
			return TRUE;
		}
		static byte tpic_data_finsh_board()
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
			tx_temp += specfile.tpic_size.ToString() + ",";
			tx_temp += specfile.tpic_name + ",";
			tx_temp += specfile.tpic_crc32.ToString("X") + ",";

			byte[] tx_buff = util.StringToByte(tx_temp);

			serial.tx_bd(ntype.TPIC_DATA_FINSH, tx_buff.Length, tx_buff);

			return board_wait();
		}
		public static bool bd_tpic_data_write()
		{
            if (tpic_data_earse_board() == FALSE)
            {
                MessageBox.Show("TPIC Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            util.delay(50);
            if (tpic_data_write_board() == FALSE)
			{
				MessageBox.Show("TPIC Data Write Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - TPIC Data Write OK";
			KI.frm.Refresh();

			util.delay(50);
			if (tpic_data_finsh_board() == FALSE)
			{
				MessageBox.Show("TPIC Data Finsh Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			KI.frm.text_pmic.Text = " - TPIC Data Finsh OK";
			KI.frm.Refresh();

			return true;
		}
		#endregion
	}
}
