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
using System.Windows.Forms.VisualStyles;

namespace QuanLyNhaHang
{
    public partial class fThucDon : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True;MultipleActiveResultSets=True");
        SqlDataReader reader, readerID;
        SqlCommand com, comID;
        string tenmon, gia, dvt;
        int id;
        BindingSource bs = new BindingSource();
        public fThucDon()
        {
            InitializeComponent();
            if (con.State == ConnectionState.Closed) con.Open();
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select tenmon 'Tên món', gia 'Giá', dvt 'Đơn vị tính' from thucdon";
            reader = com.ExecuteReader();
            comID = new SqlCommand();
            comID.Connection = con;
            comID.CommandText = "select id from thucdon";
            readerID = comID.ExecuteReader();
            reader.Read();
            readerID.Read();
            
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
            }
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
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (fThemMon fTM = new fThemMon(1))
            {
                fTM.ShowDialog();
                this.OnLoad(e);
                tenmon = dataGridView1.SelectedRows[1].Index.ToString();//(string)reader[0];
                gia = dataGridView1.SelectedRows[1].Index.ToString();// (string)reader[1];
                dvt = dataGridView1.SelectedRows[1].Index.ToString();// (string)reader[2];
                id = int.Parse(dataGridView1.SelectedRows[1].Index.ToString()); //(int)readerID[0];
            }
        }

        private void fThucDon_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select tenmon 'Tên món', gia 'Giá', dvt 'Đơn vị tính' from thucdon";
            reader = com.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
            }
        }
        public string TenMon
        {
            get { return tenmon; }
        }
        public string Gia
        {
            get { return gia; }
        }
        public string DVT
        {
            get { return dvt; }
        }
        public string ID
        {
            get { return id + ""; }
        }
    }
}
