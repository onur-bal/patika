using System;
using System.Collections;

namespace ucuncu_soru
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList kelimeler = new ArrayList();
           System.Console.WriteLine("pozitif bir sayı giriniz");
           int n = int.Parse(Console.ReadLine());

             System.Console.WriteLine("{0} adet kelime giriniz ",n);
             for (int i = 0; i < n; i++)
             {
             string kelime = Console.ReadLine();
             kelimeler.Add(kelime);

                 
             }
             Console.WriteLine("Dizi elemanlarının tersten yazılısı ");
            for (int i = kelimeler.Count -1; i >= 0; i--)
            {
                Console.Write(kelimeler[i]);
            }

        }
    }
}
