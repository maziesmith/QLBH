using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1st_XayDungPhanMem.BUS;
using Project_1st_XayDungPhanMem.Object_QLLK;
namespace Project_2nd_FormQL
{
    public partial class Phieu_xuat : Form
    {
        Phieugiao_BUS pg_bus = new Phieugiao_BUS();
        
        Phieu_Giao pg = new Phieu_Giao();
        
        
        public Phieu_xuat()
        {
            InitializeComponent();
        }

        private void Phieu_xuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLKDataSet.PHIEU_GIAO' table. You can move, or remove it, as needed.
            this.pHIEU_GIAOTableAdapter.Fill(this.qLLKDataSet.PHIEU_GIAO);
            bingding();
            Dis_Enl(false);
        }
        private void bingding()
        {
            txtidpg.DataBindings.Clear();
            txtidpg.DataBindings.Add("Text", ds_pg.DataSource, "ID_PG");
            txtTrangthai.DataBindings.Clear();
            txtTrangthai.DataBindings.Add("Text", ds_pg.DataSource, "TRANG_THAI");


        }
        private void Dis_Enl(bool e)
        {
            txtidpg.Enabled = e;
            //txttrangthai.Enabled = e;

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            pg.Trangthai = txtTrangthai.Text.Trim();
            pg.Id_pg = txtidpg.Text.Trim();
            if (pg_bus.UpdData(pg))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Phieu_xuat_Load(sender, e);
            Dis_Enl(false);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa PG này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (pg_bus.DelData(txtidpg.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            Phieu_xuat_Load(sender, e);
            Dis_Enl(false);
        }
    }
}
