namespace KI_GUI
{
    partial class KI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KI));
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_pj_name = new System.Windows.Forms.GroupBox();
            this.text_pj_sub = new System.Windows.Forms.TextBox();
            this.text_pj_data = new System.Windows.Forms.TextBox();
            this.text_pj_name = new System.Windows.Forms.TextBox();
            this.bt_st1st2 = new System.Windows.Forms.Button();
            this.bt_next_page = new System.Windows.Forms.Button();
            this.bt_prev_page = new System.Windows.Forms.Button();
            this.bt_esc_key = new System.Windows.Forms.Button();
            this.status_main = new System.Windows.Forms.StatusStrip();
            this.Close_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID_GUI = new System.Windows.Forms.ToolStripStatusLabel();
            this.bd_ver_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.run_mode_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Board_Port = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stage_Port = new System.Windows.Forms.ToolStripStatusLabel();
            this.Camera_conn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sen_input = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_mode_key = new System.Windows.Forms.Button();
            this.bd_serial = new System.IO.Ports.SerialPort(this.components);
            this.vision_timer = new System.Windows.Forms.Timer(this.components);
            this.stage_serial = new System.IO.Ports.SerialPort(this.components);
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.text_log = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabBoot = new System.Windows.Forms.TabPage();
            this.text_fw = new System.Windows.Forms.TextBox();
            this.text_boot_ver = new System.Windows.Forms.TextBox();
            this.bt_fw_reload = new System.Windows.Forms.Button();
            this.bt_down_fw = new System.Windows.Forms.Button();
            this.bt_full_erase = new System.Windows.Forms.Button();
            this.tabVision = new System.Windows.Forms.TabPage();
            this.grbox_cam1 = new System.Windows.Forms.GroupBox();
            this.group_cam1_match = new System.Windows.Forms.GroupBox();
            this.text_x_dist1 = new System.Windows.Forms.TextBox();
            this.text_t_dist1 = new System.Windows.Forms.TextBox();
            this.text_y_dist1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_cam1_vfflip = new System.Windows.Forms.Button();
            this.bt_cam1_hfflip = new System.Windows.Forms.Button();
            this.disp_cam1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.bt_result_align1 = new System.Windows.Forms.Button();
            this.grbox_cam2 = new System.Windows.Forms.GroupBox();
            this.bt_result_align2 = new System.Windows.Forms.Button();
            this.group_cam2_match = new System.Windows.Forms.GroupBox();
            this.text_y_dist2 = new System.Windows.Forms.TextBox();
            this.text_t_dist2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_x_dist2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_cam2_vfflip = new System.Windows.Forms.Button();
            this.bt_cam2_hfflip = new System.Windows.Forms.Button();
            this.disp_cam2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.gb_sol_control = new System.Windows.Forms.GroupBox();
            this.bt_match_disp = new System.Windows.Forms.Button();
            this.bt_cam_change = new System.Windows.Forms.Button();
            this.bt_solo_on = new System.Windows.Forms.Button();
            this.bt_dual_on = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.text_led4 = new System.Windows.Forms.TextBox();
            this.text_led3 = new System.Windows.Forms.TextBox();
            this.text_led2 = new System.Windows.Forms.TextBox();
            this.text_led1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.bt_vision_setup = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_load_center = new System.Windows.Forms.Button();
            this.text_t_jog = new System.Windows.Forms.TextBox();
            this.text_y_jog = new System.Windows.Forms.TextBox();
            this.bt_x_jog_p = new System.Windows.Forms.Button();
            this.text_x_jog = new System.Windows.Forms.TextBox();
            this.bt_y_jog_p = new System.Windows.Forms.Button();
            this.bt_x_jog_n = new System.Windows.Forms.Button();
            this.text_loc_y = new System.Windows.Forms.TextBox();
            this.bt_t_jog_n = new System.Windows.Forms.Button();
            this.bt_t_jog_p = new System.Windows.Forms.Button();
            this.bt_y_jog_n = new System.Windows.Forms.Button();
            this.text_loc_t = new System.Windows.Forms.TextBox();
            this.text_loc_x = new System.Windows.Forms.TextBox();
            this.bt_all_home = new System.Windows.Forms.Button();
            this.bt_y_home = new System.Windows.Forms.Button();
            this.bt_all_center = new System.Windows.Forms.Button();
            this.bt_x_home = new System.Windows.Forms.Button();
            this.bt_t_home = new System.Windows.Forms.Button();
            this.text_os_dx = new System.Windows.Forms.TextBox();
            this.by_stage_center_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_autoalign = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_led_save = new System.Windows.Forms.Button();
            this.text_os_dy = new System.Windows.Forms.TextBox();
            this.bt_t_center = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_align_est = new System.Windows.Forms.Button();
            this.text_os_dt = new System.Windows.Forms.TextBox();
            this.text_sen8 = new System.Windows.Forms.TextBox();
            this.bt_y_center = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_sol1 = new System.Windows.Forms.Button();
            this.bt_x_center = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_sen7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_sol_all = new System.Windows.Forms.Button();
            this.bt_sol2 = new System.Windows.Forms.Button();
            this.text_sen6 = new System.Windows.Forms.TextBox();
            this.bt_sol3 = new System.Windows.Forms.Button();
            this.text_sen5 = new System.Windows.Forms.TextBox();
            this.bt_sol4 = new System.Windows.Forms.Button();
            this.text_sen4 = new System.Windows.Forms.TextBox();
            this.bt_sol5 = new System.Windows.Forms.Button();
            this.text_sen3 = new System.Windows.Forms.TextBox();
            this.bt_sol6 = new System.Windows.Forms.Button();
            this.text_sen2 = new System.Windows.Forms.TextBox();
            this.text_sen1 = new System.Windows.Forms.TextBox();
            this.bt_sol7 = new System.Windows.Forms.Button();
            this.bt_sol8 = new System.Windows.Forms.Button();
            this.tabSpecview = new System.Windows.Forms.TabPage();
            this.bt_spec_open = new System.Windows.Forms.Button();
            this.text_sv_view_mode = new System.Windows.Forms.TextBox();
            this.text_sv_row9_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row9 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row9_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row4 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_5 = new System.Windows.Forms.TextBox();
            this.text_sv_no_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_6 = new System.Windows.Forms.TextBox();
            this.text_sv_no_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_7 = new System.Windows.Forms.TextBox();
            this.text_sv_no_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_8 = new System.Windows.Forms.TextBox();
            this.text_sv_no_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row8 = new System.Windows.Forms.TextBox();
            this.text_sv_no = new System.Windows.Forms.TextBox();
            this.text_sv_row8_1 = new System.Windows.Forms.TextBox();
            this.text_sv_no_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_2 = new System.Windows.Forms.TextBox();
            this.text_sv_no_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_3 = new System.Windows.Forms.TextBox();
            this.text_sv_no_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row8_4 = new System.Windows.Forms.TextBox();
            this.text_sv_no_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_9 = new System.Windows.Forms.TextBox();
            this.text_sv_no_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_10 = new System.Windows.Forms.TextBox();
            this.text_sv_no_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row7 = new System.Windows.Forms.TextBox();
            this.text_sv_row1 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row7_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row1_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row6 = new System.Windows.Forms.TextBox();
            this.text_sv_row2 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row6_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row2_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row5 = new System.Windows.Forms.TextBox();
            this.text_sv_row3 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_1 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row5_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_10 = new System.Windows.Forms.TextBox();
            this.text_sv_row3_9 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_5 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_4 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_6 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_3 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_7 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_2 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_8 = new System.Windows.Forms.TextBox();
            this.text_sv_row4_1 = new System.Windows.Forms.TextBox();
            this.button_sv_tp = new System.Windows.Forms.Button();
            this.button_sv_op = new System.Windows.Forms.Button();
            this.button_sv_shb = new System.Windows.Forms.Button();
            this.button_sv_she = new System.Windows.Forms.Button();
            this.button_sv_pt = new System.Windows.Forms.Button();
            this.button_sv_fn = new System.Windows.Forms.Button();
            this.button_sv_pre = new System.Windows.Forms.Button();
            this.button_sv_mode1 = new System.Windows.Forms.Button();
            this.button_sv_mode2 = new System.Windows.Forms.Button();
            this.button_sv_mode3 = new System.Windows.Forms.Button();
            this.button_sv_mode4 = new System.Windows.Forms.Button();
            this.button_sv_next = new System.Windows.Forms.Button();
            this.tabSpecUp = new System.Windows.Forms.TabPage();
            this.chb_EEPROM = new System.Windows.Forms.CheckBox();
            this.chb_TPIC = new System.Windows.Forms.CheckBox();
            this.chb_PMIC = new System.Windows.Forms.CheckBox();
            this.chb_InData = new System.Windows.Forms.CheckBox();
            this.chb_bootApp = new System.Windows.Forms.CheckBox();
            this.text_eep = new System.Windows.Forms.TextBox();
            this.bt_eep_update = new System.Windows.Forms.Button();
            this.text_pmic = new System.Windows.Forms.TextBox();
            this.bt_pmic_Update = new System.Windows.Forms.Button();
            this.chb_subname = new System.Windows.Forms.CheckBox();
            this.chb_logunit = new System.Windows.Forms.CheckBox();
            this.chb_fwwrite = new System.Windows.Forms.CheckBox();
            this.chb_ngcont = new System.Windows.Forms.CheckBox();
            this.bt_data_Update = new System.Windows.Forms.Button();
            this.bt_ict_update = new System.Windows.Forms.Button();
            this.text_data = new System.Windows.Forms.TextBox();
            this.text_ict = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.pn_result = new System.Windows.Forms.Panel();
            this.text_result = new System.Windows.Forms.TextBox();
            this.text_popup4 = new System.Windows.Forms.TextBox();
            this.text_popup3 = new System.Windows.Forms.TextBox();
            this.text_popup1 = new System.Windows.Forms.TextBox();
            this.text_popup2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sub_popup = new System.Windows.Forms.Button();
            this.bd_version = new System.Windows.Forms.TextBox();
            this.text_tact_time = new System.Windows.Forms.TextBox();
            this.text_ng = new System.Windows.Forms.TextBox();
            this.text_ok = new System.Windows.Forms.TextBox();
            this.text_qty = new System.Windows.Forms.TextBox();
            this.txt_Vision = new System.Windows.Forms.TextBox();
            this.txt_Handler = new System.Windows.Forms.TextBox();
            this.txt_3Stage = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_sdclog = new System.Windows.Forms.TextBox();
            this.txt_fwwrite = new System.Windows.Forms.TextBox();
            this.txt_ngcont = new System.Windows.Forms.TextBox();
            this.rd_mode4 = new System.Windows.Forms.RadioButton();
            this.rd_mode3 = new System.Windows.Forms.RadioButton();
            this.rd_mode2 = new System.Windows.Forms.RadioButton();
            this.rd_mode1 = new System.Windows.Forms.RadioButton();
            this.bt_modechange = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabCheck = new System.Windows.Forms.TabPage();
            this.text_check_popup = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.TimerMelfasCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBox_pj_name.SuspendLayout();
            this.status_main.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.tabBoot.SuspendLayout();
            this.tabVision.SuspendLayout();
            this.grbox_cam1.SuspendLayout();
            this.group_cam1_match.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_cam1)).BeginInit();
            this.grbox_cam2.SuspendLayout();
            this.group_cam2_match.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_cam2)).BeginInit();
            this.gb_sol_control.SuspendLayout();
            this.tabSpecview.SuspendLayout();
            this.tabSpecUp.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pn_result.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCheck.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_pj_name
            // 
            this.groupBox_pj_name.BackColor = System.Drawing.Color.Black;
            this.groupBox_pj_name.Controls.Add(this.text_pj_sub);
            this.groupBox_pj_name.Controls.Add(this.text_pj_data);
            this.groupBox_pj_name.Controls.Add(this.text_pj_name);
            this.groupBox_pj_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_pj_name.Font = new System.Drawing.Font("굴림", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_pj_name.Location = new System.Drawing.Point(0, 0);
            this.groupBox_pj_name.Name = "groupBox_pj_name";
            this.groupBox_pj_name.Size = new System.Drawing.Size(1024, 46);
            this.groupBox_pj_name.TabIndex = 127;
            this.groupBox_pj_name.TabStop = false;
            // 
            // text_pj_sub
            // 
            this.text_pj_sub.BackColor = System.Drawing.Color.Black;
            this.text_pj_sub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pj_sub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pj_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_pj_sub.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pj_sub.ForeColor = System.Drawing.Color.White;
            this.text_pj_sub.Location = new System.Drawing.Point(432, 24);
            this.text_pj_sub.Name = "text_pj_sub";
            this.text_pj_sub.ReadOnly = true;
            this.text_pj_sub.Size = new System.Drawing.Size(589, 18);
            this.text_pj_sub.TabIndex = 115;
            this.text_pj_sub.Text = "Spec History";
            this.text_pj_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_pj_data
            // 
            this.text_pj_data.BackColor = System.Drawing.Color.Black;
            this.text_pj_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pj_data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pj_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_pj_data.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pj_data.ForeColor = System.Drawing.Color.White;
            this.text_pj_data.Location = new System.Drawing.Point(432, 6);
            this.text_pj_data.Name = "text_pj_data";
            this.text_pj_data.ReadOnly = true;
            this.text_pj_data.Size = new System.Drawing.Size(589, 18);
            this.text_pj_data.TabIndex = 116;
            this.text_pj_data.Text = "Data File Name";
            this.text_pj_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_pj_name
            // 
            this.text_pj_name.BackColor = System.Drawing.Color.Black;
            this.text_pj_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pj_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pj_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.text_pj_name.Font = new System.Drawing.Font("Yu Gothic UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pj_name.ForeColor = System.Drawing.Color.White;
            this.text_pj_name.Location = new System.Drawing.Point(3, 6);
            this.text_pj_name.Name = "text_pj_name";
            this.text_pj_name.ReadOnly = true;
            this.text_pj_name.Size = new System.Drawing.Size(429, 34);
            this.text_pj_name.TabIndex = 114;
            this.text_pj_name.Text = "Project Name";
            // 
            // bt_st1st2
            // 
            this.bt_st1st2.BackColor = System.Drawing.Color.Black;
            this.bt_st1st2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_st1st2.BackgroundImage")));
            this.bt_st1st2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_st1st2.FlatAppearance.BorderSize = 0;
            this.bt_st1st2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_st1st2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_st1st2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_st1st2.ForeColor = System.Drawing.Color.White;
            this.bt_st1st2.Location = new System.Drawing.Point(820, 547);
            this.bt_st1st2.Name = "bt_st1st2";
            this.bt_st1st2.Size = new System.Drawing.Size(204, 28);
            this.bt_st1st2.TabIndex = 123;
            this.bt_st1st2.Text = "START1+START2";
            this.bt_st1st2.UseVisualStyleBackColor = false;
            this.bt_st1st2.Click += new System.EventHandler(this.bt_st1st2_Click);
            // 
            // bt_next_page
            // 
            this.bt_next_page.BackColor = System.Drawing.Color.Black;
            this.bt_next_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_next_page.BackgroundImage")));
            this.bt_next_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_next_page.FlatAppearance.BorderSize = 0;
            this.bt_next_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_next_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_next_page.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next_page.ForeColor = System.Drawing.Color.White;
            this.bt_next_page.Location = new System.Drawing.Point(615, 547);
            this.bt_next_page.Name = "bt_next_page";
            this.bt_next_page.Size = new System.Drawing.Size(204, 28);
            this.bt_next_page.TabIndex = 184;
            this.bt_next_page.Text = "START1";
            this.bt_next_page.UseVisualStyleBackColor = false;
            this.bt_next_page.Click += new System.EventHandler(this.bt_next_page_Click);
            // 
            // bt_prev_page
            // 
            this.bt_prev_page.BackColor = System.Drawing.Color.Black;
            this.bt_prev_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_prev_page.BackgroundImage")));
            this.bt_prev_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_prev_page.FlatAppearance.BorderSize = 0;
            this.bt_prev_page.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_prev_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prev_page.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prev_page.ForeColor = System.Drawing.Color.White;
            this.bt_prev_page.Location = new System.Drawing.Point(0, 547);
            this.bt_prev_page.Name = "bt_prev_page";
            this.bt_prev_page.Size = new System.Drawing.Size(204, 28);
            this.bt_prev_page.TabIndex = 183;
            this.bt_prev_page.Text = "START2";
            this.bt_prev_page.UseVisualStyleBackColor = false;
            this.bt_prev_page.Click += new System.EventHandler(this.bt_prev_page_Click);
            // 
            // bt_esc_key
            // 
            this.bt_esc_key.BackColor = System.Drawing.Color.Black;
            this.bt_esc_key.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_esc_key.BackgroundImage")));
            this.bt_esc_key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_esc_key.FlatAppearance.BorderSize = 0;
            this.bt_esc_key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_esc_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_esc_key.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_esc_key.ForeColor = System.Drawing.Color.White;
            this.bt_esc_key.Location = new System.Drawing.Point(410, 547);
            this.bt_esc_key.Name = "bt_esc_key";
            this.bt_esc_key.Size = new System.Drawing.Size(204, 28);
            this.bt_esc_key.TabIndex = 187;
            this.bt_esc_key.Text = "ESC";
            this.bt_esc_key.UseVisualStyleBackColor = false;
            this.bt_esc_key.Click += new System.EventHandler(this.bt_esc_key_Click);
            // 
            // status_main
            // 
            this.status_main.BackColor = System.Drawing.Color.Black;
            this.status_main.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close_Label,
            this.ID_GUI,
            this.bd_ver_label,
            this.run_mode_label,
            this.Board_Port,
            this.Stage_Port,
            this.Camera_conn,
            this.toolStripStatusLabel2,
            this.sen_input});
            this.status_main.Location = new System.Drawing.Point(0, 574);
            this.status_main.Name = "status_main";
            this.status_main.Size = new System.Drawing.Size(1024, 26);
            this.status_main.SizingGrip = false;
            this.status_main.TabIndex = 188;
            this.status_main.Text = "statusStrip1";
            // 
            // Close_Label
            // 
            this.Close_Label.AutoSize = false;
            this.Close_Label.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Close_Label.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Close_Label.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Close_Label.DoubleClickEnabled = true;
            this.Close_Label.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Label.Name = "Close_Label";
            this.Close_Label.Size = new System.Drawing.Size(100, 21);
            this.Close_Label.Text = "EXIT";
            this.Close_Label.DoubleClick += new System.EventHandler(this.Close_Label_DoubleClick);
            // 
            // ID_GUI
            // 
            this.ID_GUI.AutoSize = false;
            this.ID_GUI.BackColor = System.Drawing.Color.MidnightBlue;
            this.ID_GUI.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ID_GUI.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.ID_GUI.DoubleClickEnabled = true;
            this.ID_GUI.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_GUI.Name = "ID_GUI";
            this.ID_GUI.Size = new System.Drawing.Size(100, 21);
            this.ID_GUI.Text = "Machine No.0";
            this.ID_GUI.DoubleClick += new System.EventHandler(this.ID_GUI_DoubleClick);
            // 
            // bd_ver_label
            // 
            this.bd_ver_label.AutoSize = false;
            this.bd_ver_label.BackColor = System.Drawing.Color.MidnightBlue;
            this.bd_ver_label.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.bd_ver_label.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.bd_ver_label.DoubleClickEnabled = true;
            this.bd_ver_label.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_ver_label.Name = "bd_ver_label";
            this.bd_ver_label.Size = new System.Drawing.Size(100, 21);
            this.bd_ver_label.Text = "KM-V1.00(D)";
            this.bd_ver_label.DoubleClick += new System.EventHandler(this.VER_GUI_DoubleClick);
            // 
            // run_mode_label
            // 
            this.run_mode_label.AutoSize = false;
            this.run_mode_label.BackColor = System.Drawing.Color.MidnightBlue;
            this.run_mode_label.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.run_mode_label.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.run_mode_label.DoubleClickEnabled = true;
            this.run_mode_label.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_mode_label.Name = "run_mode_label";
            this.run_mode_label.Size = new System.Drawing.Size(100, 21);
            this.run_mode_label.Text = "APP/BOOT";
            this.run_mode_label.DoubleClick += new System.EventHandler(this.run_mode_label_DoubleClick);
            // 
            // Board_Port
            // 
            this.Board_Port.AutoSize = false;
            this.Board_Port.BackColor = System.Drawing.Color.Red;
            this.Board_Port.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Board_Port.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Board_Port.DoubleClickEnabled = true;
            this.Board_Port.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Board_Port.ForeColor = System.Drawing.Color.Black;
            this.Board_Port.Name = "Board_Port";
            this.Board_Port.Size = new System.Drawing.Size(100, 21);
            this.Board_Port.Text = "BOARD : COM0";
            // 
            // Stage_Port
            // 
            this.Stage_Port.AutoSize = false;
            this.Stage_Port.BackColor = System.Drawing.Color.Red;
            this.Stage_Port.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Stage_Port.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Stage_Port.DoubleClickEnabled = true;
            this.Stage_Port.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stage_Port.ForeColor = System.Drawing.Color.Black;
            this.Stage_Port.Name = "Stage_Port";
            this.Stage_Port.Size = new System.Drawing.Size(100, 21);
            this.Stage_Port.Text = "STAGE : COM0";
            // 
            // Camera_conn
            // 
            this.Camera_conn.AutoSize = false;
            this.Camera_conn.BackColor = System.Drawing.Color.Red;
            this.Camera_conn.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Camera_conn.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Camera_conn.DoubleClickEnabled = true;
            this.Camera_conn.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_conn.ForeColor = System.Drawing.Color.Black;
            this.Camera_conn.Name = "Camera_conn";
            this.Camera_conn.Size = new System.Drawing.Size(100, 21);
            this.Camera_conn.Text = "Camera";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel2.DoubleClickEnabled = true;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 21);
            this.toolStripStatusLabel2.Text = "Handler";
            // 
            // sen_input
            // 
            this.sen_input.AutoSize = false;
            this.sen_input.BackColor = System.Drawing.Color.Red;
            this.sen_input.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sen_input.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.sen_input.DoubleClickEnabled = true;
            this.sen_input.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sen_input.ForeColor = System.Drawing.Color.Black;
            this.sen_input.Name = "sen_input";
            this.sen_input.Size = new System.Drawing.Size(100, 21);
            this.sen_input.Text = "Safe Sensor";
            // 
            // bt_mode_key
            // 
            this.bt_mode_key.BackColor = System.Drawing.Color.Black;
            this.bt_mode_key.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_mode_key.BackgroundImage")));
            this.bt_mode_key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_mode_key.FlatAppearance.BorderSize = 0;
            this.bt_mode_key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_mode_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mode_key.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mode_key.ForeColor = System.Drawing.Color.Black;
            this.bt_mode_key.Location = new System.Drawing.Point(205, 547);
            this.bt_mode_key.Name = "bt_mode_key";
            this.bt_mode_key.Size = new System.Drawing.Size(204, 28);
            this.bt_mode_key.TabIndex = 189;
            this.bt_mode_key.Text = "FUNCTION";
            this.bt_mode_key.UseVisualStyleBackColor = false;
            this.bt_mode_key.Click += new System.EventHandler(this.bt_mode_key_Click);
            // 
            // tabDebug
            // 
            this.tabDebug.BackColor = System.Drawing.Color.Black;
            this.tabDebug.Controls.Add(this.text_log);
            this.tabDebug.Controls.Add(this.textBox7);
            this.tabDebug.Location = new System.Drawing.Point(4, 24);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(1016, 471);
            this.tabDebug.TabIndex = 5;
            this.tabDebug.Text = "Debug";
            // 
            // text_log
            // 
            this.text_log.BackColor = System.Drawing.Color.Black;
            this.text_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_log.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_log.ForeColor = System.Drawing.Color.White;
            this.text_log.Location = new System.Drawing.Point(3, 35);
            this.text_log.Multiline = true;
            this.text_log.Name = "text_log";
            this.text_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_log.Size = new System.Drawing.Size(1010, 433);
            this.text_log.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DimGray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox7.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(1010, 32);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "Debug Message";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabBoot
            // 
            this.tabBoot.BackColor = System.Drawing.Color.Black;
            this.tabBoot.Controls.Add(this.text_fw);
            this.tabBoot.Controls.Add(this.text_boot_ver);
            this.tabBoot.Controls.Add(this.bt_fw_reload);
            this.tabBoot.Controls.Add(this.bt_down_fw);
            this.tabBoot.Controls.Add(this.bt_full_erase);
            this.tabBoot.Location = new System.Drawing.Point(4, 24);
            this.tabBoot.Name = "tabBoot";
            this.tabBoot.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoot.Size = new System.Drawing.Size(1016, 471);
            this.tabBoot.TabIndex = 7;
            this.tabBoot.Text = "Bootloader";
            // 
            // text_fw
            // 
            this.text_fw.BackColor = System.Drawing.Color.Black;
            this.text_fw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_fw.Dock = System.Windows.Forms.DockStyle.Left;
            this.text_fw.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fw.ForeColor = System.Drawing.Color.White;
            this.text_fw.Location = new System.Drawing.Point(3, 35);
            this.text_fw.Multiline = true;
            this.text_fw.Name = "text_fw";
            this.text_fw.ReadOnly = true;
            this.text_fw.Size = new System.Drawing.Size(863, 433);
            this.text_fw.TabIndex = 187;
            // 
            // text_boot_ver
            // 
            this.text_boot_ver.BackColor = System.Drawing.Color.DimGray;
            this.text_boot_ver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_boot_ver.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_boot_ver.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_boot_ver.ForeColor = System.Drawing.Color.White;
            this.text_boot_ver.Location = new System.Drawing.Point(3, 3);
            this.text_boot_ver.Name = "text_boot_ver";
            this.text_boot_ver.ReadOnly = true;
            this.text_boot_ver.Size = new System.Drawing.Size(1010, 32);
            this.text_boot_ver.TabIndex = 3;
            this.text_boot_ver.Text = "Bootloader";
            this.text_boot_ver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_fw_reload
            // 
            this.bt_fw_reload.BackColor = System.Drawing.Color.Black;
            this.bt_fw_reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_fw_reload.BackgroundImage")));
            this.bt_fw_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_fw_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fw_reload.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fw_reload.ForeColor = System.Drawing.Color.DimGray;
            this.bt_fw_reload.Location = new System.Drawing.Point(872, 38);
            this.bt_fw_reload.Name = "bt_fw_reload";
            this.bt_fw_reload.Size = new System.Drawing.Size(140, 140);
            this.bt_fw_reload.TabIndex = 189;
            this.bt_fw_reload.UseVisualStyleBackColor = false;
            this.bt_fw_reload.Click += new System.EventHandler(this.bt_fw_reload_Click);
            // 
            // bt_down_fw
            // 
            this.bt_down_fw.BackColor = System.Drawing.Color.Black;
            this.bt_down_fw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_down_fw.BackgroundImage")));
            this.bt_down_fw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_down_fw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_down_fw.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_down_fw.ForeColor = System.Drawing.Color.DimGray;
            this.bt_down_fw.Location = new System.Drawing.Point(872, 184);
            this.bt_down_fw.Name = "bt_down_fw";
            this.bt_down_fw.Size = new System.Drawing.Size(140, 140);
            this.bt_down_fw.TabIndex = 184;
            this.bt_down_fw.UseVisualStyleBackColor = false;
            this.bt_down_fw.Click += new System.EventHandler(this.bt_down_fw_Click);
            // 
            // bt_full_erase
            // 
            this.bt_full_erase.BackColor = System.Drawing.Color.Black;
            this.bt_full_erase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_full_erase.BackgroundImage")));
            this.bt_full_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_full_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_full_erase.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bt_full_erase.ForeColor = System.Drawing.Color.DimGray;
            this.bt_full_erase.Location = new System.Drawing.Point(872, 329);
            this.bt_full_erase.Name = "bt_full_erase";
            this.bt_full_erase.Size = new System.Drawing.Size(140, 140);
            this.bt_full_erase.TabIndex = 188;
            this.bt_full_erase.UseVisualStyleBackColor = false;
            this.bt_full_erase.Click += new System.EventHandler(this.bt_full_erase_Click);
            // 
            // tabVision
            // 
            this.tabVision.BackColor = System.Drawing.Color.Black;
            this.tabVision.Controls.Add(this.grbox_cam1);
            this.tabVision.Controls.Add(this.grbox_cam2);
            this.tabVision.Controls.Add(this.gb_sol_control);
            this.tabVision.Location = new System.Drawing.Point(4, 24);
            this.tabVision.Name = "tabVision";
            this.tabVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabVision.Size = new System.Drawing.Size(1016, 471);
            this.tabVision.TabIndex = 6;
            this.tabVision.Text = "Vision";
            // 
            // grbox_cam1
            // 
            this.grbox_cam1.Controls.Add(this.group_cam1_match);
            this.grbox_cam1.Controls.Add(this.bt_cam1_vfflip);
            this.grbox_cam1.Controls.Add(this.bt_cam1_hfflip);
            this.grbox_cam1.Controls.Add(this.disp_cam1);
            this.grbox_cam1.Controls.Add(this.bt_result_align1);
            this.grbox_cam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbox_cam1.Location = new System.Drawing.Point(2, -6);
            this.grbox_cam1.Margin = new System.Windows.Forms.Padding(0);
            this.grbox_cam1.Name = "grbox_cam1";
            this.grbox_cam1.Padding = new System.Windows.Forms.Padding(0);
            this.grbox_cam1.Size = new System.Drawing.Size(505, 371);
            this.grbox_cam1.TabIndex = 38;
            this.grbox_cam1.TabStop = false;
            // 
            // group_cam1_match
            // 
            this.group_cam1_match.Controls.Add(this.text_x_dist1);
            this.group_cam1_match.Controls.Add(this.text_t_dist1);
            this.group_cam1_match.Controls.Add(this.text_y_dist1);
            this.group_cam1_match.Controls.Add(this.label13);
            this.group_cam1_match.Controls.Add(this.label15);
            this.group_cam1_match.Controls.Add(this.label14);
            this.group_cam1_match.Font = new System.Drawing.Font("Yu Gothic UI", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_cam1_match.Location = new System.Drawing.Point(2, 336);
            this.group_cam1_match.Name = "group_cam1_match";
            this.group_cam1_match.Size = new System.Drawing.Size(96, 32);
            this.group_cam1_match.TabIndex = 120;
            this.group_cam1_match.TabStop = false;
            // 
            // text_x_dist1
            // 
            this.text_x_dist1.BackColor = System.Drawing.Color.DimGray;
            this.text_x_dist1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_x_dist1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_x_dist1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_x_dist1.ForeColor = System.Drawing.Color.Black;
            this.text_x_dist1.Location = new System.Drawing.Point(2, 14);
            this.text_x_dist1.Name = "text_x_dist1";
            this.text_x_dist1.ReadOnly = true;
            this.text_x_dist1.Size = new System.Drawing.Size(30, 15);
            this.text_x_dist1.TabIndex = 104;
            this.text_x_dist1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_t_dist1
            // 
            this.text_t_dist1.BackColor = System.Drawing.Color.DimGray;
            this.text_t_dist1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_t_dist1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_t_dist1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_t_dist1.ForeColor = System.Drawing.Color.Black;
            this.text_t_dist1.Location = new System.Drawing.Point(64, 14);
            this.text_t_dist1.Name = "text_t_dist1";
            this.text_t_dist1.ReadOnly = true;
            this.text_t_dist1.Size = new System.Drawing.Size(30, 15);
            this.text_t_dist1.TabIndex = 110;
            this.text_t_dist1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_y_dist1
            // 
            this.text_y_dist1.BackColor = System.Drawing.Color.DimGray;
            this.text_y_dist1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_y_dist1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_y_dist1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_y_dist1.ForeColor = System.Drawing.Color.Black;
            this.text_y_dist1.Location = new System.Drawing.Point(33, 14);
            this.text_y_dist1.Name = "text_y_dist1";
            this.text_y_dist1.ReadOnly = true;
            this.text_y_dist1.Size = new System.Drawing.Size(30, 15);
            this.text_y_dist1.TabIndex = 105;
            this.text_y_dist1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(38, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 113;
            this.label13.Text = "ΔY";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(72, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 115;
            this.label15.Text = "ΔT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(9, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 112;
            this.label14.Text = "ΔX";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cam1_vfflip
            // 
            this.bt_cam1_vfflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cam1_vfflip.BackgroundImage")));
            this.bt_cam1_vfflip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cam1_vfflip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cam1_vfflip.Location = new System.Drawing.Point(439, 337);
            this.bt_cam1_vfflip.Name = "bt_cam1_vfflip";
            this.bt_cam1_vfflip.Size = new System.Drawing.Size(30, 30);
            this.bt_cam1_vfflip.TabIndex = 119;
            this.bt_cam1_vfflip.UseVisualStyleBackColor = true;
            this.bt_cam1_vfflip.Click += new System.EventHandler(this.bt_cam1_vfflip_Click);
            // 
            // bt_cam1_hfflip
            // 
            this.bt_cam1_hfflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cam1_hfflip.BackgroundImage")));
            this.bt_cam1_hfflip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cam1_hfflip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cam1_hfflip.Location = new System.Drawing.Point(471, 337);
            this.bt_cam1_hfflip.Name = "bt_cam1_hfflip";
            this.bt_cam1_hfflip.Size = new System.Drawing.Size(30, 30);
            this.bt_cam1_hfflip.TabIndex = 118;
            this.bt_cam1_hfflip.UseVisualStyleBackColor = true;
            this.bt_cam1_hfflip.Click += new System.EventHandler(this.bt_cam1_hfflip_Click);
            // 
            // disp_cam1
            // 
            this.disp_cam1.BackColor = System.Drawing.Color.Black;
            this.disp_cam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disp_cam1.Location = new System.Drawing.Point(2, 9);
            this.disp_cam1.Name = "disp_cam1";
            this.disp_cam1.Size = new System.Drawing.Size(501, 326);
            this.disp_cam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disp_cam1.TabIndex = 27;
            this.disp_cam1.TabStop = false;
            // 
            // bt_result_align1
            // 
            this.bt_result_align1.BackColor = System.Drawing.Color.Black;
            this.bt_result_align1.FlatAppearance.BorderSize = 0;
            this.bt_result_align1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_result_align1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_result_align1.Location = new System.Drawing.Point(190, 337);
            this.bt_result_align1.Name = "bt_result_align1";
            this.bt_result_align1.Size = new System.Drawing.Size(126, 30);
            this.bt_result_align1.TabIndex = 122;
            this.bt_result_align1.UseVisualStyleBackColor = false;
            // 
            // grbox_cam2
            // 
            this.grbox_cam2.Controls.Add(this.bt_result_align2);
            this.grbox_cam2.Controls.Add(this.group_cam2_match);
            this.grbox_cam2.Controls.Add(this.bt_cam2_vfflip);
            this.grbox_cam2.Controls.Add(this.bt_cam2_hfflip);
            this.grbox_cam2.Controls.Add(this.disp_cam2);
            this.grbox_cam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbox_cam2.Location = new System.Drawing.Point(509, -6);
            this.grbox_cam2.Margin = new System.Windows.Forms.Padding(0);
            this.grbox_cam2.Name = "grbox_cam2";
            this.grbox_cam2.Padding = new System.Windows.Forms.Padding(0);
            this.grbox_cam2.Size = new System.Drawing.Size(505, 371);
            this.grbox_cam2.TabIndex = 39;
            this.grbox_cam2.TabStop = false;
            // 
            // bt_result_align2
            // 
            this.bt_result_align2.BackColor = System.Drawing.Color.Black;
            this.bt_result_align2.FlatAppearance.BorderSize = 0;
            this.bt_result_align2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_result_align2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_result_align2.Location = new System.Drawing.Point(190, 337);
            this.bt_result_align2.Name = "bt_result_align2";
            this.bt_result_align2.Size = new System.Drawing.Size(126, 30);
            this.bt_result_align2.TabIndex = 123;
            this.bt_result_align2.UseVisualStyleBackColor = false;
            // 
            // group_cam2_match
            // 
            this.group_cam2_match.Controls.Add(this.text_y_dist2);
            this.group_cam2_match.Controls.Add(this.text_t_dist2);
            this.group_cam2_match.Controls.Add(this.label2);
            this.group_cam2_match.Controls.Add(this.text_x_dist2);
            this.group_cam2_match.Controls.Add(this.label5);
            this.group_cam2_match.Controls.Add(this.label4);
            this.group_cam2_match.Font = new System.Drawing.Font("Yu Gothic UI", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_cam2_match.Location = new System.Drawing.Point(2, 336);
            this.group_cam2_match.Name = "group_cam2_match";
            this.group_cam2_match.Size = new System.Drawing.Size(96, 32);
            this.group_cam2_match.TabIndex = 118;
            this.group_cam2_match.TabStop = false;
            // 
            // text_y_dist2
            // 
            this.text_y_dist2.BackColor = System.Drawing.Color.DimGray;
            this.text_y_dist2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_y_dist2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_y_dist2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_y_dist2.ForeColor = System.Drawing.Color.Black;
            this.text_y_dist2.Location = new System.Drawing.Point(33, 14);
            this.text_y_dist2.Name = "text_y_dist2";
            this.text_y_dist2.ReadOnly = true;
            this.text_y_dist2.Size = new System.Drawing.Size(30, 15);
            this.text_y_dist2.TabIndex = 107;
            this.text_y_dist2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_t_dist2
            // 
            this.text_t_dist2.BackColor = System.Drawing.Color.DimGray;
            this.text_t_dist2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_t_dist2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_t_dist2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_t_dist2.ForeColor = System.Drawing.Color.Black;
            this.text_t_dist2.Location = new System.Drawing.Point(64, 14);
            this.text_t_dist2.Name = "text_t_dist2";
            this.text_t_dist2.ReadOnly = true;
            this.text_t_dist2.Size = new System.Drawing.Size(30, 15);
            this.text_t_dist2.TabIndex = 114;
            this.text_t_dist2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "ΔT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_x_dist2
            // 
            this.text_x_dist2.BackColor = System.Drawing.Color.DimGray;
            this.text_x_dist2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_x_dist2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_x_dist2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.text_x_dist2.ForeColor = System.Drawing.Color.Black;
            this.text_x_dist2.Location = new System.Drawing.Point(2, 14);
            this.text_x_dist2.Name = "text_x_dist2";
            this.text_x_dist2.ReadOnly = true;
            this.text_x_dist2.Size = new System.Drawing.Size(30, 15);
            this.text_x_dist2.TabIndex = 106;
            this.text_x_dist2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "ΔX";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "ΔY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cam2_vfflip
            // 
            this.bt_cam2_vfflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cam2_vfflip.BackgroundImage")));
            this.bt_cam2_vfflip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cam2_vfflip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cam2_vfflip.ForeColor = System.Drawing.Color.White;
            this.bt_cam2_vfflip.Location = new System.Drawing.Point(439, 337);
            this.bt_cam2_vfflip.Name = "bt_cam2_vfflip";
            this.bt_cam2_vfflip.Size = new System.Drawing.Size(30, 30);
            this.bt_cam2_vfflip.TabIndex = 117;
            this.bt_cam2_vfflip.UseVisualStyleBackColor = true;
            this.bt_cam2_vfflip.Click += new System.EventHandler(this.bt_cam2_vfflip_Click);
            // 
            // bt_cam2_hfflip
            // 
            this.bt_cam2_hfflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cam2_hfflip.BackgroundImage")));
            this.bt_cam2_hfflip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cam2_hfflip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cam2_hfflip.ForeColor = System.Drawing.Color.White;
            this.bt_cam2_hfflip.Location = new System.Drawing.Point(471, 337);
            this.bt_cam2_hfflip.Name = "bt_cam2_hfflip";
            this.bt_cam2_hfflip.Size = new System.Drawing.Size(30, 30);
            this.bt_cam2_hfflip.TabIndex = 116;
            this.bt_cam2_hfflip.UseVisualStyleBackColor = true;
            this.bt_cam2_hfflip.Click += new System.EventHandler(this.bt_cam2_hfflip_Click);
            // 
            // disp_cam2
            // 
            this.disp_cam2.BackColor = System.Drawing.Color.Black;
            this.disp_cam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disp_cam2.Location = new System.Drawing.Point(2, 9);
            this.disp_cam2.Name = "disp_cam2";
            this.disp_cam2.Size = new System.Drawing.Size(501, 326);
            this.disp_cam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disp_cam2.TabIndex = 28;
            this.disp_cam2.TabStop = false;
            // 
            // gb_sol_control
            // 
            this.gb_sol_control.Controls.Add(this.bt_match_disp);
            this.gb_sol_control.Controls.Add(this.bt_cam_change);
            this.gb_sol_control.Controls.Add(this.bt_solo_on);
            this.gb_sol_control.Controls.Add(this.bt_dual_on);
            this.gb_sol_control.Controls.Add(this.button6);
            this.gb_sol_control.Controls.Add(this.text_led4);
            this.gb_sol_control.Controls.Add(this.text_led3);
            this.gb_sol_control.Controls.Add(this.text_led2);
            this.gb_sol_control.Controls.Add(this.text_led1);
            this.gb_sol_control.Controls.Add(this.button7);
            this.gb_sol_control.Controls.Add(this.bt_vision_setup);
            this.gb_sol_control.Controls.Add(this.button5);
            this.gb_sol_control.Controls.Add(this.button4);
            this.gb_sol_control.Controls.Add(this.button3);
            this.gb_sol_control.Controls.Add(this.button2);
            this.gb_sol_control.Controls.Add(this.button1);
            this.gb_sol_control.Controls.Add(this.label16);
            this.gb_sol_control.Controls.Add(this.label8);
            this.gb_sol_control.Controls.Add(this.label3);
            this.gb_sol_control.Controls.Add(this.label1);
            this.gb_sol_control.Controls.Add(this.bt_load_center);
            this.gb_sol_control.Controls.Add(this.text_t_jog);
            this.gb_sol_control.Controls.Add(this.text_y_jog);
            this.gb_sol_control.Controls.Add(this.bt_x_jog_p);
            this.gb_sol_control.Controls.Add(this.text_x_jog);
            this.gb_sol_control.Controls.Add(this.bt_y_jog_p);
            this.gb_sol_control.Controls.Add(this.bt_x_jog_n);
            this.gb_sol_control.Controls.Add(this.text_loc_y);
            this.gb_sol_control.Controls.Add(this.bt_t_jog_n);
            this.gb_sol_control.Controls.Add(this.bt_t_jog_p);
            this.gb_sol_control.Controls.Add(this.bt_y_jog_n);
            this.gb_sol_control.Controls.Add(this.text_loc_t);
            this.gb_sol_control.Controls.Add(this.text_loc_x);
            this.gb_sol_control.Controls.Add(this.bt_all_home);
            this.gb_sol_control.Controls.Add(this.bt_y_home);
            this.gb_sol_control.Controls.Add(this.bt_all_center);
            this.gb_sol_control.Controls.Add(this.bt_x_home);
            this.gb_sol_control.Controls.Add(this.bt_t_home);
            this.gb_sol_control.Controls.Add(this.text_os_dx);
            this.gb_sol_control.Controls.Add(this.by_stage_center_save);
            this.gb_sol_control.Controls.Add(this.label10);
            this.gb_sol_control.Controls.Add(this.bt_autoalign);
            this.gb_sol_control.Controls.Add(this.label11);
            this.gb_sol_control.Controls.Add(this.bt_led_save);
            this.gb_sol_control.Controls.Add(this.text_os_dy);
            this.gb_sol_control.Controls.Add(this.bt_t_center);
            this.gb_sol_control.Controls.Add(this.label12);
            this.gb_sol_control.Controls.Add(this.bt_align_est);
            this.gb_sol_control.Controls.Add(this.text_os_dt);
            this.gb_sol_control.Controls.Add(this.text_sen8);
            this.gb_sol_control.Controls.Add(this.bt_y_center);
            this.gb_sol_control.Controls.Add(this.label9);
            this.gb_sol_control.Controls.Add(this.bt_sol1);
            this.gb_sol_control.Controls.Add(this.bt_x_center);
            this.gb_sol_control.Controls.Add(this.label7);
            this.gb_sol_control.Controls.Add(this.text_sen7);
            this.gb_sol_control.Controls.Add(this.label6);
            this.gb_sol_control.Controls.Add(this.bt_sol_all);
            this.gb_sol_control.Controls.Add(this.bt_sol2);
            this.gb_sol_control.Controls.Add(this.text_sen6);
            this.gb_sol_control.Controls.Add(this.bt_sol3);
            this.gb_sol_control.Controls.Add(this.text_sen5);
            this.gb_sol_control.Controls.Add(this.bt_sol4);
            this.gb_sol_control.Controls.Add(this.text_sen4);
            this.gb_sol_control.Controls.Add(this.bt_sol5);
            this.gb_sol_control.Controls.Add(this.text_sen3);
            this.gb_sol_control.Controls.Add(this.bt_sol6);
            this.gb_sol_control.Controls.Add(this.text_sen2);
            this.gb_sol_control.Controls.Add(this.text_sen1);
            this.gb_sol_control.Controls.Add(this.bt_sol7);
            this.gb_sol_control.Controls.Add(this.bt_sol8);
            this.gb_sol_control.Location = new System.Drawing.Point(2, 359);
            this.gb_sol_control.Name = "gb_sol_control";
            this.gb_sol_control.Size = new System.Drawing.Size(1012, 111);
            this.gb_sol_control.TabIndex = 26;
            this.gb_sol_control.TabStop = false;
            // 
            // bt_match_disp
            // 
            this.bt_match_disp.BackColor = System.Drawing.Color.Black;
            this.bt_match_disp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_match_disp.BackgroundImage")));
            this.bt_match_disp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_match_disp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_match_disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_match_disp.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_match_disp.ForeColor = System.Drawing.Color.White;
            this.bt_match_disp.Location = new System.Drawing.Point(824, 85);
            this.bt_match_disp.Name = "bt_match_disp";
            this.bt_match_disp.Size = new System.Drawing.Size(60, 23);
            this.bt_match_disp.TabIndex = 121;
            this.bt_match_disp.Text = "OFF";
            this.bt_match_disp.UseVisualStyleBackColor = false;
            this.bt_match_disp.Click += new System.EventHandler(this.bt_match_disp_Click);
            // 
            // bt_cam_change
            // 
            this.bt_cam_change.BackColor = System.Drawing.Color.Black;
            this.bt_cam_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cam_change.BackgroundImage")));
            this.bt_cam_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cam_change.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_cam_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cam_change.ForeColor = System.Drawing.Color.White;
            this.bt_cam_change.Location = new System.Drawing.Point(824, 60);
            this.bt_cam_change.Name = "bt_cam_change";
            this.bt_cam_change.Size = new System.Drawing.Size(60, 23);
            this.bt_cam_change.TabIndex = 119;
            this.bt_cam_change.UseVisualStyleBackColor = false;
            this.bt_cam_change.Click += new System.EventHandler(this.bt_cam_change_Click);
            // 
            // bt_solo_on
            // 
            this.bt_solo_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_solo_on.BackgroundImage")));
            this.bt_solo_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_solo_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_solo_on.Location = new System.Drawing.Point(824, 35);
            this.bt_solo_on.Name = "bt_solo_on";
            this.bt_solo_on.Size = new System.Drawing.Size(60, 23);
            this.bt_solo_on.TabIndex = 120;
            this.bt_solo_on.UseVisualStyleBackColor = true;
            this.bt_solo_on.Click += new System.EventHandler(this.bt_solo_on_Click);
            // 
            // bt_dual_on
            // 
            this.bt_dual_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_dual_on.BackgroundImage")));
            this.bt_dual_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_dual_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dual_on.Location = new System.Drawing.Point(824, 35);
            this.bt_dual_on.Name = "bt_dual_on";
            this.bt_dual_on.Size = new System.Drawing.Size(60, 23);
            this.bt_dual_on.TabIndex = 119;
            this.bt_dual_on.UseVisualStyleBackColor = true;
            this.bt_dual_on.Click += new System.EventHandler(this.bt_dual_on_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(818, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(5, 100);
            this.button6.TabIndex = 176;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // text_led4
            // 
            this.text_led4.BackColor = System.Drawing.Color.Black;
            this.text_led4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_led4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_led4.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_led4.ForeColor = System.Drawing.Color.White;
            this.text_led4.Location = new System.Drawing.Point(347, 85);
            this.text_led4.Name = "text_led4";
            this.text_led4.Size = new System.Drawing.Size(37, 22);
            this.text_led4.TabIndex = 117;
            this.text_led4.Text = "0";
            this.text_led4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_led3
            // 
            this.text_led3.BackColor = System.Drawing.Color.Black;
            this.text_led3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_led3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_led3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_led3.ForeColor = System.Drawing.Color.White;
            this.text_led3.Location = new System.Drawing.Point(347, 60);
            this.text_led3.Name = "text_led3";
            this.text_led3.Size = new System.Drawing.Size(37, 22);
            this.text_led3.TabIndex = 116;
            this.text_led3.Text = "0";
            this.text_led3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_led2
            // 
            this.text_led2.BackColor = System.Drawing.Color.Black;
            this.text_led2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_led2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_led2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_led2.ForeColor = System.Drawing.Color.White;
            this.text_led2.Location = new System.Drawing.Point(347, 35);
            this.text_led2.Name = "text_led2";
            this.text_led2.Size = new System.Drawing.Size(37, 22);
            this.text_led2.TabIndex = 115;
            this.text_led2.Text = "0";
            this.text_led2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_led1
            // 
            this.text_led1.BackColor = System.Drawing.Color.Black;
            this.text_led1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_led1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_led1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_led1.ForeColor = System.Drawing.Color.White;
            this.text_led1.Location = new System.Drawing.Point(347, 10);
            this.text_led1.Name = "text_led1";
            this.text_led1.Size = new System.Drawing.Size(37, 22);
            this.text_led1.TabIndex = 114;
            this.text_led1.Text = "0";
            this.text_led1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(887, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(5, 100);
            this.button7.TabIndex = 175;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // bt_vision_setup
            // 
            this.bt_vision_setup.BackColor = System.Drawing.Color.Black;
            this.bt_vision_setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_vision_setup.BackgroundImage")));
            this.bt_vision_setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_vision_setup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_vision_setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vision_setup.ForeColor = System.Drawing.Color.White;
            this.bt_vision_setup.Location = new System.Drawing.Point(824, 10);
            this.bt_vision_setup.Name = "bt_vision_setup";
            this.bt_vision_setup.Size = new System.Drawing.Size(60, 23);
            this.bt_vision_setup.TabIndex = 42;
            this.bt_vision_setup.UseVisualStyleBackColor = false;
            this.bt_vision_setup.Click += new System.EventHandler(this.bt_vision_setup_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(689, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(5, 100);
            this.button5.TabIndex = 173;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(553, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(5, 100);
            this.button4.TabIndex = 172;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(308, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(5, 100);
            this.button3.TabIndex = 171;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(428, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(5, 100);
            this.button2.TabIndex = 170;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 22);
            this.button1.TabIndex = 169;
            this.button1.Text = "Stage Jog Move";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(311, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 21);
            this.label16.TabIndex = 168;
            this.label16.Text = "CH4";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(311, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 167;
            this.label8.Text = "CH3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 166;
            this.label3.Text = "CH2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 165;
            this.label1.Text = "CH1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_load_center
            // 
            this.bt_load_center.BackColor = System.Drawing.Color.Black;
            this.bt_load_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_load_center.BackgroundImage")));
            this.bt_load_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_load_center.FlatAppearance.BorderSize = 0;
            this.bt_load_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_load_center.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_load_center.Location = new System.Drawing.Point(434, 80);
            this.bt_load_center.Name = "bt_load_center";
            this.bt_load_center.Size = new System.Drawing.Size(45, 27);
            this.bt_load_center.TabIndex = 164;
            this.bt_load_center.Text = "load";
            this.bt_load_center.UseVisualStyleBackColor = false;
            this.bt_load_center.Click += new System.EventHandler(this.bt_load_center_Click);
            // 
            // text_t_jog
            // 
            this.text_t_jog.BackColor = System.Drawing.Color.Black;
            this.text_t_jog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_t_jog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_t_jog.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_t_jog.ForeColor = System.Drawing.Color.White;
            this.text_t_jog.Location = new System.Drawing.Point(595, 84);
            this.text_t_jog.Name = "text_t_jog";
            this.text_t_jog.Size = new System.Drawing.Size(56, 25);
            this.text_t_jog.TabIndex = 137;
            this.text_t_jog.Text = "0";
            this.text_t_jog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_y_jog
            // 
            this.text_y_jog.BackColor = System.Drawing.Color.Black;
            this.text_y_jog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_y_jog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_y_jog.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_y_jog.ForeColor = System.Drawing.Color.White;
            this.text_y_jog.Location = new System.Drawing.Point(595, 58);
            this.text_y_jog.Name = "text_y_jog";
            this.text_y_jog.Size = new System.Drawing.Size(56, 25);
            this.text_y_jog.TabIndex = 137;
            this.text_y_jog.Text = "0";
            this.text_y_jog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_x_jog_p
            // 
            this.bt_x_jog_p.BackColor = System.Drawing.Color.Black;
            this.bt_x_jog_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_x_jog_p.BackgroundImage")));
            this.bt_x_jog_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_x_jog_p.FlatAppearance.BorderSize = 0;
            this.bt_x_jog_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_x_jog_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_x_jog_p.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_x_jog_p.Location = new System.Drawing.Point(652, 34);
            this.bt_x_jog_p.Name = "bt_x_jog_p";
            this.bt_x_jog_p.Size = new System.Drawing.Size(35, 23);
            this.bt_x_jog_p.TabIndex = 130;
            this.bt_x_jog_p.Text = "X+";
            this.bt_x_jog_p.UseVisualStyleBackColor = false;
            this.bt_x_jog_p.Click += new System.EventHandler(this.bt_x_jog_p_Click);
            // 
            // text_x_jog
            // 
            this.text_x_jog.BackColor = System.Drawing.Color.Black;
            this.text_x_jog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_x_jog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_x_jog.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_x_jog.ForeColor = System.Drawing.Color.White;
            this.text_x_jog.Location = new System.Drawing.Point(595, 33);
            this.text_x_jog.Name = "text_x_jog";
            this.text_x_jog.Size = new System.Drawing.Size(56, 25);
            this.text_x_jog.TabIndex = 136;
            this.text_x_jog.Text = "0";
            this.text_x_jog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_y_jog_p
            // 
            this.bt_y_jog_p.BackColor = System.Drawing.Color.Black;
            this.bt_y_jog_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_y_jog_p.BackgroundImage")));
            this.bt_y_jog_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_y_jog_p.FlatAppearance.BorderSize = 0;
            this.bt_y_jog_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_y_jog_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_y_jog_p.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_y_jog_p.Location = new System.Drawing.Point(652, 59);
            this.bt_y_jog_p.Name = "bt_y_jog_p";
            this.bt_y_jog_p.Size = new System.Drawing.Size(35, 23);
            this.bt_y_jog_p.TabIndex = 131;
            this.bt_y_jog_p.Text = "Y+";
            this.bt_y_jog_p.UseVisualStyleBackColor = false;
            this.bt_y_jog_p.Click += new System.EventHandler(this.bt_y_jog_p_Click);
            // 
            // bt_x_jog_n
            // 
            this.bt_x_jog_n.BackColor = System.Drawing.Color.Black;
            this.bt_x_jog_n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_x_jog_n.BackgroundImage")));
            this.bt_x_jog_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_x_jog_n.FlatAppearance.BorderSize = 0;
            this.bt_x_jog_n.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_x_jog_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_x_jog_n.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_x_jog_n.Location = new System.Drawing.Point(559, 34);
            this.bt_x_jog_n.Name = "bt_x_jog_n";
            this.bt_x_jog_n.Size = new System.Drawing.Size(35, 23);
            this.bt_x_jog_n.TabIndex = 133;
            this.bt_x_jog_n.Text = "X-";
            this.bt_x_jog_n.UseVisualStyleBackColor = false;
            this.bt_x_jog_n.Click += new System.EventHandler(this.bt_x_jog_n_Click);
            // 
            // text_loc_y
            // 
            this.text_loc_y.BackColor = System.Drawing.Color.Black;
            this.text_loc_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_loc_y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loc_y.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_loc_y.ForeColor = System.Drawing.Color.White;
            this.text_loc_y.Location = new System.Drawing.Point(480, 33);
            this.text_loc_y.Name = "text_loc_y";
            this.text_loc_y.ReadOnly = true;
            this.text_loc_y.Size = new System.Drawing.Size(71, 22);
            this.text_loc_y.TabIndex = 140;
            this.text_loc_y.Text = "0";
            this.text_loc_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_t_jog_n
            // 
            this.bt_t_jog_n.BackColor = System.Drawing.Color.Black;
            this.bt_t_jog_n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_t_jog_n.BackgroundImage")));
            this.bt_t_jog_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_t_jog_n.FlatAppearance.BorderSize = 0;
            this.bt_t_jog_n.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_t_jog_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_t_jog_n.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_t_jog_n.Location = new System.Drawing.Point(559, 84);
            this.bt_t_jog_n.Name = "bt_t_jog_n";
            this.bt_t_jog_n.Size = new System.Drawing.Size(35, 23);
            this.bt_t_jog_n.TabIndex = 135;
            this.bt_t_jog_n.Text = "T-";
            this.bt_t_jog_n.UseVisualStyleBackColor = false;
            this.bt_t_jog_n.Click += new System.EventHandler(this.bt_t_jog_n_Click);
            // 
            // bt_t_jog_p
            // 
            this.bt_t_jog_p.BackColor = System.Drawing.Color.Black;
            this.bt_t_jog_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_t_jog_p.BackgroundImage")));
            this.bt_t_jog_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_t_jog_p.FlatAppearance.BorderSize = 0;
            this.bt_t_jog_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_t_jog_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_t_jog_p.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_t_jog_p.Location = new System.Drawing.Point(652, 84);
            this.bt_t_jog_p.Name = "bt_t_jog_p";
            this.bt_t_jog_p.Size = new System.Drawing.Size(35, 23);
            this.bt_t_jog_p.TabIndex = 132;
            this.bt_t_jog_p.Text = "T+";
            this.bt_t_jog_p.UseVisualStyleBackColor = false;
            this.bt_t_jog_p.Click += new System.EventHandler(this.bt_t_jog_p_Click);
            // 
            // bt_y_jog_n
            // 
            this.bt_y_jog_n.BackColor = System.Drawing.Color.Black;
            this.bt_y_jog_n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_y_jog_n.BackgroundImage")));
            this.bt_y_jog_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_y_jog_n.FlatAppearance.BorderSize = 0;
            this.bt_y_jog_n.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_y_jog_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_y_jog_n.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_y_jog_n.Location = new System.Drawing.Point(559, 59);
            this.bt_y_jog_n.Name = "bt_y_jog_n";
            this.bt_y_jog_n.Size = new System.Drawing.Size(35, 23);
            this.bt_y_jog_n.TabIndex = 134;
            this.bt_y_jog_n.Text = "Y-";
            this.bt_y_jog_n.UseVisualStyleBackColor = false;
            this.bt_y_jog_n.Click += new System.EventHandler(this.bt_y_jog_n_Click);
            // 
            // text_loc_t
            // 
            this.text_loc_t.BackColor = System.Drawing.Color.Black;
            this.text_loc_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_loc_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loc_t.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_loc_t.ForeColor = System.Drawing.Color.White;
            this.text_loc_t.Location = new System.Drawing.Point(480, 56);
            this.text_loc_t.Name = "text_loc_t";
            this.text_loc_t.ReadOnly = true;
            this.text_loc_t.Size = new System.Drawing.Size(71, 22);
            this.text_loc_t.TabIndex = 139;
            this.text_loc_t.Text = "0";
            this.text_loc_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_loc_x
            // 
            this.text_loc_x.BackColor = System.Drawing.Color.Black;
            this.text_loc_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_loc_x.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_loc_x.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_loc_x.ForeColor = System.Drawing.Color.White;
            this.text_loc_x.Location = new System.Drawing.Point(480, 10);
            this.text_loc_x.Name = "text_loc_x";
            this.text_loc_x.ReadOnly = true;
            this.text_loc_x.Size = new System.Drawing.Size(71, 22);
            this.text_loc_x.TabIndex = 138;
            this.text_loc_x.Text = "0";
            this.text_loc_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_all_home
            // 
            this.bt_all_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_all_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_all_home.BackgroundImage")));
            this.bt_all_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_all_home.FlatAppearance.BorderSize = 0;
            this.bt_all_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_all_home.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_all_home.ForeColor = System.Drawing.Color.Black;
            this.bt_all_home.Location = new System.Drawing.Point(695, 12);
            this.bt_all_home.Name = "bt_all_home";
            this.bt_all_home.Size = new System.Drawing.Size(60, 22);
            this.bt_all_home.TabIndex = 161;
            this.bt_all_home.Text = "All";
            this.bt_all_home.UseVisualStyleBackColor = false;
            this.bt_all_home.Click += new System.EventHandler(this.bt_all_home_Click);
            // 
            // bt_y_home
            // 
            this.bt_y_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_y_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_y_home.BackgroundImage")));
            this.bt_y_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_y_home.FlatAppearance.BorderSize = 0;
            this.bt_y_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_y_home.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_y_home.ForeColor = System.Drawing.Color.Black;
            this.bt_y_home.Location = new System.Drawing.Point(695, 60);
            this.bt_y_home.Name = "bt_y_home";
            this.bt_y_home.Size = new System.Drawing.Size(60, 22);
            this.bt_y_home.TabIndex = 128;
            this.bt_y_home.Text = "Y-Home";
            this.bt_y_home.UseVisualStyleBackColor = false;
            this.bt_y_home.Click += new System.EventHandler(this.bt_y_home_Click);
            // 
            // bt_all_center
            // 
            this.bt_all_center.BackColor = System.Drawing.Color.Black;
            this.bt_all_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_all_center.BackgroundImage")));
            this.bt_all_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_all_center.FlatAppearance.BorderSize = 0;
            this.bt_all_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_all_center.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_all_center.ForeColor = System.Drawing.Color.Black;
            this.bt_all_center.Location = new System.Drawing.Point(756, 12);
            this.bt_all_center.Name = "bt_all_center";
            this.bt_all_center.Size = new System.Drawing.Size(60, 22);
            this.bt_all_center.TabIndex = 160;
            this.bt_all_center.Text = "All";
            this.bt_all_center.UseVisualStyleBackColor = false;
            this.bt_all_center.Click += new System.EventHandler(this.bt_all_center_Click);
            // 
            // bt_x_home
            // 
            this.bt_x_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_x_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_x_home.BackgroundImage")));
            this.bt_x_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_x_home.FlatAppearance.BorderSize = 0;
            this.bt_x_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_x_home.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_x_home.ForeColor = System.Drawing.Color.Black;
            this.bt_x_home.Location = new System.Drawing.Point(695, 36);
            this.bt_x_home.Name = "bt_x_home";
            this.bt_x_home.Size = new System.Drawing.Size(60, 22);
            this.bt_x_home.TabIndex = 127;
            this.bt_x_home.Text = "X-Home";
            this.bt_x_home.UseVisualStyleBackColor = false;
            this.bt_x_home.Click += new System.EventHandler(this.bt_x_home_Click);
            // 
            // bt_t_home
            // 
            this.bt_t_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_t_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_t_home.BackgroundImage")));
            this.bt_t_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_t_home.FlatAppearance.BorderSize = 0;
            this.bt_t_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_t_home.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_t_home.ForeColor = System.Drawing.Color.Black;
            this.bt_t_home.Location = new System.Drawing.Point(695, 84);
            this.bt_t_home.Name = "bt_t_home";
            this.bt_t_home.Size = new System.Drawing.Size(60, 22);
            this.bt_t_home.TabIndex = 129;
            this.bt_t_home.Text = "T-Home";
            this.bt_t_home.UseVisualStyleBackColor = false;
            this.bt_t_home.Click += new System.EventHandler(this.bt_t_home_Click);
            // 
            // text_os_dx
            // 
            this.text_os_dx.BackColor = System.Drawing.Color.Black;
            this.text_os_dx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_os_dx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_os_dx.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_os_dx.ForeColor = System.Drawing.Color.White;
            this.text_os_dx.Location = new System.Drawing.Point(918, 10);
            this.text_os_dx.Name = "text_os_dx";
            this.text_os_dx.ReadOnly = true;
            this.text_os_dx.Size = new System.Drawing.Size(38, 22);
            this.text_os_dx.TabIndex = 149;
            this.text_os_dx.Text = "0";
            this.text_os_dx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // by_stage_center_save
            // 
            this.by_stage_center_save.BackColor = System.Drawing.Color.Black;
            this.by_stage_center_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("by_stage_center_save.BackgroundImage")));
            this.by_stage_center_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.by_stage_center_save.FlatAppearance.BorderSize = 0;
            this.by_stage_center_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.by_stage_center_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.by_stage_center_save.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_stage_center_save.Location = new System.Drawing.Point(480, 80);
            this.by_stage_center_save.Name = "by_stage_center_save";
            this.by_stage_center_save.Size = new System.Drawing.Size(72, 27);
            this.by_stage_center_save.TabIndex = 141;
            this.by_stage_center_save.Text = "center save";
            this.by_stage_center_save.UseVisualStyleBackColor = false;
            this.by_stage_center_save.Click += new System.EventHandler(this.by_stage_center_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(433, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 153;
            this.label10.Text = "X Pos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_autoalign
            // 
            this.bt_autoalign.BackColor = System.Drawing.Color.Black;
            this.bt_autoalign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_autoalign.BackgroundImage")));
            this.bt_autoalign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_autoalign.FlatAppearance.BorderSize = 0;
            this.bt_autoalign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_autoalign.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_autoalign.Location = new System.Drawing.Point(894, 80);
            this.bt_autoalign.Name = "bt_autoalign";
            this.bt_autoalign.Size = new System.Drawing.Size(115, 27);
            this.bt_autoalign.TabIndex = 152;
            this.bt_autoalign.Text = "Align > Stage";
            this.bt_autoalign.UseVisualStyleBackColor = false;
            this.bt_autoalign.Click += new System.EventHandler(this.bt_autoalign_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(433, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 154;
            this.label11.Text = "Y Pos";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_led_save
            // 
            this.bt_led_save.BackColor = System.Drawing.Color.Black;
            this.bt_led_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_led_save.BackgroundImage")));
            this.bt_led_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_led_save.FlatAppearance.BorderSize = 0;
            this.bt_led_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_led_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_led_save.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_led_save.Location = new System.Drawing.Point(385, 8);
            this.bt_led_save.Name = "bt_led_save";
            this.bt_led_save.Size = new System.Drawing.Size(41, 99);
            this.bt_led_save.TabIndex = 122;
            this.bt_led_save.Text = "LED\rSAVE";
            this.bt_led_save.UseVisualStyleBackColor = false;
            this.bt_led_save.Click += new System.EventHandler(this.bt_led_save_Click);
            // 
            // text_os_dy
            // 
            this.text_os_dy.BackColor = System.Drawing.Color.Black;
            this.text_os_dy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_os_dy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_os_dy.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_os_dy.ForeColor = System.Drawing.Color.White;
            this.text_os_dy.Location = new System.Drawing.Point(918, 33);
            this.text_os_dy.Name = "text_os_dy";
            this.text_os_dy.ReadOnly = true;
            this.text_os_dy.Size = new System.Drawing.Size(38, 22);
            this.text_os_dy.TabIndex = 151;
            this.text_os_dy.Text = "0";
            this.text_os_dy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_t_center
            // 
            this.bt_t_center.BackColor = System.Drawing.Color.Black;
            this.bt_t_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_t_center.BackgroundImage")));
            this.bt_t_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_t_center.FlatAppearance.BorderSize = 0;
            this.bt_t_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_t_center.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_t_center.ForeColor = System.Drawing.Color.Black;
            this.bt_t_center.Location = new System.Drawing.Point(756, 84);
            this.bt_t_center.Name = "bt_t_center";
            this.bt_t_center.Size = new System.Drawing.Size(60, 22);
            this.bt_t_center.TabIndex = 126;
            this.bt_t_center.Text = "T-Center";
            this.bt_t_center.UseVisualStyleBackColor = false;
            this.bt_t_center.Click += new System.EventHandler(this.bt_t_center_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(433, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 155;
            this.label12.Text = "T Pos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_align_est
            // 
            this.bt_align_est.BackColor = System.Drawing.Color.Black;
            this.bt_align_est.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_align_est.BackgroundImage")));
            this.bt_align_est.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_align_est.FlatAppearance.BorderSize = 0;
            this.bt_align_est.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_align_est.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_align_est.Location = new System.Drawing.Point(957, 10);
            this.bt_align_est.Name = "bt_align_est";
            this.bt_align_est.Size = new System.Drawing.Size(52, 68);
            this.bt_align_est.TabIndex = 145;
            this.bt_align_est.Text = "Only\r\nAlign\r\nMatch";
            this.bt_align_est.UseVisualStyleBackColor = false;
            this.bt_align_est.Click += new System.EventHandler(this.bt_align_est_Click);
            // 
            // text_os_dt
            // 
            this.text_os_dt.BackColor = System.Drawing.Color.Black;
            this.text_os_dt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_os_dt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_os_dt.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_os_dt.ForeColor = System.Drawing.Color.White;
            this.text_os_dt.Location = new System.Drawing.Point(918, 56);
            this.text_os_dt.Name = "text_os_dt";
            this.text_os_dt.ReadOnly = true;
            this.text_os_dt.Size = new System.Drawing.Size(38, 22);
            this.text_os_dt.TabIndex = 150;
            this.text_os_dt.Text = "0";
            this.text_os_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sen8
            // 
            this.text_sen8.BackColor = System.Drawing.Color.Black;
            this.text_sen8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen8.ForeColor = System.Drawing.Color.White;
            this.text_sen8.Location = new System.Drawing.Point(267, 85);
            this.text_sen8.Name = "text_sen8";
            this.text_sen8.ReadOnly = true;
            this.text_sen8.Size = new System.Drawing.Size(40, 23);
            this.text_sen8.TabIndex = 106;
            this.text_sen8.Text = "SEN8";
            this.text_sen8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_y_center
            // 
            this.bt_y_center.BackColor = System.Drawing.Color.Black;
            this.bt_y_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_y_center.BackgroundImage")));
            this.bt_y_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_y_center.FlatAppearance.BorderSize = 0;
            this.bt_y_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_y_center.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_y_center.ForeColor = System.Drawing.Color.Black;
            this.bt_y_center.Location = new System.Drawing.Point(756, 60);
            this.bt_y_center.Name = "bt_y_center";
            this.bt_y_center.Size = new System.Drawing.Size(60, 22);
            this.bt_y_center.TabIndex = 125;
            this.bt_y_center.Text = "Y-Center";
            this.bt_y_center.UseVisualStyleBackColor = false;
            this.bt_y_center.Click += new System.EventHandler(this.bt_y_center_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(891, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 146;
            this.label9.Text = "ΔX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_sol1
            // 
            this.bt_sol1.BackColor = System.Drawing.Color.Black;
            this.bt_sol1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol1.BackgroundImage")));
            this.bt_sol1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol1.FlatAppearance.BorderSize = 0;
            this.bt_sol1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol1.Location = new System.Drawing.Point(2, 10);
            this.bt_sol1.Name = "bt_sol1";
            this.bt_sol1.Size = new System.Drawing.Size(45, 48);
            this.bt_sol1.TabIndex = 0;
            this.bt_sol1.Text = "SOL1\r\nON";
            this.bt_sol1.UseVisualStyleBackColor = false;
            this.bt_sol1.Click += new System.EventHandler(this.bt_sol1_Click);
            // 
            // bt_x_center
            // 
            this.bt_x_center.BackColor = System.Drawing.Color.Black;
            this.bt_x_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_x_center.BackgroundImage")));
            this.bt_x_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_x_center.FlatAppearance.BorderSize = 0;
            this.bt_x_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_x_center.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_x_center.ForeColor = System.Drawing.Color.Black;
            this.bt_x_center.Location = new System.Drawing.Point(756, 36);
            this.bt_x_center.Name = "bt_x_center";
            this.bt_x_center.Size = new System.Drawing.Size(60, 22);
            this.bt_x_center.TabIndex = 124;
            this.bt_x_center.Text = "X-Center";
            this.bt_x_center.UseVisualStyleBackColor = false;
            this.bt_x_center.Click += new System.EventHandler(this.bt_x_center_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(891, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 21);
            this.label7.TabIndex = 147;
            this.label7.Text = "ΔY";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_sen7
            // 
            this.text_sen7.BackColor = System.Drawing.Color.Black;
            this.text_sen7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen7.ForeColor = System.Drawing.Color.White;
            this.text_sen7.Location = new System.Drawing.Point(267, 60);
            this.text_sen7.Name = "text_sen7";
            this.text_sen7.ReadOnly = true;
            this.text_sen7.Size = new System.Drawing.Size(40, 23);
            this.text_sen7.TabIndex = 105;
            this.text_sen7.Text = "SEN7";
            this.text_sen7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(891, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 148;
            this.label6.Text = "ΔT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_sol_all
            // 
            this.bt_sol_all.BackColor = System.Drawing.Color.Black;
            this.bt_sol_all.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol_all.BackgroundImage")));
            this.bt_sol_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol_all.FlatAppearance.BorderSize = 0;
            this.bt_sol_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_sol_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol_all.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol_all.Location = new System.Drawing.Point(187, 10);
            this.bt_sol_all.Name = "bt_sol_all";
            this.bt_sol_all.Size = new System.Drawing.Size(38, 98);
            this.bt_sol_all.TabIndex = 14;
            this.bt_sol_all.Text = "SOL OFF";
            this.bt_sol_all.UseVisualStyleBackColor = false;
            this.bt_sol_all.Click += new System.EventHandler(this.bt_sol_all_Click);
            // 
            // bt_sol2
            // 
            this.bt_sol2.BackColor = System.Drawing.Color.Black;
            this.bt_sol2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol2.BackgroundImage")));
            this.bt_sol2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol2.FlatAppearance.BorderSize = 0;
            this.bt_sol2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol2.Location = new System.Drawing.Point(48, 10);
            this.bt_sol2.Name = "bt_sol2";
            this.bt_sol2.Size = new System.Drawing.Size(45, 48);
            this.bt_sol2.TabIndex = 2;
            this.bt_sol2.Text = "SOL2\r\nON";
            this.bt_sol2.UseVisualStyleBackColor = false;
            this.bt_sol2.Click += new System.EventHandler(this.bt_sol2_Click);
            // 
            // text_sen6
            // 
            this.text_sen6.BackColor = System.Drawing.Color.Black;
            this.text_sen6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen6.ForeColor = System.Drawing.Color.White;
            this.text_sen6.Location = new System.Drawing.Point(267, 35);
            this.text_sen6.Name = "text_sen6";
            this.text_sen6.ReadOnly = true;
            this.text_sen6.Size = new System.Drawing.Size(40, 23);
            this.text_sen6.TabIndex = 104;
            this.text_sen6.Text = "SEN6";
            this.text_sen6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_sol3
            // 
            this.bt_sol3.BackColor = System.Drawing.Color.Black;
            this.bt_sol3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol3.BackgroundImage")));
            this.bt_sol3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol3.FlatAppearance.BorderSize = 0;
            this.bt_sol3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol3.Location = new System.Drawing.Point(94, 10);
            this.bt_sol3.Name = "bt_sol3";
            this.bt_sol3.Size = new System.Drawing.Size(45, 48);
            this.bt_sol3.TabIndex = 4;
            this.bt_sol3.Text = "SOL3\r\nON";
            this.bt_sol3.UseVisualStyleBackColor = false;
            this.bt_sol3.Click += new System.EventHandler(this.bt_sol3_Click);
            // 
            // text_sen5
            // 
            this.text_sen5.BackColor = System.Drawing.Color.Black;
            this.text_sen5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen5.ForeColor = System.Drawing.Color.White;
            this.text_sen5.Location = new System.Drawing.Point(267, 10);
            this.text_sen5.Name = "text_sen5";
            this.text_sen5.ReadOnly = true;
            this.text_sen5.Size = new System.Drawing.Size(40, 23);
            this.text_sen5.TabIndex = 103;
            this.text_sen5.Text = "SEN5";
            this.text_sen5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_sol4
            // 
            this.bt_sol4.BackColor = System.Drawing.Color.Black;
            this.bt_sol4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol4.BackgroundImage")));
            this.bt_sol4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol4.FlatAppearance.BorderSize = 0;
            this.bt_sol4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol4.Location = new System.Drawing.Point(140, 10);
            this.bt_sol4.Name = "bt_sol4";
            this.bt_sol4.Size = new System.Drawing.Size(45, 48);
            this.bt_sol4.TabIndex = 6;
            this.bt_sol4.Text = "SOL4\r\nON";
            this.bt_sol4.UseVisualStyleBackColor = false;
            this.bt_sol4.Click += new System.EventHandler(this.bt_sol4_Click);
            // 
            // text_sen4
            // 
            this.text_sen4.BackColor = System.Drawing.Color.Black;
            this.text_sen4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen4.ForeColor = System.Drawing.Color.White;
            this.text_sen4.Location = new System.Drawing.Point(226, 85);
            this.text_sen4.Name = "text_sen4";
            this.text_sen4.ReadOnly = true;
            this.text_sen4.Size = new System.Drawing.Size(40, 23);
            this.text_sen4.TabIndex = 102;
            this.text_sen4.Text = "SEN4";
            this.text_sen4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_sol5
            // 
            this.bt_sol5.BackColor = System.Drawing.Color.Black;
            this.bt_sol5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol5.BackgroundImage")));
            this.bt_sol5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol5.FlatAppearance.BorderSize = 0;
            this.bt_sol5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol5.Location = new System.Drawing.Point(2, 60);
            this.bt_sol5.Name = "bt_sol5";
            this.bt_sol5.Size = new System.Drawing.Size(45, 48);
            this.bt_sol5.TabIndex = 8;
            this.bt_sol5.Text = "SOL5\r\nON";
            this.bt_sol5.UseVisualStyleBackColor = false;
            this.bt_sol5.Click += new System.EventHandler(this.bt_sol5_Click);
            // 
            // text_sen3
            // 
            this.text_sen3.BackColor = System.Drawing.Color.Black;
            this.text_sen3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen3.ForeColor = System.Drawing.Color.White;
            this.text_sen3.Location = new System.Drawing.Point(226, 60);
            this.text_sen3.Name = "text_sen3";
            this.text_sen3.ReadOnly = true;
            this.text_sen3.Size = new System.Drawing.Size(40, 23);
            this.text_sen3.TabIndex = 101;
            this.text_sen3.Text = "SEN3";
            this.text_sen3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_sol6
            // 
            this.bt_sol6.BackColor = System.Drawing.Color.Black;
            this.bt_sol6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol6.BackgroundImage")));
            this.bt_sol6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol6.FlatAppearance.BorderSize = 0;
            this.bt_sol6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol6.Location = new System.Drawing.Point(48, 60);
            this.bt_sol6.Name = "bt_sol6";
            this.bt_sol6.Size = new System.Drawing.Size(45, 48);
            this.bt_sol6.TabIndex = 10;
            this.bt_sol6.Text = "SOL6\r\nON";
            this.bt_sol6.UseVisualStyleBackColor = false;
            this.bt_sol6.Click += new System.EventHandler(this.bt_sol6_Click);
            // 
            // text_sen2
            // 
            this.text_sen2.BackColor = System.Drawing.Color.Black;
            this.text_sen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen2.ForeColor = System.Drawing.Color.White;
            this.text_sen2.Location = new System.Drawing.Point(226, 35);
            this.text_sen2.Name = "text_sen2";
            this.text_sen2.ReadOnly = true;
            this.text_sen2.Size = new System.Drawing.Size(40, 23);
            this.text_sen2.TabIndex = 100;
            this.text_sen2.Text = "SEN2";
            this.text_sen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sen1
            // 
            this.text_sen1.BackColor = System.Drawing.Color.Black;
            this.text_sen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_sen1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sen1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sen1.ForeColor = System.Drawing.Color.White;
            this.text_sen1.Location = new System.Drawing.Point(226, 10);
            this.text_sen1.Name = "text_sen1";
            this.text_sen1.ReadOnly = true;
            this.text_sen1.Size = new System.Drawing.Size(40, 23);
            this.text_sen1.TabIndex = 99;
            this.text_sen1.Text = "SEN1";
            this.text_sen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_sol7
            // 
            this.bt_sol7.BackColor = System.Drawing.Color.Black;
            this.bt_sol7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol7.BackgroundImage")));
            this.bt_sol7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol7.FlatAppearance.BorderSize = 0;
            this.bt_sol7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol7.Location = new System.Drawing.Point(94, 60);
            this.bt_sol7.Name = "bt_sol7";
            this.bt_sol7.Size = new System.Drawing.Size(45, 48);
            this.bt_sol7.TabIndex = 12;
            this.bt_sol7.Text = "SOL7\r\nON";
            this.bt_sol7.UseVisualStyleBackColor = false;
            this.bt_sol7.Click += new System.EventHandler(this.bt_sol7_Click);
            // 
            // bt_sol8
            // 
            this.bt_sol8.BackColor = System.Drawing.Color.Black;
            this.bt_sol8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sol8.BackgroundImage")));
            this.bt_sol8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sol8.FlatAppearance.BorderSize = 0;
            this.bt_sol8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sol8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sol8.Location = new System.Drawing.Point(140, 60);
            this.bt_sol8.Name = "bt_sol8";
            this.bt_sol8.Size = new System.Drawing.Size(45, 48);
            this.bt_sol8.TabIndex = 16;
            this.bt_sol8.Text = "SOL8\r\nON";
            this.bt_sol8.UseVisualStyleBackColor = false;
            this.bt_sol8.Click += new System.EventHandler(this.bt_sol8_Click);
            // 
            // tabSpecview
            // 
            this.tabSpecview.BackColor = System.Drawing.Color.Black;
            this.tabSpecview.Controls.Add(this.bt_spec_open);
            this.tabSpecview.Controls.Add(this.text_sv_view_mode);
            this.tabSpecview.Controls.Add(this.text_sv_row9_9);
            this.tabSpecview.Controls.Add(this.text_sv_row9_10);
            this.tabSpecview.Controls.Add(this.text_sv_row9_5);
            this.tabSpecview.Controls.Add(this.text_sv_row9_6);
            this.tabSpecview.Controls.Add(this.text_sv_row9_7);
            this.tabSpecview.Controls.Add(this.text_sv_row9_8);
            this.tabSpecview.Controls.Add(this.text_sv_row9);
            this.tabSpecview.Controls.Add(this.text_sv_row9_1);
            this.tabSpecview.Controls.Add(this.text_sv_row9_2);
            this.tabSpecview.Controls.Add(this.text_sv_row9_3);
            this.tabSpecview.Controls.Add(this.text_sv_row9_4);
            this.tabSpecview.Controls.Add(this.text_sv_row8_9);
            this.tabSpecview.Controls.Add(this.text_sv_row8_10);
            this.tabSpecview.Controls.Add(this.text_sv_row4);
            this.tabSpecview.Controls.Add(this.text_sv_row8_5);
            this.tabSpecview.Controls.Add(this.text_sv_no_4);
            this.tabSpecview.Controls.Add(this.text_sv_row8_6);
            this.tabSpecview.Controls.Add(this.text_sv_no_3);
            this.tabSpecview.Controls.Add(this.text_sv_row8_7);
            this.tabSpecview.Controls.Add(this.text_sv_no_2);
            this.tabSpecview.Controls.Add(this.text_sv_row8_8);
            this.tabSpecview.Controls.Add(this.text_sv_no_1);
            this.tabSpecview.Controls.Add(this.text_sv_row8);
            this.tabSpecview.Controls.Add(this.text_sv_no);
            this.tabSpecview.Controls.Add(this.text_sv_row8_1);
            this.tabSpecview.Controls.Add(this.text_sv_no_8);
            this.tabSpecview.Controls.Add(this.text_sv_row8_2);
            this.tabSpecview.Controls.Add(this.text_sv_no_7);
            this.tabSpecview.Controls.Add(this.text_sv_row8_3);
            this.tabSpecview.Controls.Add(this.text_sv_no_6);
            this.tabSpecview.Controls.Add(this.text_sv_row8_4);
            this.tabSpecview.Controls.Add(this.text_sv_no_5);
            this.tabSpecview.Controls.Add(this.text_sv_row7_9);
            this.tabSpecview.Controls.Add(this.text_sv_no_10);
            this.tabSpecview.Controls.Add(this.text_sv_row7_10);
            this.tabSpecview.Controls.Add(this.text_sv_no_9);
            this.tabSpecview.Controls.Add(this.text_sv_row7_5);
            this.tabSpecview.Controls.Add(this.text_sv_row1_4);
            this.tabSpecview.Controls.Add(this.text_sv_row7_6);
            this.tabSpecview.Controls.Add(this.text_sv_row1_3);
            this.tabSpecview.Controls.Add(this.text_sv_row7_7);
            this.tabSpecview.Controls.Add(this.text_sv_row1_2);
            this.tabSpecview.Controls.Add(this.text_sv_row7_8);
            this.tabSpecview.Controls.Add(this.text_sv_row1_1);
            this.tabSpecview.Controls.Add(this.text_sv_row7);
            this.tabSpecview.Controls.Add(this.text_sv_row1);
            this.tabSpecview.Controls.Add(this.text_sv_row7_1);
            this.tabSpecview.Controls.Add(this.text_sv_row1_8);
            this.tabSpecview.Controls.Add(this.text_sv_row7_2);
            this.tabSpecview.Controls.Add(this.text_sv_row1_7);
            this.tabSpecview.Controls.Add(this.text_sv_row7_3);
            this.tabSpecview.Controls.Add(this.text_sv_row1_6);
            this.tabSpecview.Controls.Add(this.text_sv_row7_4);
            this.tabSpecview.Controls.Add(this.text_sv_row1_5);
            this.tabSpecview.Controls.Add(this.text_sv_row6_9);
            this.tabSpecview.Controls.Add(this.text_sv_row1_10);
            this.tabSpecview.Controls.Add(this.text_sv_row6_10);
            this.tabSpecview.Controls.Add(this.text_sv_row1_9);
            this.tabSpecview.Controls.Add(this.text_sv_row6_5);
            this.tabSpecview.Controls.Add(this.text_sv_row2_4);
            this.tabSpecview.Controls.Add(this.text_sv_row6_6);
            this.tabSpecview.Controls.Add(this.text_sv_row2_3);
            this.tabSpecview.Controls.Add(this.text_sv_row6_7);
            this.tabSpecview.Controls.Add(this.text_sv_row2_2);
            this.tabSpecview.Controls.Add(this.text_sv_row6_8);
            this.tabSpecview.Controls.Add(this.text_sv_row2_1);
            this.tabSpecview.Controls.Add(this.text_sv_row6);
            this.tabSpecview.Controls.Add(this.text_sv_row2);
            this.tabSpecview.Controls.Add(this.text_sv_row6_1);
            this.tabSpecview.Controls.Add(this.text_sv_row2_8);
            this.tabSpecview.Controls.Add(this.text_sv_row6_2);
            this.tabSpecview.Controls.Add(this.text_sv_row2_7);
            this.tabSpecview.Controls.Add(this.text_sv_row6_3);
            this.tabSpecview.Controls.Add(this.text_sv_row2_6);
            this.tabSpecview.Controls.Add(this.text_sv_row6_4);
            this.tabSpecview.Controls.Add(this.text_sv_row2_5);
            this.tabSpecview.Controls.Add(this.text_sv_row5_9);
            this.tabSpecview.Controls.Add(this.text_sv_row2_10);
            this.tabSpecview.Controls.Add(this.text_sv_row5_10);
            this.tabSpecview.Controls.Add(this.text_sv_row2_9);
            this.tabSpecview.Controls.Add(this.text_sv_row5_5);
            this.tabSpecview.Controls.Add(this.text_sv_row3_4);
            this.tabSpecview.Controls.Add(this.text_sv_row5_6);
            this.tabSpecview.Controls.Add(this.text_sv_row3_3);
            this.tabSpecview.Controls.Add(this.text_sv_row5_7);
            this.tabSpecview.Controls.Add(this.text_sv_row3_2);
            this.tabSpecview.Controls.Add(this.text_sv_row5_8);
            this.tabSpecview.Controls.Add(this.text_sv_row3_1);
            this.tabSpecview.Controls.Add(this.text_sv_row5);
            this.tabSpecview.Controls.Add(this.text_sv_row3);
            this.tabSpecview.Controls.Add(this.text_sv_row5_1);
            this.tabSpecview.Controls.Add(this.text_sv_row3_8);
            this.tabSpecview.Controls.Add(this.text_sv_row5_2);
            this.tabSpecview.Controls.Add(this.text_sv_row3_7);
            this.tabSpecview.Controls.Add(this.text_sv_row5_3);
            this.tabSpecview.Controls.Add(this.text_sv_row3_6);
            this.tabSpecview.Controls.Add(this.text_sv_row5_4);
            this.tabSpecview.Controls.Add(this.text_sv_row3_5);
            this.tabSpecview.Controls.Add(this.text_sv_row4_9);
            this.tabSpecview.Controls.Add(this.text_sv_row3_10);
            this.tabSpecview.Controls.Add(this.text_sv_row4_10);
            this.tabSpecview.Controls.Add(this.text_sv_row3_9);
            this.tabSpecview.Controls.Add(this.text_sv_row4_5);
            this.tabSpecview.Controls.Add(this.text_sv_row4_4);
            this.tabSpecview.Controls.Add(this.text_sv_row4_6);
            this.tabSpecview.Controls.Add(this.text_sv_row4_3);
            this.tabSpecview.Controls.Add(this.text_sv_row4_7);
            this.tabSpecview.Controls.Add(this.text_sv_row4_2);
            this.tabSpecview.Controls.Add(this.text_sv_row4_8);
            this.tabSpecview.Controls.Add(this.text_sv_row4_1);
            this.tabSpecview.Controls.Add(this.button_sv_tp);
            this.tabSpecview.Controls.Add(this.button_sv_op);
            this.tabSpecview.Controls.Add(this.button_sv_shb);
            this.tabSpecview.Controls.Add(this.button_sv_she);
            this.tabSpecview.Controls.Add(this.button_sv_pt);
            this.tabSpecview.Controls.Add(this.button_sv_fn);
            this.tabSpecview.Controls.Add(this.button_sv_pre);
            this.tabSpecview.Controls.Add(this.button_sv_mode1);
            this.tabSpecview.Controls.Add(this.button_sv_mode2);
            this.tabSpecview.Controls.Add(this.button_sv_mode3);
            this.tabSpecview.Controls.Add(this.button_sv_mode4);
            this.tabSpecview.Controls.Add(this.button_sv_next);
            this.tabSpecview.Location = new System.Drawing.Point(4, 24);
            this.tabSpecview.Name = "tabSpecview";
            this.tabSpecview.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecview.Size = new System.Drawing.Size(1016, 471);
            this.tabSpecview.TabIndex = 4;
            this.tabSpecview.Text = "Spec View";
            // 
            // bt_spec_open
            // 
            this.bt_spec_open.BackColor = System.Drawing.Color.Black;
            this.bt_spec_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_spec_open.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_spec_open.ForeColor = System.Drawing.Color.Lavender;
            this.bt_spec_open.Location = new System.Drawing.Point(1, 133);
            this.bt_spec_open.Name = "bt_spec_open";
            this.bt_spec_open.Size = new System.Drawing.Size(51, 33);
            this.bt_spec_open.TabIndex = 189;
            this.bt_spec_open.Text = "Open";
            this.bt_spec_open.UseVisualStyleBackColor = false;
            this.bt_spec_open.Click += new System.EventHandler(this.bt_spec_open_Click);
            // 
            // text_sv_view_mode
            // 
            this.text_sv_view_mode.BackColor = System.Drawing.Color.DimGray;
            this.text_sv_view_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_view_mode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_view_mode.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_view_mode.ForeColor = System.Drawing.Color.White;
            this.text_sv_view_mode.Location = new System.Drawing.Point(1, 437);
            this.text_sv_view_mode.Name = "text_sv_view_mode";
            this.text_sv_view_mode.ReadOnly = true;
            this.text_sv_view_mode.Size = new System.Drawing.Size(1014, 32);
            this.text_sv_view_mode.TabIndex = 187;
            this.text_sv_view_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_9
            // 
            this.text_sv_row9_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_9.Location = new System.Drawing.Point(965, 383);
            this.text_sv_row9_9.Name = "text_sv_row9_9";
            this.text_sv_row9_9.ReadOnly = true;
            this.text_sv_row9_9.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_9.TabIndex = 185;
            this.text_sv_row9_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_10
            // 
            this.text_sv_row9_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_10.Location = new System.Drawing.Point(965, 410);
            this.text_sv_row9_10.Name = "text_sv_row9_10";
            this.text_sv_row9_10.ReadOnly = true;
            this.text_sv_row9_10.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_10.TabIndex = 186;
            this.text_sv_row9_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_5
            // 
            this.text_sv_row9_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_5.Location = new System.Drawing.Point(965, 275);
            this.text_sv_row9_5.Name = "text_sv_row9_5";
            this.text_sv_row9_5.ReadOnly = true;
            this.text_sv_row9_5.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_5.TabIndex = 181;
            this.text_sv_row9_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_6
            // 
            this.text_sv_row9_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_6.Location = new System.Drawing.Point(965, 302);
            this.text_sv_row9_6.Name = "text_sv_row9_6";
            this.text_sv_row9_6.ReadOnly = true;
            this.text_sv_row9_6.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_6.TabIndex = 182;
            this.text_sv_row9_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_7
            // 
            this.text_sv_row9_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_7.Location = new System.Drawing.Point(965, 329);
            this.text_sv_row9_7.Name = "text_sv_row9_7";
            this.text_sv_row9_7.ReadOnly = true;
            this.text_sv_row9_7.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_7.TabIndex = 183;
            this.text_sv_row9_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_8
            // 
            this.text_sv_row9_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_8.Location = new System.Drawing.Point(965, 356);
            this.text_sv_row9_8.Name = "text_sv_row9_8";
            this.text_sv_row9_8.ReadOnly = true;
            this.text_sv_row9_8.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_8.TabIndex = 184;
            this.text_sv_row9_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9
            // 
            this.text_sv_row9.BackColor = System.Drawing.Color.Black;
            this.text_sv_row9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9.ForeColor = System.Drawing.Color.White;
            this.text_sv_row9.Location = new System.Drawing.Point(965, 133);
            this.text_sv_row9.Name = "text_sv_row9";
            this.text_sv_row9.ReadOnly = true;
            this.text_sv_row9.Size = new System.Drawing.Size(50, 33);
            this.text_sv_row9.TabIndex = 176;
            this.text_sv_row9.Text = "-";
            this.text_sv_row9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_1
            // 
            this.text_sv_row9_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_1.Location = new System.Drawing.Point(965, 167);
            this.text_sv_row9_1.Name = "text_sv_row9_1";
            this.text_sv_row9_1.ReadOnly = true;
            this.text_sv_row9_1.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_1.TabIndex = 177;
            this.text_sv_row9_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_2
            // 
            this.text_sv_row9_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_2.Location = new System.Drawing.Point(965, 194);
            this.text_sv_row9_2.Name = "text_sv_row9_2";
            this.text_sv_row9_2.ReadOnly = true;
            this.text_sv_row9_2.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_2.TabIndex = 178;
            this.text_sv_row9_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_3
            // 
            this.text_sv_row9_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_3.Location = new System.Drawing.Point(965, 221);
            this.text_sv_row9_3.Name = "text_sv_row9_3";
            this.text_sv_row9_3.ReadOnly = true;
            this.text_sv_row9_3.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_3.TabIndex = 179;
            this.text_sv_row9_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row9_4
            // 
            this.text_sv_row9_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row9_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row9_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row9_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row9_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row9_4.Location = new System.Drawing.Point(965, 248);
            this.text_sv_row9_4.Name = "text_sv_row9_4";
            this.text_sv_row9_4.ReadOnly = true;
            this.text_sv_row9_4.Size = new System.Drawing.Size(50, 26);
            this.text_sv_row9_4.TabIndex = 180;
            this.text_sv_row9_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_9
            // 
            this.text_sv_row8_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_9.Location = new System.Drawing.Point(910, 383);
            this.text_sv_row8_9.Name = "text_sv_row8_9";
            this.text_sv_row8_9.ReadOnly = true;
            this.text_sv_row8_9.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_9.TabIndex = 174;
            this.text_sv_row8_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_10
            // 
            this.text_sv_row8_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_10.Location = new System.Drawing.Point(910, 410);
            this.text_sv_row8_10.Name = "text_sv_row8_10";
            this.text_sv_row8_10.ReadOnly = true;
            this.text_sv_row8_10.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_10.TabIndex = 175;
            this.text_sv_row8_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4
            // 
            this.text_sv_row4.BackColor = System.Drawing.Color.Black;
            this.text_sv_row4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4.ForeColor = System.Drawing.Color.White;
            this.text_sv_row4.Location = new System.Drawing.Point(450, 133);
            this.text_sv_row4.Name = "text_sv_row4";
            this.text_sv_row4.ReadOnly = true;
            this.text_sv_row4.Size = new System.Drawing.Size(114, 33);
            this.text_sv_row4.TabIndex = 121;
            this.text_sv_row4.Text = "-";
            this.text_sv_row4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_5
            // 
            this.text_sv_row8_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_5.Location = new System.Drawing.Point(910, 275);
            this.text_sv_row8_5.Name = "text_sv_row8_5";
            this.text_sv_row8_5.ReadOnly = true;
            this.text_sv_row8_5.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_5.TabIndex = 170;
            this.text_sv_row8_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_4
            // 
            this.text_sv_no_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_4.Location = new System.Drawing.Point(1, 248);
            this.text_sv_no_4.Name = "text_sv_no_4";
            this.text_sv_no_4.ReadOnly = true;
            this.text_sv_no_4.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_4.TabIndex = 50;
            this.text_sv_no_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_6
            // 
            this.text_sv_row8_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_6.Location = new System.Drawing.Point(910, 302);
            this.text_sv_row8_6.Name = "text_sv_row8_6";
            this.text_sv_row8_6.ReadOnly = true;
            this.text_sv_row8_6.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_6.TabIndex = 171;
            this.text_sv_row8_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_3
            // 
            this.text_sv_no_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_3.Location = new System.Drawing.Point(1, 221);
            this.text_sv_no_3.Name = "text_sv_no_3";
            this.text_sv_no_3.ReadOnly = true;
            this.text_sv_no_3.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_3.TabIndex = 48;
            this.text_sv_no_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_7
            // 
            this.text_sv_row8_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_7.Location = new System.Drawing.Point(910, 329);
            this.text_sv_row8_7.Name = "text_sv_row8_7";
            this.text_sv_row8_7.ReadOnly = true;
            this.text_sv_row8_7.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_7.TabIndex = 172;
            this.text_sv_row8_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_2
            // 
            this.text_sv_no_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_2.Location = new System.Drawing.Point(1, 194);
            this.text_sv_no_2.Name = "text_sv_no_2";
            this.text_sv_no_2.ReadOnly = true;
            this.text_sv_no_2.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_2.TabIndex = 46;
            this.text_sv_no_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_8
            // 
            this.text_sv_row8_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_8.Location = new System.Drawing.Point(910, 356);
            this.text_sv_row8_8.Name = "text_sv_row8_8";
            this.text_sv_row8_8.ReadOnly = true;
            this.text_sv_row8_8.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_8.TabIndex = 173;
            this.text_sv_row8_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_1
            // 
            this.text_sv_no_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_1.Location = new System.Drawing.Point(1, 167);
            this.text_sv_no_1.Name = "text_sv_no_1";
            this.text_sv_no_1.ReadOnly = true;
            this.text_sv_no_1.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_1.TabIndex = 44;
            this.text_sv_no_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8
            // 
            this.text_sv_row8.BackColor = System.Drawing.Color.Black;
            this.text_sv_row8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8.ForeColor = System.Drawing.Color.White;
            this.text_sv_row8.Location = new System.Drawing.Point(910, 133);
            this.text_sv_row8.Name = "text_sv_row8";
            this.text_sv_row8.ReadOnly = true;
            this.text_sv_row8.Size = new System.Drawing.Size(54, 33);
            this.text_sv_row8.TabIndex = 165;
            this.text_sv_row8.Text = "-";
            this.text_sv_row8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no
            // 
            this.text_sv_no.BackColor = System.Drawing.Color.Black;
            this.text_sv_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no.ForeColor = System.Drawing.Color.White;
            this.text_sv_no.Location = new System.Drawing.Point(1, 133);
            this.text_sv_no.Name = "text_sv_no";
            this.text_sv_no.ReadOnly = true;
            this.text_sv_no.Size = new System.Drawing.Size(51, 33);
            this.text_sv_no.TabIndex = 42;
            this.text_sv_no.Text = "-";
            this.text_sv_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_1
            // 
            this.text_sv_row8_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_1.Location = new System.Drawing.Point(910, 167);
            this.text_sv_row8_1.Name = "text_sv_row8_1";
            this.text_sv_row8_1.ReadOnly = true;
            this.text_sv_row8_1.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_1.TabIndex = 166;
            this.text_sv_row8_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_8
            // 
            this.text_sv_no_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_8.Location = new System.Drawing.Point(1, 356);
            this.text_sv_no_8.Name = "text_sv_no_8";
            this.text_sv_no_8.ReadOnly = true;
            this.text_sv_no_8.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_8.TabIndex = 58;
            this.text_sv_no_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_2
            // 
            this.text_sv_row8_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_2.Location = new System.Drawing.Point(910, 194);
            this.text_sv_row8_2.Name = "text_sv_row8_2";
            this.text_sv_row8_2.ReadOnly = true;
            this.text_sv_row8_2.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_2.TabIndex = 167;
            this.text_sv_row8_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_7
            // 
            this.text_sv_no_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_7.Location = new System.Drawing.Point(1, 329);
            this.text_sv_no_7.Name = "text_sv_no_7";
            this.text_sv_no_7.ReadOnly = true;
            this.text_sv_no_7.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_7.TabIndex = 56;
            this.text_sv_no_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_3
            // 
            this.text_sv_row8_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_3.Location = new System.Drawing.Point(910, 221);
            this.text_sv_row8_3.Name = "text_sv_row8_3";
            this.text_sv_row8_3.ReadOnly = true;
            this.text_sv_row8_3.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_3.TabIndex = 168;
            this.text_sv_row8_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_6
            // 
            this.text_sv_no_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_6.Location = new System.Drawing.Point(1, 302);
            this.text_sv_no_6.Name = "text_sv_no_6";
            this.text_sv_no_6.ReadOnly = true;
            this.text_sv_no_6.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_6.TabIndex = 54;
            this.text_sv_no_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row8_4
            // 
            this.text_sv_row8_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row8_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row8_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row8_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row8_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row8_4.Location = new System.Drawing.Point(910, 248);
            this.text_sv_row8_4.Name = "text_sv_row8_4";
            this.text_sv_row8_4.ReadOnly = true;
            this.text_sv_row8_4.Size = new System.Drawing.Size(54, 26);
            this.text_sv_row8_4.TabIndex = 169;
            this.text_sv_row8_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_5
            // 
            this.text_sv_no_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_5.Location = new System.Drawing.Point(1, 275);
            this.text_sv_no_5.Name = "text_sv_no_5";
            this.text_sv_no_5.ReadOnly = true;
            this.text_sv_no_5.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_5.TabIndex = 52;
            this.text_sv_no_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_9
            // 
            this.text_sv_row7_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_9.Location = new System.Drawing.Point(795, 383);
            this.text_sv_row7_9.Name = "text_sv_row7_9";
            this.text_sv_row7_9.ReadOnly = true;
            this.text_sv_row7_9.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_9.TabIndex = 163;
            this.text_sv_row7_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_10
            // 
            this.text_sv_no_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_10.Location = new System.Drawing.Point(1, 410);
            this.text_sv_no_10.Name = "text_sv_no_10";
            this.text_sv_no_10.ReadOnly = true;
            this.text_sv_no_10.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_10.TabIndex = 62;
            this.text_sv_no_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_10
            // 
            this.text_sv_row7_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_10.Location = new System.Drawing.Point(795, 410);
            this.text_sv_row7_10.Name = "text_sv_row7_10";
            this.text_sv_row7_10.ReadOnly = true;
            this.text_sv_row7_10.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_10.TabIndex = 164;
            this.text_sv_row7_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_no_9
            // 
            this.text_sv_no_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_no_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_no_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_no_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_no_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_no_9.Location = new System.Drawing.Point(1, 383);
            this.text_sv_no_9.Name = "text_sv_no_9";
            this.text_sv_no_9.ReadOnly = true;
            this.text_sv_no_9.Size = new System.Drawing.Size(51, 26);
            this.text_sv_no_9.TabIndex = 60;
            this.text_sv_no_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_5
            // 
            this.text_sv_row7_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_5.Location = new System.Drawing.Point(795, 275);
            this.text_sv_row7_5.Name = "text_sv_row7_5";
            this.text_sv_row7_5.ReadOnly = true;
            this.text_sv_row7_5.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_5.TabIndex = 159;
            this.text_sv_row7_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_4
            // 
            this.text_sv_row1_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_4.Location = new System.Drawing.Point(53, 248);
            this.text_sv_row1_4.Name = "text_sv_row1_4";
            this.text_sv_row1_4.ReadOnly = true;
            this.text_sv_row1_4.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_4.TabIndex = 92;
            this.text_sv_row1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_6
            // 
            this.text_sv_row7_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_6.Location = new System.Drawing.Point(795, 302);
            this.text_sv_row7_6.Name = "text_sv_row7_6";
            this.text_sv_row7_6.ReadOnly = true;
            this.text_sv_row7_6.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_6.TabIndex = 160;
            this.text_sv_row7_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_3
            // 
            this.text_sv_row1_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_3.Location = new System.Drawing.Point(53, 221);
            this.text_sv_row1_3.Name = "text_sv_row1_3";
            this.text_sv_row1_3.ReadOnly = true;
            this.text_sv_row1_3.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_3.TabIndex = 91;
            this.text_sv_row1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_7
            // 
            this.text_sv_row7_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_7.Location = new System.Drawing.Point(795, 329);
            this.text_sv_row7_7.Name = "text_sv_row7_7";
            this.text_sv_row7_7.ReadOnly = true;
            this.text_sv_row7_7.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_7.TabIndex = 161;
            this.text_sv_row7_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_2
            // 
            this.text_sv_row1_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_2.Location = new System.Drawing.Point(53, 194);
            this.text_sv_row1_2.Name = "text_sv_row1_2";
            this.text_sv_row1_2.ReadOnly = true;
            this.text_sv_row1_2.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_2.TabIndex = 90;
            this.text_sv_row1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_8
            // 
            this.text_sv_row7_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_8.Location = new System.Drawing.Point(795, 356);
            this.text_sv_row7_8.Name = "text_sv_row7_8";
            this.text_sv_row7_8.ReadOnly = true;
            this.text_sv_row7_8.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_8.TabIndex = 162;
            this.text_sv_row7_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_1
            // 
            this.text_sv_row1_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_1.Location = new System.Drawing.Point(53, 167);
            this.text_sv_row1_1.Name = "text_sv_row1_1";
            this.text_sv_row1_1.ReadOnly = true;
            this.text_sv_row1_1.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_1.TabIndex = 89;
            this.text_sv_row1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7
            // 
            this.text_sv_row7.BackColor = System.Drawing.Color.Black;
            this.text_sv_row7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7.ForeColor = System.Drawing.Color.White;
            this.text_sv_row7.Location = new System.Drawing.Point(795, 133);
            this.text_sv_row7.Name = "text_sv_row7";
            this.text_sv_row7.ReadOnly = true;
            this.text_sv_row7.Size = new System.Drawing.Size(114, 33);
            this.text_sv_row7.TabIndex = 154;
            this.text_sv_row7.Text = "-";
            this.text_sv_row7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1
            // 
            this.text_sv_row1.BackColor = System.Drawing.Color.Black;
            this.text_sv_row1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1.ForeColor = System.Drawing.Color.White;
            this.text_sv_row1.Location = new System.Drawing.Point(53, 133);
            this.text_sv_row1.Name = "text_sv_row1";
            this.text_sv_row1.ReadOnly = true;
            this.text_sv_row1.Size = new System.Drawing.Size(213, 33);
            this.text_sv_row1.TabIndex = 88;
            this.text_sv_row1.Text = "-";
            this.text_sv_row1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_1
            // 
            this.text_sv_row7_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_1.Location = new System.Drawing.Point(795, 167);
            this.text_sv_row7_1.Name = "text_sv_row7_1";
            this.text_sv_row7_1.ReadOnly = true;
            this.text_sv_row7_1.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_1.TabIndex = 155;
            this.text_sv_row7_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_8
            // 
            this.text_sv_row1_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_8.Location = new System.Drawing.Point(53, 356);
            this.text_sv_row1_8.Name = "text_sv_row1_8";
            this.text_sv_row1_8.ReadOnly = true;
            this.text_sv_row1_8.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_8.TabIndex = 96;
            this.text_sv_row1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_2
            // 
            this.text_sv_row7_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_2.Location = new System.Drawing.Point(795, 194);
            this.text_sv_row7_2.Name = "text_sv_row7_2";
            this.text_sv_row7_2.ReadOnly = true;
            this.text_sv_row7_2.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_2.TabIndex = 156;
            this.text_sv_row7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_7
            // 
            this.text_sv_row1_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_7.Location = new System.Drawing.Point(53, 329);
            this.text_sv_row1_7.Name = "text_sv_row1_7";
            this.text_sv_row1_7.ReadOnly = true;
            this.text_sv_row1_7.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_7.TabIndex = 95;
            this.text_sv_row1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_3
            // 
            this.text_sv_row7_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_3.Location = new System.Drawing.Point(795, 221);
            this.text_sv_row7_3.Name = "text_sv_row7_3";
            this.text_sv_row7_3.ReadOnly = true;
            this.text_sv_row7_3.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_3.TabIndex = 157;
            this.text_sv_row7_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_6
            // 
            this.text_sv_row1_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_6.Location = new System.Drawing.Point(53, 302);
            this.text_sv_row1_6.Name = "text_sv_row1_6";
            this.text_sv_row1_6.ReadOnly = true;
            this.text_sv_row1_6.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_6.TabIndex = 94;
            this.text_sv_row1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row7_4
            // 
            this.text_sv_row7_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row7_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row7_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row7_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row7_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row7_4.Location = new System.Drawing.Point(795, 248);
            this.text_sv_row7_4.Name = "text_sv_row7_4";
            this.text_sv_row7_4.ReadOnly = true;
            this.text_sv_row7_4.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row7_4.TabIndex = 158;
            this.text_sv_row7_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_5
            // 
            this.text_sv_row1_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_5.Location = new System.Drawing.Point(53, 275);
            this.text_sv_row1_5.Name = "text_sv_row1_5";
            this.text_sv_row1_5.ReadOnly = true;
            this.text_sv_row1_5.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_5.TabIndex = 93;
            this.text_sv_row1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_9
            // 
            this.text_sv_row6_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_9.Location = new System.Drawing.Point(680, 383);
            this.text_sv_row6_9.Name = "text_sv_row6_9";
            this.text_sv_row6_9.ReadOnly = true;
            this.text_sv_row6_9.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_9.TabIndex = 152;
            this.text_sv_row6_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_10
            // 
            this.text_sv_row1_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_10.Location = new System.Drawing.Point(53, 410);
            this.text_sv_row1_10.Name = "text_sv_row1_10";
            this.text_sv_row1_10.ReadOnly = true;
            this.text_sv_row1_10.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_10.TabIndex = 98;
            this.text_sv_row1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_10
            // 
            this.text_sv_row6_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_10.Location = new System.Drawing.Point(680, 410);
            this.text_sv_row6_10.Name = "text_sv_row6_10";
            this.text_sv_row6_10.ReadOnly = true;
            this.text_sv_row6_10.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_10.TabIndex = 153;
            this.text_sv_row6_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row1_9
            // 
            this.text_sv_row1_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row1_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row1_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row1_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row1_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row1_9.Location = new System.Drawing.Point(53, 383);
            this.text_sv_row1_9.Name = "text_sv_row1_9";
            this.text_sv_row1_9.ReadOnly = true;
            this.text_sv_row1_9.Size = new System.Drawing.Size(213, 26);
            this.text_sv_row1_9.TabIndex = 97;
            this.text_sv_row1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_5
            // 
            this.text_sv_row6_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_5.Location = new System.Drawing.Point(680, 275);
            this.text_sv_row6_5.Name = "text_sv_row6_5";
            this.text_sv_row6_5.ReadOnly = true;
            this.text_sv_row6_5.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_5.TabIndex = 148;
            this.text_sv_row6_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_4
            // 
            this.text_sv_row2_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_4.Location = new System.Drawing.Point(267, 248);
            this.text_sv_row2_4.Name = "text_sv_row2_4";
            this.text_sv_row2_4.ReadOnly = true;
            this.text_sv_row2_4.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_4.TabIndex = 103;
            this.text_sv_row2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_6
            // 
            this.text_sv_row6_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_6.Location = new System.Drawing.Point(680, 302);
            this.text_sv_row6_6.Name = "text_sv_row6_6";
            this.text_sv_row6_6.ReadOnly = true;
            this.text_sv_row6_6.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_6.TabIndex = 149;
            this.text_sv_row6_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_3
            // 
            this.text_sv_row2_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_3.Location = new System.Drawing.Point(267, 221);
            this.text_sv_row2_3.Name = "text_sv_row2_3";
            this.text_sv_row2_3.ReadOnly = true;
            this.text_sv_row2_3.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_3.TabIndex = 102;
            this.text_sv_row2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_7
            // 
            this.text_sv_row6_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_7.Location = new System.Drawing.Point(680, 329);
            this.text_sv_row6_7.Name = "text_sv_row6_7";
            this.text_sv_row6_7.ReadOnly = true;
            this.text_sv_row6_7.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_7.TabIndex = 150;
            this.text_sv_row6_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_2
            // 
            this.text_sv_row2_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_2.Location = new System.Drawing.Point(267, 194);
            this.text_sv_row2_2.Name = "text_sv_row2_2";
            this.text_sv_row2_2.ReadOnly = true;
            this.text_sv_row2_2.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_2.TabIndex = 101;
            this.text_sv_row2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_8
            // 
            this.text_sv_row6_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_8.Location = new System.Drawing.Point(680, 356);
            this.text_sv_row6_8.Name = "text_sv_row6_8";
            this.text_sv_row6_8.ReadOnly = true;
            this.text_sv_row6_8.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_8.TabIndex = 151;
            this.text_sv_row6_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_1
            // 
            this.text_sv_row2_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_1.Location = new System.Drawing.Point(267, 167);
            this.text_sv_row2_1.Name = "text_sv_row2_1";
            this.text_sv_row2_1.ReadOnly = true;
            this.text_sv_row2_1.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_1.TabIndex = 100;
            this.text_sv_row2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6
            // 
            this.text_sv_row6.BackColor = System.Drawing.Color.Black;
            this.text_sv_row6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6.ForeColor = System.Drawing.Color.White;
            this.text_sv_row6.Location = new System.Drawing.Point(680, 133);
            this.text_sv_row6.Name = "text_sv_row6";
            this.text_sv_row6.ReadOnly = true;
            this.text_sv_row6.Size = new System.Drawing.Size(114, 33);
            this.text_sv_row6.TabIndex = 143;
            this.text_sv_row6.Text = "-";
            this.text_sv_row6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2
            // 
            this.text_sv_row2.BackColor = System.Drawing.Color.Black;
            this.text_sv_row2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2.ForeColor = System.Drawing.Color.White;
            this.text_sv_row2.Location = new System.Drawing.Point(267, 133);
            this.text_sv_row2.Name = "text_sv_row2";
            this.text_sv_row2.ReadOnly = true;
            this.text_sv_row2.Size = new System.Drawing.Size(116, 33);
            this.text_sv_row2.TabIndex = 99;
            this.text_sv_row2.Text = "-";
            this.text_sv_row2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_1
            // 
            this.text_sv_row6_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_1.Location = new System.Drawing.Point(680, 167);
            this.text_sv_row6_1.Name = "text_sv_row6_1";
            this.text_sv_row6_1.ReadOnly = true;
            this.text_sv_row6_1.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_1.TabIndex = 144;
            this.text_sv_row6_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_8
            // 
            this.text_sv_row2_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_8.Location = new System.Drawing.Point(267, 356);
            this.text_sv_row2_8.Name = "text_sv_row2_8";
            this.text_sv_row2_8.ReadOnly = true;
            this.text_sv_row2_8.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_8.TabIndex = 107;
            this.text_sv_row2_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_2
            // 
            this.text_sv_row6_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_2.Location = new System.Drawing.Point(680, 194);
            this.text_sv_row6_2.Name = "text_sv_row6_2";
            this.text_sv_row6_2.ReadOnly = true;
            this.text_sv_row6_2.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_2.TabIndex = 145;
            this.text_sv_row6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_7
            // 
            this.text_sv_row2_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_7.Location = new System.Drawing.Point(267, 329);
            this.text_sv_row2_7.Name = "text_sv_row2_7";
            this.text_sv_row2_7.ReadOnly = true;
            this.text_sv_row2_7.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_7.TabIndex = 106;
            this.text_sv_row2_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_3
            // 
            this.text_sv_row6_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_3.Location = new System.Drawing.Point(680, 221);
            this.text_sv_row6_3.Name = "text_sv_row6_3";
            this.text_sv_row6_3.ReadOnly = true;
            this.text_sv_row6_3.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_3.TabIndex = 146;
            this.text_sv_row6_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_6
            // 
            this.text_sv_row2_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_6.Location = new System.Drawing.Point(267, 302);
            this.text_sv_row2_6.Name = "text_sv_row2_6";
            this.text_sv_row2_6.ReadOnly = true;
            this.text_sv_row2_6.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_6.TabIndex = 105;
            this.text_sv_row2_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row6_4
            // 
            this.text_sv_row6_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row6_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row6_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row6_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row6_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row6_4.Location = new System.Drawing.Point(680, 248);
            this.text_sv_row6_4.Name = "text_sv_row6_4";
            this.text_sv_row6_4.ReadOnly = true;
            this.text_sv_row6_4.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row6_4.TabIndex = 147;
            this.text_sv_row6_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_5
            // 
            this.text_sv_row2_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_5.Location = new System.Drawing.Point(267, 275);
            this.text_sv_row2_5.Name = "text_sv_row2_5";
            this.text_sv_row2_5.ReadOnly = true;
            this.text_sv_row2_5.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_5.TabIndex = 104;
            this.text_sv_row2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_9
            // 
            this.text_sv_row5_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_9.Location = new System.Drawing.Point(565, 383);
            this.text_sv_row5_9.Name = "text_sv_row5_9";
            this.text_sv_row5_9.ReadOnly = true;
            this.text_sv_row5_9.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_9.TabIndex = 141;
            this.text_sv_row5_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_10
            // 
            this.text_sv_row2_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_10.Location = new System.Drawing.Point(267, 410);
            this.text_sv_row2_10.Name = "text_sv_row2_10";
            this.text_sv_row2_10.ReadOnly = true;
            this.text_sv_row2_10.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_10.TabIndex = 109;
            this.text_sv_row2_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_10
            // 
            this.text_sv_row5_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_10.Location = new System.Drawing.Point(565, 410);
            this.text_sv_row5_10.Name = "text_sv_row5_10";
            this.text_sv_row5_10.ReadOnly = true;
            this.text_sv_row5_10.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_10.TabIndex = 142;
            this.text_sv_row5_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row2_9
            // 
            this.text_sv_row2_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row2_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row2_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row2_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row2_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row2_9.Location = new System.Drawing.Point(267, 383);
            this.text_sv_row2_9.Name = "text_sv_row2_9";
            this.text_sv_row2_9.ReadOnly = true;
            this.text_sv_row2_9.Size = new System.Drawing.Size(116, 26);
            this.text_sv_row2_9.TabIndex = 108;
            this.text_sv_row2_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_5
            // 
            this.text_sv_row5_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_5.Location = new System.Drawing.Point(565, 275);
            this.text_sv_row5_5.Name = "text_sv_row5_5";
            this.text_sv_row5_5.ReadOnly = true;
            this.text_sv_row5_5.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_5.TabIndex = 137;
            this.text_sv_row5_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_4
            // 
            this.text_sv_row3_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_4.Location = new System.Drawing.Point(384, 248);
            this.text_sv_row3_4.Name = "text_sv_row3_4";
            this.text_sv_row3_4.ReadOnly = true;
            this.text_sv_row3_4.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_4.TabIndex = 114;
            this.text_sv_row3_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_6
            // 
            this.text_sv_row5_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_6.Location = new System.Drawing.Point(565, 302);
            this.text_sv_row5_6.Name = "text_sv_row5_6";
            this.text_sv_row5_6.ReadOnly = true;
            this.text_sv_row5_6.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_6.TabIndex = 138;
            this.text_sv_row5_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_3
            // 
            this.text_sv_row3_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_3.Location = new System.Drawing.Point(384, 221);
            this.text_sv_row3_3.Name = "text_sv_row3_3";
            this.text_sv_row3_3.ReadOnly = true;
            this.text_sv_row3_3.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_3.TabIndex = 113;
            this.text_sv_row3_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_7
            // 
            this.text_sv_row5_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_7.Location = new System.Drawing.Point(565, 329);
            this.text_sv_row5_7.Name = "text_sv_row5_7";
            this.text_sv_row5_7.ReadOnly = true;
            this.text_sv_row5_7.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_7.TabIndex = 139;
            this.text_sv_row5_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_2
            // 
            this.text_sv_row3_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_2.Location = new System.Drawing.Point(384, 194);
            this.text_sv_row3_2.Name = "text_sv_row3_2";
            this.text_sv_row3_2.ReadOnly = true;
            this.text_sv_row3_2.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_2.TabIndex = 112;
            this.text_sv_row3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_8
            // 
            this.text_sv_row5_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_8.Location = new System.Drawing.Point(565, 356);
            this.text_sv_row5_8.Name = "text_sv_row5_8";
            this.text_sv_row5_8.ReadOnly = true;
            this.text_sv_row5_8.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_8.TabIndex = 140;
            this.text_sv_row5_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_1
            // 
            this.text_sv_row3_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_1.Location = new System.Drawing.Point(384, 167);
            this.text_sv_row3_1.Name = "text_sv_row3_1";
            this.text_sv_row3_1.ReadOnly = true;
            this.text_sv_row3_1.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_1.TabIndex = 111;
            this.text_sv_row3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5
            // 
            this.text_sv_row5.BackColor = System.Drawing.Color.Black;
            this.text_sv_row5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5.ForeColor = System.Drawing.Color.White;
            this.text_sv_row5.Location = new System.Drawing.Point(565, 133);
            this.text_sv_row5.Name = "text_sv_row5";
            this.text_sv_row5.ReadOnly = true;
            this.text_sv_row5.Size = new System.Drawing.Size(114, 33);
            this.text_sv_row5.TabIndex = 132;
            this.text_sv_row5.Text = "-";
            this.text_sv_row5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3
            // 
            this.text_sv_row3.BackColor = System.Drawing.Color.Black;
            this.text_sv_row3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3.ForeColor = System.Drawing.Color.White;
            this.text_sv_row3.Location = new System.Drawing.Point(384, 133);
            this.text_sv_row3.Name = "text_sv_row3";
            this.text_sv_row3.ReadOnly = true;
            this.text_sv_row3.Size = new System.Drawing.Size(65, 33);
            this.text_sv_row3.TabIndex = 110;
            this.text_sv_row3.Text = "-";
            this.text_sv_row3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_1
            // 
            this.text_sv_row5_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_1.Location = new System.Drawing.Point(565, 167);
            this.text_sv_row5_1.Name = "text_sv_row5_1";
            this.text_sv_row5_1.ReadOnly = true;
            this.text_sv_row5_1.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_1.TabIndex = 133;
            this.text_sv_row5_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_8
            // 
            this.text_sv_row3_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_8.Location = new System.Drawing.Point(384, 356);
            this.text_sv_row3_8.Name = "text_sv_row3_8";
            this.text_sv_row3_8.ReadOnly = true;
            this.text_sv_row3_8.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_8.TabIndex = 118;
            this.text_sv_row3_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_2
            // 
            this.text_sv_row5_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_2.Location = new System.Drawing.Point(565, 194);
            this.text_sv_row5_2.Name = "text_sv_row5_2";
            this.text_sv_row5_2.ReadOnly = true;
            this.text_sv_row5_2.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_2.TabIndex = 134;
            this.text_sv_row5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_7
            // 
            this.text_sv_row3_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_7.Location = new System.Drawing.Point(384, 329);
            this.text_sv_row3_7.Name = "text_sv_row3_7";
            this.text_sv_row3_7.ReadOnly = true;
            this.text_sv_row3_7.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_7.TabIndex = 117;
            this.text_sv_row3_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_3
            // 
            this.text_sv_row5_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_3.Location = new System.Drawing.Point(565, 221);
            this.text_sv_row5_3.Name = "text_sv_row5_3";
            this.text_sv_row5_3.ReadOnly = true;
            this.text_sv_row5_3.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_3.TabIndex = 135;
            this.text_sv_row5_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_6
            // 
            this.text_sv_row3_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_6.Location = new System.Drawing.Point(384, 302);
            this.text_sv_row3_6.Name = "text_sv_row3_6";
            this.text_sv_row3_6.ReadOnly = true;
            this.text_sv_row3_6.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_6.TabIndex = 116;
            this.text_sv_row3_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row5_4
            // 
            this.text_sv_row5_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row5_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row5_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row5_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row5_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row5_4.Location = new System.Drawing.Point(565, 248);
            this.text_sv_row5_4.Name = "text_sv_row5_4";
            this.text_sv_row5_4.ReadOnly = true;
            this.text_sv_row5_4.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row5_4.TabIndex = 136;
            this.text_sv_row5_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_5
            // 
            this.text_sv_row3_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_5.Location = new System.Drawing.Point(384, 275);
            this.text_sv_row3_5.Name = "text_sv_row3_5";
            this.text_sv_row3_5.ReadOnly = true;
            this.text_sv_row3_5.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_5.TabIndex = 115;
            this.text_sv_row3_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_9
            // 
            this.text_sv_row4_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_9.Location = new System.Drawing.Point(450, 383);
            this.text_sv_row4_9.Name = "text_sv_row4_9";
            this.text_sv_row4_9.ReadOnly = true;
            this.text_sv_row4_9.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_9.TabIndex = 130;
            this.text_sv_row4_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_10
            // 
            this.text_sv_row3_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_10.Location = new System.Drawing.Point(384, 410);
            this.text_sv_row3_10.Name = "text_sv_row3_10";
            this.text_sv_row3_10.ReadOnly = true;
            this.text_sv_row3_10.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_10.TabIndex = 120;
            this.text_sv_row3_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_10
            // 
            this.text_sv_row4_10.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_10.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_10.Location = new System.Drawing.Point(450, 410);
            this.text_sv_row4_10.Name = "text_sv_row4_10";
            this.text_sv_row4_10.ReadOnly = true;
            this.text_sv_row4_10.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_10.TabIndex = 131;
            this.text_sv_row4_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row3_9
            // 
            this.text_sv_row3_9.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row3_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row3_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row3_9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row3_9.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row3_9.Location = new System.Drawing.Point(384, 383);
            this.text_sv_row3_9.Name = "text_sv_row3_9";
            this.text_sv_row3_9.ReadOnly = true;
            this.text_sv_row3_9.Size = new System.Drawing.Size(65, 26);
            this.text_sv_row3_9.TabIndex = 119;
            this.text_sv_row3_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_5
            // 
            this.text_sv_row4_5.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_5.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_5.Location = new System.Drawing.Point(450, 275);
            this.text_sv_row4_5.Name = "text_sv_row4_5";
            this.text_sv_row4_5.ReadOnly = true;
            this.text_sv_row4_5.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_5.TabIndex = 126;
            this.text_sv_row4_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_4
            // 
            this.text_sv_row4_4.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_4.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_4.Location = new System.Drawing.Point(450, 248);
            this.text_sv_row4_4.Name = "text_sv_row4_4";
            this.text_sv_row4_4.ReadOnly = true;
            this.text_sv_row4_4.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_4.TabIndex = 125;
            this.text_sv_row4_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_6
            // 
            this.text_sv_row4_6.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_6.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_6.Location = new System.Drawing.Point(450, 302);
            this.text_sv_row4_6.Name = "text_sv_row4_6";
            this.text_sv_row4_6.ReadOnly = true;
            this.text_sv_row4_6.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_6.TabIndex = 127;
            this.text_sv_row4_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_3
            // 
            this.text_sv_row4_3.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_3.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_3.Location = new System.Drawing.Point(450, 221);
            this.text_sv_row4_3.Name = "text_sv_row4_3";
            this.text_sv_row4_3.ReadOnly = true;
            this.text_sv_row4_3.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_3.TabIndex = 124;
            this.text_sv_row4_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_7
            // 
            this.text_sv_row4_7.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_7.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_7.Location = new System.Drawing.Point(450, 329);
            this.text_sv_row4_7.Name = "text_sv_row4_7";
            this.text_sv_row4_7.ReadOnly = true;
            this.text_sv_row4_7.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_7.TabIndex = 128;
            this.text_sv_row4_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_2
            // 
            this.text_sv_row4_2.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_2.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_2.Location = new System.Drawing.Point(450, 194);
            this.text_sv_row4_2.Name = "text_sv_row4_2";
            this.text_sv_row4_2.ReadOnly = true;
            this.text_sv_row4_2.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_2.TabIndex = 123;
            this.text_sv_row4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_8
            // 
            this.text_sv_row4_8.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_8.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_8.Location = new System.Drawing.Point(450, 356);
            this.text_sv_row4_8.Name = "text_sv_row4_8";
            this.text_sv_row4_8.ReadOnly = true;
            this.text_sv_row4_8.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_8.TabIndex = 129;
            this.text_sv_row4_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_sv_row4_1
            // 
            this.text_sv_row4_1.BackColor = System.Drawing.SystemColors.Window;
            this.text_sv_row4_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_sv_row4_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sv_row4_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sv_row4_1.ForeColor = System.Drawing.Color.Black;
            this.text_sv_row4_1.Location = new System.Drawing.Point(450, 167);
            this.text_sv_row4_1.Name = "text_sv_row4_1";
            this.text_sv_row4_1.ReadOnly = true;
            this.text_sv_row4_1.Size = new System.Drawing.Size(114, 26);
            this.text_sv_row4_1.TabIndex = 122;
            this.text_sv_row4_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_sv_tp
            // 
            this.button_sv_tp.BackColor = System.Drawing.Color.Black;
            this.button_sv_tp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_tp.BackgroundImage")));
            this.button_sv_tp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_tp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_tp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_tp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_tp.Location = new System.Drawing.Point(1, 1);
            this.button_sv_tp.Name = "button_sv_tp";
            this.button_sv_tp.Size = new System.Drawing.Size(167, 65);
            this.button_sv_tp.TabIndex = 76;
            this.button_sv_tp.Text = "TP";
            this.button_sv_tp.UseVisualStyleBackColor = false;
            this.button_sv_tp.Click += new System.EventHandler(this.button_sv_tp_Click);
            // 
            // button_sv_op
            // 
            this.button_sv_op.BackColor = System.Drawing.Color.Black;
            this.button_sv_op.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_op.BackgroundImage")));
            this.button_sv_op.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_op.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_op.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_op.Location = new System.Drawing.Point(170, 1);
            this.button_sv_op.Name = "button_sv_op";
            this.button_sv_op.Size = new System.Drawing.Size(167, 65);
            this.button_sv_op.TabIndex = 77;
            this.button_sv_op.Text = "Open";
            this.button_sv_op.UseVisualStyleBackColor = false;
            this.button_sv_op.Click += new System.EventHandler(this.button_sv_op_Click);
            // 
            // button_sv_shb
            // 
            this.button_sv_shb.BackColor = System.Drawing.Color.Black;
            this.button_sv_shb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_shb.BackgroundImage")));
            this.button_sv_shb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_shb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_shb.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_shb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_shb.Location = new System.Drawing.Point(339, 1);
            this.button_sv_shb.Name = "button_sv_shb";
            this.button_sv_shb.Size = new System.Drawing.Size(167, 65);
            this.button_sv_shb.TabIndex = 78;
            this.button_sv_shb.Text = "Short";
            this.button_sv_shb.UseVisualStyleBackColor = false;
            this.button_sv_shb.Click += new System.EventHandler(this.button_sv_shb_Click);
            // 
            // button_sv_she
            // 
            this.button_sv_she.BackColor = System.Drawing.Color.Black;
            this.button_sv_she.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_she.BackgroundImage")));
            this.button_sv_she.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_she.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_she.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_she.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_she.Location = new System.Drawing.Point(508, 1);
            this.button_sv_she.Name = "button_sv_she";
            this.button_sv_she.Size = new System.Drawing.Size(167, 65);
            this.button_sv_she.TabIndex = 79;
            this.button_sv_she.Text = "Short Ex";
            this.button_sv_she.UseVisualStyleBackColor = false;
            this.button_sv_she.Click += new System.EventHandler(this.button_sv_she_Click);
            // 
            // button_sv_pt
            // 
            this.button_sv_pt.BackColor = System.Drawing.Color.Black;
            this.button_sv_pt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_pt.BackgroundImage")));
            this.button_sv_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_pt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_pt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_pt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_pt.Location = new System.Drawing.Point(677, 1);
            this.button_sv_pt.Name = "button_sv_pt";
            this.button_sv_pt.Size = new System.Drawing.Size(167, 65);
            this.button_sv_pt.TabIndex = 80;
            this.button_sv_pt.Text = "Part";
            this.button_sv_pt.UseVisualStyleBackColor = false;
            this.button_sv_pt.Click += new System.EventHandler(this.button_sv_pt_Click);
            // 
            // button_sv_fn
            // 
            this.button_sv_fn.BackColor = System.Drawing.Color.Black;
            this.button_sv_fn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_fn.BackgroundImage")));
            this.button_sv_fn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_fn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_fn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_fn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_fn.Location = new System.Drawing.Point(846, 1);
            this.button_sv_fn.Name = "button_sv_fn";
            this.button_sv_fn.Size = new System.Drawing.Size(167, 65);
            this.button_sv_fn.TabIndex = 81;
            this.button_sv_fn.Text = "Function";
            this.button_sv_fn.UseVisualStyleBackColor = false;
            this.button_sv_fn.Click += new System.EventHandler(this.button_sv_fn_Click);
            // 
            // button_sv_pre
            // 
            this.button_sv_pre.BackColor = System.Drawing.Color.Black;
            this.button_sv_pre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_pre.BackgroundImage")));
            this.button_sv_pre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_pre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_pre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_pre.ForeColor = System.Drawing.Color.Lavender;
            this.button_sv_pre.Location = new System.Drawing.Point(1, 66);
            this.button_sv_pre.Name = "button_sv_pre";
            this.button_sv_pre.Size = new System.Drawing.Size(167, 65);
            this.button_sv_pre.TabIndex = 82;
            this.button_sv_pre.Text = "Prev Page";
            this.button_sv_pre.UseVisualStyleBackColor = false;
            this.button_sv_pre.Click += new System.EventHandler(this.button_sv_pre_Click);
            // 
            // button_sv_mode1
            // 
            this.button_sv_mode1.BackColor = System.Drawing.Color.Black;
            this.button_sv_mode1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_mode1.BackgroundImage")));
            this.button_sv_mode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_mode1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_mode1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_mode1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_mode1.Location = new System.Drawing.Point(170, 66);
            this.button_sv_mode1.Name = "button_sv_mode1";
            this.button_sv_mode1.Size = new System.Drawing.Size(167, 65);
            this.button_sv_mode1.TabIndex = 83;
            this.button_sv_mode1.Text = "mode1";
            this.button_sv_mode1.UseVisualStyleBackColor = false;
            this.button_sv_mode1.Click += new System.EventHandler(this.button_sv_mode1_Click);
            // 
            // button_sv_mode2
            // 
            this.button_sv_mode2.BackColor = System.Drawing.Color.Black;
            this.button_sv_mode2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_mode2.BackgroundImage")));
            this.button_sv_mode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_mode2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_mode2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_mode2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_mode2.Location = new System.Drawing.Point(339, 66);
            this.button_sv_mode2.Name = "button_sv_mode2";
            this.button_sv_mode2.Size = new System.Drawing.Size(167, 65);
            this.button_sv_mode2.TabIndex = 84;
            this.button_sv_mode2.Text = "mode2";
            this.button_sv_mode2.UseVisualStyleBackColor = false;
            this.button_sv_mode2.Click += new System.EventHandler(this.button_sv_mode2_Click);
            // 
            // button_sv_mode3
            // 
            this.button_sv_mode3.BackColor = System.Drawing.Color.Black;
            this.button_sv_mode3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_mode3.BackgroundImage")));
            this.button_sv_mode3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_mode3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_mode3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_mode3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_mode3.Location = new System.Drawing.Point(508, 66);
            this.button_sv_mode3.Name = "button_sv_mode3";
            this.button_sv_mode3.Size = new System.Drawing.Size(167, 65);
            this.button_sv_mode3.TabIndex = 85;
            this.button_sv_mode3.Text = "mode3";
            this.button_sv_mode3.UseVisualStyleBackColor = false;
            this.button_sv_mode3.Click += new System.EventHandler(this.button_sv_mode3_Click);
            // 
            // button_sv_mode4
            // 
            this.button_sv_mode4.BackColor = System.Drawing.Color.Black;
            this.button_sv_mode4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_mode4.BackgroundImage")));
            this.button_sv_mode4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_mode4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_mode4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_mode4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_sv_mode4.Location = new System.Drawing.Point(677, 66);
            this.button_sv_mode4.Name = "button_sv_mode4";
            this.button_sv_mode4.Size = new System.Drawing.Size(167, 65);
            this.button_sv_mode4.TabIndex = 86;
            this.button_sv_mode4.Text = "mode4";
            this.button_sv_mode4.UseVisualStyleBackColor = false;
            this.button_sv_mode4.Click += new System.EventHandler(this.button_sv_mode4_Click);
            // 
            // button_sv_next
            // 
            this.button_sv_next.BackColor = System.Drawing.Color.Black;
            this.button_sv_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sv_next.BackgroundImage")));
            this.button_sv_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sv_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sv_next.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv_next.ForeColor = System.Drawing.Color.Lavender;
            this.button_sv_next.Location = new System.Drawing.Point(846, 66);
            this.button_sv_next.Name = "button_sv_next";
            this.button_sv_next.Size = new System.Drawing.Size(167, 65);
            this.button_sv_next.TabIndex = 87;
            this.button_sv_next.Text = "Next Page";
            this.button_sv_next.UseVisualStyleBackColor = false;
            this.button_sv_next.Click += new System.EventHandler(this.button_sv_next_Click);
            // 
            // tabSpecUp
            // 
            this.tabSpecUp.BackColor = System.Drawing.Color.Black;
            this.tabSpecUp.Controls.Add(this.chb_EEPROM);
            this.tabSpecUp.Controls.Add(this.chb_TPIC);
            this.tabSpecUp.Controls.Add(this.chb_PMIC);
            this.tabSpecUp.Controls.Add(this.chb_InData);
            this.tabSpecUp.Controls.Add(this.chb_bootApp);
            this.tabSpecUp.Controls.Add(this.text_eep);
            this.tabSpecUp.Controls.Add(this.bt_eep_update);
            this.tabSpecUp.Controls.Add(this.text_pmic);
            this.tabSpecUp.Controls.Add(this.bt_pmic_Update);
            this.tabSpecUp.Controls.Add(this.chb_subname);
            this.tabSpecUp.Controls.Add(this.chb_logunit);
            this.tabSpecUp.Controls.Add(this.chb_fwwrite);
            this.tabSpecUp.Controls.Add(this.chb_ngcont);
            this.tabSpecUp.Controls.Add(this.bt_data_Update);
            this.tabSpecUp.Controls.Add(this.bt_ict_update);
            this.tabSpecUp.Controls.Add(this.text_data);
            this.tabSpecUp.Controls.Add(this.text_ict);
            this.tabSpecUp.Location = new System.Drawing.Point(4, 24);
            this.tabSpecUp.Name = "tabSpecUp";
            this.tabSpecUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecUp.Size = new System.Drawing.Size(1016, 471);
            this.tabSpecUp.TabIndex = 3;
            this.tabSpecUp.Text = "Spec Update";
            // 
            // chb_EEPROM
            // 
            this.chb_EEPROM.AutoSize = true;
            this.chb_EEPROM.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_EEPROM.Location = new System.Drawing.Point(268, 222);
            this.chb_EEPROM.Name = "chb_EEPROM";
            this.chb_EEPROM.Size = new System.Drawing.Size(106, 29);
            this.chb_EEPROM.TabIndex = 205;
            this.chb_EEPROM.Text = "EEPROM";
            this.chb_EEPROM.UseVisualStyleBackColor = true;
            this.chb_EEPROM.CheckedChanged += new System.EventHandler(this.chb_EEPROM_CheckedChanged);
            // 
            // chb_TPIC
            // 
            this.chb_TPIC.AutoSize = true;
            this.chb_TPIC.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_TPIC.Location = new System.Drawing.Point(192, 222);
            this.chb_TPIC.Name = "chb_TPIC";
            this.chb_TPIC.Size = new System.Drawing.Size(70, 29);
            this.chb_TPIC.TabIndex = 204;
            this.chb_TPIC.Text = "TPIC";
            this.chb_TPIC.UseVisualStyleBackColor = true;
            this.chb_TPIC.CheckedChanged += new System.EventHandler(this.chb_TPIC_CheckedChanged);
            // 
            // chb_PMIC
            // 
            this.chb_PMIC.AutoSize = true;
            this.chb_PMIC.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_PMIC.Location = new System.Drawing.Point(112, 222);
            this.chb_PMIC.Name = "chb_PMIC";
            this.chb_PMIC.Size = new System.Drawing.Size(78, 29);
            this.chb_PMIC.TabIndex = 203;
            this.chb_PMIC.Text = "PMIC";
            this.chb_PMIC.UseVisualStyleBackColor = true;
            this.chb_PMIC.CheckedChanged += new System.EventHandler(this.chb_PMIC_CheckedChanged);
            // 
            // chb_InData
            // 
            this.chb_InData.AutoSize = true;
            this.chb_InData.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_InData.Location = new System.Drawing.Point(12, 222);
            this.chb_InData.Name = "chb_InData";
            this.chb_InData.Size = new System.Drawing.Size(94, 29);
            this.chb_InData.TabIndex = 202;
            this.chb_InData.Text = "In Data";
            this.chb_InData.UseVisualStyleBackColor = true;
            this.chb_InData.CheckedChanged += new System.EventHandler(this.chb_InData_CheckedChanged);
            // 
            // chb_bootApp
            // 
            this.chb_bootApp.AutoSize = true;
            this.chb_bootApp.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_bootApp.Location = new System.Drawing.Point(12, 175);
            this.chb_bootApp.Name = "chb_bootApp";
            this.chb_bootApp.Size = new System.Drawing.Size(250, 41);
            this.chb_bootApp.TabIndex = 201;
            this.chb_bootApp.Text = "Boot + App Write";
            this.chb_bootApp.UseVisualStyleBackColor = true;
            this.chb_bootApp.CheckedChanged += new System.EventHandler(this.chb_bootApp_CheckedChanged);
            // 
            // text_eep
            // 
            this.text_eep.BackColor = System.Drawing.Color.Black;
            this.text_eep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_eep.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_eep.ForeColor = System.Drawing.Color.White;
            this.text_eep.Location = new System.Drawing.Point(600, 356);
            this.text_eep.Multiline = true;
            this.text_eep.Name = "text_eep";
            this.text_eep.ReadOnly = true;
            this.text_eep.Size = new System.Drawing.Size(413, 65);
            this.text_eep.TabIndex = 200;
            this.text_eep.Text = " - EEP File Name\r\n - Size : 0.00 kB";
            // 
            // bt_eep_update
            // 
            this.bt_eep_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_eep_update.BackgroundImage")));
            this.bt_eep_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_eep_update.FlatAppearance.BorderSize = 0;
            this.bt_eep_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eep_update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eep_update.ForeColor = System.Drawing.Color.Black;
            this.bt_eep_update.Location = new System.Drawing.Point(458, 356);
            this.bt_eep_update.Name = "bt_eep_update";
            this.bt_eep_update.Size = new System.Drawing.Size(136, 65);
            this.bt_eep_update.TabIndex = 199;
            this.bt_eep_update.Text = "EEP Data\r\nUpdate";
            this.bt_eep_update.UseVisualStyleBackColor = true;
            this.bt_eep_update.Click += new System.EventHandler(this.bt_eep_update_Click);
            // 
            // text_pmic
            // 
            this.text_pmic.BackColor = System.Drawing.Color.Black;
            this.text_pmic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_pmic.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pmic.ForeColor = System.Drawing.Color.White;
            this.text_pmic.Location = new System.Drawing.Point(600, 222);
            this.text_pmic.Multiline = true;
            this.text_pmic.Name = "text_pmic";
            this.text_pmic.ReadOnly = true;
            this.text_pmic.Size = new System.Drawing.Size(413, 128);
            this.text_pmic.TabIndex = 198;
            this.text_pmic.Text = " - PMIC File Name\r\n - Size : 0.00 kB";
            // 
            // bt_pmic_Update
            // 
            this.bt_pmic_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pmic_Update.BackgroundImage")));
            this.bt_pmic_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pmic_Update.FlatAppearance.BorderSize = 0;
            this.bt_pmic_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pmic_Update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pmic_Update.ForeColor = System.Drawing.Color.Black;
            this.bt_pmic_Update.Location = new System.Drawing.Point(460, 222);
            this.bt_pmic_Update.Name = "bt_pmic_Update";
            this.bt_pmic_Update.Size = new System.Drawing.Size(136, 128);
            this.bt_pmic_Update.TabIndex = 197;
            this.bt_pmic_Update.Text = "PMIC & TPIC Data\r\nUpdate";
            this.bt_pmic_Update.UseVisualStyleBackColor = true;
            this.bt_pmic_Update.Click += new System.EventHandler(this.bt_pmic_Update_Click_1);
            // 
            // chb_subname
            // 
            this.chb_subname.AutoSize = true;
            this.chb_subname.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_subname.Location = new System.Drawing.Point(12, 128);
            this.chb_subname.Name = "chb_subname";
            this.chb_subname.Size = new System.Drawing.Size(440, 41);
            this.chb_subname.TabIndex = 196;
            this.chb_subname.Text = "Display data file name in subarea";
            this.chb_subname.UseVisualStyleBackColor = true;
            this.chb_subname.CheckedChanged += new System.EventHandler(this.chb_subname_CheckedChanged);
            // 
            // chb_logunit
            // 
            this.chb_logunit.AutoSize = true;
            this.chb_logunit.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_logunit.Location = new System.Drawing.Point(12, 87);
            this.chb_logunit.Name = "chb_logunit";
            this.chb_logunit.Size = new System.Drawing.Size(258, 41);
            this.chb_logunit.TabIndex = 195;
            this.chb_logunit.Text = "Save log with Unit";
            this.chb_logunit.UseVisualStyleBackColor = true;
            this.chb_logunit.CheckedChanged += new System.EventHandler(this.chb_logunit_CheckedChanged);
            // 
            // chb_fwwrite
            // 
            this.chb_fwwrite.AutoSize = true;
            this.chb_fwwrite.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_fwwrite.Location = new System.Drawing.Point(12, 47);
            this.chb_fwwrite.Name = "chb_fwwrite";
            this.chb_fwwrite.Size = new System.Drawing.Size(248, 41);
            this.chb_fwwrite.TabIndex = 193;
            this.chb_fwwrite.Text = "Enable F/W Write";
            this.chb_fwwrite.UseVisualStyleBackColor = true;
            this.chb_fwwrite.CheckedChanged += new System.EventHandler(this.chb_fwwrite_CheckedChanged);
            // 
            // chb_ngcont
            // 
            this.chb_ngcont.AutoSize = true;
            this.chb_ngcont.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ngcont.Location = new System.Drawing.Point(12, 6);
            this.chb_ngcont.Name = "chb_ngcont";
            this.chb_ngcont.Size = new System.Drawing.Size(360, 41);
            this.chb_ngcont.TabIndex = 192;
            this.chb_ngcont.Text = "Continue inspection at NG";
            this.chb_ngcont.UseVisualStyleBackColor = true;
            this.chb_ngcont.CheckedChanged += new System.EventHandler(this.chb_ngcont_CheckedChanged);
            // 
            // bt_data_Update
            // 
            this.bt_data_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_data_Update.BackgroundImage")));
            this.bt_data_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_data_Update.FlatAppearance.BorderSize = 0;
            this.bt_data_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_data_Update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_data_Update.ForeColor = System.Drawing.Color.Black;
            this.bt_data_Update.Location = new System.Drawing.Point(460, 151);
            this.bt_data_Update.Name = "bt_data_Update";
            this.bt_data_Update.Size = new System.Drawing.Size(136, 65);
            this.bt_data_Update.TabIndex = 190;
            this.bt_data_Update.Text = "Input Data\r\nUpdate";
            this.bt_data_Update.UseVisualStyleBackColor = true;
            this.bt_data_Update.Click += new System.EventHandler(this.bt_data_Update_Click);
            // 
            // bt_ict_update
            // 
            this.bt_ict_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ict_update.BackgroundImage")));
            this.bt_ict_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ict_update.FlatAppearance.BorderSize = 0;
            this.bt_ict_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ict_update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ict_update.ForeColor = System.Drawing.Color.Black;
            this.bt_ict_update.Location = new System.Drawing.Point(460, 4);
            this.bt_ict_update.Name = "bt_ict_update";
            this.bt_ict_update.Size = new System.Drawing.Size(136, 142);
            this.bt_ict_update.TabIndex = 3;
            this.bt_ict_update.Text = "ICT Spec \r\nUpdate";
            this.bt_ict_update.UseVisualStyleBackColor = true;
            this.bt_ict_update.Click += new System.EventHandler(this.bt_ict_update_Click);
            // 
            // text_data
            // 
            this.text_data.BackColor = System.Drawing.Color.Black;
            this.text_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_data.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data.ForeColor = System.Drawing.Color.White;
            this.text_data.Location = new System.Drawing.Point(600, 151);
            this.text_data.Multiline = true;
            this.text_data.Name = "text_data";
            this.text_data.ReadOnly = true;
            this.text_data.Size = new System.Drawing.Size(413, 65);
            this.text_data.TabIndex = 2;
            this.text_data.Text = " - Data File Name\r\n - Size : 0.00 kB";
            // 
            // text_ict
            // 
            this.text_ict.BackColor = System.Drawing.Color.Black;
            this.text_ict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_ict.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ict.ForeColor = System.Drawing.Color.White;
            this.text_ict.Location = new System.Drawing.Point(600, 4);
            this.text_ict.Multiline = true;
            this.text_ict.Name = "text_ict";
            this.text_ict.ReadOnly = true;
            this.text_ict.Size = new System.Drawing.Size(413, 142);
            this.text_ict.TabIndex = 0;
            this.text_ict.Text = "[Number]\r\n - TP(0)\r\n - Open(0)/Short(0)/Short Ex(0)\r\n - Part(0)/Func(0)\r\n[CRC]\r\n " +
    "- TP(0)\r\n - Open(0)/Short(0)/Short Ex(0)\r\n - Part(0)/Func(0)";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Black;
            this.tabMain.Controls.Add(this.pn_result);
            this.tabMain.Controls.Add(this.groupBox1);
            this.tabMain.Controls.Add(this.textBox1);
            this.tabMain.Controls.Add(this.textBox2);
            this.tabMain.Controls.Add(this.textBox3);
            this.tabMain.Controls.Add(this.textBox4);
            this.tabMain.Location = new System.Drawing.Point(4, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(1016, 471);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Main";
            // 
            // pn_result
            // 
            this.pn_result.BackColor = System.Drawing.Color.MidnightBlue;
            this.pn_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_result.Controls.Add(this.text_result);
            this.pn_result.Controls.Add(this.text_popup4);
            this.pn_result.Controls.Add(this.text_popup3);
            this.pn_result.Controls.Add(this.text_popup1);
            this.pn_result.Controls.Add(this.text_popup2);
            this.pn_result.ForeColor = System.Drawing.Color.LightPink;
            this.pn_result.Location = new System.Drawing.Point(1, 1);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(52, 36);
            this.pn_result.TabIndex = 180;
            // 
            // text_result
            // 
            this.text_result.BackColor = System.Drawing.Color.MidnightBlue;
            this.text_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_result.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_result.ForeColor = System.Drawing.Color.LightPink;
            this.text_result.Location = new System.Drawing.Point(27, 111);
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(529, 86);
            this.text_result.TabIndex = 0;
            this.text_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_popup4
            // 
            this.text_popup4.BackColor = System.Drawing.Color.MidnightBlue;
            this.text_popup4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_popup4.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_popup4.ForeColor = System.Drawing.Color.LightPink;
            this.text_popup4.Location = new System.Drawing.Point(37, 5);
            this.text_popup4.Name = "text_popup4";
            this.text_popup4.Size = new System.Drawing.Size(529, 36);
            this.text_popup4.TabIndex = 4;
            this.text_popup4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_popup3
            // 
            this.text_popup3.BackColor = System.Drawing.Color.MidnightBlue;
            this.text_popup3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_popup3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_popup3.ForeColor = System.Drawing.Color.LightPink;
            this.text_popup3.Location = new System.Drawing.Point(37, 5);
            this.text_popup3.Name = "text_popup3";
            this.text_popup3.Size = new System.Drawing.Size(529, 36);
            this.text_popup3.TabIndex = 3;
            this.text_popup3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_popup1
            // 
            this.text_popup1.BackColor = System.Drawing.Color.MidnightBlue;
            this.text_popup1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_popup1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_popup1.ForeColor = System.Drawing.Color.LightPink;
            this.text_popup1.Location = new System.Drawing.Point(79, 5);
            this.text_popup1.Name = "text_popup1";
            this.text_popup1.Size = new System.Drawing.Size(529, 36);
            this.text_popup1.TabIndex = 2;
            this.text_popup1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_popup2
            // 
            this.text_popup2.BackColor = System.Drawing.Color.MidnightBlue;
            this.text_popup2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_popup2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_popup2.ForeColor = System.Drawing.Color.LightPink;
            this.text_popup2.Location = new System.Drawing.Point(67, 1);
            this.text_popup2.Name = "text_popup2";
            this.text_popup2.Size = new System.Drawing.Size(529, 36);
            this.text_popup2.TabIndex = 1;
            this.text_popup2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.bt_sub_popup);
            this.groupBox1.Controls.Add(this.bd_version);
            this.groupBox1.Controls.Add(this.text_tact_time);
            this.groupBox1.Controls.Add(this.text_ng);
            this.groupBox1.Controls.Add(this.text_ok);
            this.groupBox1.Controls.Add(this.text_qty);
            this.groupBox1.Controls.Add(this.txt_Vision);
            this.groupBox1.Controls.Add(this.txt_Handler);
            this.groupBox1.Controls.Add(this.txt_3Stage);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txt_sdclog);
            this.groupBox1.Controls.Add(this.txt_fwwrite);
            this.groupBox1.Controls.Add(this.txt_ngcont);
            this.groupBox1.Controls.Add(this.rd_mode4);
            this.groupBox1.Controls.Add(this.rd_mode3);
            this.groupBox1.Controls.Add(this.rd_mode2);
            this.groupBox1.Controls.Add(this.rd_mode1);
            this.groupBox1.Controls.Add(this.bt_modechange);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(764, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 471);
            this.groupBox1.TabIndex = 178;
            this.groupBox1.TabStop = false;
            // 
            // bt_sub_popup
            // 
            this.bt_sub_popup.BackColor = System.Drawing.Color.Lavender;
            this.bt_sub_popup.FlatAppearance.BorderSize = 0;
            this.bt_sub_popup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub_popup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub_popup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bt_sub_popup.Location = new System.Drawing.Point(10, 240);
            this.bt_sub_popup.Name = "bt_sub_popup";
            this.bt_sub_popup.Size = new System.Drawing.Size(233, 85);
            this.bt_sub_popup.TabIndex = 187;
            this.bt_sub_popup.UseVisualStyleBackColor = false;
            this.bt_sub_popup.Visible = false;
            // 
            // bd_version
            // 
            this.bd_version.BackColor = System.Drawing.Color.MidnightBlue;
            this.bd_version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bd_version.Dock = System.Windows.Forms.DockStyle.Top;
            this.bd_version.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_version.ForeColor = System.Drawing.Color.Red;
            this.bd_version.Location = new System.Drawing.Point(3, 441);
            this.bd_version.Name = "bd_version";
            this.bd_version.ReadOnly = true;
            this.bd_version.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bd_version.Size = new System.Drawing.Size(246, 27);
            this.bd_version.TabIndex = 121;
            this.bd_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_tact_time
            // 
            this.text_tact_time.BackColor = System.Drawing.Color.DimGray;
            this.text_tact_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_tact_time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_tact_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_tact_time.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tact_time.ForeColor = System.Drawing.Color.White;
            this.text_tact_time.Location = new System.Drawing.Point(3, 415);
            this.text_tact_time.Name = "text_tact_time";
            this.text_tact_time.ReadOnly = true;
            this.text_tact_time.Size = new System.Drawing.Size(246, 26);
            this.text_tact_time.TabIndex = 102;
            this.text_tact_time.Text = "0.00 sec";
            this.text_tact_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_ng
            // 
            this.text_ng.BackColor = System.Drawing.Color.Crimson;
            this.text_ng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_ng.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_ng.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ng.ForeColor = System.Drawing.Color.White;
            this.text_ng.Location = new System.Drawing.Point(3, 389);
            this.text_ng.Name = "text_ng";
            this.text_ng.ReadOnly = true;
            this.text_ng.Size = new System.Drawing.Size(246, 26);
            this.text_ng.TabIndex = 98;
            this.text_ng.Text = "N G : 0";
            this.text_ng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_ok
            // 
            this.text_ok.BackColor = System.Drawing.Color.ForestGreen;
            this.text_ok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_ok.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_ok.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ok.ForeColor = System.Drawing.Color.White;
            this.text_ok.Location = new System.Drawing.Point(3, 363);
            this.text_ok.Name = "text_ok";
            this.text_ok.ReadOnly = true;
            this.text_ok.Size = new System.Drawing.Size(246, 26);
            this.text_ok.TabIndex = 97;
            this.text_ok.Text = "O K : 0";
            this.text_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_qty
            // 
            this.text_qty.BackColor = System.Drawing.Color.DarkBlue;
            this.text_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_qty.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_qty.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_qty.ForeColor = System.Drawing.Color.White;
            this.text_qty.Location = new System.Drawing.Point(3, 337);
            this.text_qty.Name = "text_qty";
            this.text_qty.ReadOnly = true;
            this.text_qty.Size = new System.Drawing.Size(246, 26);
            this.text_qty.TabIndex = 96;
            this.text_qty.Text = "QTY : 0";
            this.text_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_qty.DoubleClick += new System.EventHandler(this.text_qty_DoubleClick);
            // 
            // txt_Vision
            // 
            this.txt_Vision.BackColor = System.Drawing.Color.Black;
            this.txt_Vision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Vision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Vision.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Vision.Enabled = false;
            this.txt_Vision.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Vision.ForeColor = System.Drawing.Color.White;
            this.txt_Vision.Location = new System.Drawing.Point(3, 315);
            this.txt_Vision.Name = "txt_Vision";
            this.txt_Vision.ReadOnly = true;
            this.txt_Vision.Size = new System.Drawing.Size(246, 22);
            this.txt_Vision.TabIndex = 124;
            this.txt_Vision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Handler
            // 
            this.txt_Handler.BackColor = System.Drawing.Color.Black;
            this.txt_Handler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Handler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Handler.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Handler.Enabled = false;
            this.txt_Handler.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Handler.ForeColor = System.Drawing.Color.White;
            this.txt_Handler.Location = new System.Drawing.Point(3, 293);
            this.txt_Handler.Name = "txt_Handler";
            this.txt_Handler.ReadOnly = true;
            this.txt_Handler.Size = new System.Drawing.Size(246, 22);
            this.txt_Handler.TabIndex = 132;
            this.txt_Handler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_3Stage
            // 
            this.txt_3Stage.BackColor = System.Drawing.Color.Black;
            this.txt_3Stage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_3Stage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_3Stage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_3Stage.Enabled = false;
            this.txt_3Stage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_3Stage.ForeColor = System.Drawing.Color.White;
            this.txt_3Stage.Location = new System.Drawing.Point(3, 271);
            this.txt_3Stage.Name = "txt_3Stage";
            this.txt_3Stage.ReadOnly = true;
            this.txt_3Stage.Size = new System.Drawing.Size(246, 22);
            this.txt_3Stage.TabIndex = 125;
            this.txt_3Stage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(3, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(246, 22);
            this.textBox5.TabIndex = 186;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(3, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(246, 22);
            this.textBox6.TabIndex = 133;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sdclog
            // 
            this.txt_sdclog.BackColor = System.Drawing.Color.Black;
            this.txt_sdclog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sdclog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdclog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_sdclog.Enabled = false;
            this.txt_sdclog.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdclog.ForeColor = System.Drawing.Color.Black;
            this.txt_sdclog.Location = new System.Drawing.Point(3, 205);
            this.txt_sdclog.Name = "txt_sdclog";
            this.txt_sdclog.ReadOnly = true;
            this.txt_sdclog.Size = new System.Drawing.Size(246, 22);
            this.txt_sdclog.TabIndex = 128;
            this.txt_sdclog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_fwwrite
            // 
            this.txt_fwwrite.BackColor = System.Drawing.Color.Black;
            this.txt_fwwrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fwwrite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fwwrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fwwrite.Enabled = false;
            this.txt_fwwrite.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fwwrite.ForeColor = System.Drawing.Color.White;
            this.txt_fwwrite.Location = new System.Drawing.Point(3, 183);
            this.txt_fwwrite.Name = "txt_fwwrite";
            this.txt_fwwrite.ReadOnly = true;
            this.txt_fwwrite.Size = new System.Drawing.Size(246, 22);
            this.txt_fwwrite.TabIndex = 127;
            this.txt_fwwrite.Text = "F/W Write Off";
            this.txt_fwwrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ngcont
            // 
            this.txt_ngcont.BackColor = System.Drawing.Color.Black;
            this.txt_ngcont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ngcont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngcont.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ngcont.Enabled = false;
            this.txt_ngcont.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngcont.ForeColor = System.Drawing.Color.White;
            this.txt_ngcont.Location = new System.Drawing.Point(3, 161);
            this.txt_ngcont.Name = "txt_ngcont";
            this.txt_ngcont.ReadOnly = true;
            this.txt_ngcont.Size = new System.Drawing.Size(246, 22);
            this.txt_ngcont.TabIndex = 126;
            this.txt_ngcont.Text = "NG Continue Off";
            this.txt_ngcont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rd_mode4
            // 
            this.rd_mode4.AutoCheck = false;
            this.rd_mode4.AutoSize = true;
            this.rd_mode4.BackColor = System.Drawing.Color.Black;
            this.rd_mode4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rd_mode4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_mode4.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mode4.ForeColor = System.Drawing.Color.White;
            this.rd_mode4.Location = new System.Drawing.Point(3, 128);
            this.rd_mode4.Name = "rd_mode4";
            this.rd_mode4.Padding = new System.Windows.Forms.Padding(3);
            this.rd_mode4.Size = new System.Drawing.Size(246, 33);
            this.rd_mode4.TabIndex = 93;
            this.rd_mode4.Text = "mode4";
            this.rd_mode4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd_mode4.UseVisualStyleBackColor = false;
            // 
            // rd_mode3
            // 
            this.rd_mode3.AutoCheck = false;
            this.rd_mode3.AutoSize = true;
            this.rd_mode3.BackColor = System.Drawing.Color.Black;
            this.rd_mode3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rd_mode3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_mode3.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mode3.ForeColor = System.Drawing.Color.White;
            this.rd_mode3.Location = new System.Drawing.Point(3, 95);
            this.rd_mode3.Name = "rd_mode3";
            this.rd_mode3.Padding = new System.Windows.Forms.Padding(3);
            this.rd_mode3.Size = new System.Drawing.Size(246, 33);
            this.rd_mode3.TabIndex = 92;
            this.rd_mode3.Text = "mode3";
            this.rd_mode3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd_mode3.UseVisualStyleBackColor = false;
            // 
            // rd_mode2
            // 
            this.rd_mode2.AutoCheck = false;
            this.rd_mode2.AutoSize = true;
            this.rd_mode2.BackColor = System.Drawing.Color.Black;
            this.rd_mode2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rd_mode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_mode2.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mode2.ForeColor = System.Drawing.Color.White;
            this.rd_mode2.Location = new System.Drawing.Point(3, 62);
            this.rd_mode2.Name = "rd_mode2";
            this.rd_mode2.Padding = new System.Windows.Forms.Padding(3);
            this.rd_mode2.Size = new System.Drawing.Size(246, 33);
            this.rd_mode2.TabIndex = 91;
            this.rd_mode2.Text = "mode2";
            this.rd_mode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd_mode2.UseVisualStyleBackColor = false;
            // 
            // rd_mode1
            // 
            this.rd_mode1.AutoCheck = false;
            this.rd_mode1.AutoSize = true;
            this.rd_mode1.BackColor = System.Drawing.Color.Black;
            this.rd_mode1.Checked = true;
            this.rd_mode1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rd_mode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_mode1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mode1.ForeColor = System.Drawing.Color.White;
            this.rd_mode1.Location = new System.Drawing.Point(3, 29);
            this.rd_mode1.Name = "rd_mode1";
            this.rd_mode1.Padding = new System.Windows.Forms.Padding(3);
            this.rd_mode1.Size = new System.Drawing.Size(246, 33);
            this.rd_mode1.TabIndex = 90;
            this.rd_mode1.TabStop = true;
            this.rd_mode1.Text = "mode1";
            this.rd_mode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd_mode1.UseVisualStyleBackColor = false;
            // 
            // bt_modechange
            // 
            this.bt_modechange.BackColor = System.Drawing.Color.Black;
            this.bt_modechange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_modechange.BackgroundImage")));
            this.bt_modechange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_modechange.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_modechange.FlatAppearance.BorderSize = 0;
            this.bt_modechange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modechange.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modechange.ForeColor = System.Drawing.Color.White;
            this.bt_modechange.Location = new System.Drawing.Point(3, 7);
            this.bt_modechange.Name = "bt_modechange";
            this.bt_modechange.Size = new System.Drawing.Size(246, 22);
            this.bt_modechange.TabIndex = 122;
            this.bt_modechange.Text = "MODE CHANGE";
            this.bt_modechange.UseVisualStyleBackColor = false;
            this.bt_modechange.Click += new System.EventHandler(this.bt_modechange_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(1, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 35);
            this.textBox1.TabIndex = 114;
            this.textBox1.Text = "No";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(54, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 35);
            this.textBox2.TabIndex = 115;
            this.textBox2.Text = "Test Item";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Location = new System.Drawing.Point(304, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(378, 35);
            this.textBox3.TabIndex = 116;
            this.textBox3.Text = "Measure Value";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Location = new System.Drawing.Point(683, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(80, 35);
            this.textBox4.TabIndex = 117;
            this.textBox4.Text = "Result";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabCheck
            // 
            this.tabCheck.BackColor = System.Drawing.Color.White;
            this.tabCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCheck.BackgroundImage")));
            this.tabCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCheck.Controls.Add(this.text_check_popup);
            this.tabCheck.Location = new System.Drawing.Point(4, 24);
            this.tabCheck.Name = "tabCheck";
            this.tabCheck.Size = new System.Drawing.Size(1016, 471);
            this.tabCheck.TabIndex = 0;
            this.tabCheck.Text = "Check";
            this.tabCheck.UseVisualStyleBackColor = true;
            // 
            // text_check_popup
            // 
            this.text_check_popup.BackColor = System.Drawing.Color.White;
            this.text_check_popup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_check_popup.Enabled = false;
            this.text_check_popup.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_check_popup.ForeColor = System.Drawing.Color.GhostWhite;
            this.text_check_popup.Location = new System.Drawing.Point(1, 271);
            this.text_check_popup.Name = "text_check_popup";
            this.text_check_popup.ReadOnly = true;
            this.text_check_popup.Size = new System.Drawing.Size(1014, 18);
            this.text_check_popup.TabIndex = 1;
            this.text_check_popup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.tabCheck);
            this.tab.Controls.Add(this.tabMain);
            this.tab.Controls.Add(this.tabSpecUp);
            this.tab.Controls.Add(this.tabSpecview);
            this.tab.Controls.Add(this.tabVision);
            this.tab.Controls.Add(this.tabBoot);
            this.tab.Controls.Add(this.tabDebug);
            this.tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tab.ItemSize = new System.Drawing.Size(100, 20);
            this.tab.Location = new System.Drawing.Point(0, 46);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1024, 499);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 129;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // KI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.bt_mode_key);
            this.Controls.Add(this.bt_esc_key);
            this.Controls.Add(this.bt_st1st2);
            this.Controls.Add(this.bt_next_page);
            this.Controls.Add(this.bt_prev_page);
            this.Controls.Add(this.status_main);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.groupBox_pj_name);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KI GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KI_Manager_FormClosing);
            this.Load += new System.EventHandler(this.KI_Manager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KI_Manager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KI_Manager_MouseMove);
            this.groupBox_pj_name.ResumeLayout(false);
            this.groupBox_pj_name.PerformLayout();
            this.status_main.ResumeLayout(false);
            this.status_main.PerformLayout();
            this.tabDebug.ResumeLayout(false);
            this.tabDebug.PerformLayout();
            this.tabBoot.ResumeLayout(false);
            this.tabBoot.PerformLayout();
            this.tabVision.ResumeLayout(false);
            this.grbox_cam1.ResumeLayout(false);
            this.group_cam1_match.ResumeLayout(false);
            this.group_cam1_match.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_cam1)).EndInit();
            this.grbox_cam2.ResumeLayout(false);
            this.group_cam2_match.ResumeLayout(false);
            this.group_cam2_match.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_cam2)).EndInit();
            this.gb_sol_control.ResumeLayout(false);
            this.gb_sol_control.PerformLayout();
            this.tabSpecview.ResumeLayout(false);
            this.tabSpecview.PerformLayout();
            this.tabSpecUp.ResumeLayout(false);
            this.tabSpecUp.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.pn_result.ResumeLayout(false);
            this.pn_result.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCheck.ResumeLayout(false);
            this.tabCheck.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		public System.Windows.Forms.Timer main_timer;
        public System.Windows.Forms.GroupBox groupBox_pj_name;
		public System.Windows.Forms.Button bt_st1st2;
		public System.Windows.Forms.Button bt_next_page;
		public System.Windows.Forms.Button bt_prev_page;
		public System.Windows.Forms.Button bt_esc_key;
		public System.Windows.Forms.StatusStrip status_main;
		public System.Windows.Forms.ToolStripStatusLabel Close_Label;
		public System.Windows.Forms.ToolStripStatusLabel bd_ver_label;
		public System.Windows.Forms.ToolStripStatusLabel ID_GUI;
		public System.Windows.Forms.ToolStripStatusLabel sen_input;
		public System.Windows.Forms.Button bt_mode_key;
		public System.Windows.Forms.TextBox text_pj_sub;
		public System.Windows.Forms.TextBox text_pj_data;
		public System.Windows.Forms.TextBox text_pj_name;
		public System.IO.Ports.SerialPort bd_serial;
		public System.Windows.Forms.ToolStripStatusLabel Board_Port;
		public System.Windows.Forms.Timer vision_timer;
		public System.Windows.Forms.ToolStripStatusLabel run_mode_label;
		public System.Windows.Forms.ToolStripStatusLabel Camera_conn;
		public System.IO.Ports.SerialPort stage_serial;
		public System.Windows.Forms.ToolStripStatusLabel Stage_Port;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		public System.Windows.Forms.TabPage tabDebug;
		public System.Windows.Forms.TextBox text_log;
		private System.Windows.Forms.TextBox textBox7;
		public System.Windows.Forms.TabPage tabBoot;
		public System.Windows.Forms.Button bt_fw_reload;
		public System.Windows.Forms.Button bt_full_erase;
		public System.Windows.Forms.Button bt_down_fw;
		public System.Windows.Forms.TextBox text_fw;
		public System.Windows.Forms.TabPage tabVision;
		public System.Windows.Forms.Button bt_vision_setup;
		public System.Windows.Forms.GroupBox grbox_cam1;
		public System.Windows.Forms.TextBox text_t_dist1;
		public System.Windows.Forms.TextBox text_y_dist1;
		public System.Windows.Forms.TextBox text_x_dist1;
		public OpenCvSharp.UserInterface.PictureBoxIpl disp_cam1;
		public System.Windows.Forms.GroupBox grbox_cam2;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox text_t_dist2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox text_y_dist2;
		public System.Windows.Forms.TextBox text_x_dist2;
		public OpenCvSharp.UserInterface.PictureBoxIpl disp_cam2;
		private System.Windows.Forms.GroupBox gb_sol_control;
		public System.Windows.Forms.Button bt_load_center;
		public System.Windows.Forms.TextBox text_t_jog;
		public System.Windows.Forms.TextBox text_y_jog;
		public System.Windows.Forms.Button bt_x_jog_p;
		public System.Windows.Forms.TextBox text_x_jog;
		public System.Windows.Forms.Button bt_y_jog_p;
		public System.Windows.Forms.Button bt_x_jog_n;
		public System.Windows.Forms.TextBox text_loc_y;
		public System.Windows.Forms.Button bt_t_jog_n;
		public System.Windows.Forms.Button bt_t_jog_p;
		public System.Windows.Forms.Button bt_y_jog_n;
		public System.Windows.Forms.TextBox text_loc_t;
		public System.Windows.Forms.TextBox text_loc_x;
		public System.Windows.Forms.Button bt_all_home;
		public System.Windows.Forms.Button bt_y_home;
		public System.Windows.Forms.Button bt_all_center;
		public System.Windows.Forms.Button bt_x_home;
		public System.Windows.Forms.Button bt_t_home;
		public System.Windows.Forms.TextBox text_os_dx;
		public System.Windows.Forms.Button by_stage_center_save;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Button bt_autoalign;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.Button bt_led_save;
		public System.Windows.Forms.TextBox text_os_dy;
		public System.Windows.Forms.Button bt_t_center;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.TextBox text_led4;
		public System.Windows.Forms.Button bt_align_est;
		public System.Windows.Forms.TextBox text_os_dt;
		public System.Windows.Forms.TextBox text_sen8;
		public System.Windows.Forms.Button bt_y_center;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.Button bt_sol1;
		public System.Windows.Forms.Button bt_x_center;
		public System.Windows.Forms.TextBox text_led3;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox text_sen7;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.Button bt_sol_all;
		public System.Windows.Forms.TextBox text_led2;
		public System.Windows.Forms.Button bt_sol2;
		public System.Windows.Forms.TextBox text_led1;
		public System.Windows.Forms.TextBox text_sen6;
		public System.Windows.Forms.Button bt_sol3;
		public System.Windows.Forms.TextBox text_sen5;
		public System.Windows.Forms.Button bt_sol4;
		public System.Windows.Forms.TextBox text_sen4;
		public System.Windows.Forms.Button bt_sol5;
		public System.Windows.Forms.TextBox text_sen3;
		public System.Windows.Forms.Button bt_sol6;
		public System.Windows.Forms.TextBox text_sen2;
		public System.Windows.Forms.TextBox text_sen1;
		public System.Windows.Forms.Button bt_sol7;
		public System.Windows.Forms.Button bt_sol8;
		public System.Windows.Forms.TabPage tabSpecview;
		public System.Windows.Forms.Button bt_spec_open;
		public System.Windows.Forms.TextBox text_sv_view_mode;
		public System.Windows.Forms.TextBox text_sv_row9_9;
		public System.Windows.Forms.TextBox text_sv_row9_10;
		public System.Windows.Forms.TextBox text_sv_row9_5;
		public System.Windows.Forms.TextBox text_sv_row9_6;
		public System.Windows.Forms.TextBox text_sv_row9_7;
		public System.Windows.Forms.TextBox text_sv_row9_8;
		public System.Windows.Forms.TextBox text_sv_row9;
		public System.Windows.Forms.TextBox text_sv_row9_1;
		public System.Windows.Forms.TextBox text_sv_row9_2;
		public System.Windows.Forms.TextBox text_sv_row9_3;
		public System.Windows.Forms.TextBox text_sv_row9_4;
		public System.Windows.Forms.TextBox text_sv_row8_9;
		public System.Windows.Forms.TextBox text_sv_row8_10;
		public System.Windows.Forms.TextBox text_sv_row4;
		public System.Windows.Forms.TextBox text_sv_row8_5;
		public System.Windows.Forms.TextBox text_sv_no_4;
		public System.Windows.Forms.TextBox text_sv_row8_6;
		public System.Windows.Forms.TextBox text_sv_no_3;
		public System.Windows.Forms.TextBox text_sv_row8_7;
		public System.Windows.Forms.TextBox text_sv_no_2;
		public System.Windows.Forms.TextBox text_sv_row8_8;
		public System.Windows.Forms.TextBox text_sv_no_1;
		public System.Windows.Forms.TextBox text_sv_row8;
		public System.Windows.Forms.TextBox text_sv_no;
		public System.Windows.Forms.TextBox text_sv_row8_1;
		public System.Windows.Forms.TextBox text_sv_no_8;
		public System.Windows.Forms.TextBox text_sv_row8_2;
		public System.Windows.Forms.TextBox text_sv_no_7;
		public System.Windows.Forms.TextBox text_sv_row8_3;
		public System.Windows.Forms.TextBox text_sv_no_6;
		public System.Windows.Forms.TextBox text_sv_row8_4;
		public System.Windows.Forms.TextBox text_sv_no_5;
		public System.Windows.Forms.TextBox text_sv_row7_9;
		public System.Windows.Forms.TextBox text_sv_no_10;
		public System.Windows.Forms.TextBox text_sv_row7_10;
		public System.Windows.Forms.TextBox text_sv_no_9;
		public System.Windows.Forms.TextBox text_sv_row7_5;
		public System.Windows.Forms.TextBox text_sv_row1_4;
		public System.Windows.Forms.TextBox text_sv_row7_6;
		public System.Windows.Forms.TextBox text_sv_row1_3;
		public System.Windows.Forms.TextBox text_sv_row7_7;
		public System.Windows.Forms.TextBox text_sv_row1_2;
		public System.Windows.Forms.TextBox text_sv_row7_8;
		public System.Windows.Forms.TextBox text_sv_row1_1;
		public System.Windows.Forms.TextBox text_sv_row7;
		public System.Windows.Forms.TextBox text_sv_row1;
		public System.Windows.Forms.TextBox text_sv_row7_1;
		public System.Windows.Forms.TextBox text_sv_row1_8;
		public System.Windows.Forms.TextBox text_sv_row7_2;
		public System.Windows.Forms.TextBox text_sv_row1_7;
		public System.Windows.Forms.TextBox text_sv_row7_3;
		public System.Windows.Forms.TextBox text_sv_row1_6;
		public System.Windows.Forms.TextBox text_sv_row7_4;
		public System.Windows.Forms.TextBox text_sv_row1_5;
		public System.Windows.Forms.TextBox text_sv_row6_9;
		public System.Windows.Forms.TextBox text_sv_row1_10;
		public System.Windows.Forms.TextBox text_sv_row6_10;
		public System.Windows.Forms.TextBox text_sv_row1_9;
		public System.Windows.Forms.TextBox text_sv_row6_5;
		public System.Windows.Forms.TextBox text_sv_row2_4;
		public System.Windows.Forms.TextBox text_sv_row6_6;
		public System.Windows.Forms.TextBox text_sv_row2_3;
		public System.Windows.Forms.TextBox text_sv_row6_7;
		public System.Windows.Forms.TextBox text_sv_row2_2;
		public System.Windows.Forms.TextBox text_sv_row6_8;
		public System.Windows.Forms.TextBox text_sv_row2_1;
		public System.Windows.Forms.TextBox text_sv_row6;
		public System.Windows.Forms.TextBox text_sv_row2;
		public System.Windows.Forms.TextBox text_sv_row6_1;
		public System.Windows.Forms.TextBox text_sv_row2_8;
		public System.Windows.Forms.TextBox text_sv_row6_2;
		public System.Windows.Forms.TextBox text_sv_row2_7;
		public System.Windows.Forms.TextBox text_sv_row6_3;
		public System.Windows.Forms.TextBox text_sv_row2_6;
		public System.Windows.Forms.TextBox text_sv_row6_4;
		public System.Windows.Forms.TextBox text_sv_row2_5;
		public System.Windows.Forms.TextBox text_sv_row5_9;
		public System.Windows.Forms.TextBox text_sv_row2_10;
		public System.Windows.Forms.TextBox text_sv_row5_10;
		public System.Windows.Forms.TextBox text_sv_row2_9;
		public System.Windows.Forms.TextBox text_sv_row5_5;
		public System.Windows.Forms.TextBox text_sv_row3_4;
		public System.Windows.Forms.TextBox text_sv_row5_6;
		public System.Windows.Forms.TextBox text_sv_row3_3;
		public System.Windows.Forms.TextBox text_sv_row5_7;
		public System.Windows.Forms.TextBox text_sv_row3_2;
		public System.Windows.Forms.TextBox text_sv_row5_8;
		public System.Windows.Forms.TextBox text_sv_row3_1;
		public System.Windows.Forms.TextBox text_sv_row5;
		public System.Windows.Forms.TextBox text_sv_row3;
		public System.Windows.Forms.TextBox text_sv_row5_1;
		public System.Windows.Forms.TextBox text_sv_row3_8;
		public System.Windows.Forms.TextBox text_sv_row5_2;
		public System.Windows.Forms.TextBox text_sv_row3_7;
		public System.Windows.Forms.TextBox text_sv_row5_3;
		public System.Windows.Forms.TextBox text_sv_row3_6;
		public System.Windows.Forms.TextBox text_sv_row5_4;
		public System.Windows.Forms.TextBox text_sv_row3_5;
		public System.Windows.Forms.TextBox text_sv_row4_9;
		public System.Windows.Forms.TextBox text_sv_row3_10;
		public System.Windows.Forms.TextBox text_sv_row4_10;
		public System.Windows.Forms.TextBox text_sv_row3_9;
		public System.Windows.Forms.TextBox text_sv_row4_5;
		public System.Windows.Forms.TextBox text_sv_row4_4;
		public System.Windows.Forms.TextBox text_sv_row4_6;
		public System.Windows.Forms.TextBox text_sv_row4_3;
		public System.Windows.Forms.TextBox text_sv_row4_7;
		public System.Windows.Forms.TextBox text_sv_row4_2;
		public System.Windows.Forms.TextBox text_sv_row4_8;
		public System.Windows.Forms.TextBox text_sv_row4_1;
		public System.Windows.Forms.Button button_sv_tp;
		public System.Windows.Forms.Button button_sv_op;
		public System.Windows.Forms.Button button_sv_shb;
		public System.Windows.Forms.Button button_sv_she;
		public System.Windows.Forms.Button button_sv_pt;
		public System.Windows.Forms.Button button_sv_fn;
		public System.Windows.Forms.Button button_sv_pre;
		public System.Windows.Forms.Button button_sv_mode1;
		public System.Windows.Forms.Button button_sv_mode2;
		public System.Windows.Forms.Button button_sv_mode3;
		public System.Windows.Forms.Button button_sv_mode4;
		public System.Windows.Forms.Button button_sv_next;
		public System.Windows.Forms.TabPage tabSpecUp;
		public System.Windows.Forms.CheckBox chb_subname;
		public System.Windows.Forms.CheckBox chb_logunit;
		public System.Windows.Forms.CheckBox chb_fwwrite;
		public System.Windows.Forms.CheckBox chb_ngcont;
		public System.Windows.Forms.Button bt_data_Update;
		public System.Windows.Forms.Button bt_ict_update;
		public System.Windows.Forms.TextBox text_data;
		public System.Windows.Forms.TextBox text_ict;
		public System.Windows.Forms.TabPage tabMain;
		public System.Windows.Forms.Panel pn_result;
		public System.Windows.Forms.TextBox text_popup4;
		public System.Windows.Forms.TextBox text_popup3;
		public System.Windows.Forms.TextBox text_popup1;
		public System.Windows.Forms.TextBox text_popup2;
		public System.Windows.Forms.TextBox text_result;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox bd_version;
		public System.Windows.Forms.TextBox text_tact_time;
		public System.Windows.Forms.TextBox text_ng;
		public System.Windows.Forms.TextBox text_ok;
		public System.Windows.Forms.TextBox text_qty;
		public System.Windows.Forms.TextBox txt_Vision;
		public System.Windows.Forms.TextBox txt_Handler;
		public System.Windows.Forms.TextBox txt_3Stage;
		public System.Windows.Forms.TextBox textBox5;
		public System.Windows.Forms.TextBox textBox6;
		public System.Windows.Forms.TextBox txt_sdclog;
		public System.Windows.Forms.TextBox txt_fwwrite;
		public System.Windows.Forms.TextBox txt_ngcont;
		public System.Windows.Forms.RadioButton rd_mode4;
		public System.Windows.Forms.RadioButton rd_mode3;
		public System.Windows.Forms.RadioButton rd_mode2;
		public System.Windows.Forms.RadioButton rd_mode1;
		public System.Windows.Forms.Button bt_modechange;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.TabPage tabCheck;
		public System.Windows.Forms.TextBox text_check_popup;
		public System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.Button bt_cam2_vfflip;
		private System.Windows.Forms.Button bt_cam2_hfflip;
		private System.Windows.Forms.Button bt_cam1_vfflip;
		private System.Windows.Forms.Button bt_cam1_hfflip;
		public System.Windows.Forms.Button bt_solo_on;
		public System.Windows.Forms.Button bt_dual_on;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.Button bt_cam_change;
		public System.Windows.Forms.Button bt_match_disp;
		public System.Windows.Forms.GroupBox group_cam2_match;
		public System.Windows.Forms.GroupBox group_cam1_match;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button bt_result_align1;
		public System.Windows.Forms.Button bt_result_align2;
		public System.Windows.Forms.TextBox text_boot_ver;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.Button button7;
		public System.Windows.Forms.Button button5;
		public System.Windows.Forms.Button button6;
		public System.Windows.Forms.Button bt_sub_popup;
        public System.Windows.Forms.Timer TimerMelfasCheck;
        public System.Windows.Forms.TextBox text_eep;
        public System.Windows.Forms.Button bt_eep_update;
        public System.Windows.Forms.TextBox text_pmic;
        public System.Windows.Forms.Button bt_pmic_Update;
        public System.Windows.Forms.CheckBox chb_bootApp;
        public System.Windows.Forms.CheckBox chb_EEPROM;
        public System.Windows.Forms.CheckBox chb_TPIC;
        public System.Windows.Forms.CheckBox chb_PMIC;
        public System.Windows.Forms.CheckBox chb_InData;
    }
}

