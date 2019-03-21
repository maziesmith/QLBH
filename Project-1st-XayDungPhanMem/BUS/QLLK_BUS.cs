using Project_1st_XayDungPhanMem.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Project_1st_XayDungPhanMem.Object_QLLK;


namespace Project_1st_XayDungPhanMem.BUS
{
    public class QLLK_BUS
    {
        public static string flat_Alert="";
        public static DataTable Add_item_into_gridview2(GridViewRow selected_row, GridView GridView2, DataTable abc)
        {
            DataRow rowdata_now = abc.NewRow();
            // Đổ dữ liệu vào DataTable abc và từ abc đổ vào vào Gridview2 hay box-selected-products
            //Nếu đã có rồi thì tăng số lượng
            bool test = true;
            foreach (GridViewRow row_gridview2 in GridView2.Rows) //Lấy lại dữ liệu đã có của Gridview2
            {

                DataRow rowdata = abc.NewRow();
                if (selected_row.Cells[1].Text != row_gridview2.Cells[2].Text)
                {
                 //rowdata_now 0:id 1:tensp 2:dongia 3:soluong 
                    rowdata[0] = row_gridview2.Cells[2].Text;
                    rowdata[1] = row_gridview2.Cells[3].Text;
                    rowdata[2] = row_gridview2.Cells[4].Text;
                    rowdata[3] = row_gridview2.Cells[5].Text;
                    abc.Rows.Add(rowdata);
                }
                else //Nếu sản phẩm đã chọn rồi thì tăng số lượng
                {
                    //rowdata_now 0:id 1:tensp 2:dongia 3:soluong 
                    rowdata[0] = row_gridview2.Cells[2].Text;
                    rowdata[1] = row_gridview2.Cells[3].Text;

                    rowdata[2] = int.Parse(selected_row.Cells[3].Text) * int.Parse(row_gridview2.Cells[5].Text) + int.Parse(selected_row.Cells[3].Text);  //Giá  
                    if(int.Parse(selected_row.Cells[4].Text) > int.Parse(row_gridview2.Cells[5].Text))
                        rowdata[3] = int.Parse(row_gridview2.Cells[5].Text) + 1;//Số lượng
                    else //Nếu vượt quá số lượng của sản phẩm
                        {                    
                        System.Web.HttpContext.Current.Response.Write("Số lượng đạt tối đa");
                        flat_Alert = "thong bao";
                        return abc;
                        }
                    abc.Rows.Add(rowdata);
                    test = false;
                }

            }
            // Ngược lại 
            //Chèn thêm dữ liệu mới vô
            if (test == true)
            {//rowdata_now 0:id 1:tensp 2:dongia 3:soluong 
                rowdata_now[0] = selected_row.Cells[1].Text;
                rowdata_now[1] = selected_row.Cells[2].Text;
                rowdata_now[2] = selected_row.Cells[3].Text;
                rowdata_now[3] = 1;
                abc.Rows.Add(rowdata_now);

            }//Đổ dữ liệu từ DataTable abc vào Gridview2
            
            return abc;
        }

        internal static object get_Product_Data_DAO(ref Datatable bcd)
        {
            throw new NotImplementedException();
        }

        public static DataTable Remove_a_item_when_selecting_item(GridViewRow selected_row, GridView GridView2, DataTable datatable_temp)
        {

            datatable_temp.Columns.Add("ID Sản phẩm");//0
            datatable_temp.Columns.Add("Tên Sản phẩm");//1
            datatable_temp.Columns.Add("Giá");//2
            datatable_temp.Columns.Add("Số lượng");

            foreach (GridViewRow gridview2_row in GridView2.Rows)
            {
                bool flat = false;
                DataRow row_data_gridview2 = datatable_temp.NewRow();
                // Text_Selected_Item.Text = selected_row.RowIndex.ToString();
                row_data_gridview2[0] = gridview2_row.Cells[2].Text;// ID 
                row_data_gridview2[1] = gridview2_row.Cells[3].Text;// Tên
                if (selected_row.Cells[2].Text == row_data_gridview2[0].ToString())
                {
                    if (int.Parse(gridview2_row.Cells[5].Text) > 1) // If the quality bigger than 1, Our remove it for 1
                    {
                       
                        row_data_gridview2[3] = int.Parse(gridview2_row.Cells[5].Text) - 1;//so luong
                        row_data_gridview2[2] = (int.Parse(gridview2_row.Cells[4].Text) / int.Parse(gridview2_row.Cells[5].Text)) *(int.Parse(gridview2_row.Cells[5].Text) - 1); //gia
                    }
                    else
                    {
                        row_data_gridview2[0] = gridview2_row.Cells[2].Text;
                        row_data_gridview2[1] = gridview2_row.Cells[3].Text;
                        row_data_gridview2[2] = gridview2_row.Cells[4].Text; //gia
                        row_data_gridview2[3] = gridview2_row.Cells[5].Text;
                        datatable_temp.Rows.Add(row_data_gridview2);
                        datatable_temp.Rows.RemoveAt(gridview2_row.RowIndex);
                        flat = true;
                    }
                }

                else
                {
                    row_data_gridview2[0] = gridview2_row.Cells[2].Text;
                    row_data_gridview2[1] = gridview2_row.Cells[3].Text;
                    row_data_gridview2[2] = gridview2_row.Cells[4].Text; //gia
                    row_data_gridview2[3] = gridview2_row.Cells[5].Text;
                }

               
        
                if (flat == false)
                    datatable_temp.Rows.Add(row_data_gridview2);
            }
            return datatable_temp;
        }
        public static DataTable Delete_a_row_which_is_item(int row_index, GridView GridView2, DataTable datatable_temp)
        {

            datatable_temp.Columns.Add("ID Sản phẩm");//0
            datatable_temp.Columns.Add("Tên Sản phẩm");//1
            datatable_temp.Columns.Add("Giá");//2
            datatable_temp.Columns.Add("Số lượng");
           
            foreach (GridViewRow gridview2_row in GridView2.Rows)
            {
                DataRow row_data_gridview2 = datatable_temp.NewRow();
                if (row_index != gridview2_row.RowIndex)
                { 
                row_data_gridview2[0] = gridview2_row.Cells[2].Text;// ID 
                row_data_gridview2[1] = gridview2_row.Cells[3].Text;// Tên                      
                row_data_gridview2[2] = gridview2_row.Cells[4].Text; //gia
                row_data_gridview2[3] = gridview2_row.Cells[5].Text;
                datatable_temp.Rows.Add(row_data_gridview2);
                }
                
            }    

            return datatable_temp;
        }
        public static DataTable updating_the_quantity(DataTable Grid1_datatable,GridViewRow selected_row, int soluong)
        {
      
            foreach(DataRow row_data in Grid1_datatable.Rows)
            {
                //giảm int soluong cho cột số lượng
                 if ( row_data[0] == selected_row.Cells[1])
                        row_data[3] = int.Parse(row_data[3].ToString())-soluong;
             
            }
            return Grid1_datatable;
        }
        public static DataTable transfer_data_from_Grid_to_Datatable(GridView Grid, GridViewRow selected_row)
        {
            DataTable Datatable_temp = new DataTable();


            Datatable_temp.Columns.Add("ID Sản phẩm");//0
            Datatable_temp.Columns.Add("Tên Sản phẩm");//1
            Datatable_temp.Columns.Add("Giá");//2
            Datatable_temp.Columns.Add("Số lượng");
            foreach (GridViewRow Grid_row in Grid.Rows)
            {
                DataRow data_Row = Datatable_temp.NewRow();
                data_Row[0] = Grid_row.Cells[1];
                data_Row[1] = Grid_row.Cells[2];
                data_Row[2] = int.Parse(Grid_row.Cells[3].Text);
                data_Row[3] = Grid_row.Cells[4];
            }
            return Datatable_temp;
        }
        public static DataTable get_Product_Data_BUS(string option)
        {
            DataTable data_Table = new DataTable();
           
            data_Table.AcceptChanges();
            data_Table =QLLK_DAO.get_Product_Data_DAO( data_Table,option).Copy();
            return data_Table;
        }
        public static int Calculator_money(GridView GridView_to_Calc)
        {
            int tongtien = 0;
            foreach (GridViewRow Grid_row in GridView_to_Calc.Rows)
            {
                tongtien = tongtien + int.Parse(Grid_row.Cells[4].Text);
            }
                return tongtien;
            
        }
        public static int last_Money(int temp_Money,string type_Combo,Hashtable ds_combo)
        { 
            if (ds_combo.ContainsKey(type_Combo))
            {
                int sotiengiam = int.Parse(ds_combo[type_Combo].ToString());
            return temp_Money - sotiengiam;
            }
            return temp_Money;
        }
        public void throw_Alert(string flat)
        {   
        }

        public static bool insert_bill(Hoa_Don hd)
        {

            if (QLLK_DAO.add_bill(hd))
                return true;
            else return false;
        }
        public static bool insert_bill_detail(CTHD cthd)
        {
            if (QLLK_DAO.add_bill_detail(cthd))
                return true;
            return false;
        }
        public static bool insert_delivery_note(Phieu_Giao pg)
        {
            if (QLLK_DAO.add_delivery_note(pg))
                return true;
            return false;
        }

    }
}