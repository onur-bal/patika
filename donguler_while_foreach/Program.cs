using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi=int.Parse(Console.ReadLine());
            int top = 0;
            int sayac=1;
            while (sayac<=sayi)
            {
                top+=sayac;
                sayac ++ ;
            }
                 System.Console.WriteLine("ortalama=" + top/sayi);

                 string[] arabalar ={"nissan","dacia","ford","bmw"};

                 foreach (var araba in arabalar)
                 {
                     System.Console.WriteLine(araba);
                 }
        }
    }
}
