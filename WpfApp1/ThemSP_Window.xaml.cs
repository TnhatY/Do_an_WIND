using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for ThemSP_Window.xaml
    /// </summary>
    public partial class ThemSP_Window : Window
    {

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.jpg;*.png";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == true)
            {
                imgDynamic.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        void cbDanhMuc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            cbDanhMuc.ItemsSource = DanhMuc;
            cbDanhMuc.SelectionChanged += cbDanhMuc_SelectionChanged;
        }

        private void txtMoTa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
