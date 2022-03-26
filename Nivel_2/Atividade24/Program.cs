using System;

namespace Atividade24
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int opcao;
            double media;

            Console.WriteLine("Insira o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções:\n 1- Verificar se um dos números lidos é ou não múltiplo do outro\n 2- Verificar se os dois números lidos são pares\n" +
                "3- Verificar se a média dos dois números é maior ou igual a 7.\n 4- Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    if (num1 % num2 == 0)
                    {
                        Console.WriteLine($"O número {num1} é multiplo de {num2}");
                    }
                    else if (num2 % num1 == 0)
                    {
                        Console.WriteLine($"O número {num2} é multiplo de {num1}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos dois números são multiplos um do outro");
                    }
                    break;

                case 2:

                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine($"O número {num1} é par");
                    }
                    else
                    {
                        Console.WriteLine($"O número {num1} não é par");
                    }

                    if (num2 % 2 == 0)
                    {
                        Console.WriteLine($"O número {num2} é par");
                    }
                    else
                    {
                        Console.WriteLine($"O número {num2} não é par");
                    }
                    break;

                case 3:

                    media = (num1 + num2) / 2;

                    if (media >= 7)
                    {
                        Console.WriteLine($"A média é maior ou igual a 7, sua media foi {media} ");
                    }
                    else
                    {
                        Console.WriteLine($"A média não é maior ou igual a 7, sua media foi {media} ");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
