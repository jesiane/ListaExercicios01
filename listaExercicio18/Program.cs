//18. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
namespace listaExercicio18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int num1;
            int num2;
            int num3;


            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"\n{num1}, {num2}, {num3}");
                }
                else
                {
                    Console.WriteLine($"\n{num1}, {num3}, {num2}");
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"\n{num2}, {num1}, {num3}");
                }
                else
                {
                    Console.WriteLine($"\n{num2}, {num3}, {num1}");
                }
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"\n{num3}, {num1}, {num2}");
                }
                else
                {
                    Console.WriteLine($"\n{num3}, {num2}, {num1}");
                }
            }

            Console.ReadKey();
        }
    }
}