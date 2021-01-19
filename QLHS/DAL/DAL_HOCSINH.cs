using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HOCSINH
    {
        public DataTable LayTatCaHocSinh()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT * FROM HOCSINH";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayTatCaMonHoc()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT * FROM MONHOC";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayTatCaKhoiLop()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT * FROM KHOILOP";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public DataTable LayTatCaLop()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT * FROM DANHSACHLOP";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayLopHoc(string makhoilop)
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT MaLop FROM DANHSACHLOP where MaKhoiLop = '"+ makhoilop + "'";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayKhoiLop()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT MaKhoiLop FROM KHOILOP";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public DataTable LayTatCaHocKi()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "SELECT * FROM HOCKI";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable DSLOP()
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "EXEC dbo.DSLOP";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable TIMHSBANGMA(string MaHocSinh)
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "EXEC dbo.TIMHSBANGMA '" + MaHocSinh + "'";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public int ThemHocSinh(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "INSERT INTO HOCSINH(MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, Email) VALUES(@MaHocSinh, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocSinh", Value = hs.MaHocSinh },
                            new SqlParameter { ParameterName = "@HoTen", Value = hs.HoTen },
                            new SqlParameter { ParameterName = "@NgaySinh", Value = hs.NgaySinh },
                            new SqlParameter { ParameterName = "@GioiTinh", Value = hs.GioiTinh },
                            new SqlParameter { ParameterName = "@DiaChi", Value = hs.DiaChi },
                            new SqlParameter { ParameterName = "@Email", Value = hs.Email }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int ThemMonHoc(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "INSERT INTO MONHOC(MaMonHoc, TenMonHoc) VALUES(@MaMonHoc, @TenMonHoc)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaMonHoc", Value = hs.MaMonHoc },
                            new SqlParameter { ParameterName = "@TenMonHoc", Value = hs.TenMonHoc }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int ThemDSLop(string malop, string mahs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "EXEC USP_CHITIETDSLOP @Malop , @MaHS";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@Malop", Value = malop },
                            new SqlParameter { ParameterName = "@MaHS", Value = mahs }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public bool Check_MaKL(string malop)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            string strSql = "Select * from KHOILOP where MaKhoiLop = @MaKhoiLop";
            provider.Connect();
            nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                        new SqlParameter { ParameterName = "@MaKhoiLop", Value = malop }
                );
            if (nRow > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int ThemKhoiLop(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            if (Check_MaKL(hs.MaKhoiLop) == true)
            {
                try
                {
                    string strSql = "INSERT INTO KHOILOP(MaKhoiLop, TenKhoiLop) VALUES(@MaKhoiLop, @TenKhoiLop)";
                    provider.Connect();
                    nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@MaKhoiLop", Value = hs.MaKhoiLop },
                                new SqlParameter { ParameterName = "@TenKhoiLop", Value = hs.TenKhoiLop }
                        );

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    provider.DisConnect();
                }
        }
            return nRow;
        }
        public int ThemLop(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "INSERT INTO DANHSACHLOP(MaLop, TenLop, SiSo, MaKhoiLop) VALUES(@MaLop, @TenLop, @SiSo, @MaKhoiLop)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaLop", Value = hs.MaLop },
                            new SqlParameter { ParameterName = "@TenLop", Value = hs.TenLop },
                            new SqlParameter { ParameterName = "@SiSo", Value = hs.SiSo },
                            new SqlParameter { ParameterName = "@MaKhoiLop", Value = hs.MaKhoiLop }

                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int ThemHocKi(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "INSERT INTO HOCKI(MaHocKi, TenHocKi) VALUES(@MaHocKi, @TenHocKi)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocKi", Value = hs.MaHocKi },
                            new SqlParameter { ParameterName = "@TenHocKi", Value = hs.TenHocKi }

                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public DataTable ThemHSVaoLop(string TenLop)
        {
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "EXEC dbo.ThemHSVaoLop '" + TenLop + "'";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public int ThemCTDSLOP(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "INSERT INTO CHITIETDSLOP(MaChiTietDSLop, MaHocSinh) VALUES(@MaHocSinh, @MaHocSinh)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocSinh", Value = hs.MaHocSinh }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int XoaHocSinh(QLHS_DTO ma)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "DELETE FROM HOCSINH WHERE MaHocSinh = @MaHocSinh;";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocSinh", Value = ma.MaHocSinh }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int XoaMonHoc(QLHS_DTO ma)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "DELETE FROM MONHOC WHERE MaMonHoc = @MaMonHoc;";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaMonHoc", Value = ma.MaMonHoc }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int XoaKhoiLop(QLHS_DTO ma)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "DELETE FROM KHOILOP WHERE MaKhoiLop = @MaKhoiLop;";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaKhoiLop", Value = ma.MaKhoiLop }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int XoaLop(QLHS_DTO ma)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "DELETE FROM DANHSACHLOP WHERE MaLop = @MaLop;";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaLop", Value = ma.MaLop }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int XoaHocKi(QLHS_DTO ma)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "DELETE FROM HOCKI WHERE MaHocKi = @MaHocKi;";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocKi", Value = ma.MaHocKi }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int CapNhatHocSinh(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "UPDATE HOCSINH SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, Email = @Email WHERE MaHocSinh = @MaHocSinh";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocSinh", Value = hs.MaHocSinh },
                            new SqlParameter { ParameterName = "@HoTen", Value = hs.HoTen },
                            new SqlParameter { ParameterName = "@NgaySinh", Value = hs.NgaySinh },
                            new SqlParameter { ParameterName = "@GioiTinh", Value = hs.GioiTinh },
                            new SqlParameter { ParameterName = "@DiaChi", Value = hs.DiaChi },
                            new SqlParameter { ParameterName = "@Email", Value = hs.Email }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int CapNhatMonHoc(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "UPDATE MONHOC SET MaMonHoc = @MaMonHoc, TenMonHoc = @TenMonHoc";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaMonHoc", Value = hs.MaMonHoc },
                            new SqlParameter { ParameterName = "@TenMonHoc", Value = hs.TenMonHoc }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int CapNhatKhoiLop(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "UPDATE KHOILOP SET MaKhoiLop = @MaKhoiLop, TenKhoiLop = @TenKhoiLop WHERE MaKhoiLop = @MaKhoiLop";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaKhoiLop", Value = hs.MaKhoiLop },
                            new SqlParameter { ParameterName = "@TenKhoiLop", Value = hs.TenKhoiLop }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int CapNhatLop(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "UPDATE DANHSACHLOP SET MaLop = @MaLop, TenLop = @TenLop, SiSo = @SiSo, MaKhoiLop = @MaKhoiLop WHERE MaLop = @MaLop";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaLop", Value = hs.MaLop },
                            new SqlParameter { ParameterName = "@TenLop", Value = hs.TenLop },
                            new SqlParameter { ParameterName = "@SiSo", Value = hs.SiSo },
                            new SqlParameter { ParameterName = "@MaKhoiLop", Value = hs.MaKhoiLop }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int CapNhatHocKi(QLHS_DTO hs)
        {
            int nRow = 0;
            DBConnect provider = new DBConnect();
            try
            {
                string strSql = "UPDATE HOCKI SET MaHocKi = @MaHocKi, TenHocKi = @TenHocKi";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@MaHocKi", Value = hs.MaHocKi },
                            new SqlParameter { ParameterName = "@TenHocKi", Value = hs.TenHocKi }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        /*
        public int SuaSanPham(SanPhamDTO sp)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "sp_SuaSanPham";
                provider.Connect();
                int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, strSql,
                            new SqlParameter { ParameterName = "@MaSP", Value = sp.MaSP },
                            new SqlParameter { ParameterName = "@TenSP", Value = sp.TenSP },
                            new SqlParameter { ParameterName = "@GiaTien", Value = sp.GiaTien },
                            new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
                            new SqlParameter { ParameterName = "@DonViTinh", Value = sp.DonViTinh }
                    );
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        */
    }
}
