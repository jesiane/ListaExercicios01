//3. Crie um programa para calcular o volume de um Cilindro
namespace listaExercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do cilindro");

            string strRaio = Console.ReadLine();

            double raio = Convert.ToDouble(strRaio);

            Console.WriteLine("Digite a altura do cilindro");

            string strAltura = Console.ReadLine();
           
            double altura = Convert.ToDouble(strAltura);

            double volume = Math.PI * raio * raio * altura;
            Console.WriteLine("\r O valor do volume: " + volume);
            Console.ReadLine();
        }
    }
}