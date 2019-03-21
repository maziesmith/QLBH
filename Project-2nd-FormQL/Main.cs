using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Project_2nd_FormQL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_combo_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:56573/Properties/WebForm1");
        }

        

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            frm_SanPham sp = new frm_SanPham();
            sp.Show();
        }

        private void btn_QLPG_Click(object sender, EventArgs e)
        {
            Phieu_xuat pg = new Phieu_xuat();
            pg.Show();
        }

        private void btn_QLHD_Click(object sender, EventArgs e)
        {
            frm_QLHD hd = new frm_QLHD();
            hd.Show();
        }
    }
}
