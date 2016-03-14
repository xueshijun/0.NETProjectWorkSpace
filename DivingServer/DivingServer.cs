using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


//添加的命名空间引用
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace ChatServer
{
    public partial class DivingServer : Form
    {
        delegate void ChangeTextCallback(string text);
        ChangeTextCallback labelResultDetailsCallback, labelResultCallback;

        delegate void ChangeButtonEnable(bool enable);
        ChangeButtonEnable changeSubmitCallback;


        //使用的接收端口号
        private string ipAddress = "224.100.0.3";
        private int PORT_RECEIVE=8004;
        private int PORT_SEND= 8003;
        private UdpClient udpClient;

        List<Entitys.Athlete> listAthletes = new List<Entitys.Athlete>();

        Entitys.Athlete currentAthlete = new Entitys.Athlete();
        
        //存储单个队员的分数
        List<double> listScores = new List<double>();

        public DivingServer()
        {
            InitializeComponent();
            labelResultCallback = new ChangeTextCallback(ChangeResult);
            labelResultDetailsCallback = new ChangeTextCallback(ChangeResultDetails);
            changeSubmitCallback = new ChangeButtonEnable(ChangeSubmit);
        } 

        private void DivingServer_Load(object sender, EventArgs e)
        {

            Thread myThread = new Thread(new ThreadStart(ReceiveData));
            myThread.Start();

            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            System.Xml.XmlNodeReader reader = null;
            string strFilename = "C:/athlete.xml";
            if (System.IO.File.Exists(strFilename) == false)
            {
                MessageBox.Show(this, "没找到配置文件！", this.Text);
                return;
            }
            try
            {
                xmlDoc.Load(strFilename);
                System.Xml.XmlNode selectSingleNode = xmlDoc.SelectSingleNode("human");
                System.Xml.XmlNodeList childNodes = selectSingleNode.ChildNodes;//user

                foreach (System.Xml.XmlNode childNode in selectSingleNode.ChildNodes)
                {
                    System.Xml.XmlElement xe = (System.Xml.XmlElement)childNode;

                    // this.comboBoxNum.Items.Add(xe.GetAttribute("role"));  
                    //System.Xml.XmlNodeList xnf1 = xe.ChildNodes;
                    Entitys.Athlete athlete = new Entitys.Athlete();
                    if (xe.GetAttribute("role").Equals("athlete"))
                    {
                        int i = 0;
                        foreach (System.Xml.XmlNode xn2 in xe.ChildNodes)
                        {
                            switch (i++)
                            {
                                case 0:
                                    athlete.ID = xn2.InnerText;
                                    break;
                                case 1:
                                    athlete.Name = xn2.InnerText; 
                                    break;
                                case 2:
                                    athlete.Parameter = xn2.InnerText;
                                    i = 0;
                                    break;
                            }
                        }
                        listAthletes.Add(athlete);
                    }
                }

                foreach (Entitys.Athlete athlete in listAthletes)
                {
                    this.listBoxAthlete.Items.Add(
                        "选手编号:" + athlete.ID 
                        + "#"
                        +"姓名:" + athlete.Name
                        + "#"
                        + "难度系数:" + athlete.Parameter
                        +"#");
                }



            }
            catch
            {
                MessageBox.Show(this, "读取文件“" + strFilename + "”出错了,请检查配置是否正确。", this.Text);
                return;
            }


        }
         

        #region 回调相关

        private void ChangeResult(string text)
        {
            if(this.labelResult.InvokeRequired == true)
            {
                this.Invoke(labelResultCallback, text);
            }
            else
            {
                this.labelResult.Text +=(text+ "\n");
            }
        }
        private void ChangeResultDetails(string text)
        {
            if(this.labelResultDetails.InvokeRequired == true)
            {
                this.Invoke(labelResultDetailsCallback, text);
            }
            else
            {
                this.labelResultDetails.AppendText(text + "\n");
            }
        }

        private void ChangeSubmit(bool  enable)
        {
            if (this.btnListen.InvokeRequired == true)
            {
                this.Invoke(changeSubmitCallback, enable);
            }
            else
            {
                this.btnListen.Enabled = enable;
            }
        }



        #endregion



     

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (this.listBoxAthlete.SelectedIndex >= 0)
            {
                string[] strAthlete = this.listBoxAthlete.SelectedItem.ToString().Split('#');

                this.labelAthleteID.Text = strAthlete[0].Replace("选手编号:","");
                this.labelAthleteName.Text = strAthlete[1].Replace("姓名:","");
                this.labelAthleteParameter.Text = strAthlete[2].Replace("难度系数:","");
                //#SERVER#USER#选手编号#选手姓名#难度系数
                SendUser("#SERVER#USER#" + this.labelAthleteID.Text + "#"
                        + this.labelAthleteName.Text + "#" + this.labelAthleteParameter.Text);
                this.listBoxAthlete.Items.RemoveAt(this.listBoxAthlete.SelectedIndex);

                ChangeSubmit(false);
            }
            else {
                MessageBox.Show("请选择参赛者");
            } 
        }
         


        private void ReceiveData()
        {
            //在本机指定的端口接收
            udpClient = new UdpClient(PORT_RECEIVE);
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

                    //格式：#CLIENT#USER#评委编号#评委数量#选手编号#选手得分#难度系数
                    if (str.Substring(0, 13).Equals("#CLIENT#USER#"))//接收评分的选手编号
                    {
                        string[] strResult = str.Split('#');
                        string value =
                            "评委编号" + strResult[3]
                            + "评委数量" + strResult[4]
                            + "选手编号" + strResult[5]
                            + "选手得分" + strResult[6]
                           + "难度系数" + strResult[7];
                        ChangeResultDetails(string.Format("来自{0}：{1}", remote, value));
                        listScores.Add(Int32.Parse(strResult[6])); 

                        if (listScores.Count < Int32.Parse(strResult[4]))//判断所有评委都打分了？
                        { 
                            ChangeSubmit(false);
                        }
                        else { //所有评委都打分了
                            listScores.Sort();

                            string msg = "【" + strResult[5] + "】号选手  ";
                            foreach(double element in listScores) {

                                msg +="第"+strResult[3] +"号评委给分[" + element + "]  "; 
                            }

                            //当评委数量不足3人时，就不进行去除最高分和最低分
                            if (Int32.Parse(strResult[4]) >= 3)
                            {
                                listScores.RemoveAt(0);
                                listScores.RemoveAt(listScores.Count - 1);
                            }

                            double sum = 0;
                            foreach (double temp in listScores)
                            {
                                sum += temp;
                            }
                            msg += "总分:【" + sum * Double.Parse(strResult[7]) + "】"; 

                            ChangeResult(msg); 
                            ChangeSubmit(true);
                            listScores.Clear();
                        }
                    }
                    else { 
                    }
                }
                catch (Exception err)
                {
                    //退出循环，结束线程 
                   // MessageBox.Show("接收数据失败" + err.ToString());
                    break; 
                }
            }
        } 

        private void SendUser(string strMsg)
        {
            UdpClient myUdpClient = new UdpClient();
            //允许发送和接收广播数据报
            myUdpClient.EnableBroadcast = true;
            //必须使用组播地址范围内的地址
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ipAddress), PORT_SEND);
            //将发送内容转换为字节数组
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strMsg);
            try
            {
                //向子网发送信息
                myUdpClient.Send(bytes, bytes.Length, iep); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "发送失败");
            }
            finally
            {
                myUdpClient.Close();
            }
        }

        private void DivingServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                udpClient.Close();
                Application.Exit();
            }
            catch { }
        } 
    }
}
