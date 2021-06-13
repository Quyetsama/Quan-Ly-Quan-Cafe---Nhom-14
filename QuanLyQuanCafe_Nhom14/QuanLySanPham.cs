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

    public partial class QuanLySanPham : UserControl
    {
        DataTable dataExcel;
        DataTable dataExcel2;
        string ID;
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            cbbTrangThaiSP.Items.Add("Đang hoạt động");
            cbbTrangThaiSP.Items.Add("Dừng hoạt động");
            cbbTrangThaiSP.SelectedIndex = 0;



            btnLamMoi.Enabled = false;




            LoadSanPham();
            LoadSanPhamTK(1);
            LoadCategory();
        }


        void LoadCategory()
        {
            // Lay danh sach loai san pham
            List<Category> listCategory = new List<Category>();
            List<Category> listCategoryTK = new List<Category>();

            string queryCategory = "select * from FoodCategory where status = N'Đang hoạt động'";

            DataTable dataCategory = DataProvider.Instance.ExecuteQuery(queryCategory);

            foreach (DataRow row in dataCategory.Rows)
            {
                Category category = new Category(row);
                listCategory.Add(category);
                listCategoryTK.Add(category);
            }

            cbbDanhMuc.DataSource = listCategory;
            cbbTimKiemDanhMuc.DataSource = listCategoryTK;
            cbbDanhMuc.DisplayMember = "name";
            cbbTimKiemDanhMuc.DisplayMember = "name";

        }

        private void LoadSanPham()
        {
            btnThemSua.Text = "Thêm";
            btnLamMoi.Enabled = false;

            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtKhuyenMai.Text = "";
            txtTenSP.Focus();



            DataTable data = DataProvider.Instance.ExecuteQuery("select f.id, f.name, f.idCategory, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where f.idCategory = fc.id");
            dtgDanhSachSP.DataSource = data;
            dtgDanhSachSP.Columns["idCategory"].Visible = false;

            dataExcel = data;


        }

        private void LoadSanPhamTK(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select f.id, f.name, f.idCategory, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where f.idCategory = '"+ id + "' and f.idCategory = fc.id");
            dtgTimKiemSP.DataSource = data;
            dtgTimKiemSP.Columns["idCategory"].Visible = false;

            dataExcel2 = data;


        }

        private void dtgDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSua.Text = "Sửa";
            btnLamMoi.Enabled = true;


            //Luu id
            ID = dtgDanhSachSP.Rows[e.RowIndex].Cells["idSP"].Value.ToString();

            txtTenSP.Text = dtgDanhSachSP.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtGiaSP.Text = dtgDanhSachSP.Rows[e.RowIndex].Cells["price"].Value.ToString();
            txtKhuyenMai.Text = dtgDanhSachSP.Rows[e.RowIndex].Cells["discount"].Value.ToString();

            string danhMuc = dtgDanhSachSP.Rows[e.RowIndex].Cells["nameCategory"].Value.ToString();
            cbbDanhMuc.BorderRadius = 12;
            cbbDanhMuc.Text = danhMuc;



            string trangThai = dtgDanhSachSP.Rows[e.RowIndex].Cells["status"].Value.ToString();
            cbbTrangThaiSP.BorderRadius = 12;
            cbbTrangThaiSP.Text = trangThai;




        }

        private void dtgTimKiemSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSua.Text = "Sửa";
            btnLamMoi.Enabled = true;


            //Luu id
            ID = dtgTimKiemSP.Rows[e.RowIndex].Cells["idSPTK"].Value.ToString();

            txtTenSP.Text = dtgTimKiemSP.Rows[e.RowIndex].Cells["nameTK"].Value.ToString();
            txtGiaSP.Text = dtgTimKiemSP.Rows[e.RowIndex].Cells["dongiaTK"].Value.ToString();
            txtKhuyenMai.Text = dtgTimKiemSP.Rows[e.RowIndex].Cells["kmTK"].Value.ToString();

            string danhMuc = dtgTimKiemSP.Rows[e.RowIndex].Cells["danhmucTK"].Value.ToString();
            cbbDanhMuc.BorderRadius = 12;
            cbbDanhMuc.Text = danhMuc;



            string trangThai = dtgTimKiemSP.Rows[e.RowIndex].Cells["statusTK"].Value.ToString();
            cbbTrangThaiSP.BorderRadius = 12;
            cbbTrangThaiSP.Text = trangThai;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadCategory();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtGiaSP.Text == "" || txtKhuyenMai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thống Báo");
                return;
            }


            string idCate = DataProvider.Instance.ExecuteScalar("select id from FoodCategory where name = N'" + cbbDanhMuc.Text + "'").ToString();

            if (btnThemSua.Text == "Thêm")
            {

                

                int result = DataProvider.Instance.ExecuteNonQuery("insert into Food (name, idCategory, price, discount, status) values (N'" + txtTenSP.Text + "', N'" + idCate + "', N'" + txtGiaSP.Text + "', N'" + txtKhuyenMai.Text + "', N'" + cbbTrangThaiSP.Text + "')");

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thống Báo");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thống Báo");
                }
            }
            else
            {
                int result = DataProvider.Instance.ExecuteNonQuery("update Food set name = N'" + txtTenSP.Text + "', idCategory = N'" + idCate + "', price = N'" + txtGiaSP.Text + "', discount = N'" + txtKhuyenMai.Text + "', status = N'" + cbbTrangThaiSP.Text + "' where id = '" + ID + "'");

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thống Báo");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại", "Thống Báo");
                }
            }
        }

        private void btnSPMax_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select f.id, f.name, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where f.price in (select Max(price) from Food) and f.idCategory = fc.id");
            dtgTimKiemSP.DataSource = data;

            dataExcel2 = data;
        }

        private void btnSPMin_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select f.id, f.name, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where f.price in (select Min(price) from Food) and f.idCategory = fc.id");
            dtgTimKiemSP.DataSource = data;

            dataExcel2 = data;
        }

        private void btnGiaSP_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select f.id, f.name, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where price >= '"+ txtGia1.Text + "' and price <= '" + txtGia2.Text + "' and f.idCategory = fc.id");
            dtgTimKiemSP.DataSource = data;

            dataExcel2 = data;
        }

        private void btnIDSP_Click(object sender, EventArgs e)
        {


            string query = string.Format("select f.id, f.name, fc.name as nameCategory, f.price, f.discount, f.status from Food as f, FoodCategory as fc where f.id like N'%{0}%' and f.idCategory = fc.id", txtIDSP.Text);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            dtgTimKiemSP.DataSource = data;

            dataExcel2 = data;
        }

        private void cbbTimKiemDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 1;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }


            Category selected = cb.SelectedItem as Category;

            id = selected.ID;

            LoadSanPhamTK(id);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel obj = new ExportExcel();
                obj.WriteDataTableToExcel(dataExcel, "Sản Phẩm", folderBrowserDialog.SelectedPath + "\\" + "sanPham.xlsx", "");


                MessageBox.Show("Xuất file sản phẩm thành công!", "Thông Báo");
            }
        }

        private void btnExportExcel2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel obj = new ExportExcel();
                obj.WriteDataTableToExcel(dataExcel2, "Sản Phẩm", folderBrowserDialog.SelectedPath + "\\" + "sanPhamTimKiem.xlsx", "");


                MessageBox.Show("Xuất file sản phẩm thành công!", "Thông Báo");
            }
        }

        
    }
}
