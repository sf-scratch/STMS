namespace STMS.STMSApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            btnClose = new UControls.UIconButton();
            btnMax = new UControls.UIconButton();
            btnMin = new UControls.UIconButton();
            uPanel1 = new UControls.UPanel();
            uMenuButton3 = new UControls.UMenuButton();
            uMenuButton2 = new UControls.UMenuButton();
            uMenuButton1 = new UControls.UMenuButton();
            uPanel5 = new UControls.UPanel();
            uPanel6 = new UControls.UPanel();
            uPanel7 = new UControls.UPanel();
            uPanel8 = new UControls.UPanel();
            uPanel3 = new UControls.UPanel();
            uPanel4 = new UControls.UPanel();
            uPanel2 = new UControls.UPanel();
            uPanel9 = new UControls.UPanel();
            lbLoginTime = new Label();
            lbUsername = new Label();
            label2 = new Label();
            label1 = new Label();
            uPanel10 = new UControls.UPanel();
            uPanel11 = new UControls.UPanel();
            uPanel12 = new UControls.UPanel();
            uPanel13 = new UControls.UPanel();
            uPanel14 = new UControls.UPanel();
            uPanel15 = new UControls.UPanel();
            uPanel16 = new UControls.UPanel();
            panel2 = new Panel();
            button1 = new Button();
            uPageButton4 = new UControls.UPageButton();
            uPageButton3 = new UControls.UPageButton();
            uPageButton1 = new UControls.UPageButton();
            uPageButton2 = new UControls.UPageButton();
            btnStorePage = new UControls.UPageButton();
            panelPage = new Panel();
            panel1.SuspendLayout();
            uPanel1.SuspendLayout();
            uPanel5.SuspendLayout();
            uPanel6.SuspendLayout();
            uPanel3.SuspendLayout();
            uPanel9.SuspendLayout();
            uPanel10.SuspendLayout();
            uPanel11.SuspendLayout();
            uPanel14.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Resources.logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnMin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 89);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 10.8F);
            btnClose.ForeColor = Color.Silver;
            btnClose.Location = new Point(1346, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Webdings", 10.8F);
            btnMax.ForeColor = Color.Silver;
            btnMax.Location = new Point(1298, 12);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(42, 45);
            btnMax.TabIndex = 1;
            btnMax.Text = "1";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Webdings", 10.8F);
            btnMin.ForeColor = Color.Silver;
            btnMin.Location = new Point(1250, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(42, 45);
            btnMin.TabIndex = 0;
            btnMin.Text = "0";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // uPanel1
            // 
            uPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uPanel1.BackColor = Color.Transparent;
            uPanel1.BgColor = Color.FromArgb(45, 50, 116);
            uPanel1.BgColor2 = Color.Transparent;
            uPanel1.Controls.Add(uMenuButton3);
            uPanel1.Controls.Add(uMenuButton2);
            uPanel1.Controls.Add(uMenuButton1);
            uPanel1.Controls.Add(uPanel5);
            uPanel1.Controls.Add(uPanel3);
            uPanel1.Controls.Add(uPanel2);
            uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel1.Location = new Point(12, 94);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 5;
            uPanel1.Size = new Size(264, 716);
            uPanel1.TabIndex = 1;
            // 
            // uMenuButton3
            // 
            uMenuButton3.BackColor = Color.FromArgb(45, 50, 116);
            uMenuButton3.BtnImage = Resources._04;
            uMenuButton3.BtnText = "仓库温控管理";
            uMenuButton3.Location = new Point(3, 129);
            uMenuButton3.Name = "uMenuButton3";
            uMenuButton3.Size = new Size(258, 54);
            uMenuButton3.TabIndex = 6;
            // 
            // uMenuButton2
            // 
            uMenuButton2.BackColor = Color.FromArgb(45, 50, 116);
            uMenuButton2.BtnImage = Resources._03;
            uMenuButton2.BtnText = "产品管理";
            uMenuButton2.Location = new Point(3, 69);
            uMenuButton2.Name = "uMenuButton2";
            uMenuButton2.Size = new Size(258, 54);
            uMenuButton2.TabIndex = 5;
            // 
            // uMenuButton1
            // 
            uMenuButton1.BackColor = Color.FromArgb(45, 50, 116);
            uMenuButton1.BtnImage = (Image)resources.GetObject("uMenuButton1.BtnImage");
            uMenuButton1.BtnText = "仓库管理";
            uMenuButton1.Location = new Point(3, 4);
            uMenuButton1.Name = "uMenuButton1";
            uMenuButton1.Size = new Size(258, 54);
            uMenuButton1.TabIndex = 0;
            // 
            // uPanel5
            // 
            uPanel5.BackColor = Color.Transparent;
            uPanel5.BgColor = Color.FromArgb(45, 50, 116);
            uPanel5.BgColor2 = Color.Transparent;
            uPanel5.Controls.Add(uPanel6);
            uPanel5.Controls.Add(uPanel8);
            uPanel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel5.Location = new Point(3, 640);
            uPanel5.Name = "uPanel5";
            uPanel5.Radius = 5;
            uPanel5.Size = new Size(835, 70);
            uPanel5.TabIndex = 4;
            // 
            // uPanel6
            // 
            uPanel6.BackColor = Color.Transparent;
            uPanel6.BgColor = Color.FromArgb(45, 50, 116);
            uPanel6.BgColor2 = Color.Transparent;
            uPanel6.Controls.Add(uPanel7);
            uPanel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel6.Location = new Point(0, 640);
            uPanel6.Name = "uPanel6";
            uPanel6.Radius = 5;
            uPanel6.Size = new Size(1400, 73);
            uPanel6.TabIndex = 3;
            // 
            // uPanel7
            // 
            uPanel7.BackColor = Color.Transparent;
            uPanel7.BgColor = Color.FromArgb(45, 50, 116);
            uPanel7.BgColor2 = Color.Transparent;
            uPanel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel7.Location = new Point(0, 640);
            uPanel7.Name = "uPanel7";
            uPanel7.Radius = 5;
            uPanel7.Size = new Size(276, 73);
            uPanel7.TabIndex = 2;
            // 
            // uPanel8
            // 
            uPanel8.BackColor = Color.Transparent;
            uPanel8.BgColor = Color.FromArgb(45, 50, 116);
            uPanel8.BgColor2 = Color.Transparent;
            uPanel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel8.Location = new Point(0, 640);
            uPanel8.Name = "uPanel8";
            uPanel8.Radius = 5;
            uPanel8.Size = new Size(276, 73);
            uPanel8.TabIndex = 2;
            // 
            // uPanel3
            // 
            uPanel3.BackColor = Color.Transparent;
            uPanel3.BgColor = Color.FromArgb(45, 50, 116);
            uPanel3.BgColor2 = Color.Transparent;
            uPanel3.Controls.Add(uPanel4);
            uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel3.Location = new Point(0, 640);
            uPanel3.Name = "uPanel3";
            uPanel3.Radius = 5;
            uPanel3.Size = new Size(1400, 73);
            uPanel3.TabIndex = 3;
            // 
            // uPanel4
            // 
            uPanel4.BackColor = Color.Transparent;
            uPanel4.BgColor = Color.FromArgb(45, 50, 116);
            uPanel4.BgColor2 = Color.Transparent;
            uPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel4.Location = new Point(0, 640);
            uPanel4.Name = "uPanel4";
            uPanel4.Radius = 5;
            uPanel4.Size = new Size(276, 73);
            uPanel4.TabIndex = 2;
            // 
            // uPanel2
            // 
            uPanel2.BackColor = Color.Transparent;
            uPanel2.BgColor = Color.FromArgb(45, 50, 116);
            uPanel2.BgColor2 = Color.Transparent;
            uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel2.Location = new Point(0, 640);
            uPanel2.Name = "uPanel2";
            uPanel2.Radius = 5;
            uPanel2.Size = new Size(276, 73);
            uPanel2.TabIndex = 2;
            // 
            // uPanel9
            // 
            uPanel9.BackColor = Color.Transparent;
            uPanel9.BgColor = Color.FromArgb(45, 50, 116);
            uPanel9.BgColor2 = Color.Transparent;
            uPanel9.Controls.Add(lbLoginTime);
            uPanel9.Controls.Add(lbUsername);
            uPanel9.Controls.Add(label2);
            uPanel9.Controls.Add(label1);
            uPanel9.Controls.Add(uPanel10);
            uPanel9.Controls.Add(uPanel14);
            uPanel9.Controls.Add(uPanel16);
            uPanel9.Dock = DockStyle.Bottom;
            uPanel9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel9.Location = new Point(0, 733);
            uPanel9.Name = "uPanel9";
            uPanel9.Radius = 5;
            uPanel9.Size = new Size(1400, 67);
            uPanel9.TabIndex = 5;
            // 
            // lbLoginTime
            // 
            lbLoginTime.AutoSize = true;
            lbLoginTime.BackColor = Color.FromArgb(53, 61, 134);
            lbLoginTime.ForeColor = SystemColors.ButtonFace;
            lbLoginTime.Location = new Point(474, 22);
            lbLoginTime.Name = "lbLoginTime";
            lbLoginTime.Size = new Size(0, 24);
            lbLoginTime.TabIndex = 8;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.FromArgb(53, 61, 134);
            lbUsername.ForeColor = SystemColors.ButtonFace;
            lbUsername.Location = new Point(118, 22);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(0, 24);
            lbUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(53, 61, 134);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(368, 22);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 6;
            label2.Text = "登录时间：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 61, 134);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 5;
            label1.Text = "登录者：";
            // 
            // uPanel10
            // 
            uPanel10.BackColor = Color.Transparent;
            uPanel10.BgColor = Color.FromArgb(45, 50, 116);
            uPanel10.BgColor2 = Color.Transparent;
            uPanel10.Controls.Add(uPanel11);
            uPanel10.Controls.Add(uPanel13);
            uPanel10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel10.Location = new Point(3, 640);
            uPanel10.Name = "uPanel10";
            uPanel10.Radius = 5;
            uPanel10.Size = new Size(835, 70);
            uPanel10.TabIndex = 4;
            // 
            // uPanel11
            // 
            uPanel11.BackColor = Color.Transparent;
            uPanel11.BgColor = Color.FromArgb(45, 50, 116);
            uPanel11.BgColor2 = Color.Transparent;
            uPanel11.Controls.Add(uPanel12);
            uPanel11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel11.Location = new Point(0, 640);
            uPanel11.Name = "uPanel11";
            uPanel11.Radius = 5;
            uPanel11.Size = new Size(1400, 73);
            uPanel11.TabIndex = 3;
            // 
            // uPanel12
            // 
            uPanel12.BackColor = Color.Transparent;
            uPanel12.BgColor = Color.FromArgb(45, 50, 116);
            uPanel12.BgColor2 = Color.Transparent;
            uPanel12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel12.Location = new Point(0, 640);
            uPanel12.Name = "uPanel12";
            uPanel12.Radius = 5;
            uPanel12.Size = new Size(276, 73);
            uPanel12.TabIndex = 2;
            // 
            // uPanel13
            // 
            uPanel13.BackColor = Color.Transparent;
            uPanel13.BgColor = Color.FromArgb(45, 50, 116);
            uPanel13.BgColor2 = Color.Transparent;
            uPanel13.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel13.Location = new Point(0, 640);
            uPanel13.Name = "uPanel13";
            uPanel13.Radius = 5;
            uPanel13.Size = new Size(276, 73);
            uPanel13.TabIndex = 2;
            // 
            // uPanel14
            // 
            uPanel14.BackColor = Color.Transparent;
            uPanel14.BgColor = Color.FromArgb(45, 50, 116);
            uPanel14.BgColor2 = Color.Transparent;
            uPanel14.Controls.Add(uPanel15);
            uPanel14.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel14.Location = new Point(0, 640);
            uPanel14.Name = "uPanel14";
            uPanel14.Radius = 5;
            uPanel14.Size = new Size(1400, 73);
            uPanel14.TabIndex = 3;
            // 
            // uPanel15
            // 
            uPanel15.BackColor = Color.Transparent;
            uPanel15.BgColor = Color.FromArgb(45, 50, 116);
            uPanel15.BgColor2 = Color.Transparent;
            uPanel15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel15.Location = new Point(0, 640);
            uPanel15.Name = "uPanel15";
            uPanel15.Radius = 5;
            uPanel15.Size = new Size(276, 73);
            uPanel15.TabIndex = 2;
            // 
            // uPanel16
            // 
            uPanel16.BackColor = Color.Transparent;
            uPanel16.BgColor = Color.FromArgb(45, 50, 116);
            uPanel16.BgColor2 = Color.Transparent;
            uPanel16.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel16.Location = new Point(0, 640);
            uPanel16.Name = "uPanel16";
            uPanel16.Radius = 5;
            uPanel16.Size = new Size(276, 73);
            uPanel16.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(39, 44, 102);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(uPageButton4);
            panel2.Controls.Add(uPageButton3);
            panel2.Controls.Add(uPageButton1);
            panel2.Controls.Add(uPageButton2);
            panel2.Controls.Add(btnStorePage);
            panel2.Location = new Point(282, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 40);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 44, 102);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1064, 3);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // uPageButton4
            // 
            uPageButton4.BackColor = Color.Transparent;
            uPageButton4.BackgroundImage = Resources.btnbg05;
            uPageButton4.BackgroundImageLayout = ImageLayout.Stretch;
            uPageButton4.BtnText = "仓库温控页面";
            uPageButton4.Location = new Point(822, 3);
            uPageButton4.Margin = new Padding(0);
            uPageButton4.Name = "uPageButton4";
            uPageButton4.Size = new Size(174, 35);
            uPageButton4.TabIndex = 4;
            // 
            // uPageButton3
            // 
            uPageButton3.BackColor = Color.Transparent;
            uPageButton3.BackgroundImage = Resources.btnbg04;
            uPageButton3.BackgroundImageLayout = ImageLayout.Stretch;
            uPageButton3.BtnText = "产品入库页面";
            uPageButton3.Location = new Point(618, 3);
            uPageButton3.Margin = new Padding(0);
            uPageButton3.Name = "uPageButton3";
            uPageButton3.Size = new Size(174, 35);
            uPageButton3.TabIndex = 3;
            // 
            // uPageButton1
            // 
            uPageButton1.BackColor = Color.Transparent;
            uPageButton1.BackgroundImage = Resources.btnbg03;
            uPageButton1.BackgroundImageLayout = ImageLayout.Stretch;
            uPageButton1.BtnText = "产品管理页面";
            uPageButton1.Location = new Point(413, 3);
            uPageButton1.Margin = new Padding(0);
            uPageButton1.Name = "uPageButton1";
            uPageButton1.Size = new Size(174, 35);
            uPageButton1.TabIndex = 2;
            // 
            // uPageButton2
            // 
            uPageButton2.BackColor = Color.Transparent;
            uPageButton2.BackgroundImage = Resources.btnbg02;
            uPageButton2.BackgroundImageLayout = ImageLayout.Stretch;
            uPageButton2.BtnText = "仓库分区页面";
            uPageButton2.Location = new Point(213, 3);
            uPageButton2.Margin = new Padding(0);
            uPageButton2.Name = "uPageButton2";
            uPageButton2.Size = new Size(174, 35);
            uPageButton2.TabIndex = 1;
            // 
            // btnStorePage
            // 
            btnStorePage.BackColor = Color.Transparent;
            btnStorePage.BackgroundImage = (Image)resources.GetObject("btnStorePage.BackgroundImage");
            btnStorePage.BackgroundImageLayout = ImageLayout.Stretch;
            btnStorePage.BtnText = "仓库管理页面";
            btnStorePage.Location = new Point(12, 3);
            btnStorePage.Margin = new Padding(0);
            btnStorePage.Name = "btnStorePage";
            btnStorePage.Size = new Size(174, 35);
            btnStorePage.TabIndex = 0;
            btnStorePage.Click += btnStorePage_Click;
            // 
            // panelPage
            // 
            panelPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPage.Location = new Point(282, 141);
            panelPage.Name = "panelPage";
            panelPage.Size = new Size(1106, 586);
            panelPage.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 61, 134);
            ClientSize = new Size(1400, 800);
            Controls.Add(panelPage);
            Controls.Add(panel2);
            Controls.Add(uPanel9);
            Controls.Add(uPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            Text = "仓库温度控制系统";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            uPanel1.ResumeLayout(false);
            uPanel5.ResumeLayout(false);
            uPanel6.ResumeLayout(false);
            uPanel3.ResumeLayout(false);
            uPanel9.ResumeLayout(false);
            uPanel9.PerformLayout();
            uPanel10.ResumeLayout(false);
            uPanel11.ResumeLayout(false);
            uPanel14.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private UControls.UPanel uPanel1;
        private UControls.UPanel uPanel3;
        private UControls.UPanel uPanel4;
        private UControls.UPanel uPanel2;
        private UControls.UPanel uPanel5;
        private UControls.UPanel uPanel6;
        private UControls.UPanel uPanel7;
        private UControls.UPanel uPanel8;
        private UControls.UPanel uPanel9;
        private UControls.UPanel uPanel10;
        private UControls.UPanel uPanel11;
        private UControls.UPanel uPanel12;
        private UControls.UPanel uPanel13;
        private UControls.UPanel uPanel14;
        private UControls.UPanel uPanel15;
        private UControls.UPanel uPanel16;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panelPage;
        private UControls.UMenuButton uMenuButton2;
        private UControls.UMenuButton uMenuButton1;
        private UControls.UIconButton btnClose;
        private UControls.UIconButton btnMax;
        private UControls.UIconButton btnMin;
        private Label lbLoginTime;
        private Label lbUsername;
        private UControls.UPageButton btnStorePage;
        private UControls.UPageButton uPageButton2;
        private UControls.UPageButton uPageButton4;
        private UControls.UPageButton uPageButton3;
        private UControls.UPageButton uPageButton1;
        private UControls.UMenuButton uMenuButton3;
        private Button button1;
    }
}