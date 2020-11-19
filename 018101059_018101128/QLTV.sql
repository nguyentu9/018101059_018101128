create database QLTV
go
use QLTV
go

create table TACGIA (
	MATG varchar(10) primary key(MATG),
	TENTACGIA nvarchar(40)
)
go
create table KHOA (
	MAKHOA varchar(10) primary key(MAKHOA),
	TENKHOA nvarchar(40)
)
go
create table LOAI(
	MATL varchar(10) primary key(MATL),
	TENTHELOAI nvarchar(40),
	MAKHOA varchar(10)

	foreign key(MAKHOA) references KHOA(MAKHOA)
)
go
create table SACH(
	MASH varchar(10) primary key (MASH), 
	TENSACH nvarchar(100), 
	MATL varchar(10), 
	MATG varchar(10), 
	NXB nvarchar(100), 
	NAMSX int,
	SOLUONG int
	
	foreign key (MATL) references LOAI(MATL),
	foreign key (MATG) references TACGIA(MATG),
)
go
create table SINHVIEN(
	MASV varchar(10) primary key (MASV), 
	HOTEN nvarchar(40), 
	GIOITINH bit,
	MAKHOA varchar(10),
	NGAYSINH datetime, 
	DIACHI nvarchar(40), 
	SDT varchar(10)

	foreign key(MAKHOA) references KHOA(MAKHOA)
)
go
create table THETHUVIEN(
	MATHE varchar(10) primary key (MATHE), 
	MASV varchar(10), 
	NGAYCAP datetime, 
	NGAYHETHAN datetime

	foreign key (MASV) references SINHVIEN (MASV)
)
go
create table NHANVIEN(
	MANV varchar(10) primary key (MANV), 
	HOTEN nvarchar(40), 
	NGAYSINH datetime, 
	GIOITINH bit,
	DIACHI nvarchar(40), 
	SDT varchar(10)
)
go
create table PHIEUMUON(
	SOPM varchar(10) primary key (SOPM), 
	NGAYMUON datetime, 
	NGAYTRA datetime, 
	MASV varchar(10), 
	MASH varchar(10), 
	MATHE varchar(10), 
	MANV varchar(10)

	foreign key(MASV) references SINHVIEN(MASV),
	foreign key(MASH) references SACH(MASH),
	foreign key(MATHE) references THETHUVIEN(MATHE),
	foreign key(MANV) references NHANVIEN(MANV)
)
go
create table CTPM (
	SOPM varchar(10) primary key(SOPM, MASH),
	MASH varchar(10),
	SOLUONG int
	
	foreign key(SOPM) references PHIEUMUON(SOPM),
	foreign key(MASH) references SACH(MASH),
)
go

create table NHACC (
	MANCC varchar(10) primary key(MANCC),
	TENNCC nvarchar(40),
	DIACHI nvarchar(40),
	SDT varchar(10)
)
go
create table PHIEUNHAP(
	MAPN varchar(10) primary key(MAPN),
	NGAYNHAP datetime,
	MANCC varchar(10),
	MANV varchar(10)

	foreign key (MANCC) references NHACC(MANCC),
	foreign key (MANV) references NHANVIEN(MANV)
)
go

create table TINHTRANG (
	MATT varchar(10) primary key(MATT),
	TENTT nvarchar(40)
)
go

create table GIAIQUYET (
	MAGQ varchar(10) primary key(MAGQ),
	TENGQ nvarchar(40)
)
go
create table PHIEUBOITHUONG (
	SOBT varchar(10) primary key(SOBT),
	MATT varchar(10),
	MAGQ varchar(10),
	MANV varchar(10),
	MASV varchar(10)

	foreign key (MATT) references TINHTRANG(MATT),
	foreign key (MAGQ) references GIAIQUYET(MAGQ),
	foreign key (MANV) references NHANVIEN(MANV),
	foreign key (MASV) references SINHVIEN(MASV),
)
go

create table TAIKHOAN (
	MATAIKHOAN varchar(10) primary key(MATAIKHOAN),
	TENTAIKHOAN varchar(20) unique,
	MATKHAU varchar(20),
	LOAITK varchar(10) NULL

	foreign key (MATAIKHOAN) references NHANVIEN(MANV)
)


insert into KHOA values ('TN',N'KHOA HỌC TỰ NHIÊN');
insert into KHOA values ('XH', N'KHOA HỌC XÃ HỘI');


insert into LOAI values ('KHXH', N'Khoa học xã hội','XH');
insert into LOAI values ('SP', N'Sư phạm','XH');
insert into LOAI values ('KTCN', N'Kỹ thuật công nghiệp','TN');
insert into LOAI values ('KTXD', N'Kỹ thuật xây dựng','TN');
insert into LOAI values ('KTL', N'Kinh tế-Luật','XH');
insert into LOAI values ('CNTT',N'Công nghệ thông tin','TN');
insert into LOAI values ('NNTP', N'Nông nghiệp-thực phẩm','TN');
insert into LOAI values ('KHTN', N'Khoa học tự nhiên','TN');
insert into LOAI values ('LLCT', N'Lý luận chính trị','XH');


insert into TACGIA values ('TG01',N'Mai Văn Hai');
insert into TACGIA values ('TG02',N'GS.TS Nguyễn Văn Đính');
insert into TACGIA values ('TG03',N'TS.Lê Xuân Vinh');
insert into TACGIA values ('TG04',N'GS.TS.Phạm Ngọc Khánh');
insert into TACGIA values ('TG05',N'GS.TSKH.Nguyễn Minh Thảo');
insert into TACGIA values ('TG06',N'Phí Trọng Hảo');
insert into TACGIA values ('TG07',N'Trần Thế Sang');
insert into TACGIA values ('TG08',N'TS.Trần Xuân Minh');
insert into TACGIA values ('TG09',N'Đinh Vũ Nhân');
insert into TACGIA values ('TG10',N'Nguyễn Nghĩa Thìn');
insert into TACGIA values ('TG11',N'Mai Lê');
insert into TACGIA values ('TG12',N'GS.TS.Nguyên Kim Độ');
insert into TACGIA values ('TG13',N'Nguyẽn Thị Nhung');
insert into TACGIA values ('TG14',N'Trần Tình');

insert into NHANVIEN values ('NV01', N'Nguyễn Thị Hoa',' 1/1/1995','0',N'Vĩnh Long','0987654321');
insert into NHANVIEN values ('NV02', N'Nguyễn Thị Thúy Hiền', '1/1/1990','0',N'Tiền Giang','0287652145');
insert into NHANVIEN values ('NV03', N'Lê Vĩnh Phúc', '1/1/1994','1',N'Bến Tre','0234543223');

insert into SACH values ('VH',N'Xã hội học văn hóa','KHXH','TG01',N'NXB Khoa học xã hội',2004,50);
insert into SACH values ('DLKS',N'Giáo trình kinh tế du lịch','KHXH','TG02',N'NXB Tổng hợp TP.HCM',2005,60);
insert into SACH values ('TH',N'Giáo trình Logic và ứng dụng','SP','TG03',N'NXB Xây dựng',1999,70);
insert into SACH values ('VL',N'Sức bền vật liệu','SP','TG04',N'NXB Xây dựng',1995,80);
insert into SACH values ('HH',N'Các hợp chất dị vòng','SP','TG05',N'NXB Giáo dục',1996,40);
insert into SACH values ('CK',N'Kỹ thuật nguội','KTCN','TG06',N'NXB Giáo dục',2001,50);
insert into SACH values ('CDT',N'Thủy lực và khí nén ','KTCN','TG07',N'NXB khoa học và kỹ thuật',2002,60);
insert into SACH values ('DDT',N'Điện tử công suất','KTCN','TG08',N'NXB Khoa học kỹ thuật',2004,70);
insert into SACH values ('TT',N'Norton ghost chương trình sao chép ổ cứng','CNTT','TG09',N'NXB Thanh Niên',2009,100);
insert into SACH values ('CNSH',N'Hệ thống học thực vật','NNTP','TG10',N'NXB Đại học quốc gia Hà Nội',2005,70);
insert into SACH values ('CNTP',N'Bảo quản lương thực','NNTP','TG11',N'NXB Bách khoa Hà Nội',2007,60);
insert into SACH values ('NTTS',N'Phương pháp và kỹ thuật nuôi cá lồng biển','NNTP','TG12',N'NXB Nông nghiệp',2008,50);
insert into SACH values ('TKT',N'Xác suất Thống kê ứng dụng trong Kinh tế Xã hội','KHTN','TG13',N'NXB Đại học Thăng Long',2010,45);
insert into SACH values ('LL',N'Văn kiện Đảng toàn tập','LLCT','TG14',N'NXB Chính trị Quốc Gia',2006,50);


insert into NHACC values('MLB', N'Minh Long Book' ,N'TP.Hồ Chí Minh', '0987654321');
insert into NHACC values('DTB', N'Định tị Book' ,N'TP.Hồ Chí Minh', '0234543223');
insert into NHACC values('NMB', N'Nhã Nam Book' ,N'Hà Nội', '0287652145');
insert into NHACC values('KDB', N'Kim Đồng Book' ,N'Hà Nội', '0287652145');

insert into SINHVIEN values('SV001',N'Trần Văn Triều','1','XH','1/2/2000',N'Tiền Giang','0287652145');
insert into SINHVIEN values('SV002',N'Nguyễn Thanh Mai','0','TN','2/1/2000',N'Bến Tre','0234543223');

insert into PHIEUNHAP values('PN001','1/9/2006','MLB','NV01');
insert into PHIEUNHAP values('PN002','1/4/2008','DTB','NV02');
insert into PHIEUNHAP values('PN003','10/7/2006','KDB','NV03');

insert into TAIKHOAN(TENTAIKHOAN, MATKHAU, LOAITK) values ('admin', 'admin', 'admin'),
												('toan', '12345', 'admin'),
												('thanh', '12345', 'user');


select MATL, TENTHELOAI, k.MAKHOA, TENKHOA " +
                "from KHOA k, LOAI l where k.MAKHOA=l.MAKHOA


-- Sử dụng view tìm câu lệnh cho sách
SELECT dbo.SACH.MASH, dbo.SACH.TENSACH, dbo.LOAI.TENTHELOAI, dbo.TACGIA.TENTACGIA, dbo.SACH.NXB, dbo.SACH.NAMSX, dbo.SACH.SOLUONG
FROM  dbo.SACH INNER JOIN dbo.LOAI ON dbo.SACH.MATL = dbo.LOAI.MATL INNER JOIN dbo.TACGIA ON dbo.SACH.MATG = dbo.TACGIA.MATG
