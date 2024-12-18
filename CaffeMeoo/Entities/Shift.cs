using System;
using System.ComponentModel.DataAnnotations;

namespace CaffeMeoo.Entities
{
    // Enum để đại diện cho các ca làm việc
    public enum ShiftType
    {
        Morning,    // Ca sáng
        Afternoon,  // Ca chiều
        Night       // Ca tối
    }

    public class WorkShift
    {
        // Mã số ca làm việc
        [Key]

        public int ID { get; set; }

        // Số điện thoại của nhân viên
        public string EmployeePhoneNumber { get; set; }

        // Ca làm việc (Morning, Afternoon, Night)
        public ShiftType Shift { get; set; }

        // Ngày làm việc của nhân viên
        public DateTime Date { get; set; }

        // Xác định nếu ca làm việc có phải là "Ca sáng", "Ca chiều" hay "Ca tối"
        public string GetShiftDescription()
        {
            switch (Shift)
            {
                case ShiftType.Morning:
                    return "Ca sáng (9h-14h)";
                case ShiftType.Afternoon:
                    return "Ca chiều (14h-19h)";
                case ShiftType.Night:
                    return "Ca tối (19h-24h)";
                default:
                    return "Không xác định";
            }
        }

        // Kiểm tra nếu ca làm việc hiện tại có phải ca sáng, ca chiều hay ca tối
        public bool IsCurrentShift(DateTime currentDateTime)
        {
            // Lấy giờ trong ngày
            TimeSpan time = currentDateTime.TimeOfDay;

            if (Shift == ShiftType.Morning && time >= new TimeSpan(9, 0, 0) && time < new TimeSpan(14, 0, 0))
            {
                return true;
            }
            else if (Shift == ShiftType.Afternoon && time >= new TimeSpan(14, 0, 0) && time < new TimeSpan(19, 0, 0))
            {
                return true;
            }
            else if (Shift == ShiftType.Night && time >= new TimeSpan(19, 0, 0) && time < new TimeSpan(24, 0, 0))
            {
                return true;
            }

            return false;
        }

        // Phương thức kiểm tra xem ngày ca làm việc có trùng với ngày hôm nay không
        public bool IsWorkToday(DateTime currentDate)
        {
            return Date.Date == currentDate.Date;
        }

       
    }
}
