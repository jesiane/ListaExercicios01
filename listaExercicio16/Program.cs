/*16. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
impostos. Imprima o salário inicial, o salário com o aumento e o salário final.*/
namespace listaExercicio16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o salário do funcionário: R$ ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.15;
            double salarioAumentado = salario + aumento;
            double imposto = salarioAumentado * 0.08;
            double salarioFinal = salarioAumentado - imposto;

            Console.WriteLine($"\nSalário inicial: R$ {salario:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {salarioAumentado:F2}");
            Console.WriteLine($"Salário final com desconto de imposto de 8%: R$ {salarioFinal:F2}");

            Console.WriteLine();
            //OUTRO TIPO DE FORMATAÇÃO

            Console.WriteLine("O salário inicial é " + String.Format("{0:C}", salario) + "\n" + 
                "o aumento é de " + String.Format("{0:C}", salarioAumentado) + "\n" +
                "o valor do salario com desconto de 8% é" + String.Format("{0:C}", salarioFinal));
            Console.ReadKey();
        }
    }
}