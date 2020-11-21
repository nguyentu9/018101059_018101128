using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class CTPMDAO
    {
        public static DataTable CT_PM()
        {
            string s = "select sopm, s.mash, tensach, s.soluong from SACH s, CTPM c where s.mash= c.mash ";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(CTPMDTO c)
        {
            string s = "insert into CTPM values ('"+c.mash+"','"+c.soluong+"')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(CTPMDTO c)
        {
            string s = "update CTPM set soluong ='" + c.soluong + "' where sopm='" + c.sopm + "' and mash='" + c.mash + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void xoa(CTPMDTO c)
        {
            string s = "delete from CTPM where sopm='"+c.sopm+"' and mash='"+ c.mash + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
