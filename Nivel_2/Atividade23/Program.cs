using System;
using Atividade23.Model23;

namespace Atividade23
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia objvar = new Varia();




            Console.WriteLine("Digite o 1 valor: ");
            objvar.valorDigitado = Console.ReadLine();



            objvar.valor1 = Math.Round(double.Parse(objvar.valorDigitado), 4);




            Console.WriteLine("Digite a operação (' / | + | * | - '): ");
            objvar.operador = Console.ReadLine();




            Console.WriteLine("Digite o 2 valor: ");
            objvar.valorDigitado = Console.ReadLine();



            objvar.valor2 = Math.Round(double.Parse(objvar.valorDigitado), 4);




            switch (objvar.operador)
            {
                case "+":
                    objvar.resultado = Math.Round(objvar.valor1 + objvar.valor2, 4);
                    Console.WriteLine($"{ objvar.valor1 } {'+'} { objvar.valor2 } = {objvar.resultado}");
                    break;
                case "-":
                    objvar.resultado = Math.Round(objvar.valor1 - objvar.valor2, 4);
                    Console.WriteLine($"{ objvar.valor1 } {'-'} { objvar.valor2 } = {objvar.resultado}");
                    break;
                case "*":
                    objvar.resultado = Math.Round(objvar.valor1 * objvar.valor2, 4);
                    Console.WriteLine($"{ objvar.valor1 } {'*'} { objvar.valor2 } = {objvar.resultado}");
                    break;
                case "/":
                    objvar.resultado = Math.Round(objvar.valor1 / objvar.valor2, 4);
                    Console.WriteLine($"{ objvar.valor1 } {'/'} { objvar.valor2 } = {objvar.resultado}");
                    break;



            }




            Console.ReadKey();
        }
    }
}
