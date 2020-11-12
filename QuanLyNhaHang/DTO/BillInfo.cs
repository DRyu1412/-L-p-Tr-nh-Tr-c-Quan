using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{

    public class BillInfo
    {

        public BillInfo(int id, int idBill, int idFood, int count)
        {
            this.IdCTHD = id;
            this.IdHoaDon = idBill;
            this.IdMonAn = idFood;
            this.SoLuong = count;
        }

        public BillInfo(DataRow row)
        {
            this.IdCTHD = (int)row["idCTHD"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdMonAn = (int)row["idMonAn"];
            this.SoLuong = (int)row["SoLuong"];
        }


        private int idCTHD;
        private int idHoaDon;
        private int idMonAn;
        private int soLuong;

        public int IdCTHD { get => idCTHD; set => idCTHD = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdMonAn { get => idMonAn; set => idMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
