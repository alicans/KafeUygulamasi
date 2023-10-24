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
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        public UrunlerForm(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            UrunleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // eğer ürün adı boş ise
            if (string.IsNullOrEmpty(txtUrunAd.Text)) return;

            Urun urun = new Urun();
            urun.UrunAd = txtUrunAd.Text.Trim();
            urun.BirimFiyat = nudBirimFiyat.Value;

            //ürünü ekle ve listele
            _db.Urunler.Add(urun);
            UrunleriListele();

            txtUrunAd.Focus();

            //en son eklenen satırı seç
            dgvUrunler.Rows[dgvUrunler.Rows.Count - 1].Selected = true;

            //formu sıfırla
            Reset();
        }

        private void Reset()
        {
            txtUrunAd.Text = null;
            nudBirimFiyat.Value = 1;
        }

        private void UrunleriListele()
        {
            dgvUrunler.DataSource = _db.Urunler.ToList();
        }
    }
}
