/*
 * 由SharpDevelop创建。
 * 用户： zhoudd
 * 日期: 2016/7/28
 * 时间: 22:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rsc_win
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private string homeUrl = "";

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void MainFormLoad(object sender, EventArgs e)
        {

            init();

        }



        void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //         linkLabel3.Links[linkLabel3.Links.IndexOf(e.Link)].Visited = true;  
            //string targetUrl = e.Link.LinkData as string;  
            //if (string.IsNullOrEmpty(targetUrl))
            //	MessageBox.Show("没有链接地址！");
            //else
            //	System.Diagnostics.Process.Start(targetUrl);  
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(homeUrl);
        }
        void Open(string url)
        {
            System.Diagnostics.Process.Start(url);

        }

        void init()
        {
            string[] ctr_types = new string[] { "pan_", "lab_", "pic_" };
            string[] names = new string[] { "ie9", "qq", "firefox", "google" };

            homeUrl = System.Configuration.ConfigurationManager.AppSettings["homeUrl"];
            if(string.IsNullOrEmpty(homeUrl))
            {
                homeUrl = "http://www.rsc365.com";
            }

            foreach (string sfirst in ctr_types)
            {
                foreach (string item in names)
                {
                    Control[] controls= this.Controls.Find(sfirst + item, true);
                    if(controls.Length<=0)
                    {
                        continue;
                    }
                    Control find = controls[0];
                    if (find != null)
                    {
                        string[] sconfigs = System.Configuration.ConfigurationManager.AppSettings[item].Split(',');

                        if (sfirst == "lab_")
                        {
                            find.Text = sconfigs[0];
                        }
                        find.Tag = sconfigs;

                        find.Click += new EventHandler((d, a) => System.Diagnostics.Process.Start(sconfigs[1]));

                    }

                }
            }

        }

        private void pan_ie9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pic_ie9_Click(object sender, EventArgs e)
        {

        }

        private void lab_ie9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
    
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("pan");

        }
    }
}
