using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace rsc_win
{
    public partial class Form1 : Form
    {
        private string homeUrl = "";

        public Form1()
        {
            InitializeComponent();
        }


        void init()
        {
            string[] ctr_types = new string[] { "pan_", "lab_", "pic_" };
            string[] names = new string[] { "ie9", "qq", "firefox", "google" };

            homeUrl = System.Configuration.ConfigurationManager.AppSettings["homeUrl"];
            if (string.IsNullOrEmpty(homeUrl))
            {
                homeUrl = "http://www.rsc365.com";
            }

            foreach (string sfirst in ctr_types)
            {
                foreach (string item in names)
                {
                    Control[] controls = this.Controls.Find(sfirst + item, true);
                    if (controls.Length <= 0)
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
        void Open(string url)
        {
            System.Diagnostics.Process.Start(url);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            Open(homeUrl);

            string homeImg = Application.StartupPath + "\\img\\home.png";

            if (File.Exists(homeImg))
            {
                this.splitContainer1.Panel1.BackgroundImage = Bitmap.FromFile(homeImg);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
