CREATE DATABASE WATER
USE WATER
GO

CREATE TABLE KhachHang
(
	MaKH CHAR (10),
	Ten NVARCHAR (50),
	DiaChi NVARCHAR (60),
	SDT VARCHAR (12),
	CMND VARCHAR (10),
	ChuLD CHAR (10),
	SoTK CHAR (15),
	LoaiKH BIT,
	CONSTRAINT pk_KH PRIMARY KEY (MaKH)
)
ALTER TABLE KhachHang ADD CONSTRAINT fk_CLD_KH FOREIGN KEY (ChuLD) REFERENCES KhachHang(MaKH)
INSERT INTO KhachHang (MaKH, Ten, DiaChi, SDT, SoTK, LoaiKH) VALUES
	('1', 'Phan Thanh Duy', N'TX Tan An - Tinh Long An', '0123453674', '123456576', 1),
	('2', N'Nguyen Duy Dat', 'Quan 10 - TP HCM', '01286742374', '132334567', 1),
	('3', N'Pham Thi Hong Nhung', 'H Thanh Phu - Tinh Ben Tre', '01684058473', '456575432324', 1),
	('4', N'Dang Thi Thuy Vy', 'H Long Ho - Tinh Vinh Long', '0175746263', '456567868', 1),
	('5', N'Hà Đăng Duy', 'H Long Ho - Tinh Vinh Long', '0175746263', '456567868', 1),
	('6', N'Dũng Kon', 'H Long Ho - Tinh Vinh Long', '0175746263', '456567868', 1),
	('7', N'Dang Thi Thuy', 'H Long Ho - Tinh Vinh Long', '0175746263', '456567868', 1),
	('8', N'Trong An', N'Lề đường - Quan 1', '0123948566', '345456877', 1),
	('9', N'Truong Van Dang', 'H Long Ho - Tinh Binh Dinh', '0175746263', '456567868', 0),
	('10', N'Dang Tuy Thuy', 'H Long Hop - Tinh Phu Yen', '017574345', '4512457868', 0);


CREATE TABLE CongTy
(
	MaCT CHAR (10),
	Ten NVARCHAR (150),
	DiaChi NVARCHAR (100),
	MaVAT VARCHAR (30),
	GTGT INT,
	NguoiDaiDien CHAR (10),	
	CONSTRAINT pk_CT PRIMARY KEY (MaCT)
)
ALTER TABLE CongTy ADD CONSTRAINT fk_NDD_KH FOREIGN KEY (NguoiDaiDien) REFERENCES KhachHang(MaKH)
INSERT INTO CongTy (MaCT, Ten, DiaChi, MaVAT, GTGT, NguoiDaiDien) VALUES
	('1', N'CÔNG TY TNHH SẢN XUẤT XÂY DỰNG VÀ THƯƠNG MẠI FIVE D', N'502/55/38 Huỳnh Tấn Phát, Phường Bình Thuận, Quận 7, TP Hồ Chí Minh', '56456', 10, '1'),
	('2', N'CÔNG TY TNHH ĐẦU TƯ SENTOSA', N'Phòng 8.6 - Tầng 8 Tòa nhà Le Meridien, Số 3C Tôn Đức Thắng, Phường Bến Nghé, Quận 1, TP Hồ Chí Minh', '657643', 10, '2'),
	('3', N'CÔNG TY TNHH SHINWA', N'750/72 Điện Biên Phủ, Phường 10, Quận 10, TP Hồ Chí Minh', '345345', 10, '3'),
	('4', N'CÔNG TY TNHH THƯƠNG MẠI DỊCH VỤ MỘT THÀNH VIÊN CÁT THIÊN AN', N'Số 11, Đường D3, Phường 25, Quận Bình Thạnh, TP Hồ Chí Minh', '76686', 10, '4'),
	('5', N'CÔNG TY TNHH MỘT THÀNH VIÊN PINK VELVET', N'9 Nguyễn Minh Hoàng, Phường 12, Quận Tân Bình, TP Hồ Chí Minh', '23421', 10, '5'),
	('6', N'CÔNG TY CỔ PHẦN ĐẦU TƯ XÂY DỰNG DẦU KHÍ TÂN DUY ANH', N'Số 20 đường số 2, Phường Tân Phú, Quận 7, TP Hồ Chí Minh', '12234', 10, '6'),
	('7', N'CÔNG TY TNHH MENSCH', N'245/9 Hòa Hảo, Phường 02, Quận 10, TP Hồ Chí Minh', '86542', 10, '7'),
	('8', N'CÔNG TY TNHH DỊCH VỤ PHÚC THIỆN', N'35/5E, ấp 1, Xã Xuân Thới Thượng, Huyện Hóc Môn, TP Hồ Chí Minh', '24356', 10, '8');


CREATE TABLE ThietBi
(
	MaTB CHAR (10),
	Ten NVARCHAR (50),
	LaBinhNuoc BIT, --Thiết bị này có phải là bình nước hay không:{1: phải; 0: Không}
	SLKho INT,
	CONSTRAINT pk_ThietBi PRIMARY KEY (MaTB)
)
INSERT INTO ThietBi (MaTB, Ten, SLKho, LaBinhNuoc) VALUES
	('1', N'Bình 19L có vòi', 1000, 1),
	('2', N'Bình 19L không vòi', 900, 1),
	('3', N'Bình 12L có vòi', 800, 1),
	('4', N'Bình 12L không vòi', 860, 1),
	('5', N'Chai 1L', 690, 1),
	('6', N'Chai 500ML', 999, 1),
	('7', N'Bình sứ', 500, 0),
	('8', N'Giá đỡ bình (cao)', 200, 0),
	('9', N'Giá đỡ bình (thấp)', 200, 0),
	('10', N'Máy nóng lạnh', 100, 0);

CREATE TABLE TTThietBi
(
	MaTB CHAR (10),
	Serial VARCHAR (30),
	NhaSX NVARCHAR (150),
	NgaySX DATE,
	NoiSX NVARCHAR (150),
	ChuaNuoc BIT,--nếu là bình nước thì bình đó đã đựng nước hay chưa: {1: có; 0: chưa}
	TrongKho BIT, --0: sản phẩm này không còn trong kho; 1:hiện đagn có trong kho
	CONSTRAINT pk_TTThietBi PRIMARY KEY (MaTB, Serial)
)
ALTER TABLE TTThietBi ADD CONSTRAINT fk_MaSP_TB FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB)


CREATE TABLE HopDong
(
	MaHD CHAR (10),
	MaKH CHAR (10),
	ThoiGianDinhKi INT,
	PTThanhToan BIT, -- 0: thanh toán khi giao hàng; 1: thanh toán vào cuối tháng
	TinhTrang BIT,-- 0: Hợp Đồng đã hủy; 1: Hợp đồng đang hiệu lực
	TuyenDuong NVARCHAR (100),
	NgayGiao DATE,
	DiaChi NVARCHAR (10),
	Thue INT,
	TongTien INT,
	TienNhan INT,
	No int,
	CONSTRAINT pk_HopDong PRIMARY KEY (MaHD)
)
ALTER TABLE HopDong ADD CONSTRAINT fk_MaKH_HD FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
INSERT INTO [dbo].[HopDong] ([MaHD] ,[MaKH] ,[ThoiGianDinhKi] , [PTThanhToan], [TinhTrang], [TuyenDuong],[NgayGiao] ,[DiaChi] ,[Thue],[TienNhan], [No]) VALUES
           ('1', '1', 0, 0, 1, N'Duong 1', '1/10/2017', N'DC 1', 100000 , 500000, 0),
		   ('2', '2', 0, 0, 1, N'Duong 2', '1/10/2017', N'DC 2', 100000 , 500000, 0),
		   ('3', '3', 0, 0, 1, N'Duong 3', '1/10/2017', N'DC 3', 100000 , 500000, 0);
GO


CREATE TABLE SanPhamThue
(
	MaHD CHAR (10),
	MaTB CHAR (10),
	SLuong INT,
	KhoanKyQuy INT,
	GiaThue INT,
	ThoiGianThue INT, -- thang
	TGLapDat DATE,
	CONSTRAINT pk_TBThue PRIMARY KEY (MaHD, MaTB)
)
ALTER TABLE SanPhamThue ADD CONSTRAINT fk_TBT_HD FOREIGN KEY (MaHD) REFERENCES HopDong(MaHD)
ALTER TABLE SanPhamThue ADD CONSTRAINT fk_MaTB_HD FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB)
INSERT INTO [dbo].SanPhamThue([MaHD],[MaTB], [SLuong],[KhoanKyQuy],[GiaThue],[ThoiGianThue] ,[TGLapDat]) VALUES
           ('1' ,'7', 1, 1200000, 600000, 12, '1/13/2017'),
		   ('2' ,'7', 2, 1200000, 600000, 12, '1/13/2017'),
		   ('2' ,'9', 2, 1000000, 650000, 12, '1/13/2017'),
		   ('3' ,'10', 3, 1290000, 100000, 12, '1/13/2017'),
		   ('1' ,'8', 4, 2200000, 700000, 12, '1/13/2017');
GO

CREATE TABLE SanPhamMua
(
	MaHD CHAR (10),
	MaTB CHAR (10),
	SLuong INT,
	DonGia INT,
	LaNuoc BIT,--mua sản phảm là nước {1: phải; 0: không}
	CONSTRAINT pk_SPMua PRIMARY KEY (MaHD, MaTB)
)
ALTER TABLE SanPhamMua ADD CONSTRAINT fk_SPM_HD FOREIGN KEY (MaHD) REFERENCES HopDong(MaHD)
ALTER TABLE SanPhamMua ADD CONSTRAINT fk_SPM_TB FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB)
INSERT INTO [dbo].[SanPhamMua]([MaHD],[MaTB],[SLuong],[DonGia], [LaNuoc]) VALUES
           ('3','1', 100, 15000, 1),
		   ('3','2', 1000, 14000, 0),
		   ('3','9', 1, 2500000, null);
GO


CREATE TABLE CT_GiaoHang
(
	MaHD CHAR (10),
	MaTB CHAR (10),
	SLDaGiao INT,
	DonGia INT,
	SoTien INT,
	NgayLap DATE,
	NgayThuHoi DATE,
	NVGiao	NVARCHAR (30)
	--CONSTRAINT pk_CTGH PRIMARY KEY (MaPGH, MaTB)
)
ALTER TABLE CT_GiaoHang ADD CONSTRAINT fk_PGH_CT FOREIGN KEY (MaHD) REFERENCES HopDong(MaHD)
INSERT INTO [dbo].[CT_GiaoHang]([MaHD],[MaTB],[SLDaGiao],[DonGia],[SoTien],[NgayLap],[NgayThuHoi], NVGiao) VALUES
           ('3', '1' , 50, 15000, 750000, '1/7/2017',null, 'NV1'),
		   ('3', '1' , 50, 15000, 150000, '1/8/2017',null, 'NV1'),
		   ('1', '7' , 1, null, 1200000, '1/7/2017',null, 'NV1'),
		   ('2', '7' , 1, null, 1200000, '1/7/2017',null, 'NV1'),
		   ('3', '2' , 500, 14000, 7000000, '1/7/2017',null, 'NV1');
GO

CREATE TABLE NhaCungCap
(
	MaNCC CHAR (10),
	Ten NVARCHAR (150),
	DiaChi NVARCHAR (100),
	SDT VARCHAR (12),
	FAX VARCHAR (12),
	CONSTRAINT pk_NhaCC PRIMARY KEY (MaNCC)
)
INSERT INTO NhaCungCap (MaNCC, Ten, DiaChi, SDT) VALUES
	('1', N'CÔNG TY TNHH EMEM', N'86 Phan Xích Long, Phường 3, Quận Bình Thạnh, TP Hồ Chí Minh', '1243563345'),
	('2', N'CÔNG TY TNHH MTV HOÀNG Ý LOGISTICS', N'32/23 đường số 5, KP 8, Phường Bình Hưng Hòa, Quận Bình Tân, TP Hồ Chí Minh', '012024325'),
	('3', N'CÔNG TY TNHH DỊCH VỤ VÀ THƯƠNG MẠI T', N'80/2 Võ Trường Toản, Phường 05, Quận 5, TP Hồ Chí Minh', '01645786786'),
	('4', N'CÔNG TY CỔ PHẦN ĐẦU TƯ VĂN GIA', N'141-143 Diệp Minh Châu, Phường Tân Sơn Nhì, Quận Tân phú, TP Hồ Chí Minh', '012245465'),
	('5', N'CÔNG TY TNHH TẰM TƠ SÀI GÒN', N'47/3 Trần Hưng Đạo, Phường 06, Quận 5, TP Hồ Chí Minh', '0163546567'),
	('6', N'CÔNG TY TNHH HÀ HOÀNG THẾ QUANG', N'16/34 Lê Trọng Tấn, Phường Tây Thạnh, Quận Tân phú, TP Hồ Chí Minh', '014563234'),
	('7', N'CÔNG TY TNHH EFCO VIỆT NAM', N'Phòng 305, Lầu 3, Số 79C, Đường Điện Biên Phủ, Phường Đa Kao, Quận 1, TP Hồ Chí Minh', '015674335'),
	('8', N'CÔNG TY TNHH XÂY DỰNG CÔNG NGHIỆP', N'499/44/29D Quang Trung, Phường 10, Quận Gò Vấp, TP Hồ Chí Minh', '016484843');

CREATE TABLE NhaCC_TB
(
	MaNCC CHAR (10),
	MaTB CHAR (10),
	CONSTRAINT pk_NhaCCTB PRIMARY KEY (MaNCC, MaTB)
)
ALTER TABLE NhaCC_TB ADD CONSTRAINT fk_NCC_Ma FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
ALTER TABLE NhaCC_TB ADD CONSTRAINT fk_TB_Ma FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB)
INSERT NhaCC_TB (MaNCC, MaTB) VALUES 
	('1', '1'),
	('1', '2'),
	('1', '3'),
	('1', '4'),
	('1', '5'),
	('1', '6'),
	('2', '1'),
	('2', '6'),
	('2', '3'),
	('2', '2'),
	('2', '5'),
	('2', '4'),
	('3', '10'),
	('4', '9'),
	('4', '8'),
	('5', '7'),
	('5', '6'),
	('5', '5'),
	('6', '4'),
	('6', '5'),
	('7', '10'),
	('7', '9'),
	('8', '9'),
	('8', '8'),	
	('8', '10');

CREATE TABLE DonDacHang
(
	MaNCC CHAR (10),
	MaTB CHAR (10),
	SLuong INT,
	DonGia INT,
	ThoiGianGiao INT, --Số ngày sẽ giao hàng
	XacNhan BIT, -- 0: ĐƠN ĐẶT HÀNG CHƯA ĐƯỢC DUYỆT
	TinhTrang BIT, -- 0: Dơn hàng đã hoàng thanh
	CONSTRAINT pk_DonDH PRIMARY KEY (MaNCC, MaTB)
)
ALTER TABLE DonDacHang ADD CONSTRAINT fk_DDH_NCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
ALTER TABLE DonDacHang ADD CONSTRAINT fk_DDH_TB FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB)

CREATE TABLE TTNhanHang
(
	MaNCC CHAR (10),
	MaTB CHAR (10),
	SLuong INT,
	CONSTRAINT pk_TTNhanHang PRIMARY KEY (MaNCC,MaTB, SLuong)
)
ALTER TABLE TTNhanHang ADD CONSTRAINT fk_TTN_NCC_TB FOREIGN KEY (MaNCC, MaTB) REFERENCES DonDacHang(MaNCC, MaTB)

CREATE TABLE KhuyenMai
(
	MaKM CHAR (10),
	SLCan INT,
	ThongTinKM NVARCHAR (200)
	CONSTRAINT pk_KM PRIMARY KEY (MaKM)
)

CREATE TABLE LichSuaChua
(
	MaTB CHAR (10),
	MaHD CHAR (10),
	NoiDungSua NVARCHAR (200),
	TienSua INT,
	CONSTRAINT pk_LichSua PRIMARY KEY (MaTB, MaHD)
)

ALTER TABLE LichSuaChua ADD CONSTRAINT fk_LichSua_HD FOREIGN KEY (MaHD) REFERENCES HopDong(MaHD)
