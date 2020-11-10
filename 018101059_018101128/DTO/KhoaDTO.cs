using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DTO
{
    class KhoaDTO
    {
        private string _makhoa;
        public string makhoa
        {

            get { return _makhoa; }
            set { _makhoa = value; }
        }
        private string _tenkhoa;
        public string tenkhoa
        {

            get { return _tenkhoa; }
            set { _tenkhoa = value; }
        }
        public KhoaDTO()
        {
            _makhoa = "";
            _tenkhoa = "";
        }
        public KhoaDTO(string MAKHOA, string TENKHOA)
        {
            _makhoa = MAKHOA;
            _tenkhoa = TENKHOA;
        }
    }
}
