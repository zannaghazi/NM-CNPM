using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class LoginForm : Form
    {
        private MainForm parent;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            this.txtPassword.PasswordChar = '*';
            this.parent = parent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (this.parent.memberBus.CheckLogin(this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim()))
            {
                this.parent.username = this.txtUsername.Text.Trim();
                this.parent.LoginCallBack();
                this.Close();
            }
            else
            {
                this.errorMess.Text = "Tên đăng nhập hoặc mật khẩu không chính xác!";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
