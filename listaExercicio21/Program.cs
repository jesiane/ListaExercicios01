/*21. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
contrário multiplique A por B. */
namespace listaExercicio21
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           int resultado;

            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                resultado = a + b;
                Console.WriteLine($"\nOs valores são iguais. A soma é: {resultado}");
            }
            else
            {
                resultado = a * b;
                Console.WriteLine($"\nOs valores são diferentes. A multiplicação é: {resultado}");
            }
        }
    }
}
