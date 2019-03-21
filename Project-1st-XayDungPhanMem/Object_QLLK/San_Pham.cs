using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1st_XayDungPhanMem.Object_QLLK
{
    public class San_Pham
    {
        private string id_sp, ten_sp, ngaynhap, dongia, soluong, ct_sp, loai_sp;

        public string Id_sp { get => id_sp; set => id_sp = value; }
        public string Ten_sp { get => ten_sp; set => ten_sp = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Ct_sp { get => ct_sp; set => ct_sp = value; }
        public string Loai_sp { get => loai_sp; set => loai_sp = value; }

        public San_Pham() { }
        public San_Pham(string id_sp, string ten_sp, string ngaynhap, string dongia, string soluong, string ct_sp, string loai_sp)
        {
            this.id_sp = id_sp;
            this.ten_sp = ten_sp;
            this.ngaynhap = ngaynhap;
            this.dongia = dongia;
            this.soluong = soluong;
            this.ct_sp = ct_sp;
            this.loai_sp = loai_sp;
        }
    }
}