using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
             Calisan calisan1=new Calisan("Onur", "Bal", 222222, "IT");
             calisan1.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string SoyAd;
            public int No;
            public string Departman;

            public Calisan (string ad, string soyad, int no, string departman)
            {
                this.Ad=ad;
                this.SoyAd=soyad;
                this.No=no;
                this.Departman=departman;

            }

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
   
