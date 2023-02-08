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
            tbUserName.Focus();
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

        private void ShowScreen(Main__Screen mainScreen, fAdmin adminScreen)
        {
            Form main;
            if (mainScreen != null)
            {
                main = mainScreen;
            } else
            {
                main = adminScreen;
            }
            Hide();
            main.ShowDialog();
            ResetForm();
            Show();
        }
        private void ResetForm()
        {
            tbUserName.Text = "";
            tbUserName.Focus();
            tbPassword.Text = "";
        }

        private void handleLogin()
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            if (userName == "admin")
            {
                if (Login(userName, password))
                {
                    ShowScreen(null, new fAdmin());
                    ResetForm();
                } else
                {
                    MessageBox.Show("Vui lòng đúng mật khẩu hoặc tài khoản đăng nhập!");
                }
            } else
            {
                if (Login(userName, password))
                {
                    string query = $"Login @userName = {userName}, @passWord = {password}";
                    DataTable results = DataProviderDAO.Instance.ExecuteQuery(query);
                    DataRow dataRow = results.Rows[0];
                    ShowScreen(new Main__Screen(dataRow["DisplayName"].ToString()),null);
                }
                else
                {
                    MessageBox.Show("Vui lòng đúng mật khẩu hoặc tài khoản đăng nhập!");
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fSignUp formSignUp = new fSignUp(this);
            Hide();
            formSignUp.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
