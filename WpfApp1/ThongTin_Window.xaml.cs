using Do_an.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for ThongTin_Window.xaml
    /// </summary>
    public partial class ThongTin_Window : Window
    {
        public ThongTin_Window()
        {
            InitializeComponent();
        }

        class danhgia
        {
            public string ten { get; set; }
            public string ngay { get; set; }
            public string danhgiasp { get; set; }
            public int sosao { get; set; }  
            public danhgia(string _ten,string _ngay, string _danhgia,int sao)
            {
                ten = _ten;
                ngay = _ngay;
                danhgiasp = _danhgia;
                sosao = sao;
            }
        }
        List<danhgia> listdg = new List<danhgia>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = $"select * from DanhGia_SP where MaSP='{MaSP.Text}'";
            //MessageBox.Show(MaSP.Text);
            Database database = new Database();
            DataTable dt = database.getAllData(sql);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string ten = row["TenNgDG"].ToString();
                    int soSao =int.Parse(row["SoSao"].ToString());
                    DateTime ngay = (DateTime)row["NgayDG"];
                    string ngaydg = ngay.ToShortDateString();
                    string danhgias = row["DanhGia"].ToString();
                  
                    listdg.Add(new danhgia(ten, ngaydg, danhgias, soSao));
                }
                thongtin.ItemsSource = listdg;
            }
            else
            {
                chuDG.Text = "Chưa có đánh giá nào!";
               // thongtin.ItemsSource = null; 
            }

        }

        private void btnThoat_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMua_Click(object sender, RoutedEventArgs e)
        {
            ThanhToan_Window thanhToan_Window = new ThanhToan_Window();
            thanhToan_Window.masp.Text = MaSP.Text;
            thanhToan_Window.tensp.Text = TenSP.Text;
            thanhToan_Window.tenshop.Text = TenShop.Text;
            thanhToan_Window.giaban.Text = GiaBan.Text;
            thanhToan_Window.hinhanh.Source = HinhAnh.Source;
            thanhToan_Window.Show();
            this.Hide();
        }

        private void btnThemGioHang_Click(object sender, RoutedEventArgs e)
        {
            SanPham_DAO sanPham_DAO = new SanPham_DAO();
            sanPham_DAO.themGioHang(MaSP.Text,PhanQuyen.taikhoan);
            Close();
        }
    }
}
