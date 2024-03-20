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
using System.Windows.Shapes;

namespace Do_an
{
	/// <summary>
	/// Interaction logic for WindowSp.xaml
	/// </summary>
	public partial class WindowSp : Window
	{
		public WindowSp()
		{
			InitializeComponent();
			string tenSP = "Sample Product";
			string giaHTai = "1000";
			string maSp = "SP01";
			string tenShop = "Sample Shop";
			string tinhTrang = "New";
			string ngayMua = "01/01/2024";
			string con = "Yes";
			string moTa = "This is a sample product.";
			string hinhAnh = "sample.jpg";
			UC_ChiTietSP ucchitiet = new UC_ChiTietSP(tenSP, giaHTai, maSp, tenShop, tinhTrang, ngayMua, con, moTa, hinhAnh);
		}
	}
}
