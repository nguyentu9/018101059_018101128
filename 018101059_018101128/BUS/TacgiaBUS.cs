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
    class TacgiaBUS
    {
        public static DataTable TT_Tacgia()
        {
            return TacgiaDAO.TT_Tacgia();
        }
        public static void Them(TacgiaDTO tacgia)
        {
            try
            {
                TacgiaDAO.Them(tacgia);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm tác giả thất bại");
            }
        }
        public static void Capnhat(TacgiaDTO tacgia)
        {
            try
            {
                TacgiaDAO.Capnhat(tacgia);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật tác giả thất bại");
            }
        }
        public static void Xoa(TacgiaDTO tacgia)
        {
            try
            {
                TacgiaDAO.Xoa(tacgia);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá tác giả thất bại");
            }
        }
    }
}
