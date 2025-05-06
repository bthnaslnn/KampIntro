using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> //Mylist' de T ile çalışacağım anlamına geliyor.
    {
        T[] items;
        //constructor 
        public MyList()
        {
           items = new T[0];        //Array her newlendiği, yeniden oluşturulduğu zaman 0 elemanlı olarak tekrardan oluşturuluyor. 
        }
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length+1];  //dizinin eleman sayısını bir arttırıyorum.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];     // for döngüsü ile, eski kaybolan elemanları tekrardan yeni diziye atayabildik böylece veri kaybına uğramadık.
            }

            items[items.Length - 1] = item;
        }

    }
} 
