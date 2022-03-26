using System;
using Atividade14.Model14;

namespace Atividade14
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia aa = new Varia();



            Console.WriteLine("Digete o primeiro numero: ");
            aa.a = Console.ReadLine();



            aa.n1 = int.Parse(aa.a);




            Console.WriteLine("\nDigete o primeiro numero: ");
            aa.a = Console.ReadLine();




            aa.n2 = int.Parse(aa.a);




            if (aa.n1 > aa.n2)
            {



                aa.result = aa.n1 - aa.n2;



                Console.WriteLine($"\n {aa.n1} - {aa.n2} Adiferença é = {aa.result}");



            }



            else if (aa.n1 < aa.n2)
            {



                aa.result = aa.n2 - aa.n1;



                Console.WriteLine($"\n {aa.n2} - {aa.n1} Adiferença é de = {aa.result}");



            }
        }
    }
}
