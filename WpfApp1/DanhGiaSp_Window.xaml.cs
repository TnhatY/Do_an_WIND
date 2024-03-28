﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Do_an
{
    /// <summary>
    /// Interaction logic for DanhGiaSp_Window.xaml
    /// </summary>
    public partial class DanhGiaSp_Window : Window
    {
        
        public DanhGiaSp_Window()
        {
            InitializeComponent();
        }
        private void Star_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton clickedStar = sender as ToggleButton;
            int dem = 0;
            if (clickedStar != null)
            {
                int clickedIndex = int.Parse(clickedStar.Name.Substring(4)); // Lấy chỉ số của sao được nhấp vào

                // Đặt các sao trước đó theo trạng thái của sao hiện tại
                for (int i = 1; i <= clickedIndex; i++)
                {
                    ToggleButton star = FindName("star" + i) as ToggleButton;
                    if (star != null)
                    {
                        star.IsChecked = true;
                        dem++;
                    }
                }

                // Bỏ chọn các sao sau đó
                for (int i = clickedIndex + 1; i <= 5; i++)
                {
                    ToggleButton star = FindName("star" + i) as ToggleButton;
                    if (star != null)
                    {
                        star.IsChecked = false;
                    }
                }
                ratingText.Text=dem.ToString();
            }
        }
        

        private void nhanXet_Click(object sender, RoutedEventArgs e)
        {

            if (sender == nx1)
            {
                nhanxet.Text += nx1.Content.ToString() + Environment.NewLine;
            }
            else if (sender == nx2)
            {
                nhanxet.Text += nx2.Content.ToString() + Environment.NewLine;
            }
            else if (sender == nx3)
            {
                nhanxet.Text += nx3.Content.ToString() + Environment.NewLine;
            }
            //StringBuilder nhanXetBuilder = new StringBuilder();

            //if (sender == nx1)
            //{
            //    nhanXetBuilder.Append(nx1.Content.ToString());
            //}
            //else if (sender == nx2)
            //{
            //    nhanXetBuilder.Append(nx2.Content.ToString());
            //}
            //else if (sender == nx3)
            //{
            //    nhanXetBuilder.Append(nx3.Content.ToString());
            //}

            //nhanxet.Text = nhanXetBuilder.ToString();

        }
    }
}
