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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for UC_SpGioHang.xaml
    /// </summary>
    public partial class UC_SpGioHang : UserControl
    {
        public UC_SpGioHang()
        {
            InitializeComponent();
        }

       
        private void btnHienThiThonTin_Click(object sender, RoutedEventArgs e)
        {
            ThongTin_Window thongTin_Window = new ThongTin_Window();
            thongTin_Window.TenSP.Text = lblTenSP.Text;
            thongTin_Window.TenShop.Text = lblTenShop.Text;
            thongTin_Window.GiaBan.Text = lblGiaHTai.Text;
            thongTin_Window.GiaGoc.Text = lblGiaGoc.Text;
            thongTin_Window.MoTa.Text = mota.Text;
            thongTin_Window.TinhTrang.Text = tinhtrang.Text;
            thongTin_Window.HinhAnh.Source = hinhanh.Source;
            thongTin_Window.btnThemGioHang.Visibility = Visibility.Hidden;

            thongTin_Window.ShowDialog();
        }
    }
}
