using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class PhieumuonDAO
    {
        public static DataTable NV()
        {
            string s = "select distinct MaNV, HOTEN from NHANVIEN ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable SV()
        {
            string s = "select * from SINHVIEN";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable CT_PM()
        {
            string s = "select sopm, ngaymuon, ngaytra, p.masv, sv.hoten, s.mash, tensach, mathe, n.manv, n.hoten from sach s, phieumuon p, sinhvien sv, nhanvien n where s.mash=p.mash and p.manv =n.manv and sv.masv=p.masv";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable SACH()
        {
            string s = "select * from SACH";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void ThemPM(PhieumuonDTO pm)
        {
            string s = "insert into PHIEUMUON values ('"+pm.ngaymuon+"','"+pm.ngaytra+"','"+pm.masv+"','"+pm.mash+"','"+pm.mathe+"','"+pm.manv+"') ";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void CapnhatPM(PhieumuonDTO pm)
        {
            string s = "Update PHIEUMUON set NgayMuon='" + pm.ngaymuon + "',NgayTra='" + pm.ngaytra + "',MaSV='" + pm.masv + "',MaSH='" + pm.mash + "',Mathe='" + pm.mathe + "',Manv='" + pm.manv + "' where sopm='"+pm.sopm+"' ";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void XoaPM(PhieumuonDTO pm)
        {
            string s = "Delete  from  PHIEUMUON where sopm='" + pm.sopm + "' ";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
