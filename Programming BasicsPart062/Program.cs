using System;

namespace Programming_BasicsPart062
{
    class Program
    {
        static void Main(string[] args  )
        {
            //            b.Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin.
            //Kullanıcıdan toplamda kaç adet sayı alınacağı kullanıcıya bağlı olacak, kullanıcı “end” yazdığında sayı alma işlemi durdurulacak ve sonuçlar ekrana yazdırılacak.
            //Ancak kullanıcı minimum 2 sayı yazmak zorundadır.Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. 
            //Kullanıcı uygun formatta sayı yazmazsa(“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
            //Programı geliştirirken minimum sayıda değişken kullanın, her giriş yapılan değer için değişken oluşturmayın. Ayrıca kodlamada dizi kullanılmayacaktır.
            //Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir. 
            //Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.
            //NOT: “end” komutu, eğer ki toplamda 2 sayıya ulaşılmadıysa işlevsiz olacaktır ve uyarı döndürecektir.Ancak “exit” komutu herhangi bir anda doğrudan çalışabilir.
            //Ayrıca kullanıcı uygun formatta sayı yazmazsa(“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.

            const string exitCommand = "exit";
            const string endCommand = "end";
            const int requiredMinInputCount = 2;
            bool exitCommandExecuted = false;

            while (!exitCommandExecuted)
            {
                int counter = 0;
                string input;
                int inputNumber;
                int minNumber = int.MaxValue;
                int maxNumber = int.MinValue;

                while (true)
                {
                    Console.WriteLine("Lütfen {0}. sayı yazınız", counter + 1);
                    input = Console.ReadLine();

                    if (input == exitCommand)
                    {
                        exitCommandExecuted = true;
                        break;
                    }
                    else if (input == endCommand)
                    {
                        if (counter >= requiredMinInputCount)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yeterli sayıda ({0}) giriş yapılmadı!!1!!1!!", requiredMinInputCount);
                        }
                    }
                    else if (!int.TryParse(input, out inputNumber))
                    {
                        Console.Write("Yanlış formatta bir sayı girdiniz! ");
                    }
                    else
                    {
                        if (inputNumber > maxNumber)
                            maxNumber = inputNumber;

                        if (inputNumber < minNumber)
                            minNumber = inputNumber;

                        counter++;
                    }
                }

                // Flag yöntemi

                //if (exitCommandExecuted)
                //{
                //    Console.WriteLine("Program sonlandı");
                //    break;
                //}

                if (!exitCommandExecuted)
                {
                    Console.WriteLine("En büyük sayı {0}", maxNumber);
                    Console.WriteLine("En küçük sayı {0}", minNumber);
                }
            }

        }
    }
}
