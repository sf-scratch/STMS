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
    public partial class UPageButton : UserControl
    {
        public UPageButton()
        {
            InitializeComponent();
        }

        public string BtnText
        {
            get { return lbText.Text; }
            set { lbText.Text = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            lbText.ForeColor = Color.FromArgb(45, 50, 116);
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
