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
            uCircleButton1 = new UControls.UCircleButton();
            uPanel3 = new UControls.UPanel();
            textBox2 = new TextBox();
            label3 = new Label();
            uPanel2 = new UControls.UPanel();
            textBox1 = new TextBox();
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
            uPanel1.Controls.Add(uCircleButton1);
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
            // uCircleButton1
            // 
            uCircleButton1.BackColor = Color.Transparent;
            uCircleButton1.BgColor = Color.MediumTurquoise;
            uCircleButton1.BgColor2 = Color.Blue;
            uCircleButton1.ForeColor = SystemColors.ButtonFace;
            uCircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uCircleButton1.Location = new Point(164, 231);
            uCircleButton1.Name = "uCircleButton1";
            uCircleButton1.Radius = 5;
            uCircleButton1.Size = new Size(449, 42);
            uCircleButton1.TabIndex = 3;
            uCircleButton1.Text = "登录";
            uCircleButton1.UseVisualStyleBackColor = false;
            // 
            // uPanel3
            // 
            uPanel3.BackColor = Color.Transparent;
            uPanel3.BgColor = Color.Transparent;
            uPanel3.BgColor2 = Color.Transparent;
            uPanel3.BorderColor = SystemColors.ButtonFace;
            uPanel3.BorderWidth = 2;
            uPanel3.Controls.Add(textBox2);
            uPanel3.Controls.Add(label3);
            uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel3.Location = new Point(164, 161);
            uPanel3.Name = "uPanel3";
            uPanel3.Radius = 5;
            uPanel3.Size = new Size(449, 61);
            uPanel3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 33, 106);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(72, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 30);
            textBox2.TabIndex = 3;
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
            uPanel2.Controls.Add(textBox1);
            uPanel2.Controls.Add(label2);
            uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel2.Location = new Point(164, 94);
            uPanel2.Name = "uPanel2";
            uPanel2.Radius = 5;
            uPanel2.Size = new Size(449, 61);
            uPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 33, 106);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(72, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 30);
            textBox1.TabIndex = 1;
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
        private UControls.UCircleButton uCircleButton1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
    }
}