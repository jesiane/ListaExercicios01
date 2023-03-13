/*13. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
quantidades de pães e de broas, e depois calcular os dados solicitados.*/
namespace listaExercicio13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(" --- Padaria HotPão --- \n");

            Console.Write("Digite a quantidade de pães vendidos: ");
            int qtdPaes = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");
            int qtdBroas = int.Parse(Console.ReadLine());

            double valorPao = 0.12;
            double valorBroa = 1.5;

            double totalPao = qtdPaes * valorPao;
            double totalBroa = qtdBroas * valorBroa;

            double arrecadacaoTotal = totalPao + totalBroa;
            double poupanca = arrecadacaoTotal * 0.1;

            Console.WriteLine($"\nA arrecadação total foi de R$ {arrecadacaoTotal:F2}.");
            Console.WriteLine($"O valor a ser guardado na poupança é de R$ {poupanca:F2}.");

            Console.WriteLine();

            Console.WriteLine("\r A arrecadação total foi de " + String.Format("{0:C}", arrecadacaoTotal) + "\n" +
                "e o valor a ser guardado na poupança é de " + String.Format("{0:C}", poupanca));
            Console.ReadKey();
        }
    }
}