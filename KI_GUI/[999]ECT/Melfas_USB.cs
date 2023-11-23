using System;
using System.Diagnostics; //210516 MCH
using System.ComponentModel; //210516 MCH
using System.Timers;//210516 MCH
using System.Runtime.InteropServices; //210517 MCH
using System.Threading;//210517 MCH
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Text;

namespace KI_GUI
{
    class melfas_usb
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string lpszWindow);

        [DllImport("user32.dll")]
        public static extern Int32 SendMessage(IntPtr hWnd, Int32 uMsg, IntPtr WParam, IntPtr LParam);
        [DllImport("user32.dll")]
        public static extern Int32 SendMessage(IntPtr hWnd, Int32 uMsg, IntPtr WParam, string LParam);

        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;


        private const int WM_GETTEXT = 0x000D;
        private const int WM_GETTEXTLENGTH = 0x000E;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_SETTEXT = 0x000C;

        const int TYPE_NORMAL_MSG = 0;
        const int TYPE_MIT_MSG = 1;

        public const byte MFS_ING = 220;
        public const byte MFS_PASS = 221;
        public const byte MFS_FAIL = 222;
        /*
                //MIT4XX Factory Downloader v1.73 기준 버튼
                static List<IntPtr> ChildBtnHandle;
                const int BTN_READ_INFO = 0;
                const int BTN_DOWNLOAD = 1;
                const int BTN_SELECT_TARGET = 2;
                const int BTN_HID = 4;
                const int BTN_I2C = 5;
                const int BTN_MIT400 = 6;
                const int BTN_MIT401 = 7;
                const int BTN_MIT410 = 8;
                /*
                 *  Read Info : 0
                 *  Download : 1
                 *  Select Target : 2
                 *  HID over USB : 4
                 *  MIT400 : 6
                 *  MIT401 : 7
                 *  MIT410 : 8
                */

        //LXS FW Updator 1.2.2 (Bulk Release Date : 2022-08-19 0952 기준 버튼
        static List<IntPtr> ChildBtnHandle;
        const int BTN_READ_INFO = 7;
        const int BTN_DOWNLOAD = 8;
        const int BTN_SELECT_TARGET = 3;
        const int BTN_HID = 6;
        const int BTN_I2C = 5;
        const int TBOX_TEXT_TARGET = 0;
        const int TBOX_TEXT_TARGET2 = 1;
        const int TBOX_TEXT_DEVICE = 2;
        const int BTN_VID = 2;
        /*
         *  Read Info : 0
         *  Download : 1
         *  Select Target : 2
         *  HID over USB : 4
         *  MIT400 : 6
         *  MIT401 : 7
         *  MIT410 : 8
        */

        static List<IntPtr> ChildEditHandle;
        const int EDIT_LOG = 0;
        /*
         * Log Edit : 0
        */

        static IntPtr SettingWindow;
        static List<IntPtr> ChildOpenWindowButton;
        static List<IntPtr> ChildOpenWindowEdit;

        static string CurrentPath;
        static string SetupInfoFile;
        int STATE_FLAG = 0;
        bool bFirstRunFlag = true;


        static string strDragMessage = "";

        System.Windows.Forms.Timer MitTimer = new System.Windows.Forms.Timer();


        static bool g_bIsRunMelfasApp = false;

        const string LXS_WINDOW_NAME = "LXS FW Updator v1.2.5 (Bulk) Release Date : 2022-11-10 09:26";
        public static void InitThread_Melfas()
        {
            KI.frm.TimerMelfasCheck.Interval =8000; //주기 설정
            KI.frm.TimerMelfasCheck.Tick += new EventHandler(Timer_MelfasMonitor); //주기마다 실행되는 이벤트 등록
            KI.frm.TimerMelfasCheck.Start();
        }

        [DllImport("kernel32.dll", EntryPoint = "Beep", SetLastError = true, ExactSpelling = true)]
        public static extern bool Beep(uint frequency, uint duration);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        static IntPtr Melfas_Ptr;

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        internal extern static Int32 SetCursorPos(Int32 x, Int32 y);
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        internal extern static Int32 mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private static void Timer_MelfasMonitor(object sender, System.EventArgs e)
        {
            if (g_bIsRunMelfasApp == false)
            {
                GetMITProcessChild();
                CLICK_XML_OPEN();
                g_bIsRunMelfasApp = true;
                ShowWindow(Melfas_Ptr, SW_SHOWMINIMIZED);
                System.Threading.Thread.Sleep(1000);
                InitMelfasTimer();
            }
        }

        public static void GetMITProcessChild()
        {
            try
            {
                CurrentPath = @"C:\KI\Spec";

                System.Threading.Thread.Sleep(1000);
                
                IntPtr SubParent = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "#32770", LXS_WINDOW_NAME);

                System.Threading.Thread.Sleep(1000);

                //MIT Downloader 가 없으면 실행
                if (SubParent == IntPtr.Zero)
                {
                    Process myProcess = new Process();
                    //ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(@"C:\KI\Spec\MitControl" + "\\MIT4XX_FactoryDownloader.exe");
                     ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(@"C:\KI\Spec\LXSControl" + "\\FWUpdate_M.exe");
                    myProcess.StartInfo = myProcessStartInfo;
                    myProcessStartInfo.WorkingDirectory = CurrentPath + "\\LXSControl";
                    myProcess.StartInfo = myProcessStartInfo;
                    myProcess.Start();
                    System.Threading.Thread.Sleep(1000);
                    //SubParent = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "#32770", "MIT4XX Factory Downloader v1.8");
                    SubParent = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "#32770", LXS_WINDOW_NAME);
                }

                //System.//Console.WriteLine("Parent Handle : {0}", SubParent);
                ChildBtnHandle = GetAllChildWindowHandles(SubParent, "Button", 100); //Button
                ChildEditHandle = GetAllChildWindowHandles(SubParent, "Edit", 100); //Edit
                //ShowWindow(SubParent, SW_SHOWMINIMIZED);

                Melfas_Ptr = SubParent;
            }
            catch
            {
                //Console.WriteLine("Can't open Melfas Downloader");
                //MessageBox.Show("Can't open MIT4XX Downloader\nClose this program");

                //Application.Exit();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
        public static bool CLICK_XML_OPEN()
        {
            CurrentPath = @"C:\KI\Spec";
           //SetupInfoFile = CurrentPath + "\\MitControl\\FileInformation.csv";
            SetupInfoFile = "TargetSpec.ini";

            if (ChildBtnHandle[BTN_SELECT_TARGET] == IntPtr.Zero) return false;
            PostMessage(ChildBtnHandle[BTN_SELECT_TARGET], WM_LBUTTONDOWN, IntPtr.Zero, IntPtr.Zero);
            PostMessage(ChildBtnHandle[BTN_SELECT_TARGET], WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);
            System.Threading.Thread.Sleep(1000);
            //DisplayMessage("[Success] Select Target Open", TYPE_NORMAL_MSG);

            //파일 열기 창에서 다운로드할 파일명 입력
            SettingWindow = FindWindow("#32770", "열기");
            if (SettingWindow == IntPtr.Zero)
            {
                //DisplayMessage("[Fail] Cannot find open window", TYPE_NORMAL_MSG);
                return false;
            }

            ChildOpenWindowButton = GetAllChildWindowHandles(SettingWindow, "Button", 100);
            List<IntPtr> ChildOpenComboEx = GetAllChildWindowHandles(SettingWindow, "ComboBoxEx32", 100);
            List<IntPtr> ChildOpenCombo = GetAllChildWindowHandles(ChildOpenComboEx[0], "ComboBox", 100);
            ChildOpenWindowEdit = GetAllChildWindowHandles(ChildOpenCombo[0], "Edit", 100);

            /*try
            {
                FileStream fs_File = new FileStream(SetupInfoFile, FileMode.Open, FileAccess.Read);
                StreamReader sr_File = new StreamReader(fs_File, Encoding.UTF8);

                string strFileName = sr_File.ReadLine();
                strFileName = sr_File.ReadLine();
                strFileName = sr_File.ReadLine();
                strFileName = strFileName.Replace("XML,", CurrentPath + "\\LXSControl\\");
                strFileName = strFileName.Replace(",", "");

                fs_File.Close();
                sr_File.Close();

                //DisplayMessage("[Success] Target File Select", TYPE_NORMAL_MSG);
                System.Threading.Thread.Sleep(1500);

                if (ChildOpenWindowEdit[0] == IntPtr.Zero) return false;
                SendMessage(ChildOpenWindowEdit[0], WM_SETTEXT, IntPtr.Zero, strFileName);           //파일명 붙여넣기
            }
            catch
            {
                //DisplayMessage("[Fail] FileInformation.csv File Not Found", TYPE_NORMAL_MSG);
                return false;
            }*/
            SendMessage(ChildOpenWindowEdit[0], WM_SETTEXT, IntPtr.Zero, SetupInfoFile);           // LXS 파일명 붙여넣기
            System.Threading.Thread.Sleep(1500);
            //DisplayMessage("[Success] File name paste", TYPE_NORMAL_MSG);

            if (ChildOpenWindowButton[0] == IntPtr.Zero) return false;
            PostMessage(ChildOpenWindowButton[0], WM_LBUTTONDOWN, IntPtr.Zero, IntPtr.Zero);    //확인 버튼 누르기
            PostMessage(ChildOpenWindowButton[0], WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);
            //DisplayMessage("[Success] XML File Load", TYPE_NORMAL_MSG);

            System.Threading.Thread.Sleep(500);

            return true;
        }

        static List<IntPtr> GetAllChildWindowHandles(IntPtr hParent, string classname, int maxCount)
        {
            List<IntPtr> result = new List<IntPtr>();
            int ct = 0;
            IntPtr prevChild = IntPtr.Zero;
            IntPtr currChild = IntPtr.Zero;
            while (true && ct < maxCount)
            {
                currChild = FindWindowEx(hParent, prevChild, classname, null);
                if (currChild == IntPtr.Zero) break;
                result.Add(currChild);
                prevChild = currChild;
                ++ct;
            }
            return result;
        }

        public static void SearchAndClearMsg()
        {
            try
            {
                IntPtr MessageBoxHandle = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "#32770", "MIT4XX_FactoryDownloader");
                if (MessageBoxHandle == IntPtr.Zero)
                {
                    return;
                }
                else
                {
                    List<IntPtr> SubStatic = GetAllChildWindowHandles(MessageBoxHandle, "Static", 100);
                    //Child Window Caption의 길이 구하기
                    int ChildTextLength = SendMessage(SubStatic[1], WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero) + 1;

                    //Child Window Caption의 길이만큼 공간할당
                    IntPtr ChildTextPtr = Marshal.AllocHGlobal(ChildTextLength);

                    //Child Window Caption의 포인터 가져오기
                    SendMessage(SubStatic[1], WM_GETTEXT, (IntPtr)ChildTextLength, ChildTextPtr);

                    //Child Window Caption 포인터를 문자열로 변환
                    String ChildText = Marshal.PtrToStringAnsi(ChildTextPtr, ChildTextLength);

                    string msg = string.Format("MIT MSG : {0}", ChildText);
                    //DisplayMessage(msg, TYPE_MIT_MSG);

                    //Child Window Caption 포인터 해제
                    Marshal.FreeHGlobal(ChildTextPtr);

                    List<IntPtr> SubBtnHandle = GetAllChildWindowHandles(MessageBoxHandle, "Button", 100);
                    if (SubBtnHandle[0] == IntPtr.Zero)
                    {

                    }
                    else
                    {
                        PostMessage(SubBtnHandle[0], WM_LBUTTONDOWN, IntPtr.Zero, IntPtr.Zero);
                        PostMessage(SubBtnHandle[0], WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }
            catch
            {

            }
        }
        public static bool Drag_Copy()
        {
            try
            {
                if (ChildEditHandle[EDIT_LOG] == IntPtr.Zero) return false;

                int ChildTextLength = SendMessage(ChildEditHandle[EDIT_LOG], WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero) + 1;
                IntPtr ChildTextPtr = Marshal.AllocHGlobal(ChildTextLength);
                SendMessage(ChildEditHandle[EDIT_LOG], WM_GETTEXT, (IntPtr)ChildTextLength, ChildTextPtr);
                //System.Threading.Thread.Sleep(10);
                String ChildText = Marshal.PtrToStringAnsi(ChildTextPtr, ChildTextLength);

                strDragMessage = ChildText;

                Marshal.FreeHGlobal(ChildTextPtr);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private static DateTime Delay_ms(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
        private static void InitMelfasTimer()
        {
            Thread pCheckThread = new Thread(Timer_ProcMelfas);
            pCheckThread.IsBackground = true;
            pCheckThread.Start();
        }

        static int g_nMelfasStep = 0;
        static bool g_bIsMelfasRun = false;
        static int g_nMelfasJobResult = 0; //0이면 Fail, 1이면 OK, 2면 동작중

        static bool g_bIsFirstTime = true;

        static int g_nBusyTime = 0;

        static int g_nMelfasRunMode = 0;   //0이면 동작안함, 1이면 Write, 2이면 Read/Verify

        const int MELFAS_NG = 0;
        const int MELFAS_OK = 1;
        const int MELFAS_ING = 2;

        const int MELFAS_STATE_STOP = 0;
        const int MELFAS_STATE_WRITE = 1;
        const int MELFAS_STATE_READ = 2;

        public static void ModeChange_Write()
        {
            g_nMelfasRunMode = MELFAS_STATE_WRITE;
        }

        public static void ModeChange_Read()
        {
            g_nMelfasRunMode = MELFAS_STATE_READ;
        }

        private static void Timer_ProcMelfas()
        {
            byte[] tx_buff = new byte[1];
            while (true)
            {
                Thread.Sleep(100);

                SearchAndClearMsg(); //MIT 프로그램에서 에러 메세지박스 뜨면 창 끄기
                //Console.WriteLine("MELFAS_STATE_STOP = {0}", MELFAS_STATE_STOP);
                //Console.WriteLine("g_nMelfasStep = {0}", g_nMelfasStep);

                if (g_nMelfasRunMode == MELFAS_STATE_STOP)
                {
                    //Console.WriteLine("Change Here 1");
                    g_nMelfasStep = 0;
                    g_nMelfasJobResult = MELFAS_ING;
                    g_nBusyTime = 0;
                    g_bIsMelfasRun = false;
                    //g_nMelfasRunMode = MELFAS_STATE_STOP;
                    //Console.WriteLine("Change Here 2");
                }
                else if (g_nMelfasRunMode == MELFAS_STATE_WRITE)
                {
                    //Console.WriteLine("Something hera 1");

                    switch (g_nMelfasStep)
                    {
                        case 0:
                            Console.WriteLine("Melfas Write Step 0");
                            g_nMelfasStep = 1;
                            break;
                        case 1:
                            //전원 투입, 릴레이 켜기
                            Console.WriteLine("Melfas Write Step 1");
                            g_nMelfasStep = 2;
                            break;
                        case 2:
                            Console.WriteLine("Melfas Write Step 2");
                            try
                            {
                                PostMessage(ChildBtnHandle[BTN_DOWNLOAD], WM_LBUTTONDOWN, IntPtr.Zero, IntPtr.Zero);
                                Thread.Sleep(500);
                                PostMessage(ChildBtnHandle[BTN_DOWNLOAD], WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);

                                //Delay_ms(1000);
                                System.Threading.Thread.Sleep(5000);

                                g_nMelfasStep = 3;
                            }
                            catch
                            {

                            }
                            break;
                        case 3:
                            //메세지 드래그  -> 판단

                            Console.WriteLine("Melfas Write Step 3");
                            Drag_Copy();

                          //  strDragMessage = strDragMessage.Replace(" ", "");
                            string[] splitS = strDragMessage.Split('\n');

                            //if (splitS[splitS.Length - 1] == "PASS")
                            Console.WriteLine("index pass = "+ splitS[splitS.Length - 1].IndexOf("PASS").ToString());
                            if (splitS[splitS.Length - 1].IndexOf("PASS") == 11)
                            {
                                //Melfas_Power(false);
                                System.Threading.Thread.Sleep(200);
                                g_nMelfasJobResult = MELFAS_OK;
                                serial.tx_bd(MFS_PASS, 1, tx_buff);
                                g_nMelfasRunMode = MELFAS_STATE_STOP;
                                //g_bIsMelfasRun = false;
                            }
                            //else if (splitS[splitS.Length - 1] == "FAIL!!!")
                            else if (splitS[splitS.Length - 1].IndexOf("FAIL") == 4)    //8)
                            {

                                Console.WriteLine("else if (splitS[splitS.Length - 1].IndexOf(FAIL) == 0)");
                                //Melfas_Power(false);
                                System.Threading.Thread.Sleep(200);
                                g_nMelfasJobResult = MELFAS_NG;
                                serial.tx_bd(MFS_FAIL, 1, tx_buff );
                                g_nMelfasRunMode = MELFAS_STATE_STOP;
                                //g_bIsMelfasRun = false;
                            }
                            else
                            {
                                g_nBusyTime++;
                                if (g_nBusyTime >= 200)  // Firmware Downlaod 소요시간 limit 100ms * 200 = 20sec
                                {
                                    //Time Out
                                    //Melfas_Power(false);
                                    System.Threading.Thread.Sleep(200);
                                    g_nMelfasJobResult = MELFAS_NG;
                                    serial.tx_bd(MFS_FAIL, 1, tx_buff );
                                    g_nMelfasRunMode = MELFAS_STATE_STOP;
                                }
                                else
                                {
                                    //Do nothing
                                }
                            }
                            break;
                    }
                }
                else if (g_nMelfasRunMode == MELFAS_STATE_READ)
                {
                    Console.WriteLine("Something hera 2");

                    switch (g_nMelfasStep)
                    {
                        case 0:
                            g_nMelfasJobResult = MELFAS_ING;
                            Delay_ms(500);
                            g_nMelfasStep = 1;
                            break;
                        case 1:
                            g_nMelfasStep = 2;

                            break;
                        case 2:
                            try
                            {
                                PostMessage(ChildBtnHandle[BTN_READ_INFO], WM_LBUTTONDOWN, IntPtr.Zero, IntPtr.Zero);
                                PostMessage(ChildBtnHandle[BTN_READ_INFO], WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);
                                Delay_ms(2500);
                                g_nMelfasStep = 3;
                            }
                            catch
                            {

                            }
                            break;
                        case 3:
                            //메세지 드래그  -> 판단
                            Drag_Copy();

                            strDragMessage = strDragMessage.Replace(" ", "");
                            string[] splitS = strDragMessage.Split('\n');
                            if (splitS[splitS.Length - 1].IndexOf("PASS") == 11)
                            {
                                g_nMelfasJobResult = MELFAS_OK;
                                serial.tx_bd(MFS_PASS, 1, tx_buff );
                                g_nMelfasRunMode = MELFAS_STATE_STOP;
                            }
                            else if (splitS[splitS.Length - 1].IndexOf("FAIL") == 8)
                            {
                                g_nMelfasJobResult = MELFAS_NG;
                                serial.tx_bd(MFS_FAIL, 1, tx_buff );
                                g_nMelfasRunMode = MELFAS_STATE_STOP;
                            }
                            else
                            {
                                g_nBusyTime++;
                                if (g_nBusyTime >= 200)  // Firmware Downlaod 소요시간 limit 100ms * 50 = 5sec
                                {
                                    //Time Out
                                    g_nMelfasJobResult = MELFAS_NG;
                                    serial.tx_bd(MFS_FAIL, 1, tx_buff);
                                    g_nMelfasRunMode = MELFAS_STATE_STOP;
                                }
                                else
                                {
                                    //Do nothing
                                }
                            }
                            break;
                    }
                }
            }

        }
    }
}