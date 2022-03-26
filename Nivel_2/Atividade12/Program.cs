using System;

namespace Atividade12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva o valor para 'X'");
            int X = int.Parse(Console.ReadLine());



            if (X >= 0)
            {



                Console.WriteLine($"\nO 'X' é == {X}");



            }





            else if (X < 0)
            {




                X = X * (-1);




                Console.WriteLine($"\nX * (-1) = {X}");
            }
        }
    }
}
