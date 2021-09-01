using System;
using System.Globalization;

namespace Estoque_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Digite o nome do produto: ");
            p.Nome = (Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade do produto em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados dos produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.InserirProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos para ser removida: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:  " + p );


        }
    }
}
