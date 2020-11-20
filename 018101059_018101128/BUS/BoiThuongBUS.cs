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
    class BoiThuongBUS
    {

        public static DataTable Load_TinhTrang()
        {
            return BoiThuongDAO.Load_TinhTrang();
        }
        public static DataTable Load_NhanVien()
        {
            return BoiThuongDAO.Load_NhanVien();
        }
        public static DataTable Load_SinhVien()
        {
            return BoiThuongDAO.Load_SinhVien();
        }
        public static DataTable Load_GiaiQuyet()
        {
            return BoiThuongDAO.Load_GiaiQuyet();
        }
        public static DataTable ThongTin_BT()
        {
            return BoiThuongDAO.ThongTin_BT();
        }

        public static void Them(BoiThuongDTO b)
        {
            try
            {
                BoiThuongDAO.Them(b);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public static void Capnhat(BoiThuongDTO b)
        {
            try
            {
                BoiThuongDAO.Capnhat(b);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        public static void Xoa(BoiThuongDTO b)
        {
            try
            {
                BoiThuongDAO.Xoa(b);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá thất bại");
            }
        }
    }
}
