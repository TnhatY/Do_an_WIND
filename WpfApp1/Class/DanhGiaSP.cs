﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an.Class
{
    class DanhGiaSP
    {
        public string ten { get; set; }
        public string ngay { get; set; }
        public string danhgiasp { get; set; }
        public string sosao { get; set; }
        public string masp { get; set; }
        public DanhGiaSP(string _ten, string _ngay, string _danhgia, string sao)
        {
            ten = _ten;
            ngay = _ngay;
            danhgiasp = _danhgia;
            sosao = sao;
        }
        public DanhGiaSP(string masp,string _ten, string _ngay, string _danhgia, string sao)
        {
            this.masp = masp;
            ten = _ten;
            ngay = _ngay;
            danhgiasp = _danhgia;
            sosao = sao;
        }
        public DanhGiaSP() { }  
    }
}
