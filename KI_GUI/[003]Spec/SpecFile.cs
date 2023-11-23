using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KI_GUI
{
	class specfile
	{
		#region BOARD to PC Spec Read

		#endregion

		#region OPERATION SPEC READ TO FILE

		public const string mode1_csv = @"C:\KI\Spec\01.ICT_SPEC\Operation\01.Insp_mode1.csv";
		public static UInt16 mode1_sequence = 0;
		public static string mode1_name = "mode1";
		public static UInt16[] mode1_operation = new UInt16[100];
		public static UInt16[] mode1_number = new UInt16[100];
		public static UInt16[] mode1_status = new UInt16[100];
		public static UInt16[] mode1_time = new UInt16[100];
		public static UInt32 mode1_crc32 = 0;
		static void mode1_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(mode1_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine() + ",,,,,,,,,,,";
			}
			sr.Close();
			fs.Close();

			string[] split = readbuff[0].Split(',');
			mode1_name = split[0];

			mode1_sequence = 0;
			for (int cnt = 2; cnt < line_numer; cnt++)
			{
				split = readbuff[cnt].Split(',');
				mode1_operation[mode1_sequence] = pasing_mode(split[1]);
				mode1_status[mode1_sequence] = pasing_state(split[2]);
				if (split[3] == "")
					mode1_number[mode1_sequence] = 0;
				else
					mode1_number[mode1_sequence] = Convert.ToUInt16(split[3]);
				if (split[4] == "")
					mode1_time[mode1_sequence] = 0;
				else
					mode1_time[mode1_sequence] = Convert.ToUInt16(split[4]);
				mode1_sequence++;
			}
			mode1_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_sequence >> 8) & 0x00ff)] ^ (mode1_crc32 << 8);
			mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_sequence >> 0) & 0x00ff)] ^ (mode1_crc32 << 8);

			byte[] str_buf = util.StringToByte(mode1_name);
			for (int i = 0; i < str_buf.Length; i++)
			{
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ str_buf[i]] ^ (mode1_crc32 << 8);
			}

			for (int cnt = 0; cnt < mode1_sequence; cnt++)
			{
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_operation[cnt] >> 8) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_operation[cnt] >> 0) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_number[cnt] >> 8) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_number[cnt] >> 0) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_status[cnt] >> 8) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_status[cnt] >> 0) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_time[cnt] >> 8) & 0x00ff)] ^ (mode1_crc32 << 8);
				mode1_crc32 = util.crc32_table[(mode1_crc32 >> 24) ^ ((mode1_time[cnt] >> 0) & 0x00ff)] ^ (mode1_crc32 << 8);
			}
		}
		public const string mode2_csv = @"C:\KI\Spec\01.ICT_SPEC\Operation\02.Insp_mode2.csv";
		public static UInt16 mode2_sequence = 0;
		public static string mode2_name = "mode2";
		public static UInt16[] mode2_operation = new UInt16[100];
		public static UInt16[] mode2_number = new UInt16[100];
		public static UInt16[] mode2_status = new UInt16[100];
		public static UInt16[] mode2_time = new UInt16[100];
		public static UInt32 mode2_crc32 = 0;
		static void mode2_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(mode2_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			string[] split = readbuff[0].Split(',');
			mode2_name = split[0];

			mode2_sequence = 0;
			for (int cnt = 2; cnt < line_numer; cnt++)
			{
				split = readbuff[cnt].Split(',');
				mode2_operation[mode2_sequence] = pasing_mode(split[1]);
				mode2_status[mode2_sequence] = pasing_state(split[2]);
				if (split[3] == "")
					mode2_number[mode2_sequence] = 0;
				else
					mode2_number[mode2_sequence] = Convert.ToUInt16(split[3]);
				if (split[4] == "")
					mode2_time[mode2_sequence] = 0;
				else
					mode2_time[mode2_sequence] = Convert.ToUInt16(split[4]);
				mode2_sequence++;
			}
			mode2_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			mode2_crc32 = util.crc32_table[(mode2_crc32 >> 24) ^ ((mode2_sequence >> 8) & 0x00ff)] ^ (mode2_crc32 << 8);
			mode2_crc32 = util.crc32_table[(mode2_crc32 >> 24) ^ ((mode2_sequence >> 0) & 0x00ff)] ^ (mode2_crc32 << 8);

			byte[] str_buf = util.StringToByte(mode2_name);
			for (int i = 0; i < str_buf.Length; i++)
			{
				mode2_crc32 = util.crc32_table[(mode2_crc32 >> 24) ^ str_buf[i]] ^ (mode2_crc32 << 8);
			}

			for (int cnt = 0; cnt < mode2_sequence; cnt++)
			{
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_operation[cnt] >> 8) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_operation[cnt] >> 0) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_number[cnt] >> 8) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_number[cnt] >> 0) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_status[cnt] >> 8) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_status[cnt] >> 0) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_time[cnt] >> 8) & 0x00ff)] ^ (mode2_crc32 << 8);
				mode2_crc32 = util.crc32_table[(mode2_crc32>> 24) ^ ((mode2_time[cnt] >> 0) & 0x00ff)] ^ (mode2_crc32 << 8);
			}
		}
		public const string mode3_csv = @"C:\KI\Spec\01.ICT_SPEC\Operation\03.Insp_mode3.csv";
		public static UInt16 mode3_sequence = 0;
		public static string mode3_name = "mode3";
		public static UInt16[] mode3_operation = new UInt16[100];
		public static UInt16[] mode3_number = new UInt16[100];
		public static UInt16[] mode3_status = new UInt16[100];
		public static UInt16[] mode3_time = new UInt16[100];
		public static UInt32 mode3_crc32 = 0;
		static void mode3_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(mode3_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			string[] split = readbuff[0].Split(',');
			mode3_name = split[0];

			mode3_sequence = 0;
			for (int cnt = 2; cnt < line_numer; cnt++)
			{
				split = readbuff[cnt].Split(',');
				mode3_operation[mode3_sequence] = pasing_mode(split[1]);
				mode3_status[mode3_sequence] = pasing_state(split[2]);
				if (split[3] == "")
					mode3_number[mode3_sequence] = 0;
				else
					mode3_number[mode3_sequence] = Convert.ToUInt16(split[3]);
				if (split[4] == "")
					mode3_time[mode3_sequence] = 0;
				else
					mode3_time[mode3_sequence] = Convert.ToUInt16(split[4]);
				mode3_sequence++;
			}
			mode3_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_sequence >> 8) & 0x00ff)] ^ (mode3_crc32 << 8);
			mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_sequence >> 0) & 0x00ff)] ^ (mode3_crc32 << 8);

			byte[] str_buf = util.StringToByte(mode3_name);
			for (int i = 0; i < str_buf.Length; i++)
			{
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ str_buf[i]] ^ (mode3_crc32 << 8);
			}

			for (int cnt = 0; cnt < mode3_sequence; cnt++)
			{
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_operation[cnt] >> 8) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_operation[cnt] >> 0) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_number[cnt] >> 8) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_number[cnt] >> 0) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_status[cnt] >> 8) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_status[cnt] >> 0) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_time[cnt] >> 8) & 0x00ff)] ^ (mode3_crc32 << 8);
				mode3_crc32 = util.crc32_table[(mode3_crc32 >> 24) ^ ((mode3_time[cnt] >> 0) & 0x00ff)] ^ (mode3_crc32 << 8);
			}
		}
		public const string mode4_csv = @"C:\KI\Spec\01.ICT_SPEC\Operation\04.Insp_mode4.csv";
		public static UInt16 mode4_sequence;
		public static string mode4_name = "mode4";
		public static UInt16[] mode4_operation = new UInt16[100];
		public static UInt16[] mode4_number = new UInt16[100];
		public static UInt16[] mode4_status = new UInt16[100];
		public static UInt16[] mode4_time = new UInt16[100];
		public static UInt32 mode4_crc32 = 0;
		static void mode4_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(mode4_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			string[] split = readbuff[0].Split(',');
			mode4_name = split[0];

			mode4_sequence = 0;
			for (int cnt = 2; cnt < line_numer; cnt++)
			{
				split = readbuff[cnt].Split(',');
				mode4_operation[mode4_sequence] = pasing_mode(split[1]);
				mode4_status[mode4_sequence] = pasing_state(split[2]);
				if (split[3] == "")
					mode4_number[mode4_sequence] = 0;
				else
					mode4_number[mode4_sequence] = Convert.ToUInt16(split[3]);
				if (split[4] == "")
					mode4_time[mode4_sequence] = 0;
				else
					mode4_time[mode4_sequence] = Convert.ToUInt16(split[4]);
				mode4_sequence++;
			}
			mode4_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_sequence >> 8) & 0x00ff)] ^ (mode4_crc32 << 8);
			mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_sequence >> 0) & 0x00ff)] ^ (mode4_crc32 << 8);

			byte[] str_buf = util.StringToByte(mode4_name);
			for (int i = 0; i < str_buf.Length; i++)
			{
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ str_buf[i]] ^ (mode4_crc32 << 8);
			}

			for (int cnt = 0; cnt < mode4_sequence; cnt++)
			{
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_operation[cnt] >> 8) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_operation[cnt] >> 0) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_number[cnt] >> 8) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_number[cnt] >> 0) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_status[cnt] >> 8) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_status[cnt] >> 0) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_time[cnt] >> 8) & 0x00ff)] ^ (mode4_crc32 << 8);
				mode4_crc32 = util.crc32_table[(mode4_crc32 >> 24) ^ ((mode4_time[cnt] >> 0) & 0x00ff)] ^ (mode4_crc32 << 8);
			}
		}
		public const string init_csv = @"C:\KI\Spec\01.ICT_SPEC\Operation\05.Insp_init.csv";
		public static UInt16 init_sequence;
		public static string init_name = "init";
		public static UInt16[] init_operation = new UInt16[100];
		public static UInt16[] init_number = new UInt16[100];
		public static UInt16[] init_status = new UInt16[100];
		public static UInt16[] init_time = new UInt16[100];
		public static UInt32 init_crc32 = 0;
		static void init_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(init_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			string[] split = readbuff[0].Split(',');
			init_name = split[0];

			init_sequence = 0;
			for (int cnt = 2; cnt < line_numer; cnt++)
			{
				split = readbuff[cnt].Split(',');
				init_operation[init_sequence] = pasing_mode(split[1]);
				init_status[init_sequence] = pasing_state(split[2]);
				if (split[3] == "")
					init_number[init_sequence] = 0;
				else
					init_number[init_sequence] = Convert.ToUInt16(split[3]);
				if (split[4] == "")
					init_time[init_sequence] = 0;
				else
					init_time[init_sequence] = Convert.ToUInt16(split[4]);
				init_sequence++;
			}

			init_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_sequence >> 8) & 0x00ff)] ^ (init_crc32 << 8);
			init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_sequence >> 0) & 0x00ff)] ^ (init_crc32 << 8);

			byte[] str_buf = util.StringToByte(init_name);
			for (int i = 0; i < str_buf.Length; i++)
			{
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ str_buf[i]] ^ (init_crc32 << 8);
			}

			for (int cnt = 0; cnt < init_sequence; cnt++)
			{
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_operation[cnt] >> 8) & 0x00ff)] ^ (init_crc32 << 8);
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_operation[cnt] >> 0) & 0x00ff)] ^ (init_crc32 << 8);

				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_number[cnt] >> 8) & 0x00ff)] ^ (init_crc32 << 8);
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_number[cnt] >> 0) & 0x00ff)] ^ (init_crc32 << 8);

				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_status[cnt] >> 8) & 0x00ff)] ^ (init_crc32 << 8);
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_status[cnt] >> 0) & 0x00ff)] ^ (init_crc32 << 8);

				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_time[cnt] >> 8) & 0x00ff)] ^ (init_crc32 << 8);
				init_crc32 = util.crc32_table[(init_crc32 >> 24) ^ ((init_time[cnt] >> 0) & 0x00ff)] ^ (init_crc32 << 8);
			}
		}
		//*************************
		// Operation mode
		//*************************
		public const byte OPEN_TEST = 0;
		public const byte SHORT_TEST = 1;
		public const byte PART_TEST = 2;
		public const byte FUNC_TEST = 3;
		public const byte SOL_RUN = 4;
		public const byte MARKING_UNIT = 5;
		public const byte RELAY = 6;
		public const byte WAIT_KEY = 7;
		public const byte TACT_TIME = 8;
		public const byte VCC = 9;
		public const byte LOG_SAVE = 10;
		public const byte START_FLOW = 11;
		public const byte END_FLOW = 12;
		public const byte DISP_RESULT = 13;
		public const byte CY_SEN_CHK = 14;
		public const byte SAFE_SEN_CHK = 15;
		public const byte STATE_LED = 16;
		public const byte AUTO_ALIGN = 17;

		public static string find_mode_str(byte md)
		{
			if (md == SOL_RUN) return "SOL";
			else if (md == MARKING_UNIT) return "MARKING";
			else if (md == WAIT_KEY) return "WAIT_KEY";
			else if (md == LOG_SAVE) return "LOG_SAVE";
			else if (md == RELAY) return "RELAY";
			else if (md == VCC) return "VCC";
			else if (md == TACT_TIME) return "TACT_TIME";
			else if (md == START_FLOW) return "START_FLOW";
			else if (md == END_FLOW) return "END_FLOW";
			else if (md == OPEN_TEST) return "OPEN_TEST";
			else if (md == SHORT_TEST) return "SHORT_TEST";
			else if (md == PART_TEST) return "PART_TEST";
			else if (md == FUNC_TEST) return "FUNC_TEST";
			else if (md == DISP_RESULT) return "DISP_RESULT";
			else if (md == CY_SEN_CHK) return "CY_SEN_CHK";
			else if (md == SAFE_SEN_CHK) return "SAFE_SEN";
			else if (md == AUTO_ALIGN) return "AUTO_ALIGN";
			else return "None";
		}
		public static byte pasing_mode(string op)
		{
			if (op == "SOL_RUN") return SOL_RUN;                // SOL
			else if (op == "MARKING_UNIT") return MARKING_UNIT; // MAKING
			else if (op == "WAIT_KEY") return WAIT_KEY;         // WAIT_KEY
			else if (op == "LOG_SAVE") return LOG_SAVE;         // LOG
			else if (op == "RELAY") return RELAY;               // RY
			else if (op == "VCC") return VCC;                   // END
			else if (op == "TACT_TIME") return TACT_TIME;       // TIME
			else if (op == "START_FLOW") return START_FLOW;     // START
			else if (op == "END_FLOW") return END_FLOW;         // END
			else if (op == "OPEN_TEST") return OPEN_TEST;       // OPEN
			else if (op == "SHORT_TEST") return SHORT_TEST;     // SHORT
			else if (op == "PART_TEST") return PART_TEST;       // PART
			else if (op == "FUNC_TEST") return FUNC_TEST;       // FUNC
			else if (op == "DISP_RESULT") return DISP_RESULT;   // DISP_RESULT
			else if (op == "CYL_SEN") return CY_SEN_CHK;        // CY_SEN_CHK
			else if (op == "SAFE_SEN") return SAFE_SEN_CHK;     // CY_SEN_CHK
			else if (op == "AUTO_ALIGN") return AUTO_ALIGN;     // CY_SEN_CHK
			else return 0;										// none
		}

		//*************************
		// Operation state
		//*************************
		public const byte ON_STATE = 1;
		public const byte OFF_STATE = 0;
		public const byte ST12_STATE = (0x01 | 0x02);
		public const byte ST1_STATE = 0x01;
		public const byte ST2_STATE = 0x02;
		public const byte AUTO_STATE = 0x41;	//'A'
		public const byte STEP_STATE = 0x53;	//'S'
		public const byte USB_STATE = 0x55;		//'U'
		public const byte PC_STATE = 0x50;		//'P'

		public static string find_state_str(byte st)
		{
			if (st == ON_STATE) return "ON";
			else if (st == OFF_STATE) return "OFF";
			else if (st == ST12_STATE) return "ST12";
			else if (st == ST1_STATE) return "ST1";
			else if (st == ST2_STATE) return "ST2";
			else if (st == AUTO_STATE) return "AUTO";
			else if (st == STEP_STATE) return "STEP";
			else if (st == USB_STATE) return "USB";
			else if (st == PC_STATE) return "PC";
			else return "None";
		}
		public static byte pasing_state(string st)
		{
			if (st == "ON") return ON_STATE;
			else if (st == "OFF") return OFF_STATE;
			else if (st == "ST1+ST2") return ST12_STATE;
			else if (st == "ST1") return ST1_STATE;
			else if (st == "ST2") return ST2_STATE;
			else if (st == "AUTO") return AUTO_STATE;
			else if (st == "STEP") return STEP_STATE;
			else if (st == "USB") return USB_STATE;
			else if (st == "PC") return PC_STATE;
			else return 0;
		}
		#endregion

		#region ICT SPEC READ TO FILE
		public const string project_csv = @"C:\KI\Spec\01.ICT_SPEC\01.project.csv";
		public static string project_name_main;
		public static string project_name_sub;
		public static UInt16 short_auto_pp = 0;
		public static UInt16 short_auto_mm = 0;
		public static UInt32 info_crc32 = 0;
		static void project_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(project_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			//// main project
			string[] split = readbuff[0].Split(',');  // main project
			project_name_main = split[1];
			//// sub project
			split = readbuff[1].Split(',');
			project_name_sub = split[1];
			//// mux on -> skip
			split = readbuff[2].Split(',');
			//// short auto start
			split = readbuff[3].Split(',');
			short_auto_pp = Convert.ToUInt16(split[1]);
			short_auto_mm = Convert.ToUInt16(split[2]);
			
			//StringToByte
			byte[] str_buf1 = util.StringToByte(project_name_main);
			byte[] str_buf2 = util.StringToByte(project_name_sub);

			info_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			for (int i = 0; i < str_buf1.Length; i++)
			{
				info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ str_buf1[i]] ^ (info_crc32 << 8);
			}
			for (int i = 0; i < str_buf2.Length; i++)
			{
				info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ str_buf2[i]] ^ (info_crc32 << 8);
			}
			info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ ((short_auto_pp >> 8 ) &0x00ff)] ^ (info_crc32 << 8);
			info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ ((short_auto_pp >> 0) & 0x00ff)] ^ (info_crc32 << 8);
			info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ ((short_auto_mm >> 8) & 0x00ff)] ^ (info_crc32 << 8);
			info_crc32 = util.crc32_table[(info_crc32 >> 24) ^ ((short_auto_mm >> 0) & 0x00ff)] ^ (info_crc32 << 8);

		}

		public const string tp_csv = @"C:\KI\Spec\01.ICT_SPEC\02.tp.csv";
		public static UInt16 tp_count;
		public static string[] tp_name = new string[720];
		public static UInt16[] tp_number = new UInt16[720];
		public static UInt32 tp_crc32 = 0;
		static void tp_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(tp_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			tp_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{				
				string[] split = readbuff[cnt].Split(',');  // main project

				tp_name[tp_count] = split[1];
				tp_number[tp_count] = Convert.ToUInt16(split[2]);
				tp_count++;
			}

			tp_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			tp_crc32 = util.crc32_table[(tp_crc32 >> 24) ^ ((tp_count >> 8) & 0x00ff)] ^ (tp_crc32 << 8);
			tp_crc32 = util.crc32_table[(tp_crc32 >> 24) ^ ((tp_count >> 0) & 0x00ff)] ^ (tp_crc32 << 8);

			for (int cnt = 0; cnt < tp_count; cnt++)
			{
				byte[] str_buf = util.StringToByte(tp_name[cnt]);
				for (int i = 0; i < str_buf.Length; i++)
				{
					tp_crc32 = util.crc32_table[(tp_crc32 >> 24) ^ str_buf[i]] ^ (tp_crc32 << 8);
				}
				tp_crc32 = util.crc32_table[(tp_crc32 >> 24) ^ ((tp_number[cnt] >> 8) & 0x00ff)] ^ (tp_crc32 << 8);
				tp_crc32 = util.crc32_table[(tp_crc32 >> 24) ^ ((tp_number[cnt] >> 0) & 0x00ff)] ^ (tp_crc32 << 8);
			}
		}

		public const string open_csv = @"C:\KI\Spec\01.ICT_SPEC\03.open.csv";
		public static UInt16 open_count;
		public static UInt16[] open_tp1 = new UInt16[720];
		public static UInt16[] open_tp2 = new UInt16[720];
		public static UInt16[] open_range = new UInt16[720];
		public static float[] open_spec = new float[720];
		public static UInt16[] open_ok_cnt = new UInt16[720];
		public static UInt16[] open_ng_cnt = new UInt16[720];
		public static UInt32 open_crc32 = 0;
		static void open_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(open_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			open_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{
				string[] split = readbuff[cnt].Split(',');  // main project
				open_tp1[open_count] = Convert.ToUInt16(split[1]);
				open_tp2[open_count] = Convert.ToUInt16(split[2]);
				open_range[open_count] = Convert.ToUInt16(split[3]);
				open_spec[open_count] = (float)Convert.ToDouble(split[4]);
				open_ok_cnt[open_count] = Convert.ToUInt16(split[5]);
				open_ng_cnt[open_count] = Convert.ToUInt16(split[6]);
				open_count++;
			}
			
			open_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_count >> 8) & 0x00ff)] ^ (open_crc32 << 8);
			open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_count >> 0) & 0x00ff)] ^ (open_crc32 << 8);
			for (int cnt = 0; cnt < open_count; cnt++)
			{
				Int16 open_spec_temp = (Int16)(open_spec[cnt] * 100);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_tp1[cnt] >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_tp1[cnt] >> 0) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_tp2[cnt] >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_tp2[cnt] >> 0) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_range[cnt] >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_range[cnt] >> 0) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_spec_temp >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_spec_temp >> 0) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_ok_cnt[cnt] >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_ok_cnt[cnt] >> 0) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_ng_cnt[cnt] >> 8) & 0x00ff)] ^ (open_crc32 << 8);
				open_crc32 = util.crc32_table[(open_crc32 >> 24) ^ ((open_ng_cnt[cnt] >> 0) & 0x00ff)] ^ (open_crc32 << 8);
			}
		}

		public const string short_csv = @"C:\KI\Spec\01.ICT_SPEC\04.short.csv";
		public static UInt16 short_bs_count = 0;
		public static UInt16[] short_bs_tp = new UInt16[720];
		public static UInt16[] short_bs_group = new UInt16[720];
		public static UInt16 short_bs_range = 0;
		public static float short_bs_spec = 0;
		public static UInt16 short_bs_ok_cnt = 0;
		public static UInt16 short_bs_ng_cnt = 0;
		public static UInt32 short_crc32 = 0;
		static void short_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(short_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			short_bs_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{
				string[] split = readbuff[cnt].Split(',');  // main project
				short_bs_tp[short_bs_count] = Convert.ToUInt16(split[1]);
				short_bs_group[short_bs_count] = Convert.ToUInt16(split[2]);
				short_bs_count++;

				if (cnt > 1)
					continue;

				short_bs_range = Convert.ToUInt16(split[3]);
				short_bs_spec = (float)Convert.ToDouble(split[4]);
				short_bs_ok_cnt = Convert.ToUInt16(split[5]);
				short_bs_ng_cnt = Convert.ToUInt16(split[6]);
			}

			Int16 short_spec_temp = (Int16)(short_bs_spec * 100);
			short_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_count >> 8) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_count >> 0) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_range >> 8) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_range >> 0) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_ok_cnt >> 8) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_ok_cnt >> 0) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_ng_cnt >> 8) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_ng_cnt >> 0) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_spec_temp >> 8) & 0x00ff)] ^ (short_crc32 << 8);
			short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_spec_temp >> 0) & 0x00ff)] ^ (short_crc32 << 8);

			for (int cnt = 0; cnt < short_bs_count; cnt++)
			{
				short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_tp[cnt] >> 8) & 0x00ff)] ^ (short_crc32 << 8);
				short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_tp[cnt] >> 0) & 0x00ff)] ^ (short_crc32 << 8);
				short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_group[cnt] >> 8) & 0x00ff)] ^ (short_crc32 << 8);
				short_crc32 = util.crc32_table[(short_crc32 >> 24) ^ ((short_bs_group[cnt] >> 0) & 0x00ff)] ^ (short_crc32 << 8);
			}
		}

		public const string short_ex_csv = @"C:\KI\Spec\01.ICT_SPEC\05.short_ex.csv";
		public static UInt16 short_ex_count;
		public static UInt16[] short_ex_tp1 = new UInt16[720];
		public static UInt16[] short_ex_tp2 = new UInt16[720];
		public static UInt16[] short_ex_range = new UInt16[720];
		public static float[] short_ex_spec = new float[720];
		public static UInt16[] short_ex_ok_cnt = new UInt16[720];
		public static UInt16[] short_ex_ng_cnt = new UInt16[720];
		public static UInt32 shortex_crc32 = 0;
		static void shortex_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(short_ex_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			short_ex_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{
				string[] split = readbuff[cnt].Split(',');  // main project
				short_ex_tp1[short_ex_count] = Convert.ToUInt16(split[1]);
				short_ex_tp2[short_ex_count] = Convert.ToUInt16(split[2]);
				short_ex_range[short_ex_count] = Convert.ToUInt16(split[3]);
				short_ex_spec[short_ex_count] = (float)Convert.ToDouble(split[4]);
				short_ex_ok_cnt[short_ex_count] = Convert.ToUInt16(split[5]);
				short_ex_ng_cnt[short_ex_count] = Convert.ToUInt16(split[6]);
				short_ex_count++;
			}

			shortex_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_count >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
			shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_count >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);
			for (int cnt = 0; cnt < short_ex_count; cnt++)
			{
				Int16 shortex_spec_temp = (Int16)(short_ex_spec[cnt] * 100);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_tp1[cnt] >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_tp1[cnt] >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);

				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_tp2[cnt] >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_tp2[cnt] >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);

				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_range[cnt] >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_range[cnt] >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);

				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_ok_cnt[cnt] >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_ok_cnt[cnt] >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);

				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_ng_cnt[cnt] >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((short_ex_ng_cnt[cnt] >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);

				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((shortex_spec_temp >> 8) & 0x00ff)] ^ (shortex_crc32 << 8);
				shortex_crc32 = util.crc32_table[(shortex_crc32 >> 24) ^ ((shortex_spec_temp >> 0) & 0x00ff)] ^ (shortex_crc32 << 8);
			}
		}

		public const string part_csv = @"C:\KI\Spec\01.ICT_SPEC\06.part.csv";
		public static UInt16 part_count;
		public static string[] part_name = new string[720];
		public static UInt16[] part_tp1 = new UInt16[720];
		public static UInt16[] part_tp2 = new UInt16[720];
		public static UInt16[] part_range = new UInt16[720];
		public static float[] part_spec_hi = new float[720];
		public static float[] part_spec_lo = new float[720];
		public static UInt16[] part_ok_cnt = new UInt16[720];
		public static UInt16[] part_ng_cnt = new UInt16[720];
		public static UInt32 part_crc32 = 0;
		static void part_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(part_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			part_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{
				string[] split = readbuff[cnt].Split(',');
				part_name[part_count] = split[1];
				part_tp1[part_count] = Convert.ToUInt16(split[2]);
				part_tp2[part_count] = Convert.ToUInt16(split[3]);
				part_range[part_count] = Convert.ToUInt16(split[4]);
				part_spec_hi[part_count] = (float)Convert.ToDouble(split[5]);
				part_spec_lo[part_count] = (float)Convert.ToDouble(split[6]);
				part_ok_cnt[part_count] = Convert.ToUInt16(split[7]);
				part_ng_cnt[part_count] = Convert.ToUInt16(split[8]);
				part_count++;
			}

			part_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_count >> 8) & 0x00ff)] ^ (part_crc32 << 8);
			part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_count >> 0) & 0x00ff)] ^ (part_crc32 << 8);
			for (int cnt = 0; cnt < part_count; cnt++)
			{
				byte[] str_buf = util.StringToByte(part_name[cnt]);
				for (int i = 0; i < str_buf.Length; i++)
				{
					part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ str_buf[i]] ^ (part_crc32 << 8);
				}
				
				Int16 part1_spec_temp = (Int16)(part_spec_hi[cnt] * 100);
				Int16 part2_spec_temp = (Int16)(part_spec_lo[cnt] * 100);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_tp1[cnt] >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_tp1[cnt] >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_tp2[cnt] >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_tp2[cnt] >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_range[cnt] >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_range[cnt] >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_ok_cnt[cnt] >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_ok_cnt[cnt] >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_ng_cnt[cnt] >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part_ng_cnt[cnt] >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part1_spec_temp >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part1_spec_temp >> 0) & 0x00ff)] ^ (part_crc32 << 8);

				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part2_spec_temp >> 8) & 0x00ff)] ^ (part_crc32 << 8);
				part_crc32 = util.crc32_table[(part_crc32 >> 24) ^ ((part2_spec_temp >> 0) & 0x00ff)] ^ (part_crc32 << 8);
			}
		}

		public static string func_csv = @"C:\KI\Spec\01.ICT_SPEC\07.func.csv";
		public static UInt16 func_count;
		public static string[] func_name = new string[180];
		public static UInt16[] func_type = new UInt16[180];
		public static UInt16[] func_module = new UInt16[180];
		public static UInt16[] func_spec_dec = new UInt16[180];
		public static byte[,] func_spec_hex = new byte[180, 4];
		public static float[] func_spec_float = new float[180];
		public static string[] func_spec_ascii = new string[180];
		public static UInt16[] func_log_flag = new UInt16[180];
		public static UInt16[] func_panel_link = new UInt16[180];
		public static UInt32 func_crc32 = 0;
		static void func_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[1000];

			FileStream fs = new FileStream(func_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			func_count = 0;
			for (int cnt = 1; cnt < line_numer; cnt++)
			{
				string[] split = readbuff[cnt].Split(',');
				func_name[func_count] = split[1];
				func_type[func_count] = pasing_func(split[2]);
                //------------------------------------- 210516 MCH
                //if (func_type[func_count] == MFS_USB) KI.USB_Flag = 1;
                //-------------------------------------
                 func_module[func_count] = Convert.ToUInt16(split[3]);
				if (split[4] == "OK")
					func_log_flag[func_count] = 1;
				else
					func_log_flag[func_count] = 0;
				func_panel_link[func_count] = Convert.ToUInt16(split[5]);
				func_spec_dec[func_count] = Convert.ToUInt16(split[6]);
				string[] hexsplit = split[7].Split('.');
				if (hexsplit.Length == 4)
				{
					func_spec_hex[func_count, 0] = Convert.ToByte(hexsplit[0].Substring(0), 16);
					func_spec_hex[func_count, 1] = Convert.ToByte(hexsplit[1].Substring(0), 16);
					func_spec_hex[func_count, 2] = Convert.ToByte(hexsplit[2].Substring(0), 16);
					func_spec_hex[func_count, 3] = Convert.ToByte(hexsplit[3].Substring(0), 16);
				}
				else
				{
					func_spec_hex[func_count, 0] = func_spec_hex[func_count, 1] = 0;
					func_spec_hex[func_count, 2] = func_spec_hex[func_count, 3] = 0;
				}
				func_spec_float[func_count] = (float)Convert.ToDouble(split[8]);
				func_spec_ascii[func_count] = split[9];
				func_count++;
			}

			func_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_count >> 8) & 0x00ff)] ^ (func_crc32 << 8);
			func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_count >> 0) & 0x00ff)] ^ (func_crc32 << 8);
			for (int cnt = 0; cnt < func_count; cnt++)
			{
				byte[] str_buf = util.StringToByte(func_name[cnt]);
				for (int i = 0; i < str_buf.Length; i++)
				{
					func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ str_buf[i]] ^ (func_crc32 << 8);
				}				

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_type[cnt] >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_type[cnt] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_module[cnt] >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_module[cnt] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_log_flag[cnt] >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_log_flag[cnt] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_panel_link[cnt] >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_panel_link[cnt] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_dec[cnt] >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_dec[cnt] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_hex[cnt, 0] >> 0) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_hex[cnt, 1] >> 0) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_hex[cnt, 2] >> 0) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_hex[cnt, 3] >> 0) & 0x00ff)] ^ (func_crc32 << 8);

				Int16 func_spec_temp = (Int16)(func_spec_float[cnt] * 100);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_temp >> 8) & 0x00ff)] ^ (func_crc32 << 8);
				func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ ((func_spec_temp >> 0) & 0x00ff)] ^ (func_crc32 << 8);
				
				byte[] str_buf1 = util.StringToByte(func_spec_ascii[cnt]);
				for (int i = 0; i < str_buf1.Length; i++)
				{
					func_crc32 = util.crc32_table[(func_crc32 >> 24) ^ str_buf1[i]] ^ (func_crc32 << 8);
				}
			}
		}
//----------------------------------------USB File 관련 
        public static string USBINFO_csv = @"C:\KI\Spec\01.ICT_SPEC\08.usbinfo.csv";
        public static string[] usbinfo_file = new string[180];
        //public static string[] usbinfo_ic = new string[180];
        public static FileInfo fi = new FileInfo(USBINFO_csv);

        static void usb_read2file()
        {
            int line_numer = 0;
            string[] readbuff = new string[1000];

            if(fi.Exists == true)
            { 
                FileStream fs = new FileStream(USBINFO_csv, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                while (!sr.EndOfStream)
                {
                    readbuff[line_numer++] = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                usbinfo_file[line_numer] = readbuff[line_numer];
            }
            else
            {
                MessageBox.Show("No Usbinfo File", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//-----------------------------------------------------------       
       
        //*************************
        // Function Type
        //*************************
        const byte LSI = 1;             // touch
		const byte STM = 2;             // touch
		const byte SYNA = 3;            // touch
		const byte ATMEL = 4;           // touch
		const byte SiW = 5;             // touch
		const byte MELFAS = 6;          // touch
        const byte MFS = 7;             // lgd auto 210514 MCH
        const byte MFS_USB = 8;         // lgd auto 210514 MCH

        const byte SPIFLASH = 10;       // spi flash
		const byte PMIC = 11;			// 
		const byte EEP = 12;
		const byte TPIC = 13;
        const byte LXS_IC = 14;

        public static string find_func_str(byte fn)
		{
			if (fn == LSI)
				return "LSI";
			else if (fn == STM)
				return "STM";
			else if (fn == SYNA)
				return "SYNA";
			else if (fn == ATMEL)
				return "ATMEL";
			else if (fn == SiW)
				return "SiW";
			else if (fn == MELFAS)
				return "MELFAS";
			else if (fn == SPIFLASH)
				return "SPIFLASH";
			else if (fn == PMIC)
				return "PMIC";
			else if (fn == EEP)
				return "EEP";
			else if (fn == TPIC)
				return "TPIC";
			else if (fn == MFS)
                return "MFS";
            else if (fn == MFS_USB)
                return "MFS_USB";
            else
				return "None";
		}
		public static byte pasing_func(string fn)
		{
			if (fn == "S6SY711")
				return LSI;
			else if (fn == "LSI_IC")
				return LSI;
			else if (fn == "STMICRO")
				return STM;
			else if (fn == "Synaptic")
				return SYNA;
			else if (fn == "ATMEL")
				return ATMEL;
			else if (fn == "SiW")
				return SiW;
			else if (fn == "MSS100")
				return MELFAS;
            else if (fn == "MFS_ISC")
                return MFS;
            else if (fn == "MFS_USB")
                return MFS_USB;
            else if (fn == "FLASH")
				return SPIFLASH;
			else if (fn == "PMIC")
				return PMIC;
			else if (fn == "EEP")
				return EEP;
			else if (fn == "TPIC")
				return TPIC;
            else if (fn == "LXS")
                return LXS_IC;
            else
				return 0;
		}
		#endregion

		#region  PANEL SPEC READ TO FILE
		public const string panel_csv = @"C:\KI\Spec\02.PANEL_SPEC\01.panel.csv";
		public static UInt16 panel_count = 0;
		public static UInt16[] panel_tx_num = new UInt16[50];
		public static UInt16[] panel_rx_num = new UInt16[50];
		public static Int16[,] panel_min = new Int16[50, 1800];
		public static Int16[,] panel_max = new Int16[50, 1800];
		public static UInt32 panel_crc32 = 0;
		static void panel_read2file()
		{
			int line_numer = 0;
			string[] readbuff = new string[2000];

			FileStream fs = new FileStream(panel_csv, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.Default);
			while (!sr.EndOfStream)
			{
				readbuff[line_numer++] = sr.ReadLine();
			}
			sr.Close();
			fs.Close();

			int spec_cnt = 0;
			int tx_cnt = 0;
			int node_cnt = 0;
			panel_count = 0;
			for (int i = 0; i < line_numer; i++)
			{
				if (spec_cnt == 0)  //label
				{
					panel_count++;
					spec_cnt++;
				}
				else if (spec_cnt == 1) // trx number
				{
					string[] split = readbuff[i].Split(',');  // 
					panel_tx_num[panel_count - 1] = Convert.ToUInt16(split[1]);
					panel_rx_num[panel_count - 1] = Convert.ToUInt16(split[3]);
					spec_cnt++;
				}
				else if (spec_cnt == 2) // min value label
				{
					spec_cnt++;
					node_cnt = tx_cnt = 0;
				}
				else if (spec_cnt == 3) // min value
				{
					tx_cnt++;
					string[] split = readbuff[i].Split(',');  // 
					for (int cnt = 0; cnt < panel_rx_num[panel_count - 1]; cnt++)
					{
						panel_min[panel_count - 1, node_cnt] = Convert.ToInt16(split[cnt + 1]);
						node_cnt++;
					}
					if (tx_cnt == panel_tx_num[panel_count - 1])
						spec_cnt++;
				}
				else if (spec_cnt == 4) // max value label
				{
					spec_cnt++;
					node_cnt = tx_cnt = 0;
				}
				else if (spec_cnt == 5) // max value
				{
					tx_cnt++;
					string[] split = readbuff[i].Split(',');  // 
					for (int cnt = 0; cnt < panel_rx_num[panel_count - 1]; cnt++)             // rx data read
					{
						panel_max[panel_count - 1, node_cnt] = Convert.ToInt16(split[cnt + 1]);
						node_cnt++;
					}
					if (tx_cnt == panel_tx_num[panel_count - 1])
						spec_cnt = 0;
				}
			}
			spec_cnt = 0;


			panel_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
			panel_crc32 = util.crc32_table[(panel_crc32 >> 24) ^ ((panel_count >> 8) & 0x00ff)] ^ (panel_crc32 << 8);
			panel_crc32 = util.crc32_table[(panel_crc32 >> 24) ^ ((panel_count >> 0) & 0x00ff)] ^ (panel_crc32 << 8);
			for (int cnt = 0; cnt < panel_count; cnt++)
			{
				panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_tx_num[cnt] >> 8) & 0x00ff))] ^ (panel_crc32 << 8);
				panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_tx_num[cnt] >> 0) & 0x00ff))] ^ (panel_crc32 << 8);

				panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_rx_num[cnt] >> 8) & 0x00ff))] ^ (panel_crc32 << 8);
				panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_rx_num[cnt] >> 0) & 0x00ff))] ^ (panel_crc32 << 8);

				UInt16 node = 0;
				for (int tx = 0; tx < panel_tx_num[cnt]; tx++)
				{
					for (int rx = 0; rx < panel_rx_num[cnt]; rx++)
					{
						panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_min[cnt,node] >> 8) & 0x00ff))] ^ (panel_crc32 << 8);
						panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_min[cnt,node] >> 0) & 0x00ff))] ^ (panel_crc32 << 8);

						panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_max[cnt,node] >> 8) & 0x00ff))] ^ (panel_crc32 << 8);
						panel_crc32 = util.crc32_table[((panel_crc32 >> 24) ^ ((panel_max[cnt,node] >> 0) & 0x00ff))] ^ (panel_crc32 << 8);

						node++;
					}
				}
			}
		}
		#endregion

		#region INPUT DATA UPDATE
		public const string data_path = @"C:\KI\Spec\03.DATA_FILE\";
		public static int data_size = 0;
		public static UInt32 data_crc32 = 0;
		public static UInt32 board_crc32 = 0;
		public static string data_name = "Data File Name";
		public static byte[] INPUT_DATA = new byte[496 * 1024];

        public const string boot_path = @"C:\KI\Spec\07.BOOT_FILE\";
        public static int boot_size = 0;
        public static UInt32 boot_crc32 = 0;
        public static UInt32 boardboot_crc32 = 0;
        public static string boot_name = "BOOT File Name";
        public static byte[] INPUT_BOOT = new byte[496 * 1024];

        public static void data_read(string filename)
		{
			FileStream fs = new FileStream(data_path + filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			data_name = filename;
			data_size = (int)fs.Length;
			INPUT_DATA = br.ReadBytes(data_size);

			br.Close();
			fs.Close();
		}
        public static void boot_read(string filename)
        {
            FileStream fs = new FileStream(boot_path + filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            boot_name = filename;
            boot_size = (int)fs.Length;
            INPUT_BOOT = br.ReadBytes(boot_size);

            br.Close();
            fs.Close();
        }

        #endregion

        #region PMIC DATA UPDATE

        public const string pmic_path = @"C:\KI\Spec\04.PMIC_FILE\";
		public static int pmic_size = 0;
		public static UInt32 pmic_crc32 = 0;
		public static UInt32 bd_pmic_crc32 = 0;
		public static string pmic_name = "PMIC File Name";
		public static byte[] INPUT_PMIC = new byte[496 * 1024];
		//public static char[] INPUT_PMIC = new char[496 * 1024];
		//public static byte[] pmic_data = new byte[496 * 1024];

		public static void pmic_read(string filename)
		{
            try
            {
                FileStream fs = new FileStream(pmic_path + filename, FileMode.Open, FileAccess.Read);
                //StreamReader br = new StreamReader(fs); //test
                BinaryReader br = new BinaryReader(fs);

                pmic_name = filename;
                //pmic_size = (int)fs.Length;

                //INPUT_PMIC = br.ReadBytes(pmic_size);

                string strpmic = File.ReadAllText(pmic_path + filename, Encoding.Default); //Test

                string[] PMIC = strpmic.Replace("\n", "").Replace("\r", "").Split(','); //Test

                pmic_size = PMIC.Length; //test

                /********** Sujan **********/                
                if (PMIC[pmic_size - 1] == "")
                {
                    pmic_size = pmic_size - 1;
                    //MessageBox.Show("PMIC last byte is null.\ncount up to " + pmic_size);
                }
                else
                {
                    //MessageBox.Show("PMIC last byte is not null.\ncount up to " + pmic_size);
                }
                /***************************/
                //for (UInt16 cnt = 0; cnt < pmic_size - 1; cnt++) // Test
                for (UInt16 cnt = 0; cnt < pmic_size; cnt++) // Test
                {
                    INPUT_PMIC[cnt] = Convert.ToByte(PMIC[cnt], 16);
                }

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: \n" + ex.ToString());
            }
		}
		#endregion

		#region EEP DATA UPDATE
		public const string eep_path = @"C:\KI\Spec\05.EEP_FILE\";
		public static int eep_size = 0;
		public static UInt32 eep_crc32 = 0;
		public static UInt32 bd_eep_crc32 = 0;
		public static string eep_name = "PMIC File Name";
		public static byte[] INPUT_EEP = new byte[496 * 1024];

		public static void eep_read(string filename)
		{
			FileStream fs = new FileStream(eep_path + filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			eep_name = filename;
			//eep_size = (int)fs.Length;
			//INPUT_EEP = br.ReadBytes(eep_size);

			string strrrp = File.ReadAllText(eep_path + filename, Encoding.Default); //Test

			string[] EEP = strrrp.Replace("\n", "").Replace("\r", "").Split(','); //Test

            //eep_size = EEP.Length; //test
            eep_size = EEP.Length;

            //eep_size = EEP.Length-1;
            if (EEP[eep_size - 1] == "")
            {
                eep_size = eep_size - 1;
                //MessageBox.Show("PMIC last byte is null.\ncount up to " + pmic_size);
            }

            for (UInt16 cnt = 0; cnt < eep_size; cnt++) // Test
			{
				INPUT_EEP[cnt] = Convert.ToByte(EEP[cnt], 16);
			}

			br.Close();
			fs.Close();
		}
		#endregion

		#region TPIC DATA UPDATE
		public const string tpic_path = @"C:\KI\Spec\06.TPIC_FILE\";
		public static int tpic_size = 0;
		public static UInt32 tpic_crc32 = 0;
		public static UInt32 bd_tpic_crc32 = 0;
		public static string tpic_name = "TPIC File Name";
		public static byte[] INPUT_TPIC = new byte[496 * 1024];

		public static void tpic_read(string filename)
		{
			FileStream fs = new FileStream(tpic_path + filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			tpic_name = filename;

			string strtpic = File.ReadAllText(tpic_path + filename, Encoding.Default); //Test

			string[] TPIC = strtpic.Replace("\n", "").Replace("\r", "").Split(','); //Test

			//tpic_size = TPIC.Length - 1; //test
			tpic_size = TPIC.Length; //test

            /********** Sujan **********/
            if (TPIC[tpic_size - 1] == "")
            {
                tpic_size = tpic_size - 1;                
            }
            else
            {
                
            }
            /***************************/
            //for (UInt16 cnt = 0; cnt < tpic_size - 1; cnt++) // Test
            for (UInt16 cnt = 0; cnt < tpic_size; cnt++) // Test
			{
				INPUT_TPIC[cnt] = Convert.ToByte(TPIC[cnt], 16);
			}

			br.Close();
			fs.Close();
		}
		#endregion

		#region Read PC FILE
		public static bool spec_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\01.ICT_SPEC"))
			{
				KI.frm.text_ict.Text = "";
				try
				{
					project_read2file();
					tp_read2file();
					open_read2file();
					short_read2file();
					shortex_read2file();
					part_read2file();
					func_read2file();
                    if (KI.USB_Flag == 1) usb_read2file(); //210516 MCH
                    return true;
				}
				catch
				{
					tp_count = 0;
					open_count = short_bs_count = short_ex_count = 0;
					part_count = func_count = 0;
					MessageBox.Show("Spec Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			else
			{
				MessageBox.Show("No Spec folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		public static bool oper_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\01.ICT_SPEC\Operation"))
			{
				try
				{
					mode1_read2file();
					mode2_read2file();
					mode3_read2file();
					mode4_read2file();
					init_read2file();
					return true;
				}
				catch
				{
					init_sequence = 0;
					mode1_sequence = mode2_sequence = 0;
					mode3_sequence = mode4_sequence = 0;
					MessageBox.Show("Operation Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return false;
				}
			}
			else
			{
				MessageBox.Show("No Operation folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		/*public static bool panel_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\02.PANEL_SPEC"))
			{
				KI.frm.text_panel.Text = "";
				try
				{
					panel_read2file();
				}
				catch
				{
					MessageBox.Show("Panel Spec Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			else
			{
				MessageBox.Show("No Panel folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
			return true;
		}*/ //210514 MCH
        public static bool indata_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\03.DATA_FILE"))
			{
				int file_number = 0;
				string FileName = "";
				KI.frm.text_data.Text = "";
				try
				{
					DirectoryInfo di = new DirectoryInfo(data_path);
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
						data_read(FileName);

						data_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
						for (int i = 0; i < data_size; i++)
						{
							data_crc32 = util.crc32_table[(data_crc32 >> 24) ^ INPUT_DATA[i]] ^ (data_crc32 << 8);
						}

						KI.frm.text_pj_data.Text = data_name;
						KI.frm.text_data.AppendText(String.Format(" - " + data_name));
						KI.frm.text_data.AppendText(Environment.NewLine);
						KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", data_size / 1024));
						KI.frm.text_data.AppendText(Environment.NewLine);
						KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
					}
					else
					{
						data_size = 0;
						data_crc32 = 0;
						data_name = "Data File Name";

						KI.frm.text_data.AppendText(String.Format(" - " + data_name));
						KI.frm.text_data.AppendText(Environment.NewLine);
						KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", data_size / 1024));
						KI.frm.text_data.AppendText(Environment.NewLine);
						KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
						MessageBox.Show("Input Data Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				catch
				{
					data_size = 0;
					data_crc32 = 0;
					data_name = "Data File Name";

					KI.frm.text_data.AppendText(String.Format(" - " + specfile.data_name));
					KI.frm.text_data.AppendText(Environment.NewLine);
					KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", specfile.data_size / 1024));
					KI.frm.text_data.AppendText(Environment.NewLine);
					KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
					MessageBox.Show("Input Data Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			else
			{
				util.dbgmsg("No Data folder");
				//MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
        public static bool inboot_read_file()
        {
            if (Directory.Exists(@"C:\KI\Spec\07.BOOT_FILE"))
            {
                int file_number = 0;
                string FileName = "";
                KI.frm.text_data.Text = "";
                try
                {
                    DirectoryInfo di = new DirectoryInfo(data_path);
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
                        data_read(FileName);

                        data_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
                        for (int i = 0; i < data_size; i++)
                        {
                            data_crc32 = util.crc32_table[(data_crc32 >> 24) ^ INPUT_DATA[i]] ^ (data_crc32 << 8);
                        }

                        KI.frm.text_pj_data.Text = data_name;
                        KI.frm.text_data.AppendText(String.Format(" - " + data_name));
                        KI.frm.text_data.AppendText(Environment.NewLine);
                        KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", data_size / 1024));
                        KI.frm.text_data.AppendText(Environment.NewLine);
                        KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
                    }
                    else
                    {
                        data_size = 0;
                        data_crc32 = 0;
                        data_name = "Data File Name";

                        KI.frm.text_data.AppendText(String.Format(" - " + data_name));
                        KI.frm.text_data.AppendText(Environment.NewLine);
                        KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", data_size / 1024));
                        KI.frm.text_data.AppendText(Environment.NewLine);
                        KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
                        MessageBox.Show("Input Data Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch
                {
                    data_size = 0;
                    data_crc32 = 0;
                    data_name = "Data File Name";

                    KI.frm.text_data.AppendText(String.Format(" - " + specfile.data_name));
                    KI.frm.text_data.AppendText(Environment.NewLine);
                    KI.frm.text_data.AppendText(String.Format(" - Size : {0:F2} kB", specfile.data_size / 1024));
                    KI.frm.text_data.AppendText(Environment.NewLine);
                    KI.frm.text_data.AppendText(String.Format(" - CRC32 : {0:X}", data_crc32));
                    MessageBox.Show("Input Data Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                util.dbgmsg("No Data folder");
                //MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public static bool pmic_read_file()
		{
			//if (Directory.Exists(@"C:\KI\Spec\04.PMIC_FILE"))
			if (Directory.Exists(@"C:\KI\Spec\04.PMIC_FILE")&& Directory.Exists(@"C:\KI\Spec\06.TPIC_FILE"))
			{
				int file_number = 0;
				int file_number2 = 0; //210912
				string FileName = "";
				string FileName2 = ""; //210912
				KI.frm.text_pmic.Text = "";

				try
				{
					DirectoryInfo di = new DirectoryInfo(pmic_path);
					DirectoryInfo di2 = new DirectoryInfo(tpic_path);//210912
					foreach (FileInfo File in di.GetFiles())
					{
						if (file_number == 0)
						{
							FileName = File.Name;
						}
						file_number++;
					}
					//------------------------------------ TPIC
					foreach (FileInfo File2 in di2.GetFiles())
					{
						if (file_number2 == 0)
						{
							FileName2 = File2.Name;
						}
						file_number2++;
					}
					//----------------------------------
					//if (file_number == 1)
					if (file_number == 1&& file_number2 == 1)
					{
						pmic_read(FileName);
						tpic_read(FileName2);//tpic

						pmic_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
						for (int i = 0; i < pmic_size; i++)
						{
							pmic_crc32 = util.crc32_table[(pmic_crc32 >> 24) ^ INPUT_PMIC[i]] ^ (pmic_crc32 << 8);
						}

						tpic_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE); //tpic 210912
						for (int i = 0; i < tpic_size; i++)
						{
							tpic_crc32 = util.crc32_table[(tpic_crc32 >> 24) ^ INPUT_TPIC[i]] ^ (tpic_crc32 << 8);
						}
						//KI.frm.text_pj_data.Text = pmic_name;
						KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));
					}
					else
					{
						pmic_size = 0;
						pmic_crc32 = 0;
						pmic_name = "PMIC File Name";
						//--------------------------
						tpic_size = 0;
						tpic_crc32 = 0;
						tpic_name = "TPIC File Name";
						//--------------------------
						KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
						KI.frm.text_pmic.AppendText(Environment.NewLine);
						KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));

						MessageBox.Show("Input PMIC&TPIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				
				
				}
				catch
				{
					pmic_size = 0;
					pmic_crc32 = 0;
					pmic_name = "PMIC File Name";
					//---------------------------
					tpic_size = 0;
					tpic_crc32 = 0;
					tpic_name = "TPIC File Name";
					//--------------------------
					KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
					//KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} kB", pmic_size / 1024));
					KI.frm.text_pmic.AppendText(Environment.NewLine);
					KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));

					MessageBox.Show("Input PMIC&TPIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

			}
			else
			{
				util.dbgmsg("No PMIC folder");
				//MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
        public static bool pmic_read_file_only()
        {
            if (Directory.Exists(@"C:\KI\Spec\04.PMIC_FILE"))
            {
                int file_number = 0;
                string FileName = "";
                KI.frm.text_pmic.Text = "";

                try
                {
                    DirectoryInfo di = new DirectoryInfo(pmic_path);
                    foreach (FileInfo File in di.GetFiles())
                    {
                        if (file_number == 0)
                        {
                            FileName = File.Name;
                        }
                        file_number++;
                    }
                    
                    //----------------------------------
                    if (file_number == 1)
                    {
                        pmic_read(FileName);

                        pmic_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
                        for (int i = 0; i < pmic_size; i++)
                        {
                            pmic_crc32 = util.crc32_table[(pmic_crc32 >> 24) ^ INPUT_PMIC[i]] ^ (pmic_crc32 << 8);
                        }
                        
                        //KI.frm.text_pj_data.Text = pmic_name;
                        KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);                        
                    }
                    else
                    {
                        pmic_size = 0;
                        pmic_crc32 = 0;
                        pmic_name = "PMIC File Name";
                        //--------------------------
                        KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        MessageBox.Show("Input PMIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                catch
                {
                    pmic_size = 0;
                    pmic_crc32 = 0;
                    pmic_name = "PMIC File Name";
                    //---------------------------
                    KI.frm.text_pmic.AppendText(String.Format(" - " + pmic_name));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", pmic_size));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", pmic_crc32));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    
                    MessageBox.Show("Input PMIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                util.dbgmsg("No PMIC folder");
                //MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool tpic_read_file_only()
        {
            if (Directory.Exists(@"C:\KI\Spec\06.TPIC_FILE"))
            {
                int file_number2 = 0; //210912
                string FileName2 = ""; //210912
                //KI.frm.text_pmic.Text = "";

                try
                {
                    DirectoryInfo di2 = new DirectoryInfo(tpic_path);//210912
                    //------------------------------------ TPIC
                    foreach (FileInfo File2 in di2.GetFiles())
                    {
                        if (file_number2 == 0)
                        {
                            FileName2 = File2.Name;
                        }
                        file_number2++;
                    }
                    //----------------------------------
                    if (file_number2 == 1)
                    {
                        tpic_read(FileName2);//tpic

                        tpic_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE); //tpic 210912
                        for (int i = 0; i < tpic_size; i++)
                        {
                            tpic_crc32 = util.crc32_table[(tpic_crc32 >> 24) ^ INPUT_TPIC[i]] ^ (tpic_crc32 << 8);
                        }                        
                        KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tpic_size = 0;
                        tpic_crc32 = 0;
                        tpic_name = "TPIC File Name";
                        //--------------------------                        
                        KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));
                        KI.frm.text_pmic.AppendText(Environment.NewLine);
                        MessageBox.Show("Input TPIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                catch
                {
                    pmic_size = 0;
                    pmic_crc32 = 0;
                    pmic_name = "PMIC File Name";
                    //---------------------------
                    tpic_size = 0;
                    tpic_crc32 = 0;
                    tpic_name = "TPIC File Name";
                    //--------------------------                    
                    KI.frm.text_pmic.AppendText(String.Format(" - " + tpic_name));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", tpic_size));
                    //KI.frm.text_pmic.AppendText(String.Format(" - Size : {0:F2} kB", pmic_size / 1024));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    KI.frm.text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", tpic_crc32));
                    KI.frm.text_pmic.AppendText(Environment.NewLine);
                    MessageBox.Show("Input TPIC Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                util.dbgmsg("No TPIC folder");
                //MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool eep_read_file()
		{
			if (Directory.Exists(@"C:\KI\Spec\05.EEP_FILE"))
			{
				int file_number = 0;
				string FileName = "";
				KI.frm.text_eep.Text = "";

				try
				{
					DirectoryInfo di = new DirectoryInfo(eep_path);
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
						eep_read(FileName);

						eep_crc32 = util.set_crc32_init_value(util.CRC_INITIALVALUE);
						for (int i = 0; i < eep_size; i++)
						{
							eep_crc32 = util.crc32_table[(eep_crc32 >> 24) ^ INPUT_EEP[i]] ^ (eep_crc32 << 8);
						}

						//KI.frm.text_pj_data.Text = eep_name;
						KI.frm.text_eep.AppendText(String.Format(" - " + eep_name));
						KI.frm.text_eep.AppendText(Environment.NewLine);
						KI.frm.text_eep.AppendText(String.Format(" - Size : {0:F2} kB", eep_size / 1024));
						KI.frm.text_eep.AppendText(Environment.NewLine);
						KI.frm.text_eep.AppendText(String.Format(" - CRC32 : {0:X}", eep_crc32));
					}
					else
					{
						eep_size = 0;
						eep_crc32 = 0;
						eep_name = "EEP File Name";

						KI.frm.text_eep.AppendText(String.Format(" - " + eep_name));
						KI.frm.text_eep.AppendText(Environment.NewLine);
						KI.frm.text_eep.AppendText(String.Format(" - Size : {0:F2} kB", eep_size / 1024));
						KI.frm.text_eep.AppendText(Environment.NewLine);
						KI.frm.text_eep.AppendText(String.Format(" - CRC32 : {0:X}", eep_crc32));
						MessageBox.Show("Input EEP Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
				catch
				{
					eep_size = 0;
					eep_crc32 = 0;
					eep_name = "EEP File Name";

					KI.frm.text_eep.AppendText(String.Format(" - " + specfile.eep_name));
					KI.frm.text_eep.AppendText(Environment.NewLine);
					KI.frm.text_eep.AppendText(String.Format(" - Size : {0:F2} kB", specfile.eep_size / 1024));
					KI.frm.text_eep.AppendText(Environment.NewLine);
					KI.frm.text_eep.AppendText(String.Format(" - CRC32 : {0:X}", eep_crc32));
					MessageBox.Show("Input EEP Read Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

			}
			else
			{
				util.dbgmsg("No EEP folder");
				//MessageBox.Show("No Data folder", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		#endregion
	}
}
