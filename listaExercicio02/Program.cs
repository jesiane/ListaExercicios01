//2.Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
namespace listaExercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit");

            double temperatura = double.Parse(Console.ReadLine());

            //Para converter graus Fahrenheit em graus Celsius, subtraia 32 e divida por 1,8

             double celsius = (temperatura - 32) * 5 / 9;

           // double celsius = (temperatura - 32) / 1.8;

            Console.WriteLine("A temperatura Fahrenheit " + temperatura + " em Celsius é " + celsius);
        }
    }
}