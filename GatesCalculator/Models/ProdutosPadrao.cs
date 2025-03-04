namespace GatesCalculator.Models
{
    public class ProdutosPadrao
    {
        public int Id { get; set; }
        public int TiraId { get; set; }
        public Tira Tira { get; set; }
        public int SoleiraId { get; set; }
        public Soleira Soleira { get; set; }
        public int TuboEixoId { get; set; }
        public TuboEixo TuboEixo { get; set; }
        public int GuiaPortaAcoId { get; set; }
        public GuiaPortaDeAco GuiaPortaDeAco { get; set; }
        public ICollection<ProdutoGenerico> ProdutoGenericos { get; set; } = new List<ProdutoGenerico>();

    }
}
