using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Windows.Forms;


//
//添加的命名空间引用
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient
{
    public partial class DivingClient : Form
    {
        private Entitys.Admins admin;

        delegate void ChangeTextCallback(string text);
        ChangeTextCallback appendStringCallback;
        ChangeTextCallback changeIDCallback, changeNameCallback, changeParameterCallback;

        delegate void ChangeButtonStateCallback(bool enable);
        ChangeButtonStateCallback changeSubmit;

        private string ipAddress = "224.100.0.3";

        //使用的接收端口号
        private int portReceive = 8003;
        private int portSend = 8004;

        private UdpClient udpClient;


        public DivingClient()
        {
            InitializeComponent();

            changeIDCallback = new ChangeTextCallback(ChangeID);
            changeNameCallback = new ChangeTextCallback(ChangeName);
            changeParameterCallback = new ChangeTextCallback(ChangeParameter);

            changeSubmit = new ChangeButtonStateCallback(ChangeSubmitEnable);
            
        }


        private void DivingClient_Load(object sender, EventArgs e)
        {
            admin = ((LoginForm)this.Owner).admin;
            this.labelID.Text = admin.ID;
            this.labelName.Text = admin.Name; 
            this.labelCount.Text = admin.Count;

            Thread myThread = new Thread(new ThreadStart(ReceiveData));
            myThread.Start();
        }

        #region 相关界面回调
        private void ChangeID(string text) {
            if (this.labelAthleteID.InvokeRequired == true)
            {
                this.Invoke(changeIDCallback, text);
            }
            else
            {
                this.labelAthleteID.Text=text;
            }
        }
        private void ChangeName(string text)
        {
            if (this.labelAthleteName.InvokeRequired == true)
            {
                this.Invoke(changeNameCallback, text);
            }
            else
            {
                this.labelAthleteName.Text = text;
            }
        }
        private void ChangeParameter(string text)
        {
            if (this.labelAthleteParameter.InvokeRequired == true)
            {
                this.Invoke(changeParameterCallback, text);
            }
            else
            {
                this.labelAthleteParameter.Text = text;
            }
        }
        private void ChangeSubmitEnable(bool bol) {
            if (this.labelAthleteParameter.InvokeRequired == true)
            {
                this.Invoke(changeSubmit,bol);
            }
            else
            {
                this.btnSubmit.Enabled = bol; 
            }
        }

        #endregion


        private void ReceiveData()
        {
            //在本机指定的端口接收
            udpClient = new UdpClient(portReceive);
            //必须使用组播地址范围内的地址
            udpClient.JoinMulticastGroup(IPAddress.Parse(ipAddress));
            udpClient.Ttl = 50;
            udpClient.EnableBroadcast = true;
            IPEndPoint remote = null;
            //接收从远程主机发送过来的信息；
            while (true)
            {
                try
                {  
                    //关闭udpClient时此句会产生异常
                    byte[] bytes = udpClient.Receive(ref remote);
                    string str = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                    //格式：#SERVER#USER#选手编号#选手姓名#难度系数
                    if (str.Substring(0, 13).Equals("#SERVER#USER#"))//接收评分的选手编号
                    {
                       // AppendString(string.Format("来自{0}：{1}", remote, "" + str));
                        string[] strAthlete = str.Split('#');
                        ChangeID(strAthlete[3]);
                        ChangeName(strAthlete[4]);
                        ChangeParameter(strAthlete[5]);
                        ChangeSubmitEnable(true); 
                    }
                    else
                    {
                    } 
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("异常了" + ex.ToString());
                    break;
                }
            }
        }
         

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.textBoxScore.Text.Trim().Equals(""))
            {
                MessageBox.Show("请打分！");
            }
            else {  
               try{
                   if (Double.Parse(textBoxScore.Text) >= 10.0 || Double.Parse(textBoxScore.Text) <= 0.0)
                   {
                       MessageBox.Show("请输入正确的分数范围：0-10！");
                   }
                   else {

                       //发送到服务器端，服务器端只识别
                       //格式：#CLIENT#USER#评委编号#评委数量#选手编号#选手得分#难度系数
                       SendData("#CLIENT#USER#" + labelID.Text + "#" + labelCount.Text + "#" + labelAthleteID.Text + "#" + textBoxScore.Text + "#" + labelAthleteParameter.Text);
                       textBoxScore.Clear();
                       textBoxScore.Focus();
                       // this.btnSubmit.Enabled = false;
                       ChangeSubmitEnable(false);
                   }
               }catch{
                   MessageBox.Show("请输入正确的分数格式！如8.01或8");
               }

            }
        } 

        private void SendData(string strMsg)
        { 
            UdpClient myUdpClient = new UdpClient();
            //允许发送和接收广播数据报
            myUdpClient.EnableBroadcast = true;
            //必须使用组播地址范围内的地址
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ipAddress), portSend);
            //将发送内容转换为字节数组
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strMsg);
            try
            {
                //向子网发送信息
                myUdpClient.Send(bytes, bytes.Length, iep);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "网络连接出错！");
            }
            finally
            {
                myUdpClient.Close();
            }

        }

        private void DivingClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpClient.Close();
            Application.Exit();
        }

    } 
}