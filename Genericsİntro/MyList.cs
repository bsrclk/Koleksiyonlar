using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    //Genericclass özel bir tip oluşturuyor demektir
    class MyList<T>//sonuna o işaretleri ekledik ben MyList imde T ile çalışcam
    {
        //bu clasın içnde olduğu için çoğu yerden erişebilirmisin
        T[] items;// bunu classı newlediğimde oluşturmak zorundayım
        public MyList()//ctor yazıp tab tab tıkla buna constructor denir
        {
            items = new T[0];//newledik  items diye ilk olarak 0 elemanlı bir eleman oluşturduk
        }





        public void Add(T İtem)//ben Saana T ile ne verirsem istediğim elemanın türüde o dur.
            //aslında senin o T arka planda string oluyor.
        {
            T[] tempArray = items;//geçiçi dizinin referansı itemsın referansıdır.
            items = new T[items.Length + 1];//dizinin eleman sayısını 1 artırdık dşnamik yaptık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//temparry eski elemanlarına ukaştı
            }

            items[items.Length - 1] = İtem;
        
        
        }

    
    
    
    
    
    
    }
}
