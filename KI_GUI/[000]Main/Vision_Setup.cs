using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace KI_GUI._000_Main
{
	public partial class Vision_Setup : Form
	{
		public Vision_Setup()
		{
			InitializeComponent();
		}

		private void bt_close_setup_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Vision_Setup_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;

			Location = KI.frm.Location;
			Size = new System.Drawing.Size(1024, 600);

			if (Properties.Settings.Default.dual_cam == true)
			{
				Ref1_img.ImageIpl = vision.cam1_ref_dut;
				Ref2_img.ImageIpl = vision.cam1_ref_olb;
				Ref3_img.ImageIpl = vision.cam2_ref_dut;
				Ref4_img.ImageIpl = vision.cam2_ref_olb;
				bt_cam1_disp.Visible = true;
				bt_cam2_disp.Visible = true;
				groupBox1.Visible = true;
				groupBox2.Visible = true;
			}
			else
			{
				Ref1_img.ImageIpl = vision.cam1_ref_dut;
				Ref2_img.ImageIpl = vision.cam1_ref_olb;
				Setup_pic.ImageIpl = vision.cam1_save;

				bt_cam1_disp.Visible = true;
				bt_cam2_disp.Visible = false;
				groupBox1.Visible = true;
				groupBox2.Visible = false;
			}

			tbW1.Text = vision.cam1_ref_dut.Width.ToString();
			tbH1.Text = vision.cam1_ref_dut.Height.ToString();
			tbW2.Text = vision.cam1_ref_olb.Width.ToString();
			tbH2.Text = vision.cam1_ref_olb.Height.ToString();
			tbW3.Text = vision.cam2_ref_dut.Width.ToString();
			tbH3.Text = vision.cam2_ref_dut.Height.ToString();
			tbW4.Text = vision.cam2_ref_olb.Width.ToString();
			tbH4.Text = vision.cam2_ref_olb.Height.ToString();

			tbDistX1.Text = Properties.Settings.Default.Dist_X1.ToString();
			tbDistY1.Text = Properties.Settings.Default.Dist_Y1.ToString();

			tbDistX2.Text = Properties.Settings.Default.Dist_X2.ToString();
			tbDistY2.Text = Properties.Settings.Default.Dist_Y2.ToString();
		}

		private System.Drawing.Point mousePoint;

		private void Vision_Setup_MouseDown(object sender, MouseEventArgs e)
		{
			mousePoint = new System.Drawing.Point(e.X, e.Y);
		}

		private void Vision_Setup_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				int x = mousePoint.X - e.X;
				int y = mousePoint.Y - e.Y;
				Location = new System.Drawing.Point(this.Left - x, this.Top - y);
			}
		}
		bool disp1_setup = false;
		bool disp2_setup = false;
		private void bt_cam1_disp_Click(object sender, EventArgs e)
		{
			rectdisp1 = new Rectangle(0, 0, 0, 0);
			rectdisp2 = new Rectangle(0, 0, 0, 0);
			Setup_pic.ImageIpl = vision.cam1_save;
			disp1_setup = true;
			disp2_setup = false;
			Refresh();
		}

		private void bt_cam2_disp_Click(object sender, EventArgs e)
		{
			rectdisp1 = new Rectangle(0, 0, 0, 0);
			rectdisp2 = new Rectangle(0, 0, 0, 0);
			Setup_pic.ImageIpl = vision.cam2_save;
			disp1_setup = false;
			disp2_setup = true;
			Refresh();
		}
				

		private Rectangle rectdisp1 = new Rectangle(0, 0, 0, 0);
		private Rectangle rectdisp2 = new Rectangle(0, 0, 0, 0);
		
		private void Setup_pic_Click(object sender, EventArgs e)
		{
		}
		private void Setup_pic_MouseDown(object sender, MouseEventArgs e)
		{
			if ((disp1_setup == false) && (disp2_setup == false)) return;

			if (e.Button == MouseButtons.Left)
			{
				rectdisp1 = new Rectangle(e.X, e.Y, 0, 0);
				this.Refresh();
			}
			else if (e.Button == MouseButtons.Right)
			{
				rectdisp2 = new Rectangle(e.X, e.Y, 0, 0);
				this.Refresh();
			}
		}

		private void Setup_pic_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if ((disp1_setup == false) && (disp2_setup == false)) return;

				if (e.Button == MouseButtons.Left)
				{
					rectdisp1 = new Rectangle(rectdisp1.Left, rectdisp1.Top,
					Math.Min(e.X - rectdisp1.Left, Setup_pic.ClientRectangle.Width - rectdisp1.Left),
					Math.Min(e.Y - rectdisp1.Top, Setup_pic.ClientRectangle.Height - rectdisp1.Top));
					this.Refresh();
					if (disp1_setup == true)
					{
						tbX1.Text = rectdisp1.X.ToString();
						tbY1.Text = rectdisp1.Y.ToString();
						tbW1.Text = rectdisp1.Width.ToString();
						tbH1.Text = rectdisp1.Height.ToString();
						tbDistX1.Text = (rectdisp1.X - rectdisp2.X).ToString();
						tbDistY1.Text = (rectdisp1.Y - rectdisp2.Y).ToString();
						if ((rectdisp1.X != 0) && (rectdisp1.Y != 0) && (rectdisp1.Width != 0) && (rectdisp1.Height != 0))
						{
							vision.roi = new Mat(vision.cam1_save, new Rect(rectdisp1.X, rectdisp1.Y, rectdisp1.Width, rectdisp1.Height));
							Ref1_img.ImageIpl = vision.roi;
						}
					}
					else if (disp2_setup == true)
					{
						tbX3.Text = rectdisp1.X.ToString();
						tbY3.Text = rectdisp1.Y.ToString();
						tbW3.Text = rectdisp1.Width.ToString();
						tbH3.Text = rectdisp1.Height.ToString();
						tbDistX2.Text = (rectdisp1.X - rectdisp2.X).ToString();
						tbDistY2.Text = (rectdisp1.Y - rectdisp2.Y).ToString();
						if ((rectdisp1.X != 0)&& (rectdisp1.Y != 0) && (rectdisp1.Width != 0) && (rectdisp1.Height != 0))
						{
							vision.roi = new Mat(vision.cam2_save, new Rect(rectdisp1.X, rectdisp1.Y, rectdisp1.Width, rectdisp1.Height));
							Ref3_img.ImageIpl = vision.roi;
						}
					}
				}
				else if (e.Button == MouseButtons.Right)
				{
					rectdisp2 = new Rectangle(rectdisp2.Left, rectdisp2.Top,
					Math.Min(e.X - rectdisp2.Left, Setup_pic.ClientRectangle.Width - rectdisp2.Left),
					Math.Min(e.Y - rectdisp2.Top, Setup_pic.ClientRectangle.Height - rectdisp2.Top));
					this.Refresh();
					if (disp1_setup == true)
					{
						tbX2.Text = rectdisp2.X.ToString();
						tbY2.Text = rectdisp2.Y.ToString();
						tbW2.Text = rectdisp2.Width.ToString();
						tbH2.Text = rectdisp2.Height.ToString();
						tbDistX1.Text = (rectdisp1.X - rectdisp2.X).ToString();
						tbDistY1.Text = (rectdisp1.Y - rectdisp2.Y).ToString();
						if (((rectdisp2.X != 0) && (rectdisp2.Y != 0) && (rectdisp2.Width != 0) && (rectdisp2.Height != 0)))
						{
							vision.roi = new Mat(vision.cam1_save, new Rect(rectdisp2.X, rectdisp2.Y, rectdisp2.Width, rectdisp2.Height));
							Ref2_img.ImageIpl = vision.roi;
						}
					}
					else if (disp2_setup == true)
					{
						tbX4.Text = rectdisp2.X.ToString();
						tbY4.Text = rectdisp2.Y.ToString();
						tbW4.Text = rectdisp2.Width.ToString();
						tbH4.Text = rectdisp2.Height.ToString();
						tbDistX2.Text = (rectdisp1.X - rectdisp2.X).ToString();
						tbDistY2.Text = (rectdisp1.Y - rectdisp2.Y).ToString();
						if (((rectdisp2.X != 0) && (rectdisp2.Y != 0) && (rectdisp2.Width != 0) && (rectdisp2.Height != 0)))
						{
							vision.roi = new Mat(vision.cam2_save, new Rect(rectdisp2.X, rectdisp2.Y, rectdisp2.Width, rectdisp2.Height));
							Ref4_img.ImageIpl = vision.roi;
						}
					}
				}
			}
			catch
			{

			}
		}

		private void Setup_pic_Paint(object sender, PaintEventArgs e)
		{
			if ((disp1_setup == false) && (disp2_setup == false)) return;

			using (Pen pen = new Pen(Color.Red, 2))
			{
				e.Graphics.DrawRectangle(pen, rectdisp1);				
			}
			using (Pen pen = new Pen(Color.Blue, 2))
			{
				e.Graphics.DrawRectangle(pen, rectdisp2);
			}
		}

		private void bt_cam1_ref_save_Click(object sender, EventArgs e)
		{
			if (disp1_setup == true)
			{
				vision.dut = new Mat(vision.cam1_save, new Rect(rectdisp1.X, rectdisp1.Y, rectdisp1.Width, rectdisp1.Height));
				vision.olb = new Mat(vision.cam1_save, new Rect(rectdisp2.X, rectdisp2.Y, rectdisp2.Width, rectdisp2.Height));

				if (vision.dut.Empty() == true || vision.olb.Empty() == true)
				{
					MessageBox.Show("Not Select");
				}
				else
				{
					vision.cam_ref_save(1, vision.dut, vision.olb);

					Properties.Settings.Default.Dist_X1 = rectdisp1.X - rectdisp2.X;
					Properties.Settings.Default.Dist_Y1 = rectdisp1.Y - rectdisp2.Y;
					Properties.Settings.Default.Save();
					MessageBox.Show("Camera1 Reference Save OK");
				}
			}
		}

		private void bt_cam2_ref_save_Click(object sender, EventArgs e)
		{
			if (disp2_setup == true)
			{
				vision.dut = new Mat(vision.cam2_save, new Rect(rectdisp1.X, rectdisp1.Y, rectdisp1.Width, rectdisp1.Height));
				vision.olb = new Mat(vision.cam2_save, new Rect(rectdisp2.X, rectdisp2.Y, rectdisp2.Width, rectdisp2.Height));
				if (vision.dut.Empty() == true || vision.olb.Empty() == true)
				{
					MessageBox.Show("Not Select");
				}
				else
				{
					vision.cam_ref_save(2, vision.dut, vision.olb);
					Properties.Settings.Default.Dist_X2 = rectdisp1.X - rectdisp2.X;
					Properties.Settings.Default.Dist_Y2 = rectdisp1.Y - rectdisp2.Y;
					Properties.Settings.Default.Save();
					MessageBox.Show("Camera2 Reference Save OK");
				}
			}
		}
	}
}
