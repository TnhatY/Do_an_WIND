using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace Do_an
{
	/// <summary>
	/// Interaction logic for UC_SanPhamGioHang.xaml
	/// </summary>
	public partial class UC_SpGioHang : UserControl
	{
		public UC_SpGioHang()
		{
			InitializeComponent();
		}
		private void btnHienThiChiTietSp_Click(object sender, RoutedEventArgs e)
		{
			WindowSp detailWindow = new WindowSp();

			string tenSP = "Sample Product";
			string giaHTai = "1000";
			string maSp = "SP01";
			string tenShop = "Sample Shop";
			string tinhTrang = "New";
			string ngayMua = "01/01/2024";
			string con = "Yes";
			string moTa = "This is a sample product.";
			string hinhAnh = "C:\\Users\\admin\\source\\repos\\Do_an\\Do_an\\image\\1.JPG";

			detailWindow.Content = new UC_ChiTietSP(tenSP, giaHTai, maSp, tenShop, tinhTrang, ngayMua, con, moTa, hinhAnh);

			detailWindow.Width = 500;
			detailWindow.Height = 800;
			detailWindow.Title = "Chi tiết sản phẩm";

			// Hiển thị cửa sổ
			detailWindow.Show();
		}
	}
}
