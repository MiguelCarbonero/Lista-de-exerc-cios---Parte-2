using System;

namespace Atividade18
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            int codigo;



            Console.WriteLine("Escreva um numero entre ('1, 2, 3')");
            a = Console.ReadLine();



            codigo = int.Parse(a);




            switch (codigo)
            {
                case 1:



                    Console.WriteLine("Voce entrou na casa '1'");
                    break;



                case 2:



                    Console.WriteLine("Voce entrou na casa '2'");
                    break;



                case 3:



                    Console.WriteLine("Voce entrou na casa '3'");
                    break;
            }
        }
    }
}
