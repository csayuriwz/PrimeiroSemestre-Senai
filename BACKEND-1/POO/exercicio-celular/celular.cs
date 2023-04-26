namespace exercicio_celular
{
    public class celular
    {
        // definir os atributos

        public string Cor = "";
        public string Modelo = "";
        public string Tamanho = "";
        public bool Ligado;

        // definir os metodos

        public void Ligar()
        {
            Ligado = true;
            Console.WriteLine($"Ligando...");

        }
        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine($"Desligando...");

        }
        public void FazerLigacao()
        {
            Console.WriteLine($"Para quem você quer ligar");
            string contato = Console.ReadLine()!;

            Console.WriteLine($" Vc está ligando para {contato}");

        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"Pra quem você deseja enviar uma mensagem?");
            string contato = Console.ReadLine()!;

            Console.WriteLine($"Você esta enviando essa mensagem para {contato}!");

        }

    }
}