//5.Crie um programa para calcular o volume de uma esfera


// Formula V = 4/3 * π *  r³
namespace listaExercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, volumen;
            Console.Write("Digite o valor do radio: ");
            radio = double.Parse(Console.ReadLine());
            volumen = 4.0 * Math.PI * radio * radio * radio / 3;
            Console.WriteLine("O valor do volumen: " + volumen);
            Console.ReadLine();
        }
    }
}