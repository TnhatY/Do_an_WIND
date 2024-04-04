using Do_an.Class;
using MaterialDesignThemes.Wpf;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
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
	/// Interaction logic for UC_TopDanhMuc.xaml
	/// </summary>
	public partial class UC_TopDanhMuc : UserControl
	{
		Database data = new Database();
		SanPham_DAO sanPham_DAO = new SanPham_DAO();

		public UC_TopDanhMuc()
		{
			InitializeComponent();
		}

		//public ObservableCollection<string> GetTopCategories()
		//{
		//	return sanPham_DAO.topDanhMucTimKiem();
		//}

		private void btnSpTop_Click(object sender, RoutedEventArgs e)
		{
			//UC_SpTopTimKiem uc_sptop = new UC_SpTopTimKiem();
			TopSanPham_Window topSanPham_Window = new TopSanPham_Window();
			topSanPham_Window.DanhMuc.Text = danhmuc.Text;
			topSanPham_Window.ShowDialog();
		}
	}
}
