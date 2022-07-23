using System;

namespace Degisken_ve_Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            DateTime dt = DateTime.Now; //O an icinde bulundugumuz tarih ve saati dt adinda bir degiskene tanimladik.
            Console.WriteLine(dt); //tanimladigimiz degiskeni console ekraninda yazirdik.

            string ad = "Ahmet"; //string ad degiskeni tanimladik.
            string soyad = "Kanca"; //string soyad degiskenini tanimladik.
            string tamisim = ad + " " + soyad; //string tam isim degiskenini tanimladik (" ") ile aralarinda bosluk biraktik.
            Console.WriteLine(tamisim); //console ekranina yazdirdik ==>Ahmet Kanca

            int s1 = 5; 
            int s2 = 10;          
            int stoplam = s1 + s2;
            Console.WriteLine(stoplam); //5+10= ekranda "15" yazar.

            bool b1 = 10 > 5; 
            Console.WriteLine(b1);//consol ekraninda true yazar.


            //degisken donusumu

            string str20 = "20"; //str20 ve int20 birbirine ayni degil. "int20" degiskenini string'e cevirmemiz lazim.
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // consol ekraninda "2020" yazar.

            int yeniDeger2 = Convert.ToInt32(str20) + int20; // 20+20=40 olur. Convert.ToInt() int'e donusturme
            yeniDeger2.ToString();  //Convert.ToString() string ifadeye donusturme
            Console.WriteLine(yeniDeger2);//consol ekraninda 40 yazar.

            int yeniDeger3 = int.Parse(str20) + int20; //int.Parse() string ifadeyi int'e donusturduk.
            Console.WriteLine(yeniDeger3);//consol ekraninda 40 yazar.


            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yy"); //23.07.22
            Console.WriteLine(datetime); //23.07.22 yazar.

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); //23/07/2022
            Console.WriteLine(datetime2); //23/07/2022 yazar.

            string hour = DateTime.Now.ToString("HH.mm"); //o an icinde bulunulan saati yazar. mesela==>13.58
            Console.WriteLine(hour); //13.58




        }
    }
}
