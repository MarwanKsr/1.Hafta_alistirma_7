using System;

namespace alistirma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cumleyi giriniz: ");
            string cumle = Console.ReadLine();
            int sayi = 0;
            for (int i=0; i<cumle.Length; i++)
            {
                if (cumle[i] != ' ')
                {
                    sayi++;
                }
            }
            Console.WriteLine("Cumledeki harf sayisi: " + sayi);
        }
    }
}
