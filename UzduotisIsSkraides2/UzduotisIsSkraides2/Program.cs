using System;

namespace UzduotisIsSkraides2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            var thirdNumber = Convert.ToDouble(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber < 100)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra skaiciu ir pirmas skaicius mazesnis uz 100");
            }
            if(secondNumber > 0 && secondNumber > firstNumber)
            {
                Console.WriteLine("antras skaicius didesnis uz 0 ir antras skaicius didesnis uz pirma skaiciu");
            }
            if(firstNumber > secondNumber && firstNumber > thirdNumber || firstNumber > 0)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra skaiciu ir didesnis uz trecia skaiciu arba teigiamas");
            }
            if (thirdNumber >= 5 && thirdNumber <= 10 || thirdNumber > firstNumber || thirdNumber > secondNumber)
            {
                Console.WriteLine("trecias numeris telpa i 5-10 ir trec nr daug uz prim sk ir trec sk did uz antr sk");
            }
        }   
    }
}
