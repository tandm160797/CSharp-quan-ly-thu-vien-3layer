﻿--Create database!
CREATE DATABASE QUANLYTHUVIEN
GO
USE QUANLYTHUVIEN
GO
--

CREATE TABLE LOAINHANVIEN
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15)
	CONSTRAINT PK_LOAINHANVIEN PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE NHANVIEN
(	
	MaNhanVien VARCHAR(6) NOT NULL,
	TenNhanVien NVARCHAR(30),
	GioiTinh NVARCHAR(3),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	DienThoai VARCHAR(10),
	MatKhau VARCHAR(32),
	MaLoai VARCHAR(6),
	HinhAnh NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY(MaNhanVien),
	CONSTRAINT FK_NHANVIEN_LOAINHANVIEN FOREIGN KEY(MaLoai) REFERENCES LOAINHANVIEN(MaLoai)
)
GO

CREATE TABLE LOAIDOCGIA
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_LOAIDOCGIA PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE DOCGIA
(
	MaDocGia VARCHAR(6) NOT NULL,
	TenDocGia NVARCHAR(30),
	GioiTinh NVARCHAR(3),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	DienThoai VARCHAR(10),
	MatKhau NVARCHAR(32),
	MaLoai VARCHAR(6),
	HinhAnh NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_DOCGIA PRIMARY KEY(MaDocGia),
	CONSTRAINT FK_DOCGIA_LOAIDOCGIA FOREIGN KEY(MaLoai) REFERENCES LOAIDOCGIA(MaLoai)
)
GO

CREATE TABLE TACGIA
(
	MaTacGia VARCHAR(6) NOT NULL,
	TenTacGia NVARCHAR(30),
	DienThoai VARCHAR(10),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_TACGIA PRIMARY KEY(MaTacGia)
)
GO

CREATE TABLE NHAXUATBAN
(
	MaNhaXuatBan VARCHAR(6) NOT NULL,
	TenNhaXuatBan NVARCHAR(30),
	Email VARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NHAXUATBAN PRIMARY KEY(MaNhaXuatBan)
)
GO

CREATE TABLE NGONNGU
(	
	MaNgonNgu VARCHAR(6) NOT NULL,
	TenNgonNgu NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NGONNGU PRIMARY KEY(MaNgonNgu)
)
GO

CREATE TABLE LOAISACH
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_LOAISACH PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE SACH
(
	MaSach VARCHAR(6) NOT NULL,
	TenSach NVARCHAR(50),
	MaLoai VARCHAR(6),
	MaTacGia VARCHAR(6),
	MaNgonNgu VARCHAR(6),
	MaNhaXuatBan VARCHAR(6),
	NamXuatBan VARCHAR(4),
	SoLuong INT,
	GiaNhap INT,
	MoTa NVARCHAR(MAX),
	HinhAnh NVARCHAR(60),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_SACH PRIMARY KEY(MaSach),
	CONSTRAINT FK_SACH_TACGIA FOREIGN KEY(MaTacGia) REFERENCES TACGIA(MaTacGia),
	CONSTRAINT FK_SACH_NHAXUATBAN FOREIGN KEY(MaNhaXuatBan) REFERENCES NHAXUATBAN(MaNhaXuatBan),
	CONSTRAINT FK_SACH_NGONNGU FOREIGN KEY(MaNgonNgu) REFERENCES NGONNGU(MaNgonNgu),
	CONSTRAINT FK_SACH_LOAISACH FOREIGN KEY(MaLoai) REFERENCES LOAISACH(MaLoai)
)
GO

CREATE TABLE HOADONNHAP
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaNhanVien VARCHAR(6),
	NgayLap DATE,
	TongTien INT,
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_HOADONNHAP PRIMARY KEY(MaHoaDon),
	CONSTRAINT FK_HOADONNHAP_NHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
)
GO

CREATE TABLE CHITIETHOADONNHAP
(	
	MaHoaDon VARCHAR(6) NOT NULL,
	MaSach VARCHAR(6) NOT NULL,
	SoLuong INT,
	CONSTRAINT PK_CHITIETHOADONNHAP PRIMARY KEY(MaHoaDon, MaSach),
	CONSTRAINT FK_CHITIETHOADONNHAP_HOADONNHAP FOREIGN KEY(MaHoaDon) REFERENCES HOADONNHAP(MaHoaDon)
)
GO

CREATE TABLE HOADONMUON
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaNhanVien VARCHAR(6),
	MaDocGia VARCHAR(6),
	NgayLap DATE,
	NgayTra DATE,
	DaTra BIT,
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_HOADONMUON PRIMARY KEY(MaHoaDon),
	CONSTRAINT FK_HOADONMUON_NHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES NHANVIEN(MaNhanVien),
	CONSTRAINT FK_HOADONMUON_DOCGIA FOREIGN KEY(MaDocGia) REFERENCES DOCGIA(MaDocGia)
)
GO

CREATE TABLE CHITIETHOADONMUON
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaSach VARCHAR(6),
	SoLuong INT,
	CONSTRAINT PK_CHITIETHOADONMUON PRIMARY KEY(MaHoaDon, MaSach),
	CONSTRAINT FK_CHITIETHOADONMUON_HOADONMUON FOREIGN KEY(MaHoaDon) REFERENCES HOADONMUON(MaHoaDon),
	CONSTRAINT FK_CHITIETHOADONMUON_SACH FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)
)
GO

--Insert data!
INSERT INTO LOAINHANVIEN(MaLoai, TenLoai, TrangThai)
VALUES ('LNV1', N'Admin', N'Tồn tại'),
	   ('LNV2', N'Quản lý', N'Tồn tại')

INSERT INTO NHANVIEN
VALUES ('NV1', N'Admin', N'Nam', '1-1-1', N'Địa chỉ', '0111111111', 'c4ca4238a0b923820dcc509a6f75849b', 'LNV1', 'Admin.jpg', N'Tồn tại')