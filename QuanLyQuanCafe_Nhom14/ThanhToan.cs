using QuanLyQuanCafe_Nhom14.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class ThanhToan : Form
    {

        private int idBill = 0;

        public ThanhToan()
        {
            InitializeComponent();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if(txtTienKhachTra.Text.ToString() == "" ||(float.Parse(txtTienKhachTra.Text) < float.Parse(txtTienPhaiThanhToan.Text)))
            {
                return;
            }


            DataTable dataBill = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + QuanLyBanHang.IDTable + "and status = 0");



            if (dataBill.Rows.Count > 0)
            {


                Bill bill = new Bill(dataBill.Rows[0]);

                idBill = bill.ID;

                printPreviewDialog1.Size = new Size(800, 800);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }


                

                DataProvider.Instance.ExecuteNonQuery("exec USP_ThanhToan @idTable , @idBill , @dateCheckOut , @totalPrice", new object[] { QuanLyBanHang.IDTable, bill.ID, DateTime.Now.ToString("yyyy.MM.dd"), QuanLyBanHang.TongTienThanhToan });

                this.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Segoe UI", 21, FontStyle.Bold), Brushes.Black, new Point(270, 100));
            e.Graphics.DrawString("Ngày bán: " + DateTime.Now.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("HĐ: " + idBill, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(700, 200));
            e.Graphics.DrawString("NVBH: " + 123, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(700, 250));
            e.Graphics.DrawString("______________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 270));




            e.Graphics.DrawString("Mặt hàng", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("SL", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(250, 320));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(350, 320));
            e.Graphics.DrawString("KM (%)", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 320));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(680, 320));




            List<BillInfo> listBillInfo = new List<BillInfo>();
            //label1.Text = billID.ToString();

            string query = "select f.id, f.name, bi.count, f.price, (f.price*bi.count*(100-f.discount))/100 as totalPrice, f.discount from Bill as b, BillInfo as bi, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + QuanLyBanHang.IDTable;
            DataTable dataBillInfo = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataBillInfo.Rows)
            {
                BillInfo info = new BillInfo(row);
                listBillInfo.Add(info);
            }



            int point = 320;
            foreach (BillInfo item in listBillInfo)
            {
                point += 50;
                e.Graphics.DrawString(item.NameFood.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, point));
                e.Graphics.DrawString(item.Count.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(250, point));
                e.Graphics.DrawString(item.Price.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, point));
                e.Graphics.DrawString(item.Discount.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, point));
                e.Graphics.DrawString(item.TotalPrice.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, point));
            }



        

            point += 50;
            e.Graphics.DrawString("______________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, point));
            point += 50;
            e.Graphics.DrawString("TỔNG TIỀN PHẢI THANH TOÁN", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(50, point));
            e.Graphics.DrawString(txtTienPhaiThanhToan.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, point));
            point += 50;

            e.Graphics.DrawString("TIỀN KHÁCH TRẢ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(50, point));
            e.Graphics.DrawString(txtTienKhachTra.Text.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, point));
            point += 50;

            e.Graphics.DrawString("TIỀN TRẢ LẠI", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(50, point));
            e.Graphics.DrawString((float.Parse(txtTienKhachTra.Text) - float.Parse(txtTienPhaiThanhToan.Text)).ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, point));
            point += 100;

            e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH VÀ HẸN GẶP LẠI", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(195, point));
        }
    }
}
