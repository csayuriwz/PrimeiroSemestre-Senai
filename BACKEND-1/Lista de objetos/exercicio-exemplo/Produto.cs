namespace exercicio_exemplo
{
    public class Produto
    {
        // propriedades
        public int Código { get; set; }
        public string Nome { get; set; } = "";
        public float Preço { get; set; }

        // métodos

        public Produto()
        {
            
        }
        public Produto(int codigo, string nome, float preco)
        {
            Código = codigo;
            Nome = nome;
            Preço = preco;
            
        }
    }
}