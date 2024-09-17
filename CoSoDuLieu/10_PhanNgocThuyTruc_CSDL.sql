create database QLBH_VPP_JD
go
use  QLBH_VPP_JD
go
--Tạo bảng
--1.Nhân viên
create table NhanVien
(
MaNV char(6) not null,
HoNV nvarchar (10),
TenNV nvarchar (30),
GioiTinh nvarchar (5),
NgaySinh datetime,
DiaChi nvarchar (50),
DienThoai varchar (15),
NoiSinh nvarchar (20),
NgayVaoLam datetime,
Email varchar (30)
constraint PK_NhanVien Primary Key (MaNV)
)
go
--2. Tài khoản
create table TaiKhoan
(
TenDN varchar(10) not null,
MatKhau varchar (15),
ChucVu nvarchar (10),
MaNV char(6),
constraint PK_TaiKhoan Primary Key (TenDN)
)
go
--3.Loại sản phẩm
create table LoaiSanPham
(
MaloaiSP char (6) not null,
TenloaiSP nvarchar (15),
GhiChu nvarchar (50),
constraint PK_LoaiSP Primary Key (MaloaiSP)
)
go
--4.Sản phẩm
create table SanPham
(
MaSP char (6) not null,
TenSP nvarchar (40),
SLTon int,
DonViTinh nvarchar(10),
DonGiaBan real,
MaloaiSP char (6) not null,
MaNCC char(6) not null,
constraint PK_SanPham Primary Key (MaSP)
)
go
--5.Nhà cung cấp
create table NhaCungCap
(
MaNCC char(6) not null,
TenNCC nvarchar(40),
DiaChi nvarchar(50),
DienThoai varchar(15),
Email varchar(30),
constraint PK_NhaCungCap Primary Key (MaNCC)
)
go
-- 6.Cửa hàng
create table CuaHang 
(
MaCH char(6) not null,
TenCH nvarchar (40),
DiaChi nvarchar (50),
DienThoai varchar(15),
NguoiLH nvarchar (40),
constraint PK_CuaHang Primary Key (MaCH)
)
go
--7.Khách hàng
create table KhachHang
(
MaKH char(6) not null,
TenKH nvarchar(40),
DiaChi nvarchar(50),
NgaySinh datetime,
DienThoai varchar(15),
ThanhVien nvarchar (5),
constraint PK_KhachHang Primary Key (MaKH)
)
go
--8.Phiếu Nhập
create table PhieuNhap
(
SoPN char(6)not null,
NgayNhap datetime,
GhiChu nvarchar(50),
PTTT nvarchar(15),
MaNV char (6) not null,
MaNCC char (6) not null,
constraint PK_PhieuNhap Primary Key (SoPN)
)
go
--9.Phiếu Xuất
create table PhieuXuat
(
SoPX char(6) not null,
NgayXuat datetime, 
PTTT nvarchar(15),
MaNV char(6) not null,
MaCH char(6) not null,
constraint PK_PhieuXuat Primary Key (SoPX)
)
go
--10.Chi tiết phiếu nhập
create table CTPhieuNhap
(
SoPN char(6) not null,
MaSP char(6) not null,
SoLuong int,
DonGia real,
constraint PK_CTPN Primary Key (SoPN,MaSP)
)
go
--11.Chi tiết phiếu xuất 
create table CTPhieuXuat
(
SoPX char(6) not null,
MaSP char(6) not null,
SoLuong int,
DonGiaXuat real,
constraint PK_CTPX Primary Key (SoPX,MaSP)
)
go
--12.Hóa đơn
create table HoaDon
(
MaHD char(6) not null,
NgayDH datetime,
PTTT nvarchar(15),
MaNV char(6) not null,
MaKH char(6) not null
constraint PK_HoaDon Primary Key (MaHD)
)
go
--13.Chi tiết hóa đơn
create table CTHoaDon
(
MaHD char(6) not null,
MaSP char(6) not null,
SoLuong int,
DonGiaBan real,
constraint PK_CTHD Primary Key (MaHD,MaSP)
)
--Khóa ngoại
alter table TaiKhoan
add constraint FK_TaiKhoan_MaNV foreign key(MaNV) references NhanVien(MaNV)

alter table SanPham
add constraint FK_SanPham_MaLSP foreign key(MaloaiSP) references LoaiSanPham(MaloaiSP),
    constraint FK_SanPham_MaNCC foreign key(MaNCC) references NhaCungCap(MaNCC)

alter table PhieuNhap
add constraint FK_PhieuNhap_MaNV foreign key(MaNV) references NhanVien(MaNV),
    constraint FK_Phieunhap_MaNCC foreign key(MaNCC) references NhaCungCap(MaNCC)


alter table PhieuXuat
add constraint FK_PhieuXuat_MaNV foreign key(MaNV) references NhanVien(MaNV),
    constraint FK_PhieuXuat_MaCH foreign key(MaCH) references CuaHang(MaCH)


alter table HoaDon
add constraint FK_HoaDon_MaNV foreign key(MaNV) references NhanVien(MaNV),
    constraint FK_HoaDon_MaKH foreign key(MaKH) references KhachHang(MaKH)

alter table CTPhieuNhap
add constraint FK_CTPhieuNhap_SoPN foreign key(SoPN) references PhieuNhap(SoPN),
	constraint FK_CTPhieuNhap_MaSP foreign key(MaSP) references SanPham(MaSP)

alter table CTPhieuXuat
add constraint FK_CTPhieuXuat_SoPX foreign key(SoPX) references PhieuXuat(SoPX),
	constraint FK_CTPhieuXuat_MaSP foreign key(MaSP) references SanPham(MaSP)

alter table CTHoaDon
add constraint FK_CTHoaDon_MaHD foreign key(MaHD) references HoaDon(MaHD),
	constraint FK_CTHoaDon_MaSP foreign key(MaSP) references SanPham(MaSP)


-- Thêm dữ liệu
--1. Nhân viên
 insert into NhanVien values 
 (N'NV0001',N'Phan', N'Thành Duy',N'Nam','02/25/1998',N'5 Dương Quảng hàm',N'08858454182',N'Vũng Tàu','05/01/2017',null),
 (N'NV0002',N'Lâm', N'Đại Ngọc',N'Nữ','03/06/1999',N'2/1A Quang Trung',N'08354362205',N'Cà Mau','05/01/2017',null),
 (N'NV0003',N'Trần', N'Châu Khoa',N'Nam','05/05/1999',N'10 QL 1A',N'09181833333',N'Vĩnh Long','05/01/2017',null),
 (N'NV0004',N'Lê', N'Chí Kiên',N'Nam','03/10/1995',N'564/1/3F Nguyễn Xí',N'09131620000',N'Nghệ An','05/01/2017',null),
 (N'NV0005',N'Phan', N'Thanh Tâm',N'Nữ','03/03/1996',N'306 Nguyễn Trọng Tuyển',N'09186223333',N'Đồng Nai','08/01/2017',null),
 (N'NV0006',N'Mai', N'Thị Lựu',N'Nữ','06/25/1992',N'256/96/4 Phan Đăng Lưu',N'09181831444',N'TP.HCM','03/01/2017',null),
 (N'NV0007',N'Đào', N'Thị Hồng',N'Nữ','03/18/1999',N'764/94 Phạm Văn Chiêu',N'09754322222',N'TP.HCM','03/01/2017',null),
 (N'NV0008',N'Phan', N'Thành Nhân',N'Nam','10/07/1998',N'152 Nguyễn Trọng Tuyển',N'09135332332',N'TP.HCM','09/01/2018',null),
 (N'NV0009',N'Nguyễn', N'Ánh Dương',N'Nữ','12/01/2000',N'65 Nam Kỳ Khởi Nghĩa',N'09812127678',N'Tiền Giang','05/01/2018',null),
 (N'NV0010',N'Phan', N'Ánh Nguyệt',N'Nữ','12/28/1997',N'32/65/9 Trần Cao Vân',N'09812342356',N'Đà Nẵng','05/01/2018',null),
 (N'NV0011',N'Lê', N'Thị Cúc',N'Nữ','04/05/2000',N'334 Phan Văn Trị',N'0389297475',N'Vũng Tàu','05/01/2018',null),
 (N'NV0012',N'Mai', N'Minh Mẫn',N'Nam','12/25/1995',N'58 Trần Bình Trọng',N'0883215763',N'Nha Trang','06/01/2019',null),
 (N'NV0013',N'Võ', N'Minh Hoàng',N'Nam','01/20/2000',N'310 Lê Quang Định',N'0982742175',N'Long An','06/01/2019',null),
 (N'NV0014',N'Lê', N'Trung Kiệt',N'Nam','10/10/1999',N'28 Nguyễn An Ninh',N'0398458351',N'Đà Nẵng','06/01/2019',null),
 (N'NV0015',N'Trần', N'Trọng Duy',N'Nam','02/25/2000',N'258 Dương Quảng hàm',N'0918670347',N'Tiền Giang','06/01/2019',null),
 (N'NV0016',N'Phan', N'Nhật Hạ',N'Nữ','06/29/2000',N'470 Nguyễn Thái Sơn',N'08858454874',N'Vũng Tàu','09/07/2019',null),
 (N'NV0017',N'Trần', N'Minh Thư',N'Nữ','02/15/1999',N'174 Bùi Đình Túy',N'08898454182',N'Nha Trang','09/07/2019',null),
 (N'NV0018',N'Nguyễn', N'Bảo Duy',N'Nam','09/28/1998',N'240 Nguyễn Xí',N'09638454084',N'Đồng Nai','09/07/2019',null),
 (N'NV0019',N'Trịnh', N'Kim Chi',N'Nữ','02/02/1995',N'791 Nguyễn Kiệm',N'08532454895',N'TP.HCM','09/07/2019',null),
 (N'NV0020',N'Lê', N'Ngọc Thanh',N'Nữ','05/07/2000',N'267 Chu Văn An',N'08979254186',N'Đà Nẵng','09/07/2019',null)

 -- 2. Tài khoản
 insert into TaiKhoan values('nv0001','12345678*', N'Nhân Viên','NV0001')
 insert into TaiKhoan values('nv0002','12345678*', N'Nhân Viên','NV0002')
 insert into TaiKhoan values('nv0003','12345678*', N'Nhân Viên','NV0003')
 insert into TaiKhoan values('nv0004','12345678*', N'Nhân Viên','NV0004')
 insert into TaiKhoan values('nv0005','12345678*', N'Nhân Viên','NV0005')
 insert into TaiKhoan values('nv0006','12345678*', N'Nhân Viên','NV0006')
 insert into TaiKhoan values('nv0007','12345678*', N'Nhân Viên','NV0007')
 insert into TaiKhoan values('nv0008','12345678*', N'Nhân Viên','NV0008')
 insert into TaiKhoan values('nv0009','12345678*', N'Nhân Viên','NV0009')
 insert into TaiKhoan values('nv0010','12345678*', N'Nhân Viên','NV0010')
 insert into TaiKhoan values('nv0011','12345678*', N'Nhân Viên','NV0011')
 insert into TaiKhoan values('nv0012','12345678*', N'Nhân Viên','NV0012')
 insert into TaiKhoan values('nv0013','12345678*', N'Nhân Viên','NV0013')
 insert into TaiKhoan values('nv0014','12345678*', N'Nhân Viên','NV0014')
 insert into TaiKhoan values('nv0015','12345678*', N'Nhân Viên','NV0015')
 insert into TaiKhoan values('nv0016','12345678*', N'Nhân Viên','NV0016')
 insert into TaiKhoan values('n00v17','12345678*', N'Nhân Viên','NV0017')
 insert into TaiKhoan values('n00v18','12345678*', N'Nhân Viên','NV0018')
 insert into TaiKhoan values('n00v19','12345678*', N'Nhân Viên','NV0019')
 insert into TaiKhoan values('n00v20','12345678*', N'Nhân Viên','NV0020')
 insert into TaiKhoan values('quanly','12345678*', N'Quản Lý', NULL)

  --3.Loại sản phẩm
insert into LoaiSanPham values('LSP001',N'Bút',null)
insert into LoaiSanPham values('LSP002',N'Vở Sổ',null)
insert into LoaiSanPham values('LSP003',N'Thước',null)
insert into LoaiSanPham values('LSP004',N'Máy Tính',null)
insert into LoaiSanPham values('LSP005',N'Đồ Chơi',null)
insert into LoaiSanPham values('LSP006',N'Khác',null)

--4. Nhà cung cấp
insert into NhaCungCap values('NCC001',N'Công ty cổ phần tập đoàn Thiên Long', N'Số 10 Đường Mai Chí Thọ','02837505555','info@thienlonggroup.com') 
insert into NhaCungCap values('NCC002',N'Faber-Castell',N'224 Nguyễn Phúc Nguyên','02838616768','greenbee.faber@gmail.com') 
insert into NhaCungCap values('NCC003',N'STABILO Viet Nam',N'28/8 Đặng Văn Ngữ','0983066228','stabilo@thaia-vn.com')
insert into NhaCungCap values('NCC004',N'Đồ chơi LEGO Việt Nam',N'Quận Gò Vấp, TP.HCM','0907660011','legohouse.vn@gmail.com')
insert into NhaCungCap values('NCC005',N'Công Ty TNHH Miniso Việt Nam',N'81 Cao Thắng','0888826776','support@minisovietnam.vn')
insert into NhaCungCap values('NCC006',N'Đại Lý  Phân Phối Casio Tại  Việt Nam',N'187 Phố Vọng','0903472299','Casiovietnam.net@gmail.com')
insert into NhaCungCap values('NCC007',N'Crabit Notebuck',N'Số 5 ngõ 379 Hoàng Hoa Thám','0988782832','info@crabit.vn')
insert into NhaCungCap values('NCC008',N'Công ty TNHH K.LONG',N'Số 36 ngõ 259 Phố Vọng','02436621359','info@klong.com.vn')
insert into NhaCungCap values('NCC009',N'Ann Store',N'101A Nguyễn Khuyến','0902221723','online@annstore.vn')
insert into NhaCungCap values('NCC010',N'Cửa hàng JOLA',N'120 Trần Minh Quyền','0383980923','sale.jola.vn@gmail.com')

--5.Sản phẩm
insert into SanPham values('BU0001',N'Bút Bi', 2000, N'Cây', 6800,'LSP001','NCC001')
insert into SanPham values('BU0002',N'Bút Chì', 1500, N'Cây', 7000,'LSP001','NCC002')
insert into SanPham values('BU0003',N'Bút Chì Màu', 400, N'Hộp', 76000,'LSP001','NCC002')
insert into SanPham values('BU0004',N'Bút Dạ Quang', 600, N'Hộp', 50000,'LSP001','NCC003')
insert into SanPham values('BU0005',N'Bút Gel', 1600, N'Cây', 8000,'LSP001','NCC001')
insert into SanPham values('BU0006',N'Bút Lông Màu', 600, N'Hộp', 68000,'LSP001','NCC001')
insert into SanPham values('BU0007',N'Bút Sáp Màu', 700, N'Hộp', 86000,'LSP001','NCC002')
insert into SanPham values('BU0008',N'Bút Xóa', 2000, N'Cây', 29000,'LSP001','NCC001')
insert into SanPham values('DC0001',N'Đồ Chơi Gấu Bông', 300, N'Cái', 195000,'LSP005','NCC005')
insert into SanPham values('DC0002',N'Đồ Chơi Búp Bê', 400, N'Cái', 299000,'LSP005','NCC005')
insert into SanPham values('DC0003',N'Đồ Chơi Xe Điều Khiển', 500, N'Cái', 399000,'LSP005','NCC010')
insert into SanPham values('DC0004',N'Đồ Chơi Xếp Hình', 600, N'Cái', 144000,'LSP005','NCC004')
insert into SanPham values('KA0001',N'Ba Lô Disney', 400, N'Cái', 399000,'LSP006','NCC009')
insert into SanPham values('KA0002',N'Ba Lô Mickey', 500, N'Cái', 399000,'LSP006','NCC009')
insert into SanPham values('KA0003',N'Đồ Chuốt Bút Chì', 1000, N'Cái', 3400,'LSP006','NCC002')
insert into SanPham values('KA0004',N'Compa', 700, N'Cái', 15300,'LSP006','NCC001')
insert into SanPham values('KA0005',N'Dao Rọc Giấy', 500, N'Cái', 22000,'LSP006','NCC001')
insert into SanPham values('KA0006',N'Giấy Thủ Công', 2000, N'Bộ', 29000,'LSP006','NCC001')
insert into SanPham values('KA0007',N'Gôm', 1800, N'Cái', 6000,'LSP006','NCC002')
insert into SanPham values('KA0008',N'Hộp Bút Captain', 500, N'Cái', 175000,'LSP006','NCC001')
insert into SanPham values('KA0009',N'Hộp Bút Minnie', 600, N'Cái', 175000,'LSP006','NCC001')
insert into SanPham values('KA0010',N'Kéo', 1500, N'Cái', 25000,'LSP006','NCC001')
insert into SanPham values('KA0011',N'Hồ Dán', 1200, N'Cái', 4000,'LSP006','NCC001')
insert into SanPham values('KA0012',N'Kẹp Giấy', 800, N'Hộp', 59000,'LSP006','NCC001')
insert into SanPham values('KA0013',N'Sáp Nặn', 600, N'Bộ', 29000,'LSP006','NCC001')
insert into SanPham values('KA0014',N'Túi Rút Minnie', 600, N'Cái', 133000,'LSP006','NCC009')
insert into SanPham values('KA0015',N'Túi Rút Spider Man', 700, N'Cái', 133000,'LSP006','NCC009')
insert into SanPham values('MT0001',N'Máy Tính FX580-VN', 1700, N'Cái', 520000,'LSP004','NCC006')
insert into SanPham values('MT0002',N'Máy Tính FX590-VN', 1400, N'Cái', 569000,'LSP004','NCC001')
insert into SanPham values('MT0003',N'Máy Tính FX680-VN', 1100, N'Cái', 679000,'LSP004','NCC001')
insert into SanPham values('MT0004',N'Máy Tính FX799-VN', 900, N'Cái', 669000,'LSP004','NCC001')
insert into SanPham values('TH0001',N'Thước Bộ', 700, N'Bộ', 18000,'LSP003','NCC001')
insert into SanPham values('TH0002',N'Thước Dẻo', 300, N'Cái', 9000,'LSP003','NCC001')
insert into SanPham values('TH0003',N'Thước Nhựa', 500, N'Cái', 18000,'LSP003','NCC002')
insert into SanPham values('VS0001',N'Sổ Lò Xo Kép', 2000, N'Quyển', 69000,'LSP002','NCC008')
insert into SanPham values('VS0002',N'Sổ Lò Xo Đơn', 1000, N'Quyển', 45000,'LSP002','NCC008')
insert into SanPham values('VS0003',N'Vở Học Sinh 96 Trang', 3000, N'Quyển', 9000,'LSP002','NCC001')
insert into SanPham values('VS0004',N'Vở Học Sinh 200 Trang', 3000, N'Quyển', 18000,'LSP002','NCC001')
insert into SanPham values('VS0005',N'Vở Crabit Kẻ Ngang', 900, N'Quyển', 18000,'LSP002','NCC007')
insert into SanPham values('VS0006',N'Vở Crabit Ô Vuông', 1200, N'Quyển', 21000,'LSP002','NCC007')

-- 6. Cửa hàng
insert into CuaHang values('CH0001',N'Nhà sách Văn Lang', N'40 - 42 Nguyễn Thị Minh Khai', '02838233022', N'Phan Văn Tài');
insert into CuaHang values('CH0002',N'Nhà sách Nguyễn Văn Cừ', N'188 Võ Văn Ngân', '0931849751', N'Lâm Văn Bền');
insert into CuaHang values('CH0003',N'Nhà sách Tân Bình', N'364 Trường Chinh', '02838122847',N'Trần Thị Mơ');
insert into CuaHang values('CH0004',N'Nhà Sách Huy Hoàng', N'357A Lê Văn Sỹ', '02437365859', N'Trần Ngọc Mai');
insert into CuaHang values('CH0005',N'Nhà sách Nhân Văn', N'01 Trường Chinh', '02836367777', N'Phan Duy Tâm');
insert into CuaHang values('CH0006',N'Nhà sách Fabico', N'604 Cách Mạng Tháng 8', '02743822062', N'Lê Duy Khánh');
insert into CuaHang values('CH0007',N'Nhà sách Tân Phú', N'212 Nguyễn Sơn', '02838607127', N'Phạm Tùng Dương');
insert into CuaHang values('CH0008',N'Nhà sách Cá Chép', N'211 - 213 Võ Văn Tần', '02862906951', N'Võ Ngọc Tâm');
insert into CuaHang values('CH0009',N'Nhà sách Nhã Nam', N'Nguyễn Văn Bình', '02435146875', N'Nguyễn Phương Dung');
insert into CuaHang values('CH0010',N'Nhà sách Tổng Hợp', N'62 Nguyễn Thị Minh Khai', '02838238191', N'Đặng Ngọc Nam');

--7.Khách hàng
insert into KhachHang values
(N'KH0001',N'Lê Minh Ngọc',N'123/6 bis Lê Thánh Tôn',N'04/26/2000',N'098123123',N'Có'),
(N'KH0002',N'Bùi Minh Tuấn',N'49/12B Nguyễn Thị Minh Khai',N'05/07/2001',N'091321321',N'Có'),
(N'KH0003',N'Lâm Bảo Anh',N'Ngõ 6, phố Thanh Xuân',N'03/26/2000',N'090312312',N'Không'),
(N'KH0004',N'Đoàn Minh Khánh',N'67 bis Nguyễn Thượng Hiền',N'09/29/1999',N'090812812',N'Không'),
(N'KH0005',N'Ngô Đức Thịnh',N'41 Xóm Củi',N'10/02/2000',N'02116584446',N'Không'),
(N'KH0006',N'Lê Phương Minh',N'31 Nguyễn Xí',N'01/20/2001',N'02116584447',N'Không'),
(N'KH0007',N'Nguyễn Lê Khương',N'1110 Phan Văn Trị',N'07/15/1998',N'02116584448',N'Có'),
(N'KH0008',N'Phạm Minh Đức',N'91 Thống Nhất',N'07/26/2003',N'02116584449',N'Có'),
(N'KH0009',N'Đỗ Hồng Nhung',N'71 Quang Trung',N'08/20/2002',N'02116584441',N'Không'),
(N'KH0010',N'Nguyễn Bảo Hưng',N'21 Chu Văn An',N'09/21/2005',N'02116584442',N'Có'),
(N'KH0011',N'Lê Thùy Linh',N'71 Huỳnh Thúc Kháng',N'04/25/2005',N'0985278934',N'Có'),
(N'KH0012',N'Đinh Huy Khánh',N'93 Quốc lộ 13',N'04/17/2000',N'0987855432',N'Không'),
(N'KH0013',N'Vũ Lê Duy',N'455 Xô Viết Nghệ Tĩnh',N'09/29/2000',N'0347098766',N'Không'),
(N'KH0014',N'Đỗ Thúy Vy',N'12 Nguyễn Oanh',N'06/26/1996',N'098987123',N'Có'),
(N'KH0015',N'Nguyễn Khánh Nguyên',N'34 Lê Quang Định',N'04/30/2005',N'098123787',N'Không'),
(N'KH0016',N'Đỗ Thu Hồng',N'16 Trương Định',N'10/22/2003',N'038145123',N'Không'),
(N'KH0017',N'Lê Thụy Vân',N'12 Nguyễn Gia Trí',N'11/30/2000',N'098123345',N'Không'),
(N'KH0018',N'Phạm Minh Phương',N'54 Lê Văn Việt',N'04/10/2005',N'098678129',N'Có'),
(N'KH0019',N'Phạm Minh Châu',N'89 Lã Xuân Oai',N'05/19/2002',N'098567345',N'Không'),
(N'KH0020',N'Vũ Thị Liên',N'46 Võ Văn Hát',N'05/12/1999',N'038678456',N'Không')

--8.Phiếu Nhập
insert into PhieuNhap values('PN0001', N'04/05/2023', NULL,N'Chuyển khoản', 'NV0005', 'NCC001');
insert into PhieuNhap values('PN0002', N'05/05/2023', NULL,N'Chuyển khoản', 'NV0009', 'NCC006');
insert into PhieuNhap values('PN0003', N'06/15/2023', NULL,N'Chuyển khoản', 'NV0010', 'NCC008');
insert into PhieuNhap values('PN0004', N'07/15/2023', NULL,N'Chuyển khoản', 'NV0001', 'NCC001');
insert into PhieuNhap values('PN0005', N'08/09/2023', NULL,N'Chuyển khoản', 'NV0003', 'NCC004');
insert into PhieuNhap values('PN0006', N'09/09/2023', NULL,N'Chuyển khoản', 'NV0008', 'NCC006');
insert into PhieuNhap values('PN0007', N'10/03/2023', NULL,N'Chuyển khoản', 'NV0010', 'NCC005');
insert into PhieuNhap values('PN0008', N'10/03/2023', NULL,N'Chuyển khoản', 'NV0002', 'NCC002');
insert into PhieuNhap values('PN0009', N'11/25/2023', NULL,N'Chuyển khoản', 'NV0004', 'NCC008');
insert into PhieuNhap values('PN0010', N'11/25/2023', NULL,N'Chuyển khoản', 'NV0009', 'NCC003');
insert into PhieuNhap values('PN0011', N'11/25/2023', NULL,N'Chuyển khoản', 'NV0017', 'NCC002');
insert into PhieuNhap values('PN0012', N'01/30/2024', NULL,N'Chuyển khoản', 'NV0020', 'NCC005');
insert into PhieuNhap values('PN0013', N'01/30/2024', NULL,N'Chuyển khoản', 'NV0018', 'NCC008');
insert into PhieuNhap values('PN0014', N'02/20/2024', NULL,N'Chuyển khoản', 'NV0015', 'NCC009');
insert into PhieuNhap values('PN0015', N'03/20/2024', NULL,N'Chuyển khoản', 'NV0007', 'NCC007');
insert into PhieuNhap values('PN0016', N'04/26/2024', NULL,N'Chuyển khoản', 'NV0004', 'NCC010');
insert into PhieuNhap values('PN0017', N'05/20/2024', NULL,N'Chuyển khoản', 'NV0013', 'NCC007');
insert into PhieuNhap values('PN0018', N'06/01/2024', NULL,N'Chuyển khoản', 'NV0002', 'NCC008');
insert into PhieuNhap values('PN0019', N'06/02/2024', NULL,N'Chuyển khoản', 'NV0001', 'NCC005');
insert into PhieuNhap values('PN0020', N'06/02/2024', NULL,N'Chuyển khoản', 'NV0008', 'NCC002');

--9.Phiếu Xuất
insert into PhieuXuat values('PX0001', N'05/13/2023', N'Chuyển khoản', 'NV0001', 'CH0005');
insert into PhieuXuat values('PX0002', N'05/20/2023', N'Chuyển khoản', 'NV0007', 'CH0002');
insert into PhieuXuat values('PX0003', N'06/01/2023', N'Chuyển khoản', 'NV0016', 'CH0001');
insert into PhieuXuat values('PX0004', N'06/02/2023', N'Chuyển khoản', 'NV0009', 'CH0004');
insert into PhieuXuat values('PX0005', N'07/15/2023', N'Chuyển khoản', 'NV0004', 'CH0003');
insert into PhieuXuat values('PX0006', N'08/31/2023', N'Chuyển khoản', 'NV0001', 'CH0007');
insert into PhieuXuat values('PX0007', N'09/15/2023', N'Chuyển khoản', 'NV0002', 'CH0003');
insert into PhieuXuat values('PX0008', N'10/31/2023', N'Chuyển khoản', 'NV0005', 'CH0003');
insert into PhieuXuat values('PX0009', N'11/15/2023', N'Chuyển khoản', 'NV0005', 'CH0001');
insert into PhieuXuat values('PX0010', N'12/30/2023', N'Chuyển khoản', 'NV0003', 'CH0004');
insert into PhieuXuat values('PX0011', N'01/16/2024', N'Chuyển khoản', 'NV0014', 'CH0003');
insert into PhieuXuat values('PX0012', N'01/31/2024', N'Chuyển khoản', 'NV0018', 'CH0008');
insert into PhieuXuat values('PX0013', N'02/19/2024', N'Chuyển khoản', 'NV0010', 'CH0006');
insert into PhieuXuat values('PX0014', N'03/28/2024', N'Chuyển khoản', 'NV0019', 'CH0009');
insert into PhieuXuat values('PX0015', N'04/18/2024', N'Chuyển khoản', 'NV0020', 'CH0003');
insert into PhieuXuat values('PX0016', N'04/30/2024', N'Chuyển khoản', 'NV0014', 'CH0005');
insert into PhieuXuat values('PX0017', N'05/19/2024', N'Chuyển khoản', 'NV0010', 'CH0004');
insert into PhieuXuat values('PX0018', N'05/31/2024', N'Chuyển khoản', 'NV0001', 'CH0002');
insert into PhieuXuat values('PX0019', N'06/01/2024', N'Chuyển khoản', 'NV0002', 'CH0010');
insert into PhieuXuat values('PX0020', N'06/02/2024', N'Chuyển khoản', 'NV0003', 'CH0003');

--10.Hóa đơn
insert into HoaDon values('HD0001', N'06/04/2023', N'Chuyển khoản', 'NV0004', 'KH0006');
insert into HoaDon values('HD0002', N'07/09/2023', N'Chuyển khoản', 'NV0009', 'KH0001');
insert into HoaDon values('HD0003', N'07/15/2023', N'Chuyển khoản', 'NV0008', 'KH0003');
insert into HoaDon values('HD0004', N'08/25/2023', N'Tiền mặt', 'NV0001', 'KH0009');
insert into HoaDon values('HD0005', N'09/04/2023', N'Chuyển khoản', 'NV0009', 'KH0010');
insert into HoaDon values('HD0006', N'10/20/2023', N'Chuyển khoản', 'NV0003', 'KH0002');
insert into HoaDon values('HD0007', N'11/04/2023', N'Chuyển khoản', 'NV0002', 'KH0008');
insert into HoaDon values('HD0008', N'11/20/2023', N'Chuyển khoản', 'NV0001', 'KH0011');
insert into HoaDon values('HD0009', N'12/08/2023', N'Tiền mặt', 'NV0010', 'KH0004');
insert into HoaDon values('HD0010', N'12/10/2023', N'Tiền mặt', 'NV0019', 'KH0007');
insert into HoaDon values('HD0011', N'12/22/2023', N'Chuyển khoản', 'NV0020', 'KH0005');
insert into HoaDon values('HD0012', N'01/06/2024', N'Chuyển khoản', 'NV0005', 'KH0012');
insert into HoaDon values('HD0013', N'02/03/2024', N'Chuyển khoản', 'NV0015', 'KH0018');
insert into HoaDon values('HD0014', N'02/18/2024', N'Tiền mặt', 'NV0017', 'KH0013');
insert into HoaDon values('HD0015', N'03/03/2024', N'Chuyển khoản', 'NV0018', 'KH0015');
insert into HoaDon values('HD0016', N'03/26/2024', N'Chuyển khoản', 'NV0014', 'KH0014');
insert into HoaDon values('HD0017', N'04/04/2024', N'Tiền mặt', 'NV0010', 'KH0016');
insert into HoaDon values('HD0018', N'05/15/2024', N'Chuyển khoản', 'NV0001', 'KH0011');
insert into HoaDon values('HD0019', N'06/01/2024', N'Chuyển khoản', 'NV0007', 'KH0017');
insert into HoaDon values('HD0020', N'06/02/2024', N'Tiền mặt', 'NV0012', 'KH0008');

-- 11. Chi tiết phiếu nhập
insert into CTPhieuNhap values 
( 'PN0001','BU0001',3000,4200),
( 'PN0001','KA0005',1000,12000),
( 'PN0004','BU0006',1500,50000),
( 'PN0008','BU0007',1200,60000),
( 'PN0020','KA0007',2000,4000),
( 'PN0014','KA0015',1100,90000),
( 'PN0003','VS0001',2500,50000),
( 'PN0003','VS0002',2000,25000),
( 'PN0007','DC0001',280,130000),
( 'PN0011','BU0003',265,45000),
( 'PN0016','DC0003',600,200000),
( 'PN0005','DC0004',450,94000),
( 'PN0010','BU0004',2500,32000),
( 'PN0004','MT0003',450,455000),
( 'PN0002','MT0001',350,320000),
( 'PN0009','VS0001',700,50000),
( 'PN0009','VS0002',500,25000),
( 'PN0007','DC0002',400,200000),
( 'PN0017','VS0005',1000,9000),
( 'PN0001','TH0001',500,9000),
( 'PN0018','VS0001',700,25000),
( 'PN0004','KA0004',400,8500),
( 'PN0004','KA0010',300,15000),
( 'PN0018','VS0002',700,50000),
( 'PN0011','KA0007',2000,4000),
( 'PN0006','MT0001',450,320000),
( 'PN0012','DC0002',300,200000),
( 'PN0013','VS0002',500,25000),
( 'PN0015','VS0005',2500,9000),
( 'PN0019','DC0001',280,130000)

-- 12. Chi tiết phiếu xuất
insert into CTPhieuXuat values('PX0004','BU0007',500,76000);
insert into CTPhieuXuat values('PX0002','DC0002',300,289000);
insert into CTPhieuXuat values('PX0009','KA0010',400,20000);
insert into CTPhieuXuat values('PX0010','KA0009',600,165000);
insert into CTPhieuXuat values('PX0017','DC0001',400,185000);
insert into CTPhieuXuat values('PX0002','VS0005',540,14000);
insert into CTPhieuXuat values('PX0004','TH0002',500,7000);
insert into CTPhieuXuat values('PX0009','KA0015',280,123000);
insert into CTPhieuXuat values('PX0001','KA0009',480,165000);
insert into CTPhieuXuat values('PX0005','MT0004',400,659000);
insert into CTPhieuXuat values('PX0003','KA0012',300,49000);
insert into CTPhieuXuat values('PX0015','BU0008',400,25000);
insert into CTPhieuXuat values('PX0019','VS0001',600,65000);
insert into CTPhieuXuat values('PX0020','KA0004',540,11500);
insert into CTPhieuXuat values('PX0013','KA0014',430,123000);
insert into CTPhieuXuat values('PX0010','BU0007',300,76000);
insert into CTPhieuXuat values('PX0011','VS0006',510,18000);
insert into CTPhieuXuat values('PX0001','KA0008',500,165000);
insert into CTPhieuXuat values('PX0006','TH0003',610,14000);
insert into CTPhieuXuat values('PX0007','DC0002',430,289000);
insert into CTPhieuXuat values('PX0008','BU0003',300,66000);
insert into CTPhieuXuat values('PX0012','VS0005',610,14000);
insert into CTPhieuXuat values('PX0014','DC0001',430,185000);
insert into CTPhieuXuat values('PX0016','KA0003',710,3000);
insert into CTPhieuXuat values('PX0018','TH0002',420,7000);
insert into CTPhieuXuat values('PX0007','VS0006',300,18000);
insert into CTPhieuXuat values('PX0013','KA0008',610,165000);
insert into CTPhieuXuat values('PX0001','MT0003',315,669000);
insert into CTPhieuXuat values('PX0019','TH0003',510,14000);
insert into CTPhieuXuat values('PX0020','VS0004',430,14000);

-- 13. Chi tiết hóa đơn
insert into CTHoaDon values
(N'HD0003','BU0007',2,86000),
(N'HD0001','VS0006',3,21000),
(N'HD0009','KA0012',5,59000),
(N'HD0005','BU0008',10,29000),
(N'HD0014','TH0002',2,9000),
(N'HD0018','KA0009',8,175000),
(N'HD0020','KA0011',7,4000),
(N'HD0007','VS0001',5,69000),
(N'HD0002','BU0005',3,8000),
(N'HD0003','MT0004',4,669000),
(N'HD0010','VS0006',3,21000),
(N'HD0011','TH0003',10,18000),
(N'HD0017','KA0007',50,6000),
(N'HD0016','KA0010',3,25000),
(N'HD0014','VS0005',4,18000),
(N'HD0015','MT0001',2,520000),
(N'HD0020','VS0002',30,45000),
(N'HD0004','BU0002',5,7000),
(N'HD0006','DC0004',2,144000),
(N'HD0007','BU0001',3,6800),
(N'HD0008','BU0008',4,29000),
(N'HD0012','VS0003',3,9000),
(N'HD0013','DC0004',2,144000),
(N'HD0019','KA0001',5,399000),
(N'HD0007','TH0002',3,9000),
(N'HD0008','BU0007',4,86000),
(N'HD0012','VS0004',3,18000),
(N'HD0013','KA0004',2,15300),
(N'HD0019','DC0001',5,195000),
(N'HD0007','VS0006',3,21000)

-- RÀNG BUỘC TOÀN VẸN --
-- 1. Số lượng tồn của sản phẩm phải luôn lớn hơn hoặc bằng 0.
create trigger tg_SLTon_LonHon_0
on SanPham
For insert, update
as
if exists (select * from inserted where inserted.SLTon < 0)
	begin
		print(N'Số lượng tồn phải lớn hơn hoặc bằng 0. Thao tác không thành công')
		rollback tran
	end

-- 2. Mỗi loại sản phẩm phải có ít nhất một sản phẩm
CREATE TRIGGER tg_LoaiSanPham
ON SanPham
AFTER UPDATE, DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM LoaiSanPham lsp
        LEFT JOIN SanPham sp ON lsp.MaloaiSP = sp.MaloaiSP
        GROUP BY lsp.MaloaiSP
        HAVING COUNT(sp.MaloaiSP) = 0
    )
    BEGIN
        PRINT N'Loại Sản Phẩm phải có ít nhất một sản phẩm. Thao tác không thành công.'
        ROLLBACK TRANSACTION
    END
END

-- 3. Số lượng tồn của sản phẩm sẽ được cập nhật khi sản phẩm đó được xuất ra
CREATE TRIGGER tg_CapNhatSLTon_Xuat
ON CTPhieuXuat
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    -- INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon - i.SoLuong
        FROM inserted i
        WHERE SanPham.MaSP = i.MaSP;
    END

    -- DELETE
    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + d.SoLuong
        FROM deleted d
        WHERE SanPham.MaSP = d.MaSP;
    END

    -- UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + (d.SoLuong - i.SoLuong)
        FROM inserted i
        JOIN deleted d ON i.MaSP = d.MaSP
        WHERE SanPham.MaSP = i.MaSP;
    END
END


-- 4. Số lượng tồn của sản phẩm sẽ được cập nhật khi sản phẩm đó được bán ra
CREATE TRIGGER tg_CapNhatSLTon_Ban
ON CTHoaDon
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    -- INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon - i.SoLuong
        FROM inserted i
        WHERE SanPham.MaSP = i.MaSP;
    END

    -- DELETE
    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + d.SoLuong
        FROM deleted d
        WHERE SanPham.MaSP = d.MaSP;
    END

    -- UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + (d.SoLuong - i.SoLuong)
        FROM inserted i
        JOIN deleted d ON i.MaSP = d.MaSP
        WHERE SanPham.MaSP = i.MaSP;
    END
END


-- 5.  Số lượng tồn của sản phẩm sẽ được cập nhật khi sản phẩm đó được nhập vào
CREATE TRIGGER tg_CapNhatSLTon_Nhap
ON CTPhieuNhap
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    -- INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + i.SoLuong
        FROM inserted i
        WHERE SanPham.MaSP = i.MaSP;
    END

    -- DELETE
    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon - d.SoLuong
        FROM deleted d
        WHERE SanPham.MaSP = d.MaSP;
    END

    -- UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE SanPham
        SET SLTon = SanPham.SLTon + (i.SoLuong - d.SoLuong)
        FROM inserted i
        JOIN deleted d ON i.MaSP = d.MaSP
        WHERE SanPham.MaSP = i.MaSP;
    END
END


-- CHART ----
-- 1. view top 5 sản phẩm bán chạy nhất (Hóa đơn)
create view Top5_BanChay_HD 
as
select top(5)TenSP, sum(SoLuong) as DoanhSo
from CTHoaDon cthd join SanPham sp on cthd.MaSP = sp.MaSP
group by TenSP
order by sum(SoLuong) desc

-- 2. view top 5 sản phẩm bán chạy nhất (Phiếu xuất)
create view Top5_BanChay_PX 
as
select top(5)TenSP, sum(SoLuong) as DoanhSo
from CTPhieuXuat ctpx join SanPham sp on ctpx.MaSP = sp.MaSP
group by TenSP
order by sum(SoLuong) desc

-- 3. view top 5 doanh thu bán hàng (Hóa đơn)
CREATE VIEW Top5_DoanhThu_HD AS
SELECT top(5) p.MaSP, p.TenSP,
  SUM(cthd.SoLuong * cthd.DonGiaBan) AS DoanhThu
FROM SanPham p
JOIN CTHoaDon cthd ON p.MaSP = cthd.MaSP
JOIN HoaDon hd ON cthd.MaHD = hd.MaHD
JOIN SanPham s ON p.MaSP = s.MaSP
GROUP BY p.MaSP, p.TenSP
ORDER BY SUM(cthd.SoLuong * cthd.DonGiaBan) desc;

-- 4. view top 5 doanh thu bán hàng (px)
CREATE VIEW Top5_DoanhThu_PX AS
SELECT top(5) p.MaSP, p.TenSP,
  SUM(ctpx.SoLuong * ctpx.DonGiaXuat) AS DoanhThu
FROM SanPham p
JOIN CTPhieuXuat ctpx ON p.MaSP = ctpx.MaSP
JOIN PhieuXuat px ON ctpx.SoPX = px.SoPX
JOIN SanPham s ON p.MaSP = s.MaSP
GROUP BY p.MaSP, p.TenSP
ORDER BY SUM(ctpx.SoLuong * ctpx.DonGiaXuat) desc;

---- REPORT  ------
-- 1. SẢN PHẨM
create view ViewSP
as
select SP.MaSP, TenSP, SLTon, DonViTinh, TenloaiSP, MaNCC, DonGiaBan
from SanPham SP 
	join LoaiSanPham LSP on SP.MaloaiSP = LSP.MaloaiSP

-- 2. BÁO CÁO KẾT QUẢ HĐ KINH DOANH HD
create view ViewBCKQHD_HD
as
select HD.MaHD, NV.MaNV, HoNV+' '+TenNV AS HoTenNV, NgayDH, sum(SoLuong) as DoanhSo, sum(SoLuong*SP.DonGiaBan) as DoanhThu
from SanPham SP join
	CTHoaDon CTHD on SP.MaSP = CTHD.MaSP join
	HoaDon HD on HD.MaHD = CTHD.MaHD join
	NhanVien NV on NV.MaNV = HD.MaNV
group by  HD.MaHD, NV.MaNV,HoNV+' '+TenNV, NgayDH

-- 3. BÁO CÁO KẾT QUẢ HĐ KINH DOANH PX
create view ViewBCKQHD_PX
as
select PX.SoPX , NV.MaNV, HoNV+' '+TenNV AS HoTenNV, NgayXuat, sum(SoLuong) as DoanhSo, sum(SoLuong*DonGiaXuat) as DoanhThu
from SanPham SP join
	CTPhieuXuat CTPX on SP.MaSP = CTPX.MaSP join
	PhieuXuat PX on PX.SoPX = CTPX.SoPX join
	NhanVien NV on NV.MaNV = PX.MaNV
group by  PX.SoPX , NV.MaNV, HoNV+' '+TenNV, NgayXuat

-- 4. BÁO CÁO KẾT QUẢ PHIẾU NHẬP
create view ViewBaoCaoPhieuNhap
as
select PN.SoPN , SP.MaSP, TenSP, NgayNhap,  SoLuong, sum(SoLuong*DonGia) as ChiPhi
from SanPham SP join
	CTPhieuNhap CTPN on SP.MaSP = CTPN.MaSP join
	PhieuNhap PN on PN.SoPN = CTPN.SoPN join
	NhanVien NV on NV.MaNV = PN.MaNV
group by  PN.SoPN , SP.MaSP, TenSP, NgayNhap, SoLuong