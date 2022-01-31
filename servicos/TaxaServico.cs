using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoSemInterface.Entidades.servicos
{
    internal class TaxaServico
    {
        public double Taxa(double taxa)
        {
            if(taxa <= 100)
            {
                return taxa * 0.2;
            }else
            {
                return taxa * 0.15;
            }
        }
    }
}
