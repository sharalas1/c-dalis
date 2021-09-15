using System;
using System.Globalization;

namespace uzduotis1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk apskritimo spinduli");
            //string radiusInString = Console.ReadLine(); du budai parasyt. naudosim sita apacioje
            double radius = Convert.ToDouble(Console.ReadLine());

            double c = 2 * Math.PI * radius;//ilgis
            double s = Math.PI * radius * radius;//plotas. radius * radius ta pati daugimnam tas pats kas kvadratu
            Console.WriteLine($"Apskritimo ilgis yra: {c} ");
            Console.WriteLine($"Apskritimo plotas yra: {s} ");
        }
    }
}
