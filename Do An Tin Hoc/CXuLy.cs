using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tin_Hoc
{
    internal class CXuLy
    {
        private static readonly BinaryFormatter bf = new BinaryFormatter();
        public Dictionary<string,CMatHang> dsMatHang = new Dictionary<string,CMatHang>();
        public Dictionary<string,CNhanSu> dsNhanSu = new Dictionary<string,CNhanSu>();
        public static List<CMatHang> dsDoanhThu = new List<CMatHang>();
       
        //Xử Lý Doanh Thu 
        public List<CMatHang> layDSDoanhThu()
        {
            return CXuLy.dsDoanhThu.ToList();
        }
        public bool docFileDoanhThu(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                CXuLy.dsDoanhThu = (List<CMatHang>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool luuFileDoanhThu(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                bf.Serialize(fs, CXuLy.dsDoanhThu);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Xử Lý Mặt Hàng
        public List<CMatHang> layDSMatHang()
        {
            return dsMatHang.Values.ToList();
        }

        public CMatHang Tim(string ma)
        {
            if (dsMatHang.ContainsKey(ma))
            {
                return dsMatHang[ma];
            }else { return null; }
        }
        public void ThemMH(CMatHang mH)
        {
            if(!dsMatHang.ContainsKey(mH.m_TenMatHang))
            {
                dsMatHang.Add(mH.m_TenMatHang, mH);
            }            
        }
        public void Xoa(CMatHang mH)
        {
            if (dsMatHang.ContainsKey(mH.m_TenMatHang.ToString()))
            {
                dsMatHang.Remove(mH.m_TenMatHang);
            }
        }
        public void Sua(CMatHang mH)
        {
            if (dsMatHang.ContainsKey(mH.m_TenMatHang.ToString()))
            {
                dsMatHang[mH.m_TenMatHang] = mH;
            }
        }
        public bool docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                dsMatHang = (Dictionary<string, CMatHang>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool luuFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                bf.Serialize(fs, dsMatHang);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        ////Xử Lý Nhân Sự
        public List<CNhanSu> layDSNhanSu()
        {
            return dsNhanSu.Values.ToList();
        }
        public CNhanSu TimNS(string ma)
        {
            if (dsNhanSu.ContainsKey(ma))
            {
                return dsNhanSu[ma];
            }
            else 
            { return null; }
        }
        public void ThemNS(CNhanSu mH)
        {
            if (!dsNhanSu.ContainsKey(mH.MaNhanVien))
            {
                dsNhanSu.Add(mH.MaNhanVien, mH);
            }
        }
        public void XoaNS(CNhanSu mH)
        {
            if (dsNhanSu.ContainsKey(mH.MaNhanVien))
            {
                dsNhanSu.Remove(mH.MaNhanVien);
            }
        }
        public void SuaNS(CNhanSu mH)
        {
            if (dsNhanSu.ContainsKey(mH.MaNhanVien))
            {
                dsNhanSu[mH.MaNhanVien] = mH;
            }
        }
        
        public bool docFileNS(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                dsNhanSu = (Dictionary<string,CNhanSu>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool luuFileNS(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                bf.Serialize(fs, dsNhanSu);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
