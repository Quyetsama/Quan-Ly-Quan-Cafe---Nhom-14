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
                DataProvider.Instance.ExecuteNonQuery("exec USP_ThanhToan @idTable , @idBill , @dateCheckOut , @totalPrice", new object[] { QuanLyBanHang.IDTable, bill.ID, DateTime.Now.ToString("yyyy.MM.dd"), QuanLyBanHang.TongTienThanhToan });

               
                this.Close();
            }
        }

        
    }
}
