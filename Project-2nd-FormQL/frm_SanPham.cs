using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1st_XayDungPhanMem.DAO;
using Project_1st_XayDungPhanMem.BUS;
using Project_1st_XayDungPhanMem.Object_QLLK;
namespace Project_2nd_FormQL
{
    public partial class frm_SanPham : Form
    {
        QLSP_BUS sp_bus = new QLSP_BUS();
        San_Pham spObj = new San_Pham();
        private int flag = 0;
        public frm_SanPham()
        {
            InitializeComponent();
            
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = sp_bus.GetData();
            ds_sp.DataSource = dtDS;
            binhding();DisEnl(false);
        }
        private void binhding()
        {
            txt_idsp.DataBindings.Clear();
            txt_idsp.DataBindings.Add("Text", ds_sp.DataSource, "ID_SP");
            txt_tensp.DataBindings.Clear();
            txt_tensp.DataBindings.Add("Text", ds_sp.DataSource, "TEN_SP");
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", ds_sp.DataSource, "DON_GIA");
            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", ds_sp.DataSource, "SO_LUONG");
            dt_ngaynhap.DataBindings.Clear();
            dt_ngaynhap.DataBindings.Add("Text", ds_sp.DataSource, "NGAY_NHAP");
            txt_loaisp.DataBindings.Clear();
            txt_loaisp.DataBindings.Add("Text", ds_sp.DataSource, "LOAI_SAN_PHAM");

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txt_idsp.Enabled = e;
            txt_tensp.Enabled = e;
            txt_soluong.Enabled = e;
            dt_ngaynhap.Enabled = e;
            txt_loaisp.Enabled = e;
            txt_dongia.Enabled = e;
        }
        void ganDL(San_Pham spObj)
        {
            spObj.Id_sp = txt_idsp.Text.Trim();
            spObj.Ten_sp = txt_tensp.Text.Trim();
            spObj.Dongia = txt_dongia.Text.Trim();
            spObj.Ngaynhap = dt_ngaynhap.Text.Trim();
            spObj.Loai_sp = txt_loaisp.Text.Trim();
            spObj.Soluong = txt_soluong.Text.Trim();
            spObj.Ct_sp = "";
        }
        

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            DisEnl(true);
            flag = 0;
            
            dt_ngaynhap.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DisEnl(true);
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa SP này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (sp_bus.DelData(txt_idsp.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frm_SanPham_Load(sender, e);
            DisEnl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDL(spObj);
            if (flag == 0)
            {
                if (sp_bus.AddData(spObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sp_bus.UpdData(spObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            frm_SanPham_Load(sender, e);
            DisEnl(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frm_SanPham_Load(sender, e);
            else
                return;
            DisEnl(false);
        }

        //private void frm_SanPham_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'qLLKDataSet.SAN_PHAM' table. You can move, or remove it, as needed.
        //    this.sAN_PHAMTableAdapter.Fill(this.qLLKDataSet.SAN_PHAM);

        //}
    }
}
