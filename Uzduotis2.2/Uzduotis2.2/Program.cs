using System;

namespace Uzduotis2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeigu pirmas skaicius bus 1 tai isves visu skaiciu suma," +
                "jeigu pirmas skaicius bus 2 tai isves pirmo ir trecio skaiciaus skirtuma" +
                "jeigu pirmas skaicius bus 3 tai isves antro ir trecio skaiciaus sandauga");
            Console.WriteLine(" ");
            Console.WriteLine("iveskite pirma skaiciu");
            var first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            var second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("iveskite trecia skaiciu");
            var third = Convert.ToDouble(Console.ReadLine());
            if (first == 1)
            {
                Console.WriteLine("skaiciu suma yra: " + first + second + third);
            }
            else if(first != 1)
            {
                Console.WriteLine("Pirmas skaicius nera 1");
            }
            if(first == 2)
            {
                Console.WriteLine("skaiciu skirtumas: " + (first - third));
            }
            else if(first != 2)
            {
                Console.WriteLine("Pirmas skaicius nera 2");
            }
            if(first == 3)
            {
                Console.WriteLine("skaiciu sandauga yra" + (second * third));
            }
            else if(first != 3)
            {
                Console.WriteLine("pirmas skaicius nera 3");
            }
        }
    }
}
