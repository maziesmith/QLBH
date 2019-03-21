using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1st_XayDungPhanMem.Object_QLLK
{
    public class Hoa_Don
    {
        private string id_hd, id_nv, id_kh, ngaylap, trangthai, tongtien;

        
        public Hoa_Don() { }
        public Hoa_Don(string id_hd, string id_nv, string id_kh, string ngaylap, string trangthai, string tongtien)
        {
            this.id_hd = id_hd;
            this.id_nv = id_nv;
            this.id_kh = id_kh;
            this.ngaylap = ngaylap;
            this.trangthai = trangthai;
            this.tongtien = tongtien;
        }

        public string Id_hd { get => id_hd; set => id_hd = value; }
        public string Id_nv { get => id_nv; set => id_nv = value; }
        public string Id_kh { get => id_kh; set => id_kh = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
    }
}