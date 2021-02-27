using System;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Sach : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where  SACH.SoLuong > 0 and SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại'");
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataTable Result = new DataTable();
                    Result.Load(DataReader);
                    return Result;
                }
                return null;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable LoadId()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach from SACH where TrangThai = N'Tồn tại'");
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataTable Result = new DataTable();
                    Result.Load(DataReader);
                    return Result;
                }
                return null;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool IsExist(string Name, string Author)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from SACH where TenSach = N'{0}' and MaTacGia = '{1}'", Name, Author);
                SqlCommand Command = new SqlCommand(Query, Connection);
                object Result = Command.ExecuteScalar();
                return (Result != null);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Add(BEL_Sach Sach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into SACH(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai) values('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', N'{9}', N'{10}', N'{11}')", Sach.MaSach, Sach.TenSach, Sach.MaLoai, Sach.MaTacGia, Sach.MaNgonNgu, Sach.MaNhaXuatBan, Sach.StringNamXuatBan, Sach.StringSoLuong, Sach.StringGiaNhap, Sach.MoTa, Sach.HinhAnh, Sach.TrangThai);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Delete(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update SACH set TrangThai = N'Huỷ' where MaSach = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Update(BEL_Sach Sach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update SACH set TenSach = N'{0}', MaLoai = '{1}', MaTacGia = '{2}', MaNgonNgu = N'{3}', MaNhaXuatBan = '{4}', NamXuatBan = '{5}', SoLuong = SACH.SoLuong + '{6}', GiaNhap = '{7}', MoTa = N'{8}', HinhAnh = N'{9}' where MaSach = '{10}'", Sach.TenSach, Sach.MaLoai, Sach.MaTacGia, Sach.MaNgonNgu, Sach.MaNhaXuatBan, Sach.StringNamXuatBan, Sach.StringSoLuong, Sach.StringGiaNhap, Sach.MoTa, Sach.HinhAnh, Sach.MaSach);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Update2(BEL_Sach Sach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update SACH set TenSach = N'{0}', MaLoai = '{1}', MaTacGia = '{2}', MaNgonNgu = '{3}', MaNhaXuatBan = '{4}', NamXuatBan = {5}, SoLuong = SACH.SoLuong - {6}, GiaNhap = {7}, MoTa = N'{8}', HinhAnh = N'{9}' where MaSach = '{10}'", Sach.TenSach, Sach.MaLoai, Sach.MaTacGia, Sach.MaNgonNgu, Sach.MaNhaXuatBan, Sach.NamXuatBan, Sach.SoLuong, Sach.GiaNhap, Sach.MoTa, Sach.HinhAnh, Sach.MaSach);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static BEL_Sach GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from SACH where MaSach = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    string MaSach = (string)DataReader["MaSach"];
                    string TenSach = (string)DataReader["TenSach"];
                    string MaLoai = (string)DataReader["MaLoai"];
                    string MaTacGia = (string)DataReader["MaTacGia"];
                    string MaNgonNgu = (string)DataReader["MaNgonNgu"];
                    string MaNhaXuatBan = (string)DataReader["MaNhaXuatBan"];
                    string NamXuatBan = (string)DataReader["NamXuatBan"];
                    int SoLuong = (int)DataReader["SoLuong"];
                    int GiaNhap = (int)DataReader["GiaNhap"];
                    string MoTa = (string)DataReader["MoTa"];
                    string HinhAnh = (string)DataReader["HinhAnh"];
                    string TrangThai = (string)DataReader["TrangThai"];
                    BEL_Sach Sach = new BEL_Sach(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, int.Parse(NamXuatBan), SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai);
                    return Sach;
                }
                return null;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static string GetSpeciesById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaLoai from SACH where MaSach = '{0}' ", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string Result = (string)DataReader["MaLoai"];
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static string GetIdByName(string Name)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach from SACH where TenSach = N'{0}' ", Name);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string Result = (string)DataReader["MaSach"];
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static int? GetNumberById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select SoLuong from SACH where MaSach = '{0}' ", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    int Result = (int)DataReader["SoLuong"];
                    return Result;
                }
                return null;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and SACH.MaSach = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByName(string Name)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and SACH.TenSach like N'%{0}%'", Name);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByAuthor(string Author)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and TACGIA.TenTacGia like N'%{0}%'", Author);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByLanguage(string Language)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and NGONNGU.TenNgonNgu like N'%{0}%'", Language);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByBlisher(string Blisher)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and NHAXUATBAN.TenNhaXuatBan like N'%{0}%'", Blisher);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByYear(int Year)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and SACH.TrangThai = N'Tồn tại' and LOAISACH.TrangThai = N'Tồn tại' and TACGIA.TrangThai = N'Tồn tại' and NGONNGU.TrangThai = N'Tồn tại' and NHAXUATBAN.TrangThai = N'Tồn tại' and SACH.NamXuatBan = '{0}'", Year);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaSach) from SACH");
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = (int)Command.ExecuteScalar();
                return (Result);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
