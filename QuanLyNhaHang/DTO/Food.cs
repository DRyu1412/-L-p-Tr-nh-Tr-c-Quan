using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Food
    {
        public Food(int id, string name, int price, int idCategory)
        {
            this.IdMonAn = id;
            this.TenMon = name;
            this.Gia = price;
            this.IdLoaiMonAn = idCategory;
        }

        public Food(DataRow row)
        {
            this.idMonAn = (int)row["idMonAn"];
            this.TenMon = row["TenMon"].ToString();
            this.Gia = int.Parse(row["gia"].ToString());
            this.IdLoaiMonAn = (int)row["idLoaiMonAn"];
        }

        private int idMonAn;
        private string tenMon;
        private int gia;
        private int idLoaiMonAn;

        public int IdMonAn { get => idMonAn; set => idMonAn = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int Gia { get => gia; set => gia = value; }
        public int IdLoaiMonAn { get => idLoaiMonAn; set => idLoaiMonAn = value; }
    }
}
