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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;

        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            InitializeComponent();
            cmbUrun.DataSource = db.Urunler;
            DetaylariListele();
        }

        private void DetaylariListele()
        {
            dgvDetaylar.DataSource = _siparis.SiparisDetaylar.ToList();
            Guncelle();
        }

        private void Guncelle()
        {
            Text = $"Masa {_siparis.MasaNo.ToString("00")} (Açılış zamanı: {_siparis.AcilisZamani})";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutari.Text = _siparis.ToplamTutarTL;
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedItem == null) return;
            Urun urun = (Urun)cmbUrun.SelectedItem;
            SiparisDetay sd = new SiparisDetay();
            sd.UrunAd = urun.UrunAd;
            sd.BirimFiyat = urun.BirimFiyat;
            sd.Adet = (int)nudAdet.Value;

            _siparis.SiparisDetaylar.Add(sd);
            DetaylariListele();
            nudAdet.Value = 1;

            //en son eklenen satırı seç
            dgvDetaylar.Rows[dgvDetaylar.Rows.Count - 1].Selected = true;
        }

        private void dgvDetaylar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvDetaylar.SelectedRows.Count > 0)
            {
                // seçili satıra bağlı nesneyi al
                SiparisDetay sd = (SiparisDetay)dgvDetaylar.SelectedRows[0].DataBoundItem;
                _siparis.SiparisDetaylar.Remove(sd);
                DetaylariListele();
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            //formu kapat
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Iptal, 0);
        }

        private void SiparisiKapat(SiparisDurum durum, decimal odenenTutar)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.Durum = durum;
            _siparis.OdenenTutar = odenenTutar;

            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();
        }
    }
}
