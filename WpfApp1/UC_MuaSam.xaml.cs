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
using System.Xml.Linq;
using static MaterialDesignThemes.Wpf.Theme;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UC_MuaSam.xaml
    /// </summary>
    public partial class UC_MuaSam : UserControl
    {
        public UC_MuaSam()
        {
            InitializeComponent();
            List<Class1> items = new List<Class1>();
            items.Add(new Class1 { Id = 1, name = "anh", shop = "dsgf", gia = 1243, tinhTrang = "mới", ImagePath = "/image/add.png" });
            items.Add(new Class1 { Id = 1, name = "anh", shop = "dsgf", gia = 1243, tinhTrang = "mới", ImagePath = "/image/add.png" });
            items.Add(new Class1 { Id = 1, name = "anh", shop = "dsgf", gia = 1243, tinhTrang = "mới", ImagePath = "/image/add.png" });
            listView.ItemsSource= items;
        }
        


        private void btnMua_Click(object sender, RoutedEventArgs e)
        {
            ThanhToan_Window thanhToan_Window = new ThanhToan_Window();
            thanhToan_Window.Show();
        }
        private void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = listView.SelectedItem;
            if (selectedItem != null)
            {
                ThongTin t=new ThongTin();
                if (selectedItem is Class1 selectedC)
                {
                    t.MaSP.Text = selectedC.Id.ToString();
                    t.Ten.Text = selectedC.name.ToString();
                    t.shop.Text = selectedC.shop.ToString();
                    t.gia.Text = selectedC.gia.ToString();
                    t.tinhTrang.Text = selectedC.tinhTrang.ToString();
                   // t.SetImage(selectedC.ImagePath.ToString());
                    //MessageBox.Show(selectedC.ImagePath);
                }

                t.ShowDialog();
            }
        }
        private void listView_Selected(object sender, RoutedEventArgs e)
        {
            object selectedItem = listView.SelectedItem;
        }
    }
}
