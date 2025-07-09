using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioDois
{
  public class Program
  {
    static void Main(string[] args)
    {
      Produto ItemA = new Produto();

      Console.Write("Digite o nome do produto a ser adicionado: ");
      ItemA.Nome = Console.ReadLine();
      Console.Write("Digite o preço do produto: ");
      ItemA.Preco = double.Parse(Console.ReadLine());
      Console.Write("Digite a quantidade do produto: ");
      ItemA.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine("------");
      Console.WriteLine("Dados do produto: " + ItemA);
      Console.WriteLine("------");

      Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
      int quantidadeAdicional = int.Parse(Console.ReadLine());
      ItemA.AdicionarProdutos(quantidadeAdicional);

      Console.WriteLine("------");
      Console.WriteLine("Dados atualizados: " + ItemA);
      Console.WriteLine("------");

      Console.Write("Digite o número de produtos a ser removido no estoque: ");
      int quantidadeRemovida = int.Parse(Console.ReadLine());
      ItemA.RemoverProdutos(quantidadeRemovida);

      Console.WriteLine("------");
      Console.WriteLine("Dados atualizados: " + ItemA);
      Console.WriteLine("------");
    }
  }
}