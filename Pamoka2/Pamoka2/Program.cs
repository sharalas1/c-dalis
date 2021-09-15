using System;

namespace Pamoka2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu");
            var age = Convert.ToInt32(Console.ReadLine());
            if(age >= 20 && age < 50)
            {
                Console.WriteLine("Sveiki prisijunge");
            }
            else if (age >= 50 && age <= 70)// arba daugiau uz 50 arba maziau 70 metu
            {
                Console.WriteLine("Jums yra spec pasiulymas");
            }
            else
            {
                Console.WriteLine("Gal ateikite kita karta");
            }
        }
    }
}
