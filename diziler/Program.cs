using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("dizinin eleman sayısını giriniz ");
            int diziUzunluğu=int.Parse(Console.ReadLine());
            int[]sayiDizisi= new int[diziUzunluğu];
            for (int i = 0; i < diziUzunluğu; i++)
            {
                System.Console.WriteLine("lütfen {0}.sayıyı giriniz",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int top =0;
            foreach (var sayi in sayiDizisi)
            {
                top+=sayi;
            }
            System.Console.WriteLine("ortalama: " + top/diziUzunluğu);
        }
    }
}
