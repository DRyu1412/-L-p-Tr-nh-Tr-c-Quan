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

namespace QuanLyNhaHang
{
    public partial class fLogin : Form
    {
        public static string tenChuTaiKhoan;
        public fLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                string connectionString = @"Data Source=DESKTOP-07V1CVG\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;User ID=uit_lttq;Password=123456789";
                SqlConnection con = new SqlConnection(connectionString);
                string query = "select tendangnhap, matkhau, hoten from taikhoan where tendangnhap = '" + txtUser.Text + "'";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Sai Tên đăng nhập hoặc Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            string username = reader.GetString(0);
                            string password = reader.GetString(1);
                            tenChuTaiKhoan = reader.GetString(2);
                            if (username.Equals(txtUser.Text) && password.Equals(txtPass.Text))
                            {
                                this.Hide();
                                fHome fH = new fHome();
                                fH.Show();
                            }
                            else
                            {
                                MessageBox.Show("Sai Tên đăng nhập hoặc Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                con.Close();
                command.Dispose();
            }
        }
        private bool isFormValid()
        {
            if (txtPass.Text == string.Empty || txtUser.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ username và password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }
    }
}
