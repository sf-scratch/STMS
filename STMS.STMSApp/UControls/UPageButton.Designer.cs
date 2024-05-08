namespace STMS.STMSApp.UControls
{
    partial class UPageButton
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
            lbText = new Label();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.Anchor = AnchorStyles.None;
            lbText.AutoSize = true;
            lbText.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbText.ForeColor = SystemColors.ButtonFace;
            lbText.Location = new Point(14, 5);
            lbText.Name = "lbText";
            lbText.Size = new Size(138, 28);
            lbText.TabIndex = 0;
            lbText.Text = "仓库管理页面";
            lbText.TextAlign = ContentAlignment.MiddleCenter;
            lbText.Click += lbText_Click;
            // 
            // UPageButton
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Resources.btnbg01;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lbText);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "UPageButton";
            Size = new Size(165, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbText;
    }
}
