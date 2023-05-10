namespace exercicio_lista
{
    public class Carro
    {
        // propriedades

       public string Marca { get; set; }
       public string Cor { get; set; }


        // métodos 

        // vazio
        public Carro()
        {
            
        }

        // completo
        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor =  cor;
        }

    }
}