namespace projeto
{
    public class Produto
    {
        public int Código { get; set; }
        public int NomeProduto { get; set; }
        public int Preco { get; set; }
        public int DataCadastro { get; set; }
        public Marca Marca { get; set; } 

        public Usuario CadastradoPor { get; set; }


        List<Produto> produtos = new List<Produto>();

        public void Cadastrar()
        {
            // logica

            Console.WriteLine($"Digite o nome do produto a ser cadastrado:");
            string NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Digite o preco do produto a ser cadastrado:");
            string Preco = Console.ReadLine()!;
            
            Console.WriteLine($"Agora escreva o código do produto:");
            string Código = Console.ReadLine()!;

            Console.WriteLine($"Digite a marca do produto a ser cadastrado:");
            string Marca = Console.ReadLine()!;
            
        }

       public void Listar()
        {
            if(produtos.Count > 0)
            {
                foreach (var item in produtos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
                    ============================================
                    Código: {item.Código}
                    Nome do Produto: {item.NomeProduto}
                    Preço do produto: {item.Preco}
                    Data do cadastro: {item.DataCadastro}
                    ============================================
                    ");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine($"NENHUM PRODUTO CADASTRADO.");
            }
        }

        public void Deletar(int codigo)
        {
            Console.WriteLine($"Qual código do produto você deseja excluir?");
            codigo = int.Parse(Console.ReadLine()!);
            Produto produto = produtos.Find (x => x.Código == codigo);
            produtos.Remove(produto);

            Console.WriteLine($"PRODUTO EXCLUIDO COM ÉXITO!");
            
        }
    }
}