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

             Console.WriteLine($"Digite o nome da marca que você deseja cadastrar:");
            NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Digite o código da marca que você deseja cadastrar:");
            Código = int.Parse(Console.ReadLine())!;

           

        }
        public void Deletar()
        {
            Console.WriteLine($"Digite o código da marca que você deseja deletar:");
            
            

        }




    }
}