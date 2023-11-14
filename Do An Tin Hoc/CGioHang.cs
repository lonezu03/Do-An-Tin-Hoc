using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tin_Hoc
{
    internal class CGioHang
    {
        public  CGioHang(string tenH, int giaH, int soLuongH)
        {
            ten = tenH;
            gia = giaH;
            soLuong = soLuongH;

        }


        public static Dictionary<string,CGioHang> dsGioHang = new Dictionary<string, CGioHang>();

        public static void themHang(CGioHang hang)
        {
          
            dsGioHang.Add(hang.ten,hang);          
        }
        public static void XoaHang(CGioHang hang)
        {            
            dsGioHang.Remove(hang.ten);
        }
        public  string ten { get;set; }
        public  int gia { get;set; }
        public  int soLuong { get;set; }    



    }
}
