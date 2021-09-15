using System;

namespace uzduotis1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koks jusu vardas?");
            var name = Console.ReadLine();
            Console.WriteLine("Kokia jusu pavarde?");
            var lastname = Console.ReadLine();
            Console.WriteLine("Kur uzaugote?");
            var age = Console.ReadLine();
            Console.WriteLine($"{ name} { lastname} uzaugo { age}");
        }
    }
}
