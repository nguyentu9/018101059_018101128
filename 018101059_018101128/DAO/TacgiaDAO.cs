using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DTO;
namespace _018101059_018101128.DAO
{
    class TacgiaDAO
    {
        public static DataTable TT_Tacgia()
        {
            string s = "select * from TACGIA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(TacgiaDTO tacgia)
        {
            string s = "insert into TACGIA values ('" + tacgia.matacgia + "', '" + tacgia.tentacgia + "')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(TacgiaDTO tacgia)
        {
            string s = "Update TACGIA set TENTACGIA='" + tacgia.tentacgia + "' where MATG='" + tacgia.matacgia + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(TacgiaDTO tacgia)
        {
            string s = "Delete From TACGIA where MATG='" + tacgia.matacgia + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
