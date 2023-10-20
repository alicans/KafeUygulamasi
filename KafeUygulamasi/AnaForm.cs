using Kafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeUygulamasi
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariYukle();
        }

        private void OrnekUrunleriYukle()
        {
           if(db.Urunler.Count == 0)
            {
                db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 20.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 35.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Omlet", BirimFiyat = 70.00m });
                db.Urunler.Add(new Urun() { UrunAd = "Gözleme", BirimFiyat = 120.00m });
            }
        }

        private void MasalariYukle()
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem();
                int masaNo = i + 1;
                lvi.Text = "Masa " + masaNo.ToString("00");
                lvi.Tag = masaNo;
                lvi.ImageKey = "bos";
                lvi.SubItems.Add("Masa " + masaNo);

                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            lvi.ImageKey = "dolu";
            int masaNo = (int)lvi.Tag;

            //MasaNo'su tıklanan öğenin nosuna eşit olan ilk siparişi getir
            Siparis? siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);

            if (siparis == null)
            {
                //Sipariş yoksa yeni sipariş oluştur
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            // yeni bir sipariş formu aç
            SiparisForm siparisForm = new SiparisForm(db,siparis);
            siparisForm.ShowDialog();


        }
    }
}
