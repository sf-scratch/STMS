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
            DialogResult result = MsgBoxHelper.MsgBoxConfirm("ȷ���˳�", "��ȷ���˳�");
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
            //����У��
            if (string.IsNullOrEmpty(username))
            {
                MsgBoxHelper.MsgErrorShow("��¼ϵͳ", "�˺Ų���Ϊ�գ�");
                txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MsgBoxHelper.MsgErrorShow("��¼ϵͳ", "���벻��Ϊ�գ�");
                txtUPwd.Focus();
                return;
            }
            //��¼����
            UserBLL userBLL = new UserBLL();
            bool blLogin = userBLL.LoginSystem(username, password);
            if (blLogin)
            {
                //��¼�ɹ�����ʾ��ҳ��
                FormMain formMain = new FormMain();
                formMain.Tag = username;
                formMain.Show();
                this.Hide();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("��¼ϵͳ", "�˺Ż��������");
                txtUName.Focus();
            }
        }
    }
}