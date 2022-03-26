using System;

namespace Atividade19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor pro lado 'A' do triangulo");
            int a = int.Parse(Console.ReadLine());



            Console.WriteLine("Escreva o valor pro lado 'B' do triangulo");
            int b = int.Parse(Console.ReadLine());



            Console.WriteLine("Escreva o valor pro lado 'C' do triangulo");
            int c = int.Parse(Console.ReadLine());




            if (a < b + c || b < a + c || c < a + b)
            {
            }



            if (a == b || a == c)
            {



                Console.WriteLine("O triângulo é equilatero");
            }



            else if (a == b || b == c || b == c)
            {
                Console.WriteLine("O triângulo é isosceles");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno");
            }
        }
    }
}
