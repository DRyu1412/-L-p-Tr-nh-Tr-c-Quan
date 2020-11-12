using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class fBan : Form
    {
        public fBan()
        {
            InitializeComponent();

            LoadTable();
        }

        void LoadTable()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TenBan + "\n" + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(idBill);

        }


        void btn_Click (object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).IDBan;
            ShowBill(TableID);
        }
    }
}
