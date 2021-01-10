CREATE DATABASE QLHS
USE QLHS
GO

CREATE TABLE HOCSINH
(
MaHocSinh nvarchar(10),
HoTen nvarchar (50),
GioiTinh nvarchar(3),
NgaySinh datetime,
DiaChi nvarchar(100),
Email nvarchar(100),
primary key (MaHocSinh)
)

CREATE TABLE MONHOC
(
MaMonHoc nvarchar(10),
TenMonHoc nvarchar(10),
primary key (MaMonHoc)
)

CREATE TABLE KHOILOP
(
MaKhoiLop nvarchar (10),
TenKhoiLop nvarchar(10),
primary key (MaKhoiLop)
)

CREATE TABLE HOCKI
(
MaHocKi int,
TenHocKi nvarchar(10),
primary key (MaHocKi)
)

CREATE TABLE DANHSACHLOP
(
MaLop nvarchar(10),
TenLop nvarchar(10),
SiSo int,
MaKhoiLop nvarchar(10),
primary key (MaLop)
)

CREATE TABLE CHITIETDSLOP
(
MaChiTietDSLop nvarchar(10),
MaLop nvarchar(10),
MaHocSinh nvarchar(10),
TBHocKi1 float,
TBHocKi2 float,
Primary key (MaChiTietDSLop)
)

CREATE TABLE BAOCAOTONGKETMON
(
MaBaoCaoMon nvarchar(10),
MaHocKi int,
MaLop nvarchar(10),
MaMon nvarchar(10),
SoLuongDatMon int,
TiLeDatMon float,
primary key (MaBaoCaoMon)
)

CREATE TABLE BAOCAOTONGKETHK
(
MaBaoCaoHK nvarchar(10),
MaHocKi nvarchar(10),
MaLop nvarchar(10),
SoLuongDat int,
TiLeDat float,
primary key (MaBaoCaoHK)
)

CREATE TABLE THAMSO
(
TuoiToiThieu int,
TuoiToiDa int,
SiSoToiDa int,
DiemDatMon float,
)

CREATE TABLE KETQUAHOCTAP
(
MaKetQua nvarchar(10),
MaChiTietDSLop nvarchar(10),
MaHocKi nvarchar(10),
DiemTBHocKi float,
primary key (MaKetQua)
)

CREATE TABLE BANGDIEM
(
MaBangDiem nvarchar(10),
MaHocSinh nvarchar(10),
MaMonHoc nvarchar(10),
Diem15phut float,
Diem1tiet float,
DiemCuoiKi float,
primary key (MaBangDiem)
)

