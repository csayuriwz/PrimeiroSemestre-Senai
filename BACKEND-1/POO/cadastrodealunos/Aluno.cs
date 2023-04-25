namespace ProjetoAlunos
{
    public class Aluno
    {

        //definir os atributos (comportamentos ou propriedades)

        public string Nome = "";
        public string Curso = "";
        public int Idade;
        public string Rg = "";
        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensalidade;

        //DEFINIR OS METODOS

        public void VerMediaFinal()
        {
            Console.WriteLine($"A média final do aluno {Nome} é de: {MediaFinal}");

        }
        public void VerMensalidade()
        {
            if (Bolsista == true && MediaFinal >= 8)
            {
                Console.WriteLine($"O aluno(a) {Nome}, tem uma mesalidade de: R${ValorMensalidade * 0.5} ");
            }

            else if (Bolsista == true && MediaFinal > 6)
            {
                Console.WriteLine($"O aluno(a) {Nome} tem uma mesalidade de: R${ValorMensalidade * 0.7} ");
            }

            else
            {
                Console.WriteLine($"O aluno(a) {Nome}, tem uma mesalidade de: R${ValorMensalidade} ");
            }
        }

    }
}