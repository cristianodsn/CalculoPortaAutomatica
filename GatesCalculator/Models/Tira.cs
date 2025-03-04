namespace GatesCalculator.Models
{
    public class Tira
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
