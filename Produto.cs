using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque_POO
{
    class Produto
    {
       public string Nome;
       public double Preco;
       public int Quantidade;

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void InserirProduto (int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return (Nome + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                ", Quantidade: " + Quantidade + 
                ", Valor total em Estoque: " + ValorEmEstoque());
        }
    }
}
