namespace INTRODUCAO_MVC.Model
{
    public class Produto
    {
        // propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasra e do arquivo csv

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            // criar a lógica para gerar a pasta e o arquivo

            // obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //  verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // verificar se no caminho j;a existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        // método para ler os dados do arquivo csv
        public List<Produto> Ler()
        {

            // instancia da lista de produtos
            List<Produto> produtos = new List<Produto>();
            // array de strings armazenando todas as linhas do csv

            string[] linhas = File.ReadAllLines(PATH);


            // leitura das linhas
            foreach (var item in linhas)
            {
                // separacao de atributos de cada linha
                string[] atributos = item.Split(";");

                // instancia de produtos
                Produto p = new Produto();

                // atribuicao de valores
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                // adiciona objeto dentro da lista
                produtos.Add(p);

            }
            // retorna a lista de produtos
            return produtos;

        }

        
        // método para preparar as linhas as erem inseridas no csv

        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = { PrepararLinhasCSV(p) };

            File.AppendAllLines(PATH, linhas);
        }
    }

}


