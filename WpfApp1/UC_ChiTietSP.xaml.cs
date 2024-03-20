using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace Do_an
{
	public partial class UC_ChiTietSP : UserControl
	{
		public UC_ChiTietSP(string tenSP, string giaHTai, string maSp, string tenShop, string tinhTrang, string ngayMua, string con, string moTa, string hinhAnh)
		{
			InitializeComponent();
			LoadDataFromDatabase(maSp);
		}
		private void LoadDataFromDatabase(string maSp)
		{
			SqlConnection conn = new SqlConnection(Do_an.Properties.Settings.Default.connStr);
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("SELECT * FROM SanPham WHERE MaSP = @MaSP", conn))
				{
					command.Parameters.AddWithValue("@MaSP", maSp);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							lblInFoTenSp.Content = reader["TenSP"].ToString();
							lblInFoGiaGoc.Content = reader["GiaGoc"].ToString();
							lblInFoGiaHTai.Content = reader["GiaHTai"].ToString();
							lblInFoMaSp.Content = reader["MaSP"].ToString();
							lblInFoTenShop.Content = reader["TenShop"].ToString();
							lblInFoTinhTrang.Content = reader["TinhTrang"].ToString();
							lblInFoNgayMua.Content = reader["NgayMua"].ToString();
							lblInFoMoTa.Content = reader["MoTa"].ToString();
							object imagePathObj = reader["HinhAnh"];
							if (imagePathObj != null)
							{
								string ?imagePath = imagePathObj.ToString();
								if (!string.IsNullOrEmpty(imagePath))
								{
									BitmapImage bitmap = new BitmapImage();
									bitmap.BeginInit();
									bitmap.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
									bitmap.EndInit();

									List<BitmapImage> images = new List<BitmapImage> { bitmap };
									imageList.ItemsSource = images;
								}
							}

						}
					}
				}
			}
		}

	}
}
