namespace GatesCalculator.Models
{
    public class QuantidadeEmEstoque
    {
        public int CdProduto { get; set; }
        public double QtEstoque { get; set; }

        public Produto Produto { get; set; }
    }
}
