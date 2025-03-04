namespace GatesCalculator.Models
{
    public class GuiaPortaDeAco
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
