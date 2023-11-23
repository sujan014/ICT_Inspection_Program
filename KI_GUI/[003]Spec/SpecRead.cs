using System;
using System.Windows.Forms;

namespace KI_GUI
{
	class specread
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;
		
		public static UInt32 info_crc = 0;
		public static UInt32 tp_crc = 0;
		public static UInt32 open_crc = 0;
		public static UInt32 short_crc = 0;
		public static UInt32 shortex_crc = 0;
		public static UInt32 part_crc = 0;
		public static UInt32 func_crc = 0;
		public static UInt32 mode1_crc = 0;
		public static UInt32 mode2_crc = 0;
		public static UInt32 mode3_crc = 0;
		public static UInt32 mode4_crc = 0;
		public static UInt32 init_crc = 0;
		public static UInt32 panel_crc = 0;

		#region SPEC READ FLOW(Board -> PC)
		static string temp = "";
		static string buff = "";
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
				catch (Exception)
				{
					KI.frm.bd_serial.DiscardInBuffer(); // rx buf init
					temp = buff = "";
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

		static byte ict_crc_check(byte[] data)
		{
			byte ret = TRUE;
			info_crc = (UInt32)(data[0] << 24); info_crc += (UInt32)(data[1] << 16);
			info_crc += (UInt32)(data[2] << 8); info_crc += (UInt32)(data[3] << 0);

			tp_crc = (UInt32)(data[4] << 24); tp_crc += (UInt32)(data[5] << 16);
			tp_crc += (UInt32)(data[6] << 8); tp_crc += (UInt32)(data[7] << 0);

			open_crc = (UInt32)(data[8] << 24); open_crc += (UInt32)(data[9] << 16);
			open_crc += (UInt32)(data[10] << 8); open_crc += (UInt32)(data[11] << 0);

			short_crc = (UInt32)(data[12] << 24); short_crc += (UInt32)(data[13] << 16);
			short_crc += (UInt32)(data[14] << 8); short_crc += (UInt32)(data[15] << 0);

			shortex_crc = (UInt32)(data[16] << 24); shortex_crc += (UInt32)(data[17] << 16);
			shortex_crc += (UInt32)(data[18] << 8); shortex_crc += (UInt32)(data[19] << 0);

			part_crc = (UInt32)(data[20] << 24); part_crc += (UInt32)(data[21] << 16);
			part_crc += (UInt32)(data[22] << 8); part_crc += (UInt32)(data[23] << 0);

			func_crc = (UInt32)(data[24] << 24); func_crc += (UInt32)(data[25] << 16);
			func_crc += (UInt32)(data[26] << 8); func_crc += (UInt32)(data[27] << 0);

			init_crc = (UInt32)(data[28] << 24); init_crc += (UInt32)(data[29] << 16);
			init_crc += (UInt32)(data[30] << 8); init_crc += (UInt32)(data[31] << 0);

			mode1_crc = (UInt32)(data[32] << 24); mode1_crc += (UInt32)(data[33] << 16);
			mode1_crc += (UInt32)(data[34] << 8); mode1_crc += (UInt32)(data[35] << 0);

			mode2_crc = (UInt32)(data[36] << 24); mode2_crc += (UInt32)(data[37] << 16);
			mode2_crc += (UInt32)(data[38] << 8); mode2_crc += (UInt32)(data[39] << 0);

			mode3_crc = (UInt32)(data[40] << 24); mode3_crc += (UInt32)(data[41] << 16);
			mode3_crc += (UInt32)(data[42] << 8); mode3_crc += (UInt32)(data[43] << 0);

			mode4_crc = (UInt32)(data[44] << 24); mode4_crc += (UInt32)(data[45] << 16);
			mode4_crc += (UInt32)(data[46] << 8); mode4_crc += (UInt32)(data[47] << 0);

			if (info_crc != specfile.info_crc32) { ret = FALSE; util.dbgmsg("Info NG"); }
			if (tp_crc != specfile.tp_crc32) { ret = FALSE; util.dbgmsg("Tp NG"); }
			if (open_crc != specfile.open_crc32) { ret = FALSE; util.dbgmsg("Open NG"); }
			if (short_crc != specfile.short_crc32) { ret = FALSE; util.dbgmsg("Short bs NG"); }
			if (shortex_crc != specfile.shortex_crc32) { ret = FALSE; util.dbgmsg("Short ex NG"); }
			if (part_crc != specfile.part_crc32) { ret = FALSE; util.dbgmsg("Part NG"); }
			if (func_crc != specfile.func_crc32) { ret = FALSE; util.dbgmsg("Func NG"); }
			if (init_crc != specfile.init_crc32) { ret = FALSE; util.dbgmsg("Init NG"); }
			if (mode1_crc != specfile.mode1_crc32) { ret = FALSE; util.dbgmsg("Mode1 NG"); }
			if (mode2_crc != specfile.mode2_crc32) { ret = FALSE; util.dbgmsg("Mode2 NG"); }
			if (mode3_crc != specfile.mode3_crc32) { ret = FALSE; util.dbgmsg("Mode3 NG"); }
			if (mode4_crc != specfile.mode4_crc32) { ret = FALSE; util.dbgmsg("Mode4 NG"); }

			if (ret == FALSE)
			{
				MessageBox.Show("ICT Spec Update\nMCU-PC ICT Spec Difference");
			}
			else
			{
				util.dbgmsg("ICT SPEC OK");
			}


			return ret;
		}
		static byte panel_crc_check(byte[] data)
		{
			byte ret = TRUE;
			panel_crc = (UInt32)(data[0] << 24);
			panel_crc += (UInt32)(data[1] << 16);
			panel_crc += (UInt32)(data[2] << 8);
			panel_crc += (UInt32)(data[3] << 0);

			if (panel_crc == specfile.panel_crc32)
			{
				util.dbgmsg("Panel Spec OK");
				ret = TRUE;
			}
			else
			{
				MessageBox.Show("MCU Panel Spec Update\nMCU-PC Panel Spec Difference");
				ret = FALSE;
			}
			return ret;
		}

		static byte data_crc_check(byte[] data)
		{
			byte ret = TRUE;
			specfile.board_crc32 = (UInt32)(data[0] << 24);
			specfile.board_crc32 += (UInt32)(data[1] << 16);
			specfile.board_crc32 += (UInt32)(data[2] << 8);
			specfile.board_crc32 += (UInt32)(data[3] << 0);

			if (specfile.data_crc32 == specfile.board_crc32)
			{
				util.dbgmsg("Input Data OK");
				ret = TRUE;
			}
			else
			{
				MessageBox.Show("MCU Input Data Update\nMCU-PC Input Data Difference");
				ret = FALSE;
			}
			return ret;
		}

		static byte pmic_crc_check(byte[] data)
		{
			byte ret = TRUE;
			specfile.bd_pmic_crc32 = (UInt32)(data[0] << 24);
			specfile.bd_pmic_crc32 += (UInt32)(data[1] << 16);
			specfile.bd_pmic_crc32 += (UInt32)(data[2] << 8);
			specfile.bd_pmic_crc32 += (UInt32)(data[3] << 0);

			if (specfile.pmic_crc32 == specfile.bd_pmic_crc32)
			{
				util.dbgmsg("PMIC Data OK");
				ret = TRUE;
			}
			else
			{
				MessageBox.Show("PMIC Data Update\nPMIC Input Data Difference");
				ret = FALSE;
			}
			return ret;
		}
		static byte eep_crc_check(byte[] data)
		{
			byte ret = TRUE;
			specfile.bd_eep_crc32 = (UInt32)(data[0] << 24);
			specfile.bd_eep_crc32 += (UInt32)(data[1] << 16);
			specfile.bd_eep_crc32 += (UInt32)(data[2] << 8);
			specfile.bd_eep_crc32 += (UInt32)(data[3] << 0);

			if (specfile.eep_crc32 == specfile.bd_eep_crc32)
			{
				util.dbgmsg("EEP Data OK");
				ret = TRUE;
			}
			else
			{
				MessageBox.Show("EEP Data Update\nEEP Input Data Difference");
				ret = FALSE;
			}
			return ret;
		}
		//------------------------------
		static byte tpic_crc_check(byte[] data)
		{
			byte ret = TRUE;
			specfile.bd_tpic_crc32 = (UInt32)(data[0] << 24);
			specfile.bd_tpic_crc32 += (UInt32)(data[1] << 16);
			specfile.bd_tpic_crc32 += (UInt32)(data[2] << 8);
			specfile.bd_tpic_crc32 += (UInt32)(data[3] << 0);

			if (specfile.tpic_crc32 == specfile.bd_tpic_crc32)
			{
				util.dbgmsg("TPIC Data OK");
				ret = TRUE;
			}
			else
			{
				MessageBox.Show("TPIC Data Update\nTPIC Input Data Difference");
				ret = FALSE;
			}
			return ret;
		}

		static void parsing_ntype(byte nType, int length, byte[] data)
		{
			switch (nType)
			{
				////// read spec board(Board -> PC)
				case (ntype.ICT_PROJECT_RD):
					board_rx_result = ict_crc_check(data);
					board_rx_flag = true;
					break;
				case (ntype.PANEL_DATA_RD):
					board_rx_result = panel_crc_check(data);
					board_rx_flag = true;
					break;
				case (ntype.INPUT_DATA_RD):
					board_rx_result = data_crc_check(data);
					board_rx_flag = true;
					break;
				case (ntype.PMIC_DATA_RD):
					board_rx_result = pmic_crc_check(data);
					board_rx_flag = true;
					break;
				case (ntype.EEP_DATA_RD):
					board_rx_result = eep_crc_check(data);
					board_rx_flag = true;
					break;
				case (ntype.TPIC_DATA_RD):
					board_rx_result = tpic_crc_check(data);
					board_rx_flag = true;
					break;

				//default: MessageBox.Show("parsing_ntype default", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error); break;

			}
		}
		static byte board_wait()
		{
			int timecnt = 0;

			while (!board_rx_flag)
			{
				rx_board_data();

				//if (timecnt++ > 500) // 1ms * 500
				if (timecnt++ > 1500) // 1ms * 500
				{
					MessageBox.Show("Spec Read Timeout", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

					break;
				}
				util.delay(1);
			}

			return board_rx_result;
		}
		#endregion

		#region ICT Spec READ BOARD(Board -> PC)
		static byte ict_info_read_board()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.ICT_PROJECT_RD, tx_buff.Length, tx_buff);

			return board_wait();
		}

		static void spec_clear()
		{
			KI.frm.text_pj_name.Text = specfile.project_name_main = "Project Name";
			KI.frm.text_pj_sub.Text = specfile.project_name_sub = "Spec History";
			specfile.short_auto_pp = 0;
			specfile.short_auto_mm = 0;
			////////////////////////
			specfile.tp_count = 0;
			specfile.tp_name.Initialize();
			specfile.tp_number.Initialize();
			////////////////////////
			specfile.open_count = 0;
			specfile.open_tp1.Initialize();
			specfile.open_tp2.Initialize();
			specfile.open_range.Initialize();
			specfile.open_spec.Initialize();
			specfile.open_ok_cnt.Initialize();
			specfile.open_ng_cnt.Initialize();
			////////////////////////
			specfile.short_bs_count = 0;
			specfile.short_bs_range = 0;
			specfile.short_bs_spec = 0;
			specfile.short_bs_ok_cnt = 0;
			specfile.short_bs_ng_cnt = 0;
			specfile.short_bs_tp.Initialize();
			specfile.short_bs_group.Initialize();
			////////////////////////
			specfile.short_ex_count = 0;
			specfile.short_ex_tp1.Initialize();
			specfile.short_ex_tp2.Initialize();
			specfile.short_ex_range.Initialize();
			specfile.short_ex_spec.Initialize();
			specfile.short_ex_ok_cnt.Initialize();
			specfile.short_ex_ng_cnt.Initialize();
			////////////////////////
			specfile.part_count = 0;
			specfile.part_name.Initialize();
			specfile.part_tp1.Initialize();
			specfile.part_tp2.Initialize();
			specfile.part_range.Initialize();
			specfile.part_spec_hi.Initialize();
			specfile.part_spec_lo.Initialize();
			specfile.part_ok_cnt.Initialize();
			specfile.part_ng_cnt.Initialize();
			////////////////////////
			specfile.func_count = 0;
			specfile.func_name.Initialize();
			specfile.func_type.Initialize();
			specfile.func_module.Initialize();
			specfile.func_spec_dec.Initialize();
			specfile.func_spec_hex.Initialize();
			specfile.func_spec_float.Initialize();
			specfile.func_spec_ascii.Initialize();
			specfile.func_log_flag.Initialize();
			specfile.func_panel_link.Initialize();
			////////////////////////
			specfile.mode1_sequence = 0;
			KI.frm.rd_mode1.Text = specfile.mode1_name = "mode1";
			specfile.mode1_operation.Initialize();
			specfile.mode1_number.Initialize();
			specfile.mode1_status.Initialize();
			specfile.mode1_time.Initialize();
			////////////////////////
			specfile.mode2_sequence = 0;
			KI.frm.rd_mode2.Text = specfile.mode2_name = "mode2";
			specfile.mode2_operation.Initialize();
			specfile.mode2_number.Initialize();
			specfile.mode2_status.Initialize();
			specfile.mode2_time.Initialize();
			////////////////////////
			specfile.mode3_sequence = 0;
			KI.frm.rd_mode3.Text = specfile.mode3_name = "mode3";
			specfile.mode3_operation.Initialize();
			specfile.mode3_number.Initialize();
			specfile.mode3_status.Initialize();
			specfile.mode3_time.Initialize();
			////////////////////////
			specfile.mode4_sequence = 0;
			KI.frm.rd_mode4.Text = specfile.mode4_name = "mode4";
			specfile.mode4_operation.Initialize();
			specfile.mode4_number.Initialize();
			specfile.mode4_status.Initialize();
			specfile.mode4_time.Initialize();
			////////////////////////
			specfile.init_sequence = 0;
			specfile.init_name = "";
			specfile.init_operation.Initialize();
			specfile.init_number.Initialize();
			specfile.init_status.Initialize();
			specfile.init_time.Initialize();
		}
		public static bool read_board_ict_spec()
		{
			util.delay(50);

			if (ict_info_read_board() == FALSE)
			{
				return false;
			}
						
			KI.frm.text_check_popup.Text = "";
			KI.frm.Refresh();

			return true;
		}
		#endregion

		#region Panel READ BOARD(Board -> PC)
		public static bool read_panel_data()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.PANEL_DATA_RD, tx_buff.Length, tx_buff);

			byte ret = board_wait();

			if (ret == 1)
				return true;
			else
				return false;
		}
		#endregion

		#region Input DATA READ BOARD(Board -> PC)
		public static bool read_input_data()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.INPUT_DATA_RD, tx_buff.Length, tx_buff);

			byte ret = board_wait();

			if (ret == 1)
				return true;
			else
				return false;
		}
		#endregion

		#region PMIC DATA READ BOARD(Board -> PC)
		public static bool read_pmic_data()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.PMIC_DATA_RD, tx_buff.Length, tx_buff);

			byte ret = board_wait();

			if (ret == 1)
				return true;
			else
				return false;
		}
		#endregion

		#region EEP DATA READ BOARD(Board -> PC)
		public static bool read_eep_data()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.EEP_DATA_RD, tx_buff.Length, tx_buff);

			byte ret = board_wait();

			if (ret == 1)
				return true;
			else
				return false;
		}
		#endregion

		#region TPIC DATA READ BOARD(Board -> PC)
		public static bool read_tpic_data()
		{
			board_rx_flag = false;
			board_rx_result = 0;

			byte[] tx_buff = new byte[1];
			tx_buff[0] = 0;

			serial.tx_bd(ntype.TPIC_DATA_RD, tx_buff.Length, tx_buff);

			byte ret = board_wait();

			if (ret == 1)
				return true;
			else
				return false;
		}
		#endregion

		public static bool bd_ict_spec_read()
		{
			try
			{
				spec_clear();
				if ((specfile.spec_read_file() == true) && (specfile.oper_read_file() == true))
				{
					if (read_board_ict_spec() == true)
					{
						KI.frm.text_pj_name.Text = specfile.project_name_main;
						KI.frm.text_pj_sub.Text = specfile.project_name_sub;
						
						KI.frm.rd_mode1.Text = specfile.mode1_name;
						KI.frm.rd_mode2.Text = specfile.mode2_name;
						KI.frm.rd_mode3.Text = specfile.mode3_name;
						KI.frm.rd_mode4.Text = specfile.mode4_name;

						KI.frm.button_sv_mode1.Text = specfile.mode1_name + "\r\nFlow";
						KI.frm.button_sv_mode2.Text = specfile.mode2_name + "\r\nFlow";
						KI.frm.button_sv_mode3.Text = specfile.mode3_name + "\r\nFlow";
						KI.frm.button_sv_mode4.Text = specfile.mode4_name + "\r\nFlow";

						KI.frm.text_ict.Clear();
						KI.frm.text_ict.AppendText(String.Format("[Number]"));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - TP({0})", specfile.tp_count));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - Open({0})/Short({1})/Short Ex({2})", specfile.open_count, specfile.short_bs_count, specfile.short_ex_count));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - Part({0})/Func({1})", specfile.part_count, specfile.func_count));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format("[CRC32]"));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - TP({0:X})", specfile.tp_crc32));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - Open({0:X})/Short({1:X})/Short Ex({2:X})", specfile.open_crc32, specfile.short_crc32, specfile.shortex_crc32));
						KI.frm.text_ict.AppendText(Environment.NewLine);
						KI.frm.text_ict.AppendText(String.Format(" - Part({0:X})/Func({1:X})", specfile.part_crc32, specfile.func_crc32));
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}
		/*public static bool bd_panel_spec_read()
		{
			try
			{
				if ((specfile.panel_read_file() == true) && (read_panel_data() == true))
				{
					KI.frm.text_panel.Text = "";
					KI.frm.text_panel.AppendText(String.Format(" - Panel({0})", specfile.panel_count));
					KI.frm.text_panel.AppendText(Environment.NewLine);
					KI.frm.text_panel.AppendText(String.Format(" - CRC32 : {0:X}", specfile.panel_crc32));
				}
				else
				{
					return false;

				}
			}
			catch
			{
				return false;
			}
			return true;
		}*/ //210514 MCH

		public static bool bd_input_data_read()
		{
			try
			{
				if ((specfile.indata_read_file() == true) && (read_input_data() == true))
				{
					KI.frm.text_data.Clear();
					KI.frm.text_pj_data.Text = specfile.data_name;
					KI.frm.text_data.AppendText(String.Format(" - " + specfile.data_name));
					KI.frm.text_data.AppendText(Environment.NewLine);
					KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", specfile.data_size / 1024));
					KI.frm.text_data.AppendText(Environment.NewLine);
					KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", specfile.data_crc32));
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		public static bool bd_pmic_data_read()
		{
			try
			{
				if ((specfile.pmic_read_file() == true) && (read_pmic_data() == true) && (read_tpic_data() == true))//tpic 추가
				{
					KI.frm.text_pmic.Clear();
					//KI.frm.text_pj_data.Text = specfile.pmic_name;
					KI.frm.text_pmic.AppendText(String.Format(" - " + specfile.pmic_name));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} kB", specfile.pmic_size / 1024));
					KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.pmic_size));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.pmic_crc32));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - " + specfile.tpic_name));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.tpic_size));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.tpic_crc32));
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

        public static bool bd_pmic_data_read_only()
        {
            try
            {
                if ((specfile.pmic_read_file_only() == true) && (read_pmic_data() == true))//pmic 만 read 함
                {
                    KI.frm.text_pmic.Clear();
                    //KI.frm.text_pj_data.Text = specfile.pmic_name;
                    KI.frm.text_pmic.AppendText(String.Format(" - " + specfile.pmic_name));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} kB", specfile.pmic_size / 1024));
                    KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.pmic_size));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.pmic_crc32));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);                    
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool bd_tpic_data_read_only()
        {
            try
            {
                if ((specfile.tpic_read_file_only() == true) && (read_tpic_data() == true))//tpic 추가
                {
                    //KI.frm.text_pmic.Clear();
                    KI.frm.text_pmic.AppendText(String.Format(" - " + specfile.tpic_name));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.tpic_size));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.tpic_crc32));
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool bd_eep_data_read()
		{
			try
			{
				if ((specfile.eep_read_file() == true) && (read_eep_data() == true))
				{
					KI.frm.text_eep.Clear();
					//KI.frm.text_pj_data.Text = specfile.eep_name;
					KI.frm.text_eep.AppendText(String.Format(" - " + specfile.eep_name));
					KI.frm.text_eep.AppendText(Environment.NewLine);
					KI.frm.text_eep.AppendText(String.Format(" - Size : {0:F2} kB", specfile.eep_size / 1024));
					KI.frm.text_eep.AppendText(Environment.NewLine);
					KI.frm.text_eep.AppendText(String.Format(" - CRC32 : {0:X}", specfile.eep_crc32));
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
}
