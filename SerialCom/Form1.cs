using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class MainForm : Form
    {

        //实例化串口对象
        SerialPort serialPort = new SerialPort();

        String saveDataFile = null;
        FileStream saveDataFS = null;

        public MainForm()
        {
            InitializeComponent();
        }


        //初始化串口界面参数设置
        private void Init_Port_Confs()
        {
            /*------串口界面参数设置------*/

            //检查是否含有串口
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            //添加串口
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }
            //设置默认串口选项
            comboBoxCom.SelectedIndex = 0;

            /*------波特率设置-------*/
            string[] baudRate = { "9600", "19200", "38400", "57600", "115200" };
            foreach (string s in baudRate)
            {
                comboBoxBaudRate.Items.Add(s);
            }
            comboBoxBaudRate.SelectedIndex = 0;

            /*------数据位设置-------*/
            string[] dataBit = { "5", "6", "7", "8" };
            foreach (string s in dataBit)
            {
                comboBoxDataBit.Items.Add(s);
            }
            comboBoxDataBit.SelectedIndex = 3;


            /*------校验位设置-------*/
            string[] checkBit = { "None", "Even", "Odd", "Mask", "Space" };
            foreach (string s in checkBit)
            {
                comboBoxCheckBit.Items.Add(s);
            }
            comboBoxCheckBit.SelectedIndex = 0;


            /*------停止位设置-------*/
            string[] stopBit = { "1", "1.5", "2" };
            foreach (string s in stopBit)
            {
                comboBoxStopBit.Items.Add(s);
            }
            comboBoxStopBit.SelectedIndex = 0;

            /*------数据格式设置-------*/
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;
        }

        //加载主窗体
        private void MainForm_Load(object sender, EventArgs e)
        {

            Init_Port_Confs();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);


            //准备就绪              
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            //设置数据读取超时为1秒
            serialPort.ReadTimeout = 1000;

            serialPort.Close();

            buttonSendData.Enabled = false;

        }


        //打开串口 关闭串口
        private void buttonOpenCloseCom_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)//串口处于关闭状态
            {
                
                try
                {
                    
                    if (comboBoxCom.SelectedIndex == -1)
                    {
                        MessageBox.Show("Error: 无效的端口,请重新选择", "Error");
                        return;
                    }
                    string strSerialName    = comboBoxCom.SelectedItem.ToString();
                    string strBaudRate      = comboBoxBaudRate.SelectedItem.ToString();
                    string strDataBit       = comboBoxDataBit.SelectedItem.ToString();
                    string strCheckBit      = comboBoxCheckBit.SelectedItem.ToString();
                    string strStopBit       = comboBoxStopBit.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit  = Convert.ToInt32(strDataBit);

                    serialPort.PortName = strSerialName;//串口号
                    serialPort.BaudRate = iBaudRate;//波特率
                    serialPort.DataBits = iDataBit;//数据位

                    

                    switch (strStopBit)            //停止位
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：停止位参数不正确!", "Error");
                            break;
                    }
                    switch (strCheckBit)             //校验位
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：校验位参数不正确!", "Error");
                            break;
                    }



                    if (saveDataFile != null)
                    {
                        saveDataFS = File.Create(saveDataFile);
                    }

                    //打开串口
                    serialPort.Open();

                    //打开串口后设置将不再有效
                    comboBoxCom.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxDataBit.Enabled = false;
                    comboBoxCheckBit.Enabled = false;
                    comboBoxStopBit.Enabled = false;
                    radioButtonSendDataASCII.Enabled = false;
                    radioButtonSendDataHex.Enabled = false;
                    radioButtonReceiveDataASCII.Enabled = false;
                    radioButtonReceiveDataHEX.Enabled = false;
                    buttonSendData.Enabled = true;
                    Button_Refresh.Enabled = false;

                    buttonOpenCloseCom.Text = "关闭串口";

                }
                catch(System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else //串口处于打开状态
            {
                
                serialPort.Close();//关闭串口
                //串口关闭时设置有效
                comboBoxCom.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxDataBit.Enabled = true;
                comboBoxCheckBit.Enabled = true;
                comboBoxStopBit.Enabled = true;
                radioButtonSendDataASCII.Enabled = true;
                radioButtonSendDataHex.Enabled = true;
                radioButtonReceiveDataASCII.Enabled = true;
                radioButtonReceiveDataHEX.Enabled = true;
                buttonSendData.Enabled = false;
                Button_Refresh.Enabled = true;

                buttonOpenCloseCom.Text = "打开串口";

                if (saveDataFS != null)
                {
                    saveDataFS.Close(); // 关闭文件
                    saveDataFS = null;//释放文件句柄
                }

            }
        }

        //接收数据
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                //MessageBox.Show("sss","OK");
                //输出当前时间
                DateTime dateTimeNow = DateTime.Now;
                //dateTimeNow.GetDateTimeFormats();
                textBoxReceive.Text += string.Format("{0}\r\n", dateTimeNow);
                //dateTimeNow.GetDateTimeFormats('f')[0].ToString() + "\r\n";
                textBoxReceive.ForeColor = Color.Red;    //改变字体的颜色

                if (radioButtonReceiveDataASCII.Checked == true) //接收格式为ASCII
                {
                    try
                    {
                        String input = serialPort.ReadLine();
                        textBoxReceive.Text += input + "\r\n";
                        // save data to file
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }
                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "你波特率是不是有问题？？？");
                        return;
                    }
                    
                    textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
                    textBoxReceive.ScrollToCaret();//滚动到光标处
                    serialPort.DiscardInBuffer(); //清空SerialPort控件的Buffer 
                }
                else //接收格式为HEX
                {
                    try
                    {

                        string input = serialPort.ReadLine();
                        char[] values = input.ToCharArray();
                        foreach (char letter in values)
                        {
                            // Get the integral value of the character.
                            int value = Convert.ToInt32(letter);
                            // Convert the decimal value to a hexadecimal value in string form.
                            string hexOutput = String.Format("{0:X}", value);
                            textBoxReceive.AppendText(hexOutput + " ");
                            textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
                            textBoxReceive.ScrollToCaret();//滚动到光标处
                            //textBoxReceive.Text += hexOutput + " ";

                        }

                        // save data to file
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }


                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        textBoxReceive.Text = "";//清空
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        //发送数据
        private void buttonSendData_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口", "Error");
                return;
            }

            String strSend = textBoxSend.Text;//发送框数据
            if (radioButtonSendDataASCII.Checked == true)//以字符串 ASCII 发送
            {
                serialPort.WriteLine(strSend);//发送一行数据 

            }
            else
            {
                //16进制数据格式 HXE 发送
                 
                char[] values = strSend.ToCharArray();
                foreach (char letter in values)
                {
                    // Get the integral value of the character.
                    int value = Convert.ToInt32(letter);
                    // Convert the decimal value to a hexadecimal value in string form.
                    string hexIutput = String.Format("{0:X}", value);
                    serialPort.WriteLine(hexIutput);

                }



            }

        }

        //清空接收数据框
        private void buttonClearRecData_Click(object sender, EventArgs e)
        {
            
            textBoxReceive.Text = "";

        }


        //窗体关闭时
        private void MainForm_Closing(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();//关闭串口
            }

            if (saveDataFS != null)
            {
                saveDataFS.Close(); // 关闭文件
                saveDataFS = null;//释放文件句柄
            }

        }

        //刷新串口
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            comboBoxCom.Text = "";
            comboBoxCom.Items.Clear();
            
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }

            //添加串口
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }

            //设置默认串口
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;

        }

        // 退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();//关闭串口
            }
            if (saveDataFS != null)
            {
                saveDataFS.Close(); // 关闭文件
                saveDataFS = null;//释放文件句柄
            }

            this.Close();
        }

        // 重置串口参数设置
        private void ResetPortConfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;

        }

        // 保存接收数据到文件
        private void SaveReceiveDataToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt |*.txt";
            saveFileDialog.Title = "保存接收到的数据到文件中";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != null)
            {
                saveDataFile = saveFileDialog.FileName;
            }


        }
    }
}
