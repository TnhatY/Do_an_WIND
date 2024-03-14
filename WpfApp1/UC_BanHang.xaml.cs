
using Do_an;
using System;

using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UC_BanHang.xaml
    /// </summary>
    public partial class UC_BanHang : UserControl
    {
       
        public UC_BanHang()
        {
            InitializeComponent();
        }
        private void ThemSanPham_Click(object sender, RoutedEventArgs e)
        {
            ThemSP_Window themSP_Window = new ThemSP_Window();
            themSP_Window.Show();
        }
    }
}
