using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    internal class Exerc2
    {
        static void Main(string[] args)
        {
            float valor1;
            float valor2;

            Console.Write("Insira o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            if (valor2 == valor1)
            {
                Console.WriteLine("Os valores são idênticos...");
            }
            else 
            {
                if (valor1 > valor2)
                {
                    Console.WriteLine("O primeiro valor é maior que o segundo!");
                }
                else
                {
                    Console.WriteLine("O segundo valor é maior que o primeiro!");
                }
            }
            Console.ReadKey();
        }

    }

}
    

