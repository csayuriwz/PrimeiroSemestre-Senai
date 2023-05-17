using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Usuário
    {
        public int Código { get; set; }
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Senha { get; set; } = "";
        public DateTime DataCadastro { get; set; }


        public void Cadastrar()
        {
            this.Nome = "Carlos";
            this.Email = "Carlos@gmail.com";
            this.Senha = "12";
            this.DataCadastro = DateTime.Now;
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