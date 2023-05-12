namespace exercicioguiado
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        // propriedades
        public string Cnpj { get; set; } = "";

        public bool ValidarCnpj(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}