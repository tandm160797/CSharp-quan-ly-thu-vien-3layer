using System;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietHoaDonNhap : General
    {
        public static DataTable Load()
        {
            try
            {
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
        public static bool Add(BEL_ChiTietHoaDonNhap ChiTietHoaDonNhap)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into CHITIETHOADONNHAP(MaHoaDon, MaSach, SoLuong) values('{0}', '{1}', {2})", ChiTietHoaDonNhap.MaHoaDon, ChiTietHoaDonNhap.MaSach, ChiTietHoaDonNhap.SoLuong);
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
                return false;
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
        public static bool Update(BEL_ChiTietHoaDonNhap ChiTietHoaDonNhap)
        {
            try
            {
                return false;
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
        public static BEL_HoaDonNhap GetObjectById(string Id)
        {
            try
            {
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
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaHoaDon, MaSach) from CHITIETHOADONNHAP");
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
