﻿using System;

namespace Atividade16
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Console.WriteLine("Escreva o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"num1 = {num1} é maior que num2 = {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"num2 = {num2} é maior que num1 = {num1}");
            }
            else
            {

            }


            if (num1 == num2)
            { 
                    Console.WriteLine($"num1 é igual a num2  {num1} == {num2}");
            }
            else
            {

            }
        }
    }
}
