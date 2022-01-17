using System;

namespace WissenMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen isminizi giriniz:");
            string isim = Console.ReadLine();
            Console.Write("Lüften yaşınızı giriniz:");
            int yas = int.Parse(Console.ReadLine());
            Console.Write("Lütfen boyunuzu giriniz");
            float boy = float.Parse(Console.ReadLine());

            Console.WriteLine($"Girdiğiniz bilgilere göre; İsminiz : {isim}, Yaşınız: {yas} , Boyunuz:{boy}");
        }
    }
}
