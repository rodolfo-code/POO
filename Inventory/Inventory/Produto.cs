using System;
using System.Globalization;

namespace Inventory
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + ", unidades, Total: R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
