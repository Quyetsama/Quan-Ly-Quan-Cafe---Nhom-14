using QuanLyQuanCafe_Nhom14.Class;
using QuanLyQuanCafe_Nhom14.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class BaoCao_ThongKe : UserControl
    {
        public BaoCao_ThongKe()
        {
            InitializeComponent();

            
            //DataTable table = new DataTable();
            //table.Columns.Add("ID", Type.GetType("System.Double"));
            //guna2DataGridView1.DataSource = table;


            //guna2DataGridView1.Columns[0].HeaderText = "ID";
            //guna2DataGridView1.Columns[1].HeaderText = "Name";
            //guna2DataGridView1.Columns[2].HeaderText = "SL";
            //guna2DataGridView1.Columns[3].HeaderText = "Price";
            //guna2DataGridView1.Columns[4].HeaderText = "DisCount";


        }

        private void BaoCao_ThongKe_Load(object sender, EventArgs e)
        {
            DateTimeTu.Value = DateTime.Now.AddDays(-7);
            DateTimeDen.Value = DateTime.Now;
            DateTimeDen.CustomFormat = "yyyy-MM-dd";
            DateTimeDen.Format = DateTimePickerFormat.Custom;
            DateTimeTu.CustomFormat = "yyyy-MM-dd";
            DateTimeTu.Format = DateTimePickerFormat.Custom;

            cbbThongKe.Items.Add("Doanh Thu");
            cbbThongKe.Items.Add("Sản Phẩm");

            cbbThongKe.SelectedIndex = 0;

            ThongKe();

        }

        void ThongKe()
        {

            chart1.Series[0].Points.Clear();

            if (cbbThongKe.Text.ToString() == "Doanh Thu")
            {
                // Hien thi danh sach hoa don
                DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_ThongKeBill @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });
                dtgThongKe.DataSource = data;


                // lay doanh thu theo ngay va ve bieu do
                List<DoanhThuNgay> listDoanhThu = new List<DoanhThuNgay>();
                DataTable dataDoanhThu = DataProvider.Instance.ExecuteQuery("exec USP_BieuDoThongKeDoanhThu @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });

                foreach (DataRow row in dataDoanhThu.Rows)
                {
                    DoanhThuNgay doanhThu = new DoanhThuNgay(row);
                    listDoanhThu.Add(doanhThu);
                }

                chart1.Series[0].Name = "Doanh Thu (VNĐ)";

                foreach (DoanhThuNgay item in listDoanhThu)
                {
                    chart1.Series[0].Points.AddXY(item.Date.Value.ToString("yyyy-MM-dd"), (float)item.TotalPrice);
                }
            }
            else
            {
                List<ThongKeSanPham> listSanPham = new List<ThongKeSanPham>();
                DataTable dataSanPham = DataProvider.Instance.ExecuteQuery("exec USP_ThongKeSanPham @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });

                dtgThongKe.DataSource = dataSanPham;

                foreach (DataRow row in dataSanPham.Rows)
                {
                    ThongKeSanPham tkSanPham = new ThongKeSanPham(row);
                    listSanPham.Add(tkSanPham);
                }

                chart1.Series[0].Name = "Số Lượng Đã Bán";

                foreach (ThongKeSanPham item in listSanPham)
                {
                    chart1.Series[0].Points.AddXY(item.TenSP.ToString(), item.DaBan);
                }
            }
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        
    }
}
