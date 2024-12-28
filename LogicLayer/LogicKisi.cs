using DataAccesLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicKisi
    {
        public static List<KisiBilgi> LLKisiListesi()
        {
            return DALKisi.KisiListesi();
        }
        public static int LLKisiEkle(KisiBilgi p)
        {
            if (p.Ad!="" && p.Soyad!="" && p.Ad.Length >= 3)
            {
                return DALKisi.LLKisiEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLKisiSil(int kis)
        {
            if (kis >= 1)
            {
                return DALKisi.KisiSil(kis);
            }
            else
            {
                return false;
            }
        }
        public static bool LLKisiGuncelle(KisiBilgi ks)
        {
            if(ks.Ad!="" && ks.Ad.Length >= 3 && ks.Telno!="" && ks.Eposta!="")
            {
                return DALKisi.LLKisiGuncelle(ks);
            }
            else
            {
                return false;
            }
        }
    }
}
