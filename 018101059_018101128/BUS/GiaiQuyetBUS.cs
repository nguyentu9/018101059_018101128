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
    class GiaiQuyetBUS
    {
        public static DataTable ThongTin_GQ()
        {
            return GiaiQuyetDAO.ThongTin_GQ();
        }
        public static void Them(GiaiQuyetDTO gq)
        {
            try
            {
                GiaiQuyetDAO.Them(gq);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm giải quyết thất bại");
            }
        }
        public static void Capnhat(GiaiQuyetDTO gq)
        {
            try
            {
                GiaiQuyetDAO.Capnhat(gq);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật giải quyết thất bại");
            }
        }
        public static void Xoa(GiaiQuyetDTO gq)
        {
            try
            {
                GiaiQuyetDAO.Xoa(gq);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá giải quyết thất bại");
            }
        }
    }
}
