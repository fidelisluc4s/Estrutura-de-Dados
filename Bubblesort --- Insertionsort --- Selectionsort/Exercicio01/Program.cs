using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[]
        {
            new Produto{Codigo = 3, Descricao = "Produto C", Preco = 10.0 },
            new Produto{Codigo = 1, Descricao = "Produto A", Preco = 5.0 },
            new Produto{Codigo = 2, Descricao = "Produto B", Preco = 7.0 }
        };

        OrdenarPorCodigo(produtos);

        foreach(Produto produto in produtos)
        {
            System.Console.WriteLine($"Código: {produto.Codigo}, Descrição: {produto.Descricao}, Preço: {produto.Preco}");
        }
    }
    static void OrdenarPorCodigo(Produto[] produtos)
    {
        for(int i = 1; i < produtos.Length; i++)
        {
            Produto produtoAtual = produtos[i];
            int j = i -1;

            while (j >= 0 && produtos[j].Codigo > produtoAtual.Codigo)
            {
                produtos[j + 1] = produtos[j];
                j--;
            }
            produtos[j+1] = produtoAtual;
        }
    }
}