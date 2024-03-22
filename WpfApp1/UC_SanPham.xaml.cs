using Do_an;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UC_SanPham.xaml
    /// </summary>
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }
        //public event EventHandler<DataEventArgs> DataRequested;

      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ThongTin_Window thongTin = new ThongTin_Window();
            thongTin.TenSP.Text = ten.Text;
            thongTin.MaSP.Text = masp.Text;
            thongTin.TenShop.Text =tenshop.Text;
            thongTin.GiaGoc.Text = giagoc.Text;
            thongTin.GiaBan.Text = giaBan.Text;
            thongTin.NgayMua.Text = ngaymua.Text;
            thongTin.TinhTrang.Text = tinhtrang.Text;
            thongTin.MoTa.Text = mota.Text;
            thongTin.HinhAnh.Source = hinhanh.Source;
            //MessageBox.Show(ngaymua.Text);
            thongTin.ShowDialog(); 
        }
    }
}
