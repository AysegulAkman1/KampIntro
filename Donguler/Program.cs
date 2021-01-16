using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirici kampı";
            string kurs2 = "Programlamaya baslangic için temel kurs";
            string kurs3 = "java";


            //array - dizi

            string[] kurslar = new string[] { "yazilim gelistirici kampı", 
                "Programlamaya baslangic için temel kurs",
                "java","python"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)//dizileri tek tek dolaşmaya yarar.for ile aynı anlamdadır.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
