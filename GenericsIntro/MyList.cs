using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//generic class T type dan geliyor.Bir tane deger alıyorsa t yaz
    {
       T[] items; //dizi

        //constructor
        public MyList()
        {
            items = new T[0];//0 elemanli dizi var
        }
       public void Add(T item)
        {
            T[] tempArray = items;//geçici dizinin referansı itemsin referansi.
            //referans  umarası uçmasın diye
            items = new T[items.Length+1];//dizinin eleman sayisini bir artir.
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //elemanı sona ekleme.
    }
    }
}
