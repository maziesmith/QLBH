using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_1st_XayDungPhanMem.DAO;
using Project_1st_XayDungPhanMem.Object_QLLK;
using System.Data;
namespace Project_1st_XayDungPhanMem.BUS
{
    public class QLSP_BUS
    {
        QLSP_DAO spMod = new QLSP_DAO();
        public DataTable GetData()
        {
            return spMod.GetData();
        }
        public DataTable GetData(string dk)
        {
            return spMod.GetData(dk);
        }
        public bool AddData(San_Pham spObj)
        {
            return spMod.AddData(spObj);
        }
        public bool UpdData(San_Pham spObj)
        {
            return spMod.UpData(spObj);
        }

        public bool DelData(string ma)
        {
            return spMod.DelData(ma);
        }
    }
}