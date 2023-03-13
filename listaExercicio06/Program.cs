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

            double fahrenheit = (temperatura * 9 / 5) + 32;
            
            Console.WriteLine("A temperatura Celsius " + temperatura + "°C em Fahrenheit é " + fahrenheit +"°f");
        }
    }
}