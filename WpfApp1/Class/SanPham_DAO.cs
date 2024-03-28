using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Drawing;
using System.Collections.ObjectModel;

namespace Do_an.Class
{
    internal class SanPham_DAO
    {
        public List<SanPham> Getlist(string sql) 
        {
            List<SanPham> sanPhams = new List<SanPham>();
            Database database = new Database();

            DataTable dt = database.getAllData(sql);
            foreach (DataRow row in dt.Rows)
            {
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                string tenShop = row["TenShop"].ToString();
                float giaGoc = Convert.ToSingle(row["GiaGoc"]);
                float giaHTai = Convert.ToSingle(row["GiaHTai"]);
                string ngayMua = row["NgayMua"].ToString();
                string tinhTrang = row["TinhTrang"].ToString();
                string moTa = row["MoTa"].ToString();
                string hinhAnh = row["HinhAnh"].ToString();
                string danhMucSP = row["DanhMucSP"].ToString();
                sanPhams.Add(new SanPham(maSP,tenSP,tenShop,giaGoc,giaHTai,ngayMua,tinhTrang,moTa,hinhAnh,danhMucSP));
            }
            return sanPhams; 
        }
        public void them(SanPham sp,string query)
        {
            try {
                Database database = new Database();
                SqlConnection sqlConnection = database.getConnection();
                using (SqlConnection connection = new SqlConnection(database.conStr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", sp.MaSP);
                        command.Parameters.AddWithValue("@TenSP", sp.TenSP);
                        command.Parameters.AddWithValue("@TenShop", sp.TenShop);
                        command.Parameters.AddWithValue("@GiaGoc", sp.GiaGoc);
                        command.Parameters.AddWithValue("@GiaHTai", sp.GiaHTai);
                        command.Parameters.AddWithValue("@NgayMua", sp.NgayMua);
                        command.Parameters.AddWithValue("@TinhTrang", sp.TinhTrang);
                        command.Parameters.AddWithValue("@MoTa", sp.MoTa);
                        command.Parameters.AddWithValue("@HinhAnh", sp.HinhAnh);
                        command.Parameters.AddWithValue("@DanhMucSP", sp.DanhMucSP);
                        command.ExecuteNonQuery();
                    }
                }
            } 
            catch(Exception Fail){
                MessageBox.Show(Fail.Message);
            }
            
        }
        public void sua(SanPham sp, string query)
        {
            try
            {
                Database database = new Database();
                SqlConnection sqlConnection = database.getConnection();
                using (SqlConnection connection = new SqlConnection(database.conStr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", sp.MaSP);
                        command.Parameters.AddWithValue("@TenSP", sp.TenSP);
                        command.Parameters.AddWithValue("@TenShop", sp.TenShop);
                        command.Parameters.AddWithValue("@GiaGoc", sp.GiaGoc);
                        command.Parameters.AddWithValue("@GiaHTai", sp.GiaHTai);
                        command.Parameters.AddWithValue("@NgayMua", sp.NgayMua);
                        command.Parameters.AddWithValue("@TinhTrang", sp.TinhTrang);
                        command.Parameters.AddWithValue("@MoTa", sp.MoTa);
                        command.Parameters.AddWithValue("@HinhAnh", sp.HinhAnh);
                        command.Parameters.AddWithValue("@DanhMucSP", sp.DanhMucSP);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Fail)
            {
                MessageBox.Show(Fail.Message);
            }
        }
        public void xoa(string masp, string query)
        {
            try
            {
                Database database = new Database();
                SqlConnection sqlConnection = database.getConnection();
                using (SqlConnection connection = new SqlConnection(database.conStr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", masp);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Fail)
            {
                MessageBox.Show(Fail.Message);
            }
        }

        public void themGioHang(string masp,string taikhoan)
        {
            string query = "insert into GioHang values (@MaSP,@TaiKhoan)";
            try
            {
                Database database = new Database();
                SqlConnection sqlConnection = database.getConnection();
                using (SqlConnection connection = new SqlConnection(database.conStr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", masp);
                        command.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!");
            }
            catch (Exception Fail)
            {
                MessageBox.Show(Fail.Message);
            }
        }
        public ObservableCollection<UC_SpGioHang> listGioHang()
        {
            ObservableCollection<UC_SpGioHang> listSP = new ObservableCollection<UC_SpGioHang> ();
            Database database = new Database();
            string tk = PhanQuyen.taikhoan;
            List<string> listmasp = new List<string>();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM GioHang where TaiKhoan='{tk}'", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listmasp.Add(reader["MaSP"].ToString());
                    }
                }
                foreach (string msp in listmasp)
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP='{msp}'", conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_SpGioHang sp = new UC_SpGioHang();
                            sp.masp.Text = reader["MaSP"].ToString();
                            sp.lblTenSP.Text = reader["TenSP"].ToString();
                            sp.lblTenShop.Text = reader["TenShop"].ToString();
                            sp.lblGiaGoc.Text = reader["GiaGoc"].ToString();
                            sp.lblGiaHTai.Text = reader["GiaHTai"].ToString();
                            sp.tinhtrang.Text = reader["TinhTrang"].ToString();
                            sp.mota.Text = reader["MoTa"].ToString();
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute); // Thay đổi path_to_your_image.jpg thành đường dẫn của ảnh của bạn
                            bitmap.EndInit();
                            sp.hinhanh.Source = bitmap;
                            listSP.Add(sp);
                        }
                    }
                }
                conn.Close();
                return listSP;
            }
        }
        public ObservableCollection<UC_SpBan> listSPBan()
        {
            ObservableCollection<UC_SpBan> SanPhamList = new ObservableCollection<UC_SpBan>();
            List<string> listsp = new List<string>();
            Database database = new Database();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();
                string taikhoan = PhanQuyen.taikhoan;
                using (SqlCommand command = new SqlCommand($"SELECT MaSP FROM SP_Ban where TaiKhoan='{taikhoan}'", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listsp.Add(reader["MaSP"].ToString());
                    }
                }

                foreach (string masp in listsp)
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP='{masp}'", conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_SpBan sp = new UC_SpBan();
                            sp.masp.Text = reader["MaSP"].ToString();
                            sp.tensp.Text = reader["TenSP"].ToString();
                            sp.mota.Text = reader["MoTa"].ToString();
                            // sp.giagoc.Text = reader["GiaGoc"].ToString();
                            sp.giaban.Text = reader["GiaHTai"].ToString();
                            sp.tinhtrang.Text = reader["TinhTrang"].ToString();
                            sp.xacnhan.Visibility = Visibility.Collapsed;
                            //sp.dagiao.Text = "Sản phẩm đã giao thành công";
                            //sp..Text = reader["MoTa"].ToString();
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute);
                            bitmap.EndInit();
                            sp.hinhanh.Source = bitmap;
                            SanPhamList.Add(sp);
                        }
                    }
                }
            }
            return SanPhamList;
        }
        public ObservableCollection<UC_SP_DaMua> listSPDamua(string xacNhan)
        {
            ObservableCollection<UC_SP_DaMua> SanPhamList = new ObservableCollection<UC_SP_DaMua>();
            List<string> listsp = new List<string>();
            Database database = new Database();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();
                string taikhoan = PhanQuyen.taikhoan;
                using (SqlCommand command = new SqlCommand($"SELECT MaSP FROM SP_DaMua where TaiKhoan='{taikhoan}' and XacNhan='{xacNhan}'", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listsp.Add(reader["MaSP"].ToString());
                    }
                }

                foreach (string masp in listsp)
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP='{masp}'", conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_SP_DaMua sp = new UC_SP_DaMua();
                            sp.tensp.Text = reader["TenSP"].ToString();
                            sp.masp.Text = reader["MaSP"].ToString();
                            sp.giagoc.Text = reader["GiaGoc"].ToString();
                            sp.giaban.Text = reader["GiaHTai"].ToString();
                            sp.tinhtrang.Text = reader["TinhTrang"].ToString();
                            if (xacNhan == "no")
                            {
                                sp.giaohang.Text = "Đang chờ xác nhận từ người bán!";
                                sp.btndanhgia.Visibility = Visibility.Collapsed;

                            }
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute);
                            bitmap.EndInit();
                            sp.hinhanh.Source = bitmap;
                            SanPhamList.Add(sp);
                        }
                    }
                }
            }
            return SanPhamList;
        }

        public void edit(string masp,ThemSP_Window sp)
        {
            Database database = new Database();
            SqlConnection conn = database.getConnection();
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP='{masp}'", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sp.txtMaSP.Text = reader["MaSP"].ToString();
                        sp.txtTenSP.Text = reader["TenSP"].ToString();
                        sp.txtTenShop.Text = reader["TenShop"].ToString();
                        sp.txtGiaGoc.Text = reader["GiaGoc"].ToString();
                        sp.txtGiaBan.Text = reader["GiaHTai"].ToString();
                        sp.txtTinhTrang.Text = reader["TinhTrang"].ToString();
                        sp.txtMoTa.Text = reader["MoTa"].ToString();
                        sp.txtTinhTrang.Text = reader["TinhTrang"].ToString();
                        sp.cbDanhMuc.SelectedItem = reader["DanhMucSP"].ToString();
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute);
                        bitmap.EndInit();
                        sp.imgHinhAnh.Source = bitmap;
                    }
                    
                }
            }
        }
        public ObservableCollection<UC_SpBan> listSPChoXacNhan()
        {
            try
            {
                ObservableCollection<UC_SpBan> SanPhamList = new ObservableCollection<UC_SpBan>();
                List<string> listsp = new List<string>();
                Database database = new Database();
                SqlConnection conn = database.getConnection();
                {
                    conn.Open();
                    string taikhoan = PhanQuyen.taikhoan;
                    using (SqlCommand command = new SqlCommand($"SELECT SP_Ban.MaSP FROM SP_Ban INNER JOIN SP_DaMua ON SP_Ban.MaSP = SP_DaMua.MaSP WHERE SP_Ban.TaiKhoan = '{taikhoan}' and SP_DaMua.XacNhan='no'", conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listsp.Add(reader["MaSP"].ToString());
                        }
                    }

                    foreach (string masp in listsp)
                    {
                        using (SqlCommand command = new SqlCommand($"SELECT * FROM SanPham where MaSP='{masp}'", conn))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UC_SpBan sp = new UC_SpBan();
                                sp.masp.Text = reader["MaSP"].ToString();
                                sp.tensp.Text = reader["TenSP"].ToString();
                                sp.mota.Text = reader["MoTa"].ToString();
                                // sp.giagoc.Text = reader["GiaGoc"].ToString();
                                sp.giaban.Text = reader["GiaHTai"].ToString();
                                sp.tinhtrang.Text = reader["TinhTrang"].ToString();
                                sp.edit.Visibility = sp.delete.Visibility = Visibility.Collapsed;
                                //sp.dagiao.Text = "Sản phẩm đã giao thành công";
                                //sp..Text = reader["MoTa"].ToString();
                                BitmapImage bitmap = new BitmapImage();
                                bitmap.BeginInit();
                                bitmap.UriSource = new Uri(reader["HinhAnh"].ToString(), UriKind.RelativeOrAbsolute);
                                bitmap.EndInit();
                                sp.hinhanh.Source = bitmap;
                                SanPhamList.Add(sp);
                            }
                        }
                    }
                }
                return SanPhamList;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
