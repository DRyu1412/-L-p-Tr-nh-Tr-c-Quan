using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace QuanLyNhaHang
{
    public partial class fThemMon : Form
    {
        string tenmon, gia, dvt, id;
        int pos;
        public fThemMon(int tmp = 0)
        {
            InitializeComponent();
            pos = tmp;
            if (tmp == 0) labelTitle.Text = "Thêm món ăn";
            else if (tmp == 1)
            {
                labelTitle.Text = "Sửa món ăn";
                id = fThucDon.ID;
                tenmon = fThucDon.TenMon;
                gia = fThucDon.Gia;
                dvt = fThucDon.DVT;
                textBox1.Text = tenmon;
                textBox2.Text = gia;
                textBox3.Text = dvt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                if (isFormValid())
                    insertValues();
            }
            else if (pos == 1)
            {
                if (isFormValid())
                    updateValues();
            }
        }
        private string getUpper(string name)
        {
            string tmp = name.Substring(0, 1);
            string tmp2 = name.Substring(1, name.Length - 1);
            tmp = tmp.ToUpper();
            return tmp + tmp2;
        }
        private void updateValues()
        {
            DialogResult dR = MessageBox.Show("Bạn có muốn sửa món ăn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.Yes)
            {
                string tenmon, gia, dvt;
                tenmon = getUpper(textBox1.Text);
                gia = getUpper(textBox2.Text);
                dvt = getUpper(textBox3.Text);
                string connectionString = @"Data Source=DESKTOP-07V1CVG\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;User ID=uit_lttq;Password=123456789";
                SqlConnection con = new SqlConnection(connectionString);
                string sql = "update thucdon set tenmon = '" + tenmon + "', dvt = '" + dvt + "', gia = '" + gia + "' where id = " + id;
                SqlCommand command = new SqlCommand(sql, con);
                if (con.State != ConnectionState.Open) con.Open();
                command.ExecuteNonQuery();
                con.Close();
                this.Dispose();
            }
        }
        private void insertValues()
        {
            DialogResult dR = MessageBox.Show("Bạn có muốn thêm món ăn này vào danh sách không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.Yes)
            {
                string tenmon, gia, dvt;
                tenmon = getUpper(textBox1.Text);
                gia = getUpper(textBox2.Text);
                dvt = getUpper(textBox3.Text);
                string connectionString = @"Data Source=DESKTOP-07V1CVG\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;User ID=uit_lttq;Password=123456789";
                SqlConnection con = new SqlConnection(connectionString);
                string sql = "insert into thucdon values (N'" + tenmon + "'," + gia + ", N'" + dvt + "')";
                SqlCommand command = new SqlCommand(sql, con);
                if (con.State != ConnectionState.Open) con.Open();
                command.ExecuteNonQuery();
                con.Close();
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
            if (textBox1.Text.Trim() == string.Empty
                || textBox2.Text.Trim() == string.Empty
                || textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ nội dung món ăn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
