using System;
using System.Collections;

namespace dorduncu_soru
{
    class Program
    {
        static void Main(string[] args)
        {
           // ArrayList cumleler=new ArrayList();
            Console.WriteLine("Lütfen bir cümle yazınız = ");
            string cumle = Console.ReadLine();
            string [] cumleler= cumle.Split(' ');
           
            

        
             
                System.Console.WriteLine("toplam kelime sayısı = " + cumleler.Length);

                string harfler = "a,b,c,ç,d,e,f,g,ğ,h,ı,i,j,k,l,m,n,o,ö,p,r,s,ş,t,u,ü,v,y,z,A,B,C,Ç,D,E,F,G,Ğ,H,I,İ,J,K,L,M,N,O,Ö,P,R,S,Ş,T,U,Ü,V,Y,Z";
               int say=0;

                    for (int i = 0; i < cumle.Length; i++)
                    {
                        if(harfler.Contains(cumle[i])){
                            say++;
                        }
                    }
                System.Console.WriteLine("toplam harf sayısı = "+say );
                
    

        }
    }
}
