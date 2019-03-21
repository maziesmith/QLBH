using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1st_XayDungPhanMem.Object_QLLK
{
    public class CTHD
    {
        private string id_hd, id_sp, dongia, soluong, thanhtien;

        public string Id_hd { get => id_hd; set => id_hd = value; }
        public string Id_sp { get => id_sp; set => id_sp = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }

        public CTHD() { }
        public CTHD(string id_hd, string id_sp, string dongia, string soluong, string thanhtien)
        {
            this.id_hd = id_hd;
            this.id_sp = id_sp;
            this.dongia = dongia;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }
    }
}