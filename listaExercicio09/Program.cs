//9. Crie um programa para calcular a média harmônica das notas de um Aluno
using System;
namespace listaExercicio09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Informe a quantidade de notas: ");
            int quantidadeNotas = int.Parse(Console.ReadLine());

            double somaInversos = 0;
            for (int i = 1; i <= quantidadeNotas; i++)
            {
                Console.Write($"Informe a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());

                somaInversos += 1.0 / nota;
            }

            double mediaHarmonica = quantidadeNotas / somaInversos;

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica}");
            Console.ReadLine();
        }
    }
}