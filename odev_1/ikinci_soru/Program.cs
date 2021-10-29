using System;

namespace ikinci_soru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pozitif 2 sayı giriniz: ");
            int n=int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet pozitif sayı giriniz",n);
            for (int i = 0; i < n; i++)
            {
            int sayi=int.Parse(Console.ReadLine());
            if (sayi==m||sayi%m==0)
            {
                Console.WriteLine(sayi);
            }
                
            }



        }
    }
}
