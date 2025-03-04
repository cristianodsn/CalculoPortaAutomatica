namespace GatesCalculator.Models
{
    public class ProdutoGenerico
    {
        public int Id { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
