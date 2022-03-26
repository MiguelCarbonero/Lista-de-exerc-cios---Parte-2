using System;

namespace Atividade22
{
    class Program
    {
        static void Main(string[] args)
        {

            int pos;
            int neg;

            Console.WriteLine("escreva um numero");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {​​
                pos = n1;
                Console.WriteLine($"\nesse numero é positivo {​​pos}​​");
            }

            else if (n1 < 0)
            {​​
                neg = n1;
                Console.WriteLine($"\nesse numero é negativo {​​neg}​​");
            }​​

        }
    }
}
