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
    class PhieunhapBUS
    {
        public static DataTable Cbb_Phieunhap()
        {
           DataTable dt = new DataTable();
            dt = PhieunhapDAO.Cbb_Phieunhap();
           return dt;
        }
        public static void ThemPN(PhieunhapDTO pn)
        {
            try
            {
                PhieunhapDAO.ThemPn(pn);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm phiếu nhập không thành công");
            }
        }
        public static void CapnhatPN(PhieunhapDTO pn)
        {
            try
            {
                PhieunhapDAO.CapnhatPn(pn);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhậtphiếu nhập không thành công");
            }
        }
        public static void Xoapn(PhieunhapDTO pn)
        {
            if ((MessageBox.Show("Bạn có muốn xóa phiếu nhập này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                try
                {
                    PhieunhapDAO.XoaPn(pn);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập");
                }
        }
    }
}
