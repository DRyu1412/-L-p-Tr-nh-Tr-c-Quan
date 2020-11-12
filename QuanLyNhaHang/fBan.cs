using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
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

namespace QuanLyNhaHang
{
    public partial class fBan : Form
    {
        public fBan()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();
            
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBox_Category.DataSource = listCategory;
            comboBox_Category.DisplayMember = "TenLoai";

        }

        void LoadFoodByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBox_Food.DataSource = listFood;
            comboBox_Food.DisplayMember = "TenMon";
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
            listView_Bill.Items.Clear();

            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTableID(id);
            int TongTien = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                TongTien += item.ThanhTien;

                listView_Bill.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            textBox_TotalPrice.Text = TongTien.ToString("c", culture);
        }


        void btn_Click (object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).IDBan;
            listView_Bill.Tag = (sender as Button).Tag;
            ShowBill(TableID);
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.IdLoaiMonAn;

            LoadFoodByCategoryID(id);
           
        }

        private void iconButton_AddFood_Click(object sender, EventArgs e)
        {
            Table table = listView_Bill.Tag as Table;

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.IDBan);
            int idFood = (comboBox_Food.SelectedItem as Food).IdMonAn;
            int count = (int)num_FoodCount.Value;


            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.IDBan);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }

            ShowBill(table.IDBan);
        }
    }
}
