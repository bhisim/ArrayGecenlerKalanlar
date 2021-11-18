using System;

namespace ArrayGecenlerKalanlar
{
    class Program
    {
        static void Main(string[] args)//Bahar Merdamert Çan değerine göre geçen ve kalan öğrencilerin isimlerini ve ortalamalarını dizide gösteren uygulama
        {
            Console.WriteLine("Kaç öğrencinin bilgisi girilecek?");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[n]; // ogrenci isimleri
            float[] ortalamalar = new float[n];

            for (int i = 0; i < n; i++)
            {
                int sira = i + 1;
                Console.WriteLine($"{sira}. öğrencinin adını giriniz");
                ogrenciler[i] = Console.ReadLine();

                Console.WriteLine($"{sira}. öğrencinin vize notunu giriniz");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{sira}. öğrencinin final notunu giriniz");
                float final = Convert.ToSingle(Console.ReadLine());

                ortalamalar[i] = (vize * 0.4f) + (final * 0.6f);

            }

            float genelToplam = 0;

            foreach (var item in ortalamalar)
            {
                genelToplam += item;

            }

            float genelOrtalama = genelToplam / n;

            string[] kalanlar = new string[0];
            string[] gecenler = new string[0];

            Console.WriteLine(kalanlar.Length);

            int kalanlarIndis = 0;
            int gecenlerIndis = 0;

            for (int i = 0; i < n; i++)
            {
                if (ortalamalar[i] < genelOrtalama)
                {
                    Array.Resize(ref kalanlar, kalanlar.Length + 1);
                    kalanlar[kalanlarIndis] = ogrenciler[i] + "-" + Convert.ToString(ortalamalar[i]);
                    kalanlarIndis++;
                }
                else
                {
                    Array.Resize(ref gecenler, gecenler.Length + 1);
                    gecenler[gecenlerIndis] = ogrenciler[i] + "-" + Convert.ToString(ortalamalar[i]);
                    gecenlerIndis++;
                }

            }

            Console.WriteLine($"Çan değeri = {genelOrtalama}");
            Console.WriteLine("**************************");

            foreach (var item in kalanlar)
            {
                
                Console.WriteLine($"Kalan öğrenciler = {item}");
            }

            Console.WriteLine("**************************");

            foreach (var item in gecenler)
            {
                
                Console.WriteLine($"Geçen öğrenciler = {item}");
            }

            Console.ReadKey();

        }
    }
}
