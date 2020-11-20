using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DTO;
namespace _018101059_018101128.DAO
{
    class GiaiQuyetDAO
    {
        public static DataTable ThongTin_GQ()
        {
            string s = "select * from GIAIQUYET";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(GiaiQuyetDTO gq)
        {
            string s = $"insert into GIAIQUYET values('{gq.ten}')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(GiaiQuyetDTO gq)
        {
            string s = $"Update GIAIQUYET set TENGQ='{gq.ten}' where MAGQ='{gq.ma}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(GiaiQuyetDTO gq)
        {
            string s = $"Delete From GIAIQUYET where MAGQ='{gq.ma}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
