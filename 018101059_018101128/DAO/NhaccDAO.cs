using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DTO;
namespace _018101059_018101128.DAO
{
    class NhaccDAO
    {
        public static DataTable TT_Nhacc()
        {
            string s = "select * from NHACC";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(NhaccDTO nhacc)
        {
            string s = "insert into NHACC values ('" + nhacc.manhacc + "', '" + nhacc.tennhacc+ "', '" + nhacc.diachi + "', '" + nhacc.sdt+ "')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(NhaccDTO nhacc)
        {
            string s = "Update NHACC set TENNCC='" + nhacc.tennhacc + "', '" + nhacc.diachi + "', '" 
                + nhacc.sdt + "' where MANCC='" + nhacc.manhacc+ "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(NhaccDTO nhacc)
        {
            string s = "Delete From NHACC where MANCC='" + nhacc.manhacc + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
