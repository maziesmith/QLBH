using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
using System.Data.SqlClient;
namespace Project_1st_XayDungPhanMem.DAO
{
    public class QLHD_DAO
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from HOA_DON";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                String mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }

        public DataTable GetData(string dk)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from HOA_DON  where " + dk;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                String mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }

        
        public bool UpData(Hoa_Don hdObj)
        {
            cmd.CommandText = "update HOA_DON set TRANG_THAI = '"+hdObj.Trangthai  + "' where ID_HD='" + hdObj.Id_hd + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                String mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete HOA_DON Where ID_HD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
    }
}