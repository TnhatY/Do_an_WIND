using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
using WpfApp1;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for UC_ThemSanPham.xaml
    /// </summary>
    public partial class UC_ThemSanPham : UserControl
    {
        public UC_ThemSanPham()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UC_BanHang uC_BanHang = new UC_BanHang();
            uC_BanHang.content.Content = null;
        }
    }
}
