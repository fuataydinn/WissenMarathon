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


            const int loopLimit = 9;  // değişkenleri her zaman döngünün dışında tanımla
            int inputNumber;          // sayı'dan başka bişi giremesin diye TryParse kullan ! -- boolean sonuc dondurur ve çift parametre ile calisir.
            int maxNumber = int.MinValue; // max sayıya verilecek min değer
            int minNumber = int.MaxValue;
            int counter = 0;
            string input;

            while (counter < loopLimit)
            {
                Console.WriteLine("Lütfen {0}. sayı giriniz:", counter + 1);
                input = Console.ReadLine();
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Yanlış formatta bir sayı giriniz");
                    continue; // continue dan sonraki şartlara bakılmaz direk while döner. Döngüde kullanılıyor bu sadece.
                }
                if (inputNumber > maxNumber)
                {
                    maxNumber = inputNumber;
                }
                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
                counter++;

            }
            Console.WriteLine($"Giriş yapılan sayılardan en küçüğü {minNumber}");
            Console.WriteLine($"Giriş yapılan sayılardan en büyüğü {maxNumber}");
        }
    }
}
