using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
using System.Data.SqlClient;
namespace Project_1st_XayDungPhanMem.DAO
{
    public class CTHD_DAO
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from CTHD";
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

            cmd.CommandText = "select * from CTHD  where ID_HD='" + dk+"'";
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
        public DataTable Get_ID_HD(string dk)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select ID_HD from CTHD  where ID_HD='" + dk + "'";
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
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete CTHD Where ID_HD = '" + ma + "'";
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