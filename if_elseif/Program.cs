using System;

namespace if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time > 18)
            Console.WriteLine("iyi akşamlar");
            else if (time >= 6 && time<=11)
            System.Console.WriteLine("günaydın");
            else
            System.Console.WriteLine("iyi akşamlar");

        }
    }
}
