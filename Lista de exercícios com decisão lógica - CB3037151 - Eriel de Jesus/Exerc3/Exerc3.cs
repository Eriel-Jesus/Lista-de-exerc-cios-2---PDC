using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    internal class Exerc3
    {
        static void Main(string[] args)
        {
            float valor1;
            float valor2;
            float valor3;

            Console.Write("Insira o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o terceiro valor: ");
            valor3 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            if (valor2 == valor1 && valor1 == valor3)
            {
                Console.WriteLine("Os valores são idênticos...");
            }
            else
            {
                if (valor1 > valor2)
                {
                    if (valor1 > valor3)
                    {
                        Console.WriteLine("O primeiro valor é o maior!");
                    }
                    else
                    {
                        Console.WriteLine("O terceiro valor é o maior!");
                    }
                }
                else
                {
                    if (valor2 > valor3)
                    {
                        Console.WriteLine("O segundo valor é o maior!");
                    }
                    else
                    {
                        Console.WriteLine("O terceiro valor é o maior");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
