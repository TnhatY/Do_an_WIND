using Do_an.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	/// Interaction logic for TopSanPham_Window.xaml
	/// </summary>
	public partial class TopSanPham_Window : Window
	{
		Database data = new Database();
		SanPham_DAO sanPham_DAO = new SanPham_DAO();
		public TopSanPham_Window()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{			
				icTop.ItemsSource = sanPham_DAO.listSPDanhMucTop(DanhMuc.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không có sản phẩm nào!", "Thông báo");
			}
		}
	}
}
