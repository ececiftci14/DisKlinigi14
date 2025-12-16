using System;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace DisKlinigi14
{
    public partial class RandevuFormu : Form
    {

        FirestoreHelper baglanti = new FirestoreHelper();

        public RandevuFormu()
        {
            InitializeComponent();
        }
        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtAdSoyad.Text == "" || txtIslem.Text == "")
                {
                    MessageBox.Show("Lütfen Ad Soyad ve Yapılacak İşlemi giriniz.");
                    return;
                }

                
                Randevu yeniRandevu = new Randevu
                {
                    HastaAdSoyad = txtAdSoyad.Text,
                    Tarih = dateTarih.Text,
                    Saat = txtSaat.Text,
                    Tedavi = txtIslem.Text
                };

                

                MessageBox.Show("Randevu başarıyla oluşturuldu!");

                
                txtAdSoyad.Clear();
                txtIslem.Clear();
                txtSaat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Close();
        }
    }


    
}