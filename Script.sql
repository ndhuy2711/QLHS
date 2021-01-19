﻿use QLHS
go

CREATE PROC DSLOP 
AS
BEGIN
	
	SELECT HS.MaHocSinh, HS.HoTen, KL.TenKhoiLop, DSL.TenLop
	FROM HOCSINH HS, KHOILOP KL, CHITIETDSLOP CTDSL, DANHSACHLOP DSL
	WHERE HS.MaHocSinh = CTDSL.MaHocSinh AND CTDSL.MaLop = DSL.MaLop AND DSL.MaKhoiLop = KL.MaKhoiLop
END

EXEC dbo.DSLOP
 go

 ------------------------
 CREATE PROC TIMKIEMHS 
AS
BEGIN
	
	SELECT HS.MaHocSinh, HS.HoTen, KL.TenKhoiLop, DSL.TenLop
	FROM HOCSINH HS, KHOILOP KL, CHITIETDSLOP CTDSL, DANHSACHLOP DSL
	WHERE HS.MaHocSinh = CTDSL.MaHocSinh AND CTDSL.MaLop = DSL.MaLop AND DSL.MaKhoiLop = KL.MaKhoiLop
END
--------------Tìm kiếm bằng MaHocSinh trong lớp--------------
CREATE PROC TIMHSBANGMA (@MaHocSinh nvarchar(10))
AS
BEGIN
	
	SELECT HS.MaHocSinh, HS.HoTen, HS.NgaySinh
	FROM HOCSINH HS, CHITIETDSLOP CTDSL
	WHERE HS.MaHocSinh = @MaHocSinh  AND HS.MaHocSinh = CTDSL.MaHocSinh
END

EXEC dbo.TIMHSBANGMA hs1
GO
------------------
ALTER PROC TIMKIEMDSHS
AS
BEGIN
	
	SELECT HS.MaHocSinh, HS.HoTen, DSL.TenLop, HS.GioiTinh, HS.NgaySinh, HS.Email, HS.DiaChi
	FROM HOCSINH HS, KHOILOP KL, CHITIETDSLOP CTDSL, DANHSACHLOP DSL
	WHERE HS.MaHocSinh = CTDSL.MaHocSinh AND CTDSL.MaLop = DSL.MaLop AND DSL.MaKhoiLop = KL.MaKhoiLop
END
GO
EXEC dbo.TIMKIEMDSHS

ALTER PROC TIMKIEMTHEOTEN
@TenHS nvarchar(50)
AS
BEGIN
	
	SELECT HS.MaHocSinh, HS.HoTen, DSL.TenLop, HS.GioiTinh, HS.NgaySinh, HS.Email, HS.DiaChi
	FROM HOCSINH HS, KHOILOP KL, CHITIETDSLOP CTDSL, DANHSACHLOP DSL
	WHERE HS.MaHocSinh = CTDSL.MaHocSinh AND CTDSL.MaLop = DSL.MaLop AND DSL.MaKhoiLop = KL.MaKhoiLop and HS.HoTen like N'%Nguyễn%'
END
GO
--------------------
CREATE PROC ThemHSVaoLop (@TenLop nvarchar (10))
AS
BEGIN
DECLARE @MaLop nvarchar(10)
SELECT DSL.MaLop
	FROM DANHSACHLOP DSL, CHITIETDSLOP CTDSL
	WHERE DSL.TenLop = '10A1'
INSERT INTO CHITIETDSLOP(MaLop) VALUES ( '@MaLop')
END

exec dbo.ThemHSVaoLop '10A1'
SELECT * FROM HOCSINH
SELECT * FROM CHITIETDSLOP
SELECT * FROM DANHSACHLOP;
SELECT * FROM KHOILOP

SELECT MaLop FROM DANHSACHLOP where MaKhoiLop = ''

---------------------------
SELECT * FROM BANGDIEM
SELECT * FROM MONHOC


select TenMonHoc from MONHOC
select * from KETQUAHOCTAP
SELECT * FROM BANGDIEM

DELETE FROM CHITIETDSLOP WHERE MaHocSinh = 'HS3'
DELETE FROM HOCSINH WHERE MaHocSinh = 'HS3'

select * from CHITIETDSLOP

select * from THAMSO
select * from hocki
select * from BAOCAOTONGKETHK
select * from BAOCAOTONGKETMON
select * from THAMSO
select * from HOCSINH
select * from BAOCAOTONGKETMON
select * from BAOCAOTONGKETHK
-- Store Proc Update Danh
CREATE 
--ALTER
PROC USP_CHITIETDSLOP
@Malop nvarchar(10),
@MaHS nvarchar(10)
AS
BEGIN
	UPDATE CHITIETDSLOP
	SET MaLop = @Malop
	WHERE MaHocSinh = @MaHS
END

EXEC USP_CHITIETDSLOP N'L1' , N'HS1'
select * from CHITIETDSLOP

CREATE FUNCTION UF_AUTO_MABD()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaBD varchar(10), @i INT = 2
	SET @MaBD = 'MBD0001'
	while exists(select * from BANGDIEM where MaBangDiem = @MaBD)
	BEGIN
		SET @MaBD = 'MBD' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@I as varchar(4))
		SET @i = @i + 1
	END
	RETURN @MaBD
END

PRINT dbo.UF_AUTO_MABD()
