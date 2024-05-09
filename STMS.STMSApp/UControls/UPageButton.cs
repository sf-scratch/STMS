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

        public Color BtnTextColor
        {
            get { return lbText.ForeColor; }
            set { lbText.ForeColor = value; }
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
