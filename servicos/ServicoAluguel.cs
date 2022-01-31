using System;

namespace SolucaoSemInterface.Entidades.servicos
{
    internal class ServicoAluguel
    {

        public double precoPorHora { get; private set; }
        public double precoPorDia { get; private set; }

        private ITaxaService taxaServico;
        public ServicoAluguel(double precoPorHora, double precoPorDia, ITaxaService taxaServico)
        {
            this.precoPorHora = precoPorHora;
            this.precoPorDia = precoPorDia;
            this.taxaServico = taxaServico;
        }

        public void processarFatura(CarroAlugado carroAlugado)
        {
            TimeSpan duracao = carroAlugado.dataRetornoAluguel.Subtract(carroAlugado.dataAluguel);

            double pagamento = 0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamento = precoPorHora * Math.Ceiling(duracao.TotalHours);
            }else
            {
                pagamento = precoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = taxaServico.taxa(pagamento);

            carroAlugado.fatura = new Fatura(pagamento, taxa);
        }
    }
}
