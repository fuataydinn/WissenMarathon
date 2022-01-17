using System;

namespace Programming_BasicsPart06
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.Kullanıcıdan istenecek 10 adet sayının içerisinde en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin.
            //    Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. 
            //    Kullanıcı uygun formatta sayı yazmazsa(“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.

            int enKucuk = 0;
            int enBuyuk = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}. Sayıyı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
                if (i == 1)
                {
                    enKucuk = sayi;
                    enBuyuk = sayi;
                }
            }
            Console.WriteLine($"en küçük sayı : {enKucuk}");
            Console.WriteLine($"en büyük sayı : {enBuyuk}");


        }
    }
}
