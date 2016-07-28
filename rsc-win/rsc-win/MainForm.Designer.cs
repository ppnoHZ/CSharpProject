/*
 * 由SharpDevelop创建。
 * 用户： zhoudd
 * 日期: 2016/7/28
 * 时间: 22:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace rsc_win
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(270, 85);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 58);
			this.button1.TabIndex = 0;
			this.button1.Text = "日升昌记";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Location = new System.Drawing.Point(6, 209);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(600, 23);
			this.linkLabel3.TabIndex = 1;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "linkLabel1";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 347);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "rsc-win";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
