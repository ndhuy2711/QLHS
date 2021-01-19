using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class QLHS_BUS
    {
        public DataTable LayTatCaHocSinh()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaHocSinh();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayTatCaMonHoc()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaMonHoc();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayTatCaBangDiem()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaBangDiem();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayDSMonHoc()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayDSMonHoc();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable TIMKIEMTHEOHOTEN(string hoten)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.TIMKIEMTHEOHOTEN(hoten);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable ThamSo()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThamSo();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayMaMH(string tenmh)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayMaMH(tenmh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        public DataTable LayTatCaHocKi()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaHocKi();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayTatCaKhoiLop()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaKhoiLop();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayTatCaLop()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayTatCaLop();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayLopHoc(string malophoc)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayLopHoc(malophoc);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable DSLop()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.DSLOP();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable TIMKIEMDSHS()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.TIMKIEMDSHS();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable TIMHSBANGMA(string MaHocSinh)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.TIMHSBANGMA(MaHocSinh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayKhoiLop()
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.LayKhoiLop();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemHocSinh(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemHocSinh(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemDSLop(string malop, string mahs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemDSLop(malop, mahs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemMonHoc(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemMonHoc(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemBangDiem(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemBangDiem(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemKhoiLop(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemKhoiLop(hs);
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }
        public int ThemHocKi(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemHocKi(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemLop(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemLop(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable ThemHSVaoLop(string TenLop)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemHSVaoLop(TenLop);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
       
        public int ThemCTDSLOP(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemCTDSLOP(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaHocSinh(string ma)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.XoaHocSinh(ma);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaMonHoc(QLHS_DTO ma)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.XoaMonHoc(ma);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaKhoiLop(QLHS_DTO ma)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.XoaKhoiLop(ma);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaLop(QLHS_DTO ma)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.XoaLop(ma);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaHocKi(QLHS_DTO ma)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.XoaHocKi(ma);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatHocSinh(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.CapNhatHocSinh(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatMonHoc(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.CapNhatMonHoc(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatKhoiLop(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.CapNhatKhoiLop(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatLop(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.CapNhatLop(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatHocKi(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.CapNhatHocKi(hs);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
