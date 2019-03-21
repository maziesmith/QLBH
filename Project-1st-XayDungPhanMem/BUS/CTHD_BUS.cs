using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.DAO;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
namespace Project_1st_XayDungPhanMem.BUS
{
    public class CTHD_BUS
    {
        CTHD_DAO hdMod = new CTHD_DAO();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public DataTable GetData(string dk)
        {
            return hdMod.GetData(dk);
        }
        public DataTable Get_ID_HD(string dk)
        {
            return hdMod.Get_ID_HD(dk);
        }
        public bool DelDate(string dk)
        {
            return hdMod.DelData(dk);
        }
    }
}