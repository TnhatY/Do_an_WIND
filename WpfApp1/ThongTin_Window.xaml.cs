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

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                // Lấy đường dẫn file ảnh
                string filePath = openFileDialog.FileName;

                // Lấy tên file và phần mở rộng
                string fileName = System.IO.Path.GetFileName(filePath);

                // Lấy thư mục chứa ảnh
                string directoryName = System.IO.Path.GetDirectoryName(filePath);

                // Tạo đường dẫn ngắn gồm thư mục gần nhất, tên file và phần mở rộng
                string shortenedPath ="/"+ System.IO.Path.Combine(System.IO.Path.GetFileName(directoryName), fileName);
                // Hiển thị ảnh lên giao diện
                MessageBox.Show(shortenedPath);
                //HinhAnh.Source = new BitmapImage(new Uri(filePath));


                // Lưu trữ ảnh dưới dạng mảng byte
                //byte[] hinhThe = (byte[])anh.Source;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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
    }
}
