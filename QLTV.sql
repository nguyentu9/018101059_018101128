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
	MATHE int primary key (MATHE) identity, 
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
	SOPM int primary key (SOPM) identity, 
	NGAYMUON datetime, 
	NGAYTRA datetime, 
	MASV varchar(10), 
	MASH varchar(10), 
	MATHE int, 
	MANV varchar(10)

	foreign key(MASV) references SINHVIEN(MASV),
	foreign key(MASH) references SACH(MASH),
	foreign key(MATHE) references THETHUVIEN(MATHE),
	foreign key(MANV) references NHANVIEN(MANV)
)
go
create table CTPM (
	SOPM int primary key(SOPM, MASH) identity,
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
	MATT int primary key(MATT) identity,
	TENTT nvarchar(100) unique
)
go

create table GIAIQUYET (
	MAGQ int primary key(MAGQ) identity,
	TENGQ nvarchar(100) unique
)
go
create table PHIEUBOITHUONG (
	SOBT int primary key(SOBT) identity,
	MATT int,
	MAGQ int,
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

insert into NHANVIEN values ('NV01', N'Nguyễn Thị Hoa',' 1/1/1995','0',N'Vĩnh Long','0987654321');
insert into NHANVIEN values ('NV02', N'Nguyễn Thị Thúy Hiền', '1/1/1990','0',N'Tiền Giang','0287652145');
insert into NHANVIEN values ('NV03', N'Lê Vĩnh Phúc', '1/1/1994','1',N'Bến Tre','0234543223');
insert into NHANVIEN values ('NV04', N'Tòn', '1/1/2000','1',N'Tìn Yang','0987654321');
insert into NHANVIEN values ('NV05', N'Thanh', '1/1/2000','1',N'American Tho','3515115131');

INSERT INTO KHOA VALUES('NN', N'Ngoại ngữ')
INSERT INTO KHOA VALUES('CN', N'Công nghệ')
INSERT INTO KHOA VALUES('SP', N'Sư phạm')
INSERT INTO KHOA VALUES('KT', N'Kỹ thuật')
INSERT INTO KHOA VALUES('XH', N'Xã hội')
INSERT INTO KHOA VALUES('TN', N'Tự nhiên')
INSERT INTO KHOA VALUES('NLN', N'Nông-Lâm-Nghiệp')
INSERT INTO KHOA VALUES('KTQL', N'Kinh tế & Quản lý')
INSERT INTO KHOA VALUES('NV', N'Nhân văn')


insert into TACGIA values ('TG01','Tac gia 01');
insert into TACGIA values ('TG02','Tac gia 02');
insert into TACGIA values ('TG03','Tac gia 03');
insert into TACGIA values ('TG04','Tac gia 04');
insert into TACGIA values ('TG05','Tac gia 05');
insert into TACGIA values ('TG06','Tac gia 06');
insert into TACGIA values ('TG07','Tac gia 07');
insert into TACGIA values ('TG08','Tac gia 08');
insert into TACGIA values ('TG09','Tac gia 09');
insert into TACGIA values ('TG13','Tac gia 13');
insert into TACGIA values ('TG14','Tac gia 14');
insert into TACGIA values ('TG15','Tac gia 15');
insert into TACGIA values ('TG16','Tac gia 16');
insert into TACGIA values ('TG17','Tac gia 17');
insert into TACGIA values ('TG18','Tac gia 18');

insert into LOAI values ('GDCT', N'Giáo dục mầm non','SP');
insert into LOAI values ('KTXD', N'Kỹ thuật xây dựng','KT');
insert into LOAI values ('KTCT', N'Kinh tế-Chính trị','XH');
insert into LOAI values ('TCNH', N'Tài nhính-Ngân hàng','KTQL');
insert into LOAI values ('QTKD', N'Quản trị kinh doanh','KTQL');
insert into LOAI values ('CNTT', N'Công nghệ thông tin','CN');
insert into LOAI values ('KHCT', N'Khoa học cây trồng','NLN');
insert into LOAI values ('KHMT', N'Khoa học môi trường','TN');
insert into LOAI values ('CTH',  N'Chính trị học','XH');
insert into LOAI values ('KTLK', N'Kỹ thuật luyện kim','KT');
insert into LOAI values ('VNH',  N'Việt Nam học','NV');
insert into LOAI values ('BQCBNS',N'Bảo quản & chế biến nông sản','NLN');
insert into LOAI values ('KTCDT',N'Kỹ thuật cơ điện tử','KT');
insert into LOAI values ('CNKT', N'Công nghệ kiến trúc','CN');
insert into LOAI values ('NTTS', N'Nuôi trồng thủy sản','NLN');
insert into LOAI values ('KTDM', N'Kỹ thuật dệt may','KT');
insert into LOAI values ('CNLK', N'Công nghệ luyện kim','CN');
insert into LOAI values ('KTDT', N'Kỹ thuật điện tử','KT');
insert into LOAI values ('DKTDH',N'Kỹ thuật Điều khiển & Tự động hóa','KT');

insert into SACH values ('XHVH',N'Xã hội học văn hóa','VNH','TG01',N'NXB Khoa học xã hội',2004,50);
insert into SACH values ('KTDL',N'Giáo trình kinh tế du lịch','QTKD','TG02',N'NXB Tổng hợp TP.HCM',2005,60);
insert into SACH values ('LGUD',N'Giáo trình Logic và ứng dụng','CNKT','TG03',N'NXB Xây dựng',1999,70);
insert into SACH values ('SBVL',N'Sức bền vật liệu','DKTDH','TG04',N'NXB Xây dựng',1995,80);
insert into SACH values ('HCDV',N'Các hợp chất dị vòng','KTCDT','TG05',N'NXB Giáo dục',1996,40);
insert into SACH values ('KTN',N'Kỹ thuật nguội','KTLK','TG06',N'NXB Giáo dục',2001,50);
insert into SACH values ('TLKN',N'Thủy lực và khí nén ','KTCDT','TG07',N'NXB khoa học và kỹ thuật',2002,60);
insert into SACH values ('DCN',N'Điện công nghiệp và điều khiển động cơ','DKTDH','TG08',N'NXB khoa học và kỹ thuật',2003,80);
insert into SACH values ('DTCS',N'Điện tử công suất','KTDT','TG09',N'NXB Khoa học kỹ thuật',2004,70);
insert into SACH values ('NRTG',N'Norton ghost chương trình sao chép ổ cứng','CNTT','TG13',N'NXB Thanh Niên',2009,100);
insert into SACH values ('HTTV',N'Hệ thống học thực vật','KHCT','TG14',N'NXB Đại học quốc gia Hà Nội',2005,70);
insert into SACH values ('BQLT',N'Bảo quản lương thực','BQCBNS','TG15',N'NXB Bách khoa Hà Nội',2007,60);
insert into SACH values ('NCLB',N'Phương pháp và kỹ thuật nuôi cá lồng biển','NTTS','TG16',N'NXB Nông nghiệp',2008,50);
insert into SACH values ('XSTK',N'Xác suất Thống kê ứng dụng trong Kinh tế Xã hội','QTKD','TG17',N'NXB Đại học Thăng Long',2010,45);
insert into SACH values ('VKD',N'Văn kiện Đảng toàn tập','CTH','TG18',N'NXB Chính trị Quốc Gia',2006,50);

insert into SINHVIEN values('SV001',N'Trần Văn Triều','1','XH','1/2/2000',N'Tiền Giang','0287652145');
insert into SINHVIEN values('SV002',N'Nguyễn Thanh Mai','0','TN','2/1/2000',N'Bến Tre','0234543223');
insert into SINHVIEN values('SV003',N'Nguyễn Thanh Tâm','1','CN','1/3/2000',N'Tiền Giang','0287652145');
insert into SINHVIEN values('SV004',N'Nguyễn Thanh Mẫn','0','KT','2/5/2000',N'Long An','0234543223');
insert into SINHVIEN values('SV005', N'Tòn','1','NV','1/1/2000',N'Tìn Yang','0987654321');
insert into SINHVIEN values('SV006', N'Thanh','1','NLN', '1/1/2000',N'AmericanTho','113114115');

insert into TAIKHOAN(MATAIKHOAN, TENTAIKHOAN, MATKHAU, LOAITK) values ('NV01', 'admin', 'admin', 'admin'),
												('NV04', 'toan', '12345', 'admin'),
												('NV05', 'thanh', '12345', 'user');

insert into THETHUVIEN values ('SV001','1/1/2020','1/7/2020');
insert into THETHUVIEN values ('SV002','1/2/2020','1/8/2020');
insert into THETHUVIEN values ('SV003','1/3/2020','1/9/2020');
insert into THETHUVIEN values ('SV004','1/6/2020','1/12/2020');
insert into THETHUVIEN values ('SV005','1/4/2020','1/10/2020');
insert into THETHUVIEN values ('SV006','1/5/2020','1/11/2020');

insert into NHACC values('MLB', N'Minh Long Book' ,N'TP.Hồ Chí Minh', '0987654321');
insert into NHACC values('DTB', N'Định tị Book' ,N'TP.Hồ Chí Minh', '0234543223');
insert into NHACC values('NMB', N'Nhã Nam Book' ,N'Hà Nội', '0287652145');
insert into NHACC values('KDB', N'Kim Đồng Book' ,N'Hà Nội', '0287652145');

insert into TINHTRANG values (N'Trả sách trễ hạn')
insert into TINHTRANG values (N'Mất sách')
insert into TINHTRANG values (N'Sách hư hỏng nhẹ')
insert into TINHTRANG values (N'Sách hư hỏng nặng')

insert into GIAIQUYET values (N'Nộp phạt-2k')
insert into GIAIQUYET values (N'Nộp phạt-5k')
insert into GIAIQUYET values (N'Nộp phạt - 10k')
insert into GIAIQUYET values (N'Nộp phạt - ứng với giá trị sách')
insert into GIAIQUYET values (N'Bồi thường sách mới')

insert into PHIEUBOITHUONG values( 1, 1, 'NV01', 'SV001')
insert into PHIEUBOITHUONG values( 1, 2, 'NV01', 'SV001')

insert into PHIEUNHAP values('PN001','1/9/2006','MLB','NV01');
insert into PHIEUNHAP values('PN002','1/4/2008','DTB','NV02');
insert into PHIEUNHAP values('PN003','10/7/2006','KDB','NV03');

--insert into CTPM values ('XHVH',50);
--insert into CTPM values ('VKD',50);
--insert into CTPM values ('BQLT',60);

insert into PHIEUMUON values ('1/9/2020','8/9/2020','SV001','DCN',1,'NV01'); 
insert into PHIEUMUON values ('1/10/2020','8/10/2020','SV002','KTN',2,'NV02'); 
insert into PHIEUMUON values ('1/11/2020','8/11/2020','SV003','VKD',3,'NV02');
insert into PHIEUMUON values ('5/10/2020','11/10/2020','SV004','HTTV',4,'NV03');
insert into PHIEUMUON values ('3/12/2020','10/12/2020','SV005','SBVL',5,'NV01');
insert into PHIEUMUON values ('5/12/2020','11/12/2020','SV006','BQLT',6,'NV03');

-- Sử dụng view tìm câu lệnh cho sách
SELECT dbo.SACH.MASH, dbo.SACH.TENSACH, dbo.LOAI.TENTHELOAI, dbo.TACGIA.TENTACGIA, dbo.SACH.NXB, dbo.SACH.NAMSX, dbo.SACH.SOLUONG
FROM  dbo.SACH INNER JOIN dbo.LOAI ON dbo.SACH.MATL = dbo.LOAI.MATL INNER JOIN dbo.TACGIA ON dbo.SACH.MATG = dbo.TACGIA.MATG

-- Sử dụng view tìm câu lệnh cho phiếu bồi thường
SELECT        dbo.PHIEUBOITHUONG.SOBT, dbo.SINHVIEN.MASV, dbo.SINHVIEN.HOTEN AS TENSV, dbo.NHANVIEN.HOTEN AS TENNV, dbo.TINHTRANG.TENTT, dbo.GIAIQUYET.TENGQ
FROM            dbo.GIAIQUYET INNER JOIN
                         dbo.PHIEUBOITHUONG ON dbo.GIAIQUYET.MAGQ = dbo.PHIEUBOITHUONG.MAGQ INNER JOIN
                         dbo.NHANVIEN ON dbo.PHIEUBOITHUONG.MANV = dbo.NHANVIEN.MANV INNER JOIN
                         dbo.SINHVIEN ON dbo.PHIEUBOITHUONG.MASV = dbo.SINHVIEN.MASV INNER JOIN
                         dbo.TINHTRANG ON dbo.PHIEUBOITHUONG.MATT = dbo.TINHTRANG.MATT
