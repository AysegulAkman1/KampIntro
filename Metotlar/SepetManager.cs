using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)//normal parantez varsa orda metot vardır.ilk urun tip digeri isimlendirme.
        {
            Console.WriteLine("sepete eklendi: "+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi:" + urunAdi);
        }
    }
}
