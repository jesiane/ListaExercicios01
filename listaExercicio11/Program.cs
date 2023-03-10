//11. Crie um programa para verificar se um número é primo.
using System;

namespace ListaExercicios.Exercicio11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = true;

            if (numero <= 1)
            {
                ehPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine($"\n{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"\n{numero} não é um número primo.");
            }

            Console.ReadKey();
        }
    }
}