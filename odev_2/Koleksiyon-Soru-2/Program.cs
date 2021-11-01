using System;

namespace Koleksiyon_Soru_2
{
    // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
    class Program
    {
        static void Main(string[] args)
        {
           int [] sayi =new int [20];
          
            for (int i = 0; i < sayi.Length; i++)
            {
                System.Console.WriteLine("Lütfen {0}. sayıı giriniz",i+1);
                sayi[i]=int.Parse(Console.ReadLine());
            }
            EnBuyukUcSayi(sayi);
            EnKucukUcSayi(sayi);
           
            
        }

        public static void EnKucukUcSayi(int[] arr)
        {
            int a = 0, b = 0, c = 0;

            Array.Sort(arr);
            a = arr[0];
            b = arr[1];
            c = arr[2];

            double ort = ((a+b+c)/3);
            Console.WriteLine("En küçük üç sayının ortalaması =" + ort);
        }

        static void EnBuyukUcSayi(int [] arr)
        {
            int a=0,b=0,c=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>a)
                {
                    c=b;
                    b=a;
                    a=arr[i];
                }
                else if (arr[i]>b)
                {
                    b=arr[i];
                }
                else if (arr[i]>c)
                {
                    c=arr[i];
                }
            }
            double ort = ((a+b+c)/3);
            System.Console.WriteLine("en büyük 3 sayının ortalaması" + ort);
        }
    }
}
