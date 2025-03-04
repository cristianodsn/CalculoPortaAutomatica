namespace GatesCalculator.Models
{
    public class Soleira
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
