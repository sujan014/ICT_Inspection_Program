using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class Test
	{
		public static bool SensorCheck = false;
		
		public static UInt16 Op_str_idx=0;
		public static UInt16 Op_end_idx=0;
		public static UInt16 Sh_str_idx=0;
		public static UInt16 Sh_end_idx=0;
		public static UInt16 Pt_str_idx=0;
		public static UInt16 Pt_end_idx=0;
		public static UInt16 Fn_str_idx=0;
		public static UInt16 Fn_end_idx=0;

		public static byte op_auto_result = 0;
		public static byte sh_auto_result = 0;
		public static byte pt_auto_result = 0;
		public static byte fn_auto_result = 0;

		public static byte  is_insp_flag = 0;
		public static byte  test_finsh_flag  = 0;
		public static byte  test_result_flag  = 0;
		public static byte  list_disp_flag  = 0;
		public static byte  list_view_mode  = 0;
		
		public static string[] test_item_name = new string[2048];
		public static string[] test_meas_string = new string[2048];
		public static string[] test_meas_string1 = new string[2048];
		public static float[] test_meas_value = new float[2048];
		public static string[] test_result = new string[2048];
		public static UInt16 test_count = 0;

		public static string[] test_ng_item_name = new string[2048];
		public static string[] test_ng_meas_string = new string[2048];
		public static string[] test_ng_result = new string[2048];
		public static UInt16 test_ng_count = 0;

		public static Int16[,] panel_data = new Int16[50,1800];
		public static float[,] panel_dataf = new float[50,1800];
		public static Int16[] ErrorNodeCount = new Int16[50];

		public static Int16[,] sdc_data = new Int16[50,1800];
		public static float[,] sdc_dataf = new float[50,1800];
	}
}
