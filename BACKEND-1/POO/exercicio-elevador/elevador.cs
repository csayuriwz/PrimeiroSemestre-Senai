namespace exercicio_elevador
{
    public class Elevador
    {
        public int Capacidade { get; set; }
        public int Andar { get; set; }
        public int PosicaoAndar { get; set; }

        // criar métodos

        public void Inicializa(int capacidade, int andar)
        {
            Console.WriteLine($"A capacidade do elevador é de {capacidade} pessoas por vez, e o elevador tem {andar} andares");
        }

        public void Entrar()
        {
              if (Andar)
              {
                
              }
        }
        public void Sair()
        {

        }
        public void Subir()
        {

        }
        public void Descer()
        {

        }
    }

}