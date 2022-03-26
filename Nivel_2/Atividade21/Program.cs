using System;

namespace Atividade21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um numero");
            int n1 = int.Parse(Console.ReadLine());



            if (n1 > 0)
            {
                Console.WriteLine($"esse numero é positivo {n1}");
            }



            else if (n1 < 0)
            {
                Console.WriteLine($"esse numero é negativo {n1}");
            }
        }
    }
}
