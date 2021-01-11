using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLHS_DTO
    {
        
        public string MaHocSinh { get => _maHocSinh; set => _maHocSinh = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Email { get => _email; set => _email = value; }
        
        //--------------------------------
        public string MaChiTietDSLop { get => _maChiTietDSLop; set => _maChiTietDSLop = value; }
        public string MaLop { get => _maLop; set => _maLop = value; }
        public float TBHocKi1 { get => _tBHocKi1; set => _tBHocKi1 = value; }
        public float TBHocKi2 { get => _tBHocKi2; set => _tBHocKi2 = value; }

        //--------------------HOCSINH--------------
        private string _maHocSinh;
        private string _hoTen;
        private string _gioiTinh;
        private string _ngaySinh;
        private string _diaChi;
        private string _email;
        //-------------------CHITIETDANHSACHLOP-----------------
        private string _maChiTietDSLop;
        private string _maLop;
        private float _tBHocKi1;
        private float _tBHocKi2;
    }

}
