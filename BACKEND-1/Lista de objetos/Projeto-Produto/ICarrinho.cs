using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public interface ICarrinho
    {
        // regras do carrinho
        // métodos aqui serao apenas declarados

        // CRUD: created, read, update e delete

        // padrao de chaada de método
        // tipo Nome (parametros)

        // create

        // adicionamos um produto da classe produto.
        void Adicionar(Produto _produto);

        // Read
        void Listar() ;

        // Update(atalizar)
        void Atualizar(int _codigo, Produto _novoproduto);


        // Delete
        // removemoss um produto da classe produto.
        void Remover(Produto _produto);
    }
}