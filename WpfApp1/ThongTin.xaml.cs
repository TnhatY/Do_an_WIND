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
    /// Interaction logic for ThongTin.xaml
    /// </summary>
    public partial class ThongTin : Window
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void UpdateImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
                image.Source = new BitmapImage(new Uri(imagePath));
        }
        public void SetImage(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            image.Source = bitmap;
        }
    }
}
