using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.DAO;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;

namespace Project_1st_XayDungPhanMem.BUS
{
    public class Phieugiao_BUS
    {
        Phieugiao_DAO hdMod = new Phieugiao_DAO();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public DataTable GetData(string dk)
        {
            return hdMod.GetData(dk);
        }
        public bool UpdData(Phieu_Giao hdObj)
        {
            return hdMod.UpData(hdObj);
        }

        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}