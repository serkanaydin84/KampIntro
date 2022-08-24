using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            // geçici bir dizi oluşturuluyor ve dizimizdeki değerler geçici diziye aktarılıyor. Çünkü;
            // her new dediğimizde eski değerler siliniyor, değerler silinmesin diyeite;
            // değerler ilk önce geçici diziye aktarılıyor sonra da tekrar alınıyor
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // 
            items[items.Length - 1] = item;
        }

    }
}
