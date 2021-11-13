using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="onur";
            ogrenci.Soyisim="bal";
            ogrenci.OgrenciNo=964;
            ogrenci.Sinif=3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("nur", "Balcı", 965,1 );
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();

            ogrenci1.OgrenciBilgileriniGetir();

           
        }
    }

    class Ogrenci
    {
        private string isim; 
        private string soyisim; 
        private int ogrenciNo; 
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif;
        
         set 
         {
             if (value<1)
             {

             System.Console.WriteLine("sınıf en az 1 olabilir");
             sinif=1;
             }
             else
          sinif = value;
         }
           }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {


        System.Console.WriteLine("--Öğrenci Bilgileri-----");
        System.Console.WriteLine("Öğrenci Adı  :{0}",this.Isim);
        System.Console.WriteLine("Öğrenci SoyAdı  :{0}",this.Soyisim);
        System.Console.WriteLine("Öğrenci NO  :{0}",this.OgrenciNo);
        System.Console.WriteLine("Öğrenci Sınıfı  :{0}",this.Sinif);
     

        }

        public void SinifAtlat()
        {
            this.Sinif=this.Sinif+1;
        }
        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }
    }
}
