using System;
using System.Windows.Forms;

namespace DisKlinigi14
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void btnHasta_Click(object sender, EventArgs e)
        {
            HastaFormu hastaSayfasi = new HastaFormu();
            hastaSayfasi.Show();
            this.Hide();
        }


        private void btnRandevu_Click(object sender, EventArgs e)
        {
            RandevuFormu randevuSayfasi = new RandevuFormu();
            randevuSayfasi.Show();
            this.Hide();
        }

        
        private void btnTedavi_Click(object sender, EventArgs e)
        {
            TedaviFormu tedaviSayfasi = new TedaviFormu();
            tedaviSayfasi.Show();
            this.Hide();
        }

       
        private void btnRecete_Click(object sender, EventArgs e)
        {
            ReceteFormu receteSayfasi = new ReceteFormu();
            receteSayfasi.Show();
            this.Hide();
        }

        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

      
        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHasta_Click_1(object sender, EventArgs e)
        {
            HastaFormu hastaSayfasi = new HastaFormu();
            hastaSayfasi.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try {
                FirestoreHelper fs = new FirestoreHelper();

                    // Veriyi gönder


                    var yeniHasta = new { Ad = "Ayşe", Soyad = "Demir" };

                // Tek satırda kayıt yapabilirsin
                await fs.KayitEkle("Hastalar", yeniHasta);


            }
            catch (Exception hata)
            {
                MessageBox.Show("PROGRAM HATASI: " + hata.Message);
            }
        }
    }
}