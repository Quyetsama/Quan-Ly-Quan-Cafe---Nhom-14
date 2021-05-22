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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            quanLyBanHang1.BringToFront();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            lblDisplayName.Text = Login.disPlayName + " - " + Login.Type;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            quanLyBanHang1.BringToFront();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            baoCao_ThongKe1.BringToFront();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login fLogin = new Login();
            fLogin.Show();
        }
    }
}
