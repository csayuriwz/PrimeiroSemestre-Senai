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
    }
}