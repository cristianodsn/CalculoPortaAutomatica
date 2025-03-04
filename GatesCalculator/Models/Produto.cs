using GatesCalculator.Models.Interfaces;
using GatesCalculator.Models.StaticClasses;
using GatesCalculator.Models.Enums;

namespace GatesCalculator.Models
{
    public class Produto : IFormatoDeVenda
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public FormatoDeVenda FormatoDeVenda { get; set; }
        public double QuantidadeEstoque;
        public QuantidadeEmEstoque QuantidadeEmEstoque { get; set; }
        private decimal _quantidade;

        public decimal Quantidade
        {
            get => _quantidade;
            set
            {
                ValidadorDeQuantidade.ValidarQuantidade(value, FormatoDeVenda);
                _quantidade = value;
            }
        }

        public Produto() { }
       
        public decimal Total()
        {
            return _quantidade * Preco;
        }
    }
}
