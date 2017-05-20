using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Threading;
using System.Text;

namespace 图像处理
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        #region 文件操作事件||打开、关闭
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp,*.jpeg, *.jpg, *.png)|*.bmp;*.jpeg;*.jpg;*.png ";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            label3.Text = null;
            label5.Text = null;
            label7.Text = null;
            label9.Text = null;
            label10.Text = null;
            label1.Text = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                
            }
        }
        
        /// <summary>
        /// 关闭应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

       
        #region 图像处理事件

        /// <summary>
        /// 灰度化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gray_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double time;
            //在代码开始计时
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计算
            //代码块
            Bitmap bmp1 = pictureBox1.Image as Bitmap;
            ImagePro.GrayScale(bmp1);
            pictureBox1.Image = bmp1;
            //代码块结束
            sw.Stop();//结束计时
            //单位转换            
            time = sw.ElapsedMilliseconds / 1000.000;
            label7.Text = "共" + time.ToString() + "秒";
        }
        /// <summary>
        /// 二值化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Binarize_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double time;
            //在代码开始计时
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计算
            //代码块
            Bitmap bmp2 = pictureBox1.Image as Bitmap;
            try
            {
                List<string> list = null;
                list = OperateXml.getAllXml();
                string yuzhi = list[0].ToString();
                ImagePro.Binarize(bmp2, yuzhi);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid usage!");
                Console.WriteLine("Usage: grey source object");
            }
            pictureBox1.Image = bmp2;
            //代码块结束
            sw.Stop();//结束计时
            //单位转换            
            time = sw.ElapsedMilliseconds / 1000.000;
            label9.Text = "共" + time.ToString() + "秒";
        }



        /// <summary>
        /// 获取其中黑色像素点所占百分比,得出损坏等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetTargetPix_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = pictureBox1.Image as Bitmap;//获取处理后的对象             
            long blackPixel = ImagePro.CalculateBlackPixel(bmp);
            long allPixel = ImagePro.CalculateAllPixel(bmp);
            double Percent = blackPixel / allPixel;
            label3.Text = string.Format("{0:f1}", Percent) + "百万分比";
            if (Percent > 40.0)
            {
                label10.Text = "5";
            }
            else if (Percent > 30.0 && Percent < 40.0)
            {
                label10.Text = "4";
            }
            else if (Percent > 20.0 && Percent < 30.0)
            {
                label10.Text = "3";
            }
            else if (Percent < 20.0 && Percent > 10.0)
            {
                label10.Text = "2";//算好的
            }
            else if (Percent < 10.0)
            {
                label10.Text = "1";//算优良的
            }
            getConnection(label10.Text);//写入串口，传出数据
        }
        /// <summary>
        /// 修改二值化阈值等参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditXmlData_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form2 = new SettingForm();            
            form2.Show();
            form2.Activate();
        }
        
        #endregion
       
       
        #region 自动运行事件


        /// <summary>
        /// 配合工业相机自动化运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoRun_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(ThreadMethod)); //也可简写为new Thread(ThreadMethod);                
            th.Start(); //启动线程
            while (OperateXml.getAllXml()[2].ToString() == "是")//判断配置文件中参数
            {
                //执行图像处理代码
                //1、读取文件
                String path = OperateXml.getAllXml()[1].ToString();//读取配置中路径字符串
                DirectoryInfo folder = new DirectoryInfo(path);               
                //1、先处理
                if (folder.GetFiles("*.jpg").Length>=1)
                {
                    Bitmap bmp = new Bitmap(folder.GetFiles("*.jpg")[0].FullName);//创建图像对象
                    try
                    {
                        List<string> list = null;
                        list = OperateXml.getAllXml();
                        string yuzhi = list[0].ToString();
                        ImagePro.GrayScale(bmp);//灰度化
                        ImagePro.Binarize(bmp, yuzhi);//二值化

                        #region 计算黑度值,所占百分比

                        long blackPixel = ImagePro.CalculateBlackPixel(bmp);
                        long allPixel = ImagePro.CalculateAllPixel(bmp);
                        double Percent = blackPixel / allPixel;
                                              
                        bmp.Dispose();//释放资源，才可以执行下一步删除操作
                        #endregion

                        #region 得出等级
                        if (Percent > 40.0)
                        {
                            
                            getConnection("5");
                        }
                        else if (Percent > 30.0 && Percent < 40.0)
                        {
                            
                            getConnection("4");
                        }
                        else if (Percent > 20.0 && Percent < 30.0)
                        {
                            getConnection("3");
                        }
                        else if (Percent < 20.0 && Percent > 10.0)
                        {
                            getConnection("2");//算好的
                        }
                        else if (Percent < 10.0)
                        {
                            getConnection("1");//算优良的
                        }
                       

                        #endregion

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid usage!");
                        Console.WriteLine("Usage: grey source object");
                    }
                    //2、删除                    
                    folder.GetFiles("*.jpg")[0].Delete();                
                }
                else
                {
                    if (MessageBox.Show("路径下没有图片！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning)==DialogResult.OK)
                    {
                        // 关闭所有的线程
                        this.Dispose();
                        this.Close();
                        System.Environment.Exit(0);
                    }                        
                }                
                //读取配置中间隔时间                
                Thread.Sleep(Convert.ToInt32(OperateXml.getAllXml()[3].ToString()));//等待一定时长
            }
            th.Join(); //主线程等待辅助线程结束                            
        }

        /// <summary>
        /// 灰度化与二值化一步到位，辅助进程
        /// </summary>
        static void ThreadMethod()
        {            
            Thread.Sleep(0); 
        }

        private void StopRun_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { "","","否",""};
            OperateXml.modifyXml(str);
        }
        #endregion

        #region 串口库
        
        private void getConnection( string str)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            serialPort.BaudRate = 4800;
            serialPort.DataBits = 8;
            #region 设置成hex发送

            //处理数字转换
            string sendBuf = str;
            string sendnoNull = sendBuf.Trim();
            string sendNOComma = sendnoNull.Replace(',', ' ');    //去掉英文逗号
            string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号
            string strSendNoComma2 = sendNOComma1.Replace("0x", "");   //去掉0x
            strSendNoComma2.Replace("0X", "");   //去掉0X
            string[] strArray = strSendNoComma2.Split(' ');

            int byteBufferLength = strArray.Length;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] == "")
                {
                    byteBufferLength--;
                }
            }
            // int temp = 0;
            byte[] byteBuffer = new byte[byteBufferLength];
            int ii = 0;
            for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
            {
                Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);
                int decNum = 0;
                if (strArray[i] == "")
                {
                    //ii--;     //加上此句是错误的，下面的continue以延缓了一个ii，不与i同步
                    continue;
                }
                else
                {
                    decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                }

                try    //防止输错，使其只能输入一个字节的字符
                {
                    byteBuffer[ii] = Convert.ToByte(decNum);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                    return;
                }
                ii++;
            }
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.PortName = ports[0].ToString();
            try
            {
                serialPort.Open();
                serialPort.Write(byteBuffer, 0, byteBuffer.Length);
            }
            catch
            {
                MessageBox.Show("没发现次串口或串口已经在使用");
            }


            #endregion            
        }

        #endregion







    }
}
