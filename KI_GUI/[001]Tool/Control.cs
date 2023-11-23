using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class control
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;

		static Stopwatch stop_watch = new Stopwatch();

		const byte STOPWATCH_START = 1;
		const byte STOPWATCH_CHECK = 0xaa;
		const byte STOPWATCH_END = 0;
		public static void StopWatch(byte state)
		{
			if (state == STOPWATCH_START)
			{
				KI.tact_time = KI.frm.text_tact_time.Text = "0.00 sec";
				stop_watch.Restart();
			}
			else if (state == STOPWATCH_CHECK)
			{
				KI.tact_time = KI.frm.text_tact_time.Text =
					((float)stop_watch.ElapsedMilliseconds / 1000).ToString("F2") + " sec";
			}
			else if (state == STOPWATCH_END)
			{
				stop_watch.Stop();
				KI.tact_time = KI.frm.text_tact_time.Text = 
					((float)stop_watch.ElapsedMilliseconds / 1000).ToString("F2") + " sec";
			}
			KI.frm.Refresh();
		}
		public static void board_qty_reset()
		{
			KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
			listview.sub_popup(KI.TRUE, "Counter Reset");
			util.delay(250);
			qty_count_write(KI.CLEAR);
			listview.sub_popup(KI.FALSE, "");
		}
		static void qty_update()
		{
			KI.frm.text_qty.Text = string.Format("QTY : {0,20}", Properties.Settings.Default.qty_cnt);
			KI.frm.text_ok.Text = string.Format("O K : {0,20}", Properties.Settings.Default.ok_cnt);
			KI.frm.text_ng.Text = string.Format("N G : {0,20}", Properties.Settings.Default.ng_cnt);
			KI.frm.Refresh();
		}
		public static void qty_count_write(byte result_flag)
		{
			Properties.Settings.Default.Reload();
			if (result_flag == KI.TRUE)
			{
				Properties.Settings.Default.ok_cnt++;
				Properties.Settings.Default.qty_cnt
					 = Properties.Settings.Default.ng_cnt + Properties.Settings.Default.ok_cnt;
			}
			else if (result_flag == KI.FALSE)
			{
				Properties.Settings.Default.ng_cnt++;
				Properties.Settings.Default.qty_cnt
					 = Properties.Settings.Default.ng_cnt + Properties.Settings.Default.ok_cnt;
			}
			else if (result_flag == KI.CLEAR)
			{
				Properties.Settings.Default.qty_cnt = 0;
				Properties.Settings.Default.ok_cnt = 0;
				Properties.Settings.Default.ng_cnt = 0;

				KI.frm.text_qty.Text = Properties.Settings.Default.qty_cnt.ToString();
				KI.frm.text_ok.Text = Properties.Settings.Default.ok_cnt.ToString();
				KI.frm.text_ng.Text = Properties.Settings.Default.ng_cnt.ToString();
			}

			Properties.Settings.Default.Save();

			qty_update();
		}
		public static void first_boot_update()
		{
			Properties.Settings.Default.Reload();
			qty_update();
			mode_update();
		}
		static void board_mode_change()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = Properties.Settings.Default.mode_flag;
			serial.tx_bd(ntype.MODE_CHANGE, 1, tx_buff);
		}
		
		public static void board_debugmode_change()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = 1;
			serial.tx_bd(ntype.DEBUG_MODE, 1, tx_buff);
		}

		const byte MODE1 = 0; 
		const byte MODE2 = 1; 
		const byte MODE3 = 2; 
		const byte MODE4 = 3; 			
		static void mode_update()
		{
			KI.frm.rd_mode1.Checked = false;
			KI.frm.rd_mode2.Checked = false;
			KI.frm.rd_mode3.Checked = false;
			KI.frm.rd_mode4.Checked = false;

			if (Properties.Settings.Default.mode_flag == 0)
				KI.frm.rd_mode1.Checked = true;
			else if (Properties.Settings.Default.mode_flag == 1)
				KI.frm.rd_mode2.Checked = true;
			else if (Properties.Settings.Default.mode_flag == 2)
				KI.frm.rd_mode3.Checked = true;
			else if (Properties.Settings.Default.mode_flag == 3)
				KI.frm.rd_mode4.Checked = true;

			KI.frm.Refresh();
		}
		public static void insp_mode_change()
		{
			//listview.sub_popup(FALSE, "");

			KI.frm.tab.SelectedIndex = KI.MAIN_DISP;

			Properties.Settings.Default.Reload();

			board_mode_change();

			if (Properties.Settings.Default.mode_flag == MODE1)
			{
				Properties.Settings.Default.mode_flag = MODE2;
				KI.frm.rd_mode1.Checked = KI.frm.rd_mode3.Checked = KI.frm.rd_mode4.Checked = false;
				KI.frm.rd_mode2.Checked = true;
			}
			else if (Properties.Settings.Default.mode_flag == MODE2)
			{
				Properties.Settings.Default.mode_flag = MODE3;
				KI.frm.rd_mode1.Checked = KI.frm.rd_mode2.Checked = KI.frm.rd_mode4.Checked = false;
				KI.frm.rd_mode3.Checked = true;
			}
			else if (Properties.Settings.Default.mode_flag == MODE3)
			{
				Properties.Settings.Default.mode_flag = MODE4;
				KI.frm.rd_mode1.Checked = KI.frm.rd_mode2.Checked = KI.frm.rd_mode3.Checked = false;
				KI.frm.rd_mode4.Checked = true;
			}
			else if (Properties.Settings.Default.mode_flag == MODE4)
			{
				Properties.Settings.Default.mode_flag = MODE1;
				KI.frm.rd_mode2.Checked = KI.frm.rd_mode3.Checked = KI.frm.rd_mode4.Checked = false;
				KI.frm.rd_mode1.Checked = true;
			}
			Properties.Settings.Default.Save();

			mode_update();
		}
		static void set_tap_disp(byte index)
		{
			KI.frm.tab.SelectedIndex = index;
		}
		static byte get_tap_disp()
		{
			return (byte)KI.frm.tab.SelectedIndex;
		}
		public static void menu_display_rotate()
		{
			//listview.sub_popup(FALSE, "");

			if (get_tap_disp() == KI.MAIN_DISP)
				set_tap_disp(KI.MENU1_DISP);
			else if (get_tap_disp() == KI.MENU1_DISP)
				set_tap_disp(KI.MENU2_DISP);
			else if (get_tap_disp() == KI.MENU2_DISP)
				set_tap_disp(KI.MAIN_DISP);
			else
				set_tap_disp(KI.MAIN_DISP);
		}
		public static void UpdateCheckBox()
		{
			KI.frm.chb_ngcont.Checked = Properties.Settings.Default.ng_cont;
			KI.frm.chb_fwwrite.Checked = Properties.Settings.Default.data_write;
			KI.frm.chb_logunit.Checked = Properties.Settings.Default.log_unit;
			//KI.frm.chb_sdclog.Checked = Properties.Settings.Default.sdc_log; 210514 MCH
			KI.frm.chb_subname.Checked = Properties.Settings.Default.sub_disp;
            KI.frm.chb_bootApp.Checked = Properties.Settings.Default.boot_app_write;
            //KI.frm.chb_shortall.Checked = Properties.Settings.Default.short_all; 210514 MCH

            KI.frm.chb_InData.Checked = Properties.Settings.Default.Data_Check;
            KI.frm.chb_PMIC.Checked = Properties.Settings.Default.Pmic_Check;
            KI.frm.chb_TPIC.Checked = Properties.Settings.Default.Tpic_Check;
            KI.frm.chb_EEPROM.Checked = Properties.Settings.Default.Eep_Check;
        }
		public static void task_start_flow()
		{
			listview.listview_clear();

			Test.is_insp_flag = TRUE;
			Test.test_finsh_flag = FALSE;
			Test.test_result_flag = TRUE;
			Test.list_disp_flag = FALSE;
			Test.list_view_mode = 0;

			Test.Op_str_idx = Test.Op_end_idx = 0;
			Test.Sh_str_idx = Test.Sh_end_idx = 0;
			Test.Pt_str_idx = Test.Pt_end_idx = 0;
			Test.Fn_str_idx = Test.Fn_end_idx = 0;

			Test.op_auto_result = Test.sh_auto_result = KI.ESC_KEY;
			Test.pt_auto_result = Test.fn_auto_result = KI.ESC_KEY;

			Test.test_item_name.Initialize();
			Test.test_meas_string.Initialize();
			Test.test_meas_string1.Initialize();
			Test.test_meas_value.Initialize();
			Test.test_result.Initialize();
			Test.test_count = 0;

			Test.test_ng_item_name.Initialize();
			Test.test_ng_meas_string.Initialize();
			Test.test_ng_result.Initialize();
			Test.test_ng_count = 0;

			Test.panel_data.Initialize();
			Test.ErrorNodeCount.Initialize();
			Test.sdc_data.Initialize();
		}
		public static void task_end_flow(byte[] data)
		{
			string[] buff = util.ByteToString(data).Split(',');

			Test.test_count = Convert.ToByte(buff[0]);
			Test.test_result_flag = Convert.ToByte(buff[1]);

			if (Test.test_count == 0)
			{
				Test.list_disp_flag = FALSE;
			}
			else
			{
				Test.test_finsh_flag = TRUE;
				Test.list_disp_flag = TRUE;
			}
			Test.is_insp_flag = FALSE;
		}

		public static void cly_sen_check(byte data)
		{
			if (((data >> 0) & 0x01) == 0x00) KI.frm.text_sen1.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen1.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 1) & 0x01) == 0x00) KI.frm.text_sen2.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen2.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 2) & 0x01) == 0x00) KI.frm.text_sen3.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen3.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 3) & 0x01) == 0x00) KI.frm.text_sen4.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen4.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 4) & 0x01) == 0x00) KI.frm.text_sen5.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen5.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 5) & 0x01) == 0x00) KI.frm.text_sen6.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen6.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 6) & 0x01) == 0x00) KI.frm.text_sen7.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen7.BackColor = System.Drawing.Color.DarkGreen;

			if (((data >> 7) & 0x01) == 0x00) KI.frm.text_sen8.BackColor = System.Drawing.Color.DimGray;
			else KI.frm.text_sen8.BackColor = System.Drawing.Color.DarkGreen;
		}
	}
}
