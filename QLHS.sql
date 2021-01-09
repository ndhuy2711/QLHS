CREATE DATABASE QLHS
USE QLHS
GO

CREATE TABLE HOCSINH
(
	mahs nvarchar (15),
	hoten nvarchar(255),
	gioitinh nvarchar(15),
	ngaysinh date,
	email nvarchar(255),
	diachi nvarchar(255),
	primary key (mahs)
)

INSERT INTO HOCSINH 
VALUES ('HS01', N'Nguyễn Văn A', N'Nam', '1/1/1999', 'nva1999@gmail.com', N'123 Nam Kỳ Khởi Nghĩa, Phường Bến Nghé, Quận 1, TP.HCM')

select * from HOCSINH