using Do_an.Class;
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

namespace Do_an
{
	/// <summary>
	/// Interaction logic for UC_SpTopTimKiem.xaml
	/// </summary>
	public partial class UC_SpTopTimKiem : UserControl
	{
		Database data = new Database();
		SanPham_DAO sanPham_DAO = new SanPham_DAO();

		public UC_SpTopTimKiem()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{
				string sql = "Select * from SanPham";
				thongtin.ItemsSource = sanPham_DAO.topSpTimKiemTheoDanhMuc(sql);
			}
			catch (Exception ex)
			{
				MessageBox.Show("  ", "  ");
			}
		}
	}
}
