using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
using System.Data.SqlClient;
namespace Project_1st_XayDungPhanMem.DAO
{
    public class Phieugiao_DAO
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from PHIEU_GIAO";
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

            cmd.CommandText = "select * from PHIEU_GIAO  where " + dk;
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


        public bool UpData(Phieu_Giao pgObj)
        {
            cmd.CommandText = "update PHIEU_GIAO set TRANG_THAI = '" + pgObj.Trangthai + "' where ID_PG='" + pgObj.Id_pg + "'";
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
            cmd.CommandText = "Delete PHIEU_GIAO Where ID_PG = '" + ma + "'";
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