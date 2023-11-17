using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tin_Hoc
{
    public partial class frmCaLam : Form
    {
        public frmCaLam()
        {
            InitializeComponent();
        }

        private void pnlLich_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadMatrix()
        {
            Button oldBtn = new Button();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button btn = new Button() { Width =75,Height=40};
                    btn.Location = new Point(oldBtn.Location.X + 75, oldBtn.Location.Y);
                    pnlLich.Controls.Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width=75,Height=40,Location=new Point(0,oldBtn.Location.Y+40)};
            }
        }

        private void frmCaLam_Load(object sender, EventArgs e)
        {
            LoadMatrix();
        }
    }
}
