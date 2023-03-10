/*29. Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10. Para isso, o programa deve gerar
todas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.
a. Desafio: Para cada número, tente separar em colunas.*/
namespace listaExercicio29
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int max = 10;

            for (int i = 1; i <= max; i++)
            {
                for (int a = 1; a <= max; a++)
                {
                    int result = i * a;

                    Console.Write("{0,2} x {1,2} = {2,3}   ", i, a, result);
                }

                Console.WriteLine();
            }
        }
    }
}