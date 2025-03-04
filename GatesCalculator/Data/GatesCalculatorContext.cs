using GatesCalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace GatesCalculator.Data
{
    public class GatesCalculatorContext : DbContext
    {
        public GatesCalculatorContext(DbContextOptions<GatesCalculatorContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<GuiaPortaDeAco> GuiasPortaDeAco { get; set; }
        public DbSet<Motor> Motores { get; set; }
        public DbSet<MotorTesteira> MotoresTesteiras { get; set; }
        public DbSet<Soleira> Soleiras { get; set; }
        public DbSet<Testeira> Testeiras { get; set; }
        public DbSet<Tira> Tiras { get; set; }
        public DbSet<TuboEixo> TuboEixo { get; set; }
        public DbSet<ProdutoGenerico> produtoGenericos { get; set; }
        public DbSet<ProdutosPadrao> ProdutosPadrao {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Ignore(p => p.QuantidadeEmEstoque);
            });

            modelBuilder.Entity<ProdutosPadrao>()
                .HasOne(p => p.Soleira)
                .WithMany()
                .HasForeignKey(p => p.SoleiraId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProdutosPadrao>()
                .HasOne(p => p.GuiaPortaDeAco)
                .WithMany()
                .HasForeignKey(p => p.GuiaPortaAcoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProdutosPadrao>()
                .HasOne(p => p.Tira)
                .WithMany()
                .HasForeignKey(p => p.TiraId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProdutosPadrao>()
                .HasOne(p => p.TuboEixo)
                .WithMany()
                .HasForeignKey(p => p.TuboEixoId)
                .OnDelete(DeleteBehavior.Restrict);

            
        }

    }
}
