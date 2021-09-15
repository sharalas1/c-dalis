using System;

namespace UzduotisIsSkaidres1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;
            //chekinam ar 1 sk yra didesnis uz 2 sk
            if (secondNumber > firstNumber)
            {
                Console.WriteLine($"Antrasis skaicius yra didesnis uz pirmaji. Antrojo skaiciaus reiksme yra {secondNumber}");
            }
        }
    }
}
