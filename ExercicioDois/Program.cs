using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace ExercicioDois
{
  public class Program
  {
    static void Main(string[] args)
    {

      Console.Write("Digite o nome do produto a ser adicionado: ");
      string nome = Console.ReadLine();
      Console.Write("Digite o preço do produto: ");
      double preco = double.Parse(Console.ReadLine());
      Console.Write("Digite a quantidade do produto: ");
      int quatidade = int.Parse(Console.ReadLine());

      Produto ItemA = new Produto("TV", 500.00, 10);


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