using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using CaffeMeoo.Entities;
using CaffeMeoo;



namespace CaffeMeoo
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();

        }
        private TextBox txtUsername;
        private TextBox txtPassword;
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();

            // Đặt tên các control
            txtUsername.Name = "txtUsername";
            txtPassword.Name = "txtPassword";

            // Cấu hình cho Button
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;

            // Thêm các control vào Form
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra đăng nhập
                bool loginSuccess = AuthenticateUser(username, password);

                if (loginSuccess)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private bool AuthenticateUser(string username, string password)
        {
            using (var context = new CompanyDBContext()) // Sử dụng DbContext
            {
                // Tìm người dùng theo tên đăng nhập
                var user = context.MasterUsers.SingleOrDefault(u => u.Username == username);

                if (user != null)
                {
                    // Kiểm tra mật khẩu với bcrypt
                    if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                    {
                        return true;
                    }
                }
                return false;
            }
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            BeforSignUp reg = new BeforSignUp();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txPass.Text))
            {
                this.txPass.PlaceholderText = "Password";
                this.txPass.PasswordChar = '\0';
            }
            else
            {
                this.txPass.PlaceholderText = "";
                this.txPass.PasswordChar = '●';
            }
        }

       

        private void txUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPass_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txPass.Text))
            {
                this.txPass.PlaceholderText = "Password";
                this.txPass.PasswordChar = '\0';
            }
            else
            {
                this.txPass.PlaceholderText = "";
                this.txPass.PasswordChar = '●';
            }
        }

        private void btnLoginGoogle_Click(object sender, EventArgs e)
        {
            bool loginSuccess = GoogleLogin();
            if (loginSuccess)
            {
                if (GlobalVars.CurrentUser != null)
                {
                    if (GlobalVars.CurrentUser.Position != "Master" && GlobalVars.CurrentUser.Position != "Admin")
                    {
                        User user = new User();
                        this.Hide();
                        user.ShowDialog();
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool GoogleLogin()
        {
            throw new NotImplementedException();
        }

    }
}
