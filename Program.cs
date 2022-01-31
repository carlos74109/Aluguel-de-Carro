using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using SolucaoSemInterface.Entidades;
using SolucaoSemInterface.Entidades.servicos;

namespace SolucaoSemInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modelo do carro: ");
            string modeloCarro = Console.ReadLine();


            Console.WriteLine("Entre com a data do aluguel(DD/MM/YYYY HH:mm): ");
            DateTime dataAluguel = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a data de devolução do carro(DD/MM/YYYY HH:mm): ");
            DateTime dataRetornoAluguel = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Preco por hora: ");
            double hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Preco por dia: ");
            double dia = double.Parse(Console.ReadLine());  

            CarroAlugado carroAlugado = new CarroAlugado(dataAluguel, dataRetornoAluguel, new Veiculo(modeloCarro));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia);

            servicoAluguel.processarFatura(carroAlugado);

            Console.WriteLine("Fatura:");
            Console.WriteLine(carroAlugado.fatura);
        }
    }
}
