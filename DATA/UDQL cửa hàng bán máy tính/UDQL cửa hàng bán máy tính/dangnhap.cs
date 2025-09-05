using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDQL_cửa_hàng_bán_máy_tính
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string taikhoan = txt_Taikhoan.Text;
            string matkhau = txt_Matkhau.Text;
            if (taikhoan == "admin" && matkhau == "123")
            {
                MessageBox.Show("Đăng nhập thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đăng ký đang được phát triển.", "Thông báo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txt_Matkhau.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để lấy lại mật khẩu.", "Quên mật khẩu");
        }

        

    }
}
