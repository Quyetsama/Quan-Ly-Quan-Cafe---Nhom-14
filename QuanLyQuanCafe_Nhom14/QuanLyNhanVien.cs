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
    public partial class QuanLyNhanVien : UserControl
    {

        DataTable data;
        string State = "";
        string ID = "0";

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            //State = "Reset";
            //SetControl(State);
            



            btnLamMoi.Enabled = false;
            btnXoa.Enabled = false;

            dateTimeNgaySinh.Value = DateTime.Now;
            dateTimeNgaySinh.CustomFormat = "yyyy-MM-dd";
            dateTimeNgaySinh.Format = DateTimePickerFormat.Custom;

            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedIndex = 0;

            cbbChucVu.Items.Add("Quản lý");
            cbbChucVu.Items.Add("Nhân viên bán hàng");
            cbbChucVu.Items.Add("Nhân viên phục vụ");
            cbbChucVu.Items.Add("Nhân viên quét dọn");
            cbbChucVu.SelectedIndex = 2;

            cbbCalamViec.Items.Add("Cả ngày");
            cbbCalamViec.Items.Add("Sáng");
            cbbCalamViec.Items.Add("Chiều");
            cbbCalamViec.Items.Add("Tối");
            cbbCalamViec.SelectedIndex = 0;


            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            //btnLamMoi.Enabled = false;
            //btnXoa.Enabled = false;

            btnThemSua.Text = "Thêm";
            btnLamMoi.Enabled = false;
            btnXoa.Enabled = false;

            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtHoTen.Focus();

            dateTimeNgaySinh.Value = DateTime.Now;

            cbbGioiTinh.SelectedIndex = 0;
            cbbGioiTinh.BorderRadius = 12;
            cbbChucVu.SelectedIndex = 2;
            cbbChucVu.BorderRadius = 12;
            cbbCalamViec.SelectedIndex = 0;
            cbbCalamViec.BorderRadius = 12;

            data = DataProvider.Instance.ExecuteQuery("select * from NhanVien");
            dtgNhanVien.DataSource = data;
        }

        //private void SetControl(string State)
        //{
        //    switch (State)
        //    {
        //        case "Reset":
        //            btnThemSua.Enabled = true;
        //            btnSua.Enabled = true;
        //            btnXoa.Enabled = true;
        //            btnGhiDuLieu.Enabled = false;
        //            btnLamMoi.Enabled = false;

        //            txtHoTen.Enabled = false;
        //            txtDiaChi.Enabled = false;
        //            txtSDT.Enabled = false;
        //            txtCMND.Enabled = false;
        //            cbbCalamViec.Enabled = false;
        //            cbbChucVu.Enabled = false;
        //            cbbGioiTinh.Enabled = false;
        //            dateTimeNgaySinh.Enabled = false;

        //            break;

        //        case "Insert":
        //            btnThemSua.Enabled = false;
        //            btnSua.Enabled = false;
        //            btnXoa.Enabled = false;
        //            btnGhiDuLieu.Enabled = true;
        //            btnLamMoi.Enabled = true;

        //            txtHoTen.Enabled = true;
        //            txtDiaChi.Enabled = true;
        //            txtSDT.Enabled = true;
        //            txtCMND.Enabled = true;
        //            cbbCalamViec.Enabled = true;
        //            cbbChucVu.Enabled = true;
        //            cbbGioiTinh.Enabled = true;
        //            dateTimeNgaySinh.Enabled = true;

        //            txtHoTen.Text = "";
        //            txtDiaChi.Text = "";
        //            txtSDT.Text = "";
        //            txtCMND.Text = "";
        //            txtHoTen.Focus();

        //            break;

        //        case "Update":
        //            btnThemSua.Enabled = false;
        //            btnSua.Enabled = false;
        //            btnXoa.Enabled = false;
        //            btnGhiDuLieu.Enabled = true;
        //            btnLamMoi.Enabled = true;

        //            txtHoTen.Enabled = true;
        //            txtDiaChi.Enabled = true;
        //            txtSDT.Enabled = true;
        //            txtCMND.Enabled = true;
        //            cbbCalamViec.Enabled = true;
        //            cbbChucVu.Enabled = true;
        //            cbbGioiTinh.Enabled = true;
        //            dateTimeNgaySinh.Enabled = true;

        //            break;

        //        case "Delete":
        //            btnThemSua.Enabled = false;
        //            btnSua.Enabled = false;
        //            btnXoa.Enabled = false;
        //            btnGhiDuLieu.Enabled = true;
        //            btnLamMoi.Enabled = true;

        //            txtHoTen.Enabled = false;
        //            txtDiaChi.Enabled = false;
        //            txtSDT.Enabled = false;
        //            txtCMND.Enabled = false;
        //            cbbCalamViec.Enabled = false;
        //            cbbChucVu.Enabled = false;
        //            cbbGioiTinh.Enabled = false;
        //            dateTimeNgaySinh.Enabled = false;

        //            break;
        //    }
        //}

        

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSua.Text = "Sửa";
            btnLamMoi.Enabled = true;
            btnXoa.Enabled = true;

            //Luu id
            ID = dtgNhanVien.Rows[e.RowIndex].Cells["id"].Value.ToString();

            txtHoTen.Text = dtgNhanVien.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtDiaChi.Text = dtgNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dtgNhanVien.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            txtCMND.Text = dtgNhanVien.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
            dateTimeNgaySinh.Value = Convert.ToDateTime(dtgNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            string CaLam = dtgNhanVien.Rows[e.RowIndex].Cells["CaLamViec"].Value.ToString();
            cbbCalamViec.BorderRadius = 12;
            if (CaLam == "Cả ngày")
            {
                cbbCalamViec.SelectedIndex = 0;
            }else if(CaLam == "Sáng")
            {
                cbbCalamViec.SelectedIndex = 1;
            }
            else if (CaLam == "Chiều")
            {
                cbbCalamViec.SelectedIndex = 2;
            }
            else if (CaLam == "Tối")
            {
                cbbCalamViec.SelectedIndex = 3;
            }

            string GioiTinh = dtgNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            cbbGioiTinh.BorderRadius = 12;
            if (GioiTinh == "Nam")
            {
                cbbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbbGioiTinh.SelectedIndex = 1;
            }

            string ChucVu = dtgNhanVien.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
            cbbChucVu.BorderRadius = 12;
            if (ChucVu == "Quản lý")
            {
                cbbChucVu.SelectedIndex = 0;
            }
            else if(ChucVu == "Nhân viên bán hàng")
            {
                cbbChucVu.SelectedIndex = 1;
            }
            else if (ChucVu == "Nhân viên phục vụ")
            {
                cbbChucVu.SelectedIndex = 2;
            }
            else if (ChucVu == "Nhân viên quét dọn")
            {
                cbbChucVu.SelectedIndex = 3;
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {

            if(txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thống Báo");
                return;
            }

            if(btnThemSua.Text == "Thêm")
            {
                int result = DataProvider.Instance.ExecuteNonQuery("insert into NhanVien (name, NgaySinh, GioiTinh, DiaChi, SoDienThoai, CMND, ChucVu, CaLamViec) values (N'" + txtHoTen.Text + "', N'" + dateTimeNgaySinh.Value.ToString("yyyy.MM.dd") + "', N'" + cbbGioiTinh.Text + "', N'" + txtDiaChi.Text + "', N'" + txtSDT.Text + "', N'" + txtCMND.Text + "', N'" + cbbChucVu.Text + "', N'" + cbbCalamViec.Text + "')");

                if(result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thống Báo");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thống Báo");
                }
            }
            else
            {
                int result = DataProvider.Instance.ExecuteNonQuery("update NhanVien set name = N'" + txtHoTen.Text + "', NgaySinh = N'" + dateTimeNgaySinh.Value.ToString("yyyy.MM.dd") + "', GioiTinh = N'" + cbbGioiTinh.Text + "', DiaChi = N'" + txtDiaChi.Text + "', SoDienThoai = N'" + txtSDT.Text + "', CMND = N'" + txtCMND.Text + "', ChucVu = N'" + cbbChucVu.Text + "', CaLamViec = N'" + cbbCalamViec.Text + "' where id = '"+ ID +"'");

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thống Báo");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại", "Thống Báo");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtHoTen.Text + "?", "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("delete from NhanVien where id = '" + ID + "'");

                if(kq > 0)
                {
                    MessageBox.Show("Xóa thành công nhân viên " + txtHoTen.Text, "Thống Báo");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên " + txtHoTen.Text + " thất bại", "Thống Báo");
                }
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }

        private void txtTimKiemNV_Click(object sender, EventArgs e)
        {
            if (txtTimKiemNV.Text == "Tìm kiếm theo mã nhân viên")
            {
                txtTimKiemNV.Text = "";
                txtTimKiemNV.SelectAll();
            }
        }

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                btnLamMoi.Enabled = true;
                btnThemSua.Text = "Thêm";
                btnXoa.Enabled = false;

                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";

                DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhanVien where id = " + txtTimKiemNV.Text);
                dtgNhanVien.DataSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo");
            }
            

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel obj = new ExportExcel();
                obj.WriteDataTableToExcel(data, "Nhân Viên", folderBrowserDialog.SelectedPath + "\\" + "nhanVien.xlsx", "");


                MessageBox.Show("Xuất file nhân viên thành công!", "Thông Báo");
            }
        }
    }
}
