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
        List<CTaiKhoan> danhsachTK = new List<CTaiKhoan>();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ReadFile("DanhSachTaiKhoan.txt");
            LoadTKMK();
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
                        CTaiKhoan taikhoan = new CTaiKhoan(strings2[a], strings2[a + 1], temp);
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
                        CTaiKhoan.setTK(danhsachTK[i].LoaiTK);
                        admin.ShowDialog();
                        this.Close();                        
                        return true;
                    }else
                    {
                        this.Hide();
                        frmTrangChuNhanVien nhanvien = new frmTrangChuNhanVien();
                        CTaiKhoan.setTK(danhsachTK[i].LoaiTK);
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
            
        }
        public void LoadTKMK()
        {
            for (int i = 0; i < danhsachTK.Count; i++)
            {
                lst.Items.Add(danhsachTK[i].Taikhoan);
                lst2.Items.Add(danhsachTK[i].Matkhau);
            }
        }
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (lst.SelectedItem.ToString() == "Admin")
                {
                    lst2.SelectedItem = lst.Items[0];
                }
                else if (lst.SelectedItem.ToString() == "Duong")
                { 
                    lst2.SelectedItem = lst.Items[1];
                }   
            
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst.SelectedItem.ToString() == "Admin")
            {
                lst2.SelectedItem = lst2.Items[0];
                txtTaiKhoan.Text = lst.SelectedItem.ToString();
                txtMatKhau.Text= lst2.SelectedItem.ToString();
            }
            else if (lst.SelectedItem.ToString() == "Duong")
            {
                lst2.SelectedItem = lst2.Items[1];
                txtTaiKhoan.Text = lst.SelectedItem.ToString();
                txtMatKhau.Text = lst2.SelectedItem.ToString();
            }
        }
    }
}
