using System;

namespace Atividade20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resMult, resDiv;

            Console.WriteLine("Digite o primeiro valor");
            a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Digite o primeiro valor");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o segundo valor");
            b = int.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Digite o segundo valor");
                b = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o terceiro valor");
            c = int.Parse(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Digite o segundo valor");
                c = int.Parse(Console.ReadLine());
            }
            if (a > b && b > c)
            {
                resMult = (c * a);
                resDiv = (a / c);
                Console.WriteLine("A = {0}, C = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", a, c, c, a, resMult, a, c, resDiv);
            }
            else if (b > a && a > c)
            {
                resMult = (c * b);
                resDiv = (b / c);
                Console.WriteLine("B = {0}, C = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", b, c, c, b, resMult, b, c, resDiv);
            }
            else if (c > b && b > a)
            {
                resMult = (a * c);
                resDiv = (c / a);
                Console.WriteLine("A = {0}, C = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", a, c, a, c, resMult, c, a, resDiv);
            }
            else if (a > c && c > b)
            {
                resMult = (b * a);
                resDiv = (a / b);
                Console.WriteLine("A = {0}, B = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", a, b, b, a, resMult, a, b, resDiv);
            }
            else if (c > a && a > b)
            {
                resMult = (b * c);
                resDiv = (c / b);
                Console.WriteLine("B = {0}, C = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", b, c, b, a, resMult, c, b, resDiv);
            }
            else
            {
                resMult = (a * b);
                resDiv = (b / a);
                Console.WriteLine("A = {0}, B = {1}\n{2} x {3} = {4}\n{5} / {6} = {7}", a, b, a, b, resMult, b, a, resDiv);
            }
        }
    }
}
