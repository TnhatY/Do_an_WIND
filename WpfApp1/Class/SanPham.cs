using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Do_an.Class
{
    class SanPham
    {
        public string DanhMucSP { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenShop { get; set; }
        public float GiaGoc { get; set; }
        public float GiaHTai { get; set; }
        public string NgayMua { get; set; }
        public string TinhTrang { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }

        public string HinhAnh2 { get; set; }

        public string HinhAnh3 { get; set; }

        public string HinhAnh4 { get; set; }

        public SanPham() { }
        public SanPham(string maSP, string tenSP, string tenShop, float giaGoc, float giaHTai, string ngayMua, string tinhTrang, string moTa, string hinhAnh, string danhMucSP, string hinhAnh2, string hinhAnh3, string hinhAnh4)
        {
            DanhMucSP = danhMucSP;
            MaSP = maSP;
            TenSP = tenSP;
            TenShop = tenShop;
            GiaGoc = giaGoc;
            GiaHTai = giaHTai;
            NgayMua = ngayMua;
            TinhTrang = tinhTrang;
            MoTa = moTa;
            HinhAnh = hinhAnh;
            HinhAnh2 = hinhAnh2;
            HinhAnh3 = hinhAnh3;
            HinhAnh4 = hinhAnh4;
        }
    }
}
