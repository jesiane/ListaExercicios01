/* Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
resultado.
a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
b. Pesquise sobre “fatorial” */
namespace listaExercicio26
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;
            int fatorial = 1;

            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write($"\n{numero}! = ");
            for (int i = numero; i >= 1; i--)
            {
                Console.Write($"{i}");
                fatorial *= i;
                if (i > 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.Write($" = {fatorial}");
        }
    }
}