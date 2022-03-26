using System;

namespace Atividade25
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura;
            string sexo;
            double peso;

            Console.WriteLine("Insira a sua medida (altura): ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu sexo (M para masculino e F para feminino): ");
            sexo = Console.ReadLine().ToUpper();

            switch (sexo)
            {
                case "M":
                    peso = (72.2 * altura) - 58;
                    Console.WriteLine($"Seu peso ideal é {peso}");

                    break;

                case "F":
                    peso = (62.1 * altura) - 47.7;
                    Console.WriteLine($"Seu peso ideal é {peso}");

                    break;
            }
        }
    }
}
