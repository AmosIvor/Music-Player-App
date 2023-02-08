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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void handleEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleLogin();
            }
        }
        private bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private bool Signin(string username, string password)
        {
            return AccountDAO.Instance.Signin(username, password);
        }

        private void ShowScreen()
        {
            Main__Screen main = new Main__Screen();
            Hide();
            main.ShowDialog();
            Show();
        }

        private void handleLogin()
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            if (Login(userName, password))
            {
                ShowScreen();
            }
            else
            {
                MessageBox.Show("Vui lòng đúng mật khẩu hoặc tài khoản đăng nhập!");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            if (Signin(userName, password)) 
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                ShowScreen();
            }
            else
            {
                MessageBox.Show("Người dùng đã tồn tại. Vui lòng sử dụng tên đăng nhập khác");
            }  
        }
    }
}
