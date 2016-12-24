using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//需要引入命名的空间
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace gcsj3s
{
    public partial class Form1 : Form
    {  
        bool isOpen = false;//打开串口标志位
        bool isSend = false;//是否通过TCP连接发送

        Socket newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            cbxComPort.SelectedIndex = 2;
            cbxBps.SelectedIndex = 7;

            tbxTemp.Text = "";
            tbxTempTime.Text = "";
            tbxGas.Text = "";
            tbxGasTime.Text = "";

            tbxTemp.ReadOnly = true;
            tbxTempTime.ReadOnly = true;
            tbxGas.ReadOnly = true;
            tbxGasTime.ReadOnly = true;

        }

        private void btnOpenComPort_Click(object sender, EventArgs e)  //打开串口
        {
            try
            {
                if (isOpen == false)
                {
                    isOpen = true;
                    cbxComPort.Enabled = false;
                    cbxBps.Enabled = false;//端口和波特率都不能再更改

                    sp = new SerialPort();
                    sp.PortName = cbxComPort.SelectedItem.ToString();
                    sp.BaudRate = Convert.ToInt32(cbxBps.SelectedItem.ToString());
                    sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    sp.Open();

                    MessageBox.Show("打开成功！");
                }
                else if (isOpen == true)
                {
                    MessageBox.Show("该串口已经打开！");
                }
            }
            catch (Exception ex)
            {
                //打开失败，将标志位还原
                isOpen = false;
                cbxComPort.Enabled = true;
                cbxBps.Enabled = true;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCloseComPort_Click(object sender, EventArgs e)//关闭串口
        {
            try
            {
                if (isOpen == true)
                {
                    isOpen = false;
                    cbxComPort.Enabled = true;
                    cbxBps.Enabled = true;

                    sp.Close();
                    MessageBox.Show("关闭成功！");
                }
                else if(isOpen == false)
                {
                    MessageBox.Show("该串口已经关闭！");
                }
            }
            catch(Exception ex)
           {
                //关闭失败
                isOpen = true;
                cbxComPort.Enabled = false;
                cbxBps.Enabled = false;
                MessageBox.Show(ex.Message);
           } 
        }

        private void btnClearBuf_Click(object sender, EventArgs e)//清空显示缓冲
        {
            tbxTemp.Text = "";
            tbxTempTime.Text = "";
            tbxGas.Text = "";
            tbxGasTime.Text = "";
        }

        private void btnEsc_Click(object sender, EventArgs e)//退出
        {
            newclient.Close();
            this.Close();
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口实时接收数据事件
        {
            String str = sp.ReadExisting();
            int index = str.IndexOf("WD");
            if (index != -1)
            {
                String deviceId = "1";  //设备ID

                Regex expressions1 = new Regex(@"WD:+(\d\d)");
                Match match1 = expressions1.Match(str);
                String buf = match1.ToString();
                Regex expressions2 = new Regex(@"\d\d");
                Match match2 = expressions2.Match(buf);
                String temp = match2.ToString();        //得到温度数据的字符串格式
                tbxTemp.Text = temp + "\r\n" + tbxTemp.Text;

                String time = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");  //获取当前接受到的数据的时间
                tbxTempTime.Text = time + "\r\n" + tbxTempTime.Text;

                String frame = deviceId + temp + time;  //组装成帧
                if (isSend)
                    sendMsg(frame);//发送
 
            }
            else
            {
                String deviceId = "2";  //设备ID

                Regex expressions1 = new Regex(@"QT:+(\d\d\d)");
                Match match1 = expressions1.Match(str);
                String buf = match1.ToString();
                Regex expressions2 = new Regex(@"\d\d\d");
                Match match2 = expressions2.Match(buf);
                String gas = match2.ToString();  //得到气体数据的字符串格式
                tbxGas.Text = gas + "\r\n" + tbxGas.Text;

                String time = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");  //获取当前接受到的数据的时间
                tbxGasTime.Text = time + "\r\n" + tbxGasTime.Text ;

                String frame = deviceId + gas + time;  //组装成帧
                if (isSend)
                    sendMsg(frame);//发送
            }
        }

        private String Encrypt(String encryptStr)  //AES加密函数
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789012");  //密钥
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();  //创建加密器
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);  //返回加密后的字符串
        }

        private void estbCon()  //TCP建立连接函数
        {
            byte[] buf = new byte[1024];
            String ip = tbxIP.Text;
            if (tbxIP.Text == "")
            {
                MessageBox.Show("请输入ip地址");
                return;
            }

            int port = 9050;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);//服务器的IP和端口  
            try
            {
                //因为客户端只是用来向特定的服务器发送信息，所以不需要绑定本机的IP和端口。不需要监听。  
                newclient.Connect(ie);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            int recvlen = newclient.Receive(buf);
            string stringdata = Encoding.ASCII.GetString(buf, 0, recvlen);
            tbxConInfo.Text = tbxConInfo.Text + stringdata + "\r\n";

        }

        private void sendMsg(String msg)  //TCP发送函数
        {

            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(Encrypt(msg));  //调用AES函数加密要发送的信息

            try
            {
                newclient.Send(data);//发送
            }
            catch (Exception ex)
            {
                newclient.Shutdown(SocketShutdown.Both);
                newclient.Close();
                isSend = false;   //出错不再发送
                MessageBox.Show(ex.ToString());
            }
            tbxIP.Enabled = false;
            btnCon.Enabled = false;
        }

        private void btnCon_Click(object sender, EventArgs e)  //建立连接
        {
            estbCon();
        }

        private void btnStop_Click(object sender, EventArgs e)  //暂停发送
        {
            isSend = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }


        private void btnStart_Click(object sender, EventArgs e)  //发送
        {
            isSend = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

    }
}
