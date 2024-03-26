SELECT *
INTO SanPhamDaMua
FROM SanPham
WHERE 1=0

INSERT INTO SanPhamDaMua (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('AAAA', 'Xe May', 'Sg', 17600000.5, 10000, '2017-07-26', 98, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')
INSERT INTO SanPhamDaMua (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('AAAA', 'Oto', 'Hn', 19900000, 15000, '2020-11-12', 97, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')
INSERT INTO SanPhamDaMua (MaSP, TenSP, TenShop, GiaGoc, GiaHTai, NgayMua, ConMoi, MoTa, HinhAnh)
VALUES ('AAAA', 'May bay', 'Dn', 11400000.5, 9000, '2003-12-31', 99, 'khong co mo ta', 'https://drive.google.com/file/d/1yFLF4LX2Ql0dLSKj2_yjXmVjIrmkdFpG/view?usp=sharing')

SELECT * FROM SanPhamDaMua