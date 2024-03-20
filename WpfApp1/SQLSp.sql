drop table SanPham
CREATE TABLE SanPham(
    MaSP VARCHAR(50) PRIMARY KEY,
    TenSP NVARCHAR(50),
    TenShop NVARCHAR(50),
    GiaGoc FLOAT,
    GiaHTai FLOAT,
    NgayMua Date,
    ConMoi FLOAT,
    MoTa NVARCHAR(MAX) NULL,
    HinhAnh NVARCHAR(MAX) NULL
)

INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('LT1234', 'LapTop Deo', 'SHOPDOCODAI', 17600000.5, 10000, '2017-07-26', 98, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('LT4567', 'LapTop Msi', 'Deo', 19900000, 15000, '2020-11-12', 97, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('LT8913', 'LapTop Mac', 'MSI', 11400000.5, 9000, '2003-12-31', 99, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('XD8913', 'Xe Dap', 'Jin', 11400000.5, 9000, '2003-12-31', 99, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('HG8913', 'May Cay', 'Mitsu', 124346345, 1231543, '2014-12-31', 56, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('MB1234', 'may bay', 'boeing', 65565765.5, 167463, '2006-12-31', 76, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('PC125123', 'phi co', 'airbus', 123543.5, 123563, '2071-12-31', 55, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('PF12512', 'Daisy', 'Delo', 16344325.5, 68756500, '2046-12-31', 73, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('Nu9244', 'Tien', 'bip', 8253256.5, 9000, '2003-12-31', 88, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('IU19249', 'Huan', 'hoahong', 9455243.5, 9000, '2003-12-31', 91, 'khong co mo ta', 'C:\Users\admin\source\repos\Do_an\Do_an\image\d63oo0x-e7806331-44e2-453f-9e84-76ef9cd89427 copy.png')

SELECT * FROM SanPham
