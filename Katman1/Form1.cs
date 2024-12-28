using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesLayer;
using EntityLayer;
using LogicLayer;

namespace Katman1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<KisiBilgi> Kisilist = LogicLayer.LogicKisi.LLKisiListesi();
            dataGridView1.DataSource = Kisilist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KisiBilgi ks = new KisiBilgi();
            ks.Ad = TxtAd.Text;
            ks.Soyad = TxtSoyad.Text;
            ks.Sehir = TxtSehir.Text;
            ks.Telno = TxtTelno.Text;
            ks.Eposta = TxtEposta.Text;
            LogicKisi.LLKisiEkle(ks);
            MessageBox.Show("Kişi Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KisiBilgi ks = new KisiBilgi();
            ks.Id = Convert.ToInt32(TxtId.Text);
            LogicKisi.LLKisiSil(ks.Id);
            MessageBox.Show("Kişi Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KisiBilgi ks = new KisiBilgi();
            ks.Id = Convert.ToInt32(TxtId.Text);
            ks.Ad = TxtAd.Text;
            ks.Soyad = TxtSoyad.Text;
            ks.Sehir = TxtSehir.Text;
            ks.Telno = TxtTelno.Text;
            ks.Eposta = TxtEposta.Text;
            LogicKisi.LLKisiGuncelle(ks);
            MessageBox.Show("Kişi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
