namespace projeto
{
    public class Login
    {
        // atributos

        public bool Logado { get; set; }


        //  método construtor login
        public Login()
        {
            Usuario user = new Usuario();
            string opcao;

            do
            {
                Console.WriteLine(@$"
                =====================================
                BEM VINDO AO NOSSO MENU! <3
                =====================================
                [1]-Cadastrar novo usuário
                [2]-Logar com um usuário já existênte

                [0]-Sair
                ======================================
                ");

                opcao = Console.ReadLine()!;


                switch (opcao)
                {
                    case "1":
                        user.Cadastrar(user);
                        break;
                    case "2":
                        Logar(user);
                        break;
                    case "0":
                        Console.WriteLine($"Saindo...");
                        break;
                    default:
                        Console.WriteLine($"opcao invalida :(");
                        break;
                }
                // Logar(user);

                if (this.Logado == true)
                {
                    GerarMenu();
                }
            } while (opcao != "0");

        }

        // metodo construtor logar
        public void Logar(Usuario usuario)
        {

            Console.WriteLine($"Vamos efetuar seu login! Primeiramente informe o seu e-mail de cadastro:");
            string email = Console.ReadLine()!;

            Console.WriteLine($"Por favor agora informe a sua senha:");
            string senha = Console.ReadLine()!;

            if (usuario.UsuarioExiste(usuario))
            {
                this.Logado = true;
                Console.WriteLine($"Login concluido! :) ");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar ! :( ");

            }

        }

        public void Deslogar() => Logado = false;

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

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

                    // case "3":
                    //     Console.WriteLine($"Informe o código a ser excluido:");
                    //     int código = int.Parse(Console.ReadLine()!);

                    //     produto.Deletar();
                    //     break;

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
                        Console.WriteLine($"Saindo...");
                        break;

                    default:
                        Console.WriteLine($"opcao inválida!");
                        break;
                }
            } while (opcao != "0");


        }
    }
}