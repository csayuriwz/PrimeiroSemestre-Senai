//Faça um programa que leia e valide as seguintes informações:
// 2. Idade: entre 0 e 100 anos;


Console.WriteLine($"Qual sua idade?");
int idade = int.Parse (Console.ReadLine()!);

while (idade < 1 || idade > 99)
{
    Console.WriteLine($"Idade negada! Digite uma idade valida.");
    idade = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Sua idade é válida! cadastro realizado.");
