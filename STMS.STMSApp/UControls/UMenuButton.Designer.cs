namespace STMS.STMSApp.UControls
{
    partial class UMenuButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            lbBtnText = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Image = Resources._02;
            pbImage.Location = new Point(3, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(50, 50);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            pbImage.MouseDown += pbImage_MouseDown;
            pbImage.MouseEnter += pbImage_MouseEnter;
            pbImage.MouseLeave += pbImage_MouseLeave;
            pbImage.MouseUp += pbImage_MouseUp;
            // 
            // lbBtnText
            // 
            lbBtnText.AutoSize = true;
            lbBtnText.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbBtnText.ForeColor = SystemColors.ButtonFace;
            lbBtnText.Location = new Point(57, 5);
            lbBtnText.Name = "lbBtnText";
            lbBtnText.Size = new Size(137, 40);
            lbBtnText.TabIndex = 1;
            lbBtnText.Text = "仓库管理";
            lbBtnText.Click += lbBtnText_Click;
            lbBtnText.MouseDown += lbBtnText_MouseDown;
            lbBtnText.MouseEnter += lbBtnText_MouseEnter;
            lbBtnText.MouseLeave += lbBtnText_MouseLeave;
            lbBtnText.MouseUp += lbBtnText_MouseUp;
            // 
            // UMenuButton
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 50, 116);
            Controls.Add(lbBtnText);
            Controls.Add(pbImage);
            Name = "UMenuButton";
            Size = new Size(251, 50);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lbBtnText;
    }
}
