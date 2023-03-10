//8. Crie um programa para calcular o volume de uma lata de óleo
namespace listaExercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio da lata de óleo");

            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo");

            double altura = double.Parse(Console.ReadLine());

            double volume = Math.PI * raio * raio * altura;
            Console.WriteLine("O valor do volume: " + volume);
            Console.WriteLine();
        }
    }
}