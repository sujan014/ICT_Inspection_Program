using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class key
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;

		public const byte ATS_ON = 0xFF;
		public const byte ST1_ON = 0x01;
		public const byte ST2_ON = 0x02;
		public const byte MOD_ON = 0x04;
		public const byte ESC_ON = 0x08; // key State

		public const byte ST1_LON = 0x11;
		public const byte ST2_LON = 0x12;
		public const byte MOD_LON = 0x14;
		public const byte ESC_LON = 0x18; // long key State

		#region [000]Board key check

		public static byte KEY_RET = 0;
		public static void boardkeycheck()
		{
			switch (KEY_RET)
			{
				case (ST1_ON | ST2_ON):
					key_st1st2_send();
					break;
				case (MOD_ON | ST1_ON):
					control.insp_mode_change();
					break;
				case (MOD_ON | ST2_ON):
					control.menu_display_rotate();
					break;
				case (MOD_ON | ESC_ON):
					control.board_qty_reset();
					break;
				//////////////////////////////////		
				case (ST1_ON):
					listview.result_disp(1, FALSE);
					break;
				case (ST2_ON):
					listview.result_disp(0, FALSE);
					break;
				case (ESC_ON):
					listview.result_disp(2, FALSE);
					break;
				case (MOD_ON):
					listview.result_disp(2, TRUE);
					break;
			}
			KEY_RET = 0;
		}
		public static void key_esc_send()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = ESC_ON;
			serial.tx_bd(ntype.KEY_STATE, 1, tx_buff);
		}
		public static void key_st1st2_send()
		{
            listview.result_disp(2, FALSE);
            byte[] tx_buff = new byte[10];
			tx_buff[0] = ST1_ON | ST2_ON;
			tx_buff[1] = Convert.ToByte(Properties.Settings.Default.ng_cont);
			tx_buff[2] = Convert.ToByte(Properties.Settings.Default.data_write);
			tx_buff[3] = Convert.ToByte(Properties.Settings.Default.sdc_log);
			tx_buff[4] = Convert.ToByte(Properties.Settings.Default.log_unit);
			tx_buff[5] = Convert.ToByte(Properties.Settings.Default.sub_disp);
			tx_buff[6] = Convert.ToByte(Properties.Settings.Default.short_all);
			tx_buff[7] = Convert.ToByte(Properties.Settings.Default.mode_flag);
            tx_buff[8] = Convert.ToByte(Properties.Settings.Default.boot_app_write);
            serial.tx_bd(ntype.KEY_STATE, 10, tx_buff);
		}
		public static void key_st1_send()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = ST1_ON;
			serial.tx_bd(ntype.KEY_STATE, 1, tx_buff);
		}
		public static void key_st2_send()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = ST2_ON;
			serial.tx_bd(ntype.KEY_STATE, 1, tx_buff);
		}
		public static void key_mode_send()
		{
			byte[] tx_buff = new byte[1];
			tx_buff[0] = MOD_ON;
			serial.tx_bd(ntype.KEY_STATE, 1, tx_buff);
		}
		#endregion
	}
}
