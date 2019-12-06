USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='dbQLST')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'dbQLST') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [dbQLST]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [dbQLST]
GO
USE [dbQLST]
GO

CREATE TABLE [dbo].[tblTHAMSO](
	[MaTS] [int] NOT NULL PRIMARY KEY,
	[ChietKhauHangVang] [float] NOT NULL,
	[ChietKhauHangBac] [float] NOT NULL,
	[ChietKhauHangBachKim] [float] NOT NULL,
	[LuongCa] [money] NOT NULL,
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tblCHUCVU](
	[MaCV] [int] NOT NULL PRIMARY KEY,
	[TenChucVu] [nvarchar](50) NOT NULL,
	[LuongCa] [money] NOT NULL,
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblHANG](
	[MaHang] [int] NOT NULL PRIMARY KEY,
	[TenHang] [nvarchar](50) NOT NULL,
	[ChietKhau] [float] NOT NULL,
	[Diem] [int] NULL,
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblMATHANG](
	[MaMH] [int] NOT NULL PRIMARY KEY,
	[Barcode] [nvarchar](50) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[GiaBan] [money] NOT NULL,
	[TonToiDa] [int] NULL,
	[TonToiThieu] [int] NULL,
 ) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblNHACUNGCAP](
	[MaNCC] [int] NOT NULL PRIMARY KEY,
	[TenNCC] [nvarchar](50) NOT NULL,
 ) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblNHANVIEN](
	[MaNV] [int] NOT NULL PRIMARY KEY,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[TongCaLam] [int] NOT NULL,
	[Luong] [money] NOT NULL,
	[MaCV] [int] NOT NULL FOREIGN KEY REFERENCES tblCHUCVU(MaCV)
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblPHIEUNHAPKHO](
	[MaSoPhieu] [int] NOT NULL PRIMARY KEY,
	[Ngay] [datetime2](7) NOT NULL,
	[MaNCC] [int] NOT NULL FOREIGN KEY REFERENCES tblNHACUNGCAP(MaNCC),
	[MaNV] [int] NOT NULL FOREIGN KEY REFERENCES tblNHANVIEN(MaNV)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblPHIEUXUATKHO](
	[MaSoPhieu] [int] NOT NULL PRIMARY KEY,
	[Ngay] [datetime2](7) NOT NULL,
	[LiDo] [nvarchar](50) NULL,
	[MaNV] [int] NOT NULL FOREIGN KEY REFERENCES tblNHANVIEN(MaNV),
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblKHACHHANG](
	[MaKH] [int] NOT NULL PRIMARY KEY,
	[HoTen] [nvarchar](50) NOT NULL,
	[Diem] [int] NULL,
	[MaHang] [int] NULL FOREIGN KEY REFERENCES tblHANG(MaHang),
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblHOADONBANHANG](
	[SoHoaDon] [int] NOT NULL PRIMARY KEY,
	[TongSo] [int] NOT NULL,
	[TongCong] [money] NOT NULL,
	[TienKhachTra] [money] NOT NULL,
	[MaNV] [int] NOT NULL FOREIGN KEY REFERENCES tblNHANVIEN(MaNV),
	[DiemMuaHang] [int] NULL,
	[MaKH] [int] NULL FOREIGN KEY REFERENCES tblKHACHHANG(MaKH),
	[DiemSauMuaHang] [int] NULL,
	[NgayGio] [datetime2](7) NOT NULL,
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblHOADONTRAHANG](
	[SoHoaDon] [int] NOT NULL FOREIGN KEY REFERENCES tblHOADONBANHANG(SoHoaDon),
	[MaNV] [int] NOT NULL FOREIGN KEY REFERENCES tblNHANVIEN(MaNV),
	[NgayGio] [datetime2](7) NOT NULL,
 ) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tblCHITIETHOADONBANHANG](
	[SoHoaDon] [int] NOT NULL FOREIGN KEY REFERENCES tblHOADONBANHANG(SoHoaDon),
	[MaMH] [int] NOT NULL FOREIGN KEY REFERENCES tblMATHANG(MaMH),
	[SoLuong] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	PRIMARY KEY ([SoHoaDon], [MaMH])
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tblBAOCAODOANHSO](
	[MaBaoCaoDoanhSo] [int] NOT NULL PRIMARY KEY,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TongDoanhThu] [money] NOT NULL,
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblBAOCAOTON](
	[MaBaoCaoTon] [int] NOT NULL PRIMARY KEY,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
 ) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblCHITIETBAOCAODOANHSO](
	[MaBaoCaoDoanhSo] [int] NOT NULL FOREIGN KEY REFERENCES tblBAOCAODOANHSO(MaBaoCaoDoanhSo),
	[MaMH] [int] NOT NULL FOREIGN KEY REFERENCES tblMATHANG(MaMH),
	[SoLuongBan] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[TiLe] [float] NOT NULL,
	PRIMARY KEY ([MaBaoCaoDoanhSo], [MaMH])
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblCHITIETBAOCAOTON](
	[MaBaoCaoTon] [int] NOT NULL FOREIGN KEY REFERENCES tblBAOCAOTON(MaBaoCaoTon),
	[MaMH] [int] FOREIGN KEY REFERENCES tblMATHANG(MaMH),
	[Ton] [int] NULL,
	[GiaVon] [money] NULL,
	[GiaBan] [money] NULL,
	PRIMARY KEY ([MaBaoCaoTon], [MaMH])
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tblCHITIETPHIEUXUATKHO](
	[MaSoPhieu] [int] NOT NULL FOREIGN KEY REFERENCES tblPHIEUXUATKHO(MaSoPhieu),
	[MaMH] [int] NOT NULL FOREIGN KEY REFERENCES tblMATHANG(MaMH),
	[SoLuongYeuCau] [int] NOT NULL,
	[SoLuongThucXuat] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	PRIMARY KEY ([MaSoPhieu], [MaMH])
) ON [PRIMARY]
GO
