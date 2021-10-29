using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pozitif bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            
            
        
            Console.WriteLine("{0} adet pozitif sayı giriniz",n);
            for (int i = 0; i < n; i++)
            {
                 //  Console.WriteLine("{0}.Sayıyı Giriniz;", i+1);
                int sayi= int.Parse(Console.ReadLine());
               
                if (sayi% 2==0)
                {
            }

                Console.WriteLine(sayi+"çift sayıdır");
                }
            
           
            

           
           
            
        }
    }
}
