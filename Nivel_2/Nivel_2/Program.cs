using System;
using Atividade_11.Model_11;

namespace Nivel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia a = new Varia();

            Console.WriteLine("Escreva o valor para A");
            a.ddd = Console.ReadLine();

            a.valA = int.Parse(a.ddd);


            Console.WriteLine("\nEscreva o valor para B");
            a.ddd = Console.ReadLine();

            a.valB = int.Parse(a.ddd);


            a.Clone = a.valA;
            a.valA = a.valB;
            a.valA = a.Clone;

            Console.WriteLine($"\nValor de A = {a.valA}​​");

            Console.WriteLine($"\nValor de B = {a.valB}​​");
        }
    }
}
