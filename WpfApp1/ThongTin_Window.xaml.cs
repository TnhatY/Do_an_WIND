using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Do_an.Class;
using System.Security.Cryptography.Pkcs;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for ThongTin_Window.xaml
    /// </summary>
    public partial class ThongTin_Window : Window
    {
        public ThongTin_Window()
        {
            InitializeComponent();
        }

        class danhgia
        {
            public string ten { get; set; }
            public string ngay { get; set; }
            public string danhgiasp { get; set; }
            public int sosao { get; set; }  
            public danhgia(string _ten,string _ngay, string _danhgia,int sao)
            {
                ten = _ten;
                ngay = _ngay;
                danhgiasp = _danhgia;
                sosao = sao;
            }
        }
        List<danhgia> listdg = new List<danhgia>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UC_DanhGia uC_DanhGia = new UC_DanhGia();
            //uC_DanhGia.danhgia.Text = "Giao hàng nhanh, đóng gói cẩn thận. Nhận hàng thấy ưng ý, Chất liệu mềm mại. Sẽ tiếp tục ủng hộ shop";
            danhgia dg = new danhgia("Đình Bảo", "21/3/2023", "Giao hàng nhanh, đóng gói cẩn thận",4);
            danhgia dg2 = new danhgia("Đình Bảo", "21/3/2023", "Giao hàng nhanh, đóng gói cẩn thận",3);
            danhgia dg3 = new danhgia("Đình Bảo", "21/3/2023", "Giao hàng nhanh, đóng gói cẩn thận",5);
            danhgia dg4 = new danhgia("Đình Bảo", "21/3/2023", "Giao hàng nhanh, đóng gói cẩn thận", 4);
            danhgia dg5 = new danhgia("Đình Bảo", "21/3/2023", "Giao hàng nhanh, đóng gói cẩn thận", 4);
            listdg.Add(dg);
            listdg.Add(dg2);
            listdg.Add(dg3);
            listdg.Add(dg4);
            listdg.Add(dg5);
            thongtin.ItemsSource= listdg;
        }

        private void btnThoat_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMua_Click(object sender, RoutedEventArgs e)
        {
            ThanhToan_Window thanhToan_Window = new ThanhToan_Window();
            thanhToan_Window.masp.Text = MaSP.Text;
            thanhToan_Window.tensp.Text = TenSP.Text;
            thanhToan_Window.tenshop.Text = TenShop.Text;
            thanhToan_Window.giaban.Text = GiaBan.Text;
            thanhToan_Window.hinhanh.Source = HinhAnh.Source;
            thanhToan_Window.Show();
            this.Hide();
        }

		private void btnThemGioHang_Click(object sender, RoutedEventArgs e)
		{
			string query = "insert into GioHang values (@MaSP,@TenSP,@TenShop,@GiaGoc,@GiaHTai,@NgayMua,@TinhTrang,@MoTa,@HinhAnh,@DanhMucSP)";

			SanPham_DAO sanPham_DAO = new SanPham_DAO();
			SanPham sanPham = new SanPham();
			sanPham.MaSP = MaSP.Text;
			sanPham.TenSP = TenSP.Text;
			sanPham.TenShop = TenShop.Text;
			sanPham.GiaGoc = float.Parse(GiaGoc.Text);
			sanPham.GiaHTai = float.Parse(GiaBan.Text);
			sanPham.NgayMua = NgayMua.Text;
			sanPham.MoTa = MoTa.Text;
			sanPham.TinhTrang = TinhTrang.Text;
			sanPham.HinhAnh = HinhAnh.Source.ToString();
			sanPham.DanhMucSP = "null";
			sanPham_DAO.them(sanPham, query);
			MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng");
		}
	}
}
