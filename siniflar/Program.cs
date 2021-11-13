using System;

namespace siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calısan1=new Calisan();
            calısan1.Ad="onur";
            calısan1.SoyAd="BAL";
            calısan1.No=22222222;
            calısan1.Departman="IT";
            calısan1.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string SoyAd;
            public int No;
            public string Departman;

            public void CalisanBilgileri()
            {
                System.Console.WriteLine("Çalışan Adı:{0}",Ad);
                System.Console.WriteLine("Çalışan SoyaAdı:{0}",SoyAd);
                System.Console.WriteLine("Çalışan No:{0}",No);
                System.Console.WriteLine("Çalışan Departmanı:{0}",Departman);

            }
            

        }
    }
}
