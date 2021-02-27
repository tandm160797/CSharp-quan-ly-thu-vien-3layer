using System;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietHoaDonMuon : General
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
        public static bool Add(BEL_ChiTietHoaDonMuon ChiTietHoaDonMuon)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into CHITIETHOADONMUON(MaHoaDon, MaSach, SoLuong) values('{0}', '{1}', {2})", ChiTietHoaDonMuon.MaHoaDon, ChiTietHoaDonMuon.MaSach, ChiTietHoaDonMuon.SoLuong);
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
