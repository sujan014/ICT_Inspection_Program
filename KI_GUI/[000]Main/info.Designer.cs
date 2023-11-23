namespace KI_GUI._000_Main
{
	partial class info
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_close_setup = new System.Windows.Forms.Button();
            this.cb_x_rev = new System.Windows.Forms.CheckBox();
            this.cb_y_rev = new System.Windows.Forms.CheckBox();
            this.cb_t_rev = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_info_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPORT = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textNO = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_ict_flag = new System.Windows.Forms.CheckBox();
            this.cb_data_flag = new System.Windows.Forms.CheckBox();
            this.cb_panel_flag = new System.Windows.Forms.CheckBox();
            this.text_center_t = new System.Windows.Forms.TextBox();
            this.text_center_y = new System.Windows.Forms.TextBox();
            this.text_center_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_pmic_flag = new System.Windows.Forms.CheckBox();
            this.cb_eep_flag = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 578);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1024, 22);
            this.textBox2.TabIndex = 68;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1024, 50);
            this.textBox1.TabIndex = 67;
            this.textBox1.Text = "Info Setting Window";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_close_setup
            // 
            this.bt_close_setup.BackColor = System.Drawing.Color.Maroon;
            this.bt_close_setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close_setup.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close_setup.ForeColor = System.Drawing.Color.White;
            this.bt_close_setup.Location = new System.Drawing.Point(930, 57);
            this.bt_close_setup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_close_setup.Name = "bt_close_setup";
            this.bt_close_setup.Size = new System.Drawing.Size(82, 42);
            this.bt_close_setup.TabIndex = 69;
            this.bt_close_setup.Text = "Close";
            this.bt_close_setup.UseVisualStyleBackColor = false;
            this.bt_close_setup.Click += new System.EventHandler(this.bt_close_setup_Click);
            // 
            // cb_x_rev
            // 
            this.cb_x_rev.AutoSize = true;
            this.cb_x_rev.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_x_rev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cb_x_rev.Location = new System.Drawing.Point(15, 21);
            this.cb_x_rev.Name = "cb_x_rev";
            this.cb_x_rev.Size = new System.Drawing.Size(263, 36);
            this.cb_x_rev.TabIndex = 70;
            this.cb_x_rev.Text = "X-Axis Reverse Move";
            this.cb_x_rev.UseVisualStyleBackColor = true;
            this.cb_x_rev.CheckedChanged += new System.EventHandler(this.cb_x_rev_CheckedChanged);
            // 
            // cb_y_rev
            // 
            this.cb_y_rev.AutoSize = true;
            this.cb_y_rev.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_y_rev.Location = new System.Drawing.Point(15, 55);
            this.cb_y_rev.Name = "cb_y_rev";
            this.cb_y_rev.Size = new System.Drawing.Size(259, 36);
            this.cb_y_rev.TabIndex = 71;
            this.cb_y_rev.Text = "Y-Axis Reverse Move";
            this.cb_y_rev.UseVisualStyleBackColor = true;
            this.cb_y_rev.CheckedChanged += new System.EventHandler(this.cb_y_rev_CheckedChanged);
            // 
            // cb_t_rev
            // 
            this.cb_t_rev.AutoSize = true;
            this.cb_t_rev.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_t_rev.Location = new System.Drawing.Point(16, 87);
            this.cb_t_rev.Name = "cb_t_rev";
            this.cb_t_rev.Size = new System.Drawing.Size(258, 36);
            this.cb_t_rev.TabIndex = 72;
            this.cb_t_rev.Text = "T-Axis Reverse Move";
            this.cb_t_rev.UseVisualStyleBackColor = true;
            this.cb_t_rev.CheckedChanged += new System.EventHandler(this.cb_t_rev_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_x_rev);
            this.groupBox1.Controls.Add(this.cb_t_rev);
            this.groupBox1.Controls.Add(this.cb_y_rev);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 131);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_info_save);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textPORT);
            this.groupBox2.Controls.Add(this.textIP);
            this.groupBox2.Controls.Add(this.textNO);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 128);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            // 
            // bt_info_save
            // 
            this.bt_info_save.BackColor = System.Drawing.Color.Maroon;
            this.bt_info_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info_save.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_info_save.ForeColor = System.Drawing.Color.White;
            this.bt_info_save.Location = new System.Drawing.Point(354, 17);
            this.bt_info_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_info_save.Name = "bt_info_save";
            this.bt_info_save.Size = new System.Drawing.Size(76, 101);
            this.bt_info_save.TabIndex = 75;
            this.bt_info_save.Text = "Save";
            this.bt_info_save.UseVisualStyleBackColor = false;
            this.bt_info_save.Click += new System.EventHandler(this.bt_info_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remote IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Machine No.";
            // 
            // textPORT
            // 
            this.textPORT.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPORT.Location = new System.Drawing.Point(166, 86);
            this.textPORT.Name = "textPORT";
            this.textPORT.Size = new System.Drawing.Size(184, 33);
            this.textPORT.TabIndex = 2;
            this.textPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.Location = new System.Drawing.Point(166, 51);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(184, 33);
            this.textIP.TabIndex = 1;
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNO
            // 
            this.textNO.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNO.Location = new System.Drawing.Point(166, 17);
            this.textNO.Name = "textNO";
            this.textNO.Size = new System.Drawing.Size(184, 33);
            this.textNO.TabIndex = 0;
            this.textNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_ict_flag);
            this.groupBox3.Controls.Add(this.cb_data_flag);
            this.groupBox3.Controls.Add(this.cb_panel_flag);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 127);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            // 
            // cb_ict_flag
            // 
            this.cb_ict_flag.AutoSize = true;
            this.cb_ict_flag.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ict_flag.Location = new System.Drawing.Point(16, 18);
            this.cb_ict_flag.Name = "cb_ict_flag";
            this.cb_ict_flag.Size = new System.Drawing.Size(293, 36);
            this.cb_ict_flag.TabIndex = 70;
            this.cb_ict_flag.Text = "ICT Spec Update Enable";
            this.cb_ict_flag.UseVisualStyleBackColor = true;
            this.cb_ict_flag.CheckedChanged += new System.EventHandler(this.cb_ict_flag_CheckedChanged);
            // 
            // cb_data_flag
            // 
            this.cb_data_flag.AutoSize = true;
            this.cb_data_flag.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_data_flag.Location = new System.Drawing.Point(16, 82);
            this.cb_data_flag.Name = "cb_data_flag";
            this.cb_data_flag.Size = new System.Drawing.Size(252, 36);
            this.cb_data_flag.TabIndex = 72;
            this.cb_data_flag.Text = "Data Update Enable";
            this.cb_data_flag.UseVisualStyleBackColor = true;
            this.cb_data_flag.CheckedChanged += new System.EventHandler(this.cb_data_flag_CheckedChanged);
            // 
            // cb_panel_flag
            // 
            this.cb_panel_flag.Location = new System.Drawing.Point(0, 0);
            this.cb_panel_flag.Name = "cb_panel_flag";
            this.cb_panel_flag.Size = new System.Drawing.Size(104, 24);
            this.cb_panel_flag.TabIndex = 73;
            // 
            // text_center_t
            // 
            this.text_center_t.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_center_t.Location = new System.Drawing.Point(190, 85);
            this.text_center_t.Name = "text_center_t";
            this.text_center_t.ReadOnly = true;
            this.text_center_t.Size = new System.Drawing.Size(108, 33);
            this.text_center_t.TabIndex = 75;
            this.text_center_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_center_y
            // 
            this.text_center_y.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_center_y.Location = new System.Drawing.Point(190, 50);
            this.text_center_y.Name = "text_center_y";
            this.text_center_y.ReadOnly = true;
            this.text_center_y.Size = new System.Drawing.Size(108, 33);
            this.text_center_y.TabIndex = 74;
            this.text_center_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_center_x
            // 
            this.text_center_x.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_center_x.Location = new System.Drawing.Point(190, 16);
            this.text_center_x.Name = "text_center_x";
            this.text_center_x.ReadOnly = true;
            this.text_center_x.Size = new System.Drawing.Size(108, 33);
            this.text_center_x.TabIndex = 73;
            this.text_center_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 32);
            this.label4.TabIndex = 78;
            this.label4.Text = "Stage Center T";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 77;
            this.label5.Text = "Stage Center Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 76;
            this.label6.Text = "Stage Center X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.text_center_x);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.text_center_y);
            this.groupBox4.Controls.Add(this.text_center_t);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(456, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 131);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            // 
            // cb_pmic_flag
            // 
            this.cb_pmic_flag.AutoSize = true;
            this.cb_pmic_flag.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pmic_flag.Location = new System.Drawing.Point(456, 195);
            this.cb_pmic_flag.Name = "cb_pmic_flag";
            this.cb_pmic_flag.Size = new System.Drawing.Size(252, 36);
            this.cb_pmic_flag.TabIndex = 74;
            this.cb_pmic_flag.Text = "Pmic Update Enable";
            this.cb_pmic_flag.UseVisualStyleBackColor = true;
            this.cb_pmic_flag.CheckedChanged += new System.EventHandler(this.cb_pmic_flag_CheckedChanged);
            // 
            // cb_eep_flag
            // 
            this.cb_eep_flag.AutoSize = true;
            this.cb_eep_flag.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_eep_flag.Location = new System.Drawing.Point(456, 236);
            this.cb_eep_flag.Name = "cb_eep_flag";
            this.cb_eep_flag.Size = new System.Drawing.Size(239, 36);
            this.cb_eep_flag.TabIndex = 75;
            this.cb_eep_flag.Text = "Eep Update Enable";
            this.cb_eep_flag.UseVisualStyleBackColor = true;
            this.cb_eep_flag.CheckedChanged += new System.EventHandler(this.cb_eep_flag_CheckedChanged);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.cb_eep_flag);
            this.Controls.Add(this.cb_pmic_flag);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_close_setup);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button bt_close_setup;
		private System.Windows.Forms.CheckBox cb_x_rev;
		private System.Windows.Forms.CheckBox cb_y_rev;
		private System.Windows.Forms.CheckBox cb_t_rev;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textPORT;
		private System.Windows.Forms.TextBox textIP;
		private System.Windows.Forms.TextBox textNO;
		private System.Windows.Forms.Button bt_info_save;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cb_ict_flag;
		private System.Windows.Forms.CheckBox cb_data_flag;
		private System.Windows.Forms.CheckBox cb_panel_flag;
		private System.Windows.Forms.TextBox text_center_t;
		private System.Windows.Forms.TextBox text_center_y;
		private System.Windows.Forms.TextBox text_center_x;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb_pmic_flag;
        private System.Windows.Forms.CheckBox cb_eep_flag;
    }
}