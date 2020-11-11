using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.IDBan = id;
            this.TenBan = name;
            this.TrangThai = status;
        }

        public Table(DataRow row)
        {
            this.IDBan = (int)row["idBan"];
            this.TenBan = row["TenBan"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        private int iDBan;
        private string tenBan;
        private string trangThai;

        public int IDBan { get => iDBan; set => iDBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
