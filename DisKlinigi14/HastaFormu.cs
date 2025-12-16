using System;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace DisKlinigi14
{
    public partial class HastaFormu : Form
    {


        public HastaFormu()
        {
            InitializeComponent();
        }

       
        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            FirestoreHelper db = new FirestoreHelper();

            try
            {
                
                if (txtAdSoyad.Text == "" || txtTelefon.Text == "")
                {
                    MessageBox.Show("Lütfen Ad Soyad ve Telefon alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                Hasta yeniHasta = new Hasta
                {
                    
                    AdSoyad = txtAdSoyad.Text,
                    Telefon = txtTelefon.Text,
                    DogumTarihi = dateDogum.Text, 
                    Cinsiyet = cmbCinsiyet.Text,  
                    Alerji = txtAlerji.Text,
                    Adres = txtAdres.Text
                   
                };

                db.KayitEkle("Hastalar", yeniHasta);

               
            
                MessageBox.Show("Hasta başarıyla sisteme kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
                Temizle();
            }
            catch (Exception ex)
            {
       
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAlerji.Clear();
            txtAdres.Clear();
            
            cmbCinsiyet.SelectedIndex = -1;
            dateDogum.Value = DateTime.Now;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Close();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }
    }
}