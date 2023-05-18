using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Produto
    {
        public int Código { get; set; }
        public int NomeProduto { get; set; }
        public int Preco { get; set; }
        public int DataCadastro { get; set; }
        public Marca Marca { get; set; } 

        public Usuário CadastradoPor { get; set; }


        List<Produto> listaProdutos = new List<Produto>();

        public void Cadastrar()
        {
            // logica

            Console.WriteLine($"Digite o nome do produto a ser cadastrado:");
            string NomeProduto = Console.ReadLine()!;
            Console.WriteLine($"Agora escreva o código do produto:");
            string Código = Console.ReadLine()!;
            
        }

        public void Listar()
        {

        }

        public void Deletar()
        {

        }


    }
}