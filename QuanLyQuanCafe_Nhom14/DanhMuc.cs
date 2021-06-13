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

namespace QuanLyQuanCafe_Nhom14
{
    public partial class DanhMuc : UserControl
    {
        string ID;

        DataTable dataExcel;

        public DanhMuc()
        {
            InitializeComponent();
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            cbbTrangThaiSP.Items.Add("Đang hoạt động");
            cbbTrangThaiSP.Items.Add("Dừng hoạt động");
            cbbTrangThaiSP.SelectedIndex = 0;

            cbbTKDanhMuc.Items.Add("Đang hoạt động");
            cbbTKDanhMuc.Items.Add("Dừng hoạt động");
            cbbTKDanhMuc.SelectedIndex = 0;

            btnLamMoi.Enabled = false;


            LoadDanhMuc();
            
        }

        private void LoadDanhMuc()
        {
            btnThemSua.Text = "Thêm";
            btnLamMoi.Enabled = false;

            txtTenSP.Text = "";
            txtTenSP.Focus();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory");
            dtgDanhSachLSP.DataSource = data;

            dataExcel = data;
        }



        private void dtgDanhSachLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSua.Text = "Sửa";
            btnLamMoi.Enabled = true;


            //Luu id
            ID = dtgDanhSachLSP.Rows[e.RowIndex].Cells["id"].Value.ToString();

            txtTenSP.Text = dtgDanhSachLSP.Rows[e.RowIndex].Cells["name"].Value.ToString();

            string trangThai = dtgDanhSachLSP.Rows[e.RowIndex].Cells["status"].Value.ToString();
            cbbTrangThaiSP.BorderRadius = 12;
            cbbTrangThaiSP.Text = trangThai;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thống Báo");
                return;
            }


            if (btnThemSua.Text == "Thêm")
            {


                int result = DataProvider.Instance.ExecuteNonQuery("insert into FoodCategory (name, status) values (N'" + txtTenSP.Text + "',N'" + cbbTrangThaiSP.Text + "')");

                if (result > 0)
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công", "Thống Báo");
                    LoadDanhMuc();
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại", "Thống Báo");
                }
            }
            else
            {
                int result = DataProvider.Instance.ExecuteNonQuery("update FoodCategory set name = N'" + txtTenSP.Text + "', status = N'" + cbbTrangThaiSP.Text + "' where id = '" + ID + "'");

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công", "Thống Báo");
                    LoadDanhMuc();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thất bại", "Thống Báo");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void cbbTKDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where status = N'" + cbbTKDanhMuc.Text + "'");
            dtgDanhSachLSP.DataSource = data;

            dataExcel = data;

            btnLamMoi.Enabled = true;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel obj = new ExportExcel();
                obj.WriteDataTableToExcel(dataExcel, "Danh mục", folderBrowserDialog.SelectedPath + "\\" + "danhMuc.xlsx", "");


                MessageBox.Show("Xuất file danh mục thành công!", "Thông Báo");
            }
        }
    }
}
