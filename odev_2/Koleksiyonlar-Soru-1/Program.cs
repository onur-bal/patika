using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("20 adet pozitif sayı giriniz :");
            ArrayList tumSayilar= new ArrayList();
            ArrayList asal=new ArrayList();
            ArrayList asalOlmayan=new ArrayList();

                for (int i = 0; i < 5; i++)
                {
                    int sayi= int.Parse(Console.ReadLine());
                    tumSayilar.Add(sayi);
                }
                
               int sayac=0;
                foreach (int item in tumSayilar)
                {
                    for (int i = 2; i < item; i++)
                    {
                        if (item%i==0)
                        {
                            sayac++;
                        
                        }
                    }

                        if (sayac==0)
                        {
                            asal.Add(item);
                            sayac=0;
                        }
                        else
                        {
                            asalOlmayan.Add(item);
                        }
                }
                        asal.Sort();
                        asalOlmayan.Sort();
                        double top=0;
                        System.Console.WriteLine("asalolmayanların sayısı= "+asalOlmayan.Count);

                        foreach (int item in asalOlmayan)
                        {

                            top=top+item;
                        
                            System.Console.WriteLine(item);
                        }
                        System.Console.WriteLine("asal olan sayıların adedi = "+asal.Count);
                         foreach (int item in asal)
                        {

                            top=top+item;
                        
                            System.Console.WriteLine(item);
                        }
                        


        }
            
                
                
                

            

    }
}
