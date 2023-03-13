/*19. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
 IMC em adultos Condição
 Abaixo de 18,5
 Abaixo do peso
 Entre 18,5 e 25 Peso normal
 Entre 25 e 30
 Acima do peso
 Acima de 30 obeso*/

//não esquecer a virgula na altura
namespace listaExercicio19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = (peso / (altura * altura));

            Console.WriteLine($"\nIMC = {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("\nCondição: Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("\nCondição: Peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("\nCondição: Acima do peso.");
            }
            else
            {
                Console.WriteLine("\nCondição: Obeso.");
            }

            Console.ReadKey();
        }
    }
}