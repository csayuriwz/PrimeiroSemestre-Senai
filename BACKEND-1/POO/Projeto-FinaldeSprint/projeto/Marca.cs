using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto
{
    public class Marca
    {
        // atributos-propriedades

        public int Código { get; set; }
        public string NomeMarca { get; set; } = "";
        public DateTime DataCadastro { get; set; }


        List<Marca> listaMarcas = new List<Marca>();

        // Métodos

        public void Listar()
        {

        }
        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            return: novaMarca;
            // logiv]ca
        }
        public void Deletar(int codigo)
        {
        }




    }
}