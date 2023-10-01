﻿CREATE DATABASE PLANE_TICKET
go

USE PLANE_TICKET
GO

SET DATEFORMAT DMY
GO

CREATE TABLE SANBAY
(
	MASANBAY VARCHAR(10) PRIMARY KEY,
	TENSANBAY NVARCHAR(100) NOT NULL,
	TENTHANHPHO NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE HANGMAYBAY
(
	MAHANGMB VARCHAR(10) PRIMARY KEY,
	TENHANGMB NVARCHAR(50) NOT NULL
)

GO
CREATE TABLE MAYBAY
(

	MAMAYBAY VARCHAR(10) PRIMARY KEY,
	MAHANGMB VARCHAR(10) NOT NULL,
	SOLUONGGHE INT NOT NULL
	CONSTRAINT FK_HANGMAYBAY_MAYBAY FOREIGN KEY(MAHANGMB) REFERENCES HANGMAYBAY(MAHANGMB)
)
GO

CREATE TABLE TUYENBAY
(
	MATUYENBAY VARCHAR(10) PRIMARY KEY,
	MASANBAYDI VARCHAR(10) NOT NULL,
	MASANBAYDEN VARCHAR(10) NOT NULL,
	CONSTRAINT UQ_TUYENBAY UNIQUE(MASANBAYDI,MASANBAYDEN)
)
GO
CREATE TABLE CHUYENBAY
(
	MACHUYENBAY VARCHAR(10) PRIMARY KEY,
	MATUYENBAY VARCHAR(10) NOT NULL,
	MAMAYBAY VARCHAR(10) NOT NULL,
	THOIGIANKHOIHANH DATETIME NOT NULL,
	THOIGIANDEN DATETIME NOT NULL,
	THOIGIANBAY FLOAT NOT NULL
	CONSTRAINT FK_CHUYENBAY_TUYENBAY FOREIGN KEY(MATUYENBAY) REFERENCES TUYENBAY(MATUYENBAY),
	CONSTRAINT FK_CHUYENBAY_MAYBAY FOREIGN KEY(MAMAYBAY) REFERENCES MAYBAY(MAMAYBAY)
)
GO
CREATE TABLE CTCHUYENBAY
(
	MACHUYENBAY VARCHAR(10),
	MASANBAYTG VARCHAR(10),
	THOIGIANDUNG FLOAT NOT NULL,
	GHICHU NVARCHAR(100)
	CONSTRAINT PK_CTCHUYENBAY PRIMARY KEY(MACHUYENBAY, MASANBAYTG),
	CONSTRAINT FK_CTCHUYENBAY_CHUYENBAY FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
)
go
CREATE TABLE HANGVE
(
	MAHANGVE VARCHAR(10) PRIMARY KEY,
	TENHANGVE NVARCHAR(20) NOT NULL UNIQUE,
	LEPHIHOAN DECIMAL NOT NULL,
	LEPHIDOI DECIMAL NOT NULL
)
GO

CREATE TABLE DONGIA
(
	MATUYENBAY VARCHAR(10),
	MAHANGVE VARCHAR(10),
	DONGIA DECIMAL NOT NULL
	CONSTRAINT PK_DONGIA PRIMARY KEY(MATUYENBAY, MAHANGVE)
	CONSTRAINT FK_DONGIA_TUYENBAY FOREIGN KEY(MATUYENBAY) REFERENCES TUYENBAY(MATUYENBAY),
	CONSTRAINT FK_DONGIA_HANGVE FOREIGN KEY(MAHANGVE) REFERENCES HANGVE(MAHANGVE)
)
GO
CREATE TABLE TINHTRANGVE
(
	MACHUYENBAY VARCHAR(10),
	MAHANGVE VARCHAR(10),
	TONGSOGHE INT NOT NULL,
	SOGHETRONG INT NOT NULL,
	CONSTRAINT PK_TINHTRANGVE PRIMARY KEY(MACHUYENBAY, MAHANGVE),
	CONSTRAINT FK_TINHTRANGVE_CHUYENBAY FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	CONSTRAINT FK_TINHTRANGVE_HANGVE FOREIGN KEY(MAHANGVE) REFERENCES HANGVE(MAHANGVE)
)
GO
CREATE TABLE KHACHHANG
(
	MAKHACHHANG VARCHAR(10) PRIMARY KEY,
	TENKHACHHANG NVARCHAR(100) NOT NULL,
	CMND NVARCHAR(20) NOT NULL UNIQUE,
	SDT NVARCHAR(15)
)
GO
CREATE TABLE NHANVIEN
(
	MANHANVIEN VARCHAR(10) PRIMARY KEY,
	TENNHANVIEN NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE DOANHTHUNAM
(
	NAM VARCHAR(5) PRIMARY KEY,
	DOANHTHU DECIMAL NOT NULL
)
GO

CREATE TABLE DOANHTHUTHANG
(
	THANG VARCHAR(3),
	NAM VARCHAR(5),
	SOCHUYENBAY INT NOT NULL,
	DOANHTHU DECIMAL NOT NULL
	CONSTRAINT PK_DOANHTHUTHANG PRIMARY KEY(THANG,NAM),
	CONSTRAINT FK_DOANHTHUTHANG_DOANHTHUNAM FOREIGN KEY(NAM) REFERENCES DOANHTHUNAM(NAM)
)
GO

CREATE TABLE CTDOANHTHUTHANG
(
	THANG VARCHAR(3),
	NAM VARCHAR(5),
	MACHUYENBAY VARCHAR(10),
	SOVEBANDUOC INT NOT NULL,
	DOANHTHU DECIMAL NOT NULL
	CONSTRAINT PK_CTDOANHTHUTHANG PRIMARY KEY(THANG, NAM, MACHUYENBAY),
	CONSTRAINT FK_CTDOANHTHUTHANG_DOANHTHUTHANG FOREIGN KEY(THANG, NAM) REFERENCES DOANHTHUTHANG(THANG, NAM),
	CONSTRAINT FK_CTDOANHTHUTHANG_CHUYENBAY FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY)
)
GO
CREATE TABLE VECHUYENBAY
(
	MAVE VARCHAR(10) PRIMARY KEY,
	MAKHACHHANG VARCHAR(10),
	MACHUYENBAY VARCHAR(10),
	MAHANGVE VARCHAR(10) NOT NULL,
	GIATIEN DECIMAL NOT NULL,
	NGAYHUY DATE,
	MANHANVIEN VARCHAR(10),
	NGAYGIOGD DATETIME,
	LOAIVE NVARCHAR(20)
	CONSTRAINT FK_VECHUYENBAY_KHACHHANG FOREIGN KEY(MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	CONSTRAINT FK_VECHUYENBAY_CHUYENBAY FOREIGN KEY(MACHUYENBAY) REFERENCES CHUYENBAY(MACHUYENBAY),
	CONSTRAINT FK_VECHUYENBAY_HANGVE FOREIGN KEY(MAHANGVE) REFERENCES HANGVE(MAHANGVE),
	CONSTRAINT FK_VECHUYENBAY_NHANVIEN FOREIGN KEY(MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN)
)
GO

CREATE TABLE ACCOUNT
(
	USERNAME VARCHAR(20) PRIMARY KEY,
	PASSWORD VARCHAR(10) NOT NULL,
	MANHANVIEN VARCHAR(10) NOT NULL,
	TYPE nvarchar(30) NOT NULL
	CONSTRAINT FK_ACCOUNT_NHANVIEN FOREIGN KEY(MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN)
)
GO
--------------------------------------------TRIGGER---------------------------------------------------
CREATE TRIGGER INSERT_DOANHTHUNAM_WHEN_INSERT_CHUYENBAY
ON CHUYENBAY
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUNAM WHERE NAM=@NAM)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES(@NAM, 0)
	END
END
GO

CREATE TRIGGER INSERT_DOANHTHUNAM_WHEN_UPDATE_CHUYENBAY
ON CHUYENBAY
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUNAM WHERE NAM=@NAM)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES(@NAM, 0)
	END
END
GO

CREATE TRIGGER INSERT_DOANHTHUTHANG_WHEN_INSERT_CHUYENBAY
ON CHUYENBAY
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES(@THANG, @NAM, 0, 0)
	END
END
GO


CREATE TRIGGER INSERT_DOANHTHUTHANG_WHEN_UPDATE_CHUYENBAY
ON CHUYENBAY
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM DOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES(@THANG, @NAM, 0, 0)
	END
END
GO


CREATE TRIGGER INSERT_CTDOANHTHUTHANG_WHEN_INSERT_CHUYENBAY
ON CHUYENBAY
FOR INSERT
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @MACHUYENBAY VARCHAR(10)= (SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG AND MACHUYENBAY=@MACHUYENBAY)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO CTDOANHTHUTHANG(THANG, NAM, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES(@THANG, @NAM, @MACHUYENBAY, 0, 0)
	END
END
GO


CREATE TRIGGER INSERT_CTDOANHTHUTHANG_WHEN_UPDATE_CHUYENBAY
ON CHUYENBAY
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)= (SELECT YEAR(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @THANG VARCHAR(5)= (SELECT MONTH(THOIGIANKHOIHANH) FROM INSERTED)
	DECLARE @MACHUYENBAY VARCHAR(10)= (SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @COUNT INT = (SELECT COUNT(*) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG AND MACHUYENBAY=@MACHUYENBAY)
	IF(@COUNT=0)
	BEGIN
		INSERT INTO CTDOANHTHUTHANG(THANG, NAM, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES(@THANG, @NAM, @MACHUYENBAY, 0, 0)
	END
END
GO

CREATE TRIGGER INSERT_CTDOANHTHUTHANG_WHEN_INSERT_VECHUYENBAY
ON VECHUYENBAY
FOR INSERT
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @GIATIEN DECIMAL =(SELECT GIATIEN FROM INSERTED)
	DECLARE @SOVEBANDUOC INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACHUYENBAY=@MACHUYENBAY)
	UPDATE CTDOANHTHUTHANG SET DOANHTHU+=@GIATIEN, SOVEBANDUOC=@SOVEBANDUOC WHERE MACHUYENBAY=@MACHUYENBAY
END
GO

CREATE TRIGGER UPDATE_CTDOANHTHUTHANG_WHEN_DELETE_VECHUYENBAY
ON VECHUYENBAY
FOR DELETE
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM deleted)
	DECLARE @GIATIEN DECIMAL =(SELECT GIATIEN FROM deleted)
	DECLARE @SOVEBANDUOC INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACHUYENBAY=@MACHUYENBAY)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHANGVE FROM deleted)
	DECLARE @LEPHIHOAN DECIMAL =(SELECT LEPHIHOAN FROM HANGVE H, deleted WHERE deleted.MAHANGVE=H.MAHANGVE and deleted.MAHANGVE=@MAHANGVE and deleted.MACHUYENBAY=@MACHUYENBAY)
	UPDATE CTDOANHTHUTHANG SET DOANHTHU=DOANHTHU - @GIATIEN + @LEPHIHOAN , SOVEBANDUOC=@SOVEBANDUOC WHERE MACHUYENBAY=@MACHUYENBAY
END
GO

CREATE TRIGGER UPDATE_CTDOANHTHUTHANG_WHEN_UPDATE_VECHUYENBAY
ON VECHUYENBAY
FOR UPDATE
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM deleted)
	DECLARE @GIATIEN DECIMAL =(SELECT GIATIEN FROM deleted)
	DECLARE @MACHUYENBAY1 VARCHAR(10)=(SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @GIATIEN1 DECIMAL =(SELECT GIATIEN FROM INSERTED)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHANGVE FROM deleted)
	DECLARE @LEPHIDOI DECIMAL =(SELECT LEPHIDOI FROM HANGVE H, deleted WHERE deleted.MAHANGVE=H.MAHANGVE and deleted.MAHANGVE=@MAHANGVE and deleted.MACHUYENBAY=@MACHUYENBAY)
	UPDATE CTDOANHTHUTHANG SET DOANHTHU=DOANHTHU-@GIATIEN+@LEPHIDOI,SOVEBANDUOC-=1 WHERE MACHUYENBAY=@MACHUYENBAY
	UPDATE CTDOANHTHUTHANG SET DOANHTHU+=@GIATIEN1,SOVEBANDUOC+=1 WHERE MACHUYENBAY=@MACHUYENBAY1
END
GO

CREATE TRIGGER UPDATE_DOANHTHUTHANG_WHEN_UPDATE_CTDOANHTHUTHANG
ON CTDOANHTHUTHANG
FOR UPDATE
AS
BEGIN
	DECLARE @THANG VARCHAR(3)=(SELECT THANG FROM INSERTED)
	DECLARE @NAM VARCHAR(5)=(SELECT NAM FROM INSERTED)
	DECLARE @DOANHTHU DECIMAL =(SELECT SUM(DOANHTHU) FROM CTDOANHTHUTHANG WHERE NAM=@NAM AND THANG=@THANG)
	DECLARE @SOCHUYENBAY INT =(SELECT COUNT(MACHUYENBAY) FROM CHUYENBAY WHERE YEAR(THOIGIANKHOIHANH)=@NAM AND MONTH(THOIGIANKHOIHANH)=@THANG)
	UPDATE DOANHTHUTHANG SET DOANHTHU=@DOANHTHU, SOCHUYENBAY=@SOCHUYENBAY WHERE NAM=@NAM AND THANG=@THANG
END
GO

CREATE TRIGGER UPDATE_DOANHTHUNAM_WHEN_UPDATE_DOANHTHUTHANG
ON DOANHTHUTHANG
FOR UPDATE
AS
BEGIN
	DECLARE @NAM VARCHAR(5)=(SELECT NAM FROM INSERTED)
	DECLARE @DOANHTHU DECIMAL =(SELECT SUM(DOANHTHU) FROM DOANHTHUTHANG WHERE NAM=@NAM)
	UPDATE DOANHTHUNAM SET DOANHTHU=@DOANHTHU WHERE NAM=@NAM
END
GO

CREATE TRIGGER UPDATE_TINHTRANGVE_WHEN_INSERT_VECHUYENBAY
ON VECHUYENBAY
FOR INSERT
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHANGVE FROM INSERTED)
	DECLARE @TONGSOGHE INT =(SELECT TONGSOGHE FROM TINHTRANGVE WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE)
	DECLARE @SOGHEMUA INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE)
	UPDATE TINHTRANGVE SET SOGHETRONG=@TONGSOGHE-@SOGHEMUA WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE
END
GO

GO
CREATE TRIGGER UPDATE_TINHTRANGVE_WHEN_DELETE_VECHUYENBAY
ON VECHUYENBAY
FOR DELETE
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM deleted)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHANGVE FROM deleted)
	DECLARE @SOGHEMUA INT =(SELECT COUNT(MAVE) FROM deleted WHERE deleted.MACHUYENBAY=@MACHUYENBAY AND deleted.MAHANGVE=@MAHANGVE)
	UPDATE TINHTRANGVE SET SOGHETRONG+=@SOGHEMUA WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE
END
GO

CREATE TRIGGER UPDATE_TINHTRANGVE_WHEN_UPDATE_VECHUYENBAY
ON VECHUYENBAY
FOR UPDATE
AS
BEGIN
	DECLARE @MACHUYENBAY VARCHAR(10)=(SELECT MACHUYENBAY FROM INSERTED)
	DECLARE @MAHANGVE VARCHAR(10)=(SELECT MAHANGVE FROM INSERTED)
	DECLARE @MACHUYENBAY1 VARCHAR(10)=(SELECT MACHUYENBAY FROM deleted)
	DECLARE @MAHANGVE1 VARCHAR(10)=(SELECT MAHANGVE FROM deleted)
	DECLARE @TONGSOGHE INT =(SELECT TONGSOGHE FROM TINHTRANGVE WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE)
	DECLARE @SOGHEMUA INT =(SELECT COUNT(MAVE) FROM VECHUYENBAY WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE)
	DECLARE @SOGHEHUY INT =(SELECT COUNT(MAVE) FROM deleted WHERE deleted.MACHUYENBAY=@MACHUYENBAY1 AND deleted.MAHANGVE=@MAHANGVE1)
	UPDATE TINHTRANGVE SET SOGHETRONG=@TONGSOGHE-@SOGHEMUA WHERE MACHUYENBAY=@MACHUYENBAY AND MAHANGVE=@MAHANGVE
	UPDATE TINHTRANGVE SET SOGHETRONG+=@SOGHEHUY WHERE MACHUYENBAY=@MACHUYENBAY1 AND MAHANGVE=@MAHANGVE1
END
GO


SELECT C.MACHUYENBAY, T.MATUYENBAY, S.TENSANBAY,S1.TENSANBAY, C.THOIGIANKHOIHANH ,C.THOIGIANDEN,C.THOIGIANBAY, H.TENHANGVE, CAST(ROUND(D.DONGIA/2,2) as decimal (18,0)) as [DONGIA]
FROM TUYENBAY T INNER JOIN CHUYENBAY C ON T.MATUYENBAY=C.MATUYENBAY INNER JOIN DONGIA D ON T.MATUYENBAY=D.MATUYENBAY INNER JOIN SANBAY S ON S.MASANBAY=T.MASANBAYDI INNER JOIN SANBAY S1 ON S1.MASANBAY=T.MASANBAYDEN INNER JOIN HANGVE H ON H.MAHANGVE=D.MAHANGVE INNER JOIN MAYBAY M ON M.MAMAYBAY = C.MAMAYBAY
WHERE S.TENSANBAY LIKE N'Chu Lai' AND S1.TENSANBAY LIKE N'Tân Sân Nhất' AND H.MAHANGVE = N'VETG' AND M.MAHANGMB = 'VSA'
GROUP BY C.MACHUYENBAY, T.MATUYENBAY, S.TENSANBAY,S1.TENSANBAY, C.THOIGIANKHOIHANH ,C.THOIGIANDEN,C.THOIGIANBAY, H.TENHANGVE,D.DONGIA
Having  CAST(C.THOIGIANKHOIHANH AS DATE) <= (SELECT DATEADD(DAY,3,CAST(C.THOIGIANKHOIHANH AS DATE))
								FROM CHUYENBAY C WHERE C.MACHUYENBAY = 'CB223') AND CAST(C.THOIGIANKHOIHANH AS DATE) > (SELECT CAST(C.THOIGIANKHOIHANH AS DATE)
								FROM CHUYENBAY C WHERE C.MACHUYENBAY = 'CB223')

GO

go
create proc HoaDon
@MaVe VARCHAR(10)
as
begin
	select TENKHACHHANG, SDT, CMND, MAVE,v.MAKHACHHANG, v.MACHUYENBAY, h.TENHANGVE, v.NGAYGIOGD, v.GIATIEN, n.TENNHANVIEN, c.THOIGIANKHOIHANH, c.THOIGIANDEN, LOAIVE, TENHANGMB
	from VECHUYENBAY as v, KHACHHANG as k, HANGVE as h,  NHANVIEN as n, CHUYENBAY as c,MAYBAY as m, HANGMAYBAY as hmb 
	where  v.MACHUYENBAY = c.MACHUYENBAY and v.MAKHACHHANG = k.MAKHACHHANG and v.MAHANGVE=h.MAHANGVE and v.MANHANVIEN = n.MANHANVIEN and c.MAMAYBAY = m.MAMAYBAY and m.MAHANGMB = hmb.MAHANGMB and MAVE=@MaVe
end

go 
exec HoaDon 'VE0000'

go
create proc DoanhsoNV 
@thang int,
@nam int
as
begin
	select nv.MANHANVIEN, nv.TENNHANVIEN, SUM(GIATIEN) as 'Doanh So'  from VECHUYENBAY as v, NHANVIEN as nv 
	where v.MANHANVIEN = nv.MANHANVIEN and MONTH(NGAYGIOGD) = @thang and YEAR(NGAYGIOGD) = @nam group by nv.MANHANVIEN, nv.TENNHANVIEN order by SUM(GIATIEN) desc
end

go
exec DoanhsoNV '12','2021'