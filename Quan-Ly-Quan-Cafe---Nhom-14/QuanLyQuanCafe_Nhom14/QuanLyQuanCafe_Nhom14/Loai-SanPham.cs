using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class Loai_SanPham : UserControl
    {

        SqlConnection connnection;
        SqlCommand command;
        String str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Loai_SanPham()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            command = connnection.CreateCommand();
            command.CommandText = "SELECT * from dbo.FoodCategory";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvMain.DataSource = table;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "insert into dbo.FoodCategory values(N'" + txtName.Text + "', N'" + cbActive.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void Loai_SanPham_Load(object sender, EventArgs e)
        {
            connnection = new SqlConnection(str);
            connnection.Open();
            loadData();
        }

        private void dtgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvMain.CurrentRow.Index;
            txtName.Text = dtgvMain.Rows[i].Cells[1].Value.ToString();
            cbActive.Text = dtgvMain.Rows[i].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            command = connnection.CreateCommand();
            command.CommandText = "update dbo.FoodCategory set active = N'" + cbActive.Text + "' where name = '" + txtName.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            cbActive.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "delete from dbo.FoodCategory where name = N'" + txtName.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
