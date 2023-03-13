//1.Crie um programa para calcular o volume de uma caixa retangular
using System;

namespace listaExercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Digite o comprimento da caixa");


            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o altura da caixa");

            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o largura da caixa");

            double largura = double.Parse(Console.ReadLine());

            double volume = comprimento * altura * largura;

            Console.WriteLine("O volume da caixa é: " + volume);
            Console.ReadLine();
        }
    }
}