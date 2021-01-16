using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip 
            //do not repeat yourself - Kendini Tekrarlama
            //deger tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalis butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");

            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
