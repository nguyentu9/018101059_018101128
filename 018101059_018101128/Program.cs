using _018101059_018101128.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmSinhVien());
            //Application.Run(new frmTinhTrang());
            // Application.Run(new frmTacGia());
            //Application.Run(new frmPhieuNhap());
            // Application.Run(new frmPhieuBoiThuong());
            Application.Run(new frmPhieuMuon());
            //Application.Run(new frmTheThuVien());
            // Application.Run(new frmGiaiQuyet());
            //Application.Run(new frmChiTietPhieuMuon());
            //Application.Run(new CrystalReportSinhvien());
            //Application.Run(new frmKhoa());
            //Application.Run(new frmLoai());
            //Application.Run(new frmNhaCungCap());
           //Application.Run(new frmNhanVien());
           // Application.Run(new frmSach());
        }
    }
}
