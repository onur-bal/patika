using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cumledekiSesliHarfler=new ArrayList();
            ArrayList cumle = new ArrayList();
            Console.WriteLine("Lütfen Bir Cümle Giriniz= ");
            string girilencumle=Console.ReadLine();
            cumle.Add(girilencumle);
            char []  unluHarfler = {'A' ,'E','I','İ','O','Ö','U','Ü','a','e','ı','i','u','ü','o','ö'};

            for (int i = 0; i < girilencumle.Length; i++)
            {
                for (int j = 0; j < unluHarfler.Length; j++)
                {
                    if (girilencumle[i]==unluHarfler[j] && !cumledekiSesliHarfler.Contains(girilencumle[i]))
                    {
                        cumledekiSesliHarfler.Add(girilencumle[i]);
                    }
                    
                }
            }
            
            System.Console.WriteLine("cümledeki sesli harfler");
            cumledekiSesliHarfler.Sort();
            foreach (var item in cumledekiSesliHarfler)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
