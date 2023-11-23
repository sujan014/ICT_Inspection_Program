using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Windows.Forms;
using System.Drawing;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Diagnostics;

namespace KI_GUI
{
	class vision
	{
		public static bool vision_conn = false;
		public static VideoCapture cam1;
		public static VideoCapture cam2;
		public static Mat cam1_img = new Mat();
		public static Mat cam2_img = new Mat();

		public static Mat cam1_save = new Mat();
		public static Mat cam2_save = new Mat();
		public static Mat cam_compare_dut = new Mat();
		public static Mat cam_compare_olb = new Mat();
		public static Mat cam_disp = new Mat();

		public static Mat cam1_ref_dut = new Mat();
		public static Mat cam1_ref_olb = new Mat();

		public static Mat cam2_ref_dut = new Mat();
		public static Mat cam2_ref_olb = new Mat();

		public static Mat roi = new Mat();
		public static Mat dut = new Mat();
		public static Mat olb = new Mat();

		public static int x1_dist = 0;
		public static int y1_dist = 0;
		public static int t1_dist = 0;
		public static int x2_dist = 0;
		public static int y2_dist = 0;
		public static int t2_dist = 0;
		
		public static int x1_pulse = 0;
		public static int y1_pulse = 0;
		public static int t1_pulse = 0;
		public static int x2_pulse = 0;
		public static int y2_pulse = 0;
		public static int t2_pulse = 0;
		
		public static int x1_margin = 5 * stage.pixel_pulse_x;
		public static int y1_margin = 20 * stage.pixel_pulse_y;
		public static int t1_margin = 5 * stage.pixel_pulse_t;
		public static int x2_margin = 20 * stage.pixel_pulse_x;
		public static int y2_margin = 5 * stage.pixel_pulse_y;
		public static int t2_margin = 5 * stage.pixel_pulse_t;


		public static Stopwatch align_watch = new Stopwatch();

		public struct CamMatchResult
		{
			public double minval;
			public double maxval;
			public OpenCvSharp.Point minloc;
			public OpenCvSharp.Point maxloc;
			public Mat rst;
		};
		public static CamMatchResult cam1_result_dut = new CamMatchResult();
		public static CamMatchResult cam2_result_dut = new CamMatchResult();
		public static CamMatchResult cam1_result_olb= new CamMatchResult();
		public static CamMatchResult cam2_result_olb = new CamMatchResult();

		static double threshold = 0.8;

		public static void solo_vision_cam_setup()
		{
			try
			{
				KI.frm.grbox_cam1.Visible = true;
				KI.frm.grbox_cam1.Location = new System.Drawing.Point(255, -6);
				KI.frm.grbox_cam1.Enabled = true;

				KI.frm.grbox_cam2.Visible = false;
				KI.frm.grbox_cam2.Enabled = false;
				KI.frm.Refresh();

				cam1 = new VideoCapture(0);
				cam1.FrameWidth = 640;
				cam1.FrameHeight = 480;
				if (cam1.IsOpened() == true) cam1.Read(cam1_img);

				if ((cam1.IsOpened() == true))
				{
					vision_conn = true;
					KI.frm.Camera_conn.BackColor = Color.Green;
					KI.frm.Camera_conn.Text = "Solo Camera";

				}
				else
				{
					vision_conn = false;
					KI.frm.Camera_conn.BackColor = Color.Red;
					KI.frm.Camera_conn.Text = "Solo Camera";
				}
			}
			catch
			{
				MessageBox.Show("Cam Connect Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

				KI.frm.vision_timer.Stop();
			}
		}
		public static void dual_vision_cam_setup()
		{
			try
			{
				KI.frm.grbox_cam1.Location = new System.Drawing.Point(2, -6);
				KI.frm.grbox_cam1.Visible = true;
				KI.frm.grbox_cam1.Enabled = true;

				KI.frm.grbox_cam2.Location = new System.Drawing.Point(509, -6);
				KI.frm.grbox_cam2.Visible = true;
				KI.frm.grbox_cam2.Enabled = true;

				KI.frm.Refresh();

				cam1 = new VideoCapture(0);
				cam1.FrameWidth = 640;
				cam1.FrameHeight = 480;
				if (cam1.IsOpened() == true) cam1.Read(cam1_img);

				cam2 = new VideoCapture(1);
				cam2.FrameWidth = 640;
				cam2.FrameHeight = 480;
				if (cam2.IsOpened() == true) cam2.Read(cam2_img);

				if ((cam1.IsOpened() == true) && (cam2.IsOpened() == true))
				{
					vision_conn = true;
					KI.frm.Camera_conn.BackColor = Color.Green;
					KI.frm.Camera_conn.Text = "Dual Camera";
				}
				else
				{
					vision_conn = false;
					KI.frm.Camera_conn.BackColor = Color.Red;
					KI.frm.Camera_conn.Text = "Dual Camera";
				}
			}
			catch
			{
				MessageBox.Show("Cam Connect Fail", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//KI.frm.vision_timer.Stop();
			}
		}
		public static void vision_cam_init()
		{
			vision_checkbox_init();

			if (cam1 != null) cam1.Dispose();
			if (cam2 != null) cam2.Dispose();

			if (Properties.Settings.Default.dual_cam == true)
			{
				dual_vision_cam_setup();
				dual_read_ref_img();
			}
			else
			{
				solo_vision_cam_setup();
				solo_read_ref_img();
			}
		
		}
		static void vision_checkbox_init()
		{
			if(Properties.Settings.Default.dual_cam == true)
			{
				//KI.frm.text_Label_Cam.Text = "Dual Camera";
				KI.frm.bt_solo_on.Visible = true;
				KI.frm.bt_dual_on.Visible = false;
			}
			else
			{
				//KI.frm.text_Label_Cam.Text = "Single Camera";
				KI.frm.bt_solo_on.Visible = false;
				KI.frm.bt_dual_on.Visible = true;
			}


			if (Properties.Settings.Default.match_disp == true)
			{
				KI.frm.group_cam1_match.Visible = true;
				KI.frm.group_cam2_match.Visible = true;
				KI.frm.bt_match_disp.Text = "ON";
			}
			else
			{
				KI.frm.group_cam1_match.Visible = false;
				KI.frm.group_cam2_match.Visible = false;
				KI.frm.bt_match_disp.Text = "OFF";
			}
		}
		public static void vision_timer_init()
		{
			KI.frm.vision_timer.Stop();
			KI.frm.vision_timer.Interval = 33;
			KI.frm.vision_timer.Tick += new EventHandler(vision_disp);
			KI.frm.vision_timer.Start();
		}
		
		public static void always_aling_estimation()
		{
			if (Properties.Settings.Default.match_disp == true)
			{
				t1_dist = (y2_dist - y1_dist);
				t2_dist = (y1_dist - y2_dist);

				x1_pulse = x1_dist * stage.pixel_pulse_x;
				y1_pulse = y1_dist * stage.pixel_pulse_y;
				t1_pulse = t1_dist * stage.pixel_pulse_t;
				x2_pulse = x2_dist * stage.pixel_pulse_x;
				y2_pulse = y2_dist * stage.pixel_pulse_y;
				t2_pulse = t2_dist * stage.pixel_pulse_t;
				
				KI.frm.text_x_dist1.Text = (x1_pulse).ToString();
				KI.frm.text_y_dist1.Text = (y1_pulse).ToString();
				KI.frm.text_t_dist1.Text = (t1_pulse).ToString();
				KI.frm.text_x_dist2.Text = (x2_pulse).ToString();
				KI.frm.text_y_dist2.Text = (y2_pulse).ToString();
				KI.frm.text_t_dist2.Text = (t2_pulse).ToString();

				KI.frm.text_os_dx.Text = (x1_pulse).ToString();
				KI.frm.text_os_dy.Text = (y1_pulse).ToString();
				KI.frm.text_os_dt.Text = (t1_pulse).ToString();
			}
		}
		public static bool oneshot_aling_estimation()
		{
			if (Properties.Settings.Default.dual_cam == true)
			{
				if (Properties.Settings.Default.cam_change == false)
				{
					if (cam1.IsOpened() == true) cam1.Read(cam1_img);
					if (cam2.IsOpened() == true) cam2.Read(cam2_img);
				}
				else
				{
					if (cam1.IsOpened() == true) cam1.Read(cam2_img);
					if (cam2.IsOpened() == true) cam2.Read(cam1_img);
				}
				
				image_flip_cam1();
				image_template_cam1_onshot();

				image_flip_cam2();
				image_template_cam2_onshot();
				
				t1_dist = (y1_dist - y2_dist);
				t2_dist = (y2_dist - y1_dist);

				x1_pulse = x1_dist * stage.pixel_pulse_x;
				y1_pulse = y1_dist * stage.pixel_pulse_y;
				t1_pulse = t1_dist * stage.pixel_pulse_t;

				x2_pulse = x2_dist * stage.pixel_pulse_x;
				y2_pulse = y2_dist * stage.pixel_pulse_y;
				t2_pulse = t2_dist * stage.pixel_pulse_t;
												
				KI.frm.text_os_dx.Text = (x1_pulse).ToString();
				KI.frm.text_os_dy.Text = (y1_pulse).ToString();
				KI.frm.text_os_dt.Text = (t1_pulse).ToString();

				if (x1_dist >= 9999 || x2_dist >= 9999 || y1_dist >= 9999 || y2_dist >= 9999)
				{
					return false;
				}

				return true;
			}
			else
			{
				if (cam1.IsOpened() == true) cam1.Read(cam1_img);

				image_flip_cam1();
				image_template_cam1_onshot();
				
				x1_pulse = x1_dist * stage.pixel_pulse_x;
				y1_pulse = y1_dist * stage.pixel_pulse_y;
				t1_pulse = t1_dist * stage.pixel_pulse_t;

				KI.frm.text_os_dx.Text = (x1_pulse).ToString();
				KI.frm.text_os_dy.Text = (y1_pulse).ToString();
				KI.frm.text_os_dt.Text = (t1_pulse).ToString();

				if (x1_dist >= 9999 || y1_dist >= 9999)
				{
					return false;
				}

				return true;
			}
		}
		static void image_flip_cam1()
		{
			if ((Properties.Settings.Default.cam1_hflip == true) && (Properties.Settings.Default.cam1_vflip == true))
			{
				cam_compare_dut = cam1_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam_compare_olb = cam1_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam1_save = cam1_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam_disp = cam1_img.Flip(FlipMode.XY); //verical,horizontal flip
			}
			else if ((Properties.Settings.Default.cam1_hflip == true) && (Properties.Settings.Default.cam1_vflip == false))
			{
				cam_compare_dut = cam1_img.Flip(FlipMode.Y); //horizontal flip
				cam_compare_olb = cam1_img.Flip(FlipMode.Y); //horizontal flip
				cam1_save = cam1_img.Flip(FlipMode.Y); //horizontal flip
				cam_disp = cam1_img.Flip(FlipMode.Y); //horizontal flip
			}
			else if ((Properties.Settings.Default.cam1_hflip == false) && (Properties.Settings.Default.cam1_vflip == true))
			{
				cam_compare_dut = cam1_img.Flip(FlipMode.X); //verical flip
				cam_compare_olb = cam1_img.Flip(FlipMode.X); //verical flip
				cam1_save = cam1_img.Flip(FlipMode.X); //verical flip
				cam_disp = cam1_img.Flip(FlipMode.X); //verical flip
			}
			else
			{
				cam_compare_dut = cam1_img;
				cam_compare_olb = cam1_img;
				cam1_save = cam1_img;
				cam_disp = cam1_img;
			}
		}
		static void image_flip_cam2()
		{
			if ((Properties.Settings.Default.cam2_hflip == true) && (Properties.Settings.Default.cam2_vflip == true))
			{
				cam_compare_dut = cam2_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam_compare_olb = cam2_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam2_save = cam2_img.Flip(FlipMode.XY); //verical,horizontal flip
				cam_disp = cam2_img.Flip(FlipMode.XY); //verical,horizontal flip
			}
			else if ((Properties.Settings.Default.cam2_hflip == true) && (Properties.Settings.Default.cam2_vflip == false))
			{
				cam_compare_dut = cam2_img.Flip(FlipMode.Y); //horizontal flip
				cam_compare_olb = cam2_img.Flip(FlipMode.Y); //horizontal flip
				cam2_save = cam2_img.Flip(FlipMode.Y); //horizontal flip
				cam_disp = cam2_img.Flip(FlipMode.Y); //horizontal flip
			}
			else if ((Properties.Settings.Default.cam2_hflip == false) && (Properties.Settings.Default.cam2_vflip == true))
			{
				cam_compare_dut = cam2_img.Flip(FlipMode.X); //verical flip
				cam_compare_olb = cam2_img.Flip(FlipMode.X); //verical flip
				cam2_save = cam2_img.Flip(FlipMode.X); //verical flip
				cam_disp = cam2_img.Flip(FlipMode.X); //verical flip
			}
			else
			{
				cam_compare_dut = cam2_img;
				cam_compare_olb = cam2_img;
				cam2_save = cam2_img;
				cam_disp = cam2_img;
			}
		}
		static void image_template_cam1_alway()
		{
			if (Properties.Settings.Default.match_disp == true)
			{
				x1_dist = y1_dist = t1_dist = 0;
				cam1_result_dut = TemplateMatch(cam_compare_dut, cam1_ref_dut);
				cam1_result_olb = TemplateMatch(cam_compare_olb, cam1_ref_olb);
				if ((cam1_result_dut.maxval >= threshold) && (cam1_result_olb.maxval >= threshold))
				{
					Rect rect = new Rect(cam1_result_dut.maxloc.X, cam1_result_dut.maxloc.Y, cam1_ref_dut.Width, cam1_ref_dut.Height);
					Rect rect1 = new Rect(cam1_result_olb.maxloc.X, cam1_result_olb.maxloc.Y, cam1_ref_olb.Width, cam1_ref_olb.Height);
					Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
					Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
					Cv2.PutText(cam_disp, cam1_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_dut.maxloc.X + 5, cam1_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
					Cv2.PutText(cam_disp, cam1_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_olb.maxloc.X + 5, cam1_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
					KI.frm.disp_cam1.ImageIpl = cam_disp;

					x1_dist = Properties.Settings.Default.Dist_X1 - (cam1_result_dut.maxloc.X - cam1_result_olb.maxloc.X);
					y1_dist = Properties.Settings.Default.Dist_Y1 - (cam1_result_dut.maxloc.Y - cam1_result_olb.maxloc.Y);
				}
				else if ((cam1_result_dut.maxval >= threshold))
				{
					Rect rect = new Rect(cam1_result_dut.maxloc.X, cam1_result_dut.maxloc.Y, cam1_ref_dut.Width, cam1_ref_dut.Height);
					Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
					Cv2.PutText(cam_disp, cam1_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_dut.maxloc.X + 5, cam1_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
					KI.frm.disp_cam1.ImageIpl = cam_disp;
				}
				else if ((cam1_result_olb.maxval >= threshold))
				{
					Rect rect1 = new Rect(cam1_result_olb.maxloc.X, cam1_result_olb.maxloc.Y, cam1_ref_olb.Width, cam1_ref_olb.Height);
					Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
					Cv2.PutText(cam_disp, cam1_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_olb.maxloc.X + 5, cam1_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
					KI.frm.disp_cam1.ImageIpl = cam_disp;
				}
				else
				{
					KI.frm.disp_cam1.ImageIpl = cam_disp;
				}
			}
			else
			{
				KI.frm.disp_cam1.ImageIpl = cam1_save;
			}
		}
		static void image_template_cam2_alway()
		{
			if (Properties.Settings.Default.match_disp == true)
			{
				x2_dist = y2_dist = t2_dist = 0;
				cam2_result_dut = TemplateMatch(cam_compare_dut, cam2_ref_dut);
				cam2_result_olb = TemplateMatch(cam_compare_olb, cam2_ref_olb);
				if ((cam2_result_dut.maxval >= threshold) && (cam2_result_olb.maxval >= threshold))
				{
					Rect rect = new Rect(cam2_result_dut.maxloc.X, cam2_result_dut.maxloc.Y, cam2_ref_dut.Width, cam2_ref_dut.Height);
					Rect rect1 = new Rect(cam2_result_olb.maxloc.X, cam2_result_olb.maxloc.Y, cam2_ref_olb.Width, cam2_ref_olb.Height);
					Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
					Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
					Cv2.PutText(cam_disp, cam2_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_dut.maxloc.X + 5, cam2_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
					Cv2.PutText(cam_disp, cam2_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_olb.maxloc.X + 5, cam2_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
					KI.frm.disp_cam2.ImageIpl = cam_disp;
					x2_dist = Properties.Settings.Default.Dist_X2 - (cam2_result_dut.maxloc.X - cam2_result_olb.maxloc.X);
					y2_dist = Properties.Settings.Default.Dist_Y2 - (cam2_result_dut.maxloc.Y - cam2_result_olb.maxloc.Y);
				}
				else if ((cam2_result_dut.maxval >= threshold))
				{
					Rect rect = new Rect(cam2_result_dut.maxloc.X, cam2_result_dut.maxloc.Y, cam2_ref_dut.Width, cam2_ref_dut.Height);
					Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
					Cv2.PutText(cam_disp, cam2_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_dut.maxloc.X + 5, cam2_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);

					KI.frm.disp_cam2.ImageIpl = cam_disp;
				}
				else if ((cam2_result_olb.maxval >= threshold))
				{
					Rect rect1 = new Rect(cam2_result_olb.maxloc.X, cam2_result_olb.maxloc.Y, cam2_ref_olb.Width, cam2_ref_olb.Height);
					Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
					Cv2.PutText(cam_disp, cam2_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_olb.maxloc.X + 5, cam2_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
					KI.frm.disp_cam2.ImageIpl = cam_disp;
				}
				else
				{
					KI.frm.disp_cam2.ImageIpl = cam_disp;
				}
			}
			else
			{
				KI.frm.disp_cam2.ImageIpl = cam2_save;
			}
		}
		static void image_template_cam1_onshot()
		{
			x1_dist = y1_dist = t1_dist = 9999;
			cam1_result_dut = TemplateMatch(cam_compare_dut, cam1_ref_dut);
			cam1_result_olb = TemplateMatch(cam_compare_olb, cam1_ref_olb);
			if ((cam1_result_dut.maxval >= threshold) && (cam1_result_olb.maxval >= threshold))
			{
				Rect rect = new Rect(cam1_result_dut.maxloc.X, cam1_result_dut.maxloc.Y, cam1_ref_dut.Width, cam1_ref_dut.Height);
				Rect rect1 = new Rect(cam1_result_olb.maxloc.X, cam1_result_olb.maxloc.Y, cam1_ref_olb.Width, cam1_ref_olb.Height);
				Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
				Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
				Cv2.PutText(cam_disp, cam1_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_dut.maxloc.X + 5, cam1_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
				Cv2.PutText(cam_disp, cam1_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_olb.maxloc.X + 5, cam1_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
				KI.frm.disp_cam1.ImageIpl = cam_disp;

				x1_dist = Properties.Settings.Default.Dist_X1 - (cam1_result_dut.maxloc.X - cam1_result_olb.maxloc.X);
				y1_dist = Properties.Settings.Default.Dist_Y1 - (cam1_result_dut.maxloc.Y - cam1_result_olb.maxloc.Y);
			}
			else if ((cam1_result_dut.maxval >= threshold))
			{
				Rect rect = new Rect(cam1_result_dut.maxloc.X, cam1_result_dut.maxloc.Y, cam1_ref_dut.Width, cam1_ref_dut.Height);
				Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
				Cv2.PutText(cam_disp, cam1_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_dut.maxloc.X + 5, cam1_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
				KI.frm.disp_cam1.ImageIpl = cam_disp;
			}
			else if ((cam1_result_olb.maxval >= threshold))
			{
				Rect rect1 = new Rect(cam1_result_olb.maxloc.X, cam1_result_olb.maxloc.Y, cam1_ref_olb.Width, cam1_ref_olb.Height);
				Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
				Cv2.PutText(cam_disp, cam1_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam1_result_olb.maxloc.X + 5, cam1_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
				KI.frm.disp_cam1.ImageIpl = cam_disp;
			}
			else
			{
				KI.frm.disp_cam1.ImageIpl = cam_disp;
			}
		}
		static void image_template_cam2_onshot()
		{
			x2_dist = y2_dist = t2_dist = 9999;
			cam2_result_dut = TemplateMatch(cam_compare_dut, cam2_ref_dut);
			cam2_result_olb = TemplateMatch(cam_compare_olb, cam2_ref_olb);
			if ((cam2_result_dut.maxval >= threshold) && (cam2_result_olb.maxval >= threshold))
			{
				Rect rect = new Rect(cam2_result_dut.maxloc.X, cam2_result_dut.maxloc.Y, cam2_ref_dut.Width, cam2_ref_dut.Height);
				Rect rect1 = new Rect(cam2_result_olb.maxloc.X, cam2_result_olb.maxloc.Y, cam2_ref_olb.Width, cam2_ref_olb.Height);
				Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
				Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
				Cv2.PutText(cam_disp, cam2_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_dut.maxloc.X + 5, cam2_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);
				Cv2.PutText(cam_disp, cam2_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_olb.maxloc.X + 5, cam2_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
				KI.frm.disp_cam2.ImageIpl = cam_disp;
				x2_dist = Properties.Settings.Default.Dist_X2 - (cam2_result_dut.maxloc.X - cam2_result_olb.maxloc.X);
				y2_dist = Properties.Settings.Default.Dist_Y2 - (cam2_result_dut.maxloc.Y - cam2_result_olb.maxloc.Y);
			}
			else if ((cam2_result_dut.maxval >= threshold))
			{
				Rect rect = new Rect(cam2_result_dut.maxloc.X, cam2_result_dut.maxloc.Y, cam2_ref_dut.Width, cam2_ref_dut.Height);
				Cv2.Rectangle(cam_disp, rect, new OpenCvSharp.Scalar(0, 0, 255), 2);
				Cv2.PutText(cam_disp, cam2_result_dut.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_dut.maxloc.X + 5, cam2_result_dut.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Red);

				KI.frm.disp_cam2.ImageIpl = cam_disp;
			}
			else if ((cam2_result_olb.maxval >= threshold))
			{
				Rect rect1 = new Rect(cam2_result_olb.maxloc.X, cam2_result_olb.maxloc.Y, cam2_ref_olb.Width, cam2_ref_olb.Height);
				Cv2.Rectangle(cam_disp, rect1, new OpenCvSharp.Scalar(0, 255, 0), 2);
				Cv2.PutText(cam_disp, cam2_result_olb.maxval.ToString("F4"), new OpenCvSharp.Point(cam2_result_olb.maxloc.X + 5, cam2_result_olb.maxloc.Y + 25), OpenCvSharp.HersheyFonts.HersheySimplex, 0.7, OpenCvSharp.Scalar.Green);
				KI.frm.disp_cam2.ImageIpl = cam_disp;
			}
			else
			{
				KI.frm.disp_cam2.ImageIpl = cam_disp;
			}
		}

		public static void vision_disp(object sender, System.EventArgs e)
		{
			//if (KI.frm.tab.SelectedIndex != KI.VISION_DISP) return;

			try
			{
				if (Properties.Settings.Default.dual_cam == true)
				{
					if (Properties.Settings.Default.cam_change == false)
					{
						if (cam1.IsOpened() == true) cam1.Read(cam1_img);
						if (cam2.IsOpened() == true) cam2.Read(cam2_img);
					}
					else
					{
						if (cam1.IsOpened() == true) cam1.Read(cam2_img);
						if (cam2.IsOpened() == true) cam2.Read(cam1_img);
					}
					
					image_flip_cam1();
					image_template_cam1_alway();

					image_flip_cam2();
					image_template_cam2_alway();

					always_aling_estimation();
				}
				else
				{
					if (cam1.IsOpened() == true) cam1.Read(cam1_img);

					image_flip_cam1();
					image_template_cam1_alway();

					always_aling_estimation();
				}
			}
			catch
			{
				//KI.frm.vision_timer.Stop();
			}
		}

		public const string img_save_path = @"C:\KI\Vision\Test\";
		public const string ref_save_path = @"C:\KI\Vision\ref\";
		public static void cam1_img_save()
		{
			DirectoryInfo di = new DirectoryInfo(img_save_path);
			if (di.Exists == false)
				di.Create();
			cam1_save.SaveImage(img_save_path+"cam1_img.png");
		}
		public static void cam2_img_save()
		{
			DirectoryInfo di = new DirectoryInfo(img_save_path);
			if (di.Exists == false)
				di.Create();

			cam2_save.SaveImage(img_save_path + "cam2_img.png");
		}
		public static void cam_ref_save(int flag,Mat img1, Mat img2)
		{
			if (flag == 1)
			{
				img1.SaveImage(ref_save_path + "cam1_ref_dut.png");
				img2.SaveImage(ref_save_path + "cam1_ref_olb.png");
				cam1_ref_dut = Cv2.ImRead(ref_save_path + "cam1_ref_dut.png");
				cam1_ref_olb = Cv2.ImRead(ref_save_path + "cam1_ref_olb.png");
			}
			else if (flag == 2)
			{
				img1.SaveImage(ref_save_path + "cam2_ref_dut.png");
				img2.SaveImage(ref_save_path + "cam2_ref_olb.png");
				cam2_ref_dut = Cv2.ImRead(ref_save_path + "cam2_ref_dut.png");
				cam2_ref_olb = Cv2.ImRead(ref_save_path + "cam2_ref_olb.png");
			}
		}

		public static void cam_ref_view(int flag)
		{
			if(flag == 1)
			{
				Cv2.ImShow("Ref1 dut", cam1_ref_dut);
				Cv2.ImShow("Ref1 olb", cam1_ref_olb);
			}
			else if (flag == 2)
			{
				Cv2.ImShow("Ref2 dut", cam2_ref_dut);
				Cv2.ImShow("Ref2 olb", cam2_ref_olb);
			}
		}

		public static void cam1_ref_view()
		{
			Cv2.ImShow("Camera1 DUT Ref", cam1_ref_dut);
			Cv2.ImShow("Camera1 OLB Ref", cam1_ref_olb);
		}

		public static void cam2_ref_view()
		{
			Cv2.ImShow("Camera2 DUT Ref", cam2_ref_dut);
			Cv2.ImShow("Camera2 OLB Ref", cam2_ref_olb);
		}

		public static CamMatchResult TemplateMatch(Mat compare_img, Mat ref_img)
		{
			CamMatchResult result_tm = new CamMatchResult();
			result_tm.rst = new Mat(); 
			Cv2.MatchTemplate(compare_img, ref_img, result_tm.rst, TemplateMatchModes.CCoeffNormed);
			Cv2.Threshold(result_tm.rst, result_tm.rst, 0.8, 1.0, ThresholdTypes.Tozero);
			Cv2.MinMaxLoc(result_tm.rst, out result_tm.minval, out result_tm.maxval, out result_tm.minloc, out result_tm.maxloc);
			return result_tm;
		}

		static void dual_read_ref_img()
		{
			DirectoryInfo di = new DirectoryInfo(img_save_path);
			if (di.Exists == false)
				di.Create();

			FileInfo dut1 = new FileInfo(ref_save_path + "cam1_ref_dut.png");
			if (dut1.Exists == false)
			{
				cam1_img.SaveImage(ref_save_path + "cam1_ref_dut.png");
			}
			FileInfo olb1 = new FileInfo(ref_save_path + "cam1_ref_olb.png");
			if (olb1.Exists == false)
			{
				cam1_img.SaveImage(ref_save_path + "cam1_ref_olb.png");
			}

			FileInfo dut2 = new FileInfo(ref_save_path + "cam2_ref_dut.png");
			if (dut2.Exists == false)
			{
				cam2_img.SaveImage(ref_save_path + "cam2_ref_dut.png");
			}
			FileInfo olb2 = new FileInfo(ref_save_path + "cam2_ref_olb.png");
			if (olb2.Exists == false)
			{
				cam2_img.SaveImage(ref_save_path + "cam2_ref_olb.png");
			}
						
			cam1_ref_dut = Cv2.ImRead(ref_save_path + "cam1_ref_dut.png");
			cam1_ref_olb = Cv2.ImRead(ref_save_path + "cam1_ref_olb.png");

			cam2_ref_dut = Cv2.ImRead(ref_save_path + "cam2_ref_dut.png");
			cam2_ref_olb = Cv2.ImRead(ref_save_path + "cam2_ref_olb.png");
		}
		static void solo_read_ref_img()
		{
			DirectoryInfo di = new DirectoryInfo(img_save_path);
			if (di.Exists == false)
				di.Create();

			FileInfo dut1 = new FileInfo(ref_save_path + "cam1_ref_dut.png");
			if (dut1.Exists == false)
			{
				cam1_img.SaveImage(ref_save_path + "cam1_ref_dut.png");
			}
			FileInfo olb1 = new FileInfo(ref_save_path + "cam1_ref_olb.png");
			if (olb1.Exists == false)
			{
				cam1_img.SaveImage(ref_save_path + "cam1_ref_olb.png");
			}
			cam1_ref_dut = Cv2.ImRead(ref_save_path + "cam1_ref_dut.png");
			cam1_ref_olb = Cv2.ImRead(ref_save_path + "cam1_ref_olb.png");
		}
	}
}
