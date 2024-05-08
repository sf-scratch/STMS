using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace STMS.STMSApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = null;

        private Point mPoint;//定义一个位置信息Point用于存储鼠标位置

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MsgBoxHelper.MsgBoxConfirm("确定退出", "请确认退出");
            if (result == DialogResult.Yes)
            {
                if (timer != null)
                {
                    timer.Stop();
                }
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = "1";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "2";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void btnStorePage_Click(object sender, EventArgs e)
        {
            MsgBoxHelper.MsgBoxShow("点击", "lll");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                InitStatusInfo();//状态栏初始化
                ShowStoreManage();//显示仓库管理页面
                btnStorePage.Visible = true;
            }
        }

        private void ShowStoreManage()
        {

        }

        private void InitStatusInfo()
        {
            string username = this.Tag.ToString();
            lbUsername.Text = username;

            lbLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.lbLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }
    }
}
