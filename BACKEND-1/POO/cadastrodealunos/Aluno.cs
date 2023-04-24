
namespace cadastrodealunos
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int rg;
        public bool bolsista;
        public float mediafinal;
        public float mensalidade;

          public void VerMediaFinal()
        {
            Console.WriteLine($"A media final é {mediafinal}");
            
        }
        public void VerMensalidade()
        {
            Console.WriteLine($"A mensalidade total é {mensalidade}");
            
        }
        
    }
}