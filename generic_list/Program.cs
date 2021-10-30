using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>SayiListesi=new List <int>(); 
            
            SayiListesi.Add(3);
            SayiListesi.Add(33);
            SayiListesi.Add(39);
            SayiListesi.Add(38);
            SayiListesi.Add(31);
            SayiListesi.Add(323);
           System.Console.WriteLine( SayiListesi.Count);
           foreach (var sayi in SayiListesi)
           {
               System.Console.WriteLine(sayi);
           }


            
            
            
            
        }
    }
}
