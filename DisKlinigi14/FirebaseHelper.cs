using System;
using Google.Cloud.Firestore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DisKlinigi14
{
    public class FirestoreHelper
    {
        public FirestoreDb database;

        public FirestoreHelper()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"service-account.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("disklinigi14");
        }

        public async Task KayitEkle(string koleksiyonAdi, object veri)
        {
            await database.Collection(koleksiyonAdi).AddAsync(veri);
        }

    }
}