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
    
    public partial class frm_QLHD : Form
    {
        QLHD_BUS hd_bus = new QLHD_BUS();
        CTHD_BUS ct_bus = new CTHD_BUS();
        Hoa_Don hd = new Hoa_Don();
        Phieugiao_BUS pg_bus = new Phieugiao_BUS();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;
        public frm_QLHD()
        {
            InitializeComponent();
        }

        private void frm_QLHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLKDataSet.HOA_DON' table. You can move, or remove it, as needed.
            this.hOA_DONTableAdapter.Fill(this.qLLKDataSet.HOA_DON);
            // TODO: This line of code loads data into the 'qLLKDataSet.HOA_DON' table. You can move, or remove it, as needed.
            //this.hOA_DONTableAdapter.Fill(this.qLLKDataSet.HOA_DON);
            bingding();
            Dis_Enl(false);
        }

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.hOA_DONTableAdapter.FillBy(this.qLLKDataSet.HOA_DON);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
        private void bingding()
        {
            txtidhd.DataBindings.Clear();
            txtidhd.DataBindings.Add("Text", ds_hd.DataSource, "ID_HD");
            txttrangthai.DataBindings.Clear();
            txttrangthai.DataBindings.Add("Text", ds_hd.DataSource, "TRANG_THAI");
            

        }
        private void Dis_Enl(bool e)
        {
            txtidhd.Enabled = e;
            //txttrangthai.Enabled = e;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ct_bus.GetData(txtidhd.Text.Trim());
            hd_ct.DataSource = dt;
            hd_ct.Refresh();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            hd.Trangthai = txttrangthai.Text.Trim();
            hd.Id_hd = txtidhd.Text.Trim();
            if (hd_bus.UpdData(hd))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frm_QLHD_Load(sender, e);
            Dis_Enl(false);
        }
        //Xóa CTHD trước rồi xóa HD
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DataTable id_hd = new DataTable();
            id_hd = ct_bus.Get_ID_HD(txtidhd.Text.Trim());
            DialogResult dr = MessageBox.Show("Xóa HD này sẽ ảnh xóa cả CTHD và phiếu giao. Bạn chắc chắn muốn xóa HD này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                ct_bus.DelDate(txtidhd.Text.Trim());
                pg_bus.DelData(txtidhd.Text.Trim());
                if (hd_bus.DelData(txtidhd.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frm_QLHD_Load(sender, e);
            Dis_Enl(false);
        }
    }
}
