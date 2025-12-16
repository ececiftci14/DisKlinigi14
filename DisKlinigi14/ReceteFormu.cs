using System;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace DisKlinigi14
{
    public partial class ReceteFormu : Form
    {
        FirestoreHelper baglanti = new FirestoreHelper();

        public ReceteFormu()
        {
            InitializeComponent();
        }

        
        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                Recete yeniRecete = new Recete
                {
                    HastaAdSoyad = txtAdSoyad.Text,
                    Ilaclar = txtIlaclar.Text,
                    Tutar = txtTutar.Text,
                    Miktar = txtMiktar.Text
                };

                MessageBox.Show("Reçete Yazıldı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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