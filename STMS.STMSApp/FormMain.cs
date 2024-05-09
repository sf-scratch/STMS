using STMS.STMSApp.UControls;
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
        int seletPageCode = 0;

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                InitStatusInfo();//状态栏初始化
                ShowStoreManage();//显示仓库管理页面
                btnStoreManagePage.Visible = true;
            }
        }

        private void ShowStoreManage()
        {
            SetPageButtonsColor(0);
            panelPage.AddPanelForm(typeof(Store.FormStoreList));
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

        private void btnStoreManage_Click(object sender, EventArgs e)
        {
            ShowStoreManage();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(2);
            panelPage.AddPanelForm(typeof(Store.FormProductList));
        }

        private void btnStoreTemperatureManage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(4);
            panelPage.AddPanelForm(typeof(Store.FormStoreRegionTemperatureList));
        }

        private void SetPageButtonsColor(int pageCode)
        {
            seletPageCode = pageCode;
            switch (seletPageCode)
            {
                case 0:
                    SetPageButtonsColor(btnStoreManagePage);
                    break;
                case 1:
                    SetPageButtonsColor(btnStoreRegionPage);
                    break;
                case 2:
                    SetPageButtonsColor(btnProductManagePage);
                    break;
                case 3:
                    SetPageButtonsColor(btnProductInputPage);
                    break;
                case 4:
                    SetPageButtonsColor(btnStoreTemperaturePage);
                    break;
            }
        }

        private void SetPageButtonsColor(UPageButton pageButton)
        {
            //分页按钮文本颜色
            Color topSelColor = Color.FromArgb(45, 50, 116);//点击时或显示相关页面时
            Color topUnSelColor = Color.White;//默认或没有显示页面时
            pageButton.BtnTextColor = topSelColor;
            UPageButton[] pageButtons = { btnStoreManagePage, btnStoreRegionPage, btnProductManagePage, btnProductInputPage, btnStoreTemperaturePage };
            foreach (UPageButton button in pageButtons)
            {
                if (button.Name != pageButton.Name)
                {
                    button.BtnTextColor = topUnSelColor;
                }
            }
        }

        private void btnStoreManagePage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(0);
            panelPage.AddPanelForm(typeof(Store.FormStoreList));
        }

        private void btnStoreRegionPage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(1);
            panelPage.AddPanelForm(typeof(Store.FormStoreRegionList));
        }

        private void btnProductManagePage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(2);
            panelPage.AddPanelForm(typeof(Store.FormProductList));
        }

        private void btnProductInputPage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(3);
            panelPage.AddPanelForm(typeof(Store.FormProductInStore));
        }

        private void btnStoreTemperaturePage_Click(object sender, EventArgs e)
        {
            SetPageButtonsColor(4);
            panelPage.AddPanelForm(typeof(Store.FormStoreRegionTemperatureList));
        }
    }
}
