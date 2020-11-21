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
    class PhieumuonBUS
    {
        public static DataTable NV()
        {
            return PhieumuonDAO.NV();
        }
        public static DataTable SV()
        {
            return PhieumuonDAO.SV();
        }
        public static DataTable CTPM()
        {
            return PhieumuonDAO.CT_PM();
        }

        public static void ThemPM(PhieumuonDTO pm)
        {
            try
            {
               PhieumuonDAO.ThemPM(pm);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public static void CapnhatPM(PhieumuonDTO pm)
        {
            try
            {
                PhieumuonDAO.CapnhatPM(pm);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        public static void XoaPM(PhieumuonDTO pm)
        {
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                try
                {
                    PhieumuonDAO.XoaPM(pm);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}
