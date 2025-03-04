namespace GatesCalculator.Models
{
    public class QuantidadeEmEstoque
    {
        public int Id { get; set; }
        public int CdProduto { get; set; }
        public double QtEstoque { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
