using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            //f.Dizi elemanlarını üç kolonda ters sırada yazdırma
            //Dizi elemanlarını ters sırada üç kolonda ekrana yazdıran kodu geliştirin.Program çıktısında dizi elemanları aşağıdaki sıralamada ekrana getirilecektir.
            //***3 * *****2 * *****1 * **
            //dizi[2] dizi[1] dizi[0]
            //dizi[5] dizi[4] dizi[3]
            //dizi[8] dizi[7] dizi[6]
            //               dizi[9]
            //NOT1: Konsol çıktısı gösteriminde gerçek elemanlar değil, elemanların dizi içerisinde bulunduğu konum yazılmıştır.
            //Sıralamanın doğru anlaşılması için gerçek dizi elemanları yazılmamıştır

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //Console.Write("*3*\t*2*\t*1*");
            //Console.WriteLine();

            for (int row = 0; row < array.Length; row = row + 3) // her bir satır için bu çalışıyor kafanda o şekilde oturt
            {

                for (int col = row + 2; col >= row; col--)
                {
                    if (col < array.Length)
                    {
                        Console.Write(array[col]);
                    }

                    Console.Write("\t");
                }

                Console.WriteLine();



            }

        }
    }
}
