using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            Console.WriteLine("----------------------Atama ve islemli atama----------------------");
            //Atama ve islemli atama

            int x = 3;
            int y = 3;
            y = y + 2; //==> eger y degiskenini 2 arttirmak istersem boyle yazabilirim.
            y += 2; //==> yukaridaki gibi ayni sekilde 2 arttirmak istersem boylede yazabilirim. Buna islemli atama denir.

            int a = 5;
            a /= 5;
            Console.WriteLine(a); // 1 yazar.

            int b = 10;
            b *= 3;
            Console.WriteLine(b); //30 yazar.

            Console.WriteLine("----------------------Mantıksal operatorler-----------------------");
            //Mantiksal operatorler

            bool isSucces = true;
            bool isCompleted = false;
            if (isSucces && isCompleted)
            {
                Console.WriteLine("Perfect!");  //true&&false atladi.
            }
            if(isSucces || isCompleted)
            {
                Console.WriteLine("Great!");    //true||false Great! yazar.
            }
            if (isSucces && !isCompleted)
            {
                Console.WriteLine("Fine!");     //true&& !false Fine! yazar.
            }

            Console.WriteLine("----------------------İliskisel operatorler-----------------------");

            //İliskisel operatorler

            int c = 3;
            int d = 4;
            bool sonuc = c < d;  //kucuk ise true,degilse false
            Console.WriteLine(sonuc); //true yazar.

            int k = 5;
            int l = 10;
            bool sonuc1 = k > l; //buyuk ise true,degilse false
            Console.WriteLine(sonuc1);//false yazar.

            int m = 8;
            int n = 9;
            bool sonuc2 = m <= n; // kucuk veya esit ise true, degilse false
            Console.WriteLine(sonuc2); //true yazar.

            int o = 8;
            int p = 11;
            bool sonuc3 = o >= p; //buyuk veya esitse true, degilse false
            Console.WriteLine(sonuc3); //false yazar.

            int w = 10;
            int v = 10;
            bool sonuc4 = w == v; // esit ise true, degilse false
            Console.WriteLine(sonuc4); // true yazar.

            int e = 5;
            int g = 12;
            bool sonuc5 = e != g;  //esit degil ise true, esitse false
            Console.WriteLine(sonuc5); //true yazar.

            Console.WriteLine("----------------------Aritmetik operatorler-----------------------");

            //Aritmetik operatorler

            int sayi1 = 6;
            int sayi2 = 6;

            int toplama= sayi1 + sayi2;
            Console.WriteLine(toplama);// 12 yazar.

            int cikarma = sayi1 - sayi2;
            Console.WriteLine(cikarma);//0 yazar.

            int carpma = sayi1 * sayi2;
            Console.WriteLine(carpma);//36 yazar.

            int bolme = sayi1 / sayi2;
            Console.WriteLine(bolme);// 1 yazar.

            int arttirma = ++sayi1;
            Console.WriteLine(arttirma);//"++" 6+1=7 yazar. "++ degiskenin onune koyarsak once arttirir ama sonuna koyarsak sonra arttirir.


            int sayi3 = 20;
            int mod = sayi3 % 6;
            Console.WriteLine(mod);//20'yi 6'ya bolunce cikan kalani verir.
            




        }
    }
}
