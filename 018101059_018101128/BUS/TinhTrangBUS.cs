using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using _018101059_018101128.DTO;
using _018101059_018101128.DAO;
namespace _018101059_018101128.BUS
{
    class TinhTrangBUS
    {
        public static DataTable ThongTin_TT()
        {
            return TinhTrangDAO.ThongTin_TT();
        }
        public static void Them(TinhTrangDTO t)
        {
            try
            {
                TinhTrangDAO.Them(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm tình trạng thất bại");
            }
        }
        public static void Capnhat(TinhTrangDTO t)
        {
            try
            {
                TinhTrangDAO.Capnhat(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật tình trạng thất bại");
            }
        }
        public static void Xoa(TinhTrangDTO t)
        {
            try
            {
                TinhTrangDAO.Xoa(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá tình trạng thất bại");
            }
        }
    }
}
