using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // var name = Console.ReadLine(); var yra dalykas kur nustato pats ar string ar int ir pns
            Console.WriteLine("koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine("kokia tavo pavarde?");
            string lastname = Console.ReadLine();
            Console.WriteLine("koks tavo amzius?");
            string age = Console.ReadLine();
            Console.WriteLine(name +" " + lastname +" " + age);
            //Console.WriteLine(string.Concat(name, " ", lastname " ", age)); tas pats eilutei rasyti
            //Console.WriteLine(string.Format("{0} {1} {2}", name, lastname, age)); irgi eilutei rasyti budas
            //Console.WriteLine($"Jus suvedete: {name} {lastname} {age}"); eilutei rasyti budas trumpiausias


        }
    }
}
