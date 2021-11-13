using System;

namespace static_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("çalışan sayısı  : {0}", Calisan.CalisanSayisi);

            Calisan calisan=new Calisan("onur", "bal", "it");
            System.Console.WriteLine("çalışan sayısı  : {0}", Calisan.CalisanSayisi);

            System.Console.WriteLine("toplama sonucu: {0}",Islemler.Topla(100,200)); 
            System.Console.WriteLine("cıkarma sonucu: {0}",Islemler.Cikar(100,200)); 

          
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
        calisanSayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            SoyIsim = soyisim;
            Departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
