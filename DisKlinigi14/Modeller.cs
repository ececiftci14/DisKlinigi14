using System;

namespace DisKlinigi14 
{
    
    public abstract class BaseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EklenmeTarihi { get; set; } = DateTime.Now.ToString("dd.MM.yyyy");
    }

    
    public class Hasta : BaseModel
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Alerji { get; set; }
        public string Adres { get; set; }
    }

    
    public class Randevu : BaseModel
    {
        public string HastaAdSoyad { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public string Tedavi { get; set; }
    }

    public class Tedavi : BaseModel
    {
        public string TedaviAdi { get; set; }
        public string Tutar { get; set; }
        public string Aciklama { get; set; }
    }

   
    public class Recete : BaseModel
    {
        public string HastaAdSoyad { get; set; }
        public string Ilaclar { get; set; }
        public string Tutar { get; set; }
        public string Miktar { get; set; }
    }
}