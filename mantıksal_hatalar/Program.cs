using System;

namespace mantıksal_hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
              Console.WriteLine("bir sayı giriniz");
              int sayi = Convert.ToInt32(Console.ReadLine());
              System.Console.WriteLine("girdiniğiniz sayı= "+ sayi);
           }
           catch(Exception ex)
           {
                System.Console.WriteLine( "hata: " + ex.Message.ToString());
           }
           finally
           {
               System.Console.WriteLine("işlem tamamlandı");
           }
           
            
        }
    }
}
