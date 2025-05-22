using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    internal class Exerc8
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

            Console.Write("Insira o valor de um dos lados do triângulo: ");
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

            Console.Write("Insira o valor de um dos lados do triângulo: ");
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

            Console.WriteLine("Primeiro valor: " + ladoa);
            Console.WriteLine("Segundo valor: " + ladob);
            Console.WriteLine("Terceiro valor: " + ladoc);
            Console.WriteLine();

            if (ladoa + ladob > ladoc && ladob + ladoc > ladoa && ladoa + ladoc > ladob)
            {
                if (ladoa > ladob)
                {
                    if (ladoa > ladoc)
                    {
                        Console.WriteLine("A hipotenusa tem valor: " + ladoa);
                        Console.WriteLine();
                        if (Math.Pow(ladoa, 2) == (Math.Pow(ladob, 2) + Math.Pow(ladoc, 2)))
                        {
                            Console.WriteLine("É um triângulo retángulo!");
                        }
                        else
                        {
                            Console.WriteLine("Não é um triângulo retángulo!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A hipotenusa tem valor: " + ladoc);
                        Console.WriteLine();
                        if (Math.Pow(ladoc, 2) == (Math.Pow(ladob, 2) + Math.Pow(ladoa, 2)))
                        {
                            Console.WriteLine("É um triângulo retángulo!");
                        }
                        else
                        {
                            Console.WriteLine("Não é um triângulo retángulo!");
                        }
                    }
                }
                else
                {
                    if (ladob > ladoc)
                    {
                        Console.WriteLine("A hipotenusa tem valor: " + ladob);
                        Console.WriteLine();
                        if (Math.Pow(ladob, 2) == (Math.Pow(ladoa, 2) + Math.Pow(ladoc, 2)))
                        {                     
                            Console.WriteLine("É um triângulo retángulo!");
                        }
                        else
                        {
                            Console.WriteLine("Não é um triângulo retángulo!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A hipotenusa tem valor: " + ladoc);
                        Console.WriteLine();
                        if (Math.Pow(ladoc, 2) == (Math.Pow(ladob, 2) + Math.Pow(ladoa, 2)))
                        {
                            Console.WriteLine("É um triângulo retángulo!");
                        }
                        else
                        {
                            Console.WriteLine("Não é um triângulo retángulo!");
                        }
                    }
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
