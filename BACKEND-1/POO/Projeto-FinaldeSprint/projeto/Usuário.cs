namespace projeto
{
    public class Usuario
    {
        public int Código { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;



        public List<Usuario> ListaDeUsuarios { get; set; } = new List<Usuario>();
        public void Cadastrar(Usuario users
        )
        {
            Console.WriteLine(@$" 
            
            Vamos cadastrar seu usuário!
            Primeiramente por favor digite o seu nome:");
            users.Nome = Console.ReadLine()!;

            Console.WriteLine($"Agora digite o seu email:");
            users.Email = Console.ReadLine()!;

            Console.WriteLine($"Digite a sua senha:");
            users.Senha = Console.ReadLine()!;

            Console.WriteLine($"Por último, digite um código para atribuirmos ao seu usuário:");
            users.Código = int.Parse(Console.ReadLine()!);


            ListaDeUsuarios.Add(users);
        }

        public void Deletar(int codigo)
        {
            Console.WriteLine($"Digite qual usuário você deseja excluir?");
            codigo = int.Parse(Console.ReadLine()!);
            Usuario users = ListaDeUsuarios.Find(x => x.Código == codigo);
            ListaDeUsuarios.Remove(users);

            Console.WriteLine($"O usuário foi excluido! :( ");



        }

        public bool UsuarioExiste(Usuario usuario)
        {
            bool usuarioExiste = false;
            if (ListaDeUsuarios.Any())
            {
                foreach (Usuario item in ListaDeUsuarios)
                {
                    if (item.Email == usuario.Email && item.Senha == usuario.Senha)
                    {
                        usuarioExiste = true;
                    }
                    else
                    {
                        Console.WriteLine($"email lista: {item.Email}  |  senha lista: {item.Senha}");
                        Console.WriteLine($"email: {usuario.Email}  |  senha: {usuario.Senha}");
                    }

                }
            }
            else
            {
                Console.WriteLine($"opcao invalida");
            }
            return usuarioExiste;
        }
    }

}