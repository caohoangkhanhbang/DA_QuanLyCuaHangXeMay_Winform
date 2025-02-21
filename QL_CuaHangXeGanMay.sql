USE [master]
GO
/****** Object:  Database [QL_CuaHangXeGanMay]    Script Date: 29/11/2023 12:33:05 SA ******/
CREATE DATABASE [QL_CuaHangXeGanMay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_CuaHangXeGanMay', FILENAME = N'E:\QL_CuaHangXeGanMay.mdf' , SIZE = 9mb , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_CuaHangXeGanMay_log', FILENAME = N'E:\QL_CuaHangXeGanMay_log.ldf' , SIZE = 9mb , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )

GO


IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_CuaHangXeGanMay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET  MULTI_USER 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

USE [QL_CuaHangXeGanMay]
GO
/****** Object:  User [Admin]    Script Date: 29/11/2023 12:33:06 SA ******/

/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [nvarchar](50) NOT NULL,
	[SoKhungXe] [nchar](50) NOT NULL,
	[GiamGia] [real] NULL,
	[DonGia] [bigint] NOT NULL,
	[ThanhTien] [bigint] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[SoKhungXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [nvarchar](50) NOT NULL,
	[SoKhungXe] [nchar](50) NOT NULL,
	[SoMay] [nchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaLoaiXeGanMay] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[SoKhungXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DongXe]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DongXe](
	[madongxe] [nchar](10) NOT NULL,
	[tendongxe] [nvarchar](50) NOT NULL,
	[tinhnang] [nvarchar](max) NULL,
	[phankhoi] [nchar](10) NOT NULL,
	[maloai] [nchar](10) NOT NULL,
	[mahang] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DongXe] PRIMARY KEY CLUSTERED 
(
	[madongxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = On) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangXe]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nchar](10) NOT NULL,
	[SoDienThoai] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_HangXe] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThucThanhToan]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThucThanhToan](
	[MaHinhThuc] [nchar](10) NOT NULL,
	[TenHinhThuc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HinhThucThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaHinhThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](50) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[MaHinhThuc] [nchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_HD] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaLoaiXe] [nchar](10) NOT NULL,
	[TenLoaiXe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[MaLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXeGanMay]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXeGanMay](
	[MaLoaiXeGanMay] [nchar](10) NOT NULL,
	[TenXe] [nvarchar](50) NOT NULL,
	[MaDongXe] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[TenLoai] [nvarchar](50) NULL,
	[NamSanXuat] [date] NOT NULL,
	[MauSac] [nvarchar](50) NOT NULL,
	[GiaBan] [int] NOT NULL,
	[Anh] [nvarchar](max) NULL,
 CONSTRAINT [PK_XeGanMay] PRIMARY KEY CLUSTERED 
(
	[MaLoaiXeGanMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[SoDienThoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[Sodienthoai] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVienBanHang]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienBanHang](
	[MaNhanVien] [nchar](10) NOT NULL,
	[Luong] [float] NOT NULL,
	[DoanhSo] [int] NULL,
 CONSTRAINT [PK_NhanVienBanHang] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanKhoi]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanKhoi](
	[MaPhanKhoi] [nchar](10) NOT NULL,
	[TenPhanKhoi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PhanKhoi] PRIMARY KEY CLUSTERED 
(
	[MaPhanKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [nvarchar](50) NOT NULL,
	[MaNhaCungCap] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_PN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLy]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLy](
	[MaNhanVien] [nchar](10) NOT NULL,
	[Luong] [float] NOT NULL,
	[Thuong] [float] NOT NULL,
 CONSTRAINT [PK_QuanLy] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](150) NOT NULL,
	[TenHienThi] [nvarchar](250) NULL,
	[MatKhau] [varchar](250) NULL,
	[Quyen] [nvarchar](250) NULL,
	[Email] [varchar](550) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = On) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 29/11/2023 12:33:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[SoKhung] [nchar](50) NOT NULL,
	[SoMay] [nchar](50) NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaLoaiXeGanMay] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[SoKhung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [SoKhungXe], [SoMay], [DonGia], [MaLoaiXeGanMay]) VALUES (N'PN14112023_181625', N'LA00192                                           ', N'BA-0029                                           ', 36000000, N'LX0001    ')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [SoKhungXe], [SoMay], [DonGia], [MaLoaiXeGanMay]) VALUES (N'PN7112023_131811', N'LA001-BH001                                       ', N'BH001-000                                         ', 35500000, N'LX0001    ')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [SoKhungXe], [SoMay], [DonGia], [MaLoaiXeGanMay]) VALUES (N'PN7112023_131811', N'LA002-BH001                                       ', N'BH0001-0001                                       ', 35000000, N'LX0001    ')
GO
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0001    ', N'Vision    ', N'Ngồi êm ái', N'PK0002    ', N'TG        ', N'H0001     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0002    ', N'Exciter 155 VVA', N'Van Biến Thiên, Nồi TRống Trượt', N'PK0004    ', N'TC        ', N'H0002     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0003    ', N'Exciter 150', N'Màn Hình LCD', N'PK0003    ', N'TC        ', N'H0002     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0004    ', N'Air Blade 125', N'Ngồi Êm', N'PK0002    ', N'TG        ', N'H0001     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0005    ', N'Air Blade 150', N'', N'PK0003    ', N'TG        ', N'H0001     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0006    ', N'Sirus Fi', N'Tiết Kiệm Xăng', N'PK0001    ', N'XS        ', N'H0002     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0007    ', N'Future Fi', N'Bền Bỉ', N'PK0002    ', N'XS        ', N'H0001     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0008    ', N'Wave Alpha', N'Nhẹ', N'PK0001    ', N'XS        ', N'H0001     ')
INSERT [dbo].[DongXe] ([madongxe], [tendongxe], [tinhnang], [phankhoi], [maloai], [mahang]) VALUES (N'DX0009    ', N'Vinfast Vento', N'Tiết kiệm năng lượng', N'PK0002    ', N'XD        ', N'H0005     ')
GO
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [SoDienThoai], [DiaChi], [Logo]) VALUES (N'H0001     ', N'HonDa     ', N'0292846537', N'Quận 5 TP Hồ Chí Minh', N'tải xuống.png')
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [SoDienThoai], [DiaChi], [Logo]) VALUES (N'H0002     ', N'Yamaha    ', N'0917535847', N'Đống Đa, Hà Nội', N'yamaha.png')
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [SoDienThoai], [DiaChi], [Logo]) VALUES (N'H0003     ', N'SYM       ', N'0919111922', N'Thành Phố Đà Nẳng', N'sym.png')
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [SoDienThoai], [DiaChi], [Logo]) VALUES (N'H0004     ', N'Suzuki    ', N'053284792', N'Quận 8 TP Hồ Chí Minh', N'suzuki.png')
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [SoDienThoai], [DiaChi], [Logo]) VALUES (N'H0005     ', N'Vinfast   ', N'09828182882', N'TP Hồ Chí Minh', N'vinfast.png')
GO
INSERT [dbo].[HinhThucThanhToan] ([MaHinhThuc], [TenHinhThuc]) VALUES (N'HT01      ', N'Tiền Mặt')
INSERT [dbo].[HinhThucThanhToan] ([MaHinhThuc], [TenHinhThuc]) VALUES (N'HT02      ', N'Internet Banking')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [MaHinhThuc], [NgayLap], [TongTien]) VALUES (N'HD14112023_194922', N'KH03      ', N'NV03      ', N'HT02      ', CAST(N'2023-11-14' AS Date), 0)
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH01      ', N'Nguyễn Tấn Tài', N'Huyện Cần Giuoc,Tỉnh Long An', N'0780599466')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH02      ', N'Nguyễn Huỳnh Như', N'Quận 5, TP Hồ Chí Minh', N'0866332556')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH03      ', N'Vũ Thị Cát', N'Bến Lức, Long An', N'0919776112')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH04      ', N'Huỳnh Thanh Tú', N'Cần Gio TP Hồ Chí Minh', N'(092) 772-8543')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH05      ', N'Vũ Như Khanh', N'Quận 12 Thành Phố Hồ Chí Minh', N'(091) 264-8483')
GO
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'MT        ', N'Moto')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'TC        ', N'Tay Côn')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'TG        ', N'Tay Ga')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'XD        ', N'Xe Điện')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'XDD       ', N'Xe Đạp ')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'XL        ', N'Xe Lăn')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe]) VALUES (N'XS        ', N'Xe Số')
GO
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0001    ', N'Vison bảng tiêu chuẩn 2023', N'DX0001    ', N'HonDa     ', N'Tay Ga', CAST(N'2023-10-20' AS Date), N'Đen Bóng', 35000000, N'vision.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0002    ', N'Exciter 155 Bảng Cao Cấp 2022', N'DX0002    ', N'Yamaha    ', N'Tay Côn', CAST(N'2022-02-20' AS Date), N'Xám Xi Măng', 42000000, N'ex155.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0003    ', N'Vison bảng cao cấp 2023', N'DX0001    ', N'HonDa     ', N'Tay Ga', CAST(N'2023-10-20' AS Date), N'Xám', 37000000, N'vison_bcc_2023.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0004    ', N'Exciter 150 2022', N'DX0003    ', N'Yamaha    ', N'Tay Côn', CAST(N'2022-05-15' AS Date), N'Xám Đỏ', 41000000, N'ex150.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0005    ', N'Aỉ Blade 150 2023', N'DX0005    ', N'HonDa     ', N'Tay Ga', CAST(N'2023-10-05' AS Date), N'Xanh Nhám', 45000000, N'ab160_2023.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0006    ', N'Wave Alpha 110 2023', N'DX0008    ', N'HonDa     ', N'Xe Số', CAST(N'2023-09-20' AS Date), N'Đen Nhám', 19000000, N'wave2023.jpeg')
INSERT [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay], [TenXe], [MaDongXe], [TenHang], [TenLoai], [NamSanXuat], [MauSac], [GiaBan], [Anh]) VALUES (N'LX0007    ', N'Sirus Fi 2023', N'DX0006    ', N'Yamaha    ', N'Xe Số', CAST(N'2023-02-15' AS Date), N'Đen Bóng', 22000000, N'sirusfi_2023.jpeg')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [Ten], [DiaChi], [SoDienThoai]) VALUES (N'NCC01     ', N'Mô Tô Mã Lực', N'Tân Bình', N'0298929291')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [Ten], [DiaChi], [SoDienThoai]) VALUES (N'NCC02     ', N'SX Phụ Tùng An Khánh', N'An Giang', N'02828282929')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [Ten], [DiaChi], [SoDienThoai]) VALUES (N'NCC03     ', N'Công Ty TNHH MTV Xe Máy Nhập Khẩu Sài Gòn', N'Quận 5 TP Hồ chí Minh', N'092928382')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [Ten], [DiaChi], [SoDienThoai]) VALUES (N'NCC04     ', N'Xe Máy Công Thành', N'Hóc Môn TP Hồ Chí Minh', N'0111888800')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [Ten], [DiaChi], [SoDienThoai]) VALUES (N'NCC05     ', N'Cty XNK Xe Máy Sài Gòn', N'Quận 5 TP Hồ Chí Minh', N'033499176')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV00      ', N'Cao Hoàng Khánh Băng', N'38383822992', N'Quận Tân Bình')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV01      ', N'Đào Thị Hồng', N'0919847732', N'Quận 12 Tp Hồ Chí Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV02      ', N'Nguyễn Chí Tài', N'0821275784', N'Quận Tân Phú Tp Hồ Chí Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV03      ', N'Trần Kim Anh', N'023937773', N'Huyện Nhà Bè')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV04      ', N'Nguyễn Tuyết Mai', N'038383822992', N'Quận Tân Bình')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV05      ', N'Huỳnh Thanh Nhã', N'0919864732', N'Quận 3 TP Hồ Chí Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV06      ', N'Cao Hoàng Khánh Băng', N'582370529', N'Mang Thít Vĩnh Long')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV07      ', N'Đào Thị Thắm', N'992929102', N'Quận 4')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [Sodienthoai], [DiaChi]) VALUES (N'NV08      ', N'Huỳnh Văn Dũng', N'929291284', N'Cần Đước Tỉnh Long An')
GO
INSERT [dbo].[NhanVienBanHang] ([MaNhanVien], [Luong], [DoanhSo]) VALUES (N'NV01      ', 6500000, 30)
INSERT [dbo].[NhanVienBanHang] ([MaNhanVien], [Luong], [DoanhSo]) VALUES (N'NV03      ', 7000000, 50)
INSERT [dbo].[NhanVienBanHang] ([MaNhanVien], [Luong], [DoanhSo]) VALUES (N'NV07      ', 8000000, 20)
INSERT [dbo].[NhanVienBanHang] ([MaNhanVien], [Luong], [DoanhSo]) VALUES (N'NV08      ', 7000000, 20)
GO
INSERT [dbo].[PhanKhoi] ([MaPhanKhoi], [TenPhanKhoi]) VALUES (N'PK0001    ', N'110cc     ')
INSERT [dbo].[PhanKhoi] ([MaPhanKhoi], [TenPhanKhoi]) VALUES (N'PK0002    ', N'125cc     ')
INSERT [dbo].[PhanKhoi] ([MaPhanKhoi], [TenPhanKhoi]) VALUES (N'PK0003    ', N'150cc     ')
INSERT [dbo].[PhanKhoi] ([MaPhanKhoi], [TenPhanKhoi]) VALUES (N'PK0004    ', N'155cc     ')
INSERT [dbo].[PhanKhoi] ([MaPhanKhoi], [TenPhanKhoi]) VALUES (N'PK0005    ', N'160cc     ')
GO
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien]) VALUES (N'PN14112023_181625', N'NCC02     ', N'NV05      ', CAST(N'2023-11-14' AS Date), 36000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien]) VALUES (N'PN7112023_131811', N'NCC02     ', N'NV04      ', CAST(N'2023-11-07' AS Date), 140500000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [MaNhanVien], [NgayLap], [TongTien]) VALUES (N'PN7112023_144152', N'NCC02     ', N'NV04      ', CAST(N'2023-11-07' AS Date), 0)
GO
INSERT [dbo].[QuanLy] ([MaNhanVien], [Luong], [Thuong]) VALUES (N'NV04      ', 20000000, 5000000)
INSERT [dbo].[QuanLy] ([MaNhanVien], [Luong], [Thuong]) VALUES (N'NV05      ', 12500000, 2000000)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [Quyen], [Email]) VALUES (N'aaaaaa', N'aaaaaa', N'1962026656160185351301320480154111117132155', N'nguoiDung', N'abc@gmail.com')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [Quyen], [Email]) VALUES (N'Bang', N'Quản trị viên', N'1962026656160185351301320480154111117132155', N'Admin', N'admin@gmail.com')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [Quyen], [Email]) VALUES (N'BangCao', N'BangCao', N'1962026656160185351301320480154111117132155', N'nguoiDung', N'an@gmail.com')
GO
INSERT [dbo].[Xe] ([SoKhung], [SoMay], [TinhTrang], [MaLoaiXeGanMay]) VALUES (N'LA00192                                           ', N'BA-0029                                           ', N'chưa bán', N'LX0001    ')
INSERT [dbo].[Xe] ([SoKhung], [SoMay], [TinhTrang], [MaLoaiXeGanMay]) VALUES (N'LA001-BH001                                       ', N'BH001-000                                         ', N'chưa bán', N'LX0001    ')
INSERT [dbo].[Xe] ([SoKhung], [SoMay], [TinhTrang], [MaLoaiXeGanMay]) VALUES (N'LA002-BH001                                       ', N'BH0001-0001                                       ', N'chưa bán', N'LX0001    ')
GO
ALTER TABLE [dbo].[Xe] ADD  CONSTRAINT [df_tinhtrang]  DEFAULT (N'chưa bán') FOR [TinhTrang]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Xe] FOREIGN KEY([SoKhungXe])
REFERENCES [dbo].[Xe] ([SoKhung])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Xe]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LoaiXeGanMay] FOREIGN KEY([MaLoaiXeGanMay])
REFERENCES [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LoaiXeGanMay]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_HD] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_HD]
GO
ALTER TABLE [dbo].[DongXe]  WITH CHECK ADD  CONSTRAINT [FK_DongXe_HangXe] FOREIGN KEY([mahang])
REFERENCES [dbo].[HangXe] ([MaHang])
GO
ALTER TABLE [dbo].[DongXe] CHECK CONSTRAINT [FK_DongXe_HangXe]
GO
ALTER TABLE [dbo].[DongXe]  WITH CHECK ADD  CONSTRAINT [FK_DongXe_LoaiXe] FOREIGN KEY([maloai])
REFERENCES [dbo].[LoaiXe] ([MaLoaiXe])
GO
ALTER TABLE [dbo].[DongXe] CHECK CONSTRAINT [FK_DongXe_LoaiXe]
GO
ALTER TABLE [dbo].[DongXe]  WITH CHECK ADD  CONSTRAINT [FK_DongXe_PhanKhoi] FOREIGN KEY([phankhoi])
REFERENCES [dbo].[PhanKhoi] ([MaPhanKhoi])
GO
ALTER TABLE [dbo].[DongXe] CHECK CONSTRAINT [FK_DongXe_PhanKhoi]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HT_HD] FOREIGN KEY([MaHinhThuc])
REFERENCES [dbo].[HinhThucThanhToan] ([MaHinhThuc])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HT_HD]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KH_HD] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KH_HD]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_NV_HD] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVienBanHang] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_NV_HD]
GO
ALTER TABLE [dbo].[LoaiXeGanMay]  WITH CHECK ADD  CONSTRAINT [FK_LoaiXeGanMay_DongXe] FOREIGN KEY([MaDongXe])
REFERENCES [dbo].[DongXe] ([madongxe])
GO
ALTER TABLE [dbo].[LoaiXeGanMay] CHECK CONSTRAINT [FK_LoaiXeGanMay_DongXe]
GO
ALTER TABLE [dbo].[NhanVienBanHang]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienBanHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NhanVienBanHang] CHECK CONSTRAINT [FK_NhanVienBanHang_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_NCC_PN] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_NCC_PN]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_NV_PN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[QuanLy] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_NV_PN]
GO
ALTER TABLE [dbo].[QuanLy]  WITH CHECK ADD  CONSTRAINT [FK_QuanLy_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[QuanLy] CHECK CONSTRAINT [FK_QuanLy_NhanVien]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_LoaiXeGanMay] FOREIGN KEY([MaLoaiXeGanMay])
REFERENCES [dbo].[LoaiXeGanMay] ([MaLoaiXeGanMay])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_LoaiXeGanMay]
GO
USE [master]
GO
ALTER DATABASE [QL_CuaHangXeGanMay] SET  READ_WRITE 
GO
