﻿using QuanLyNhaHang.DAO;
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
                flpTable.Controls.Add(btn);
            }
        }

    }
}
