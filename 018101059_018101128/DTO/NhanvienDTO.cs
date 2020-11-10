using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DTO
{
    class NhanvienDTO
    {
        private string _manv;
        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        private string _hoten;
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        private string _gioitinh;
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private string _ngaysinh;
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        private string _diachi;
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private string _sdt;
        public string sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public NhanvienDTO()
        {
            _manv = "";
            _hoten = "";
            _ngaysinh = "";
            _gioitinh = "";
            _diachi = "";
            _sdt = "";
        }
        public NhanvienDTO(string MaNV, string HoTen, string NgaySinh, string GioiTinh, string DiaChi, string SDT)
        {
            _manv = MaNV;
            _hoten = HoTen;
            _ngaysinh = NgaySinh;
            _gioitinh = GioiTinh;
            _diachi = DiaChi;
            _sdt = SDT;
        }
    }
}
