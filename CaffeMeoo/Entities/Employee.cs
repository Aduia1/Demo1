﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeMeoo.Entities
{
    public class Employee
    {
        [Key]

        public string ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Shift { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public string Address { get; set; }


        private static string error1 = "Không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {

            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_3()
        {
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsEqual(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null) { return false; }

            if (employee1.ID != employee2.ID)
            {
                error1 = "Nhân viên không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null) { return false; }

            if (employee1.ID != employee2.ID)
            {
                error1 = "Nhân viên không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null) { return false; }

            if (employee1.ID != employee2.ID)
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
