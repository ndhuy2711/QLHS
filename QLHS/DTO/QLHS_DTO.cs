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
        private string _maHocSinh;
        private string _hoTen;
        private string _gioiTinh;
        private string _ngaySinh;
        private string _diaChi;
        private string _email;
        /*public string MaHocSinh { 
            get { return _maHocSinh; }
            set { _maHocSinh = value; } 
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public string NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        */


    }

}
