//2.Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
namespace listaExercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit");

            double temperatura = double.Parse(Console.ReadLine());

             double celsius = (temperatura - 32) * 5 / 9;


            Console.WriteLine("A temperatura Fahrenheit " + temperatura + "°f em Celsius é " + celsius + "°C");

            Console.ReadLine();
        }
    }
}