using Do_an.Class;
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
		public event EventHandler Deleted;
		public UC_SpGioHang()
        {
            InitializeComponent();
        }

       
        private void btnHienThiThongTin_Click(object sender, RoutedEventArgs e)
        {
            ThongTin_Window thongTin_Window = new ThongTin_Window();
			thongTin_Window.MaSP.Text = lblMaSP.Text;
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

		private void btnXoaSp_Click(object sender, RoutedEventArgs e)
		{
			string query = "DELETE FROM GioHang WHERE MaSP = @MaSP";

			SanPham_DAO sanPham_DAO = new SanPham_DAO();
			SanPham sanPham = new SanPham();
			sanPham.MaSP = lblMaSP.Text;

			sanPham_DAO.xoa(sanPham, query);
			MessageBox.Show("Sản phẩm đã được xóa khỏi giỏ hàng");
			OnDeleted(EventArgs.Empty);
			e.Handled = true;
		}
		protected virtual void OnDeleted(EventArgs e)
		{
			Deleted?.Invoke(this, e);
		}
	}
}
