//20. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
namespace listaExercicios20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nO número digitado é par.");
            }
            else
            {
                Console.WriteLine("\nO número digitado é ímpar.");
            }
        }
    }
}