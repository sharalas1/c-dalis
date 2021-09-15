using System;

namespace Gerimai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norima punkta");
            var drinks = Console.ReadLine();
            var option = "";
            switch (drinks)
            {
                case "1":
                    //Console.WriteLine("limonadas");
                    option = "limonadas";
                    break;
                case "2":
                    option = "arbata";
                    break;
                case "3":
                    option = "kakava";
                    break;
                case "4":
                    option = "kava";
                    break;
                case "5":
                    option = "nieko";
                    break;
                default:
                    option = "blogai ivestas pasirinkimas";
                    break;
            }
            if (option != "")
            {
                Console.WriteLine("Jus pasirinkote: " + option);
            }
        }
    }
}
