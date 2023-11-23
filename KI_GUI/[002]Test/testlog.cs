using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI_GUI
{
	class testlog
	{
		public const string log_save_path = @"C:\KI\Log\";

		public static DateTime now = DateTime.Now;

		public static void panel_data_rx(byte[] data)
		{
			string[] pan = util.ByteToString(data).Split(',');

			int panel_cnt = Convert.ToUInt16(pan[0]);
			int tx_num = Convert.ToUInt16(pan[1]);
			int rx_num = Convert.ToUInt16(pan[2]);
			int err_num = Convert.ToUInt16(pan[3]);
			int panel_float = Convert.ToUInt16(pan[4]);

			int node = 0;
			for(int i = 0; i<tx_num; i++)
			{
				for(int j = 0; j<rx_num; j++)
				{
					if(panel_float==0)
						Test.panel_data[panel_cnt,node]=Convert.ToInt16(pan[5+node]);
					else
						Test.panel_dataf[panel_cnt,node]=(float)Convert.ToDouble(pan[5+node]);
					node++;
				}
			}
		}

		public static void save_log(byte flag)
		{
			now=DateTime.Now;
			save_summary_log(flag);
			save_1d_panel_log(flag);
			save_2d_panel_log(flag);
			if(	Properties.Settings.Default.sdc_log==true)
				save_sdc_panel_log(flag);
		}

		public static void save_summary_log(byte flag)
		{
			string LogFilePath = "";
			if(Properties.Settings.Default.mode_flag==0)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\",specfile.project_name_main,specfile.mode1_name,now);
			else if(Properties.Settings.Default.mode_flag==1)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\",specfile.project_name_main,specfile.mode2_name,now);
			else if(Properties.Settings.Default.mode_flag==2)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\",specfile.project_name_main,specfile.mode3_name,now);
			else if(Properties.Settings.Default.mode_flag==3)
				LogFilePath =   String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\",specfile.project_name_main,specfile.mode4_name,now);

			DirectoryInfo di = new DirectoryInfo(LogFilePath);
			if(di.Exists==false)
				di.Create();

			string logFileName = String.Format("summary_{0:yyMMdd}({1}).csv",now, KI.board_sn);

			FileStream fs = new FileStream(LogFilePath+logFileName,FileMode.Append,FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs,Encoding.Default);
			string logwritetBuff = "";
			if(fs.Length==0)
			{
				//// label
				logwritetBuff=",,,,,,,,,,,,,,upper,";
				// add part test index
				for(int cnt = 0; cnt<specfile.part_count; cnt++)
				{
					logwritetBuff+=String.Format("{0:F2},",specfile.part_spec_hi[cnt]);
				}
				sw.WriteLine(logwritetBuff);

				//// label
				logwritetBuff=",,,,,,,,,,,,,,lower,";
				// add part test index
				for(int cnt = 0; cnt<specfile.part_count; cnt++)
				{
					logwritetBuff+=String.Format("{0:F2},",specfile.part_spec_lo[cnt]);
				}

				sw.WriteLine(logwritetBuff);
				
				logwritetBuff="Project,";
				logwritetBuff+="Serial,";
				logwritetBuff+="Version,";
				logwritetBuff+="VCC1,";
				logwritetBuff+="VCC2,";
				logwritetBuff+="NG Cont.,";
				logwritetBuff+="Date,Time,Result,";
				logwritetBuff+="QTY,PASS,FAIL,";
				logwritetBuff+="Tack Time,";
				logwritetBuff+="Open,Short,";

				// add part test index
				for(int cnt = 0; cnt<specfile.part_count; cnt++)
				{
					logwritetBuff += specfile.part_name[cnt]+",";
				}
				// add part test index
				for(int cnt = 0; cnt<specfile.func_count; cnt++)
				{
					logwritetBuff+=specfile.func_name[cnt]+",";
				}
				sw.WriteLine(logwritetBuff);
			}

			logwritetBuff=specfile.project_name_main+",";
			logwritetBuff+= KI.board_sn+",";
			logwritetBuff+= KI.board_ver+",";
			logwritetBuff+="0V,";
			logwritetBuff+="0V,";

			if(Properties.Settings.Default.ng_cont==false)
				logwritetBuff+="OFF,";
			else
				logwritetBuff+="ON,";

			logwritetBuff+=String.Format("{0:yy-MM-dd},",now);
			logwritetBuff+=String.Format("{0:HH:mm:ss},",now);

			if(flag == 1)		logwritetBuff+="PASS,";
			else if(flag == 0)  logwritetBuff+="FAIL,";

			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.ok_cnt);
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.ng_cnt);

			logwritetBuff+= KI.tact_time+",";

			if(Test.op_auto_result==1)
			{
				logwritetBuff+="OK,";
			}
			else if(Test.op_auto_result==0)
			{
				logwritetBuff+=Test.test_meas_string[Test.Op_str_idx]+",";
			}

			if(Test.sh_auto_result==1)
			{
				logwritetBuff+="OK,";
			}
			else if(Test.sh_auto_result==0)
			{
				logwritetBuff+=Test.test_meas_string[Test.Sh_str_idx]+",";
			}

			for(int cnt = 0; cnt<specfile.part_count; cnt++)
			{
				if(cnt<Test.Pt_end_idx-Test.Pt_str_idx)
				{
					logwritetBuff += Test.test_meas_string[cnt+Test.Pt_str_idx]+",";
				}
				else
				{
					logwritetBuff+="-,";
				}
			}

			//Func Result Write
			for(int cnt = 0; cnt<specfile.func_count; cnt++)
			{
				if(cnt<Test.Fn_end_idx-Test.Fn_str_idx)
				{
					logwritetBuff += Test.test_meas_string[cnt+Test.Fn_str_idx]+",";
				}
				else
				{
					logwritetBuff+="-,";
				}
			}
			
			sw.WriteLine(logwritetBuff);
			
			sw.Close();
			fs.Close();
		}
		
		public static void save_1d_panel_log(byte flag)
		{
			string LogFilePath = "";
			if(Properties.Settings.Default.mode_flag==0)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode1_name,now);
			else if(Properties.Settings.Default.mode_flag==1)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode2_name,now);
			else if(Properties.Settings.Default.mode_flag==2)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode3_name,now);
			else if(Properties.Settings.Default.mode_flag==3)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode4_name,now);

			DirectoryInfo di = new DirectoryInfo(LogFilePath);
			if(di.Exists==false)
				di.Create();

			string logFileName = String.Format("1D_Panel_{0:yyMMdd}({1}).csv",now, KI.board_sn);

			FileStream fs = new FileStream(LogFilePath+logFileName,FileMode.Append,FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs,Encoding.Default);
			string logwritetBuff = "";
			if(fs.Length==0)
			{
				logwritetBuff="ITEM,Count,Tx,Rx,Error,Value,";
				sw.WriteLine(logwritetBuff);
			}
			logwritetBuff="Result,";
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);

			if(flag==1)
				logwritetBuff+="PASS";
			else if(flag==0)
				logwritetBuff+="FAIL";

			sw.WriteLine(logwritetBuff);
			
			logwritetBuff="Time,";
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
			logwritetBuff+=String.Format("{0:yy-MM-dd},",now);
			logwritetBuff+=String.Format("{0:HH:mm:ss},",now);

			sw.WriteLine(logwritetBuff);

			for(int cnt = 0; cnt<specfile.func_count; cnt++)
			{
				if(specfile.func_panel_link[cnt]!=0)
				{
					UInt16 panel_cnt = (UInt16)(specfile.func_panel_link[cnt]-1);
					UInt16 panel_float = (UInt16)specfile.func_spec_float[cnt];
					UInt16 tx_num = specfile.panel_tx_num[panel_cnt];
					UInt16 rx_num = specfile.panel_rx_num[panel_cnt];

					logwritetBuff=specfile.func_name[cnt]+",";
					logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
					logwritetBuff+=String.Format("{0},{1},",tx_num,rx_num);
					logwritetBuff+=String.Format("{0},",Test.ErrorNodeCount[panel_cnt]);

					UInt16 node = 0;
					for(int tx = 0; tx<tx_num; tx++)
					{
						for(int rx = 0; rx<rx_num; rx++)
						{
							if(panel_float==0)
								logwritetBuff+=String.Format("{0},",Test.panel_data[panel_cnt,node]);
							else
								logwritetBuff+=String.Format("{0:F3},",Test.panel_dataf[panel_cnt,node]);
							node++;
						}
					}
					sw.WriteLine(logwritetBuff);
				}
			}			
			sw.Close();
			fs.Close();
		}

		public static void save_2d_panel_log(byte flag)
		{
			string LogFilePath = "";
			if(Properties.Settings.Default.mode_flag==0)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode1_name,now);
			else if(Properties.Settings.Default.mode_flag==1)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode2_name,now);
			else if(Properties.Settings.Default.mode_flag==2)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode3_name,now);
			else if(Properties.Settings.Default.mode_flag==3)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\panel\",specfile.project_name_main,specfile.mode4_name,now);

			DirectoryInfo di = new DirectoryInfo(LogFilePath);
			if(di.Exists==false)
				di.Create();

			string logFileName = String.Format("2D_Panel_{0:yyMMdd}({1}).csv",now, KI.board_sn);

			FileStream fs = new FileStream(LogFilePath+logFileName,FileMode.Append,FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs,Encoding.Default);
			string logwritetBuff = "";
			if(fs.Length==0)
			{
				//// label
				logwritetBuff="Project Name,";
				logwritetBuff+="Date,Time,Result,";
				logwritetBuff+="QTY,PASS,FAIL,";
				logwritetBuff+="Item,Nodes,";
				sw.WriteLine(logwritetBuff);
			}

			logwritetBuff=specfile.project_name_main+",";
			logwritetBuff+=String.Format("{0:yy-MM-dd},",now);
			logwritetBuff+=String.Format("{0:HH:mm:ss},",now);
			
			if(flag==1)
				logwritetBuff="PASS,";
			else if(flag==0)
				logwritetBuff+="FAIL,";

			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.ok_cnt);
			logwritetBuff+=String.Format("{0},",Properties.Settings.Default.ng_cnt);
			sw.WriteLine(logwritetBuff);

			for(int cnt = 0; cnt<specfile.func_count; cnt++)
			{
				if(specfile.func_panel_link[cnt]!=0)
				{
					UInt16 panel_cnt = (UInt16)(specfile.func_panel_link[cnt]-1);
					UInt16 tx_num = specfile.panel_tx_num[panel_cnt];
					UInt16 rx_num = specfile.panel_rx_num[panel_cnt];
					UInt16 panel_float = (UInt16)specfile.func_spec_float[cnt];

					logwritetBuff = String.Format("{0}(err:{1}),",specfile.func_name[cnt],Test.ErrorNodeCount[panel_cnt]);

					for(int rx = 0; rx<rx_num; rx++)
					{
						logwritetBuff+=String.Format("RX{0},",rx);
					}
					sw.WriteLine(logwritetBuff);

					UInt16 node = 0;
					for(int tx = 0; tx<tx_num; tx++)
					{
						logwritetBuff=String.Format("TX{0},",tx);
						for(int rx = 0; rx<rx_num; rx++)
						{
							if(panel_float==0)
								logwritetBuff+=String.Format("{0},",Test.panel_data[panel_cnt,node]);
							else
								logwritetBuff+=String.Format("{0:F3},",Test.panel_dataf[panel_cnt,node]);
							node++;
						}
						sw.WriteLine(logwritetBuff);
					}
					logwritetBuff="";
					sw.WriteLine(logwritetBuff);
				}
			}
			sw.WriteLine(logwritetBuff);

			sw.Close();
			fs.Close();
		}

		public static void save_sdc_panel_log(byte flag)
		{
			DateTime now = DateTime.Now;

			string LogFilePath = "";
			if(Properties.Settings.Default.mode_flag==0)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\SDC\",specfile.project_name_main,specfile.mode1_name,now);
			else if(Properties.Settings.Default.mode_flag==1)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\SDC\",specfile.project_name_main,specfile.mode2_name,now);
			else if(Properties.Settings.Default.mode_flag==2)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\SDC\",specfile.project_name_main,specfile.mode3_name,now);
			else if(Properties.Settings.Default.mode_flag==3)
				LogFilePath=String.Format(@"C:\KI\LOG({0})\{1}\{2:yyyy-MM-dd}\SDC\",specfile.project_name_main,specfile.mode4_name,now);

			DirectoryInfo di = new DirectoryInfo(LogFilePath);
			if(di.Exists==false)
				di.Create();

			string logFileName = "";
			if(flag == 0)
				logFileName=String.Format("{0}_TSP_LOG_SPL{1}_F.csv",specfile.project_name_main,Properties.Settings.Default.qty_cnt);
			else if(flag==1)
				logFileName=String.Format("{0}_TSP_LOG_SPL{1}_P.csv",specfile.project_name_main,Properties.Settings.Default.qty_cnt);

			FileStream fs = new FileStream(LogFilePath+logFileName,FileMode.Append,FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs,Encoding.Default);
			string logwritetBuff = "";
			for(int cnt = 0; cnt<specfile.func_count; cnt++)
			{
				if(specfile.func_panel_link[cnt]!=0)
				{
					UInt16 panel_cnt = (UInt16)(specfile.func_panel_link[cnt]-1);
					UInt16 panel_float = (UInt16)specfile.func_spec_float[cnt];
					UInt16 tx_num = specfile.panel_tx_num[panel_cnt];
					UInt16 rx_num = specfile.panel_rx_num[panel_cnt];
					UInt16 node = 0;

					node=0;
					for(int tx = 0; tx<tx_num; tx++)
					{
						for(int rx = 0; rx<rx_num; rx++)
						{
							if(panel_float==0)
								Test.sdc_data[rx,tx]=Test.panel_data[panel_cnt,node];
							else
								Test.sdc_dataf[rx,tx]=Test.panel_dataf[panel_cnt,node];
							node++;
						}
					}

					logwritetBuff="Date,";
					logwritetBuff+="Cell ID,";
					logwritetBuff+="CH ID,";
					logwritetBuff+="ZONE,";
					logwritetBuff+="PG CH,";
					logwritetBuff+="TITLE,";
					logwritetBuff+="TYPE,";
					logwritetBuff+="X,";
					logwritetBuff+="Y,";
					logwritetBuff+="COUNT,";

					if(tx_num==1)
					{
						for(int rx = 0; rx<rx_num; rx++)
						{
							
							logwritetBuff +=String.Format("X{0},",rx);
						}
					}
					else
					{
						for(int tx = 0; tx<tx_num; tx++)
						{
							logwritetBuff+=String.Format("X{0},",tx);
						}
					}
					sw.WriteLine(logwritetBuff);
					//////////////////////////////////////////////////////////////////////////////
					//////////////////////////////////////////////////////////////////////////////
					//////////////////////////////////////////////////////////////////////////////					

					if(tx_num==1)
					{
						float avr = 0.0f;
						int sum = 0;
						float sumf = 0;
						int max = -65535;
						int min = 65535;

						for(int tx = 0; tx<tx_num; tx++)
						{
							logwritetBuff=String.Format("{0:yy-MM-dd} ",now);
							logwritetBuff+=String.Format("{0:HH:mm:ss},",now);
							logwritetBuff+=String.Format("SPL{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",specfile.func_name[cnt]);
							logwritetBuff+=String.Format("0,");
							logwritetBuff+=String.Format("{0},",rx_num);
							logwritetBuff+=String.Format("{0},",tx_num);
							logwritetBuff+=String.Format("{0},",tx);

							for(int rx = 0; rx<rx_num; rx++)
							{
								if(panel_float==0)
								{
									logwritetBuff +=String.Format("{0},",Test.sdc_data[rx,tx]);
									sum+=Test.sdc_data[rx,tx];
									if(Test.sdc_data[rx,tx]<min)			min=Test.sdc_data[rx,tx];
									if(Test.sdc_data[rx,tx]>max)			max=Test.sdc_data[rx,tx];
								}
								else
								{
									logwritetBuff+=String.Format("{0:F3},",Test.sdc_dataf[rx,tx]);
									sumf+=Test.sdc_dataf[rx,tx];
									if(Test.sdc_dataf[rx,tx]<(float)min)
										min=(int)Test.sdc_dataf[rx,tx];
									if(Test.sdc_dataf[rx,tx]>(float)max)
										max=(int)Test.sdc_dataf[rx,tx];
								}
							}
							sw.WriteLine(logwritetBuff);
						}
						logwritetBuff=String.Format("{0:yy-MM-dd} ",now);
						logwritetBuff+=String.Format("{0:HH:mm:ss},",now);
						logwritetBuff+=String.Format("SPL{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",specfile.func_name[cnt]);

						if(Test.ErrorNodeCount[panel_cnt]==0)
							logwritetBuff+="GOOD,";
						else
							logwritetBuff+="FAIL,";

						if(panel_float==0)
							avr=(((float)sum)/((float)(rx_num*tx_num)));
						else
							avr=(((float)sumf)/((float)(rx_num*tx_num)));
						
						logwritetBuff+=String.Format("{0:F3},",avr);
						logwritetBuff+=String.Format("{0},",max);
						logwritetBuff+=String.Format("{0},",min);
						sw.WriteLine(logwritetBuff);
					}
					else
					{
						float avr = 0.0f;
						int sum = 0;
						float sumf = 0;
						int max = -65535;
						int min = 65535;
						for(int rx = 0; rx<rx_num; rx++)
						{
							logwritetBuff=String.Format("{0:yy-MM-dd} ",now);
							logwritetBuff+=String.Format("{0:HH:mm:ss},",now);
							logwritetBuff+=String.Format("SPL{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
							logwritetBuff+=String.Format("{0},",specfile.func_name[cnt]);
							logwritetBuff+=String.Format("0,");
							logwritetBuff+=String.Format("{0},",tx_num);
							logwritetBuff+=String.Format("{0},",rx_num);
							logwritetBuff+=String.Format("{0},",rx);
							
							for(int tx = 0; tx<tx_num; tx++)
							{
								if(panel_float==0)
								{
									logwritetBuff+=String.Format("{0},",Test.sdc_data[rx,tx]);
									sum+=Test.sdc_data[rx,tx];
									if(Test.sdc_data[rx,tx]<min)
										min=Test.sdc_data[rx,tx];
									if(Test.sdc_data[rx,tx]>max)
										max=Test.sdc_data[rx,tx];
								}
								else
								{
									logwritetBuff+=String.Format("{0:F3},",Test.sdc_dataf[rx,tx]);
									sumf+=Test.sdc_dataf[rx,tx];
									if(Test.sdc_dataf[rx,tx]<(float)min)
										min=(int)Test.sdc_dataf[rx,tx];
									if(Test.sdc_dataf[rx,tx]>(float)max)
										max=(int)Test.sdc_dataf[rx,tx];
								}

							}
							sw.WriteLine(logwritetBuff);
						}

						logwritetBuff=String.Format("{0:yy-MM-dd} ",now);
						logwritetBuff+=String.Format("{0:HH:mm:ss},",now);
						logwritetBuff+=String.Format("SPL{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",Properties.Settings.Default.qty_cnt);
						logwritetBuff+=String.Format("{0},",specfile.func_name[cnt]);

						if(Test.ErrorNodeCount[panel_cnt]==0)
							logwritetBuff+="GOOD,";
						else
							logwritetBuff+="FAIL,";

						if(panel_float==0)
							avr=(((float)sum)/((float)(rx_num*tx_num)));
						else
							avr=(((float)sumf)/((float)(rx_num*tx_num)));

						logwritetBuff+=String.Format("{0:F3},",avr);
						logwritetBuff+=String.Format("{0},",max);
						logwritetBuff+=String.Format("{0},",min);
						sw.WriteLine(logwritetBuff);						
					}
				}
			}
			sw.Close();
			fs.Close();
		}
	}
}
