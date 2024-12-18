using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeMeoo.Entities
{
    public class Item
    {
        [Key]

        public string ID { get; set; }
        public string Name { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }
        public string Point { get; set; }
        public string Type { get; set; }

        public string ImageURL { get; set; }

        private static string error1 = "Không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_3()
        {
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool IsEqual(Item drink1, Item drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                error1 = " không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(Item drink1, Item drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                error1 = "Sản phẩm không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(Item drink1, Item drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                //System.Windows.Forms.MessageBox.Show("Sản phẩm không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
