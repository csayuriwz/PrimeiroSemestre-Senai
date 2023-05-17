using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Produto
    {
        public int Códigp { get; set; }
        public int NomeProduto { get; set; }
        public int Preco { get; set; }
        public int DataCadastro { get; set; }
        public Marca Marca { get; set; }

        public Usuário CadastradoPor{ get; set; }


        List<Produto> listaProdutos = new List<Produto>();

        public void  Cadastrar(){
            // logica
        }

        public void Listar(){

        }

        public void Deletar(int Código){

        }

        
    }
} 