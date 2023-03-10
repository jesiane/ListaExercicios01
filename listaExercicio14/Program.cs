//14. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
namespace listaExercicio14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Dias Vividos \n");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasVida = idade * 365;

            Console.WriteLine($"\n{nome.ToUpper()}, você ja viveu {diasVida} dias.");

            Console.ReadKey();
        }
    }
}