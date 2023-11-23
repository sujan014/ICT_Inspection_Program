using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using KI_GUI._000_Main;

namespace KI_GUI
{
	public partial class KI:Form
	{
		public static KI frm;

		public const byte CHECK_DISP = 0;
		public const byte MAIN_DISP = 1;
		public const byte MENU1_DISP = 2;
		public const byte MENU2_DISP = 3;
		public const byte VISION_DISP = 4;
		public const byte BOOT_DISP = 5;
		public const byte DEBUG_DISP = 6;

        public static byte USB_Flag = 0; //210516 MCH

        float version = 1.0f;
		int board_id = 0;
		
		public const string BOOT_FLAG =  "424F4F54";
		public const string APP_FLAG = "4150504C";
		public static string board_ver = "";
		public static string board_sn = "";
		public static string tact_time = "0.00";
		public static byte debug_mode = 1;
		public static string boot_mode = "";

		const int window_w = 1024, window_h = 600;

		public const byte TRUE = 1, FALSE = 0, CLEAR = 2;
		public const byte ON = 1, OFF = 0;
		public const byte ESC_KEY = 3;

        public static IntPtr Melfas_Ptr;

        public const bool USBDownload = true;

        public KI()
		{
			InitializeComponent();
			frm = this;
			Properties.Settings.Default.Reload();

			//VER_GUI.Text=String.Format("v {0:f}",version);
			//ID_GUI.Text=String.Format("ID : {0}",board_id);

			serial.bd_serial_init();
            //stage.stage_serial_init(); 210513 MCH

            main_timer_init();

			control.first_boot_update();
			control.UpdateCheckBox();

            if (USBDownload)
            {
                melfas_usb.InitThread_Melfas(); //210912 
            }
            //vision.vision_cam_init(); 210513 MCH
            //vision.vision_timer_init(); 210513 MCH
        }

		#region [000]State Bar
		
		private void ID_GUI_DoubleClick(object sender, EventArgs e)
		{
			info info_form = new info();
			info_form.ShowDialog();
		}
		private void Close_Label_DoubleClick(object sender, EventArgs e)
		{
			serial.bd_check(0);
			Application.ExitThread();
			Environment.Exit(0);
			Process.GetCurrentProcess().Kill();
		}
		private void VER_GUI_DoubleClick(object sender, EventArgs e)
		{
			serial.board_conn = false;
			tab.SelectedIndex = CHECK_DISP;

			control.board_debugmode_change();
		}
		private void run_mode_label_DoubleClick(object sender, EventArgs e)
		{
			serial.board_conn = false;
			tab.SelectedIndex = CHECK_DISP;

			if (boot_mode == BOOT_FLAG)
			{
				boot.run_mode_change(0);    // go app
			}
			else if (boot_mode == APP_FLAG)
			{
				boot.run_mode_change(1);    // go boot
			}
		}

		#endregion


		#region [001]GUI Display
		public void main_timer_init()
		{
			main_timer.Stop();
			main_timer.Interval = 1;
			//main_timer.Tick += new EventHandler(stage.check_stage); 210513 MCH
			main_timer.Tick += new EventHandler(serial.check_board);
			main_timer.Start();
		}
		private void KI_Manager_FormClosing(object sender,FormClosingEventArgs e)
		{
			if (vision.cam1 != null) vision.cam1.Dispose();
			if (vision.cam2 != null) vision.cam2.Dispose();
		}

		private void KI_Manager_Load(object sender,EventArgs e)
		{
			StartPosition=FormStartPosition.Manual;
			Location=new System.Drawing.Point(0,0);
			Size=new System.Drawing.Size(window_w,window_h);

			tab.DrawMode=TabDrawMode.OwnerDrawFixed;
			tab.DrawItem+=new DrawItemEventHandler(tab_draw_item);

			pn_result.Hide();
			pn_result.Location=new System.Drawing.Point(88,94);
			pn_result.Size=new System.Drawing.Size(584,310);

			listview.listview_create();



			KI.frm.ID_GUI.Text = "Machine No." + Properties.Settings.Default.MachineNO;
			bt_ict_update.Visible = Properties.Settings.Default.ICT_Spec_Check;
			//bt_panel_update.Visible = Properties.Settings.Default.Panel_Spec_Check; 210514 MCH
			bt_data_Update.Visible = Properties.Settings.Default.Data_Check;
			text_ict.Visible = Properties.Settings.Default.ICT_Spec_Check;
            //text_panel.Visible = Properties.Settings.Default.Panel_Spec_Check; 210514 MCH
            text_data.Visible = Properties.Settings.Default.Panel_Spec_Check;
            //-------------------------------------------------------------
            bt_data_Update.Visible = Properties.Settings.Default.Data_Check;
            text_data.Visible = Properties.Settings.Default.Data_Check;
            bt_pmic_Update.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
			text_pmic.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
			bt_eep_update.Visible = Properties.Settings.Default.Eep_Check;
			text_eep.Visible = Properties.Settings.Default.Eep_Check;
			//--------------------------------------------------------------

			text_led1.Text = Properties.Settings.Default.olb_led1.ToString();
			text_led2.Text = Properties.Settings.Default.olb_led2.ToString();
			text_led3.Text = Properties.Settings.Default.olb_led3.ToString();
			text_led4.Text = Properties.Settings.Default.olb_led4.ToString();
		}
		private void tab_draw_item(object sender,System.Windows.Forms.DrawItemEventArgs e)
		{
			Font fntTab;
			Brush bshBack;
			Brush bshFore;

			TabPage page = tab.TabPages[e.Index];
			e.Graphics.FillRectangle(new SolidBrush(page.BackColor),e.Bounds);

			Rectangle paddedBounds = e.Bounds;
			int yOffset = (e.State==DrawItemState.Selected) ? -2 : 1;
			paddedBounds.Offset(1,yOffset);
			TextRenderer.DrawText(e.Graphics,page.Text,Font,paddedBounds,page.ForeColor);
			Rectangle lasttabrect = tab.GetTabRect(tab.TabPages.Count-1);
			Rectangle background = new Rectangle();
			background.Location=new System.Drawing.Point(lasttabrect.Right,0);

			background.Size=new System.Drawing.Size(tab.Right-background.Left,lasttabrect.Height+1);
			SolidBrush sb = new SolidBrush(Color.Black);
			e.Graphics.FillRectangle(sb,background);

			if(e.Index==this.tab.SelectedIndex)
			{
				fntTab=new Font(e.Font,FontStyle.Bold);
				bshBack=new SolidBrush(Color.Black);
				bshFore=new SolidBrush(Color.White);
			}
			else
			{
				fntTab=e.Font;
				bshBack=new SolidBrush(Color.Black);
				bshFore=new SolidBrush(Color.Black);
			}
			string tabName = this.tab.TabPages[e.Index].Text;
			StringFormat sftTab = new StringFormat();
			sftTab.Alignment=StringAlignment.Center;
			sftTab.LineAlignment=StringAlignment.Center;
			e.Graphics.FillRectangle(bshBack,e.Bounds);
			Rectangle recTab = e.Bounds;
			recTab=new Rectangle(recTab.X,recTab.Y+4,recTab.Width,recTab.Height-4);
			e.Graphics.DrawString(tabName,fntTab,bshFore,recTab,sftTab);
		}

		private System.Drawing.Point mousePoint;
		private void KI_Manager_MouseDown(object sender,MouseEventArgs e)
		{
			mousePoint=new System.Drawing.Point(e.X,e.Y);
		}
		private void KI_Manager_MouseMove(object sender,MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				int x = mousePoint.X-e.X;
				int y = mousePoint.Y-e.Y;
				Location=new System.Drawing.Point(this.Left-x,this.Top-y);
			}
		}

		int current_tab = 0;

		private void tab_SelectedIndexChanged(object sender, EventArgs e)
		{
			return;
			if (tab.SelectedIndex == CHECK_DISP)
			{
				if (serial.board_conn == false)
				{
					current_tab = CHECK_DISP;
					//vision_timer.Stop();
				}
			}
			else if (tab.SelectedIndex == MAIN_DISP)
			{
				if (boot_mode != BOOT_FLAG)
				{
					current_tab = MAIN_DISP;
					//vision_timer.Stop();
				}
			}
			else if (tab.SelectedIndex == MENU1_DISP)
			{
				if (boot_mode != BOOT_FLAG)
				{
					current_tab = MENU1_DISP;
					//vision_timer.Stop();
				}

			}
			else if (tab.SelectedIndex == MENU2_DISP)
			{
				if (boot_mode != BOOT_FLAG)
				{
					current_tab = MENU2_DISP;
					//vision_timer.Stop();
				}
			}
			else if (tab.SelectedIndex == VISION_DISP)
			{
				if (boot_mode != BOOT_FLAG)
				{
					current_tab = VISION_DISP;
					//vision_timer.Start();
				}
			}
			else if (tab.SelectedIndex == BOOT_DISP)
			{
				if (boot_mode == BOOT_FLAG)
				{
					current_tab = BOOT_DISP;
					//vision_timer.Stop();
				}
			}
			else if (tab.SelectedIndex == DEBUG_DISP)
			{
				if (debug_mode == 0)
				{
					current_tab = DEBUG_DISP;
					//vision_timer.Stop();
				}
			}
			tab.SelectedIndex = current_tab;
			Refresh();
		}

		#endregion

		#region [000]Main Button Control

		private void text_qty_DoubleClick(object sender,EventArgs e)
		{
			control.board_qty_reset();
		}
		private void bt_prev_page_Click(object sender,EventArgs e)
		{
			if(Test.test_finsh_flag==FALSE)
				key.key_st2_send();
			else
				listview.result_disp(0,FALSE);
		}
		private void bt_next_page_Click(object sender,EventArgs e)
		{
			if(Test.test_finsh_flag==FALSE)
				key.key_st1_send();
			else
				listview.result_disp(1,FALSE);
		}
		private void bt_modechange_Click(object sender,EventArgs e)
		{
			control.insp_mode_change();
		}
		private void bt_st1st2_Click(object sender,EventArgs e)
		{
			key.key_st1st2_send();
		}
		private void bt_esc_key_Click(object sender,EventArgs e)
		{
			key.key_esc_send();
			listview.result_disp(2,FALSE);
		}

		private void bt_mode_key_Click(object sender,EventArgs e)
		{
			key.key_mode_send();
			listview.result_disp(2,TRUE);
		}

		#endregion

		#region [000]SPEC Update Button
		private void bt_spec_open_Click(object sender,EventArgs e)
		{
			string filePath = @"C:\KI\spec";
			Process.Start(filePath);
		}
		private void bt_ict_update_Click(object sender,EventArgs e)
		{
			if (Properties.Settings.Default.ICT_Spec_Check == false)
			{
				return;
			}

			try
			{
				if((specfile.spec_read_file()==true)&&(specfile.oper_read_file()==true))
				{
					if((specwrite.bd_ict_spec_write()==true)&&(specread.read_board_ict_spec()==true))
					{
					    text_pj_name.Text=specfile.project_name_main;
					    text_pj_sub.Text=specfile.project_name_sub;

					    button_sv_mode1.Text = rd_mode1.Text=specfile.mode1_name;
					    button_sv_mode2.Text = rd_mode2.Text=specfile.mode2_name;
					    button_sv_mode3.Text = rd_mode3.Text=specfile.mode3_name;
					    button_sv_mode4.Text = rd_mode4.Text=specfile.mode4_name;

					    text_ict.Text="";
					    text_ict.AppendText(String.Format("[Number]"));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - TP({0})",specfile.tp_count));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - Open({0})/Short({1})/Short Ex({2})",specfile.open_count,specfile.short_bs_count,specfile.short_ex_count));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - Part({0})/Func({1})",specfile.part_count,specfile.func_count));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format("[CRC32]"));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - TP({0:X})", specfile.tp_crc32));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - Open({0:X})/Short({1:X})/Short Ex({2:X})", specfile.open_crc32, specfile.short_crc32, specfile.shortex_crc32));
					    text_ict.AppendText(Environment.NewLine);
					    text_ict.AppendText(String.Format(" - Part({0:X})/Func({1:X})", specfile.part_crc32, specfile.func_crc32));
					}
				}
				else
				{
					MessageBox.Show("ICT SPEC UPDATE FAIL","FAIL",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("ICT SPEC UPDATE FAIL","FAIL",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		/*private void bt_panel_update_Click(object sender,EventArgs e)
		{
			if (Properties.Settings.Default.Panel_Spec_Check == false)
			{
				return;
			}
			try
			{
				if((specfile.panel_read_file()==true))
				{
					if((specwrite.bd_panel_spec_write()==true)&&(specread.read_panel_data()==true))
					{
						text_panel.Text="";
						text_panel.AppendText(String.Format(" - Panel({0})", specfile.panel_count));
						text_panel.AppendText(Environment.NewLine);
						text_panel.AppendText(String.Format(" - CRC32 : {0}", specfile.panel_crc32));
					}
				}
				else
				{
					MessageBox.Show("PANEL SPEC UPDATE FAIL","FAIL",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("PANEL SPEC UPDATE FAIL","FAIL",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}*/ //210514 MCH
		private void bt_data_Update_Click(object sender,EventArgs e)
		{
            if (!Properties.Settings.Default.Data_Check)
            {
                MessageBox.Show("This model does not support IN data", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*if (USBDownload)
            {
                MessageBox.Show("This model does not support IN data", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            bool write_status = true;
            if (Properties.Settings.Default.Data_Check == false)
			{
				return;
			}
			try
			{
				if ((specfile.indata_read_file() == true))
				{
					if ((specwrite.bd_input_data_write() == true) && (specread.read_input_data() == true))
					{
						text_data.Clear();
						text_pj_data.Text = specfile.data_name;
						text_data.AppendText(String.Format(" - " + specfile.data_name));
						text_data.AppendText(Environment.NewLine);
						text_data.AppendText(String.Format(" - Size : {0:F2} kB", specfile.data_size / 1024));
						text_data.AppendText(Environment.NewLine);
						text_data.AppendText(String.Format(" - CRC32 : {0:X}", specfile.data_crc32));
					}
                    else
                    {
                        write_status = false;
                    }
				}
				else
				{
                    write_status = false;
                    MessageBox.Show("INPUT DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
                /*
                if (write_status)
                {
                    util.delay(500);
                    if ((specfile.inboot_read_file() == true))
                    {
                        if ((specwrite.bd_input_boot_write() == true) && (specread.read_input_boot() == true))
                        {
                            text_data.Clear();
                            text_pj_data.Text = specfile.config_name;
                            text_data.AppendText(String.Format(" - " + specfile.config_name));
                            text_data.AppendText(Environment.NewLine);
                            text_data.AppendText(String.Format(" - Size : {0:F2} kB", (float)specfile.config_size / 1024));
                            text_data.AppendText(Environment.NewLine);
                            text_data.AppendText(String.Format(" - CRC32 : {0:X}", specfile.config_crc32));
                            update_text += (text_data.Text + Environment.NewLine);
                        }
                        else
                        {
                            write_status = false;
                        }
                    }
                    else
                    {
                        write_status = false;
                        MessageBox.Show("INPUT CONFIG UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
			}
			catch
			{
				MessageBox.Show("INPUT DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bt_pmic_Update_Click_1(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.Pmic_Check == true)
			{
                try
                {
                    if ((specfile.pmic_read_file_only() == true))
                    {
                        if ((specwrite.bd_pmic_data_write() == true) && (specread.read_pmic_data() == true))
                        //if ((specwrite.bd_pmic_data_write() == true) && (specread.read_pmic_data() == true)&& (specread.read_tpic_data() == true)) //TPIC 같이
                        {
                            text_pmic.Clear();

                            text_pmic.AppendText(String.Format(" - " + specfile.pmic_name));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.pmic_size));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.pmic_crc32));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - " + specfile.tpic_name));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.tpic_size));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.tpic_crc32));
                            text_pmic.AppendText(Environment.NewLine);
                        }
                    }
                    else
                    {
                        MessageBox.Show("PMIC&TPIC DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("PMIC&TPIC DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Properties.Settings.Default.Tpic_Check == true)
            {
                try
                {
                    if ((specfile.tpic_read_file_only() == true))
                    {
                        if ((specwrite.bd_tpic_data_write() == true) && (specread.read_tpic_data() == true))
                        //if ((specwrite.bd_pmic_data_write() == true) && (specread.read_pmic_data() == true)&& (specread.read_tpic_data() == true)) //TPIC 같이
                        {
                            //text_pmic.Clear();

                            text_pmic.AppendText(String.Format(" - " + specfile.pmic_name));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.tpic_size));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.tpic_crc32));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - " + specfile.tpic_name));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - Size : {0:F2} Byte", specfile.tpic_size));
                            text_pmic.AppendText(Environment.NewLine);
                            text_pmic.AppendText(String.Format(" - CRC32 : {0:X}", specfile.tpic_crc32));
                        }
                    }
                    else
                    {
                        MessageBox.Show("PMIC&TPIC DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("PMIC&TPIC DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

		private void bt_eep_update_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.Eep_Check == false)
			{
				return;
			}
			try
			{
				if ((specfile.eep_read_file() == true))
				{
					if ((specwrite.bd_eep_data_write() == true) && (specread.read_eep_data() == true))
					{
						text_eep.Clear();
						//text_pj_data.Text = specfile.data_name;
						text_eep.AppendText(String.Format(" - " + specfile.eep_name));
						text_eep.AppendText(Environment.NewLine);
						text_eep.AppendText(String.Format(" - Size : {0:F2} kB", specfile.eep_size / 1024));
				
						text_eep.AppendText(Environment.NewLine);
						text_eep.AppendText(String.Format(" - CRC32 : {0:X}", specfile.eep_crc32));
					}
				}
				else
				{
					MessageBox.Show("EEP DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("EEP DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


















		#endregion

		#region [000]Spec View Button (Finsh)

		private void button_sv_pre_Click(object sender,EventArgs e)
		{
			specview.pre_button();
		}
		private void button_sv_next_Click(object sender,EventArgs e)
		{
			specview.next_button();
		}
		private void button_sv_tp_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.TESTPOINT_SEL;
			specview.first_button();
		}
		private void button_sv_op_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.OPEN_SEL;
			specview.first_button();
		}
		private void button_sv_shb_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.SHORT_SEL;
			specview.first_button();
		}
		private void button_sv_she_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.SKIP_SEL;
			specview.first_button();
		}
		private void button_sv_pt_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.PART_SEL;
			specview.first_button();
		}
		private void button_sv_fn_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.FUNC_SEL;
			specview.first_button();
		}
		private void button_sv_mode1_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.MODE1_SEL;
			specview.first_button();
		}
		private void button_sv_mode2_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.MODE2_SEL;
			specview.first_button();
		}
		private void button_sv_mode3_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.MODE3_SEL;
			specview.first_button();
		}
		private void button_sv_mode4_Click(object sender,EventArgs e)
		{
			specview.VIEW_SELECT = specview.MODE4_SEL;
			specview.first_button();
		}
		#endregion

		#region [000]BOARD TEST BUTTON

		private void bt_led_save_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.olb_led1 = Convert.ToByte(text_led1.Text);
			Properties.Settings.Default.olb_led2 = Convert.ToByte(text_led2.Text);
			Properties.Settings.Default.olb_led3 = Convert.ToByte(text_led3.Text);
			Properties.Settings.Default.olb_led4 = Convert.ToByte(text_led4.Text);
			Properties.Settings.Default.Save();

			if (boardtest.board_led_test() == FALSE)
			{
				MessageBox.Show("LED SETTING NG", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("LED SETTING OK", "", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}																	

		bool[] sol_flag = new bool[8]
		{false,false,false,false,false,false,false,false};
		private void bt_sol1_Click(object sender,EventArgs e)
		{
			if (sol_flag[0] == false)
			{
				bt_sol1.Text = "SOL1\nOFF";
				bt_sol1.ForeColor = Color.Red;
				sol_flag[0] = true;
				boardtest.board_sol_test(1, ON, 0);
			}
			else if (sol_flag[0] == true)
			{
				bt_sol1.Text = "SOL1\nON";
				bt_sol1.ForeColor = Color.White;
				sol_flag[0] = false;
				boardtest.board_sol_test(1, OFF, 0);
			}
		}
		private void bt_sol2_Click(object sender,EventArgs e)
		{
			if (sol_flag[1] == false)
			{
				bt_sol2.Text = "SOL2\nOFF";
				bt_sol2.ForeColor = Color.Red;
				sol_flag[1] = true;
				boardtest.board_sol_test(2, ON, 0);
			}
			else if (sol_flag[1] == true)
			{
				bt_sol2.Text = "SOL2\nON";
				bt_sol2.ForeColor = Color.White;
				sol_flag[1] = false;
				boardtest.board_sol_test(2, OFF, 0);
			}
		}
		private void bt_sol3_Click(object sender,EventArgs e)
		{
			if (sol_flag[2] == false)
			{
				bt_sol3.Text = "SOL3\nOFF";
				bt_sol3.ForeColor = Color.Red;
				sol_flag[2] = true;
				boardtest.board_sol_test(3, ON, 0);
			}
			else if (sol_flag[2] == true)
			{
				bt_sol3.Text = "SOL3\nON";
				bt_sol3.ForeColor = Color.White;
				sol_flag[2] = false;
				boardtest.board_sol_test(3, OFF, 0);
			}
		}
		private void bt_sol4_Click(object sender,EventArgs e)
		{
			if (sol_flag[3] == false)
			{
				bt_sol4.Text = "SOL4\nOFF";
				bt_sol4.ForeColor = Color.Red;
				sol_flag[3] = true;
				boardtest.board_sol_test(4, ON, 0);
			}
			else if (sol_flag[3] == true)
			{
				bt_sol4.Text = "SOL4\nON";
				bt_sol4.ForeColor = Color.White;
				sol_flag[3] = false;
				boardtest.board_sol_test(4, OFF, 0);
			}
		}
		private void bt_sol5_Click(object sender,EventArgs e)
		{
			if (sol_flag[4] == false)
			{
				bt_sol5.Text = "SOL5\nOFF";
				bt_sol5.ForeColor = Color.Red;
				sol_flag[4] = true;
				boardtest.board_sol_test(5, ON, 0);
			}
			else if (sol_flag[4] == true)
			{
				bt_sol5.Text = "SOL5\nON";
				bt_sol5.ForeColor = Color.White;
				sol_flag[4] = false;
				boardtest.board_sol_test(5, OFF, 0);
			}
		}
		private void bt_sol6_Click(object sender,EventArgs e)
		{
			if (sol_flag[5] == false)
			{
				bt_sol6.Text = "SOL6\nON";
				bt_sol6.ForeColor = Color.Red;
				sol_flag[5] = true;
				boardtest.board_sol_test(6, ON, 0);
			}
			else if (sol_flag[5] == true)
			{
				bt_sol6.Text = "SOL6\nON";
				bt_sol6.ForeColor = Color.White;
				sol_flag[5] = false;
				boardtest.board_sol_test(6, OFF, 0);
			}
		}
		private void bt_sol7_Click(object sender,EventArgs e)
		{
			if (sol_flag[6] == false)
			{
				bt_sol7.Text = "SOL7\nOFF";
				bt_sol7.ForeColor = Color.Red;
				sol_flag[6] = true;
				boardtest.board_sol_test(7, ON, 0);
			}
			else if (sol_flag[6] == true)
			{
				bt_sol7.Text = "SOL7\nON";
				bt_sol7.ForeColor = Color.White;
				sol_flag[6] = false;
				boardtest.board_sol_test(7, OFF, 0);
			}
		}
		private void bt_sol8_Click(object sender,EventArgs e)
		{
			if (sol_flag[7] == false)
			{
				bt_sol8.Text = "SOL8\nOFF";
				bt_sol8.ForeColor = Color.Red;
				sol_flag[7] = true;
				boardtest.board_sol_test(8, ON, 0);
			}
			else if (sol_flag[7] == true)
			{
				bt_sol8.Text = "SOL8\nON";
				bt_sol8.ForeColor = Color.White;
				sol_flag[7] = false;
				boardtest.board_sol_test(8, OFF, 0);
			}
		}
		private void bt_sol_all_Click(object sender,EventArgs e)
		{
			boardtest.board_sol_test(255, OFF, 0);

			sol_flag[0] = sol_flag[1] = sol_flag[2] = sol_flag[3] = false;
			sol_flag[4] = sol_flag[5] = sol_flag[6] = sol_flag[7] = false;

			bt_sol1.Text = "SOL1\nON"; bt_sol1.ForeColor = Color.White;
			bt_sol2.Text = "SOL2\nON"; bt_sol2.ForeColor = Color.White;
			bt_sol3.Text = "SOL3\nON"; bt_sol3.ForeColor = Color.White;
			bt_sol4.Text = "SOL4\nON"; bt_sol4.ForeColor = Color.White;
			bt_sol5.Text = "SOL5\nON"; bt_sol5.ForeColor = Color.White;
			bt_sol6.Text = "SOL6\nON"; bt_sol6.ForeColor = Color.White;
			bt_sol7.Text = "SOL7\nON"; bt_sol7.ForeColor = Color.White;
			bt_sol8.Text = "SOL8\nON"; bt_sol8.ForeColor = Color.White;
		}
		#endregion

		#region [000]Setting Checkbox Button
			private void chb_ngcont_CheckedChanged(object sender, EventArgs e)
			{
				Properties.Settings.Default.ng_cont = chb_ngcont.Checked;
				Properties.Settings.Default.Save();
				if (chb_ngcont.Checked == true)
				{
					txt_ngcont.Text = "NG Continue On";
					txt_ngcont.Enabled = true;
					txt_ngcont.BackColor = Color.Green;
				}
				else
				{
					txt_ngcont.Text = "NG Continue Off";
					txt_ngcont.Enabled = false;
					txt_ngcont.BackColor = Color.Black;
				}
			}
			private void chb_fwwrite_CheckedChanged(object sender, EventArgs e)
			{
				Properties.Settings.Default.data_write = chb_fwwrite.Checked;
				Properties.Settings.Default.Save();
				if (chb_fwwrite.Checked == true)
				{
					txt_fwwrite.Text = "F/W Write On";
					txt_fwwrite.Enabled = true;
					txt_fwwrite.BackColor = Color.Green;
				}
				else
				{
					txt_fwwrite.Text = "F/W Write Off";
					txt_fwwrite.Enabled = false;
					txt_fwwrite.BackColor = Color.Black;
				}
			}		
			/*private void chb_sdclog_CheckedChanged(object sender, EventArgs e)
				{
					Properties.Settings.Default.sdc_log = chb_sdclog.Checked;
					Properties.Settings.Default.Save();
					if (chb_sdclog.Checked == true)
					{
						txt_sdclog.Text = "SDC Log Save On";
						txt_sdclog.Enabled = true;
						txt_sdclog.BackColor = Color.Green;
					}
					else
					{
						txt_sdclog.Text = "SDC Log Save Off";
						txt_sdclog.Enabled = false;
						txt_sdclog.BackColor = Color.Black;
					}
			}*/ //210514 MCH


		private void chb_logunit_CheckedChanged(object sender, EventArgs e)
			{
				Properties.Settings.Default.log_unit = chb_logunit.Checked;
				Properties.Settings.Default.Save();
			}


			private void chb_subname_CheckedChanged(object sender, EventArgs e)
			{
				Properties.Settings.Default.sub_disp = chb_subname.Checked;
				Properties.Settings.Default.Save();
			}


			/*private void chb_shortall_CheckedChanged(object sender, EventArgs e)
			{
				Properties.Settings.Default.short_all = chb_shortall.Checked;
				Properties.Settings.Default.Save();
			}*/ //210514 MCH

		#endregion
		
		#region [000]Bootloader Button

		private void bt_down_fw_Click(object sender, EventArgs e)
		{
			try
			{
				if ((boot.fw_read_file() == true))
				{
					if ((boot.bd_fw_data_write() == true))
					{
						text_fw.Clear();
						text_fw.AppendText(String.Format(" - " + boot.fw_name));
						text_fw.AppendText(Environment.NewLine);
						text_fw.AppendText(String.Format(" - Size : {0:F2} kB", boot.fw_size / 1024));
						text_fw.AppendText(Environment.NewLine);
						text_fw.AppendText(String.Format(" - CRC32 : {0:X}", boot.fw_crc32));
					}
				}
				else
				{
					MessageBox.Show("F/W DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("F/W DATA UPDATE FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bt_full_erase_Click(object sender, EventArgs e)
		{
			if (boot.full_earse_board() == FALSE)
			{
				MessageBox.Show("Erase Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				KI.frm.text_fw.Text = " - Full Erase OK";
				KI.frm.Refresh();
			}
		}


		private void bt_fw_reload_Click(object sender, EventArgs e)
		{
			try
			{
				if ((boot.fw_read_file() == true))
				{
					text_fw.Clear();
					text_fw.AppendText(String.Format(" - " + boot.fw_name));
					text_fw.AppendText(Environment.NewLine);
					text_fw.AppendText(String.Format(" - Size : {0:F2} kB", boot.fw_size / 1024));
					text_fw.AppendText(Environment.NewLine);
					text_fw.AppendText(String.Format(" - CRC32 : {0:X}", boot.fw_crc32));
				}
				else
				{
					MessageBox.Show("F/W File Read FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("F/W File Read FAIL", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region  [000]Vision Button



		private void bt_cam1_vfflip_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.cam1_vflip = !Properties.Settings.Default.cam1_vflip;
			Properties.Settings.Default.Save();

			util.delay(100);
			//vision_timer.Start();
		}

		private void bt_cam1_hfflip_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.cam1_hflip = !Properties.Settings.Default.cam1_hflip;
			Properties.Settings.Default.Save();

			util.delay(100);
			//vision_timer.Start();
		}
		private void bt_cam2_vfflip_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.cam2_vflip = !Properties.Settings.Default.cam2_vflip;
			Properties.Settings.Default.Save();

			util.delay(100);
			//vision_timer.Start();
		}

		private void bt_cam2_hfflip_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.cam2_hflip = !Properties.Settings.Default.cam2_hflip;
			Properties.Settings.Default.Save();

			util.delay(100);
			//vision_timer.Start();
		}
		private void bt_cam_change_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.cam_change = !Properties.Settings.Default.cam_change;
			Properties.Settings.Default.Save();

			util.delay(100);
			//vision_timer.Start();
		}
		
		private void bt_vision_setup_Click(object sender, EventArgs e)
		{
			if (vision.vision_conn == false)
			{
				MessageBox.Show("Camera Disconnection");
				return;
			}

			//vision_timer.Stop();
			Vision_Setup setup_form = new Vision_Setup();
			setup_form.ShowDialog();
			//vision_timer.Start();
		}

		private void bt_dual_on_Click(object sender, EventArgs e)
		{
			bt_solo_on.Visible = true;
			bt_dual_on.Visible = false;

			//vision_timer.Stop();
			Properties.Settings.Default.dual_cam = true;
			Properties.Settings.Default.Save();
			vision.vision_cam_init();
			//vision_timer.Start();
			MessageBox.Show("Camera Reconnection");
		}

		private void bt_solo_on_Click(object sender, EventArgs e)
		{
			bt_solo_on.Visible = false;
			bt_dual_on.Visible = true;

			//vision_timer.Stop();
			Properties.Settings.Default.dual_cam = false;
			Properties.Settings.Default.Save();
			vision.vision_cam_init();
			//vision_timer.Start();
			MessageBox.Show("Camera Reconnection");
		}
		private void bt_match_disp_Click(object sender, EventArgs e)
		{
			//vision_timer.Stop();
			Properties.Settings.Default.match_disp = !Properties.Settings.Default.match_disp;
			Properties.Settings.Default.Save();

			if (Properties.Settings.Default.match_disp == true)
			{
				group_cam1_match.Visible = true;
				group_cam2_match.Visible = true;
				bt_match_disp.Text = "ON";
			}
			else
			{
				group_cam1_match.Visible = false;
				group_cam2_match.Visible = false;
				bt_match_disp.Text = "OFF";
			}
			util.delay(100);
			//vision_timer.Start();
		}
		
		private void bt_align_est_Click(object sender, EventArgs e)
		{
			////vision_timer.Stop();
			vision.oneshot_aling_estimation();
			//vision_timer.Start();
		}

		private void bt_autoalign_Click(object sender, EventArgs e)
		{
			vision.align_watch.Restart();

			if (stage.align_match()==true)
			{
				bt_result_align1.Text = "Align Match OK";
				bt_result_align2.Text = "Align Match OK";
				bt_result_align1.BackColor = Color.Green;
				bt_result_align2.BackColor = Color.Green;
			}
			else
			{
				bt_result_align1.Text = "Align Match NG";
				bt_result_align2.Text = "Align Match NG";
				bt_result_align1.BackColor = Color.Red;
				bt_result_align2.BackColor = Color.Red;
			}
			vision.align_watch.Stop();
			util.dbgmsg(string.Format("Align Time : {0}ms", vision.align_watch.ElapsedMilliseconds));
		}
		#endregion

		#region [000]Stage Control

		int xdist = 0;
		int ydist = 0;
		int tdist = 0;
		private void bt_load_center_Click(object sender, EventArgs e)
		{
			int cur_x = Properties.Settings.Default.stage_center_x;
			int cur_y = Properties.Settings.Default.stage_center_y;
			int cur_t = Properties.Settings.Default.stage_center_t;

			string x_temp = string.Format("X Center: {0}\n", cur_x);
			string y_temp = string.Format("Y Center: {0}\n", cur_y);
			string t_temp = string.Format("T Center: {0}\n", cur_t);
			MessageBox.Show(x_temp + y_temp + t_temp, "Center View", MessageBoxButtons.OK, MessageBoxIcon.None);

		}
		private void by_stage_center_save_Click(object sender, EventArgs e)
		{
			int pre_x = Properties.Settings.Default.stage_center_x;
			int pre_y = Properties.Settings.Default.stage_center_y;
			int pre_t = Properties.Settings.Default.stage_center_t;


			Properties.Settings.Default.stage_center_x = Convert.ToInt16(text_loc_x.Text);
			Properties.Settings.Default.stage_center_y = Convert.ToInt16(text_loc_y.Text);
			Properties.Settings.Default.stage_center_t = Convert.ToInt16(text_loc_t.Text);
			Properties.Settings.Default.Save();

			int cur_x = Properties.Settings.Default.stage_center_x;
			int cur_y = Properties.Settings.Default.stage_center_y;
			int cur_t = Properties.Settings.Default.stage_center_t;

			string x_temp = string.Format("X Center: {0}->{1}\n", pre_x, cur_x);
			string y_temp = string.Format("Y Center: {0}->{1}\n", pre_y, cur_y);
			string t_temp = string.Format("T Center: {0}->{1}\n", pre_t, cur_t);

			MessageBox.Show(x_temp+ y_temp+ t_temp, "Center Save", MessageBoxButtons.OK, MessageBoxIcon.None);
		}		
		// move jog
		private void bt_x_jog_n_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_x = text_x_jog.Text;
			Properties.Settings.Default.Save();
			xdist = Convert.ToInt16(text_x_jog.Text);
			xdist *= Properties.Settings.Default.stage_dir_x;
			stage.move_jog(-xdist, 0, 0);
		}
		private void bt_x_jog_p_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_x = text_x_jog.Text;
			Properties.Settings.Default.Save();
			xdist = Convert.ToInt16(text_x_jog.Text);
			xdist *= Properties.Settings.Default.stage_dir_x;
			stage.move_jog(xdist, 0, 0);
		}		
		private void bt_y_jog_n_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_y = text_y_jog.Text;
			Properties.Settings.Default.Save();
			ydist = Convert.ToInt16(text_y_jog.Text);
			ydist *= Properties.Settings.Default.stage_dir_y;
			stage.move_jog(0, -ydist, 0);
		}
		private void bt_y_jog_p_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_y = text_y_jog.Text;
			Properties.Settings.Default.Save();
			ydist = Convert.ToInt16(text_y_jog.Text);
			ydist *= Properties.Settings.Default.stage_dir_y;
			stage.move_jog(0, ydist, 0);
		}
		private void bt_t_jog_n_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_t = text_t_jog.Text;
			Properties.Settings.Default.Save();
			tdist = Convert.ToInt16(text_t_jog.Text);
			tdist *= Properties.Settings.Default.stage_dir_t;
			stage.move_jog(0, 0, -tdist);
		}
		private void bt_t_jog_p_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.stage_jog_t = text_t_jog.Text;
			Properties.Settings.Default.Save();
			tdist = Convert.ToInt16(text_t_jog.Text);
			tdist *= Properties.Settings.Default.stage_dir_t;
			stage.move_jog(0, 0, tdist);
		}
		// move home
		private void bt_x_home_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.x_axis) == 0)
			{
				MessageBox.Show("x home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bt_y_home_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.y_axis) == 0)
			{
				MessageBox.Show("y home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bt_t_home_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.t_axis) == 0)
			{
				MessageBox.Show("t home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void bt_all_home_Click(object sender, EventArgs e)
		{
			stage.move_all_home();
		}

        private void chb_bootApp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.boot_app_write = chb_bootApp.Checked;
            Properties.Settings.Default.Save();
            if (chb_bootApp.Checked == true)
            {
                txt_fwwrite.Text = "Boot+App Write On";
                txt_fwwrite.Enabled = true;
                txt_fwwrite.BackColor = Color.Green;
            }
            else
            {
                txt_fwwrite.Text = "Boot+App Write Off";
                txt_fwwrite.Enabled = false;
                txt_fwwrite.BackColor = Color.Black;
            }
        }

        private void chb_InData_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Data_Check = chb_InData.Checked;
            Properties.Settings.Default.Save();
            bt_data_Update.Visible = Properties.Settings.Default.Data_Check;
            text_data.Visible = Properties.Settings.Default.Data_Check;
        }

        private void chb_PMIC_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Pmic_Check = chb_PMIC.Checked;
            Properties.Settings.Default.Save();
            bt_pmic_Update.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
            text_pmic.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
        }

        private void chb_TPIC_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tpic_Check = chb_TPIC.Checked;
            Properties.Settings.Default.Save();
            bt_pmic_Update.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
            text_pmic.Visible = Properties.Settings.Default.Pmic_Check | Properties.Settings.Default.Tpic_Check;
        }

        private void chb_EEPROM_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Eep_Check = chb_EEPROM.Checked;
            Properties.Settings.Default.Save();
            bt_eep_update.Visible = Properties.Settings.Default.Eep_Check;
            text_eep.Visible = Properties.Settings.Default.Eep_Check;
        }

        // move center
        private void bt_x_center_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.x_axis) == 0)
			{
				MessageBox.Show("x home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				util.delay(500);
				stage.move_jog(Properties.Settings.Default.stage_center_x,0, 0);
			}
		}
		private void bt_y_center_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.y_axis) == 0)
			{
				MessageBox.Show("y home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				util.delay(500);
				stage.move_jog( 0, Properties.Settings.Default.stage_center_y, 0);
			}
		}
		private void bt_t_center_Click(object sender, EventArgs e)
		{
			if (stage.move_home(stage.t_axis) == 0)
			{
				util.delay(500);
				MessageBox.Show("t home ng", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				stage.move_jog(0, 0, Properties.Settings.Default.stage_center_t);
			}
		}
		private void bt_all_center_Click(object sender, EventArgs e)
		{
			stage.move_all_center();
		}

		#endregion
	}
}
