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
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Do_an.Class;
using System.Windows.Media.Animation;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for UC_DaMua.xaml
    /// </summary>
    public partial class UC_DaMua : UserControl
    {
        //public ObservableCollection<UC_SpBan> lis { get; set; }

        public UC_DaMua()
        {
            InitializeComponent();
            this.DataContext = this;
            UC_SpBan uc =new UC_SpBan();
            uc.delete.Click += xoa2_Click;
        }

       
        public void ReloadDataGioHang()
        {
            listsp.ItemsSource = null;
            SanPham_DAO sp = new SanPham_DAO();
            listsp.ItemsSource = sp.listSPBan();
        }
        public void ReloadDataSPBan()
        {
            listsp.ItemsSource = null;
            SanPham_DAO sp = new SanPham_DAO();
            listsp.ItemsSource = sp.listGioHang();
        }

        private void xoa_Click(object sender, RoutedEventArgs e)
        {
            // Database database = new Database();
            try
            {
                if (UC_SpGioHang.check)
                {
                    foreach (var sp in UC_SpGioHang.listmasp)
                    {
                        string sql = "delete from GioHang Where MaSP=@MaSP";
                        try
                        {
                            Database database = new Database();
                            SqlConnection sqlConnection = database.getConnection();
                            using (SqlConnection connection = new SqlConnection(database.conStr))
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(sql, connection))
                                {
                                    command.Parameters.AddWithValue("@MaSP", sp);
                                    command.ExecuteNonQuery();
                                }
                            }

                        }
                        catch (Exception Fail)
                        {
                            MessageBox.Show(Fail.Message);
                        }
                    }
                    ReloadDataGioHang();
                    
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào được chọn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            if (PhanQuyen.menu == "BanHang")
            {
                tittle.Text = null;
                spdangban.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            }
            else if (PhanQuyen.menu == "Damua")
            {
                tittle.Text = null;
                spdamua.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            }
            else if (PhanQuyen.menu == "GioHang")
            {
                spdangban.Visibility = spchoxacnhan.Visibility = Visibility.Collapsed;
                spdamua.Visibility = Visibility.Collapsed;
                spchuaxacnhan.Visibility = Visibility.Collapsed;
                listsp.ItemsSource = sanPham_DAO.listGioHang();
            }
        }
        private void xoa2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void spdamua_Click(object sender, RoutedEventArgs e)
        {
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
           // tittle.Text = null;
            string xacNhan = "yes";
            spdamua.BorderThickness = new Thickness(0, 0, 0, 2);
            spchuaxacnhan.BorderThickness = new Thickness(0, 0, 0, 0);
            xoa.Visibility = Visibility.Hidden;
            listsp.ItemsSource = sanPham_DAO.listSPDamua(xacNhan);
            spchoxacnhan.Visibility = Visibility.Collapsed;
            spdangban.Visibility = Visibility.Collapsed;
        }

        private void spchuaxacnhan_Click(object sender, RoutedEventArgs e)
        {
            spdangban.Visibility = Visibility.Collapsed;
            spchoxacnhan.Visibility = Visibility.Collapsed;
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            string xacNhan = "no";
            spdamua.BorderThickness = new Thickness(0, 0, 0, 0);
            spchuaxacnhan.BorderThickness = new Thickness(0, 0, 0, 2);
            tittle.Text = null;
            xoa.Visibility = Visibility.Hidden;
            listsp.ItemsSource = sanPham_DAO.listSPDamua(xacNhan);
        }

        private void spdangban_Click(object sender, RoutedEventArgs e)
        {
            spchoxacnhan.BorderThickness = new Thickness(0, 0, 0, 0);
            spdangban.BorderThickness = new Thickness(0, 0, 0, 2);
            SanPham_DAO sanPham_DAO= new SanPham_DAO();
            spdamua.Visibility = Visibility.Collapsed;
            spchuaxacnhan.Visibility = Visibility.Collapsed;
            xoa.Visibility = Visibility.Collapsed;
            listsp.ItemsSource = sanPham_DAO.listSPBan();
        }

        private void spchoxacnhan_Click(object sender, RoutedEventArgs e)
        {
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            spdamua.Visibility = Visibility.Collapsed;
            spchuaxacnhan.Visibility = Visibility.Collapsed;
            spdangban.BorderThickness = new Thickness(0, 0, 0, 0);
            spchoxacnhan.BorderThickness = new Thickness(0, 0, 0, 2);
            listsp.ItemsSource = sanPham_DAO.listSPChoXacNhan();

        }
    }
}
