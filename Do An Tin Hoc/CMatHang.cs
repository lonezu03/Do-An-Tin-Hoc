using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tin_Hoc
{
    [Serializable]
    internal class CMatHang
    {
       public string m_TenMatHang { get; set; }
       public int m_GiaTien { get; set; }  
       public int m_SoLuong { get; set; }
       public bool m_DatHang { get; set; }
       public DateTime m_NgayMuaHang { get; set; }
       

        public CMatHang(string tenMatHang, int giaTien, int soLuong,bool datHang)
        {
            m_TenMatHang = tenMatHang;
            m_GiaTien = giaTien;
            m_SoLuong = soLuong;
            m_DatHang = datHang;
        }

        public CMatHang()
        {
            m_TenMatHang = "";
            m_GiaTien = 0;
            m_SoLuong = 0;
            m_DatHang = false;
        }
    }
}
