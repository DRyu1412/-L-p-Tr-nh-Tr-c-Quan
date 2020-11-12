using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Menu
    {
        public Menu(string foodname, int count, int price, int totalprice = 0)
        {
            this.TenMon = foodname;
            this.SoLuong = count;
            this.Gia = price;
            this.ThanhTien = totalprice; 
        }
        public Menu(DataRow row)
        {
            this.TenMon = row["TenMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.Gia = int.Parse(row["gia"].ToString());
            this.ThanhTien = int.Parse(row["ThanhTien"].ToString());
        }


        private string tenMon;
        private int soLuong;
        private int gia;
        private int thanhTien;

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
