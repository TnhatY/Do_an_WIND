using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;

namespace Do_an.Class
{
    internal class SanPham_DAO
    {
        public List<SanPham> Getlist() 
        {
            List<SanPham> sanPhams = new List<SanPham>();
            Database database = new Database();
            string sql = "Select * from SanPham";

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
                sanPhams.Add(new SanPham(maSP,tenSP,tenShop,giaGoc,giaHTai,ngayMua,tinhTrang,moTa,hinhAnh));
            }
            return sanPhams; 
        }
        public void them(SanPham sp)
        {
            Database database = new Database();
            SqlCommand cmd;
            SqlConnection sqlConnection = database.getConnection();
            string query = "insert into SanPham values (@MaSP,@TenSP,@TenShop,@GiaGoc,@GiaHTai,@NgayMua,@TinhTrang,@MoTa,@HinhAnh)";
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
                    command.ExecuteNonQuery();
                }
            }
            //Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            //openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    // Lấy đường dẫn file ảnh
            //    string filePath = openFileDialog.FileName;

            //    string fileName = Path.GetFileName(filePath);

            //    // Lấy thư mục chứa ảnh
            //    string directoryName = Path.GetDirectoryName(filePath);

            //    // Rút ngắn đường dẫn chỉ chứa tên file và phần mở rộng
            //    string shortenedPath = Path.Combine(directoryName, fileName);
            //    // Hiển thị ảnh lên giao diện
            //    anh.Source = new BitmapImage(new Uri(filePath));

            //    // Lưu trữ ảnh dưới dạng mảng byte
            //    //byte[] hinhThe = (byte[])anh.Source;
            //}
        }
    }
}
