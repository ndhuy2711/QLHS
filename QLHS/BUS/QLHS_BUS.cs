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
        public int TIMHSBANGMA(string MaHocSinh)
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
    }
}
