using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeMeoo
{
    public partial class BeforSignUp : Form
    {
        public BeforSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text.Trim();

            // Kiểm tra email có hợp lệ không
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gửi email xác minh
            bool emailSent = SendVerificationEmail(email);
            if (emailSent)
            {
                MessageBox.Show("Vui lòng kiểm tra hộp thư của bạn để xác minh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gửi email không thành công. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool SendVerificationEmail(string recipientEmail)
        {
            try
            {
                // Thông tin SMTP server
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your_email@gmail.com", "your_password"),
                    EnableSsl = true,
                };

                // Tạo nội dung email
                string verificationCode = GenerateVerificationCode();
                string subject = "Mã xác minh đăng ký";
                string body = $"Mã xác minh của bạn là: {verificationCode}\nVui lòng nhập mã này để hoàn tất đăng ký.";

                // Tạo và gửi email
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("your_email@gmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };
                mailMessage.To.Add(recipientEmail);

                smtpClient.Send(mailMessage);
                return true;
            }
            catch (SmtpException smtpEx)
            {
                // In lỗi SMTP
                MessageBox.Show($"SMTP Error: {smtpEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // In lỗi chung
                MessageBox.Show($"General Error: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }


        private void BeforSignUp_Load(object sender, EventArgs e)
        {

        }

        private void lkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login res = new Login();
            this.Hide();
            res.ShowDialog();
            this.Show();
        }
    }
}
