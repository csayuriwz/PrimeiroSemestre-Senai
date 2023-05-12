namespace exercicioguiado
{
    public class ContatoPessoal : Contato, IContatoPessoal 
    {
        // propriedades
        public string Cpf { get; set; } = "";

        public bool ValidarCPF(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}