create database QuanLyNhaHang
use QuanLyNhaHang


create table taikhoan
(
	id int identity primary key,
	tendangnhap varchar(100) unique,
	matkhau varchar(100),
	hoten nvarchar(100),
	loaitk int
)

insert into taikhoan values ('admin','123456',N'Lê Khải Hoàn', 1)


--select * from taikhoan
--delete from taikhoan

create table LoaiMonAn
(
	idLoaiMonAn int identity primary key,
	TenLoai nvarchar(200)
)


create table MonAn
(
	idMonAn int identity primary key,
	TenMon nvarchar(200),
	dvt nvarchar(20),
	gia varchar(20),
	idLoaiMonAn int

	foreign key (idLoaiMonAn) references LoaiMonAn(idLoaiMonAn)
)

create table Ban
(
	idBan int identity primary key,
	TenBan nvarchar(255),
	TrangThai nvarchar(255),
)

create table HoaDon
(
	idHoaDon int identity primary key,
	idBan int,
	TinhTrang int,
	NgayThanhToan date,
	SoTien int 

	foreign key (idBan) references Ban(idBan)
)

create table CTHD
(
	idCTHD int identity primary key,
	idHoaDon int,
	idMonAn int,
	SoLuong int,

	foreign key (idHoaDon) references HoaDon(idHoaDon),
	foreign key (idMonAn) references MonAn(idMonAn)
)


-- insert data into table Ban

INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 1', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 2', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 3', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 4', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 5', N'Có Người')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 6', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 7', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 8', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 9 ', N'Có Người')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 10', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 11', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 12', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 13', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 14', N'Có Người')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 15', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 16', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 17', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 18', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 19', N'Trống')
INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 20', N'Trống')
--INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 21', N'Trống')
--INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 22', N'Trống')
--INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 23', N'Trống')
--INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 24', N'Trống')
--INSERT Ban (TenBan, TrangThai) VALUES ( N'Bàn 25', N'Trống')

--select * from Ban
--update Ban
--set TrangThai = N'Có Người'
--where idBan = 10

-- insert data into table HoaDon

--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 1, 1, CAST(0x0000A98D00000000 AS DateTime), 126000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 7, 1, CAST(0x0000A98D00000000 AS DateTime), 272000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 8, 1, CAST(0x0000A98D00000000 AS DateTime), 966000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 5, 1, CAST(0x0000A98D00000000 AS DateTime), 229000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 9, 1, CAST(0x0000A98E00000000 AS DateTime), 191000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 1, 1, CAST(0x0000A98E00000000 AS DateTime), 400000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 4, 1, CAST(0x0000A98E00000000 AS DateTime), 58000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 7, 1, CAST(0x0000A98E00000000 AS DateTime), 387000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 2, 1, CAST(0x0000A98E00000000 AS DateTime), 632000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 9, 1, CAST(0x0000A98E00000000 AS DateTime), 896000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 11, 1, CAST(0x0000A98E00000000 AS DateTime), 136000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 6, 1, CAST(0x0000A98E00000000 AS DateTime), 239000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 3, 1, CAST(0x0000A98E00000000 AS DateTime), 432000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 9, 1, CAST(0x0000A98E00000000 AS DateTime), 507000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 15, 1, CAST(0x0000A98E00000000 AS DateTime), 583000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 10, 1, CAST(0x0000A98F00000000 AS DateTime), 525000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 11, 1, CAST(0x0000A98F00000000 AS DateTime), 467000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 16, 1, CAST(0x0000A98F00000000 AS DateTime), 2839000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 9, 1, CAST(0x0000A98F00000000 AS DateTime), 179000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 4, 1, CAST(0x0000A98F00000000 AS DateTime), 750000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 2, 1, CAST(0x0000A98F00000000 AS DateTime), 58000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 19, 1, CAST(0x0000A98F00000000 AS DateTime), 423000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 18, 1, CAST(0x0000A98F00000000 AS DateTime), 295000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 25, 1, CAST(0x0000A99000000000 AS DateTime), 1235000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 21, 1, CAST(0x0000A99000000000 AS DateTime), 486000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 20, 1, CAST(0x0000A99100000000 AS DateTime), 472000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 24, 1, CAST(0x0000A99100000000 AS DateTime), 634000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 1, 1, CAST(0x0000A99100000000 AS DateTime), 312000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 23, 1, CAST(0x0000A99100000000 AS DateTime), 447000)
--INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan, SoTien) VALUES ( 14, 1, CAST(0x0000A99200000000 AS DateTime), 660000)

--select * from HoaDon
--delete from HoaDon

-- insert  data into table MonAn
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Thịt Lợn Quay Xá Xíu', N'Đĩa', 118000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Thịt Ba Chỉ Kho Tộ', N'Đĩa', 78000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Chân Giò Nướng', N'Đĩa', 98000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Sường Xào Chua Ngọt', N'Đĩa', 113000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Quay Mật Ong', N'Đĩa', 86000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Nướng Hấp Xả', N'Đĩa', 126000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Rang Muối', N'Đĩa', 66000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Vịt Xào Lăn', N'Đĩa', 58000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Vịt Quay Thượn Hạng', N'Đĩa', 78000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Thịt Bò Xào Hành Tây', N'Đĩa', 158000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Sườn Bò Ngũ Vị', N'Đĩa', 168000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Bò Lúc Lắc', N'Đĩa', 145000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Tôm Sú Chiên Sả', N'Con', 26000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Tôm Hùm', N'Con', 750000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Ngao Hấp Sả', N'Đĩa', 150000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Hàu Nướng Phô Mai', N'Đĩa', 120000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Ngao Húng Quế', N'Đĩa', 1130000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cua Hoàng Đế', N'Con', 600000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cua Xào Me', N'Con', 35000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Chả Cá Hà Nội', N'Đĩa', 55000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cơm Tấm', N'Bát', 15000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cơm Chiên Trứng', N'Bát', 20000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cơm Rang Thịt Bò', N'Bát', 30000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Cơm Trắng', N'Bát', 10000)
--insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Lẩu Hải Sản', N'Nồi', 438000)

--select * from MonAn



-- thêm LoaiMonAn

INSERT LoaiMonAn (TenLoai) VALUES (N'Lợn')
INSERT LoaiMonAn (TenLoai) VALUES (N'Gà')
INSERT LoaiMonAn (TenLoai) VALUES (N'Vịt')

-- thêm món ăn
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Thịt Lợn Quay Xá Xíu', N'Đĩa', 118000, 1)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Thịt Ba Chỉ Kho Tộ', N'Đĩa', 78000, 1)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Chân Giò Nướng', N'Đĩa', 98000, 1)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Sường Xào Chua Ngọt', N'Đĩa', 113000, 1)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Quay Mật Ong', N'Đĩa', 86000, 2)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Nướng Hấp Xả', N'Đĩa', 126000, 2)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Gà Rang Muối', N'Đĩa', 66000, 2)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Vịt Xào Lăn', N'Đĩa', 58000, 3)
insert into MonAn (TenMon, dvt, gia, idLoaiMonAn) VALUES ( N'Vịt Quay Thượng Hạng', N'Đĩa', 78000, 3)

-- thêm Hóa Đơn

INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan) VALUES ( 5, 0, GETDATE())
INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan) VALUES ( 9, 0, GETDATE())
INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan) VALUES ( 14, 0, GETDATE())
INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan) VALUES ( 1, 1, GETDATE())



-- thêm CTHD
INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 1, 6, 1)
INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 1, 4, 1)
INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 1, 8, 2)

INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 2, 2, 1)
INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 2, 5, 2)

INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 3, 4, 3)

INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 4, 9, 3)
INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES ( 4, 7, 4)



--select * from Ban
--select * from HoaDon
--select * from CTHD
--select * from MonAn
--select * from LoaiMonAn

--select * from HoaDon where idBan = 5 and TinhTrang = 0
--select * from CTHD where idHoaDon = 1

--select TenMon, SoLuong, gia, gia*SoLuong as ThanhTien from CTHD, HoaDon, MonAn 
--where CTHD.idHoaDon = HoaDon.idHoaDon
--and CTHD.idMonAn = MonAn.idMonAn
--and TinhTrang = 0
--and HoaDon.idBan = 1

--select * from MonAn where idLoaiMonAn = 1


CREATE PROC USP_InsertBill
@idBan int
AS 
BEGIN
	INSERT HoaDon (IDBan, TinhTrang, NgayThanhToan) VALUES ( @idBan, 0, NULL)
END
--

CREATE PROC USP_InsertCTHD
@idHoaDon int, @idMonAn int, @SoLuong int
AS
BEGIN
	DECLARE @isExistBillInfo int
	DECLARE	@foodCount int = 1

	SELECT @isExistBillInfo = idCTHD, @foodCount = SoLuong
	FROM CTHD
	WHERE idHoaDon = @idHoaDon AND idMonAn = @idMonAn

	IF(@isExistBillInfo>0)
	BEGIN
		DECLARE @newCount int = @foodCount + @SoLuong
		IF(@newCount > 0)
			UPDATE CTHD SET SoLuong =  @foodCount + @SoLuong WHERE idMonAn = @idMonAn
		ELSE
			DELETE CTHD WHERE idHoaDon = @idHoaDon AND idMonAn = @idMonAn
	END
	ELSE	
		INSERT CTHD (idHoaDon, idMonAn, SoLuong) VALUES (@idHoaDon, @idMonAn, @SoLuong)
END

--

CREATE TRIGGER UTG_UpdateBillInfo
ON CTHD FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill int
	SELECT @idBill = idHoaDon FROM inserted
	DECLARE @idTable int
	SELECT @idTable = idBan FROM HoaDon WHERE idHoaDon = @idBill AND TinhTrang = 0
	UPDATE Ban SET TrangThai = N'Có Người' WHERE idBan = @idTable
END

CREATE TRIGGER UTG_UpdateBill
ON HoaDon FOR UPDATE
AS
BEGIN
	DECLARE @idBill int
	SELECT @idBill = idHoaDon FROM inserted
	DECLARE @idTable int
	SELECT @idTable = idBan FROM HoaDon WHERE idHoaDon = @idBill 
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM HoaDon WHERE idBan = @idTable and TinhTrang = 0 

	IF(@count = 0)
		UPDATE Ban SET TrangThai = N'Trống' WHERE idBan = @idTable

END



