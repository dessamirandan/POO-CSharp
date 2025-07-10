using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDois
{
    public class Produto
    {
        //atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor - Impede que nao seja atribuidos valores aos atributos
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Método que retorna valor double
        public double ValorToralEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Método que nao retorna valor = void
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //Método muda comportamento de um metodo override
        public override string ToString()
        {
            return Nome
            + ", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: R$"
            + ValorToralEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}