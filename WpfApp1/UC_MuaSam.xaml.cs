using Do_an;
using Do_an.Class;
using MaterialDesignThemes.Wpf;
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
        SanPham_DAO sanPham_DAO = new SanPham_DAO();

        public UC_MuaSam()
        {
            InitializeComponent();
            DataContext = this;
            string sql = "Select * from SanPham";
            thongtin.ItemsSource = sanPham_DAO.Getlist(sql);
            List<string> DanhMuc = new List<string> { "Điện thoại", "Đồ gia dụng", "Xe cộ", "Đồ điện tử", "Đồ dùng", "Thời trang" ,"Không"};
            cbDanhMuc.ItemsSource = DanhMuc;
            //cbDanhMuc.SelectionChanged += cbDanhMuc_SelectionChanged;
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

        private void btnThemSP_Click(object sender, RoutedEventArgs e)
        {
            ThemSP_Window themSP_Window = new ThemSP_Window();
            themSP_Window.Show();
        }

        private void cbDanhMuc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Database database = new Database
            string query = "";

            string danhmuc = cbDanhMuc.SelectedItem.ToString();
            if (danhmuc == "Không")
            {
                query = "select * from SanPham";
            }
            else
            {
                query = "select * from SanPham where DanhMucSP like N'%" + danhmuc + "%'";

            }
            // database.getAllData(query);
            thongtin.ItemsSource = sanPham_DAO.Getlist(query);
        }
    }
}
