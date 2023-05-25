using INTRODUCAO_MVC.Model;
using INTRODUCAO_MVC.View;

namespace INTRODUCAO_MVC.Controller
{
    public class ProdutoController
    {
        // instancia das classes produto e produtoView
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        // metodos controladores para acessar a listagem de produtos
        public void CadastrarProdutos()
        {
            produto.Inserir(produtoView.Cadastrar());
        }
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }


    }
}
