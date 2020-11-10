create database QuanLyNhaHang
use QuanLyNhaHang

create table thucdon
(
	id int identity primary key,
	tenmon nvarchar(200),
	gia varchar(20),
	dvt nvarchar(20)
)

create table taikhoan
(
	id int identity primary key,
	tendangnhap varchar(100) unique,
	matkhau varchar(100),
	hoten nvarchar(100),
	loaitk int
)

insert into taikhoan values ('admin','admin',N'Lê Khải Hoàn', 1)

update taikhoan
set matkhau = '123456'
where tendangnhap = 'admin'

select * from thucdon
insert into thucdon values ('Gà lá giang', '150000', 'con')
insert into thucdon values ('bò', '16000', 'con')
insert into thucdon values ('heo', '360000', 'con')