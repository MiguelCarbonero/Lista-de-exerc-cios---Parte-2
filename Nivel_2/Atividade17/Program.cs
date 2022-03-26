using System;

namespace Atividade17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número");
            n1 = int.Parse(Console.ReadLine());



            if (n1 >= 0 && n1 <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
