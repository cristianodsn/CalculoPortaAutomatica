using GatesCalculator.Models.Enums;

namespace GatesCalculator.Models.StaticClasses
{
    public static class ValidadorDeQuantidade
    {
        public static void ValidarQuantidade(decimal quantidade, FormatoDeVenda formatoDeVenda)
        {
            switch (formatoDeVenda)
            {
                case FormatoDeVenda.ItemNaoFracionado:
                    if (quantidade % 1 != 0)
                        throw new ArgumentException("Itens não fracionados devem ter uma quantidade inteira");
                    break;

                case FormatoDeVenda.ItemBarra:
                    if (quantidade != 6 && quantidade != 3)
                        throw new ArgumentException("Barras só podem ser vendidas com 3 ou 6 metros.");
                    break;

                case FormatoDeVenda.ItemFracionado:
                    break;

                default:
                    throw new ArgumentException("Formato de venda inválido.");


            }
        }
    }
}
