using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
namespace _018101059_018101128.BUS
{
    class NhaccBUS
    {
        public static DataTable TT_Nhacc()
        {
            return NhaccDAO.TT_Nhacc();
        }
        public static void Them(NhaccDTO nhacc)
        {
            try
            {
                NhaccDAO.Them(nhacc);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        public static void Capnhat(NhaccDTO nhacc)
        {
            try
            {
                NhaccDAO.Capnhat(nhacc);

            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        public static void Xoa(NhaccDTO nhacc)
        {
            try
            {
                NhaccDAO.Xoa(nhacc);

            }
            catch (Exception)
            {
                MessageBox.Show("Xoá không thành công");
            }
        }
    }
}
