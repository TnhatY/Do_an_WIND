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
VALUES ('LT1234', 'LapTop Deo', 'Mac', 17600000.5, 10000, '2017-07-26', 98, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('LT4567', 'LapTop Msi', 'Deo', 19900000, 15000, '2020-11-12', 97, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')
INSERT INTO SanPham (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('LT8913', 'LapTop Mac', 'MSI', 11400000.5, 9000, '2003-12-31', 99, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')

SELECT * FROM SanPham