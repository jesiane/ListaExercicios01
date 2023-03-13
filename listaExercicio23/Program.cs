//23. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
namespace listaExercicio23
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.Clear();
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}