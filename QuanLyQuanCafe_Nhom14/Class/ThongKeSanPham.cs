using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe_Nhom14.Class
{
    public class ThongKeSanPham
    {
        private int id;
        private string loaiSP;
        private string tenSP;
        private float donGia;
        private int khuyenMai;
        private int daBan;

        public ThongKeSanPham(int id, string lsp, string sp, float gia, int km, int sl)
        {
            this.id = id;
            this.loaiSP = lsp;
            this.tenSP = sp;
            this.donGia = gia;
            this.khuyenMai = km;
            this.daBan = sl;
        }

        public ThongKeSanPham(DataRow row)
        {
            this.id = (int)row["IDSP"];
            this.loaiSP = row["Loại Sản Phẩm"].ToString();
            this.tenSP = row["Tên Sản Phẩm"].ToString();
            this.donGia = (float)Convert.ToDouble(row["Đơn Giá"].ToString());
            this.khuyenMai = (int)row["Khuyến Mãi"];
            this.daBan = (int)row["Đã Bán"];
        }


        public int Id { get => id; set => id = value; }
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public int DaBan { get => daBan; set => daBan = value; }
    }
}
