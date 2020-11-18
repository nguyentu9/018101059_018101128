using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class SinhvienDAO
    {
        
        public static DataTable Thongtin_SV1()
        {
            string s = "select MASV,HOTEN,GIOITINH, NGAYSINH, DIACHI,SDT, k.MAKHOA, TENKHOA  From SINHVIEN s, KHOA k where s.MAKHOA=k.MAKHOA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
     
        public static DataTable Thongtin_Khoa()
        {
            string s = "select * From KHOA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
       
        public static void ThemSV(SinhvienDTO sv)
        {
            string s = "insert into SINHVIEN values('" +sv.masv+ "', N'" +sv.hoten+ "','" +sv.gioitinh+ "','" +sv.makhoa+ "','" +sv.ngaysinh+ "',N'" +sv.diachi+ "','" +sv.sdt+ "')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void CapnhatSV(SinhvienDTO sv)
        {
            string s = "Update SINHVIEN set HOTEN=N'" + sv.hoten + "',GIOITINH='" + sv.gioitinh + "',MAKHOA='" + sv.makhoa + "',NGAYSINH='" + sv.ngaysinh + "',DIACHI=N'" + sv.diachi + "',SDT='" + sv.sdt + "' where MASV='" + sv.masv + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void XoaSV(SinhvienDTO sv)
        {
            string s = "delete From SINHVIEN where MASV='" + sv.masv + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
