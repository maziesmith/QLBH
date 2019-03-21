using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.Object_QLLK;


namespace Project_1st_XayDungPhanMem.DAO
{
    public class QLLK_DAO
    {
        Hoa_Don hd = new Hoa_Don();
        CTHD cthd = new CTHD();
        Phieu_Giao pg = new Phieu_Giao();
        public static DataTable get_Product_Data_DAO(DataTable dataTable,string option_product)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A27VSOCJ\SQLEXPRESS;Initial Catalog=QLLK;Integrated Security=True");
            conn.Open();
            string option = "";
            switch (option_product)
            {
                case "main":
                    option = "where LOAI_SAN_PHAM ='main' ";
                    break;
                case "chip":
                    option = "where LOAI_SAN_PHAM = 'chip' ";
                    break;
                case "ram":
                    option = "where LOAI_SAN_PHAM ='Ram' ";
                    break;
                case "case":
                    option = "where LOAI_SAN_PHAM ='Case' ";
                    break;
                case "ssd":
                    option = "where LOAI_SAN_PHAM ='SSD' ";
                    break;
                case "hdd":
                    option = "where LOAI_SAN_PHAM ='HDD' ";
                    break;
                case "monitor":
                    option = "where LOAI_SAN_PHAM ='monitor' ";
                    break;
                case "all":
                    option = " ";
                    break;
            }
            string query = @"SELECT ID_SP as ID,TEN_SP as TênSảnPhẩm,DON_GIA as ĐơnGiá ,SO_LUONG as SốLượng FROM SAN_PHAM "+option+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
           
            da.Fill(dataTable);
            conn.Close();
            conn.Dispose();
            return dataTable;
           
        }
        //tạo Hóa Đơn, CTHD, Phiếu giao
        public static bool add_bill(Hoa_Don hd)
        {

            string query = @"insert into HOA_DON  values('" + hd.Id_hd + "','" + hd.Id_nv +  "',convert(datetime,'" + hd.Ngaylap + "',103),'" + hd.Trangthai + "','" + hd.Tongtien + "','" + hd.Id_kh + "')";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A27VSOCJ\SQLEXPRESS;Initial Catalog=QLLK;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return false;
        }

        public static bool add_bill_detail(CTHD cthd)
        {

            string query = @"insert into CTHD values('" + cthd.Id_hd + "','" + cthd.Id_sp + "','" + cthd.Dongia + "','" + cthd.Soluong + "','" + cthd.Thanhtien + "')";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A27VSOCJ\SQLEXPRESS;Initial Catalog=QLLK;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return false;
        }

        public static bool add_delivery_note(Phieu_Giao pg)
        {

            string query = @"insert into PHIEU_GIAO  values('" + pg.Id_pg + "','" + pg.Id_hd +  "',convert(datetime,'" + pg.Ngaygiao + "',103),'" + pg.Noinhan + "','" + pg.Trangthai + "','" + pg.Id_kh + "')";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A27VSOCJ\SQLEXPRESS;Initial Catalog=QLLK;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return false;
        }
    }
}