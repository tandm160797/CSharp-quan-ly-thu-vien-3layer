using System;
using BEL;
using DAL;
using System.Data;

namespace BAL
{
    public class BAL_ChiTietHoaDonNhap
    {
        public static bool Add(BEL_ChiTietHoaDonNhap ChiTietHoaDonNhap)
        {
            try
            {
                return DAL_ChiTietHoaDonNhap.Add(ChiTietHoaDonNhap);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
