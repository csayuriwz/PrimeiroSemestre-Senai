namespace calculadora
{
    public class Operador
    {
        public float num1;
        public float num2;

        public void Somar()
        {
            Console.WriteLine($"O resultado da soma é: {num1 + num2}"); 
        }
        public void Subtrair()
        {
            Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
        }
        public void Multiplicar()
        {
            Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
        }
        public void Dividir()
        {
            Console.WriteLine($"O resultado da divisao é: {num1 / num2}");
        }
    }
}