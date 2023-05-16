namespace projeto
{
    // propriedades

    public int Código { get; set; }
    public string NomeProduto { get; set; }
    public float Preco { get; set; }
    public DateTime DataCadastro { get; set; }

    public Marca : Marca { get; set; }

    List<ListaDeProdutos> Produtos = new List<ListaDeProdutos>();
}