//10. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
namespace listaexercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da nota 1");
            double pn1 = double.Parse(Console.ReadLine());  

            Console.WriteLine("Digite a nota 2");
            double n2 = double.Parse(Console.ReadLine());   

            Console.WriteLine("Digite o peso da nota 2");
            double pn2 = double.Parse(Console.ReadLine());

            double NotaPonderada = ((n1 * pn1) + (n2 + pn2)) / (pn1 + pn2);

            Console.WriteLine("A media ponderada é: " + NotaPonderada);
        }
    }
}