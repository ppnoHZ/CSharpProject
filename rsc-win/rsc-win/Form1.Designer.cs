namespace rsc_win
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_ie9 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pan_google = new System.Windows.Forms.Panel();
            this.pic_google = new System.Windows.Forms.PictureBox();
            this.lab_google = new System.Windows.Forms.LinkLabel();
            this.pan_firefox = new System.Windows.Forms.Panel();
            this.pic_firefox = new System.Windows.Forms.PictureBox();
            this.lab_firefox = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_qq = new System.Windows.Forms.PictureBox();
            this.lab_qq = new System.Windows.Forms.LinkLabel();
            this.pan_ie9 = new System.Windows.Forms.Panel();
            this.lab_ie9 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ie9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pan_google.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).BeginInit();
            this.pan_firefox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_firefox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qq)).BeginInit();
            this.pan_ie9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_ie9
            // 
            this.pic_ie9.BackColor = System.Drawing.Color.Transparent;
            this.pic_ie9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_ie9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ie9.Image = global::rsc_win.Properties.Resources.icon1;
            this.pic_ie9.Location = new System.Drawing.Point(23, 21);
            this.pic_ie9.Name = "pic_ie9";
            this.pic_ie9.Size = new System.Drawing.Size(71, 69);
            this.pic_ie9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_ie9.TabIndex = 3;
            this.pic_ie9.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::rsc_win.Properties.Resources.按钮;
            this.btnHome.Location = new System.Drawing.Point(252, 305);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(286, 86);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::rsc_win.Properties.Resources.背景;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1MinSize = 324;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.pan_google);
            this.splitContainer1.Panel2.Controls.Add(this.pan_firefox);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.pan_ie9);
            this.splitContainer1.Panel2MinSize = 140;
            this.splitContainer1.Size = new System.Drawing.Size(784, 564);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.TabStop = false;
            // 
            // pan_google
            // 
            this.pan_google.Controls.Add(this.pic_google);
            this.pan_google.Controls.Add(this.lab_google);
            this.pan_google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_google.Location = new System.Drawing.Point(582, 7);
            this.pan_google.Name = "pan_google";
            this.pan_google.Size = new System.Drawing.Size(120, 125);
            this.pan_google.TabIndex = 14;
            // 
            // pic_google
            // 
            this.pic_google.BackColor = System.Drawing.Color.Transparent;
            this.pic_google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_google.Image = global::rsc_win.Properties.Resources.icon4;
            this.pic_google.Location = new System.Drawing.Point(24, 21);
            this.pic_google.Name = "pic_google";
            this.pic_google.Size = new System.Drawing.Size(71, 69);
            this.pic_google.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_google.TabIndex = 3;
            this.pic_google.TabStop = false;
            // 
            // lab_google
            // 
            this.lab_google.AutoSize = true;
            this.lab_google.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lab_google.ForeColor = System.Drawing.Color.Black;
            this.lab_google.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_google.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lab_google.Location = new System.Drawing.Point(11, 99);
            this.lab_google.Name = "lab_google";
            this.lab_google.Size = new System.Drawing.Size(98, 14);
            this.lab_google.TabIndex = 4;
            this.lab_google.TabStop = true;
            this.lab_google.Text = "下载IE9浏览器";
            this.lab_google.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_firefox
            // 
            this.pan_firefox.Controls.Add(this.pic_firefox);
            this.pan_firefox.Controls.Add(this.lab_firefox);
            this.pan_firefox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_firefox.Location = new System.Drawing.Point(416, 7);
            this.pan_firefox.Name = "pan_firefox";
            this.pan_firefox.Size = new System.Drawing.Size(120, 125);
            this.pan_firefox.TabIndex = 13;
            // 
            // pic_firefox
            // 
            this.pic_firefox.BackColor = System.Drawing.Color.Transparent;
            this.pic_firefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_firefox.Image = global::rsc_win.Properties.Resources.icon3;
            this.pic_firefox.Location = new System.Drawing.Point(25, 21);
            this.pic_firefox.Name = "pic_firefox";
            this.pic_firefox.Size = new System.Drawing.Size(71, 69);
            this.pic_firefox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_firefox.TabIndex = 3;
            this.pic_firefox.TabStop = false;
            // 
            // lab_firefox
            // 
            this.lab_firefox.AutoSize = true;
            this.lab_firefox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lab_firefox.ForeColor = System.Drawing.Color.Black;
            this.lab_firefox.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_firefox.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lab_firefox.Location = new System.Drawing.Point(12, 99);
            this.lab_firefox.Name = "lab_firefox";
            this.lab_firefox.Size = new System.Drawing.Size(98, 14);
            this.lab_firefox.TabIndex = 4;
            this.lab_firefox.TabStop = true;
            this.lab_firefox.Text = "下载IE9浏览器";
            this.lab_firefox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_qq);
            this.panel2.Controls.Add(this.lab_qq);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(250, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 125);
            this.panel2.TabIndex = 12;
            // 
            // pic_qq
            // 
            this.pic_qq.BackColor = System.Drawing.Color.Transparent;
            this.pic_qq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_qq.Image = global::rsc_win.Properties.Resources.icon2;
            this.pic_qq.Location = new System.Drawing.Point(26, 21);
            this.pic_qq.Name = "pic_qq";
            this.pic_qq.Size = new System.Drawing.Size(71, 69);
            this.pic_qq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_qq.TabIndex = 3;
            this.pic_qq.TabStop = false;
            // 
            // lab_qq
            // 
            this.lab_qq.AutoSize = true;
            this.lab_qq.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lab_qq.ForeColor = System.Drawing.Color.Black;
            this.lab_qq.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_qq.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lab_qq.Location = new System.Drawing.Point(13, 99);
            this.lab_qq.Name = "lab_qq";
            this.lab_qq.Size = new System.Drawing.Size(91, 14);
            this.lab_qq.TabIndex = 4;
            this.lab_qq.TabStop = true;
            this.lab_qq.Text = "下载QQ浏览器";
            this.lab_qq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_ie9
            // 
            this.pan_ie9.Controls.Add(this.pic_ie9);
            this.pan_ie9.Controls.Add(this.lab_ie9);
            this.pan_ie9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_ie9.Location = new System.Drawing.Point(84, 7);
            this.pan_ie9.Name = "pan_ie9";
            this.pan_ie9.Size = new System.Drawing.Size(120, 125);
            this.pan_ie9.TabIndex = 11;
            // 
            // lab_ie9
            // 
            this.lab_ie9.AutoSize = true;
            this.lab_ie9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lab_ie9.ForeColor = System.Drawing.Color.Black;
            this.lab_ie9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_ie9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lab_ie9.Location = new System.Drawing.Point(9, 99);
            this.lab_ie9.Name = "lab_ie9";
            this.lab_ie9.Size = new System.Drawing.Size(98, 14);
            this.lab_ie9.TabIndex = 4;
            this.lab_ie9.TabStop = true;
            this.lab_ie9.Text = "下载IE9浏览器";
            this.lab_ie9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日升昌记";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ie9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pan_google.ResumeLayout(false);
            this.pan_google.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).EndInit();
            this.pan_firefox.ResumeLayout(false);
            this.pan_firefox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_firefox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qq)).EndInit();
            this.pan_ie9.ResumeLayout(false);
            this.pan_ie9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ie9;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pan_google;
        private System.Windows.Forms.PictureBox pic_google;
        private System.Windows.Forms.LinkLabel lab_google;
        private System.Windows.Forms.Panel pan_firefox;
        private System.Windows.Forms.PictureBox pic_firefox;
        private System.Windows.Forms.LinkLabel lab_firefox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_qq;
        private System.Windows.Forms.LinkLabel lab_qq;
        private System.Windows.Forms.Panel pan_ie9;
        private System.Windows.Forms.LinkLabel lab_ie9;
    }
}