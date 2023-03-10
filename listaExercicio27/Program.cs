//27. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
namespace listaExercicio27
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;
            int anterior = 0;
            int atual = 1;
            int proximo;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write($"\nSequência de Fibonacci até o número {numero}: ");

            while (atual <= numero)
            {
                Console.Write($"{atual} ");

                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
        }
    }
}