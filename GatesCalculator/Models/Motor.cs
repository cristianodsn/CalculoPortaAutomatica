namespace GatesCalculator.Models
{
    public class Motor
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public double Peso { get; set; }
    }
}
