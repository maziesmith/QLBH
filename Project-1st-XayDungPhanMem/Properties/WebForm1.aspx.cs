using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using Project_1st_XayDungPhanMem.BUS;
using Project_1st_XayDungPhanMem.DAO;
using System.Collections;
using Project_1st_XayDungPhanMem.Object_QLLK;

namespace Project_1st_XayDungPhanMem.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        DataTable abc = new DataTable();
        Hashtable ds_combo = new Hashtable() ;
        int flat_combo_discount=0 ;
        Hoa_Don hd = new Hoa_Don();
        CTHD cthd = new CTHD();
        Phieu_Giao pg = new Phieu_Giao();



        protected void Page_Load(object sender, EventArgs e)
        {
            abc.Columns.Add("ID Sản phẩm");//0
            abc.Columns.Add("Tên Sản phẩm");//1
            abc.Columns.Add("Giá");//2
            abc.Columns.Add("Số lượng");
            // if(flat==0)
            // string option = DropDownList_Type_of_Product.SelectedValue;
            //GridView1.DataSource = QLLK_BUS.get_Product_Data_BUS(option);
            // GridView1.DataBind();
            ds_combo.Add("combo-r3-b350","825000");
            ds_combo.Add("combo-i9-z370", "4050000");

            // ds_combo.Add("Combo2","");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {       //Đổ dữ liệu vào DATATABLE rồi sau đó trừ số lượng trên đó rồi cập nhật GridView1 //Cập Nhật Số Lượng
                GridViewRow selected_row = GridView1.SelectedRow;
                QLLK_BUS.Add_item_into_gridview2(selected_row, GridView2, abc);
            

                GridView2.DataSource = abc;
                GridView2.DataBind();
                TextBox_SumAll.Text = QLLK_BUS.Calculator_money(GridView2).ToString();
            if (QLLK_BUS.flat_Alert != "")//Cờ hiệu để xuất thông báo vượt quá số lượng sản phẩm
            {
                MessageBox.Show(this, "Vượt quá số lượng sản phẩm");
                QLLK_BUS.flat_Alert = "";
            }





        }

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView2.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
                
            }
        }




        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            GridViewRow selected_row = GridView2.SelectedRow;
            DataTable gridview2_data = new DataTable();

            QLLK_BUS.Remove_a_item_when_selecting_item(selected_row, GridView2, gridview2_data);
            gridview2_data.AcceptChanges();
            GridView2.DataSource = gridview2_data;
            GridView2.DataBind();
            TextBox_SumAll.Text = QLLK_BUS.Calculator_money(GridView2).ToString();

         


        }
        protected void Gridview2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int a=e.RowIndex;
            DataTable gridview2_data = new DataTable();
            QLLK_BUS.Delete_a_row_which_is_item(a, GridView2, gridview2_data);
            
            GridView2.DataSource = gridview2_data;
            GridView2.DataBind();
            TextBox_SumAll.Text = QLLK_BUS.Calculator_money(GridView2).ToString();
        }

       
        protected void DropDownList_Type_of_Product_TextChanged(object sender, EventArgs e)
        {
            //string option = DropDownList_Type_of_Product.Text;
            //GridView1.DataSource = null;
            //GridView1.DataBind();
            //GridView1.DataSource = QLLK_BUS.get_Product_Data_BUS(option);
            //GridView1.DataBind();
           // TextBox_Type_of_detail_Product.Text = DropDownList_Type_of_Product.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string option = DropDownList_Type_of_Product.Text;
            GridView1.DataSource = QLLK_BUS.get_Product_Data_BUS(option);
            GridView1.DataBind();
            
        }

        protected void Button_Discount_Click(object sender, EventArgs e)
        {
            if(flat_combo_discount==0)

            { TextBox_last_Money.Text = QLLK_BUS.last_Money(int.Parse(TextBox_SumAll.Text), TextBox_Discount.Text, ds_combo).ToString(); flat_combo_discount++;
               //GridView2.delete
            }
            else
                TextBox_last_Money.Text = QLLK_BUS.last_Money(int.Parse(TextBox_last_Money.Text), TextBox_Discount.Text, ds_combo).ToString();
        }

        protected void insert_bill(object sender, EventArgs e)
        {
            if(txtIDHD.Text != null && txtIDNV.Text != null && txtCMND.Text != null && txtNgayLapHD.Text != null && txtTrangThai.Text != null && TextBox_last_Money.Text != null && txtIDPG.Text != null && txtngaygiao.Text != null && txtDiaChi.Text != null)
           { 
            DataTable Datatable_temp = new DataTable();
            Datatable_temp.Columns.Add("ID Sản phẩm");//0
            Datatable_temp.Columns.Add("Tên Sản phẩm");//1
            Datatable_temp.Columns.Add("Giá");//2
            Datatable_temp.Columns.Add("Số lượng");

            hd.Id_hd = txtIDHD.Text;
            cthd.Id_hd = txtIDHD.Text;//cthd
            pg.Id_hd = txtIDHD.Text;//Phiếu Giao
            hd.Id_nv = txtIDNV.Text;
            hd.Id_kh = txtCMND.Text;
            pg.Id_kh = txtCMND.Text;//Phiếu giao
            hd.Ngaylap = txtNgayLapHD.Text;
            hd.Trangthai = txtTrangThai.Text;
            hd.Tongtien = TextBox_last_Money.Text;
            pg.Id_pg = txtIDPG.Text;
            pg.Ngaygiao = txtngaygiao.Text;
            pg.Noinhan = txtDiaChi.Text;
            pg.Trangthai = 0.ToString();
            if (QLLK_BUS.insert_bill(hd))
                MessageBox.Show(this, "Thêm Không thành công");
            else
            {
                QLLK_BUS.insert_delivery_note(pg);
                foreach (GridViewRow Grid_row in GridView2.Rows)
                {
                    DataRow data_Row = Datatable_temp.NewRow();
                    cthd.Id_sp = Grid_row.Cells[2].Text;
                    cthd.Dongia = (int.Parse(Grid_row.Cells[4].Text) / int.Parse(Grid_row.Cells[5].Text)).ToString();
                    cthd.Soluong = Grid_row.Cells[5].Text;
                    cthd.Thanhtien = Grid_row.Cells[4].Text;
                    QLLK_BUS.insert_bill_detail(cthd);
                }
                MessageBox.Show(this, "Thêm thành công");
            }
           }
            else MessageBox.Show(this, "Vui lòng nhập đầy đủ thông tin");
        }
    }
}