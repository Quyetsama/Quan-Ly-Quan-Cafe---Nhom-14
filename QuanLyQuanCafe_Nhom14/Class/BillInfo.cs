using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe_Nhom14
{
    public class BillInfo
    {
        private int idFood;
        private string nameFood;
        private int count;
        private float price;
        private float totalPrice;
        private int discount;

        public BillInfo(int id, string name, int count, float price, float totalPrice = 0, int discount = 0)
        {
            this.idFood = id;
            this.nameFood = name;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
            this.discount = discount;
        }

        public BillInfo(DataRow row)
        {
            this.idFood = (int)row["id"];
            this.nameFood = row["name"].ToString();
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            this.discount = (int)row["discount"];
        }


        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
