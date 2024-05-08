namespace STMS.STMSApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            uPanel1 = new UControls.UPanel();
            btnLogin = new UControls.UCircleButton();
            uPanel3 = new UControls.UPanel();
            txtUPwd = new TextBox();
            label3 = new Label();
            uPanel2 = new UControls.UPanel();
            txtUName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            uPanel1.SuspendLayout();
            uPanel3.SuspendLayout();
            uPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uPanel1
            // 
            uPanel1.BackColor = Color.Transparent;
            uPanel1.BackgroundImage = Resources.loginbgin;
            uPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            uPanel1.BgColor = Color.Transparent;
            uPanel1.BgColor2 = Color.Transparent;
            uPanel1.BorderColor = Color.Black;
            uPanel1.BorderStyle = BorderStyle.FixedSingle;
            uPanel1.Controls.Add(btnLogin);
            uPanel1.Controls.Add(uPanel3);
            uPanel1.Controls.Add(uPanel2);
            uPanel1.Controls.Add(label1);
            uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel1.Location = new Point(128, 157);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 5;
            uPanel1.Size = new Size(777, 311);
            uPanel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BgColor = Color.MediumTurquoise;
            btnLogin.BgColor2 = Color.Blue;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnLogin.Location = new Point(164, 231);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 5;
            btnLogin.Size = new Size(449, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // uPanel3
            // 
            uPanel3.BackColor = Color.Transparent;
            uPanel3.BgColor = Color.Transparent;
            uPanel3.BgColor2 = Color.Transparent;
            uPanel3.BorderColor = SystemColors.ButtonFace;
            uPanel3.BorderWidth = 2;
            uPanel3.Controls.Add(txtUPwd);
            uPanel3.Controls.Add(label3);
            uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel3.Location = new Point(164, 161);
            uPanel3.Name = "uPanel3";
            uPanel3.Radius = 5;
            uPanel3.Size = new Size(449, 61);
            uPanel3.TabIndex = 2;
            // 
            // txtUPwd
            // 
            txtUPwd.BackColor = Color.FromArgb(0, 33, 106);
            txtUPwd.BorderStyle = BorderStyle.FixedSingle;
            txtUPwd.ForeColor = SystemColors.ButtonFace;
            txtUPwd.Location = new Point(72, 17);
            txtUPwd.Name = "txtUPwd";
            txtUPwd.PasswordChar = '*';
            txtUPwd.Size = new Size(353, 30);
            txtUPwd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(11, 20);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 2;
            label3.Text = "密码：";
            // 
            // uPanel2
            // 
            uPanel2.BackColor = Color.Transparent;
            uPanel2.BgColor = Color.Transparent;
            uPanel2.BgColor2 = Color.Transparent;
            uPanel2.BorderColor = SystemColors.ButtonFace;
            uPanel2.BorderWidth = 2;
            uPanel2.Controls.Add(txtUName);
            uPanel2.Controls.Add(label2);
            uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel2.Location = new Point(164, 94);
            uPanel2.Name = "uPanel2";
            uPanel2.Radius = 5;
            uPanel2.Size = new Size(449, 61);
            uPanel2.TabIndex = 1;
            // 
            // txtUName
            // 
            txtUName.BackColor = Color.FromArgb(0, 33, 106);
            txtUName.BorderStyle = BorderStyle.FixedSingle;
            txtUName.ForeColor = SystemColors.ButtonFace;
            txtUName.Location = new Point(72, 17);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(353, 30);
            txtUName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(11, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "账号：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(276, 25);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 0;
            label1.Text = "仓库温度监控系统";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.logbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 594);
            Controls.Add(uPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "仓库温度监控系统登录界面";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UControls.UPanel uPanel1;
        private Label label1;
        private UControls.UPanel uPanel3;
        private UControls.UPanel uPanel2;
        private UControls.UCircleButton btnLogin;
        private Label label2;
        private TextBox txtUPwd;
        private Label label3;
        private TextBox txtUName;
    }
}