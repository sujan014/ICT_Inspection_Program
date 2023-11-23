using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KI_GUI._000_Main
{
	public partial class info : Form
	{
		public info()
		{
			InitializeComponent();
		}

		private void bt_close_setup_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void info_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;

			Location = KI.frm.Location;
			Size = new System.Drawing.Size(1024, 600);

			if (Properties.Settings.Default.stage_dir_x == -1) cb_x_rev.Checked = true;
			else if (Properties.Settings.Default.stage_dir_x == 1) cb_x_rev.Checked = false;

			if (Properties.Settings.Default.stage_dir_y == -1) cb_y_rev.Checked = true;
			else if (Properties.Settings.Default.stage_dir_y == 1) cb_y_rev.Checked = false;

			if (Properties.Settings.Default.stage_dir_t == -1) cb_t_rev.Checked = true;
			else if (Properties.Settings.Default.stage_dir_t == 1) cb_t_rev.Checked = false;

			textIP.Text = Properties.Settings.Default.RemoteIP;
			textPORT.Text = Properties.Settings.Default.RemotePORT;
			textNO.Text = Properties.Settings.Default.MachineNO;

			cb_ict_flag.Checked= Properties.Settings.Default.ICT_Spec_Check;
			cb_panel_flag.Checked= Properties.Settings.Default.Panel_Spec_Check;
			cb_data_flag.Checked= Properties.Settings.Default.Data_Check;
			//--------------------------------------------------------------------
			cb_pmic_flag.Checked = Properties.Settings.Default.Pmic_Check;
			cb_eep_flag.Checked = Properties.Settings.Default.Eep_Check;
			//-------------------------------------------------------------------

			text_center_x.Text = Properties.Settings.Default.stage_center_x.ToString();
			text_center_y.Text = Properties.Settings.Default.stage_center_y.ToString();
			text_center_t.Text = Properties.Settings.Default.stage_center_t.ToString();
		}
		private void cb_x_rev_CheckedChanged(object sender, EventArgs e)
		{
			if(cb_x_rev.Checked == true)
			{
				Properties.Settings.Default.stage_dir_x = -1;
			}
			else
			{
				Properties.Settings.Default.stage_dir_x = 1;
			}
			Properties.Settings.Default.Save();
		}

		private void cb_y_rev_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_y_rev.Checked == true)
			{
				Properties.Settings.Default.stage_dir_y = -1;
			}
			else
			{
				Properties.Settings.Default.stage_dir_y = 1;
			}
			Properties.Settings.Default.Save();
		}

		private void cb_t_rev_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_t_rev.Checked == true)
			{
				Properties.Settings.Default.stage_dir_t = -1;
			}
			else
			{
				Properties.Settings.Default.stage_dir_t = 1;
			}
			Properties.Settings.Default.Save();
		}

		private void bt_info_save_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.RemoteIP = textIP.Text;
			Properties.Settings.Default.RemotePORT = textPORT.Text;
			Properties.Settings.Default.MachineNO = textNO.Text;
			Properties.Settings.Default.Save();

			KI.frm.ID_GUI.Text = "Machine No." + Properties.Settings.Default.MachineNO;
		}

		private void cb_ict_flag_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ICT_Spec_Check = cb_ict_flag.Checked;
			Properties.Settings.Default.Save();
			KI.frm.bt_ict_update.Visible = Properties.Settings.Default.ICT_Spec_Check;
			KI.frm.text_ict.Visible = Properties.Settings.Default.ICT_Spec_Check;
		}

		/*private void cb_panel_flag_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Panel_Spec_Check = cb_panel_flag.Checked;
			Properties.Settings.Default.Save();
			KI.frm.bt_panel_update.Visible = Properties.Settings.Default.Panel_Spec_Check;
			KI.frm.text_panel.Visible = Properties.Settings.Default.Panel_Spec_Check;
		}*/ //210514 MCH

		private void cb_data_flag_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Data_Check = cb_data_flag.Checked;
			Properties.Settings.Default.Save();
			KI.frm.bt_data_Update.Visible = Properties.Settings.Default.Data_Check;
			KI.frm.text_data.Visible = Properties.Settings.Default.Data_Check;
		}

        private void cb_pmic_flag_CheckedChanged(object sender, EventArgs e)
        {
			Properties.Settings.Default.Pmic_Check = cb_pmic_flag.Checked;
			Properties.Settings.Default.Save();
			KI.frm.bt_pmic_Update.Visible = Properties.Settings.Default.Pmic_Check;
			KI.frm.text_pmic.Visible = Properties.Settings.Default.Pmic_Check;
		}

        private void cb_eep_flag_CheckedChanged(object sender, EventArgs e)
        {
			Properties.Settings.Default.Eep_Check = cb_eep_flag.Checked;
			Properties.Settings.Default.Save();
			
			KI.frm.bt_eep_update.Visible = Properties.Settings.Default.Eep_Check;
			KI.frm.text_eep.Visible = Properties.Settings.Default.Eep_Check;
		}
    }
}
