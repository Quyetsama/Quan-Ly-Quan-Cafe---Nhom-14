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
    public partial class QuanLyban : UserControl
    {

        string ID;

        DataTable dataExcel;
        public QuanLyban()
        {
            InitializeComponent();
        }

        private void QuanLyban_Load(object sender, EventArgs e)
        {

            LoadPosition();
            LoadTable();
        }

        private void LoadTable()
        {
            btnThemSua.Text = "Thêm";
            btnLamMoi.Enabled = false;

            txtTenTable.Text = "";
            txtTenTable.Focus();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood where id != 19");
            dtgTable.DataSource = data;

            dataExcel = data;
        }

        void LoadPosition()
        {

            List<String> listTable = new List<String>();
            List<String> listTable1 = new List<String>();

            listTable.Add("Không sử dụng");
            listTable1.Add("Không sử dụng");

            string query = "select distinct position from TableFood where position != N'NULL'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                if(row["position"].ToString() == "Không sử dụng")
                {
                    continue;
                }
                listTable.Add(row["position"].ToString());
                listTable1.Add(row["position"].ToString());

            }

            cbbTKTable.DataSource = listTable;
            cbbTKTable.SelectedIndex = 0;
            cbbpositionTable.DataSource = listTable1;
            cbbpositionTable.SelectedIndex = 0;


        }

        private void dtgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemSua.Text = "Sửa";
            btnLamMoi.Enabled = true;


            //Luu id
            ID = dtgTable.Rows[e.RowIndex].Cells["idTable"].Value.ToString();

            txtTenTable.Text = dtgTable.Rows[e.RowIndex].Cells["nameTable"].Value.ToString();

            string viTri = dtgTable.Rows[e.RowIndex].Cells["positionTable"].Value.ToString();
            cbbpositionTable.BorderRadius = 12;
            cbbpositionTable.Text = viTri;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtTenTable.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thống Báo");
                return;
            }


            if (btnThemSua.Text == "Thêm")
            {


                int result = DataProvider.Instance.ExecuteNonQuery("insert into TableFood (name, status, position) values (N'" + txtTenTable.Text + "',N'Trống', N'"+ cbbpositionTable.Text +"')");

                if (result > 0)
                {
                    MessageBox.Show("Thêm bàn thành công", "Thống Báo");
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Thêm bàn thất bại", "Thống Báo");
                }
            }
            else
            {
                int result = DataProvider.Instance.ExecuteNonQuery("update TableFood set name = N'" + txtTenTable.Text + "', position = N'" + cbbpositionTable.Text + "' where id = '" + ID + "'");

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật bàn thành công", "Thống Báo");
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Cập nhật bàn thất bại", "Thống Báo");
                }
            }
        }

        private void cbbTKTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood where position = N'" + cbbTKTable.Text + "'");
            dtgTable.DataSource = data;

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
                obj.WriteDataTableToExcel(dataExcel, "Danh sách bàn", folderBrowserDialog.SelectedPath + "\\" + "Table.xlsx", "");


                MessageBox.Show("Xuất file bàn thành công!", "Thông Báo");
            }
        }
    }
}