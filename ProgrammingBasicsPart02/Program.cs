using System;

namespace ProgrammingBasicsPart02
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.Alıstırma

            //Console.Write("Lütfen sayı1 giriniz :");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen sayı2 giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int toplam = sayi1 + sayi2;
            //int fark = sayi1 - sayi2;
            //int carpim = sayi1 * sayi2;
            //int bolum = sayi1 / sayi2;

            //Console.WriteLine($"Girilen sayi1:{sayi1} ve sayi2:{sayi2} degerlerinin sırası sonuçları ile toplam: {toplam}  fark: {fark} çarpım: {carpim} bolum: {bolum} ");

            ////2.Alıstırma

            //    Console.Write("Lüften 1.sayıyı giriniz:");
            //    float sayi1 = float.Parse(Console.ReadLine());
            //    Console.Write("Lüften 2.sayıyı giriniz:");
            //    float sayi2 = float.Parse(Console.ReadLine());

            //    float toplam = sayi1 + sayi2;
            //    float fark = sayi1 - sayi2;
            //    float carpim = sayi1 * sayi2;
            //    float bolum = sayi1 / sayi2;

            //    Console.WriteLine($"Girilen sayi1:{sayi1} ve sayi2:{sayi2} degerlerinin sırası sonuçları ile toplam: {toplam}  fark: {fark} çarpım: {carpim} bolum: {bolum} ");

            Console.Write("Ondalık sayıyı giriniz:");
            float ondalik = float.Parse(Console.ReadLine());
            Console.Write("Tam sayıyı giriniz:");
            int tamSayi = int.Parse(Console.ReadLine());

            float toplam = ondalik + tamSayi;
            float fark = ondalik - tamSayi;
            float carpim = ondalik * tamSayi;
            float bolum = ondalik / tamSayi;
            Console.WriteLine($"Girilen sayi1:{ondalik} ve sayi2:{tamSayi} degerlerinin sırası sonuçları ile toplam: {toplam}  fark: {fark} çarpım: {carpim} bolum: {bolum} ");
        }
    }
}