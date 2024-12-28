using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class KisiBilgi
    {
        private int ıd;
        private string ad;
        private string soyad;
        private string sehir;
        private string telno;
        private string eposta;

        public int Id { get => ıd; set => ıd = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Telno { get => telno; set => telno = value; }
        public string Eposta { get => eposta; set => eposta = value; }
    }
}
