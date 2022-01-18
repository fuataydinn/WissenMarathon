using System;

namespace ProgrammingBasicsPart06
{
    class Program
    {
        static void Main(string[] args)
        {
            //            c.Kullanıcıdan alınacak iki sayı arasında kalan sayıların kare ve küp değerleri hesaplanacaktır. 
            //Kullanıcı iki sayıyı birincisi küçük, ikincisi büyük olacak şekilde veya birincisi büyük, ikincisi küçük olacak şekilde sıraya bağlı kalmaksızın girebilir.
            //Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. 
            //Kullanıcı uygun formatta sayı yazmazsa(“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
            //Yapılan hesaplamalar ekrana üç kolonlu yapıda yazdırılacaktır: Sayı – Karesi – Küpü
            //Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir.Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.

            string input;
            int number1, number2;
            //Bile isteye aslında iki kez aynı şekilde yapmam gereken işi farkı görebilelim diye farklı şekilde yazdık.
            //İkisi de aynı işi yapıyor,tek farkı birinci yöntemde(döngüde) kullanıcı yanlış bir giriş yaptıgında uyarı vermiyor.
            do
            {
                Console.Write("Lütfen birinci sayıyı giriniz:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number1));

            bool parseResult;
            do
            {
                Console.Write("Lütfen ikinci sayıyı giriniz:");
                input = Console.ReadLine();
                parseResult=int.TryParse(input, out number2);  //TryParse içerde kullanınca mesaj verebiliriz fakat , yukarıdakinde mesaj veremedık çunku dogrudan kosula yazdık
                                                               // TryParse'ı

                if (!parseResult)
                {
                    Console.WriteLine("Yanlış formatta bir sayı girdiniz!");
                }

            } while (!parseResult);

            int diff = number1 - number2;

            int counter = 1;
            int number, square, cube;
            while (counter<diff)
            {
                number = number2 + counter;
                square = number * number;
                cube = square * number;

                Console.WriteLine($"Sayı:{number}\t\t Karesi: {square} \t\tKüpü: {cube}");
                counter++;
            }
         

       }
    }
}
