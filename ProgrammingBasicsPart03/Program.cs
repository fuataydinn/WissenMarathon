using System;

namespace ProgrammingBasicsPart03
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.Ekrandan giriş yapılan iki string değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın. 
            //    Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.
            //Console.Write("Katılımcı 1 isminizi giriniz:");
            // string isim1 = Console.ReadLine();
            // Console.Write("Katılımcı 2 isminizi giriniz:");
            // string isim2 = Console.ReadLine();

            // bool karsilastirma = isim1 == isim2;
            // Console.WriteLine(karsilastirma);

            //b.Ekrandan giriş yapılan iki tam sayı değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın.
            //    Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.

            //Console.Write("1. Sayıyı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());

            //bool karsilastirma = sayi1 < sayi2;
            //Console.WriteLine(karsilastirma);

            //bool karsilastirma2 = sayi1 != sayi2;
            //Console.WriteLine(karsilastirma2);

            //c.Ekrandan giriş yapılan iki ayrı tek karakter değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın.
            //    Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.
            ""
            Console.Write("1. Karakter giriniz:");
            char karakter1 = char.Parse(Console.ReadLine());
            Console.Write("2. Karakter giriniz:");
            char karakter2 = char.Parse(Console.ReadLine());
            // buyuktur ve kucuktur sadece rakam degil harfte sıralayabilir.
            bool karsilastirma = karakter1 < karakter2;
            Console.WriteLine(karsilastirma);

            bool karsilastirma2 = karakter1 != karakter2;
            Console.WriteLine(karsilastirma2);


        }
    }
}
