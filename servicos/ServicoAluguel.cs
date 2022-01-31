using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoSemInterface.Entidades.servicos
{
    internal class ServicoAluguel
    {

        public double precoPorHora { get; private set; }
        public double precoPorDia { get; private set; }

        private TaxaServico taxaServico = new TaxaServico();
        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            this.precoPorHora = precoPorHora;
            this.precoPorDia = precoPorDia;
        }

        public void processarFatura(CarroAlugado carroAlugado)
        {
            TimeSpan duracao = carroAlugado.finish.Subtract(carroAlugado.start);

            double pagamento = 0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamento = precoPorHora * Math.Ceiling(duracao.TotalHours);
            }else
            {
                pagamento = precoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = taxaServico.Taxa(pagamento);

            carroAlugado.fatura = new Fatura(pagamento, taxa);
        }
    }
}
