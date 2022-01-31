namespace SolucaoSemInterface.Entidades.servicos
{
    internal class TaxaServico : ITaxaService
    {
        public double taxa(double taxa)
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
