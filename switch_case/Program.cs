using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1 :
                System.Console.WriteLine("ocak");
                break;

                case 2 :
                System.Console.WriteLine("şubat");
                break;

                case 3 :
                System.Console.WriteLine("mart");
                break;

                case 4 :
                System.Console.WriteLine("nisan");
                break;

                case 5 :
                System.Console.WriteLine("mayıs");
                break;

                case 6 :
                System.Console.WriteLine("haziran");
                break;

                case 7 :
                System.Console.WriteLine("temmuz");
                break;

                case 8 :
                System.Console.WriteLine("apustos");
                break;

                case 9 :
                System.Console.WriteLine("eylül");
                break;

                case 10 :
                System.Console.WriteLine("ekim");
                break;

                case 11 :
                System.Console.WriteLine("kasım");
                break;

                case 12 :
                System.Console.WriteLine("aralık");
                break;
                default:
                 System.Console.WriteLine("yanlış değer");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                System.Console.WriteLine("kış");
                break;

               
                 case 3:
                case 4:
                case 5:
                System.Console.WriteLine("ilkbahar");
                break;

                 case 6:
                case 7:
                case 8:
                System.Console.WriteLine("yaz");
                break;

                 case 9:
                case 10:
                case 11:
                System.Console.WriteLine("sonbahar");
                break;
                default:
                break;
            }
        }
    }
}
