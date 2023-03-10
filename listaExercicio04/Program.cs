/*4. Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível */
namespace listaExercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r ____ ____ ____");
            Console.ReadLine();

            Console.WriteLine("Qual a kilometragem inicial ");

            String strKmini = Console.ReadLine();

            double kmini = Convert.ToDouble(strKmini);

            Console.WriteLine("Qual a kilometragem final ");

            String strKmfim = Console.ReadLine();

            double kmfim = Convert.ToDouble(strKmfim);

            Console.WriteLine("Digite o valor de combustivel inicial ");

            String strIniCombustivel = Console.ReadLine();

            double iniCombustivel = Convert.ToDouble(strIniCombustivel);

            Console.WriteLine("Digite o valor de combustivel final ");

            String strFimCombustivel = Console.ReadLine();

            double fimCombustivel = Convert.ToDouble(strFimCombustivel);

            double distancia = kmfim - kmini;
            double consumo = fimCombustivel - iniCombustivel;
            double consumoPorKm = distancia / consumo;
            
            Console.WriteLine("A distancia percorida foi de " + distancia + " e o consumo de gasolina por km foi de " +  consumoPorKm);
        }
    }
}