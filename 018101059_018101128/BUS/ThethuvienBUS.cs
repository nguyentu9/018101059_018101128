using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128.BUS
{
    class ThethuvienBUS
    {
        public static DataTable Lvthethuvien()
        {
            return ThethuvienDAO.The_TV();
        }
        public static DataTable SV()
        {
            return SinhvienDAO.Thongtin_SV1();
        }
        public static void Them(ThethuvienDTO t)
        {
            try {
                ThethuvienDAO.Them(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm");
            }
        }
        public  static void Capnhat(ThethuvienDTO t)
        {
            try
            {
                ThethuvienDAO.Capnhat(t);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể cập nhật");
            }
        }
        public static void Xoa(ThethuvienDTO t)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ThethuvienDAO.Xoa(t);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể Xóa");
                }
            }
        }
    }
}
