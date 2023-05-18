using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Usuário
    {
        public int Código { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }


        public void Cadastrar()
        {

            Console.WriteLine(@$"
            BEM VINDO AO NOSSO PROGRAMA! <3
    	    =================================
            [1]-Cadastrar Perfil
            [2]-Entrar com um Login existênte

            [0]- sair
            =================================
             ");

            Console.WriteLine($"Digite seu nome:");
            Nome = Console.ReadLine()!;

            Console.WriteLine($"Digite sua senha:");
            Senha = Console.ReadLine()!;

            Console.WriteLine($"Informe o e-mail:");
            Email = Console.ReadLine()!;

        }

        public void Deletar()
        {
            this.Nome = "Carlos";
            this.Email = "Carlos";
            this.Senha = "13";
            this.DataCadastro = DateTime.Parse("0000-00-00--000T00:00:00");
        }
    }

}