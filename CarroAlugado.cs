using System;

namespace SolucaoSemInterface.Entidades
{
    internal class CarroAlugado
    {
        public DateTime dataAluguel { get; set; }
        public DateTime dataRetornoAluguel { get; set; }
        public Veiculo veiculo { get; set; }

        public Fatura fatura { get; set; }

        public CarroAlugado(DateTime dataAluguel, DateTime dataRetornoAluguel, Veiculo veiculo)
        {
            this.dataAluguel = dataAluguel;
            this.dataRetornoAluguel = dataRetornoAluguel;
            this.veiculo = veiculo;
        }
    }
}
