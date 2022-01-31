using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoSemInterface.Entidades
{
    internal class CarroAlugado
    {
        public DateTime start { get; set; }
        public DateTime finish { get; set; }
        public Veiculo veiculo { get; set; }

        public Fatura fatura { get; set; }

        public CarroAlugado(DateTime start, DateTime finish, Veiculo veiculo)
        {
            this.start = start;
            this.finish = finish;
            this.veiculo = veiculo;
        }
    }
}
