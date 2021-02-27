using System;
using BEL;
using DAL;
using System.Data;

namespace BAL
{
    public class BAL_Sach
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_Sach.Load();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable LoadId()
        {
            return DAL_Sach.LoadId();
        }
        public static bool IsExist(string Name, string Author)
        {
            try
            {
                return DAL_Sach.IsExist(Name, Author);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_Sach Sach)
        {
            if (Sach.MaSach == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            if (Sach.TenSach == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            if (Sach.MaLoai == "")
            {
                throw new Exception("Mã loại không được trống!");
            }
            if (Sach.MaTacGia == null)
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            if (Sach.MaNgonNgu == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (Sach.MaNhaXuatBan == "")
            {
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            if (Sach.StringNamXuatBan == "")
            {
                throw new Exception("Năm xuất bản không được trống!");
            }
            if (Sach.StringSoLuong == "")
            {
                throw new Exception("Số lượng không được trống!");
            }
            if (int.Parse(Sach.StringSoLuong) <= 0)
            {
                throw new Exception("Số lượng phải lớn hơn 0!");
            }
            if (Sach.StringGiaNhap == "")
            {
                throw new Exception("Giá nhập không được trống!");
            }
            if (Sach.MoTa == "")
            {
                throw new Exception("Mô tả không được trống!");
            }
            if (Sach.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được trống!");
            }
            if (Sach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_Sach.Add(Sach);
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
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_Sach Sach)
        {
            if (Sach.MaSach == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            if (Sach.TenSach == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            if (Sach.MaLoai == "")
            {
                throw new Exception("Mã loại không được trống!");
            }
            if (Sach.MaTacGia == null)
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            if (Sach.MaNgonNgu == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (Sach.MaNhaXuatBan == "")
            {
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            if (Sach.StringNamXuatBan == "")
            {
                throw new Exception("Năm xuất bản không được để trống!");
            }
            if (Sach.StringSoLuong == "")
            {
                throw new Exception("Số lượng không được để trống!");
            }
            if (Sach.StringGiaNhap == "")
            {
                throw new Exception("Giá nhập không được để trống!");
            }
            if (Sach.MoTa == "")
            {
                throw new Exception("Mô tả không được trống!");
            }
            if (Sach.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được trống!");
            }
            if (Sach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_Sach.Update(Sach);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update2(BEL_Sach Sach)
        {
            return DAL_Sach.Update2(Sach);
        }
        public static BEL_Sach GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static string GetSpeciesById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.GetSpeciesById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static string GetIdByName(string Name)
        {
            if (Name == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            return DAL_Sach.GetIdByName(Name);
        }
        public static int? GetNumberById(string Id)
        {
            return DAL_Sach.GetNumberById(Id);
        }
        public static DataTable SearchById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.SearchById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByName(string Name)
        {
            if (Name == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            try
            {
                return DAL_Sach.SearchByName(Name);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByAuthor(string Author)
        {
            if (Author == "")
            {
                throw new Exception("Tên tác giả không được trống!");
            }
            try
            {
                return DAL_Sach.SearchByAuthor(Author);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByLanguage(string Language)
        {
            if (Language == "")
            {
                throw new Exception("Ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_Sach.SearchByLanguage(Language);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByBlisher(string Blisher)
        {
            if (Blisher == "")
            {
                throw new Exception("Nhà xuất bản không được trống!");
            }
            try
            {
                return DAL_Sach.SearchByBlisher(Blisher);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByYear(int Year)
        {
            if (Year == null)
            {
                throw new Exception("Năm không được trống!");
            }
            try
            {
                return DAL_Sach.SearchByYear(Year);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static int Count()
        {
            try
            {
                return DAL_Sach.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
