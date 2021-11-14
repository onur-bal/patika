using System;

namespace enum_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);

            int sicaklik=32;
            if(sicaklik <= (int)HavaDurumu.Normal)
            System.Console.WriteLine("dışarı çıkmak için havannın biraz daha ısınmasını bekleyiniz");

            else if (sicaklik>=(int)HavaDurumu.Sıcak)
            System.Console.WriteLine("sıcak bir gün dışarı çıkma");

            else if (sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak)
            System.Console.WriteLine("haydi dışarı");
            
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,

        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar


    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,

        CokSıcak=30

    }
}
