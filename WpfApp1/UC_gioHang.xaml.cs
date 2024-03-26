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

namespace Do_an
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
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listview_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }


        private void UC_gioHang_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataFromDatabase();
        }

		private void UC_SpGioHang_Deleted(object sender, EventArgs e)
		{
			var sanPham = sender as UC_SpGioHang;
			if (sanPham != null)
			{
				SanPhamList.Remove(sanPham);
			}
		}

		private void LoadDataFromDatabase()
        {
            Database database = new Database();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM GioHang", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UC_SpGioHang sp = new UC_SpGioHang();

						sp.lblMaSP.Text = reader["MaSP"].ToString();
						sp.lblTenSP.Text = reader["TenSP"].ToString();
                        sp.lblTenShop.Text = reader["TenShop"].ToString();
                        sp.lblGiaGoc.Text = reader["GiaGoc"].ToString();
                        sp.lblGiaHTai.Text = reader["GiaHTai"].ToString();
                        sp.tinhtrang.Text = reader["TinhTrang"].ToString();
                        sp.mota.Text = reader["MoTa"].ToString();
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
                        bitmap.EndInit();
                        sp.hinhanh.Source = bitmap;



                        SanPhamList.Add(sp);
                    }
                }
            }
			foreach (var sanPham in SanPhamList)
			{
				sanPham.Deleted += UC_SpGioHang_Deleted;
			}
		}
        public void ReloadData()
        {
            SanPhamList.Clear();
            LoadDataFromDatabase();
        }
    }
}
