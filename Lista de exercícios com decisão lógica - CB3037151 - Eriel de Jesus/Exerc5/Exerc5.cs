using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5
{
    internal class Exerc5
    {
        static void Main(string[] args)
        {
            float comprimento;
            float largura;

            Console.Write("Insira o valor do comprimento: ");
            comprimento = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o valor da largura: ");
            largura = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Área do terreno: {0}", comprimento * largura);

            if (comprimento * largura > 100)
            {
                Console.WriteLine("Terreno grande!");
            }
            else
            {
                Console.WriteLine("Terreno pequeno!");
            }
            Console.ReadKey();
        }
    }
}
