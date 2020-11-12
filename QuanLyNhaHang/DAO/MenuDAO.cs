using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set => instance = value;
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTableID(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query= " select TenMon, SoLuong, gia, gia*SoLuong as ThanhTien " +
                             "from CTHD, HoaDon, MonAn " +
                             "where CTHD.idHoaDon = HoaDon.idHoaDon " +
                             "and CTHD.idMonAn = MonAn.idMonAn " +
                             "and HoaDon.idBan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);

            }

            return listMenu;
        }
    }
}
