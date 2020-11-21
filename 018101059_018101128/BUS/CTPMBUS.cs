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
    class CTPMBUS
    {
        public static DataTable CT_PM()
        {
            return CTPMDAO.CT_PM();
        }
        public static DataTable Sach()
        {
            return PhieumuonDAO.SACH();
        }
        public static void Xoa(CTPMDTO c)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                try {
                    CTPMDAO.xoa(c);
                }
                catch(Exception)
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }
    }
}
