using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class ThethuvienDAO
    {
        public static DataTable The_TV()
        {
            string s = "select mathe, s.masv, hoten, ngaycap, ngayhethan from THETHUVIEN t, sinhvien s where t.masv = s.masv";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(ThethuvienDTO t)
        {
            string s = "insert into Thethuvien values ('"+t.masv+"', '"+t.ngaycap+"', '"+t.ngayhethan+"')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(ThethuvienDTO t)
        {
            string s = "update Thethuvien set masv='" + t.masv + "', ngaycap='" + t.ngaycap + "',ngayhethan= '" + t.ngayhethan + "' where mathe='"+t.mathe+"'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(ThethuvienDTO t)
        {
            string s = "delete from thethuvien where mathe='" + t.mathe + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
