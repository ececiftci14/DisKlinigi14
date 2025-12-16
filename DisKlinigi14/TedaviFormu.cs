using System;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace DisKlinigi14
{
   
    public partial class TedaviFormu : Form
    {
        FirestoreHelper baglanti = new FirestoreHelper();

        public TedaviFormu()
        {
            InitializeComponent();
        }

       
        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                Tedavi yeniTedavi = new Tedavi
                {
                    TedaviAdi = txtTedavi.Text, 
                    Tutar = txtTutar.Text,      
                    Aciklama = txtAciklama.Text 
                };

                MessageBox.Show("Tedavi Eklendi!");
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