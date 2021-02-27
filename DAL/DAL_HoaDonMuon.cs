using System;
using BEL;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DAL
{
    public class DAL_HoaDonMuon : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaHoaDon from HOADONMUON where DaTra = 'False' and TrangThai = N'Tồn tại'");
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataTable Result = new DataTable();
                Result.Load(DataReader);
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
        public static bool Add(BEL_HoaDonMuon HoaDonMuon)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into HOADONMUON(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{6}')", HoaDonMuon.MaHoaDon, HoaDonMuon.MaNhanVien, HoaDonMuon.MaDocGia, HoaDonMuon.NgayLap.ToString("MM-dd-yyyy"), HoaDonMuon.NgayTra.ToString("MM-dd-yyyy"), HoaDonMuon.DaTra, HoaDonMuon.TrangThai);
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
                string Query = string.Format("update HOADONMUON set TrangThai = N'Huỷ' where MaHoaDon = '{0}'", Id);
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
        public static bool Update(BEL_HoaDonMuon HoaDonMuon)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update HOADONMUON set MaNhanVien = '{0}', MaDocGia = '{1}', NgayLap = '{2}', NgayTra = '{3}', DaTra = {4}, where MaLoai = '{5}'", HoaDonMuon.MaNhanVien, HoaDonMuon.MaHoaDon, HoaDonMuon.MaDocGia, HoaDonMuon.NgayLap.ToString("MM-dd-yyyy"), HoaDonMuon.NgayTra.ToString("MM-dd-yyyy"), HoaDonMuon.DaTra, HoaDonMuon.MaHoaDon);
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
        public static bool IsPay(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update HOADONMUON set DaTra = 'True' where MaHoaDon = '{0}'", Id);
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
        public static List<BEL_Sach> GetSachById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach where MaHoaDon = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    List<BEL_Sach> Result = new List<BEL_Sach>();
                    while (DataReader.Read())
                    {
                        BEL_Sach Sach = DAL_Sach.GetObjectById((string)DataReader["MaSach"]);
                        Result.Add(Sach);
                    }
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
        public static BEL_HoaDonMuon GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from HOADONMUON where MaHoaDon = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaHoaDon = (string)DataReader["MaHoaDon"];
                string MaNhanVien = (string)DataReader["MaNhanVien"];
                string MaDocGia = (string)DataReader["MaDocGia"];
                DateTime NgayLap = (DateTime)DataReader["NgayLap"];
                DateTime NgayTra = (DateTime)DataReader["NgayTra"];
                bool DaTra = (bool)DataReader["DaTra"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_HoaDonMuon HoaDonMuon = new BEL_HoaDonMuon(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai);
                return HoaDonMuon;
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
        public static DataTable GetIdByReaderId(string ReaderId)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaHoaDon from HOADONMUON where MaDocGia = '{0}'", ReaderId);
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
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaHoaDon) from HOADONMUON");
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
