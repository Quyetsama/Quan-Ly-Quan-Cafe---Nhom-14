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

namespace QuanLyQuanCafe_Nhom14.DAO
{
    public partial class QuanLy_SanPham : UserControl
    {
        SqlConnection connnection;
        SqlCommand command;
        String str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
        command = connnection.CreateCommand();
        command.CommandText = "SELECT * from dbo.Food";
        adapter.SelectCommand = command;
        table.Clear();
        adapter.Fill(table);
        dtgvDisplay.DataSource = table;
        }

        void loadComboBox()
        {
            connnection = new SqlConnection(str);
            DataTable dt = new DataTable();
            connnection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select id from dbo.FoodCategory", connnection);
                da.Fill(dt);
                connnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("error " + ex.ToString());
            }

            try
            {
                cbNumber.DataSource = dt;
                cbNumber.DisplayMember = "name";
                cbNumber.ValueMember = "id";
                cbNumber.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }



        public QuanLy_SanPham()
        {
            InitializeComponent();

            loadComboBox();
        }

        private void QuanLy_SanPham_Load(object sender, EventArgs e)
        {
            connnection = new SqlConnection(str);
            connnection.Open();
            loadData();
        }

        private void dtgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtName.ReadOnly = true;
            int i;
            i = dtgvDisplay.CurrentRow.Index;
            txtName.Text = dtgvDisplay.Rows[i].Cells[1].Value.ToString();
            cbNumber.Text = dtgvDisplay.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dtgvDisplay.Rows[i].Cells[3].Value.ToString();
            txtDiscount.Text = dtgvDisplay.Rows[i].Cells[4].Value.ToString();

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "insert into dbo.Food values(N'" + txtName.Text + "', '" + cbNumber.Text + "', " + txtPrice.Text + ", " + txtDiscount.Text + ")";
            command.ExecuteNonQuery();
            loadData();
        }


        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "update dbo.Food set idCategory = '" + cbNumber.Text + "', price = '" + txtPrice.Text + "', discount = '" + txtDiscount.Text + "' where name = '" + txtName.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnResetFood_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            cbNumber.ResetText();
            txtPrice.ResetText();
            txtDiscount.ResetText();
        }

        private void btnDeleteGia_Click(object sender, EventArgs e)
        {
                command = connnection.CreateCommand();
                command.CommandText = "delete from dbo.Food where price = N'" + txtDeletePrice.Text + "'";
                command.ExecuteNonQuery();
                loadData();
        }

        private void btnDeleteTen_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "delete from dbo.Food where name = N'" + txtDeleteName.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnResetDelete_Click(object sender, EventArgs e)
        {
            txtDeletePrice.ResetText();
            txtDeleteName.ResetText();
        }

        private void btnIDFoodSearch_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "select * from dbo.Food where idCategory = N'" + txtIDFoodSearch.Text + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dtgvSearch.DataSource = table;
        }

        private void btnPriceMax_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "select * from dbo.Food where price = (select max(price) from dbo.Food)";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dtgvSearch.DataSource = table;
        }

        private void btnPriceMin_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "select * from dbo.Food where price = (select min(price) from dbo.Food)";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dtgvSearch.DataSource = table;
        }

        private void btnPriceSearch_Click(object sender, EventArgs e)
        {
            command = connnection.CreateCommand();
            command.CommandText = "select * from dbo.Food where price >= '" + txtPrice1.Text + "' and price <= '" + txtPrice2.Text +"'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dtgvSearch.DataSource = table;
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtPrice1.ResetText();
            txtPrice2.ResetText();
            txtIDFoodSearch.ResetText();
        }

    }
}
