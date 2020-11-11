using HalconHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]//取设备场景
        private static extern IntPtr GetDC(IntPtr hwnd);//返回设备场景句柄

        [DllImport("gdi32.dll")]//取指定点颜色
        private static extern int GetPixel(IntPtr hdc, System.Drawing.Point p);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 通过句柄获取窗口尺寸信息
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        //按顺序布局排列结构体
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;                            //最左坐标
            public int Top;                             //最上坐标
            public int Right;                           //最右坐标
            public int Bottom;                          //最下坐标
        }


        SerialPort serial = new SerialPort();
        INIClass ini = new INIClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] serialcom = SerialPort.GetPortNames();
            foreach (var item in serialcom)
            {
                cb_com.Items.Add(item);
            }

            if (ini.IniReadValue("Serial", "Port") != string.Empty || ini.IniReadValue("Serial", "Port") != "")
            {
                cb_com.SelectedItem = ini.IniReadValue("Serial", "Port");
            }
            else
            {
                cb_com.SelectedItem = cb_com.Items[0];
            }

            int[] boty = { 2400, 4800, 9600, 19200 };
            foreach (var item in boty)
            {
                cb_boty.Items.Add(item.ToString());
            }
            if (ini.IniReadValue("Serial", "Boty") != string.Empty || ini.IniReadValue("Serial", "Boty") != "")
            {
                cb_boty.SelectedItem = ini.IniReadValue("Serial", "Boty");
            }
            else
            {
                cb_boty.SelectedItem = cb_com.Items[2];
            }


            if (ini.IniReadValue("Order", "OK") != string.Empty || ini.IniReadValue("Order", "OK") != "")
            {
                tb_OK.Text = ini.IniReadValue("Order", "OK");
            }

            if (ini.IniReadValue("Order", "NG") != string.Empty || ini.IniReadValue("Order", "NG") != "")
            {
                tb_NG.Text = ini.IniReadValue("Order", "NG");
            }

           

        }
        /// <summary>
        /// /打开或关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                if (serial.IsOpen)
                {
                    cb_com.Enabled = true;
                    cb_boty.Enabled = true;
                    tb_NG.Enabled = true;
                    tb_OK.Enabled = true;
                    bn_sure.BackColor = Color.White;
                    bn_sure.Text = "打开";
                    serial.Close();

                }
                else
                {
                    cb_com.Enabled = false;
                    cb_boty.Enabled = false;
                    tb_NG.Enabled = false;
                    tb_OK.Enabled = false;
                    bn_sure.BackColor = Color.Green;
                    bn_sure.Text = "关闭";
                    serial.PortName = cb_com.SelectedItem.ToString();
                    serial.BaudRate = Convert.ToInt32(cb_boty.SelectedItem.ToString());
                    serial.Parity = Parity.None;
                    serial.DataBits = 8;
                    serial.Handshake = Handshake.None;
                    serial.Open();

                    ini.IniWriteValue("Serial", "Port", cb_com.SelectedItem.ToString());
                    ini.IniWriteValue("Serial", "Boty", cb_boty.SelectedItem.ToString());
                    ini.IniWriteValue("Order", "OK", tb_OK.Text);
                    ini.IniWriteValue("Order", "NG", tb_NG.Text);
                    Thread th_Point = new Thread(new ThreadStart(Point_Color));
                    th_Point.Start();


                    Thread th_GetMes = new Thread(MesState);
                    th_GetMes.Start();
                }
            }
            catch (Exception)
            {


            }


            //Process[] pro = Process.GetProcesses();
            //string[] proName = new string[pro.Count()];
            //for (int i = 0; i < pro.Count(); i++)
            //{
            //    proName[i] = pro[i].ProcessName;
            //}
            ////IntPtr a = GetForegroundWindow();
            //GetMESState();


        }

        //string txtPath = Path.GetFullPath("Error.txt");
        bool IsGetPoint = false;
        /// <summary>
        /// 获取鼠标坐标和颜色
        /// </summary>
        public void Point_Color()
        {


            while (true)
            {
                Thread.Sleep(200);
                try
                {
                    if (IsGetPoint)
                    {
                        this.Invoke(new Action(() =>
                        {

                            System.Drawing.Point p = new System.Drawing.Point(MousePosition.X, MousePosition.Y);//取置顶点坐标
                            IntPtr hdc = GetDC(new IntPtr(0));//取到设备场景(0就是全屏的设备场景)
                            string txtStartX = MousePosition.X.ToString();
                            string txtStartY = MousePosition.Y.ToString();
                            //label7.Text = "坐标：X:" + txtStartX + ",Y:" + txtStartY;
                            int c = GetPixel(hdc, p);//取指定点颜色
                            int r = (c & 0xFF);//转换R
                            int g = (c & 0xFF00) / 256;//转换G
                            int b = (c & 0xFF0000) / 65536;//转换B
                            //picturePintColor.BackColor = Color.FromArgb(r, g, b);
                            //label8.Text = "RGB:" + r.ToString() + "," + g.ToString() + "," + b.ToString();
                        }));
                    }

                }
                catch (Exception ex)
                {
                    //string txtPath = Path.GetFullPath("Error.txt");
                    DataFunction.txtWrite(ex.ToString());

                }


            }

        }

        private void bn_Point_Click(object sender, EventArgs e)
        {
            if (IsGetPoint)
            {
                IsGetPoint = false;
            }
            else
            {
                IsGetPoint = true;
            }
        }



        /// <summary>
        /// 窗体的原点坐标
        /// </summary>
        int yuanPointX = 0;
        int yuanPointY = 0;

        /// <summary>
        /// 获取MES状态
        /// </summary>
        public List<MesStateClass> GetMESState()
        {

            List<MesStateClass> MesStateList = new List<MesStateClass>();
            IntPtr NodeHwnd = (IntPtr)0;
            ///通过类名标题找句柄
            IntPtr maindHwnd = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r6_ad1", null); //获得句柄   
                                                                                                 ///通过进程
            //Process[] pro = Process.GetProcessesByName("IMEI_Check");
            //maindHwnd = Process.GetProcessesByName("IMEI_Check")[0].MainWindowHandle;
            ///找到窗口句柄的坐标
            RECT mRect = new RECT();
            ///窗口是否找到
            bool IsGet = GetWindowRect(maindHwnd, ref mRect);
            string RunState = string.Empty;
            string LinkState = string.Empty;
            if (IsGet)
            {
                int x, y;
                x = mRect.Right - mRect.Left;
                y = mRect.Bottom - mRect.Top;
                yuanPointX = mRect.Left;
                yuanPointY = mRect.Top;
                ini.IniWriteValue("modelPoint", "YuanPoint", yuanPointX.ToString() + " " + yuanPointY.ToString());
                //创建一个和屏幕一样大的Bitmap  
                Image myImage = new Bitmap(x, y);
                //从一个继承自Image类的对象中创建Graphics对象  
                Graphics g = Graphics.FromImage(myImage);
                string imgpath = Path.GetFullPath("images");
                imgpath += "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                //抓屏并拷贝到myimage里 
                g.CopyFromScreen(new System.Drawing.Point(mRect.Left, mRect.Top), new System.Drawing.Point(0, 0), new System.Drawing.Size(mRect.Right - mRect.Left, mRect.Bottom - mRect.Top));
                //保存为文件 
                //myImage.Save(imgpath);
                Bitmap map = (Bitmap)myImage;


                ////运行状态
                int MesStateX = Convert.ToInt32(ini.IniReadValue("MesStatePoint", "X"));
                int MesStateY = Convert.ToInt32(ini.IniReadValue("MesStatePoint", "Y"));

                Color RunpixelColor = map.GetPixel(MesStateX, MesStateY);
                //像素点颜色的 Alpha 值
                byte Runalpha = RunpixelColor.A;
                //颜色的 RED 分量值
                byte Runred = RunpixelColor.R;
                //颜色的 GREEN 分量值
                byte Rungreen = RunpixelColor.G;
                //颜色的 BLUE 分量值
                byte Runblue = RunpixelColor.B;
                //string RunState = string.Empty;

                if (Runred == 0 && Rungreen >= 128 && Runblue == 0)
                {
                    ///绿色
                    RunState = "OK";
                }
                else if (Runred == 255 && Rungreen == 0 && Runblue == 0)
                {
                    ///红色
                    RunState = "NG";
                }
                else
                {
                    RunState = "NO";
                }

                MesStateClass MesState = new MesStateClass();
                MesState.RunState = RunState;
                MesStateList.Add(MesState);
            }
            return MesStateList;
        }


        Bitmap IMgbit;
        /// <summary>
        /// 获取MesState
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public bool IsMesState(string FileName)
        {
            bool IsTrue = false;

            IMgbit = new Bitmap(FileName);
            string ModelStr = Path.GetFullPath("ModelImg");
            ModelStr += "\\Model.dfm";
            //ModelBit = new Bitmap(ModelStr);
            HalconHelper.TemplateMatching templateMatching = new TemplateMatching();
            var result = templateMatching.Findtemplates(new HalconHelper.HalconCommonly().FromBitmap32(IMgbit), ModelStr); //模板路径 //图像
            if (result.Count() > 0)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].value > 0.9)
                    {
                        IsTrue = true;
                        i = result.Count;
                    }
                }
            }
            else
            {
                IsTrue = false;

            }
            IMgbit.Dispose();
            return IsTrue;
        }



        /// <summary>
        /// 保存的图片
        /// </summary>
        byte[] SaveimgByte;
        string SaveImgstr;
        /// <summary>
        /// 获取MES状态
        /// </summary>
        public void MesState()
        {

            //获得当前屏幕的分辨率   
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            //创建一个和屏幕一样大的Bitmap  
            Image myImage = new Bitmap(iWidth, iHeight - 50);
            //Image myImage = new Bitmap(688, 520);
            //从一个继承自Image类的对象中创建Graphics对象  
            Graphics g = Graphics.FromImage(myImage);
            while (true)
            {
                try
                {
                    Thread.Sleep(20);
                    if (serial.IsOpen)
                    {
                        string imgpath = Path.GetFullPath("images");
                        imgpath += "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";

                        //抓屏并拷贝到myimage里 
                        g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
                        //保存为文件
                        myImage.Save(imgpath);

                        //string Contrast_picturePath = imgpath;
                        //byte[] JieTuByte = DataFunction.GetImageByte(Contrast_picturePath);
                        string jietustr = DataFunction.GetBase64StringByImage(myImage);
                        //myImage.Dispose();
                        if (jietustr == SaveImgstr)
                        {
                            string Write = "相同图片";

                        }
                        else
                        {
                            SaveImgstr = jietustr;
                            string Writestr = string.Empty;
                            string Runstate = string.Empty;
                            this.Invoke(new Action(() =>
                            {

                                if (IsMesState(imgpath))
                                {
                                    Writestr = tb_OK.Text;
                                }
                                else
                                {
                                    Writestr = tb_NG.Text;
                                }
                            }));

                            Runstate = Writestr;

                            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(Writestr);
                            Writestr = HexStringTenByte.ByteArrayToHexString(byteArray);
                            byte[] buff = HexStringTenByte.HexString2Bytes(Writestr);
                            serial.Write(buff, 0, buff.Length);
                            this.Invoke(new Action(() =>
                            {
                                this.lb_send.Text = "Send:" + DateTime.Now.ToString("HH:mm:ss");
                                this.tb_send.Text = Runstate;
                            }));

                        }
                        string ImgPath = Path.GetFullPath("images");
                        int FileNum = DataFunction.GetFileNum(ImgPath);
                        if (FileNum >= 10)
                        {
                            DataFunction.DelectDir(ImgPath);
                        }
                        GC.Collect();

                    }


                }
                catch (Exception ex)
                {

                    DataFunction.txtWrite(ex.ToString());
                }
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TS = MessageBox.Show("您确认要确认退出吗？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TS == DialogResult.Yes)
            {
                Process[] _processes = Process.GetProcessesByName("MarkingMachine");
                Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                //最小化  
                if (this.WindowState == FormWindowState.Minimized)
                {
                    //不显示窗体  
                    this.ShowInTaskbar = false;
                    //托盘可见  
                    this.notifyIcon1.Visible = true;

                    //气球提示           
                    this.notifyIcon1.ShowBalloonTip(3, "提示", "系统仍在运行！\n如要打开，请点击图标", ToolTipIcon.Info);

                }
            }
            catch (Exception)
            {

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                //notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetROI roi = new SetROI();
            roi.Show();
        }
    }






    public class MesStateClass
    {

        public string RunState { get; set; }



    }



}
