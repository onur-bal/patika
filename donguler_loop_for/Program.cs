using System;

namespace donguler_loop_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz!");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i%2==1)
                System.Console.WriteLine(i);
            }

           int tektoplam=0;
          int  cifttoplam=0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                tektoplam+=i;
                else
                    cifttoplam+=i;
                
            } 
                System.Console.WriteLine("cift toplamları = " + cifttoplam );
                System.Console.WriteLine("tek toplamları = " + tektoplam );

                








            
        }
    }
}
