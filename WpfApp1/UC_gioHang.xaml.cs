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
using static MaterialDesignThemes.Wpf.Theme;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UC_gioHang.xaml
    /// </summary>
    public partial class UC_gioHang : UserControl
    {
        public UC_gioHang()
        {
            InitializeComponent();
            listview.Items.Add(new Class1 { Id = 1, name = "anh", shop = "dsgf", gia = 1243 });
        }

        private void btnMua_Click(object sender, RoutedEventArgs e)
        {
            ThanhToan_Window thanhToan_Window = new ThanhToan_Window();
            thanhToan_Window.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = listview.SelectedItem;
            if (selectedItem != null)
            {
                ThongTin t = new ThongTin();
                if (selectedItem is Class1 selectedC)
                {
                    t.MaSP.Text = selectedC.Id.ToString();
                    t.Ten.Text = selectedC.name.ToString();
                    t.shop.Text = selectedC.shop.ToString();
                    t.gia.Text = selectedC.gia.ToString();
                }
                t.ShowDialog();
            }
        }
    }
}
