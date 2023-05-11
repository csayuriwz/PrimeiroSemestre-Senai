using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto
{
    public class Produto
    {
        // propriedades/atributos
        public int Codigo { get; set; }
        public string Nome { get; set; } = "";
        public float Preco { get; set; }


        // métodos

        // construtor vazio
        public Produto()
        {
            
        }

        // construtor completo
        public Produto(int _codigo, string _nome, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
    }
}