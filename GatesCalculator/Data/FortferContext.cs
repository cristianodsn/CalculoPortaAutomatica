using GatesCalculator.Models;
using GatesCalculator.Models.StaticClasses;
using Microsoft.EntityFrameworkCore;

namespace GatesCalculator.Data
{
    public class FortferContext : DbContext
    {
        public FortferContext(DbContextOptions<FortferContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<QuantidadeEmEstoque> QuantidadeEmEstoques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento da tabela "produto" para a entidade Produto
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos"); // Nome da tabela existente no banco Fortfer

                // Mapeamento das colunas
                entity.HasKey(e => e.Id); // Chave primária
                entity.Property(e => e.Id).HasColumnName("cd_produto");
                entity.Property(e => e.Nome).HasColumnName("no_produto");
                entity.Property(e => e.Preco).HasColumnName("vl_a_vista");

                // Ignorando as propriedades que não vêm do baco fortfer
                entity.Ignore(p => p.FormatoDeVenda);
                entity.Ignore(p => p.Quantidade);
                entity.Ignore(p => p.QuantidadeEstoque);

                // Relacionamento com estoque_saldo_deposito
                entity.HasOne(p => p.QuantidadeEmEstoque)
                    .WithOne(q => q.Produto)
                    .HasForeignKey<QuantidadeEmEstoque>(q => q.CdProduto)
                    .IsRequired(false);
            });

            modelBuilder.Entity<QuantidadeEmEstoque>(entity =>
            {
                entity.ToTable("estoque_saldo_deposito");
                entity.HasKey(q => q.CdProduto);
                entity.Property(q => q.CdProduto).HasColumnName("cd_produto");
                entity.Property(q => q.QtEstoque).HasColumnName("qt_saldo_produto").HasColumnType("numeric");
            });
        }
    }
}
