using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;

namespace serialPortTransmitForNavigation
{
    public partial class SerialPortForm : Form
    {
        private SerialPort serialPortCom1;// = new SerialPort();
        private SerialPort serialPortCom2;// = new SerialPort();
        private static bool IfTransmit = true;
        private static bool IsAutoReplaceForward = false;

        StreamWriter ErrorInfo;//错误日志
        StreamWriter serialPort1Info;//串口1日志
        StreamWriter serialPort2Info;//串口1日志

        bool isObsCanUse = false;


        private static UInt16[] crc_tabccitt = new UInt16[256];
        private static Boolean crc_tabccitt_init = false;
        public SerialPortForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void SerialPortForm_Load(object sender, EventArgs e)
        {
            string[] PortList = SerialPort.GetPortNames();
            //初始化串口1配置
            foreach (string portName in PortList)
                cBox_portNameCom1.Items.Add(portName);
            if (PortList.Length > 0)
                cBox_portNameCom1.SelectedIndex = 1;
            else
                cBox_portNameCom1.SelectedIndex = -1;
            cBox_baudRateCom1.SelectedIndex = cBox_baudRateCom1.Items.IndexOf("19200");
            cBox_dataBitsCom1.SelectedIndex = cBox_dataBitsCom1.Items.IndexOf("8");
            cBox_parityCom1.SelectedIndex = cBox_parityCom1.Items.IndexOf("无");
            cBox_stopBitsCom1.SelectedIndex = cBox_stopBitsCom1.Items.IndexOf("1");
            cBox_handShakeCom1.SelectedIndex = cBox_handShakeCom1.Items.IndexOf("None");

            //初始化串口2配置
            foreach (string portName in PortList)
                cBox_portNameCom2.Items.Add(portName);
            if (PortList.Length > 0)
                cBox_portNameCom2.SelectedIndex = 1;
            else
                cBox_portNameCom2.SelectedIndex = -1;
            cBox_baudRateCom2.SelectedIndex = cBox_baudRateCom1.Items.IndexOf("19200");
            cBox_dataBitsCom2.SelectedIndex = cBox_dataBitsCom1.Items.IndexOf("8");
            cBox_parityCom2.SelectedIndex = cBox_parityCom1.Items.IndexOf("无");
            cBox_stopBitsCom2.SelectedIndex = cBox_stopBitsCom1.Items.IndexOf("1");
            cBox_handShakeCom2.SelectedIndex = cBox_handShakeCom1.Items.IndexOf("None");

            checkDirectoryFile();
        }
        private void btn_openOrCloseCom1_Click(object sender, EventArgs e)
        {
            if (btn_openOrCloseCom1.Text == "打开串口")
            {
                string portName = cBox_portNameCom1.Text;
                string BaudRate = cBox_baudRateCom1.Text;
                string parity = cBox_parityCom1.Text;
                string dataBits = cBox_dataBitsCom1.Text;
                string stopBits = cBox_stopBitsCom1.Text;
                serialPortCom1 = new SerialPort();
                if (serialPortCom2 != null && serialPortCom2.IsOpen && portName == serialPortCom2.PortName)
                    MessageBox.Show("该端口已在Com2中打开");
                else
                {
                    OpenSerialPort(serialPortCom1, portName, BaudRate, parity, dataBits, stopBits);
                    if (serialPortCom1.IsOpen)
                    {
                        lab_statusCom1.Text = "打开";
                        btn_openOrCloseCom1.Text = "关闭串口";
                        serialPortCom1.DataReceived += new SerialDataReceivedEventHandler(SerialPortCom1_DataReceived);
                    }
                }
            }
            else
            {
                serialPortCom1.Close();
                if (!serialPortCom1.IsOpen)
                {
                    lab_statusCom1.Text = "关闭";
                    btn_openOrCloseCom1.Text = "打开串口";
                }
            }
        }

        private void btn_openOrCloseCom2_Click(object sender, EventArgs e)
        {
            if (btn_openOrCloseCom2.Text == "打开串口")
            {
                string portName = cBox_portNameCom2.Text;
                string BaudRate = cBox_baudRateCom2.Text;
                string parity = cBox_parityCom2.Text;
                string dataBits = cBox_dataBitsCom2.Text;
                string stopBits = cBox_stopBitsCom2.Text;
                serialPortCom2 = new SerialPort();
                if (serialPortCom1 != null && serialPortCom1.IsOpen && portName == serialPortCom1.PortName)
                    MessageBox.Show("该端口已在Com1中打开");
                else
                {
                    OpenSerialPort(serialPortCom2, portName, BaudRate, parity, dataBits, stopBits);
                    if (serialPortCom2.IsOpen)
                    {
                        lab_statusCom2.Text = "打开";
                        btn_openOrCloseCom2.Text = "关闭串口";
                        serialPortCom2.DataReceived += new SerialDataReceivedEventHandler(SerialPortCom2_DataReceived);
                    }
                }
            }
            else
            {
                serialPortCom2.Close();
                if (!serialPortCom2.IsOpen)
                {
                    lab_statusCom2.Text = "关闭";
                    btn_openOrCloseCom2.Text = "打开串口";
                }
            }
        }
        /// <summary>
        /// 串口开启
        /// </summary>
        /// <param name="Serial_Port">串口类实例</param>
        /// <param name="Port_Name">串口名字</param>
        ///  <param name="Baud_Rate">串口速率</param>
        public string OpenSerialPort(SerialPort Serial_Port, string portName, string baud_Rate, string parity, string dataBits, string stopBits)
        {
            string info_error = "";
            try
            {
                Serial_Port.PortName = portName;
                Serial_Port.BaudRate = int.Parse(baud_Rate);
                switch (parity)
                {
                    case "无":
                        Serial_Port.Parity = Parity.None;
                        break;
                    case "奇校验":
                        Serial_Port.Parity = Parity.Odd;
                        break;
                    case "偶校验":
                        Serial_Port.Parity = Parity.Even;
                        break;
                    case "Mark":
                        Serial_Port.Parity = Parity.Mark;
                        break;
                    case "Space":
                        Serial_Port.Parity = Parity.Space;
                        break;
                    default:
                        Serial_Port.Parity = Parity.None;
                        break;
                }
                Serial_Port.DataBits = int.Parse(dataBits);
                switch (stopBits)
                {
                    case "0":
                        Serial_Port.StopBits = StopBits.None;
                        break;
                    case "1":
                        Serial_Port.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        Serial_Port.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        Serial_Port.StopBits = StopBits.Two;
                        break;
                    default:
                        Serial_Port.Parity = Parity.None;
                        break;
                }

                Serial_Port.Handshake = Handshake.None;
                Serial_Port.Open();
            }
            catch (Exception EX)
            {
                info_error = EX.Message;
                MessageBox.Show("info_error");
            }
            return info_error;
        }

        private String CRC(byte[] x, int len) //CRC-16校验函数
        {
            byte[] temdata = new byte[2];
            UInt16 crc = 0;
            byte da;
            int i = 0;
            UInt16[] yu = { 0x0000,0x1021,0x2042,0x3063,0x4084,0x50a5,0x60c6,0x70e7,
                            0x8108,0x9129,0xa14a,0xb16b,0xc18c,0xd1ad,0xe1ce,0xf1ef };
            while (len-- != 0)
            {
                da = (byte)(((byte)(crc / 256)) / 16);
                crc <<= 4;
                crc ^= yu[da ^ x[i] / 16];
                da = (byte)(((byte)(crc / 256)) / 16);
                crc <<= 4;
                crc ^= yu[da ^ x[i] & 0x0f];
                i++;
            }
            temdata[0] = (byte)(crc & 0xFF);
            temdata[1] = (byte)(crc >> 8);
            return bytesToHexString(temdata, 2);
        }
        private UInt16 update_crc_sick(UInt16 crc, Byte c, Byte prev_byte)
        {
            UInt16 short_c, short_p;
            UInt16 P_SICK = 0x8005;
            short_c = (UInt16)(0x00ff & (UInt16)c);
            short_p = (UInt16)((0x00ff & (UInt16)prev_byte) << 8);
            if ((UInt16)(crc & 0x8000) > 0) crc = (UInt16)((crc << 1) ^ P_SICK);
            else crc = (UInt16)(crc << 1);
            crc &= 0xffff;
            crc ^= (UInt16)(short_c | short_p);
            return crc;
        }

        private UInt16 ComputeCRC16_SICK(byte[] buffer, int offset, int count)
        {
            UInt16 crc_sick = 0;
            Byte prev_byte = 0;
            for (Int32 i = 0; i < count; ++i)
            {
                crc_sick = update_crc_sick(crc_sick, buffer[offset + i], prev_byte);
                prev_byte = buffer[offset + i];
            }
            UInt16 low_byte = (UInt16)((crc_sick & 0xff00) >> 8);
            UInt16 high_byte = (UInt16)((crc_sick & 0x00ff) << 8);
            crc_sick = (UInt16)(low_byte | high_byte);
            return crc_sick;
        }
        private static void init_crcccitt_tab()
        {
            int i, j;
            UInt16 crc, c;
            UInt16 P_CCITT = 0x1021;
           
            for (i = 0; i < 256; i++)
            {
                crc = 0;
                c = (UInt16)(((UInt16)i) << 8);
                for (j = 0; j < 8; j++)
                {
                    if ((UInt16)((crc ^ c) & 0x8000) > 0) crc = (UInt16)((crc << 1) ^ P_CCITT);
                    else crc = (UInt16)(crc << 1);
                    c = (UInt16)(c << 1);
                }
                crc_tabccitt[i] = crc;
            }
            crc_tabccitt_init = true;
        }
        private UInt16 update_crc_ccitt(UInt16 crc, Byte c)
        {
            UInt16 tmp, short_c;
            short_c = (UInt16)(0x00ff & c);
            if (!crc_tabccitt_init) init_crcccitt_tab();
            tmp = (UInt16)((crc >> 8) ^ short_c);
            crc = (UInt16)((crc << 8) ^ crc_tabccitt[tmp]);
            return crc;
        }

        private UInt16 ComputeCRC16_CCITT_FFFF(byte[] buffer, int offset, int count)
        {
            UInt16 crc_ccitt_ffff = 0xFFFF;
            for (Int32 i = 0; i < count; ++i)
            {
                crc_ccitt_ffff = update_crc_ccitt(crc_ccitt_ffff, buffer[offset + i]);
            }
            return crc_ccitt_ffff;
        }

        /// <summary>
        /// 监听串口数据线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 接收字符集有System.Text.ASCIIEncoding、System.Text.UTF8Encoding、System.Text.UTF32Encoding、System.Text.UnicodeEncoding、Windows
            //     单字节编码之一或 Windows 双字节编码之一。
        private void SerialPortCom1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPortCom1.IsOpen)
                {
                    byte[] readBuffer = new byte[serialPortCom1.ReadBufferSize + 1];
                    byte[] sendBuffer = new byte[serialPortCom1.ReadBufferSize + 1];
                    try
                    {
                        int count = serialPortCom1.Read(readBuffer, 0, serialPortCom1.ReadBufferSize);        //读取串口数据(监听)
                        //String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count);
                        //ErrorInfo.WriteLine(DateTime.Now.ToString() + "发送数据:" + SerialIn);
                        //ErrorInfo.Flush();
                        if (count != 0)
                        {
                            //将返回值byte数组转换为string类型数据
                            String result = bytesToHexString(readBuffer, count);
                            String resultFinal;

                            checkDirectoryFile();
                            serialPort1Info.WriteLine(DateTime.Now.ToString() + "接收数据:" + result);
                            serialPort1Info.Flush();

                            //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
                            //{
                            AddRunningInfo(DateTime.Now.ToString() + "接收数据:" + result, listBox_showCom1);         //对控件进行赋值
                            //}));
                            if (serialPortCom2.IsOpen && IfTransmit)//如果另一个串口开启则进行数据转发
                            {
                                if (IsAutoReplaceForward && result.Contains(FindBox1.Text + FindBox2.Text + FindBox3.Text + FindBox4.Text + FindBox5.Text + FindBox6.Text) && result.Contains(FindBox8.Text + FindBox9.Text + FindBox10.Text + FindBox11.Text + FindBox12.Text + FindBox13.Text))
                                {
                                    String rplceStr = RplceBox1.Text + RplceBox2.Text + RplceBox3.Text + RplceBox4.Text + RplceBox5.Text + RplceBox6.Text + result[7] + RplceBox8.Text;
                                    String crc = CRC(Convert.FromBase64String(rplceStr), Convert.FromBase64String(rplceStr).Length);
                                    sendBuffer = Convert.FromBase64String(rplceStr + crc);
                                }
                                else
                                    sendBuffer = Convert.FromBase64String(result);

                                serialPortCom2.Write(sendBuffer, 0, count);
                                //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
                                //{
                                AddRunningInfo(DateTime.Now.ToString() + "发送数据:" + sendBuffer, listBox_showCom2);         //对控件进行赋值
                                //}));
                                serialPort2Info.WriteLine(DateTime.Now.ToString() + "发送数据:" + sendBuffer);
                                serialPort2Info.Flush();
                            }
                        }

                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// 监听串口数据线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 接收字符集有System.Text.ASCIIEncoding、System.Text.UTF8Encoding、System.Text.UTF32Encoding、System.Text.UnicodeEncoding、Windows
        //     单字节编码之一或 Windows 双字节编码之一。
        private void SerialPortCom2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPortCom2.IsOpen)
                {
                    byte[] readBuffer = new byte[serialPortCom2.ReadBufferSize + 1];
                    try
                    {
                        int count = serialPortCom2.Read(readBuffer, 0, serialPortCom2.ReadBufferSize);        //读取串口数据(监听)
                        //String SerialIn = System.Text.Encoding.ASCII.GetString(readBuffer, 0, count); 
                        if (count != 0)
                        {
                            //将返回值byte数组转换为string类型数据
                            String result = bytesToHexString(readBuffer, count);
                            checkDirectoryFile();
                            serialPort2Info.WriteLine(DateTime.Now.ToString() + "接收数据:" + result);
                            serialPort2Info.Flush();
                            //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
                            //{
                            AddRunningInfo(DateTime.Now.ToString() + "接收数据:" + result, listBox_showCom2);         //对控件进行赋值
                            //}));
                            if (serialPortCom1.IsOpen && IfTransmit)//如果另一个串口开启则进行数据转发
                            {
                                serialPortCom1.Write(readBuffer, 0, count);
                                //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
                                //{
                                AddRunningInfo(DateTime.Now.ToString() + "发送数据:" + result, listBox_showCom1);         //对控件进行赋值
                                                                                                                      // }));
                                serialPort1Info.WriteLine(DateTime.Now.ToString() + "发送数据:" + result);
                                serialPort1Info.Flush();
                            }
                        }
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// Byte数组转换成16进制
        /// </summary>
        /// <param name="bArr"></param>
        /// <returns></returns>
        private String bytesToHexString(byte[] bArr, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)//逐字节变为16进制字符，以%隔开
            {
                result += Convert.ToString(bArr[i], 16).ToUpper().PadLeft(2, '0') + " ";
            }
            return result;
        }
        /// <summary>
        /// 字符串转10进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private static byte[] strToDecByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
               hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2),16);
            return returnBytes;
        }
        /// <summary>
        /// 向串口发送请求信息
        /// </summary>
        /// <param name="Serial_Port"></param>
        public void SendDataToSerialPort(SerialPort Serial_Port, string Str_Send)
        {
            string info_error = "";
            try
            {
                // byte[] senddata = Encoding.Unicode.GetBytes("01040000000271cb");
                // string str = Convert.ToBase64String(senddata);
                //SerialPort1.WriteLine("01040000000271cb");
                //MODBUS请求温湿度命令符，01地址码，04功能码，0000数据起始，0002数据个数，71CRC16高位，cbCRC16低位
                //string Str_Send = "01040000000271cb";
                MatchCollection MC = Regex.Matches(Str_Send, @"(?i)[\da-f]{2}");
                List<byte> Buffer_Send = new List<byte>();
                foreach (Match M in MC)
                {
                    Buffer_Send.Add(byte.Parse(M.Value, System.Globalization.NumberStyles.HexNumber));
                }
                Serial_Port.Write(Buffer_Send.ToArray(), 0, Buffer_Send.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                info_error = ex.Message;
            }
        }

        private void AddRunningInfo(string message, ListBox listBoxName)
        {
            this.Invoke((EventHandler)delegate
            {
                listBoxName.BeginUpdate();
                listBoxName.Items.Insert(0, message);

                if (listBoxName.Items.Count > 100)
                {
                    listBoxName.Items.RemoveAt(100);
                }

                listBoxName.EndUpdate();
            });
        }

        private void btn_OpenOrCloseTransmit_Click(object sender, EventArgs e)
        {
            if (btn_OpenOrCloseTransmit.Text == "关闭")
            {
                IfTransmit = false;
                label24.Text = "关闭";
                btn_OpenOrCloseTransmit.Text = "打开";
            }
            else if (btn_OpenOrCloseTransmit.Text == "打开")
            {
                IfTransmit = true;
                label24.Text = "打开";
                btn_OpenOrCloseTransmit.Text = "关闭";
            }
        }

        private void btn_sendToCom1_Click(object sender, EventArgs e)
        {
            string Str_Send = tBox_send.Text;
            MatchCollection MC = Regex.Matches(Str_Send, @"(?i)[\da-f]{2}");
            List<byte> Buffer_Send = new List<byte>();
            foreach (Match M in MC)
            {
                Buffer_Send.Add(byte.Parse(M.Value, System.Globalization.NumberStyles.HexNumber));
            }
            serialPortCom1.Write(Buffer_Send.ToArray(), 0, Buffer_Send.Count);
            serialPort1Info.WriteLine(DateTime.Now.ToString() + "发送数据:" + Str_Send);
            serialPort1Info.Flush();
            //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
            //{
            AddRunningInfo(DateTime.Now.ToString() + "发送数据:" + Str_Send, listBox_showCom1);         //对控件进行赋值
            //}));
        }

        private void btn_sendToCom2_Click(object sender, EventArgs e)
        {
            string Str_Send = tBox_send.Text;
            MatchCollection MC = Regex.Matches(Str_Send, @"(?i)[\da-f]{2}");
            List<byte> Buffer_Send = new List<byte>();
            foreach (Match M in MC)
            {
                Buffer_Send.Add(byte.Parse(M.Value, System.Globalization.NumberStyles.HexNumber));
            }
            serialPortCom2.Write(Buffer_Send.ToArray(), 0, Buffer_Send.Count);
            serialPort2Info.WriteLine(DateTime.Now.ToString() + "发送数据:" + Str_Send);
            serialPort2Info.Flush();
            //this.BeginInvoke(new System.Threading.ThreadStart(delegate()
            //{
            AddRunningInfo(DateTime.Now.ToString() + "发送数据:" + Str_Send, listBox_showCom2);         //对控件进行赋值
            //}));
        }
        private void checkDirectoryFile()
        {
            DirectoryInfo theForder = new DirectoryInfo(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd"));
            if (!theForder.Exists)
            {
                Directory.CreateDirectory(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd"));
                serialPort1Info = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_serialPort1Info.txt");
                ErrorInfo = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_ErrorInfo.txt");
                serialPort2Info = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_serialPort2Info.txt");
                isObsCanUse = true;
            }
            else
            {
                if (!isObsCanUse)
                {
                    serialPort1Info = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_serialPort1Info.txt");
                    ErrorInfo = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_ErrorInfo.txt");
                    serialPort2Info = File.AppendText(@"d:\serialPortData\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_serialPort2Info.txt");
                    isObsCanUse = true;
                }
            }
        }

        private void SerialPortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPortCom1 != null && serialPortCom1.IsOpen)
                serialPortCom1.Close();
            if (serialPortCom2 != null && serialPortCom2.IsOpen)
                serialPortCom2.Close();
            if (serialPort1Info != null)
                serialPort1Info.Close();
            if (ErrorInfo != null)
                ErrorInfo.Close();
            if (serialPort2Info != null)
                serialPort2Info.Close();
        }

        private void btn_AutoReplaceForward_Click(object sender, EventArgs e)
        {
            if (btn_AutoReplaceForward.Text == "打开匹配替换")
            {
                IsAutoReplaceForward = true;
                label22.Text = "打开";
                btn_AutoReplaceForward.Text = "关闭匹配替换";
            }
            else if (btn_AutoReplaceForward.Text == "关闭匹配替换")
            {
                IsAutoReplaceForward = false;
                label22.Text = "关闭";
                btn_AutoReplaceForward.Text = "打开匹配替换";
            }
        }
        private void btn_CRC_Click(object sender, EventArgs e)
        {
            byte[] tempBytes = strToDecByte(textBox1.Text);
            UInt16 tempCrc = ComputeCRC16_SICK(tempBytes, 0, tempBytes.Length);
            UInt16 tempCrc2 = ComputeCRC16_CCITT_FFFF(tempBytes, 0, tempBytes.Length);
            label8.Text = Convert.ToString(tempCrc, 16).ToUpper();
            label27.Text = Convert.ToString(tempCrc2, 16).ToUpper();
        }
    }

}
