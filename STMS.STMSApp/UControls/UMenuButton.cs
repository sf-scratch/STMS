using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.STMSApp.UControls
{
    [DefaultEvent("Click")]
    public partial class UMenuButton : UserControl
    {
        public UMenuButton()
        {
            InitializeComponent();
        }

        public Image BtnImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
        }

        public string BtnText
        {
            get { return lbBtnText.Text; }
            set { lbBtnText.Text = value; }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.FromArgb(45, 50, 116);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.BackColor = Color.FromArgb(45, 50, 116);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }

        private void lbBtnText_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void lbBtnText_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void lbBtnText_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void lbBtnText_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        private void lbBtnText_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
