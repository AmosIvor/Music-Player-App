using Music__Player.sources.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player
{
    public partial class fSignUp : Form
    {
        public fSignUp(fLogin fLogin)
        {
            InitializeComponent();
            Login = fLogin;       
        }

        private fLogin login;
        public fLogin Login
        {
            get { return login; }
            set
            {
                login = value;
            }
        }
        private bool Signin(string username, string password, string displayName)
        {
            return AccountDAO.Instance.Signin(username, password, displayName);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string passWord = tbPassword.Text;
            string nickName = tbNickName.Text;
            string confirmPassword = tbConfirmPassword.Text;
            if (userName == "" || passWord == "" || nickName == "" || confirmPassword == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            } else if (tbConfirmPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Hãy nhập đúng mật khẩu xác thực!");
            } else
            {
                if (Signin(userName, passWord, nickName))
                {
                    MessageBox.Show("Đăng ký thành công!");
                    Close(); 
                } 
                else
                {
                    MessageBox.Show("Tên người dùng đã được đăng ký. Vui lòng nhập tên khác!");
                    ResetForm();
                }
            }
        }
        private void ResetForm()
        {
            tbUserName.Text = "";
            tbUserName.Focus();
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbNickName.Text = "";
        }
        private void fSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
