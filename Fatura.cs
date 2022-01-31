using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoSemInterface.Entidades
{
    internal class Fatura
    {
        public double pagamento { get; set; }

        public double taxa { get; set; }

        public Fatura(double pagamento, double taxa)
        {
            this.pagamento = pagamento;
            this.taxa = taxa;
        }

        public double pagamentoTotal()
        {
             return pagamento + taxa; 
        }

        public override string ToString()
        {
            return "Pagamento: "
                + pagamento.ToString("F2")
                + " Taxa: " + taxa.ToString("F2")
                + " pagamento total foi: " + pagamentoTotal();
        }
    }
}
