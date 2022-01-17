using System;

namespace ProgrammingBasicsPart04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.Write("3.Sayıyı Giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            bool sonuc = (sayi1 == sayi2)&&(sayi3==sayi1);
            Console.WriteLine($"{sayi1},{sayi2} ve {sayi3} sayıları birbirine eşittir: {sonuc}");

            bool sonuc2 = (sayi1 != sayi2) && (sayi3 != sayi1);
            Console.WriteLine($"{sayi1},{sayi2} ve {sayi3} sayıları birbirine eşit değildir: {sonuc2}");

            bool sonuc3 = (sayi1 >sayi2) && (sayi1 >sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından büyüktür: {sonuc3}");

            bool sonuc4 = (sayi1 >= sayi2) && (sayi1 >= sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından büyüktür veya sayılara eşittir: {sonuc4}");

            bool sonuc5 = (sayi1 < sayi2) && (sayi1 < sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından küçüktür: {sonuc5}");

            bool sonuc6 = (sayi1 <= sayi2) && (sayi1 <= sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından küçüktür veya sayılara eşittir: {sonuc6}");

            bool sonuc7 = (sayi2 > sayi1) && (sayi2 > sayi1);
            Console.WriteLine($"{sayi2} sayisi {sayi2} ve {sayi3} sayılarından büyüktür: {sonuc7}");

            bool sonuc8 = (sayi2 >= sayi1) && (sayi2 >= sayi3);
            Console.WriteLine($"{sayi2} sayisi {sayi1} ve {sayi3} sayılarından büyüktür veya sayılara eşittir: {sonuc4}");

            bool sonuc9 = (sayi2 < sayi1) && (sayi2 < sayi3);
            Console.WriteLine($"{sayi2} sayisi {sayi1} ve {sayi3} sayılarından küçüktür: {sonuc5}");

            bool sonuc10 = (sayi2 <= sayi1) && (sayi2 <= sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından küçüktür veya sayılara eşittir: {sonuc10}");

            ////////////////
            bool sonuc7 = (sayi3 > sayi1) && (sayi3 > sayi2);
            Console.WriteLine($"{sayi2} sayisi {sayi2} ve {sayi3} sayılarından büyüktür: {sonuc7}");

            bool sonuc8 = (sayi2 >= sayi1) && (sayi2 >= sayi3);
            Console.WriteLine($"{sayi2} sayisi {sayi1} ve {sayi3} sayılarından büyüktür veya sayılara eşittir: {sonuc4}");

            bool sonuc9 = (sayi2 < sayi1) && (sayi2 < sayi3);
            Console.WriteLine($"{sayi2} sayisi {sayi1} ve {sayi3} sayılarından küçüktür: {sonuc5}");

            bool sonuc10 = (sayi2 <= sayi1) && (sayi2 <= sayi3);
            Console.WriteLine($"{sayi1} sayisi {sayi2} ve {sayi3} sayılarından küçüktür veya sayılara eşittir: {sonuc10}");











        }
    }
}
