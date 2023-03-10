/*15. Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
uma temperatura Celsius e imprima em Fahrenheit (pesquise como fazer este tipo de conversão).*/
namespace listaExercicio15
{
    using System;

    namespace ListaExercicios.Exercicio15
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.Clear();
                Console.Write("Digite a temperatura em graus Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine($"\nA temperatura em Fahrenheit é: {fahrenheit:F2}");

                Console.ReadKey();
            }
        }
   }
}