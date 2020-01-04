using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double zrp = 0;
            double zrt = 0;
            double izambine = 0;
            //Pirma uzduotis
            zrp = 4 * Math.PI * Math.Pow(6371, 2);

            //Trecia uzduotis
            double statinis1 = 10;
            double statinis2 = 15;

            izambine = Math.Sqrt(Math.Pow(statinis1, 2) + Math.Pow(statinis2, 2));

            //Ketvirta uzduotis
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Kintamasis 1: {zrp}");
            Console.WriteLine($"Kintamasis 2: {zrt}");
            Console.WriteLine($"Kintamasis 3: {izambine}");
            Console.WriteLine("Kintamuju suma yra: {0}", zrp + zrt + izambine);
            Console.WriteLine("Kintamuju vidurkis yra: {0}", (zrp+zrt+izambine) / 3);
            Console.WriteLine("*************************************************");
            Console.ReadLine();
        }
    }
}
