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
        //-----------------------------------
        public string TenLop { get => _tenLop; set => _tenLop = value; }
        public string SiSo { get => _siSo; set => _siSo = value; }
        public string MaKhoiLop { get => _maKhoiLop; set => _maKhoiLop = value; }
        //------------------------------------------
        public string TenKhoiLop { get => _tenKhoiLop; set => _tenKhoiLop = value; }
        //------------------------------------------
        public string MaBangDiem { get => _maBangDiem; set => _maBangDiem = value; }
        public string MaMonHoc { get => _maMonHoc; set => _maMonHoc = value; }
        public string Diem15phut { get => _diem15phut; set => _diem15phut = value; }
        public string Diem1tiet { get => _diem1tiet; set => _diem1tiet = value; }
        public string DiemCuoiKi { get => _diemCuoiKi; set => _diemCuoiKi = value; }
        //----------------------------------------
        public string TenMonHoc { get => _tenMonHoc; set => _tenMonHoc = value; }
        //-------------------------------------------
        public string MaHocKi { get => _maHocKi; set => _maHocKi = value; }
        public string TenHocKi { get => _tenHocKi; set => _tenHocKi = value; }
        





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
        //------------------DANHSACHLOP--------------------
        private string _tenLop;
        private string _siSo;
        private string _maKhoiLop;
        //------------------KHOILOP----------------------------
        private string _tenKhoiLop;
        //-----------------BANGDIEM--------------
        private string _maBangDiem;
        private string _maMonHoc;
        private string _diem15phut;
        private string _diem1tiet;
        private string _diemCuoiKi;
        //-------------------MONHOC------------------------
        private string _tenMonHoc;
        //--------------------HOCKI--------------
        private string _maHocKi;
        private string _tenHocKi;
        //-----------------
    }

}
