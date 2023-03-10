/*12. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
terreno e depois exibir a área do terreno.*/
namespace listaExercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite a largura do terreno em metros: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno em metros: ");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine($"\nA área do terreno é de {area} metros quadrados.");

            Console.ReadKey();
        }
    }
}
