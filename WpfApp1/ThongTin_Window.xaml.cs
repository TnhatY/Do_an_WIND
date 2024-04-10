using Do_an.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Documents;

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
            string tenshop = TenShop.Text;
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            thongtin.ItemsSource = sanPham_DAO.listSPBan2(tenshop,MaSP.Text);

            Database database = new Database();
            try {
                using (SqlConnection connection = new SqlConnection(database.conStr))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM DanhGia_SP WHERE TenShop = @tenshop GROUP BY TenShop";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                       
                        command.Parameters.AddWithValue("@tenshop", tenshop);

                        int count = (int)command.ExecuteScalar();
                        sodanhgia.Text = count.ToString();
                    }
                }
            }catch (Exception ex)
            {
                sodanhgia.Text = "0";
            }
           
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
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            sanPham_DAO.themGioHang(MaSP.Text,PhanQuyen.taikhoan);
            Close();
        }

        private void xem_Click(object sender, RoutedEventArgs e)
        {
            XemDanhGia_Window xemDanhGia_Window =new XemDanhGia_Window();
            xemDanhGia_Window.tenshop.Text = TenShop.Text;
            xemDanhGia_Window.ShowDialog();
        }

        private List<string> LoadHinhAnh(string maSP)
        {
            List<string> listHinhAnh = new List<string>();
            Database database = new Database();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();
                string taikhoan = PhanQuyen.taikhoan;
                using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP = '{maSP}'", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listHinhAnh.Add(reader["HinhAnh"].ToString());
                        listHinhAnh.Add(reader["HinhAnh2"].ToString());
                        listHinhAnh.Add(reader["HinhAnh3"].ToString());
                        listHinhAnh.Add(reader["HinhAnh4"].ToString());
                    }
                }
                conn.Close();
            }
            return listHinhAnh;
        }

        private int _currentImageIndex = 0;

        private void UpdateImage()
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(LoadHinhAnh(MaSP.Text)[_currentImageIndex], UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            HinhAnh.Source = bitmap;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImageIndex > 0)
            {
                _currentImageIndex--;
                UpdateImage();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentImageIndex < LoadHinhAnh(MaSP.Text).Count - 1)
            {
                _currentImageIndex++;
                UpdateImage();
            }
        }
    }
}
