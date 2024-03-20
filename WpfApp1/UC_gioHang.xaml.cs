using Do_an;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1
{
	public partial class UC_gioHang : UserControl
	{
		public ObservableCollection<UC_SpGioHang> SanPhamList { get; set; }

		public UC_gioHang()
		{
			InitializeComponent();
			SanPhamList = new ObservableCollection<UC_SpGioHang>();
			
			this.DataContext = this;
			this.Loaded += UC_gioHang_Loaded;
		}

		private void UC_gioHang_Loaded(object sender, RoutedEventArgs e)
		{
			LoadDataFromDatabase();
		}

		private void LoadDataFromDatabase()
		{
			SqlConnection conn = new SqlConnection(Do_an.Properties.Settings.Default.connStr);
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("SELECT * FROM SanPham", conn))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						UC_SpGioHang sp = new UC_SpGioHang();

						sp.lblTenSP.Content = reader["TenSP"].ToString();
						sp.lblTenShop.Content = reader["TenShop"].ToString();
						sp.lblGiaGoc.Content = reader["GiaGoc"].ToString();
						sp.lblGiaHTai.Content = reader["GiaHTai"].ToString();
						sp.lblTienThanhToan.Content = reader["GiaHTai"].ToString();

						SanPhamList.Add(sp);
					}
				}
			}
		}
		public void ReloadData()
		{
			SanPhamList.Clear();
			LoadDataFromDatabase();
		}
	}
}
