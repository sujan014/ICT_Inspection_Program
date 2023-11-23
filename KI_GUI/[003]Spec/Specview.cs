using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class specview
	{
		public static int VIEW_SELECT = 0;
		public const int FIRST = 0, NEXT = 1, PREV = 2, STAY = 3, NONE_SEL = 0;
		public const int TESTPOINT_SEL = 1, OPEN_SEL = 2, SHORT_SEL = 3, PART_SEL = 4, SKIP_SEL = 5, FUNC_SEL = 6;
		public const int MODE1_SEL = 7, MODE2_SEL = 8, MODE3_SEL = 9, MODE4_SEL = 10;
		public static int SP_ResultPage = 0, SP_Dsp_Page = 0;
		public const int spec_view_row = 10;

		public static void spec_disp_clear()
		{
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				buff[0] = buff[1] = buff[2] = buff[3] = buff[4] = "";//
				buff[5] = buff[6] = buff[7] = buff[8] = buff[9] = "";//
				spec_disp(cnt + 1, buff);
			}
			KI.frm.text_sv_no.Text = "-";
			KI.frm.text_sv_row1.Text = KI.frm.text_sv_row2.Text = KI.frm.text_sv_row3.Text = "-";
			KI.frm.text_sv_row4.Text = KI.frm.text_sv_row5.Text = KI.frm.text_sv_row6.Text = "-";
			KI.frm.text_sv_row7.Text = KI.frm.text_sv_row8.Text = KI.frm.text_sv_row9.Text = "-";
		}
		public static void spec_disp(int row, string[] item)
		{
			if (row == 1)
			{
				KI.frm.text_sv_no_1.Text = item[0];
				KI.frm.text_sv_row1_1.Text = item[1];
				KI.frm.text_sv_row2_1.Text = item[2];
				KI.frm.text_sv_row3_1.Text = item[3];
				KI.frm.text_sv_row4_1.Text = item[4];
				KI.frm.text_sv_row5_1.Text = item[5];
				KI.frm.text_sv_row6_1.Text = item[6];
				KI.frm.text_sv_row7_1.Text = item[7];
				KI.frm.text_sv_row8_1.Text = item[8];
				KI.frm.text_sv_row9_1.Text = item[9];
			}
			else if (row == 2)
			{
				KI.frm.text_sv_no_2.Text = item[0];
				KI.frm.text_sv_row1_2.Text = item[1];
				KI.frm.text_sv_row2_2.Text = item[2];
				KI.frm.text_sv_row3_2.Text = item[3];
				KI.frm.text_sv_row4_2.Text = item[4];
				KI.frm.text_sv_row5_2.Text = item[5];
				KI.frm.text_sv_row6_2.Text = item[6];
				KI.frm.text_sv_row7_2.Text = item[7];
				KI.frm.text_sv_row8_2.Text = item[8];
				KI.frm.text_sv_row9_2.Text = item[9];
			}
			else if (row == 3)
			{
				KI.frm.text_sv_no_3.Text = item[0];
				KI.frm.text_sv_row1_3.Text = item[1];
				KI.frm.text_sv_row2_3.Text = item[2];
				KI.frm.text_sv_row3_3.Text = item[3];
				KI.frm.text_sv_row4_3.Text = item[4];
				KI.frm.text_sv_row5_3.Text = item[5];
				KI.frm.text_sv_row6_3.Text = item[6];
				KI.frm.text_sv_row7_3.Text = item[7];
				KI.frm.text_sv_row8_3.Text = item[8];
				KI.frm.text_sv_row9_3.Text = item[9];
			}
			else if (row == 4)
			{
				KI.frm.text_sv_no_4.Text = item[0];
				KI.frm.text_sv_row1_4.Text = item[1];
				KI.frm.text_sv_row2_4.Text = item[2];
				KI.frm.text_sv_row3_4.Text = item[3];
				KI.frm.text_sv_row4_4.Text = item[4];
				KI.frm.text_sv_row5_4.Text = item[5];
				KI.frm.text_sv_row6_4.Text = item[6];
				KI.frm.text_sv_row7_4.Text = item[7];
				KI.frm.text_sv_row8_4.Text = item[8];
				KI.frm.text_sv_row9_4.Text = item[9];
			}
			else if (row == 5)
			{
				KI.frm.text_sv_no_5.Text = item[0];
				KI.frm.text_sv_row1_5.Text = item[1];
				KI.frm.text_sv_row2_5.Text = item[2];
				KI.frm.text_sv_row3_5.Text = item[3];
				KI.frm.text_sv_row4_5.Text = item[4];
				KI.frm.text_sv_row5_5.Text = item[5];
				KI.frm.text_sv_row6_5.Text = item[6];
				KI.frm.text_sv_row7_5.Text = item[7];
				KI.frm.text_sv_row8_5.Text = item[8];
				KI.frm.text_sv_row9_5.Text = item[9];
			}
			else if (row == 6)
			{
				KI.frm.text_sv_no_6.Text = item[0];
				KI.frm.text_sv_row1_6.Text = item[1];
				KI.frm.text_sv_row2_6.Text = item[2];
				KI.frm.text_sv_row3_6.Text = item[3];
				KI.frm.text_sv_row4_6.Text = item[4];
				KI.frm.text_sv_row5_6.Text = item[5];
				KI.frm.text_sv_row6_6.Text = item[6];
				KI.frm.text_sv_row7_6.Text = item[7];
				KI.frm.text_sv_row8_6.Text = item[8];
				KI.frm.text_sv_row9_6.Text = item[9];
			}
			else if (row == 7)
			{
				KI.frm.text_sv_no_7.Text = item[0];
				KI.frm.text_sv_row1_7.Text = item[1];
				KI.frm.text_sv_row2_7.Text = item[2];
				KI.frm.text_sv_row3_7.Text = item[3];
				KI.frm.text_sv_row4_7.Text = item[4];
				KI.frm.text_sv_row5_7.Text = item[5];
				KI.frm.text_sv_row6_7.Text = item[6];
				KI.frm.text_sv_row7_7.Text = item[7];
				KI.frm.text_sv_row8_7.Text = item[8];
				KI.frm.text_sv_row9_7.Text = item[9];
			}
			else if (row == 8)
			{
				KI.frm.text_sv_no_8.Text = item[0];
				KI.frm.text_sv_row1_8.Text = item[1];
				KI.frm.text_sv_row2_8.Text = item[2];
				KI.frm.text_sv_row3_8.Text = item[3];
				KI.frm.text_sv_row4_8.Text = item[4];
				KI.frm.text_sv_row5_8.Text = item[5];
				KI.frm.text_sv_row6_8.Text = item[6];
				KI.frm.text_sv_row7_8.Text = item[7];
				KI.frm.text_sv_row8_8.Text = item[8];
				KI.frm.text_sv_row9_8.Text = item[9];
			}
			else if (row == 9)
			{
				KI.frm.text_sv_no_9.Text = item[0];
				KI.frm.text_sv_row1_9.Text = item[1];
				KI.frm.text_sv_row2_9.Text = item[2];
				KI.frm.text_sv_row3_9.Text = item[3];
				KI.frm.text_sv_row4_9.Text = item[4];
				KI.frm.text_sv_row5_9.Text = item[5];
				KI.frm.text_sv_row6_9.Text = item[6];
				KI.frm.text_sv_row7_9.Text = item[7];
				KI.frm.text_sv_row8_9.Text = item[8];
				KI.frm.text_sv_row9_9.Text = item[9];
			}
			else if (row == 10)
			{
				KI.frm.text_sv_no_10.Text = item[0];
				KI.frm.text_sv_row1_10.Text = item[1];
				KI.frm.text_sv_row2_10.Text = item[2];
				KI.frm.text_sv_row3_10.Text = item[3];
				KI.frm.text_sv_row4_10.Text = item[4];
				KI.frm.text_sv_row5_10.Text = item[5];
				KI.frm.text_sv_row6_10.Text = item[6];
				KI.frm.text_sv_row7_10.Text = item[7];
				KI.frm.text_sv_row8_10.Text = item[8];
				KI.frm.text_sv_row9_10.Text = item[9];
			}
		}
		public static void View_TP_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "TP View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Name";
				KI.frm.text_sv_row2.Text = "Number";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.tp_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}

			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.tp_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.tp_name[cnt + SP_Dsp_Page * spec_view_row];
					buff[2] = specfile.tp_number[cnt + SP_Dsp_Page * spec_view_row].ToString();
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}

			KI.frm.text_sv_view_mode.Text = String.Format("TP View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_Open_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Open View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "TP1-TP2";
				KI.frm.text_sv_row2.Text = "Range";
				KI.frm.text_sv_row3.Text = "Spec";
				KI.frm.text_sv_row4.Text = "OK";
				KI.frm.text_sv_row5.Text = "NG";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.open_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.open_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = (specfile.open_tp1[cnt + SP_Dsp_Page * spec_view_row]).ToString() + "-" + (specfile.open_tp2[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[2] = (specfile.open_range[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[3] = (specfile.open_spec[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[4] = (specfile.open_ok_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[5] = (specfile.open_ng_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Open View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_Short_bs_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Short Base View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "TP";
				KI.frm.text_sv_row2.Text = "Group";
				KI.frm.text_sv_row3.Text = "Range";
				KI.frm.text_sv_row4.Text = "Spec";
				KI.frm.text_sv_row5.Text = "OK";
				KI.frm.text_sv_row6.Text = "NG";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.short_bs_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.short_bs_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = (specfile.short_bs_tp[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[2] = (specfile.short_bs_group[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[3] = (specfile.short_bs_range).ToString();
					buff[4] = (specfile.short_bs_spec).ToString();
					buff[5] = (specfile.short_bs_ok_cnt).ToString();
					buff[6] = (specfile.short_bs_ng_cnt).ToString();
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Short Base View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_Short_ex_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Short Ex View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "TP";
				KI.frm.text_sv_row2.Text = "Range";
				KI.frm.text_sv_row3.Text = "Spec";
				KI.frm.text_sv_row4.Text = "OK";
				KI.frm.text_sv_row5.Text = "NG";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.short_ex_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.short_ex_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = (specfile.short_ex_tp1[cnt + SP_Dsp_Page * spec_view_row]).ToString() + "-" + (specfile.short_ex_tp2[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[2] = (specfile.short_ex_range[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[3] = (specfile.short_ex_spec[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[4] = (specfile.short_ex_ok_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[5] = (specfile.short_ex_ng_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Short Ex View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_Part_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Part View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Name";
				KI.frm.text_sv_row2.Text = "TP1-TP2";
				KI.frm.text_sv_row3.Text = "Range";
				KI.frm.text_sv_row4.Text = "Upper";
				KI.frm.text_sv_row5.Text = "Lower";
				KI.frm.text_sv_row6.Text = "OK";
				KI.frm.text_sv_row7.Text = "NG";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.part_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.part_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.part_name[cnt + SP_Dsp_Page * spec_view_row];
					buff[2] = (specfile.part_tp1[cnt + SP_Dsp_Page * spec_view_row]).ToString() + "-" + (specfile.part_tp2[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[3] = (specfile.part_range[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[4] = (specfile.part_spec_hi[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[5] = (specfile.part_spec_lo[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[6] = (specfile.part_ok_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[7] = (specfile.part_ng_cnt[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Part View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_Func_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Function View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Name";
				KI.frm.text_sv_row2.Text = "Type";
				KI.frm.text_sv_row3.Text = "Num";
				KI.frm.text_sv_row4.Text = "DDD";
				KI.frm.text_sv_row5.Text = "HEX";
				KI.frm.text_sv_row6.Text = "Float";
				KI.frm.text_sv_row7.Text = "Ascii";
				KI.frm.text_sv_row8.Text = "Log";
				KI.frm.text_sv_row9.Text = "P.L";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.func_count - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.func_count)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.func_name[cnt + SP_Dsp_Page * spec_view_row];
					buff[2] = specfile.find_func_str((byte)specfile.func_type[cnt + SP_Dsp_Page * spec_view_row]);
					buff[3] = (specfile.func_module[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[4] = (specfile.func_spec_dec[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					string temp1 = String.Format("{0:X02}.", specfile.func_spec_hex[cnt + SP_Dsp_Page * spec_view_row, 0]);
					string temp2 = String.Format("{0:X02}.", specfile.func_spec_hex[cnt + SP_Dsp_Page * spec_view_row, 1]);
					string temp3 = String.Format("{0:X02}.", specfile.func_spec_hex[cnt + SP_Dsp_Page * spec_view_row, 2]);
					string temp4 = String.Format("{0:X02}.", specfile.func_spec_hex[cnt + SP_Dsp_Page * spec_view_row, 3]);
					buff[5] = temp1 + temp2 + temp3 + temp4;
					buff[6] = (specfile.func_spec_float[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[7] = (specfile.func_spec_ascii[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[8] = (specfile.func_log_flag[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					buff[9] = (specfile.func_panel_link[cnt + SP_Dsp_Page * spec_view_row]).ToString();
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Function View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_mode1_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Mode1 View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Run";
				KI.frm.text_sv_row2.Text = "State";
				KI.frm.text_sv_row3.Text = "Num";
				KI.frm.text_sv_row4.Text = "Time";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.mode1_sequence - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.mode1_sequence)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.find_mode_str((byte)specfile.mode1_operation[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[2] = specfile.find_state_str((byte)specfile.mode1_status[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[3] = specfile.mode1_number[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[4] = specfile.mode1_time[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Mode1 View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_mode2_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Mode2 View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Run";
				KI.frm.text_sv_row2.Text = "State";
				KI.frm.text_sv_row3.Text = "Num";
				KI.frm.text_sv_row4.Text = "Time";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.mode2_sequence - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.mode2_sequence)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.find_mode_str((byte)specfile.mode2_operation[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[2] = specfile.find_state_str((byte)specfile.mode2_status[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[3] = specfile.mode2_number[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[4] = specfile.mode2_time[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Mode2 View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_mode3_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Mode3 View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Run";
				KI.frm.text_sv_row2.Text = "State";
				KI.frm.text_sv_row3.Text = "Num";
				KI.frm.text_sv_row4.Text = "Time";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.mode3_sequence - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.mode3_sequence)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.find_mode_str((byte)specfile.mode3_operation[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[2] = specfile.find_state_str((byte)specfile.mode3_status[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[3] = specfile.mode3_number[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[4] = specfile.mode3_time[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Mode3 View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void View_mode4_Spec(int wheel)
		{
			if (wheel == FIRST)
			{
				spec_disp_clear();
				KI.frm.text_sv_view_mode.Text = "Mode4 View";
				KI.frm.text_sv_no.Text = "No";
				KI.frm.text_sv_row1.Text = "Run";
				KI.frm.text_sv_row2.Text = "State";
				KI.frm.text_sv_row3.Text = "Num";
				KI.frm.text_sv_row4.Text = "Time";
				SP_Dsp_Page = 0;
				SP_ResultPage = (specfile.mode4_sequence - 1) / spec_view_row;
			}
			else if (wheel == NEXT)
			{
				SP_Dsp_Page++;
				if (SP_Dsp_Page > SP_ResultPage)
					SP_Dsp_Page = 0;
			}
			else if (wheel == PREV)
			{
				SP_Dsp_Page--;
				if (SP_Dsp_Page < 0)
					SP_Dsp_Page = SP_ResultPage;
			}
			string[] buff = new string[10];
			for (int cnt = 0; cnt < spec_view_row; cnt++)
			{
				if (cnt + SP_Dsp_Page * spec_view_row < specfile.mode4_sequence)
				{
					buff[0] = (cnt + SP_Dsp_Page * spec_view_row + 1).ToString();
					buff[1] = specfile.find_mode_str((byte)specfile.mode4_operation[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[2] = specfile.find_state_str((byte)specfile.mode4_status[(cnt + SP_Dsp_Page * spec_view_row)]);
					buff[3] = specfile.mode4_number[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[4] = specfile.mode4_time[(cnt + SP_Dsp_Page * spec_view_row)].ToString();
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
				else
				{
					buff[0] = "";//
					buff[1] = "";//
					buff[2] = "";//
					buff[3] = "";//
					buff[4] = "";//
					buff[5] = "";//
					buff[6] = "";//
					buff[7] = "";//
					buff[8] = "";//
					buff[9] = "";//
					spec_disp(cnt + 1, buff);
				}
			}
			KI.frm.text_sv_view_mode.Text = String.Format("Mode4 View {0}/{1}", SP_Dsp_Page + 1, SP_ResultPage + 1);
		}
		public static void next_button()
		{
			if (VIEW_SELECT == TESTPOINT_SEL)
				View_TP_Spec(NEXT);
			else if (VIEW_SELECT == OPEN_SEL)
				View_Open_Spec(NEXT);
			else if (VIEW_SELECT == SHORT_SEL)
				View_Short_bs_Spec(NEXT);
			else if (VIEW_SELECT == PART_SEL)
				View_Part_Spec(NEXT);
			else if (VIEW_SELECT == SKIP_SEL)
				View_Short_ex_Spec(NEXT);
			else if (VIEW_SELECT == FUNC_SEL)
				View_Func_Spec(NEXT);
			else if (VIEW_SELECT == MODE1_SEL)
				View_mode1_Spec(NEXT);
			else if (VIEW_SELECT == MODE2_SEL)
				View_mode2_Spec(NEXT);
			else if (VIEW_SELECT == MODE3_SEL)
				View_mode3_Spec(NEXT);
			else if (VIEW_SELECT == MODE4_SEL)
				View_mode4_Spec(NEXT);
		}
		public static void pre_button()
		{
			if (VIEW_SELECT == TESTPOINT_SEL)
				View_TP_Spec(PREV);
			else if (VIEW_SELECT == OPEN_SEL)
				View_Open_Spec(PREV);
			else if (VIEW_SELECT == SHORT_SEL)
				View_Short_bs_Spec(PREV);
			else if (VIEW_SELECT == PART_SEL)
				View_Part_Spec(PREV);
			else if (VIEW_SELECT == SKIP_SEL)
				View_Short_ex_Spec(PREV);
			else if (VIEW_SELECT == FUNC_SEL)
				View_Func_Spec(PREV);
			else if (VIEW_SELECT == MODE1_SEL)
				View_mode1_Spec(PREV);
			else if (VIEW_SELECT == MODE2_SEL)
				View_mode2_Spec(PREV);
			else if (VIEW_SELECT == MODE3_SEL)
				View_mode3_Spec(PREV);
			else if (VIEW_SELECT == MODE4_SEL)
				View_mode4_Spec(PREV);
		}
		public static void first_button()
		{
			if (VIEW_SELECT == TESTPOINT_SEL)
				View_TP_Spec(FIRST);
			else if (VIEW_SELECT == OPEN_SEL)
				View_Open_Spec(FIRST);
			else if (VIEW_SELECT == SHORT_SEL)
				View_Short_bs_Spec(FIRST);
			else if (VIEW_SELECT == PART_SEL)
				View_Part_Spec(FIRST);
			else if (VIEW_SELECT == SKIP_SEL)
				View_Short_ex_Spec(FIRST);
			else if (VIEW_SELECT == FUNC_SEL)
				View_Func_Spec(FIRST);
			else if (VIEW_SELECT == MODE1_SEL)
				View_mode1_Spec(FIRST);
			else if (VIEW_SELECT == MODE2_SEL)
				View_mode2_Spec(FIRST);
			else if (VIEW_SELECT == MODE3_SEL)
				View_mode3_Spec(FIRST);
			else if (VIEW_SELECT == MODE4_SEL)
				View_mode4_Spec(FIRST);
		}
	}
}
