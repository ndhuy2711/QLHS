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
        public int ThemKhoiLop(QLHS_DTO hs)
        {
            try
            {
                DAL_HOCSINH dal = new DAL_HOCSINH();
                return dal.ThemKhoiLop(hs);
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
        public int XoaHocSinh(QLHS_DTO ma)
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
    }
}
