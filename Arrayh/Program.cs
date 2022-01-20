using System;

namespace Arrayh
{
    class Program
    {
        static void Main(string[] args)
        {
            //h.Belirli kapasitede yeni bir int dizisi oluşturma
            //5 elemanlı yeni bir int dizisi oluşturup klavyeden 5 adet girilecek değeri dizi elemanlarına sırayla atayın.
            //Eğer kullanıcı hatalı bir giriş yaparsa uyarı döndürülecek ve giriş işlemi tekrar istenecek.Dizilere eleman atama
            //işlemlerinde döngü kullanılmayacaktır.


            int number;
            string input;
            int[] array = new int[5];
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                input = (Console.ReadLine());
            } while (!int.TryParse(input, out number));

            array[0] = number;

            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                input = (Console.ReadLine());
            } while (!int.TryParse(input, out number));

            array[1] = number;

            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                input = (Console.ReadLine());
            } while (!int.TryParse(input, out number));

            array[2] = number;

            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                input = (Console.ReadLine());
            } while (!int.TryParse(input, out number));

            array[3] = number;

            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                input = (Console.ReadLine());
            } while (!int.TryParse(input, out number));

            array[4] = number;

          
        }
    }
}
