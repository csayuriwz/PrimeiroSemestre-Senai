namespace projeto
{
    public class Login
    {
        // atributos

        public bool Logado { get; set; }


        //  métodos
        public Login()
        {
            Usuário user = new Usuário();

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuário usuario)
        {
            Console.WriteLine($"Informe o e-mail:");
            string email = Console.ReadLine()!;

            Console.WriteLine($"Informe a senha:");
            string senha = Console.ReadLine()!;

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login concluido! :) ");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Flha ao logar ! :( ");

            }

        }

        public void Deslogar()
        {

        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            do
            {
                Console.WriteLine(@$"

            =============================
            BEM VINDO AO NOSSO MENU! <3
            
            [1] Cadastrar Produto
            [2] Listar Produtos
            [3] Remover Produto
            -----------------------------
            [4] Cadastrar Marcas
            [5] Listar Marcas
            [6] Remover Marca
            ============================
            [0] Sair
            
            ");

             opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Informe o código a ser excluido:");
                        int código = int.Parse(Console.ReadLine()!);

                        produto.Deletar();
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o código da marca a ser excluida:");
                        int code = int.Parse(Console.ReadLine()!);

                        marca.Deletar();
                        break;

                    case "0":


                    default:
                }
            } while (opcao != 0);


        }
    }
}