using System;

namespace Uzduotis_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite 1 laptopas, 2 jeigu stacionaras");
            var first = Convert.ToDouble(Console.ReadLine());
            if(first == 1)
            {
                Console.WriteLine("Laptopas");
            }
            else if(first == 2)
            {
                Console.WriteLine("Stacionaras");
            }
            else
            {
                Console.WriteLine("Ivyko klaida, iveskite is naujo");
            }
        }
    }
}
