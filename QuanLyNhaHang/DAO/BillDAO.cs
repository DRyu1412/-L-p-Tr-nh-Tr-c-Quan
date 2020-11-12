using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            set => instance = value; 
        }
        private BillDAO() { }

        public int GetUnCheckBillIDByTableID (int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HoaDon where idBan = " + id + " and TinhTrang = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IdHoaDon;
            }
            return -1;
        }
        
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_InsertBill @idBan", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScarlar("select MAX(idHoaDon) from HoaDon");
        }

    }
}
