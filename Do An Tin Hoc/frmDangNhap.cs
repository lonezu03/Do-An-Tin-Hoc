using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Do_An_Tin_Hoc
{
    
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> danhsachTK = new List<TaiKhoan>();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile("DanhSachTaiKhoan.txt");
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    //int i = 0;
                    //string[] strings1 = new string [3];
                    List<string> strings2 = new List<string>();

                    while (!reader.EndOfStream)
                    {
                        string line=reader.ReadLine();
                       
                        strings2.Add(line);
                    }
                    for (int a = 0; a < strings2.Count; a += 3)
                    {
                        bool temp;
                        if (strings2[a + 2] == "true")
                        {
                            temp = true;
                        }
                        else temp = false;
                        TaiKhoan taikhoan = new TaiKhoan(strings2[a], strings2[a + 1], temp);
                        danhsachTK.Add(taikhoan);
                    }
                   
                }  
                
            }
        }
        public bool KTDangNhap(string tk,string mk)
        {
            for(int i = 0; i < danhsachTK.Count; i++)
            {
                if (tk == danhsachTK[i].Taikhoan && mk == danhsachTK[i].Matkhau)
                {
                    if (danhsachTK[i].LoaiTK)
                    {
                        this.Hide();
                        frmTrangChuAdmin admin = new frmTrangChuAdmin();
                        admin.ShowDialog();
                        this.Close();
                        return true;
                    }else
                    {
                        this.Hide();
                        frmTrangChuNhanVien nhanvien = new frmTrangChuNhanVien();
                        nhanvien.ShowDialog();
                        this.Close();
                        return true;
                    }                   
                }
            }
            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KTDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Đăng Nhập thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập sai\nVui lòng đăng nhập lại", "Thông Báo",MessageBoxButtons.OK);
            }
                         
        }
      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có đồng ý thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtTest1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTest2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            for(int i=0;i<danhsachTK.Count;i++)
            {
                lst.Items.Add(danhsachTK[i].Taikhoan);
                lst2.Items.Add(danhsachTK[i].Matkhau);
            }
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
