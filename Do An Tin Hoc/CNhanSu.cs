using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tin_Hoc
{
    [Serializable]
    internal class CNhanSu
    {
        private string m_maNhanVien;
        private string m_tenNhanVien;
        private DateTime m_ngaySinh;

        public string MaNhanVien { get => m_maNhanVien; set => m_maNhanVien = value; }
        public string TenNhanVien { get => m_tenNhanVien; set => m_tenNhanVien = value; }
        public DateTime NgaySinh { get => m_ngaySinh; set => m_ngaySinh = value; }

        public CNhanSu(string maNhanVien, string tenNhanVien, DateTime ngaySinh)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
        }
        public CNhanSu()
        {
            MaNhanVien = "";
            TenNhanVien = "";
            NgaySinh = DateTime.Now;
        }
    }
}
