using System;
using BEL;
using DAL;
using System.Data;
using System.Collections.Generic;

namespace BAL
{
    public class BAL_HoaDonMuon
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_HoaDonMuon.Load();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_HoaDonMuon HoaDonMuon)
        {
            if (HoaDonMuon.MaHoaDon == "")
            {
                throw new Exception("Mã hóa đơn nhập không được trống!");
            }
            if (HoaDonMuon.MaNhanVien == "")
            {
                throw new Exception("Mã nhân viên không được trống!");
            }
            if (HoaDonMuon.NgayLap == null)
            {
                throw new Exception("Ngày lập không được trống!");
            }
            if (HoaDonMuon.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_HoaDonMuon.Add(HoaDonMuon);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Delete(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            try
            {
                return DAL_HoaDonMuon.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }

        public static object GetSachById()
        {
            throw new NotImplementedException();
        }

        public static bool Update(BEL_HoaDonMuon HoaDonMuon)
        {
            if (HoaDonMuon.MaHoaDon == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            if (HoaDonMuon.MaNhanVien == "")
            {
                throw new Exception("Mã nhân viên không được trống!");
            }
            if (HoaDonMuon.NgayLap == null)
            {
                throw new Exception("Ngày lập không được trống!");
            }
            if (HoaDonMuon.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_HoaDonMuon.Update(HoaDonMuon);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool IsPay(string Id)
        {
            return DAL_HoaDonMuon.IsPay(Id);
        }
        public static List<BEL_Sach> GetSachById(string Id)
        {
            return DAL_HoaDonMuon.GetSachById(Id);
        }
        public static BEL_HoaDonMuon GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            try
            {
                return DAL_HoaDonMuon.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable GetIdByReaderId(string ReaderId)
        {
            return DAL_HoaDonMuon.GetIdByReaderId(ReaderId);
        }
        public static int Count()
        {
            try
            {
                return DAL_HoaDonMuon.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
