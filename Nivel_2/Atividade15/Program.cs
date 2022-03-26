using System;
using Atividade15.Model15;

namespace Atividade15
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia aa = new Varia();



            Console.WriteLine("escreva sua primeira nota");
            aa.a = Console.ReadLine();



            aa.n1 = int.Parse(aa.a);



            Console.WriteLine("escreva sua Segunda nota");
            aa.a = Console.ReadLine();



            aa.n2 = int.Parse(aa.a);



            Console.WriteLine("escreva sua terceira nota");
            aa.a = Console.ReadLine();



            aa.n3 = int.Parse(aa.a);



            Console.WriteLine("escreva sua quarta nota");
            aa.a = Console.ReadLine();



            aa.n4 = int.Parse(aa.a);



            aa.med = (aa.n1 + aa.n2 + aa.n3 + aa.n4) / 4;



            if (aa.med >= 7)
            {
                Console.WriteLine($"Você passou!!! {aa.n1} + {aa.n2} + {aa.n3} + {aa.n4} /4 = {aa.med}");
            }



            else if (aa.med < 7)
            {
                Console.WriteLine("Você ficou de recuperação! escreva a sua nota da recuperação!");
                aa.a = Console.ReadLine();



                aa.n5 = int.Parse(aa.a);



            }



            aa.med2 = (aa.n1 + aa.n2 + aa.n3 + aa.n4 + aa.n5) / 5;



            if (aa.med2 >= 7)
            {
                Console.WriteLine("Você passou!!!");
            }
            else
            {
                Console.WriteLine($"Você reprovou. '{aa.n1} + {aa.n2} + {aa.n3} + {aa.n4} + {aa.n5}' /5 = {aa.med2}");
            }
        }
    }
}
