using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1st_XayDungPhanMem.Object_QLLK
{
    public class Phieu_Giao
    {
        private string id_pg, id_hd, id_kh, ngaygiao, noinhan, trangthai;

        public string Id_pg { get => id_pg; set => id_pg = value; }
        public string Id_hd { get => id_hd; set => id_hd = value; }
        public string Id_kh { get => id_kh; set => id_kh = value; }
        public string Ngaygiao { get => ngaygiao; set => ngaygiao = value; }
        public string Noinhan { get => noinhan; set => noinhan = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }

        public Phieu_Giao() { }
        public Phieu_Giao(string id_pg, string id_hd, string id_kh, string ngaygiao, string noinhan, string trangthai)
        {
            this.id_pg = id_pg;
            this.id_hd = id_hd;
            this.id_kh = id_kh;
            this.ngaygiao = ngaygiao;
            this.noinhan = noinhan;
            this.trangthai = trangthai;
        }
    }
}