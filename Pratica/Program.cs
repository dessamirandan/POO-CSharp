﻿using System;
using Curso;

namespace Exercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p1 = new Pessoa();
      Pessoa p2 = new Pessoa();

      Console.WriteLine("Dados da primeira pessoa:");
      Console.Write("Nome: ");
      p1.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      p1.Idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Dados da segunda pessoa:");
      Console.Write("Nome: ");
      p2.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      p2.Idade = int.Parse(Console.ReadLine());

      if (p1.Idade > p2.Idade)
      {
        Console.WriteLine("Pessoa mais velha: " + p1.Nome);
      }
      else if (p2.Idade > p1.Idade)
      {
        Console.WriteLine("Pessoa mais velha: " + p2.Nome);
      }
      else
      {
        Console.WriteLine($" {p1.Nome} e {p2.Nome} possuem a mesma idade.");
      }
    }
  }
}