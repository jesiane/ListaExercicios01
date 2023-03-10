//6. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
namespace listaExercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius");

            string strTemperatura = Console.ReadLine();

            double temperatura = Convert.ToDouble(strTemperatura);

            //Para converter graus Fahrenheit em graus Celsius, subtraia 32 e divida por 1,8

           // double fahrenheit = (temperatura + 32) * 5 / 9;

            double fahrenheit = (temperatura + 32) * 1.8;

            Console.WriteLine("A temperatura Celsius " + temperatura + " em Fahrenheit é " + fahrenheit);
        }
    }
}