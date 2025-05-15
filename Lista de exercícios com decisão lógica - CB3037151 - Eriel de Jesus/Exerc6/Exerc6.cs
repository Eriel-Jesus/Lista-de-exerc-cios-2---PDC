using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6
{
    internal class Exerc6
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double relacao;

            Console.Write("Insira o seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira a sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            relacao = peso / Math.Pow(altura, 2);

            Console.WriteLine("Relação de peso com a altura: {0}", relacao);


            if (relacao < 20)
            {
                Console.WriteLine("Abaixo do peso!");
            }    
            if (relacao >= 20 && relacao < 25)
            {
                Console.WriteLine("Peso ideal!");
            }
            if (relacao >= 25)
            {
                Console.WriteLine("Acima do peso!");
            }
            Console.ReadKey();
        }
    }
}
