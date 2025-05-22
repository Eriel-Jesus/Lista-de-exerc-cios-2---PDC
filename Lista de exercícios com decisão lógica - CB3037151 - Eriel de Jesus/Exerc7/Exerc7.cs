using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    internal class Exerc7
    {
        static void Main(string[] args)
        {
            double ladoa;
            double ladob;
            double ladoc;
            bool deucerto;

            
            Console.Write("Insira o valor de um dos lados do triângulo: ");
            deucerto = double.TryParse(Console.ReadLine(), out ladoa);
            do
            {
                if (deucerto)
                {
                    while (ladoa < 0)
                    {
                        Console.Clear();
                        Console.Write("Valor inválido. Insira novamente: ");
                        deucerto = double.TryParse(Console.ReadLine(), out ladoa);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Valor inválido. Insira novamente: ");
                    deucerto = double.TryParse(Console.ReadLine(), out ladoa);
                }
            } while (ladoa < 0 || !deucerto);
            
            Console.Clear();

            Console.Write("Insira outro valor de um dos lados do triângulo: ");
            deucerto = double.TryParse(Console.ReadLine(), out ladob);
            do
            {
                if (deucerto)
                {
                    while (ladob < 0)
                    {
                        Console.Clear();
                        Console.Write("Valor inválido. Insira novamente: ");
                        deucerto = double.TryParse(Console.ReadLine(), out ladob);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Valor inválido. Insira novamente: ");
                    deucerto = double.TryParse(Console.ReadLine(), out ladob);
                }
            } while (ladob < 0 || !deucerto);

            Console.Clear();

            Console.Write("Insira outro valor de um dos lados do triângulo: ");
            deucerto = double.TryParse(Console.ReadLine(), out ladoc);
            do
            {
                if (deucerto)
                {
                    while (ladoc < 0)
                    {
                        Console.Clear();
                        Console.Write("Valor inválido. Insira novamente: ");
                        deucerto = double.TryParse(Console.ReadLine(), out ladoc);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Valor inválido. Insira novamente: ");
                    deucerto = double.TryParse(Console.ReadLine(), out ladoc);
                }
            } while (ladoc < 0 || !deucerto);

            Console.Clear();

            if (ladoa + ladob > ladoc && ladob + ladoc > ladoa && ladoa + ladoc > ladob)
            {
               
                if (ladoa == ladob || ladob == ladoc || ladoa == ladoc)
                {
                    Console.WriteLine("É um triângulo isósceles");
                }
                if (ladoa != ladob && ladob != ladoc && ladoc != ladoa)
                {
                    Console.WriteLine("É um triângulo escaleno!");
                }
                if (ladoa == ladob && ladob == ladoc)
                {
                    Console.WriteLine("É um triângulo equilátero!");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo!");
            }
            Console.ReadKey();
        }
    }
}
