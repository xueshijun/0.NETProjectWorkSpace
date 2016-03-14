using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        List<string> listString;
        List<Entitys.Athlete> listAthlete=new List<Entitys.Athlete>();

        private void Login_Load(object sender, EventArgs e)
        { 
            listString = new List<string>();

            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            System.Xml.XmlNodeReader reader = null;
            string strFilename = "C:/admin.xml";
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
                    //listAthlete

                    // this.comboBoxNum.Items.Add(xe.GetAttribute("role"));  
                    //System.Xml.XmlNodeList xnf1 = xe.ChildNodes;
                    if (xe.GetAttribute("role").Equals("admin"))
                    {
                        Entitys.Admins admin;
                        int i = 0;
                        foreach (System.Xml.XmlNode xn2 in xe.ChildNodes)
                        {
                            admin = new Entitys.Admins();
                            switch (i++)
                            {
                                case 0: admin.ID = xn2.InnerText; break;
                                case 1: admin.Name = xn2.InnerText; break;
                                case 2: admin.Pass = xn2.InnerText; break;
                            }
                            listString.Add(xn2.InnerText);
                        }
                    }
                    else
                    {
                        //Entitys.Athlete athlete;
                        //int i = 0;
                        //foreach (System.Xml.XmlNode xn2 in xe.ChildNodes)
                        //{
                        //    athlete = new Entitys.Athlete(); 
                        //    switch (i++)
                        //    {
                        //        case 0: athlete.ID = xn2.InnerText; break;
                        //        case 1: athlete.Name = xn2.InnerText; i = 0; break; 
                        //    }
                        //    listAthlete.Add(athlete);
                        //}
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, "读取文件“"+strFilename + "”出错了,请检查配置是否正确。", this.Text);
                return;
            }
            
        }
        public Entitys.Admins admin = new Entitys.Admins();
        private void btnStart_Click(object sender, EventArgs e)
        {
            DivingClient client = new DivingClient();
            client.Owner = this;

            for (int i = 0; i < listString.Count;i+=3)
            {
                if (listString[i+1].Equals(this.textBoxName.Text) && listString[i + 2].Equals(this.textBoxPass.Text)) {
                    this.textBoxName.Text += listString[i + 2];
                    admin.ID = listString[i].ToString();
                    admin.Name = listString[i+1].ToString();
                    admin.Pass = listString[i+2].ToString();
                    admin.Count = listString.Count/3+"";
                    this.Hide();
                    client.Show();
                    break;
                } 
            } 
            //MessageBox.Show(this, "输入的帐号和密码错误！", this.Text);
        } 
    }
}
