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
                DAL_HOCSINH dao = new DAL_HOCSINH();
                return dao.LayTatCaHocSinh();
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
    }
}
