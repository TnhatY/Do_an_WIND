using Do_an.Class;
using Microsoft.Win32;
using System;
using System.Collections;
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
    /// Interaction logic for ThemSP_Window.xaml
    /// </summary>
    public partial class ThemSP_Window : Window
    {
        SanPham_DAO SanPham = new SanPham_DAO();
        public ThemSP_Window()
        {
            InitializeComponent();
        }
        List<string> DanhMuc = new List<string> { "Điện thọai", "Đồ gia dụng", "Xe cộ", "Đồ điện tử", "Đồ điện gia dụng", "Thời trang" };
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Image_Button(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image files|*.jpg;*.png";
            //openFileDialog.FilterIndex = 2;
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    imgDynamic.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            //}
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
                string shortenedPath = "/" + System.IO.Path.Combine(System.IO.Path.GetFileName(directoryName), fileName);
                // Hiển thị ảnh lên giao diện
                //MessageBox.Show(shortenedPath);
                imgHinhAnh.Source = new BitmapImage(new Uri(filePath));


                // Lưu trữ ảnh dưới dạng mảng byte
                //byte[] hinhThe = (byte[])anh.Source;
            }
        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbDanhMuc.ItemsSource = DanhMuc;
            cbDanhMuc.SelectionChanged += cbDanhMuc_SelectionChanged;
        }


        void cbDanhMuc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txtMoTa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnThem_Click_1(object sender, RoutedEventArgs e)
        {
            SanPham sanPhamMoi = new SanPham();
            sanPhamMoi.DanhMucSP = cbDanhMuc.Text;
            sanPhamMoi.MaSP = txtMaSP.Text;
            sanPhamMoi.TenSP = txtTenSP.Text;
            sanPhamMoi.TenShop = txtTenShop.Text;
            sanPhamMoi.TinhTrang = txtTinhTrang.Text;
            sanPhamMoi.GiaGoc = float.Parse(txtGiaGoc.Text);
            sanPhamMoi.GiaHTai = float.Parse(txtGiaBan.Text);
            sanPhamMoi.NgayMua = dtpNgayMua.Text;
            sanPhamMoi.MoTa = txtMoTa.Text;
            sanPhamMoi.HinhAnh = imgHinhAnh.Source.ToString();
            string query = "insert into SanPham values (@MaSP,@TenSP,@TenShop,@GiaGoc,@GiaHTai,@NgayMua,@TinhTrang,@MoTa,@HinhAnh,@DanhMucSP)";

            SanPham.them(sanPhamMoi, query);
            MessageBox.Show("Thêm thành công");
            
        }
    }
}
