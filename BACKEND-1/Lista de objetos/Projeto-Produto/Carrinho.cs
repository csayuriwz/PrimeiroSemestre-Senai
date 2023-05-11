using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public class Carrinho : ICarrinho
    {
        // propriedades

        public float Valor { get; set; }


        // criar uma lista de objetos para manipular os produtos.

        List<Produto> carrinho = new List<Produto>();



        // métodos

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
           carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
           carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {


                    Console.WriteLine(@$"
                    -------------------
                    Código: {p.Codigo}
                    Nome: {p.Nome}
                    Preco: {p.Preco:C}
                    ------------------
                    ");


                }
            }
            else
            {
                Console.WriteLine($"O carrinho está vazio :( ");

            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"O total do seu carrinho é de: {Valor:C}");

            }
            else
            {
                Console.WriteLine($"Carrinho vazio! :( ");

            }

        }

      
    }
}