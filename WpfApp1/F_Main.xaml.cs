using Do_an;
using Do_an.Class;
using MaterialDesignThemes.Wpf;
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

namespace Do_an
{
    /// <summary>
    /// Interaction logic for F_Main.xaml
    /// </summary>
    public partial class F_Main : Window
    {
       
        public F_Main()
        {
            InitializeComponent();
            DataContext = this;
           
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTrangChu_Click(object sender, RoutedEventArgs e)
        {
            btnBanHang.BorderThickness = new Thickness(0);
            btnDaMua.BorderThickness = new Thickness(0);
            btnTrangChu.BorderThickness = new Thickness(2,0,0,2);
            btnGioHang.BorderThickness = new Thickness(0); 
            btnTrangChu.Background = new SolidColorBrush(Color.FromRgb(136, 0, 204));
            btnGioHang.Background = null;
            btnDaMua.Background = null;
            btnBanHang.Background = null;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("/image/trangchu1.png", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            imageTittle.Source = bitmap;
            UC_MuaSam uC_MuaSam = new UC_MuaSam();
            user.Content = uC_MuaSam;
            btnCaiDat.Background = null;
            btnCaiDat.BorderThickness = new Thickness(0);

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnTrangChu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            if (PhanQuyen.loaiTk == "nguoimua")
            {
                btnBanHang.Visibility = Visibility.Collapsed;
            }
           
        }


        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDaMua_Click(object sender, RoutedEventArgs e)
        {
            UC_DaMua uC_DaMua= new UC_DaMua();
            user.Content = uC_DaMua;
            btnDaMua.BorderThickness = new Thickness(2,0,0,2);
            btnTrangChu.BorderThickness = new Thickness(0);
            btnGioHang.BorderThickness = new Thickness(0);
            btnBanHang.BorderThickness = new Thickness(0);
            PhanQuyen.menu = "Damua";
            btnBanHang.Background = null;
            btnTrangChu.Background = null;
            btnGioHang.Background = null;
            btnDaMua.Background = new SolidColorBrush(Color.FromRgb(136, 0, 204));
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("/image/spdamua.png", UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
            bitmap.EndInit();
            imageTittle.Source = bitmap;
            btnCaiDat.Background = null;
            btnCaiDat.BorderThickness = new Thickness(0);
        }

        private void btnGioHang_Click(object sender, RoutedEventArgs e)
        {
            UC_DaMua uC_GioHang = new UC_DaMua();
            uC_GioHang.tittle.Text = "Sản phẩm đã thêm vào giỏ";
            user.Content = uC_GioHang;
            btnDaMua.BorderThickness = new Thickness(0);
            btnTrangChu.BorderThickness = new Thickness(0);
            btnGioHang.BorderThickness = new Thickness(2, 0, 0, 2);
            btnBanHang.BorderThickness = new Thickness(0);
            PhanQuyen.menu = "GioHang";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("/image/giohang1.png", UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
            bitmap.EndInit();
            imageTittle.Source = bitmap;
            btnGioHang.Background = new SolidColorBrush(Color.FromRgb(136, 0, 204));
            btnDaMua.Background = null;
            btnTrangChu.Background = null;
            btnBanHang.Background= null;
            btnCaiDat.Background = null;
            btnCaiDat.BorderThickness = new Thickness(0);
        }

        private void btnBanHang_Click(object sender, RoutedEventArgs e)
        {
            btnBanHang.BorderThickness= new Thickness(2,0,0,2);
            btnDaMua.BorderThickness = new Thickness(0);
            btnTrangChu.BorderThickness = new Thickness(0);
            btnGioHang.BorderThickness = new Thickness(0);
            // btnThongKe.BorderThickness = new Thickness(0);
            PhanQuyen.menu = "BanHang";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("/image/banhang.png", UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
            bitmap.EndInit();
            imageTittle.Source = bitmap;
            btnBanHang.Background = new SolidColorBrush(Color.FromRgb(136, 0, 204));
            btnDaMua.Background = null;
            btnTrangChu.Background = null;
            btnGioHang.Background= null;
            btnCaiDat.Background = null;
            UC_DaMua uC_BanHang = new UC_DaMua();
            uC_BanHang.tittle.Text = "Sản phẩm đang bán";
            user.Content = uC_BanHang;
            btnCaiDat.BorderThickness = new Thickness(0);
           // btnThongKe.Background = null;

        }
        private void Them_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCaiDat_Click(object sender, RoutedEventArgs e)
        {
            UC_CaiDat uC_CaiDat = new UC_CaiDat();
            user.Content = uC_CaiDat;

            btnBanHang.BorderThickness = new Thickness(0);
            btnDaMua.BorderThickness = new Thickness(0);
            btnTrangChu.BorderThickness = new Thickness(0);
            btnGioHang.BorderThickness = new Thickness(0);
            btnCaiDat.BorderThickness = new Thickness(2,0,0,2);
            //btnThongKe.BorderThickness = new Thickness(0);
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("/image/caidat3.png", UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
            bitmap.EndInit();
            imageTittle.Source = bitmap;
            btnBanHang.Background = null;
            btnDaMua.Background = null;
            btnTrangChu.Background = null;
            btnGioHang.Background = null;
            btnCaiDat.Background=new SolidColorBrush(Color.FromRgb(136, 0, 204));
           // btnThongKe.Background = null;

        }
    }
}
