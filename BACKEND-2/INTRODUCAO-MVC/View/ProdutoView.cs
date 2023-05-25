using INTRODUCAO_MVC.Model;

namespace INTRODUCAO_MVC.View
{
    public class ProdutoView
    {
        // me'todo para exibir os dados da lista no console

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}\n");

            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome do produto");
            novoProduto.Nome = (Console.ReadLine()!);

            Console.WriteLine($"Digite o preco do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;

        }
    }
}
