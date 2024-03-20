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
    /// Interaction logic for ThanhToan_Window.xaml
    /// </summary>
    public partial class ThanhToan_Window : Window
    {
        public ThanhToan_Window()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public class CustomTextBox : TextBox
        {
            public CustomTextBox()
            {
                this.Name = "tongthanhtoan";
            }
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            giaban1.Text = giaban.Text;
            phivanchuyen.Text = "12000";
            float giaBan = float.Parse(giaban.Text);
            float phiVanChuyen = float.Parse(phivanchuyen.Text);

            float tongThanToan = giaBan + phiVanChuyen;
            tongthanhtoan.Text = tongthanhtoan1.Text = tongThanToan.ToString();
            
            diachi.Text = "34 đường 27-Linh Đông - Thủ Đức 34 đường 27-Linh Đông - Thủ Đức 34 đường 27-Linh Đông - Thủ Đức";
           
        }


        private void btnDatHang_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đơn hàng đã được đặt");
        }

        private void btnMua_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
