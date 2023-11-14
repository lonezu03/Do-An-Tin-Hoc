using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tin_Hoc
{
    internal class TaiKhoan
    {
        private string taiKhoan;
        private string matKhau;
        public bool loaiTK;

        public string Taikhoan{
            get => taiKhoan;
            set => taiKhoan=value;
        }
        public string Matkhau
        {
            get => matKhau;
            set => matKhau=value;
        }
        public bool LoaiTK
        {
            get => loaiTK;
            set => loaiTK=value;
        }
        public TaiKhoan(string taikhoan,string matkhau,bool loaitk)
        {
            this.taiKhoan=taikhoan;
            this.matKhau=matkhau;
            this.loaiTK=loaitk;
        }
        public string ShowTK()
        {
            return this.taiKhoan;
        }
    }
}
