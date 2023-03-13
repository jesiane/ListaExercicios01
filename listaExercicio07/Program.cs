/*7. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas.A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/
namespace listaExercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, comissao, salariofinal;
            Console.WriteLine("Salario Funcionario");
            Console.ReadLine();

            Console.WriteLine("Nome funcionario ");
            string nomeFunc = Console.ReadLine();
            Console.WriteLine("Salario base ");
            salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de vendas");
            double totalVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentual de vendas");
            double percentVendas = double.Parse(Console.ReadLine());

            comissao = totalVendas* percentVendas;
            salariofinal = comissao + salarioBase;

            Console.WriteLine("O funcionario " + nomeFunc + " teve um total de " + totalVendas + " vendas, recebendo de comissão o valor de R$ " +
                + comissao +" tendo o salario total de vendedor no valor de " + salariofinal);

            //Outra formatação
            
            Console.WriteLine($"O funcionario {nomeFunc} teve um total de {totalVendas} vendas, recebendo de comissão o valor de R$ {comissao} tendo o salario total de vendedor no valor de {salariofinal}.");
            


        }
    }
}
