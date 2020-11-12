using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.IdLoaiMonAn = id;
            this.TenLoai = name;
        }
        public Category(DataRow row)
        {
            this.IdLoaiMonAn = (int)row["idLoaiMonAn"];
            this.TenLoai = row["TenLoai"].ToString();
        }

        private int idLoaiMonAn;
        private string tenLoai;

        public int IdLoaiMonAn { get => idLoaiMonAn; set => idLoaiMonAn = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
