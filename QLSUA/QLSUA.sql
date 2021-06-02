﻿CREATE DATABASE QLSUA
GO	
USE QLSUA
go
---- bang nhan vien

CREATE TABLE nhanvien
(
	ID nvarchar(4)  primary key,
	hoten nvarchar(50) ,
	gioitinh nvarchar(3) check (gioitinh in(N'Nam',N'Nữ')) ,
	ngaysinh DATE ,
	cmnd char(9) ,
	diachi nvarchar(50) ,
	sdt varchar(11) ,
	tencv nvarchar(40) 
	
	)
go




-----Dữ liệu bảng nhân viên------
insert into nhanvien values (N'NV01',N'Ngô Văn Thái',N'Nam','2000-2-19','352497258',N'Chợ Mới', '0929734993',N'Nhân Viên');
insert into nhanvien values (N'NV02',N'Nguyễn Minh Tiến ',N'Nam','2000-07-15','352468481',N'Long Xuyên', '0969940588',N'Quản lý');
insert into nhanvien values (N'NV03',N'Trương Huỳnh Phú Quí',N'Nam','2000-07-23','352448471',N'Thoại Sơn', '0969540538',N'Quản lí');
insert into nhanvien values (N'NV05',N'Nguyễn Như ',N'Nữ','2000-07-23','352448471',N'Long Xuyên', '0969540538',N'Nhân viên');
UPDATE nhanvien SET hoten=N'hhhhhhh',gioitinh=N'Nam',ngaysinh='1998-2-1',cmnd='385698545',diachi=N'Long an',sdt=N'0215632585'WHERE ID=N'NV04'
select* from sanpham
--delete FROM nhanvien WHERE id=N'NV04'
--alter table sanpham drop column hinhanh
----bang chuc vu------

--- bang tai khoan ----
create table nguoidung
(
	
	IDnhanvien nvarchar(4),
	matkhau nvarchar(50),
	quyen int
	foreign key (IDnhanvien) references nhanvien(ID)
)

go
INSERT INTO nguoidung
VALUES(N'NV01','12345',1); /*Mật khẩu 12345*/
INSERT INTO nguoidung
VALUES(N'NV02','12345',0); /*Mật khẩu 23456*/
INSERT INTO nguoidung
VALUES(N'NV03','23456',1); /*Mật khẩu 12345*/

select* from nguoidung
-----BANG DANG NHAP----


----bang khach hang
create table khachhang
(
    ID nvarchar(5) primary key,
	hotenkh nvarchar(30) ,
	gioitinh nvarchar(3) check (gioitinh in(N'Nam',N'Nữ')) ,
	sdt varchar(11) 
)
go


select*from khachhang
-----Dữ liệu bảng khách hàng------
insert into khachhang values (N'KH061',N'Nguyễn Văn A',N'Nam', '0969940538');
insert into khachhang values (N'KH082',N'Nguyễn Văn B ',N'Nữ', '0969940588');
insert into khachhang values (N'KH063',N'Hoài Phúc',N'Nam','0969540538');
insert into khachhang values (N'KH022',N'Văn A',N'Nữ','0269540538');

---bảng nhà cung cấp
CREATE table nhacungcap(
ID nvarchar(5) primary key,
tennhacungcap nvarchar(30)not null,
sdt varchar(11),
diachi nvarchar(50) not null
)
go
--Dữ liệu nhà cung cấp
insert into nhacungcap values(N'NCC1',N'Trương Trần Huy Tín','03256254582',N'Châu Đốc')
insert into nhacungcap values(N'NCC2',N'Nguyễn Thanh Giàu','03256254582',N'Đồng Tháp')
update nhacungcap set tennhacungcap=N'Phú Quí',sdt='0958453256',diachi=N'Long Xuyên' where ID=N'NCC1'
---phieu nhap san pham----
select *from nhacungcap

----Dữ liệu bảng phiếu nhập sản phẩm-----

create table phieunhapsp
(
	ID INT IDENTITY primary key,
	TenSP NVARCHAR(50) not null,
	soluong int,
	ngaynhap date,
	dongia float(30),
	)
GO


insert into phieunhapsp values (N'Vinamilk','90',GETDATE(),'80000')
insert into phieunhapsp values (N'TH True Milk','80',GETDATE(),'120000')
insert into phieunhapsp values (N'Dutch Lady','200',GETDATE(),'1000')
insert into phieunhapsp values (N'Nutifood','90',GETDATE(),'40000')
insert into phieunhapsp values (N'Nestle','30',GETDATE(),'200000')



select*from phieunhapsp
UPDATE phieunhapsp SET TenSP=N'Sữa bột ', soluong='12', ngaynhap=GETDATE() ,dongia='20000'WHERE ID='10'
delete FROM phieunhapsp WHERE ID='6'
--- loai san pham
create table loaisp
(
	ID int IDENTITY,
	maloai char(5) primary key,
	tenloai nvarchar(200)
)
GO

-----Dữ liệu bảng loai san pham------
insert into loaisp values ('L1000',N'Sữa đặc ');
insert into loaisp values ('L2000',N'Sữa chua');
insert into loaisp values ('L3000',N'Sữa trẻ em');
insert into loaisp values ('L9000',N'Sữa người già');
insert into loaisp values ('L1100',N'Sữa bột');
select* from loaisp
UPDATE loaisp SET tenloai=N'Sữa tươi' WHERE maloai='L9000'

select*from loaisp

--- bang san pham
create table sanpham
(
	ID int not null,
	masp  char(6) primary key,
	tensp nvarchar(200) ,
	soluong int ,
	dongiaban float(30) ,
	idLoaisp char(5),
	foreign key (idLoaisp) references loaisp(maloai),
	
	)
GO

-----Dữ liệu bảng sản phẩm------
insert into sanpham values ('1','SP1000',N'Vinamilk','90','80000','L1000');
insert into sanpham values ('1','SP2000',N'TH True Milk','80', '120000','L2000');
insert into sanpham values ('1','SP3000',N'Dutch Lady ','200','1000','L2000');
insert into sanpham values ('1','SP4000',N'Nutifood','30','40000','L3000');
insert into sanpham values ('1','SP5000',N'Nestle','30','200000','L1000');


delete from sanpham where masp='SP1000'

UPDATE sanpham SET   masp='SP009' , tensp=N'Sữa ngôi sao  ', soluong='12', dongiaban='20000'WHERE ID='2'
insert into sanpham values ('33','SP8000',N'Sữa con bò','50', '150000','L1000');
--select n.*, c.tenloai ,  from sanpham n, loaisp c , pwhere n.idLoaisp=c.maloai

SELECT*FROM phieunhapsp
select m.*, c.TenSP from sanpham m, phieunhapsp c where m.ID=c.ID
SELECT*FROM sanpham

SELECT*FROM phieunhapsp

----- Bảng Chi tiết phiêu nhập-------



----- bang hoa don ----
create table hoadon
(
	ID uniqueidentifier primary key,
	IDkh nvarchar(5),
	IDNhanVien nvarchar(4),
	ngaylap date default(getdate()),
	ThanhTien INT DEFAULT 0
	foreign key(IDkh) references khachhang(ID),
	foreign key (IDNhanVien) references nhanvien(ID)
)
GO
---Dữ liệu bảng hóa đơn------
insert into hoadon values ('9BC723CF-7146-40A4-9A4B-20A34FBCD6D0',N'KH061',N'NV02',GETDATE(),0);
insert into hoadon values ('0A3EE4F7-BFF9-408F-B037-706D6054AFB1',N'KH082',N'NV02',GETDATE(),0);
insert into hoadon values ('C876EF04-3409-424F-9BDC-95E6A0ABFEB8',N'KH063',N'NV02',GETDATE(),0);

select * from hoadon

---- bang chi tiet hoa don -----
create table chitiethoadon
(
	IDCTHD INT IDENTITY ,
	IDHoaDon uniqueidentifier,
	IDSanPham char(6),
	soluong int ,
	PRIMARY KEY(IDHoaDon,IDSanPham),
	foreign key (IDHoaDon) references hoadon(ID),
	foreign key (IDSanPham) references sanpham(masp),
	
)
select * from hoadon
select * from sanpham
select * from chitiethoadon
GO
-----Dữ liệu bảng chi tiết hóa đơn----
insert into chitiethoadon values  ('9BC723CF-7146-40A4-9A4B-20A34FBCD6D0','SP4000','1');
insert into chitiethoadon  values ('0A3EE4F7-BFF9-408F-B037-706D6054AFB1','SP2000','1');
insert into chitiethoadon  values ('C876EF04-3409-424F-9BDC-95E6A0ABFEB8','SP3000','2'); 


SELECT * FROM chitiethoadon



select*from phieunhapsp

select*from phieunhapsp


--SELECT * FROM nhanvien
INSERT INTO nhanvien VALUES(N'NV08',N'AGH',N'Nữ',N'2000-5-8','369324525',N'Long xuyên','0236521258',N'QL')
select * from khachhang
--select n.*, c.tensp , sp.ngaynhap from chitietphieunhap n, sanpham c , phieunhapsp sp where n.IDsp=c.ID and n.IDPhieuNhap=sp.ID
--select n.*, c.ngaynhap from chitietphieunhap n, phieunhapsp c where n.IDPhieuNhap=c.ID

select * from nhanvien


--select pn.*, sp.idPhieuNhap from phieunhapsp pn, sanpham sp where n.macv=cv.macv
--ALTER TABLE sanpham drop column dongianhap

UPDATE nguoidung SET matkhau='23456', quyen='1'where IDnhanvien='NV05'

select * from nguoidung where IDnhanvien=N'NV02' and matkhau=N'23456'

select *from dangnhap
select*from nguoidung


select n.*, c.tencv from nguoidung n, nhanvien c where n.IDnhanvien=c.ID

---sp k ban dc----
SELECT S.masp, tensp
FROM sanpham S
WHERE NOT EXISTS(SELECT * FROM sanpham  INNER JOIN chitiethoadon C ON S.masp = C.IDSanPham AND S.masp = S.masp)
---tong so sp ban dc trong thang---
       
---doanh thu nam----
SELECT SUM(ThanhTien) AS DOANHTHU
FROM hoadon
WHERE year(ngaylap) = 2021
--select*from khachhang

---doanh thu bán mỗi ngày----
SELECT hd.ngaylap, SUM(ThanhTien) AS DOANHTHU
FROM hoadon as hd
GROUP BY ngaylap
-----doanh thu bán từng tháng---
SELECT MONTH(hd.ngaylap) AS THANG, SUM(hd.ThanhTien) AS DOANHTHU
FROM hoadon as hd
WHERE YEAR(hd.ngaylap) = 2021
GROUP BY MONTH(hd.ngaylap)




select n.*, c.tenloai from sanpham n, loaisp c   where n.idLoaisp=c.maloai and n.ID = 1

select hd.ID,hd.IDNhanVien, hd.IDkh, ct.IDSanPham,ct.soluong,hd.ThanhTien ,hd.ngaylap
from hoadon as hd
inner join chitiethoadon as ct on hd.ID= ct.IDHoaDon

select * from nguoidung
	select * from chitiethoadon

---TI ma hoa don mua 2 sp---
	SELECT hd.IDHoaDon
FROM chitiethoadon hd
WHERE hd.IDSanPham IN ('SP1000', 'SP2000')

SELECT COUNT(DISTINCT IDSanPham)
FROM chitiethoadon C INNER JOIN hoadon H
ON C.IDHoaDon = H.ID
WHERE YEAR(ngaylap) = 2021


SELECT MASP, COUNT(DISTINCT MASP) AS TONGSO
FROM sanpham
WHERE MASP IN(SELECT MASP
FROM chitiethoadon C INNER JOIN hoadon H
ON C.IDHoaDon = H.ID
WHERE MONTH(ngaylap) = 10 AND YEAR(ngaylap) = 2006)
GROUP BY masp

select* from nguoidung

