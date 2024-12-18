using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaffeMeoo.Entities;

namespace CaffeMeoo
{
    public partial class AdminFP : Form

    {
        private Panel AdminMainPanel;

        public AdminFP()
        {
            InitializeComponent();
            this.AdminMainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(this.AdminMainPanel);
        }
        private void ShowUserControl(UserControl userControl)
        {
            if (userControl == null)
            {
                MessageBox.Show("Không thể tải màn hình này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AdminMainPanel.Controls.Contains(userControl))
            {
                AdminMainPanel.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
            {
                userControl.BringToFront();
            }
        }

        private void AdminPanelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminFP_Load(object sender, EventArgs e)
        {
            ShowUserControl(AdminMenu.Instance);
        }
 

        private void AdminUser_Click(object sender, EventArgs e)
        {

        }

        private void AdminMenuBtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(AdminMenu.Instance);
        }

        private void AdminOrderBtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(AdminOrder.Instance);

        }

        private void AdminReviewBtn_Click(object sender, EventArgs e)
        { 
             ShowUserControl(AdminItems.Instance);
        }

        private void AdminFinancialBtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(AdminFinancial.Instance);
        }

        private void AdminEmployeeBtn_Click(object sender, EventArgs e)
        {

            ShowUserControl(AdminEmployee.Instance);

        }

        private void AdminCustomerBtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(AdminCustomer.Instance);
        }
    }
    }

