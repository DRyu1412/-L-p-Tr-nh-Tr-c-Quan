using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Bill
    {
        public Bill(int id, int status, DateTime? DayCheckOut )
        {
            this.IdHoaDon = id;
            this.TinhTrang = status;
            this.NgayThanhToan = DayCheckOut;
        }

        public Bill(DataRow row)
        {
            this.IdHoaDon = (int)row["idHoaDon"];
            this.TinhTrang = (int)row["TinhTrang"];

            var dateCheckOutTemp = row["NgayThanhToan"];
            if (dateCheckOutTemp.ToString() != "")  
                this.NgayThanhToan = (DateTime?)dateCheckOutTemp;
        }

        private int idHoaDon;
        private int tinhTrang;
        private DateTime? ngayThanhToan;


        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public DateTime? NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
    }
}
