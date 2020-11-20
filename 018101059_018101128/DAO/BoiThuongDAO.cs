using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DTO;
namespace _018101059_018101128.DAO
{
    class BoiThuongDAO
    {
        public static DataTable Load_SinhVien()
        {
            string s = "select MASV, HOTEN from SINHVIEN";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable Load_TinhTrang()
        {
            string s = "select * from TINHTRANG";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable Load_NhanVien()
        {
            string s = "select MANV, HOTEN from NHANVIEN";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable Load_GiaiQuyet()
        {
            string s = "select * from GIAIQUYET";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable ThongTin_BT()
        {
            string s = "SELECT dbo.PHIEUBOITHUONG.SOBT,dbo.SINHVIEN.MASV, dbo.SINHVIEN.HOTEN AS TENSV, dbo.NHANVIEN.HOTEN AS TENNV, dbo.TINHTRANG.TENTT, dbo.GIAIQUYET.TENGQ FROM dbo.GIAIQUYET INNER JOIN dbo.PHIEUBOITHUONG ON dbo.GIAIQUYET.MAGQ = dbo.PHIEUBOITHUONG.MAGQ INNER JOIN dbo.NHANVIEN ON dbo.PHIEUBOITHUONG.MANV = dbo.NHANVIEN.MANV INNER JOIN dbo.SINHVIEN ON dbo.PHIEUBOITHUONG.MASV = dbo.SINHVIEN.MASV INNER JOIN dbo.TINHTRANG ON dbo.PHIEUBOITHUONG.MATT = dbo.TINHTRANG.MATT";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }

        public static void Them(BoiThuongDTO b)
        {
            string s = $"insert into PHIEUBOITHUONG values({b.matt}, {b.magq}, '{b.manv}', '{b.masv}')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(BoiThuongDTO b)
        {
            string s = $"update PHIEUBOITHUONG set MATT={b.matt}, MAGQ={b.magq}, MANV='{b.manv}', MASV='{b.masv}' where SOBT={b.sobt}";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(BoiThuongDTO b)
        {
            string s = $"Delete From PHIEUBOITHUONG where SOBT='{b.sobt}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
