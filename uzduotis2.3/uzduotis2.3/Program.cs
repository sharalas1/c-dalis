using System;

namespace sviesaforas
{
    class Program
    {
        static void Main(string[] args)
        {
            var trafficLight = Console.ReadLine();
            var option = "";
            switch (trafficLight)
            {
                case "#ff0a0a":
                    option = "vaziuoti draudziama";
                    break;
                case "#ffe20a":
                    option = "pasiruoskite";
                    break;
                case "#008509":
                    option = "vaziuoti galima";
                    break;
                default:
                    Console.WriteLine("Neatpazinta spalva");
                    break;
            }
            if (option != "")
            {
                Console.WriteLine(option);
            }
        }
    }
}
