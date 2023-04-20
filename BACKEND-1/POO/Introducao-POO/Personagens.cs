
namespace Introducao_POO
{
    public class Personagem
    {
        // atrinutos
        //  nome,idade,armadura,ia

        public string nome;

        public int idade;

        public string armadura;

        public string ia;

        // metodos
        // atacar,defender,restaurar armadura

        public void atacar()
        {
            Console.WriteLine($"O Personagem Atacou!!!");
            
        }

        public void defender()
        {
            Console.WriteLine($"O Personagem Defendeu!!!");
            
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O Personagem Consegiu Restaurar Sua Armadura!!!");
            
        }
    }
}