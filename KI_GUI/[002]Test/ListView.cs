using System;
using System.Diagnostics; //210516 MCH
using System.ComponentModel; //210516 MCH
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KI_GUI
{
	class listview
	{
		const byte TRUE = 1, FALSE = 0, CLEAR = 2;
		const byte ON = 1, OFF = 0;
		


		#region ListView Create
		public const int listview_max_row = 15;
		public static TextBox[] list_num, list_item, list_meas, list_rst;
		public static TextBox list_page;
		public static void listview_create()
		{
			create_list_num();
			create_list_item();
			create_list_meas();
			create_list_rst();
			create_list_page();
			listview_clear();
		}
		public static void create_list_num()
		{
			list_num = new TextBox[listview_max_row];
			Font myfont = new Font("Yu Gothic UI", 14.25f);
			for (int idx = 0; idx < listview_max_row; idx++)
			{
				list_num[idx] = new TextBox(); // 기본옵션 설정 
				list_num[idx].Name = "list_no" + idx.ToString("00");
				list_num[idx].Text = "";
				list_num[idx].Width = 52;
				list_num[idx].Height = 26;
				list_num[idx].Font = myfont;
				list_num[idx].BackColor = Color.White;
				list_num[idx].ForeColor = Color.Black;
				list_num[idx].ReadOnly = true;
				list_num[idx].BorderStyle = BorderStyle.None;
				list_num[idx].Location = new Point(1, 39 + 27 * idx);
				list_num[idx].TextAlign = HorizontalAlignment.Center;

				KI.frm.tabMain.Controls.Add(list_num[idx]);
			}
		}
		public static void create_list_item()
		{
			list_item = new TextBox[listview_max_row];
			Font myfont = new Font("Yu Gothic UI", 14.25f);
			for (int idx = 0; idx < listview_max_row; idx++)
			{
				list_item[idx] = new TextBox(); // 기본옵션 설정 
				list_item[idx].Name = "list_item" + idx.ToString("00");
				list_item[idx].Text = "";
				list_item[idx].Width = 249;
				list_item[idx].Height = 26;
				list_item[idx].Font = myfont;
				list_item[idx].BackColor = Color.White;
				list_item[idx].ForeColor = Color.Black;
				list_item[idx].ReadOnly = true;
				list_item[idx].BorderStyle = BorderStyle.None;
				list_item[idx].Location = new Point(54, 39 + 27 * idx);
				list_item[idx].TextAlign = HorizontalAlignment.Center;
				KI.frm.tabMain.Controls.Add(list_item[idx]);
			}
		}
		public static void create_list_meas()
		{
			list_meas = new TextBox[listview_max_row];
			Font myfont = new Font("Yu Gothic UI", 14.25f);
			for (int idx = 0; idx < listview_max_row; idx++)
			{
				list_meas[idx] = new TextBox(); // 기본옵션 설정 
				list_meas[idx].Name = "list_meas" + idx.ToString("00");
				list_meas[idx].Text = "";
				list_meas[idx].Width = 378;
				list_meas[idx].Height = 26;
				list_meas[idx].Font = myfont;
				list_meas[idx].BackColor = Color.White;
				list_meas[idx].ForeColor = Color.Black;
				list_meas[idx].ReadOnly = true;
				list_meas[idx].BorderStyle = BorderStyle.None;
				list_meas[idx].Location = new Point(304, 39 + 27 * idx);
				list_meas[idx].TextAlign = HorizontalAlignment.Center;
				KI.frm.tabMain.Controls.Add(list_meas[idx]);
			}
		}
		public static void create_list_rst()
		{
			list_rst = new TextBox[listview_max_row];
			Font myfont = new Font("Yu Gothic UI", 14.25f);
			for (int idx = 0; idx < listview_max_row; idx++)
			{
				list_rst[idx] = new TextBox(); // 기본옵션 설정 
				list_rst[idx].Name = "list_rst" + idx.ToString("00");
				list_rst[idx].Text = "";
				list_rst[idx].Width = 80;
				list_rst[idx].Height = 26;
				list_rst[idx].Font = myfont;
				list_rst[idx].BackColor = Color.White;
				list_rst[idx].ForeColor = Color.Black;
				list_rst[idx].ReadOnly = true;
				list_rst[idx].BorderStyle = BorderStyle.None;
				list_rst[idx].Location = new Point(683, 39 + 27 * idx);
				list_rst[idx].TextAlign = HorizontalAlignment.Center;
				KI.frm.tabMain.Controls.Add(list_rst[idx]);
			}
		}
		public static void create_list_page()
		{
			Font myfont = new Font("Yu Gothic UI", 14.25f);
			list_page = new TextBox(); // 기본옵션 설정 
			list_page.Name = "list_page";
			list_page.Text = "";
			list_page.Width = 762;
			list_page.Height = 26;
			list_page.Font = myfont;
			list_page.BackColor = Color.DarkGray;
			list_page.ForeColor = Color.Black;
			list_page.ReadOnly = true;
			list_page.BorderStyle = BorderStyle.None;
			list_page.Location = new Point(1, 39 + 27 * 15);
			list_page.TextAlign = HorizontalAlignment.Center;
			KI.frm.tabMain.Controls.Add(list_page);
		}
		#endregion

		#region ListView Disp
		public static int listview_row_num = 0;
		public static void listview_clear()
		{
			for (int idx = 0; idx < listview_max_row; idx++)
			{
				list_num[idx].Text = "";
				list_item[idx].Text = "";
				list_meas[idx].Text = "";
				list_rst[idx].Text = "";
				list_rst[idx].ForeColor = Color.Black;
			}
			list_page.Text = "";
		}
		public static void listview_result(byte[] result)
		{
			string[] temp = util.ByteToString(result).Split(',');
			Test.test_count = Convert.ToUInt16(temp[0]);
			Test.test_item_name[Test.test_count - 1] = temp[1];
			Test.test_meas_string[Test.test_count - 1] = temp[2];
			Test.test_result[Test.test_count - 1] = temp[3];

			int cur_page = (Test.test_count - 1) / 15;
			listview_row_num = Test.test_count - (cur_page * 15);

			if (listview_row_num == 1)
			{
				listview_clear();
			}

			if (Test.test_result[Test.test_count - 1] == "P")
			{
				list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
				list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
				list_meas[listview_row_num - 1].Text = Test.test_meas_string[Test.test_count - 1];
				list_rst[listview_row_num - 1].Text = "PASS";
				list_rst[listview_row_num - 1].ForeColor = Color.Blue;
			}
			else if (Test.test_result[Test.test_count - 1] == "F")
			{
				list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
				list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
				list_meas[listview_row_num - 1].Text = Test.test_meas_string[Test.test_count - 1];
				list_rst[listview_row_num - 1].Text = "FAIL";
				list_rst[listview_row_num - 1].ForeColor = Color.Red;
			}
			else if (Test.test_result[Test.test_count - 1] == "S")
			{
				list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
				list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
				list_meas[listview_row_num - 1].Text = Test.test_meas_string[Test.test_count - 1];
				list_rst[listview_row_num - 1].Text = "SKIP";
				list_rst[listview_row_num - 1].ForeColor = Color.DarkGreen;
			}
			else if (Test.test_result[Test.test_count - 1] == "B")
			{
				list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
				list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
				list_meas[listview_row_num - 1].Text = "~ing...";
				list_rst[listview_row_num - 1].Text = "BUSY";
				list_rst[listview_row_num - 1].ForeColor = Color.DarkBlue;
			}

            else if (Test.test_result[Test.test_count - 1] == "U")
            {
                list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
                list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
                list_meas[listview_row_num - 1].Text = "Verify...";
                list_rst[listview_row_num - 1].Text = "BUSY";
                list_rst[listview_row_num - 1].ForeColor = Color.DarkBlue;
            }

            else if (Test.test_result[Test.test_count - 1] == "I")
            {
                list_num[listview_row_num - 1].Text = (Test.test_count).ToString();
                list_item[listview_row_num - 1].Text = Test.test_item_name[Test.test_count - 1];
                list_meas[listview_row_num - 1].Text = "Download...";
                list_rst[listview_row_num - 1].Text = "BUSY";
                list_rst[listview_row_num - 1].ForeColor = Color.DarkBlue;
            }

            list_page.Text = "Page : " + (cur_page + 1).ToString();
		}
		#endregion

		#region ListView Result	
		public static Int16 Result_Total_Page = 0, Result_Display_Page = 0;
		public static Int16 NG_Result_Total_Page = 0, NG_Result_Display_Page = 0;

		public static void result_disp(byte wheel, byte mode)
		{
			KI.frm.tab.SelectedIndex = KI.MAIN_DISP;
			main_popup(FALSE, "");

			if (Test.list_disp_flag == TRUE)
			{
				wheel = 2;
				mode = FALSE;
				Test.list_disp_flag = FALSE;
			}
			if (mode == TRUE)
			{
				Test.list_view_mode++;
				if (Test.list_view_mode == 2)
					Test.list_view_mode = 0;
			}
			if (Test.test_finsh_flag == TRUE)
			{
				listview_clear();

				if (wheel == 0)
				{
					if (Test.list_view_mode == 0)
						Result_Display_Page--;
					else if (Test.list_view_mode == 1)
						NG_Result_Display_Page--;
				}
				else if (wheel == 1)
				{
					if (Test.list_view_mode == 0)
						Result_Display_Page++;
					else if (Test.list_view_mode == 1)
						NG_Result_Display_Page++;
				}
				else if (wheel == 2)
				{
					if (Test.list_view_mode == 0)
					{
						Result_Total_Page = (Int16)((Test.test_count - 1) / 15);
						Result_Display_Page = 0;
					}
					else if (Test.list_view_mode == 1)
					{
						Test.test_ng_count = 0;
						for (int cnt = 0; cnt < Test.test_count; cnt++)
						{
							if (Test.test_result[cnt] == "F")
							{
								Test.test_ng_result[Test.test_ng_count] = "F";
								Test.test_ng_item_name[Test.test_ng_count] = Test.test_item_name[cnt];
								Test.test_ng_meas_string[Test.test_ng_count] = Test.test_meas_string[cnt];
								Test.test_ng_count++;
							}
						}
						NG_Result_Total_Page = (Int16)((Test.test_ng_count - 1) / 15);
						NG_Result_Display_Page = 0;
					}
				}
				if (Test.list_view_mode == 0)
				{
					if (Result_Display_Page > Result_Total_Page)
						Result_Display_Page = 0;
					else if (Result_Display_Page < 0)
						Result_Display_Page = Result_Total_Page;

					for (int idx = 0; idx < 15; idx++)
					{
						if (idx + Result_Display_Page * 15 < Test.test_count)
						{
							list_num[idx].Text = (idx + Result_Display_Page * 15 + 1).ToString();
							list_item[idx].Text = Test.test_item_name[idx + Result_Display_Page * 15];
							list_meas[idx].Text = Test.test_meas_string[idx + Result_Display_Page * 15];

							if (Test.test_result[idx + Result_Display_Page * 15] == "P")
							{
								list_rst[idx].Text = "PASS";
								list_rst[idx].ForeColor = Color.Blue;
							}
							else if (Test.test_result[idx + Result_Display_Page * 15] == "F")
							{
								list_rst[idx].Text = "FAIL";
								list_rst[idx].ForeColor = Color.Red;
							}
							else if (Test.test_result[idx + Result_Display_Page * 15] == "S")
							{
								list_rst[idx].Text = "SKIP";
								list_rst[idx].ForeColor = Color.DarkGreen;
							}
							else if (Test.test_result[idx + Result_Display_Page * 15] == "B")
							{
								list_rst[idx].Text = "BUSY";
								list_rst[idx].ForeColor = Color.DarkGreen;
							}
                            else if (Test.test_result[idx + Result_Display_Page * 15] == "I") //210516 MCH
                            {
                                list_rst[idx].Text = "USB_WRITE";
                                list_rst[idx].ForeColor = Color.DarkGreen;

                                
                                
                                
                                
                                //Process MIT_Process = new Process();
                                
                                



                            }
                            else if (Test.test_result[idx + Result_Display_Page * 15] == "U") //210516 MCH
                            {
                                list_rst[idx].Text = "USB_VERIFY";
                                list_rst[idx].ForeColor = Color.DarkGreen;
                            }
                        }
					}
					list_page.Text = String.Format("ALL: {0} / {1}", Result_Display_Page + 1, Result_Total_Page + 1);
				}
				else if (Test.list_view_mode == 1)
				{
					if (NG_Result_Display_Page > NG_Result_Total_Page)
						NG_Result_Display_Page = 0;
					else if (NG_Result_Display_Page < 0)
						NG_Result_Display_Page = NG_Result_Total_Page;

					for (int idx = 0; idx < 15; idx++)
					{
						if (idx + NG_Result_Display_Page * 15 < Test.test_ng_count)
						{
							list_num[idx].Text = (idx + NG_Result_Display_Page * 15 + 1).ToString();
							list_item[idx].Text = Test.test_ng_item_name[idx + NG_Result_Display_Page * 15];
							list_meas[idx].Text = Test.test_ng_meas_string[idx + NG_Result_Display_Page * 15];

							if (Test.test_ng_result[idx + NG_Result_Display_Page * 15] == "P")
							{
								list_rst[idx].Text = "PASS";
								list_rst[idx].ForeColor = Color.Blue;
							}
							else if (Test.test_ng_result[idx + NG_Result_Display_Page * 15] == "F")
							{
								list_rst[idx].Text = "FAIL";
								list_rst[idx].ForeColor = Color.Red;
							}
							else if (Test.test_ng_result[idx + NG_Result_Display_Page * 15] == "S")
							{
								list_rst[idx].Text = "SKIP";
								list_rst[idx].ForeColor = Color.DarkGreen;
							}
							else if (Test.test_ng_result[idx + NG_Result_Display_Page * 15] == "B")
							{
								list_rst[idx].Text = "BUSY";
								list_rst[idx].ForeColor = Color.DarkGreen;
							}
						}
					}
					list_page.Text = String.Format("FAIL: {0} / {1}", NG_Result_Display_Page + 1, NG_Result_Total_Page + 1);
				}
			}
		}
		#endregion

		#region ListView Popup
		
		public static void sub_popup(byte flag, string msg)
		{
			if (flag == FALSE)
			{
				KI.frm.bt_sub_popup.Hide();
			}
			else
			{
				KI.frm.bt_sub_popup.Show();
				KI.frm.bt_sub_popup.Text = msg;
			}
			KI.frm.Refresh();
		}
		public static void main_popup(byte flag, string msg)
		{
			KI.frm.text_popup1.Text = "";
			KI.frm.text_popup2.Text = "";
			KI.frm.text_popup3.Text = "";
			KI.frm.text_popup4.Text = "";
			KI.frm.text_result.Text = "";

			if (flag == FALSE)
			{
				KI.frm.pn_result.Hide();
			}
			else
			{
				string[] buff = msg.Split('\n');

				if (buff.Length == 1)
				{
					KI.frm.text_popup1.Text = "";
					KI.frm.text_popup2.Text = buff[0];
					KI.frm.text_popup3.Text = "";
					KI.frm.text_popup4.Text = "";
				}
				else if (buff.Length == 2)
				{
					KI.frm.text_popup1.Text = buff[0];
					KI.frm.text_popup2.Text = "";
					KI.frm.text_popup3.Text = buff[1];
					KI.frm.text_popup4.Text = "";
				}
				else if (buff.Length == 3)
				{
					KI.frm.text_popup1.Text = buff[0];
					KI.frm.text_popup2.Text = buff[1];
					KI.frm.text_popup3.Text = buff[2];
					KI.frm.text_popup4.Text = "";
				}
				else if (buff.Length == 4)
				{
					KI.frm.text_popup1.Text = buff[0];
					KI.frm.text_popup2.Text = buff[1];
					KI.frm.text_popup3.Text = buff[2];
					KI.frm.text_popup4.Text = buff[3];
				}
				KI.frm.text_popup1.BackColor = KI.frm.text_popup2.BackColor = Color.MidnightBlue;
				KI.frm.text_popup3.BackColor = KI.frm.text_popup4.BackColor = Color.MidnightBlue;
				KI.frm.text_result.BackColor = KI.frm.pn_result.BackColor = Color.MidnightBlue;
				KI.frm.text_popup1.ForeColor = KI.frm.text_popup2.ForeColor = Color.White;
				KI.frm.text_popup3.ForeColor = KI.frm.text_popup4.ForeColor = Color.White;
				KI.frm.text_result.ForeColor = KI.frm.pn_result.ForeColor = Color.White;
				KI.frm.pn_result.Show();
			}
			KI.frm.Refresh();
		}
		public static void main_popup_result(byte flag, byte rst, string msg)
		{
			KI.frm.text_popup1.Text = "";
			KI.frm.text_popup2.Text = "";
			KI.frm.text_popup3.Text = "";
			KI.frm.text_popup4.Text = "";
			KI.frm.text_result.Text = "";

			if (flag == FALSE)
			{
				KI.frm.pn_result.Hide();
			}
			else
			{
				if (rst == TRUE)
				{
					KI.frm.text_result.Text = "PASS";
					KI.frm.text_popup1.BackColor = KI.frm.text_popup2.BackColor = Color.Blue;
					KI.frm.text_popup3.BackColor = KI.frm.text_popup4.BackColor = Color.Blue;
					KI.frm.text_result.BackColor = KI.frm.pn_result.BackColor = Color.Blue;

					KI.frm.text_popup1.ForeColor = KI.frm.text_popup2.ForeColor = Color.Black;
					KI.frm.text_popup3.ForeColor = KI.frm.text_popup4.ForeColor = Color.Black;
					KI.frm.text_result.ForeColor = KI.frm.pn_result.ForeColor = Color.Black;

				}
				else
				{
					KI.frm.text_result.Text = "FAIL";
					//string[] buff = msg.Split('\n');

                    /*
					if (buff.Length == 1)
					{
						KI.frm.text_popup1.Text = "";
						KI.frm.text_popup2.Text = "";
						KI.frm.text_popup3.Text = "";
						KI.frm.text_popup4.Text = "";
					}
					else if (buff.Length == 2)
					{
						KI.frm.text_popup1.Text = "";
						KI.frm.text_popup2.Text = buff[1];
						KI.frm.text_popup3.Text = "";
						KI.frm.text_popup4.Text = "";
					}
					else if (buff.Length == 3)
					{
						KI.frm.text_popup1.Text = "";
						KI.frm.text_popup2.Text = buff[1];
						KI.frm.text_popup3.Text = buff[2];
						KI.frm.text_popup4.Text = "";
					}
					else if (buff.Length == 4)
					{
						KI.frm.text_popup1.Text = "";
						KI.frm.text_popup2.Text = buff[1];
						KI.frm.text_popup3.Text = buff[2];
						KI.frm.text_popup4.Text = buff[3];
					}
					else if (buff.Length == 5)
					{
						KI.frm.text_popup1.Text = buff[1];
						KI.frm.text_popup2.Text = buff[2];
						KI.frm.text_popup3.Text = buff[3];
						KI.frm.text_popup4.Text = buff[4];
					}*/


					KI.frm.text_popup1.BackColor = KI.frm.text_popup2.BackColor = Color.Red;
					KI.frm.text_popup3.BackColor = KI.frm.text_popup4.BackColor = Color.Red;
					KI.frm.text_result.BackColor = KI.frm.pn_result.BackColor = Color.Red;

					KI.frm.text_popup1.ForeColor = KI.frm.text_popup2.ForeColor = Color.Black;
					KI.frm.text_popup3.ForeColor = KI.frm.text_popup4.ForeColor = Color.Black;
					KI.frm.text_result.ForeColor = KI.frm.pn_result.ForeColor = Color.Black;
				}

				KI.frm.pn_result.Show();
			}
			KI.frm.Refresh();
		}
		#endregion
	}
}
