//Faça um programa que leia e valide as seguintes informações:

// 3. Salário: maior que zero;

Console.WriteLine($"Qual o seu salário?");
float salario = float.Parse (Console.ReadLine()!);

while (salario < 0)
{
    Console.WriteLine($"Salário inválido! Digite novamente.");
    salario = float.Parse(Console.ReadLine()!); 
    
}

Console.WriteLine($"Certo! Seu sálario é: {salario}");





