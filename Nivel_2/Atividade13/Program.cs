using System;

namespace Atividade13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o numero para o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());



            Console.WriteLine("\nEscreva o numero para o segundo nuero");
            int n2 = int.Parse(Console.ReadLine());



            Console.WriteLine("\nEscreva o numero para o terceiro numero");
            int n3 = int.Parse(Console.ReadLine());





            if (n1 <= n2 && n2 <= n3)
            {
                Console.WriteLine($"1-A ordem decrescente: {n3} {n2} {n1}\n");
            }
            else if (n1 <= n3 && n3 <= n2)
            {
                Console.WriteLine($"2-A ordem decrescente: {n2} {n3} {n1}\n");
            }
            else if (n2 <= n1 && n1 <= n3)
            {
                Console.WriteLine($"3-A ordem decrescente: {n3} {n1} {n2}\n");
            }
            else if (n2 <= n3 && n3 <= n1)
            {
                Console.WriteLine($"4-A ordem decrescente: {n1} {n3} {n2}\n");
            }
            else if (n3 <= n1 && n1 <= n2)
            {
                Console.WriteLine($"5-A ordem decrescente: {n3} {n1} {n2}\n");
            }
            else
            {
                Console.WriteLine($"6-A ordem decrescente: {n1} {n2} {n3}\n");
            }
        }
    }
}
