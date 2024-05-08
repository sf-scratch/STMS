﻿using System;
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
    public partial class UIconButton : Button
    {
        public UIconButton()
        {
            InitializeComponent();
            this.Size = new Size(30, 30);
            this.Font = new Font("Webdings", 10.8f);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Text = "0";
            this.ForeColor = Color.Silver;
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(53, 61, 134);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Transparent;
        }

        protected override bool ShowFocusCues 
        { 
            get { return false; }
        }
    }
}
