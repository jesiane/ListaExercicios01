/*24. Desenvolver um algoritmo que efetue a soma de todos os números 
 *ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.*/
namespace listaExercicio24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int soma = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;

                    Console.WriteLine(soma);
                }
            }

            Console.WriteLine($"A soma dos números ímpares múltiplos de três entre 1 e 500 é: {soma}");
        }
    }
}