using System;

namespace ArrayJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string input;
            bool parseResult;

            do
            {
                Console.WriteLine("Lütfen dizinin boyutunu giriniz:");
                input = Console.ReadLine();

                parseResult = int.TryParse(input, out size);

                if (!parseResult)
                {
                    Console.WriteLine("Yanlış bir değer girdiniz!");
                }
                else if (size<=0)
                {
                    Console.WriteLine("Lütfen dizinin boyutunu 0'dan büyük bir deger olarak girin!");
                }
            } while (!parseResult||size<=0);

            // burdan itibaren size dogru bir sekilde elimize ulastı

            int[] numbers = new int[size];
            int value;
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                    input = Console.ReadLine();
                    parseResult = int.TryParse(input, out value);

                    if (!parseResult)
                    {
                        Console.WriteLine("Lütfen doğru formatta sayı girişi yapınız");
                    }
                } while (!parseResult);

                numbers[i] = value;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i!=0) // sadece ilk elemanca çizgi yazmayacak, digerlerinde yazacak -10-20-30...
                {
                    Console.Write("-");
                }
                Console.Write(numbers[i]);
         
            }
        }
    }
}
