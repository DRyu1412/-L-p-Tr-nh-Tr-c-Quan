using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Collections;

namespace QuanLyNhaHang
{
    public partial class fThucDon : Form
    {
        public static string TenMon, Gia, DVT, ID;
        ArrayList mangID = new ArrayList();
        public fThucDon()
        {
            InitializeComponent();
            SetListView();
            FillListView();
        }
        public void FillListView()
        {
            string connectionString = @"Data Source=DESKTOP-07V1CVG\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;User ID=uit_lttq;Password=123456789";
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from thucdon";
            SqlCommand command = new SqlCommand(query, con);
            if (con.State == ConnectionState.Closed) con.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {                         
                        string stt = (i + 1) + "";
                        int id = reader.GetInt32(0);
                        mangID.Add(id);
                        string tenmon = reader.GetString(1);
                        string gia = reader.GetString(2);
                        string dvt = reader.GetString(3);
                        string[] tmp = {stt, tenmon, dvt, gia};
                        i++;
                        ListViewItem temp = new ListViewItem(tmp);
                        listView1.Items.Add(temp);
                    }
                }
                else listView1.Clear();
            }
            con.Close();
        }
        private void SetListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            listView1.Columns.Add("STT", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Tên món ăn", 500, HorizontalAlignment.Center);
            listView1.Columns.Add("Đơn vị tính", 250, HorizontalAlignment.Center);
            listView1.Columns.Add("Giá", 300, HorizontalAlignment.Center);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (fThemMon fTM = new fThemMon(0))
            {
                fTM.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            ID = mangID[int.Parse(item.SubItems[0].Text) - 1]+"";
            TenMon = item.SubItems[1].Text;
            DVT = item.SubItems[2].Text;
            Gia = item.SubItems[3].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (fThemMon fTM = new fThemMon(1))
            {
                fTM.ShowDialog();
                this.OnLoad(e);
            }
        }
        private void fThucDon_Load(object sender, EventArgs e)
        {
            SetListView();
            FillListView();
            listView1.Refresh();
        }
    }
}
