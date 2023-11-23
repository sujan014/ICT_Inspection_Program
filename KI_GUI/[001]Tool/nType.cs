using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class ntype
	{
		#region SPEC Write/Read
		/////////////////////
		public const byte ICT_SPEC_ERASE = 100;
		public const byte ICT_PROJECT_WR = 101;
		public const byte ICT_TESTPOINT_WR = 102;
		public const byte ICT_OPEN_WR = 103;
		public const byte ICT_SHORTBS_WR = 104;
		public const byte ICT_SHORTEX_WR = 105;
		public const byte ICT_PART_WR = 106;
		public const byte ICT_FUNC_WR = 107;
		public const byte OP_MODE1_WR = 108;
		public const byte OP_MODE2_WR = 109;
		public const byte OP_MODE3_WR = 110;
		public const byte OP_MODE4_WR = 111;
		public const byte OP_INIT_WR = 112;
		public const byte SPEC_SAVE_FINSH = 113;
		/////////////////////
		public const byte ICT_PROJECT_RD = 115;
		//public const byte ICT_TESTPOINT_RD = 116;
		//public const byte ICT_OPEN_RD = 117;
		//public const byte ICT_SHORTBS_RD = 118;
		//public const byte ICT_SHORTEX_RD = 119;
		//public const byte ICT_PART_RD = 120;
		//public const byte ICT_FUNC_RD = 121;
		//public const byte OP_MODE1_RD = 122;
		//public const byte OP_MODE2_RD = 123;
		//public const byte OP_MODE3_RD = 124;
		//public const byte OP_MODE4_RD = 125;
		//public const byte OP_INIT_RD = 126;

		public const byte PANEL_DATA_ERASE = 130;
		public const byte PANEL_DATA_WR = 131;
		public const byte PANEL_DATA_FINSH = 132;
		public const byte PANEL_DATA_RD = 133;

		public const byte INPUT_DATA_ERASE = 135;
		public const byte INPUT_DATA_WR = 136;
		public const byte INPUT_DATA_FINSH = 137;
		public const byte INPUT_DATA_RD = 138;

		public const byte FW_DATA_ERASE = 140;
		public const byte FW_DATA_WR = 141;
		public const byte FW_DATA_FINSH = 142;
		public const byte FULL_ERASE = 143;

		public const byte PMIC_DATA_ERASE = 145;
		public const byte PMIC_DATA_WR = 146;
		public const byte PMIC_DATA_FINSH = 147;
		public const byte PMIC_DATA_RD = 148;

		public const byte EEP_DATA_ERASE = 185;
		public const byte EEP_DATA_WR = 186;
		public const byte EEP_DATA_FINSH = 187;
		public const byte EEP_DATA_RD = 188;

		public const byte TPIC_DATA_ERASE = 143;
		public const byte TPIC_DATA_WR = 127;
		public const byte TPIC_DATA_FINSH = 128;
		public const byte TPIC_DATA_RD = 129;

		#endregion

		#region Test nType
		//*************************
		// Test mode
		//*************************		
		public const byte LIST_ITEM = 150;
		public const byte LIST_MEAS = 151;
		public const byte LIST_RESULT = 152;

		public const byte START_STATE = 155;
		public const byte OPEN_STATE = 160;
		public const byte SHORT_STATE = 161;
		public const byte PART_STATE = 162;
		public const byte FUNC_STATE = 163;
		public const byte END_STATE = 165;

		public const byte PANLE_DATA = 166;

		public const byte VISON_STATE = 169;
		public const byte INFO_STATE = 170;
		public const byte SUMMARY_LOG = 180;


		public const byte KEY_STATE = 190;
		public const byte KEY_VALUE = 200;
		public const byte MODE_CHANGE = 201;
		public const byte SAFE_VALUE = 202;
		public const byte QTY_VALUE = 203;
		public const byte POPUP_DISP = 204;
		public const byte POPUP_RESULT = 205;
		public const byte STOP_WATCH = 206;
		public const byte SEN_VALUE = 207;
		public const byte LED_VALUE = 208;
		public const byte SEQ_STATE = 210;

		public const byte DEBUG_MODE = 253;
		public const byte RUN_MODE = 254;
		public const byte CONN_CHECK = 255;

        public const byte MFS_WRITE = 223;
        public const byte MFS_VERIFY = 224;

        #endregion
    }
}
