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
    public partial class Login : Form
    {

        public static string disPlayName = "";
        public static string Type = "";
        public static int idAccount = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public bool CheckLogin(string username, string password)
        {
            string query = "exec USP_Login @userName , @passWord"; //split ' '
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            if(result.Rows.Count > 0)
            {
                disPlayName = result.Rows[0]["DisplayName"].ToString();
                Type = result.Rows[0]["Type"].ToString();

                if(Type == "1")
                {
                    Type = "Quản lý";
                }
                else if(Type == "0")
                {
                    Type = "Nhân viên";
                }
            }
           
            return result.Rows.Count > 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtUserName.Text, txtPassWord.Text))
            {
                this.Hide();
                Main fMain = new Main();
                fMain.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
