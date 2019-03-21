using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
using System.Data.SqlClient;
namespace Project_1st_XayDungPhanMem.DAO
{
    public class QLSP_DAO
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select ID_SP,TEN_SP,NGAY_NHAP,DON_GIA,SO_LUONG,LOAI_SAN_PHAM from SAN_PHAM";
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

            cmd.CommandText = "select ID_SP,TEN_SP,NGAY_NHAP,DON_GIA,SO_LUONG,LOAI_SAN_PHAM from SAN_PHAM  where " + dk;
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

        public bool AddData(San_Pham spObj)
        {
            //cmd.CommandText = "Insert into tb_NhanVien values ('" + nvObj.MaNV + "',N'" + nvObj.Ten + "',N'" + nvObj.Gioitinh + "',CONVERT(DATE,'" + nvObj.Ngaysinh + "',103),N'" + nvObj.Diachi + "','" + nvObj.Sdt + "')";
            cmd.CommandText = "insert into SAN_PHAM values('" + spObj.Id_sp + "','" + spObj.Ten_sp + "', CONVERT(datetime, '" + spObj.Ngaynhap + "', 103),'" + spObj.Dongia + "','"  + spObj.Soluong + "',N'" + spObj.Ct_sp + "','" + spObj.Loai_sp + "')";
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
        public bool UpData(San_Pham spObj)
        {
            cmd.CommandText = "update SAN_PHAM set TEN_SP = '" + spObj.Ten_sp + "',SO_LUONG = " + spObj.Soluong + ",DON_GIA='" + spObj.Dongia + "',NGAY_NHAP=CONVERT(datetime, '" + spObj.Ngaynhap + "', 103)"  + " where ID_SP='" + spObj.Id_sp + "'";
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
            cmd.CommandText = "Delete SAN_PHAM Where ID_SP = '" + ma + "'";
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