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
    class KhoaBUS
    {
        public static DataTable TT_Khoa()
        {
            return KhoaDAO.TT_Khoa();
        }

        public static void Them(KhoaDTO k)
        {
            try
            {
                KhoaDAO.Them(k);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");   
            }
        }
        public static void Capnhat(KhoaDTO k)
        {
            try
            {
                KhoaDAO.Capnhat(k);

            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        public static void Xoa(KhoaDTO k)
        {
            try
            {
                KhoaDAO.Xoa(k);

            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

    }


}
