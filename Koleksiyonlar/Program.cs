using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //stuck (isimler 101 numaralı adres)          /heap(newleyip 4 elemanlı bir yer oluşturduk 101 numaralı numara)       /değerleri yazdık
            string[] isimler = new string[] { "engin", "ada", "arda","ayşe" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);//burası hata verdi
            //hata vermesinin sebebi onu sınırların dışına çıkardık çünkü


            //isimlerin adresi artık yeni bir adres oldu 102 numaralı adres 5 tane eleman var ama boş sonra gidip 4 elemanı ilker yazdık
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            //bundan sonra 0 elemanı yazdırmak iseteidğimizde ekranda göstermedi aslında geldi ama newledik ve adres değişti artık değiştiği için boş gelir.
            //dizileri genişletemiyoruz genişletince değer kaybediyoruz.
            Console.WriteLine(isimler[0]);

            //4 elemeanlı bir arryi 5 elemanlı yapamıyorsunuz 5. elemanı eklersiniz bu sefer diğer değerleri kaybediyoruz.


            //bu sebeble hayatımıza KOLEKSİYONLAR girdi

            //list elemanı yoktu ampule tıklayıp usinge ekledik
            Console.WriteLine("***************************");
            List<string> isimler2 = new List<string> { "Engin", "barış", "ada" ,"arda"};
            // isimler2.Add("Engin", "barış", "ada");şeklindede yazılabilir

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");//4. eleman olarak ilker eklendi ve 0.değeride okudu
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //list değer kaybetmemizi önler ve değer eklememizi sağlar.
            //List bir sınıftır 


























        }
    }
}
