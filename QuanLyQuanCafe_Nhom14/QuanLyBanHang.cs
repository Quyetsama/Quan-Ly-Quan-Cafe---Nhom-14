using QuanLyQuanCafe_Nhom14.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class QuanLyBanHang : UserControl
    {

        public static int IDTable = 0;
        public static string IDFOOD = "";
        public static float TongTienThanhToan = 0;

        public QuanLyBanHang()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {

        }

        void LoadCategory()
        {
            // Lay danh sach loai san pham
            List<Category> listCategory = new List<Category>();

            string queryCategory = "select * from FoodCategory";

            DataTable dataCategory = DataProvider.Instance.ExecuteQuery(queryCategory);

            foreach (DataRow row in dataCategory.Rows)
            {
                Category category = new Category(row);
                listCategory.Add(category);
            }

            cbbLoaiSanPham.DataSource = listCategory;
            cbbLoaiSanPham.DisplayMember = "name";

        }


        void LoadFoodListByCategoryID(int id)
        {
            // Lay danh sach san pham theo loia san pham
            List<Food> listFood = new List<Food>();

            string queryFood = "select * from Food where idCategory = " + id;

            DataTable dataFood = DataProvider.Instance.ExecuteQuery(queryFood);

            foreach (DataRow row in dataFood.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }


            datagridFood.DataSource = dataFood;
            datagridFood.Columns["idCategory"].Visible = false;

        }


        public void LoadTable()
        {
            lvTable.Items.Clear();

            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetTableList");


            this.lvTable.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(120, 120);
            this.lvTable.LargeImageList = this.imageList1;


            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tablelist.Add(table);
                if (table.ID == 19)
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(table.Name.ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, table.ID.ToString());
                ListViewItem status = new ListViewItem(table.Status.ToString());

                if (status.Text.ToString() == "Trống")
                {
                    item.SubItems.Add(subitem);
                    lvTable.Items.Add(item);
                    item.ImageIndex = 1;
                }
                else
                {
                    item.SubItems.Add(subitem);
                    lvTable.Items.Add(item);
                    item.ImageIndex = 0;
                }


                //Button btn = new Button() { Width = 80, Height = 80 };
                //btn.Text = table.Name + Environment.NewLine + table.Status;

                //if (table.Status == "Trống")
                //{
                //    btn.BackColor = Color.Aqua;
                //}
                //else
                //{
                //    btn.BackColor = Color.LightPink;
                //}

                //flpTable.Controls.Add(btn);
            }
        }

        public void showBill(int id)
        {
            lvBill.Items.Clear();
            List<BillInfo> listBillInfo = new List<BillInfo>();
            //label1.Text = billID.ToString();

            string query = "select f.id, f.name, bi.count, f.price, (f.price*bi.count*(100-f.discount))/100 as totalPrice, f.discount from Bill as b, BillInfo as bi, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable dataBillInfo = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataBillInfo.Rows)
            {
                BillInfo info = new BillInfo(row);
                listBillInfo.Add(info);
            }


            float totalPrice = 0;

            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.NameFood.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Discount.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());



                lvItem.SubItems.Add(item.IdFood.ToString());





                totalPrice += item.TotalPrice;

                lvBill.Items.Add(lvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);

            TongTienThanhToan = totalPrice;



            //DataTable dataBillInfo = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill = " + billID);

            //foreach (DataRow row in dataBillInfo.Rows)
            //{
            //    BillInfo info = new BillInfo(row);
            //    listBillInfo.Add(info);
            //}


            //foreach (BillInfo item in listBillInfo)
            //{
            //    ListViewItem lvItem = new ListViewItem(item.IdFood.ToString());
            //    lvItem.SubItems.Add(item.Count.ToString());

            //    lvBill.Items.Add(lvItem);
            //}

        }


        //private void lvBill_Click(object sender, EventArgs e)
        //{
        //    string a = lvBill.SelectedItems[0].SubItems[0].Text;
        //    string b = lvBill.SelectedItems[0].SubItems[5].Text;
        //    txtFood.Text = a;
        //    IDFOOD = b;
        //}

        //private void lvTable_Click(object sender, EventArgs e)
        //{
        //    string a = lvTable.SelectedItems[0].SubItems[1].Text;
        //    //label1.Text = a.ToString();
        //    showBill(Int32.Parse(a));

        //    IDTable = Int32.Parse(a);
        //    //label5.Text = IDTable.ToString();

        //    //label5.Text = lvBill.SelectedItems[0].SubItems[5].Text.ToString();
        //}
        //private void cbbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int id = 0;

        //    ComboBox cb = sender as ComboBox;

        //    if (cb.SelectedItem == null)
        //    {
        //        return;
        //    }


        //    Category selected = cb.SelectedItem as Category;

        //    id = selected.ID;

        //    LoadFoodListByCategoryID(id);
        //}

        //private void datagridFood_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //if(datagridFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    //{
        //    //    datagridFood.CurrentRow.Selected = true;
        //    //    txtFood.Text = datagridFood.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
        //    //}

        //    try
        //    {
        //        datagridFood.CurrentRow.Selected = true;
        //        txtFood.Text = datagridFood.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

        //        // luu id food
        //        IDFOOD = datagridFood.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //private void btnThemMon_Click(object sender, EventArgs e)
        //{

        //    if (IDTable == 0 || txtFood.Text == "")
        //    {
        //        return;
        //    }

        //    // get bill chưa thanh toan
        //    DataTable dataBill = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + IDTable + "and status = 0");

        //    int billID = -1;

        //    if (dataBill.Rows.Count > 0)
        //    {
        //        Bill bill = new Bill(dataBill.Rows[0]);
        //        billID = bill.ID;


        //    }

        //    string idFood = IDFOOD;
        //    int count = (int)numericUpDown1.Value;

        //    // neu billID = -1, nghia la ban do chua co bill va phai them bill moi
        //    if (billID == -1)
        //    {
        //        // Insert Bill
        //        DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { IDTable });
        //        //label5.Text = IDTable.ToString();
        //        //lay id cuoi cung de insert billinfo
        //        int idBill = (int)DataProvider.Instance.ExecuteScalar("SELECT TOP 1 * FROM Bill ORDER BY id DESC");


        //        // Insert BillInfo
        //        DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count , @idTable", new object[] { idBill, idFood, count, IDTable });
        //        LoadTable();

        //    }
        //    else
        //    {
        //        DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count , @idTable", new object[] { billID, idFood, count, IDTable });

        //    }



        //    showBill(IDTable);
        //    // check so luong trong bill sau khi load lai bill de load lai table
        //    if (lvBill.Items.Count == 0)
        //    {
        //        //neu bill trong thi set ban = trong
        //        DataProvider.Instance.ExecuteNonQuery("update TableFood set status = N'Trống' where id = " + IDTable);
        //        LoadTable();
        //    }

        //}

        //private void btnThanhToan_Click(object sender, EventArgs e)
        //{

        //    if (lvBill.Items.Count == 0)
        //    {
        //        return;
        //    }

        //    DataTable dataBill = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + IDTable + "and status = 0");



        //    if (dataBill.Rows.Count > 0)
        //    {
        //        Bill bill = new Bill(dataBill.Rows[0]);
        //        DataProvider.Instance.ExecuteNonQuery("exec USP_ThanhToan @idTable , @idBill , @dateCheckOut , @totalPrice", new object[] { IDTable, bill.ID, DateTime.Now.ToString("yyyy.MM.dd"), TongTienThanhToan });
        //        showBill(IDTable);
        //        LoadTable();
        //    }


        //}

        private void cbbLoaiSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }


            Category selected = cb.SelectedItem as Category;

            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void lvTable_Click_1(object sender, EventArgs e)
        {
            string a = lvTable.SelectedItems[0].SubItems[1].Text;
            //label1.Text = a.ToString();
            showBill(Int32.Parse(a));

            IDTable = Int32.Parse(a);
            //label5.Text = IDTable.ToString();

            //label5.Text = lvBill.SelectedItems[0].SubItems[5].Text.ToString();

            numericUpDown1.Value = 1;

            label7.Text = lvTable.SelectedItems[0].SubItems[0].Text.ToString();

        }

        private void lvBill_Click_1(object sender, EventArgs e)
        {
            string a = lvBill.SelectedItems[0].SubItems[0].Text;
            string b = lvBill.SelectedItems[0].SubItems[5].Text;
            txtFood.Text = a;
            IDFOOD = b;

            numericUpDown1.Value = 1;
        }

        private void datagridFood_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                datagridFood.CurrentRow.Selected = true;
                txtFood.Text = datagridFood.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

                // luu id food
                IDFOOD = datagridFood.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();

                numericUpDown1.Value = 1;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnThemMon_Click_1(object sender, EventArgs e)
        {
            if (IDTable == 0 || txtFood.Text == "")
            {
                return;
            }

            // get bill chưa thanh toan
            DataTable dataBill = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + IDTable + "and status = 0");

            int billID = -1;

            if (dataBill.Rows.Count > 0)
            {
                Bill bill = new Bill(dataBill.Rows[0]);
                billID = bill.ID;


            }


            string idFood = IDFOOD;
            int count = (int)numericUpDown1.Value;

            // neu billID = -1, nghia la ban do chua co bill va phai them bill moi
            if (billID == -1)
            {

                if(count <= 0)
                {
                    return;
                }

                // Insert Bill
                DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { IDTable });
                //label5.Text = IDTable.ToString();
                //lay id cuoi cung de insert billinfo
                int idBill = (int)DataProvider.Instance.ExecuteScalar("SELECT TOP 1 * FROM Bill ORDER BY id DESC");


                // Insert BillInfo
                DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count , @idTable", new object[] { idBill, idFood, count, IDTable });
                LoadTable();

            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count , @idTable", new object[] { billID, idFood, count, IDTable });

            }



            showBill(IDTable);
            // check so luong trong bill sau khi load lai bill de load lai table
            if (lvBill.Items.Count == 0)
            {
                //neu bill trong thi set ban = trong
                DataProvider.Instance.ExecuteNonQuery("update TableFood set status = N'Trống' where id = " + IDTable);
                LoadTable();
            }
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (lvBill.Items.Count == 0)
            {
                return;
            }

            ThanhToan fThanhToan = new ThanhToan();
            fThanhToan.txtTienPhaiThanhToan.Text = TongTienThanhToan.ToString();
            fThanhToan.ShowDialog();

            //DataTable dataBill = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + IDTable + "and status = 0");



            //if (dataBill.Rows.Count > 0)
            //{
            //    Bill bill = new Bill(dataBill.Rows[0]);
            //    DataProvider.Instance.ExecuteNonQuery("exec USP_ThanhToan @idTable , @idBill , @dateCheckOut , @totalPrice", new object[] { IDTable, bill.ID, DateTime.Now.ToString("yyyy.MM.dd"), TongTienThanhToan });
            showBill(IDTable);
            LoadTable();
            //}
        }


        //Tim kiem
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<Food> listFood = new List<Food>();

            string query = string.Format("select * from Food where name like N'%{0}%'", txtSearch.Text);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }
            datagridFood.DataSource = data;
            datagridFood.Columns["idCategory"].Visible = false;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            IDTable = 19;

            showBill(19);

            numericUpDown1.Value = 1;
            label7.Text = "Mang Về";
        }



        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.SelectAll();
        }
    }
}
