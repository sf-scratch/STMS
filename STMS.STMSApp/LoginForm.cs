using STMS.BLL;

namespace STMS.STMSApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtUPwd.Clear();
            txtUName.Text = "admin";
            txtUPwd.Text = "admin";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MsgBoxHelper.MsgBoxConfirm("确定退出", "请确认退出");
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUName.Text.Trim();
            string password = txtUPwd.Text.Trim();
            //参数校验
            if (string.IsNullOrEmpty(username))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号不能为空！");
                txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "密码不能为空！");
                txtUPwd.Focus();
                return;
            }
            //登录过程
            UserBLL userBLL = new UserBLL();
            bool blLogin = userBLL.LoginSystem(username, password);
            if (blLogin)
            {
                //登录成功，显示主页面
                FormMain formMain = new FormMain();
                formMain.Tag = username;
                formMain.Show();
                this.Hide();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号或密码错误");
                txtUName.Focus();
            }
        }
    }
}