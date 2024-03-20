using Do_an;
using Do_an.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        
        Database data = new Database();
        public UC_MuaSam()
        {
            InitializeComponent();
            DataContext = this;
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            thongtin.ItemsSource = sanPham_DAO.Getlist();
        }

       
        private void btnMua_Click(object sender, RoutedEventArgs e)
        {

        }
        private void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void listView_Selected(object sender, RoutedEventArgs e)
        {
            // object selectedItem = listView.SelectedItem;
        }

    }
}
