using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerci11
{
    internal class Exerc11
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double media;
            bool verificar;

            Console.Write("Insira a primeira nota: ");
            verificar = double.TryParse(Console.ReadLine(), out nota1);

            while (!verificar || (nota1 < 0 || nota1 > 10))
            {
                Console.Clear();
                Console.Write("Valor incorreto. Insira novamente a primeira nota: ");
                verificar = double.TryParse(Console.ReadLine(), out nota1);
            }
            Console.Clear();

            nota2 = (15 - nota1) / 2;

            Console.WriteLine("Média minima pra aprovação: 5");
            Console.WriteLine("Nota necessária para ser aprovado: " + nota2);



        }
    }
}
