using System;
using BEL;
using DAL;
using System.Data;

namespace BAL
{
    public class BAL_ChiTietHoaDonMuon
    {
        public static bool Add(BEL_ChiTietHoaDonMuon ChiTietHoaDonMuon)
        {
            try
            {
                return DAL_ChiTietHoaDonMuon.Add(ChiTietHoaDonMuon);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
