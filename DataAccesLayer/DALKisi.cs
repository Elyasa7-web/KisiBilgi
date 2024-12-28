using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;


namespace DataAccesLayer
{
    public class DALKisi
    {
        public static List<KisiBilgi> KisiListesi()
        {
            List<KisiBilgi> deger = new List<KisiBilgi>();
            SqlCommand komut1 = new SqlCommand("Select * From TBLKİSİ", baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                KisiBilgi ks = new KisiBilgi();
                ks.Id = int.Parse(dr["ID"].ToString());
                ks.Ad = dr["AD"].ToString();
                ks.Soyad = dr["SOYAD"].ToString();
                ks.Sehir = dr["SEHIR"].ToString();
                ks.Telno = dr["TELNO"].ToString();
                ks.Eposta = dr["EPOSTA"].ToString();
                deger.Add(ks);
            }
            dr.Close();
            return deger;
        }
        public static int LLKisiEkle(KisiBilgi p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLKİSİ (AD,SOYAD,SEHIR,TELNO,EPOSTA) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti.bgl);
            if(komut2.Connection.State!= ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Sehir);
            komut2.Parameters.AddWithValue("@P4", p.Telno);
            komut2.Parameters.AddWithValue("@P5", p.Eposta);
            return komut2.ExecuteNonQuery();
        }
        public static bool KisiSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBLKİSİ where ID=@P1", baglanti.bgl);
            if (komut3.Connection.State!= ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool LLKisiGuncelle(KisiBilgi p)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLKİSİ set AD=@P1,SOYAD=@P2,SEHIR=@P3,TELNO=@P4,EPOSTA=@P5 where ID=@P6", baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", p.Ad);
            komut4.Parameters.AddWithValue("@P2", p.Soyad);
            komut4.Parameters.AddWithValue("@P3", p.Sehir);
            komut4.Parameters.AddWithValue("@P4", p.Telno);
            komut4.Parameters.AddWithValue("@P5", p.Eposta);
            komut4.Parameters.AddWithValue("@P6", p.Id);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
