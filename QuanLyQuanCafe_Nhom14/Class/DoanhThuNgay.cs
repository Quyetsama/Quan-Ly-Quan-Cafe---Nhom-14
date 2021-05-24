using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe_Nhom14.Class
{
    public class DoanhThuNgay
    {
        private DateTime? date;
        private float totalPrice;


        public DoanhThuNgay(DateTime? Date, float totalPrice = 0)
        {
            this.date = Date;
            this.totalPrice = totalPrice;
        }

        public DoanhThuNgay(DataRow row)
        {
            this.date = (DateTime?)row["Ngay"];
            this.totalPrice = (float)Convert.ToDouble(row["DoanhThu"].ToString());
        }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime? Date { get => date; set => date = value; }
    }
}
