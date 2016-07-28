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
			linkLabel3.Text = "csdn Win 百度 谷歌 YAHOO";  
			linkLabel3.Links.Add(0, 4, "http://www.csdn.net/");  
			linkLabel3.Links.Add(9, 2, "http://www.baidu.com/");  
			linkLabel3.Links.Add(12, 2, "http://www.google.cn/");  
			linkLabel3.Links.Add(15, 5, "http://www.yahoo.com.cn/"); 
//			System.Diagnostics.Process.Start("http://blog.csdn.net/testcs_dn"); 
		}
		void Button1Click(object sender, EventArgs e)
		{
//			linkLabel1.Links
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel3.Links[linkLabel3.Links.IndexOf(e.Link)].Visited = true;  
			string targetUrl = e.Link.LinkData as string;  
			if (string.IsNullOrEmpty(targetUrl))
				MessageBox.Show("没有链接地址！");
			else
				System.Diagnostics.Process.Start(targetUrl);  
		}
	}
}
