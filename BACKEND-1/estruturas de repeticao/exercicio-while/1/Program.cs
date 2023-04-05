//Faça um programa que leia e valide as seguintes informações:
// 1. Nome: diferente de vazio;

Console.WriteLine($"Qual seu nome?");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Pfv querido, digite seu nome!");
    nome = Console.ReadLine()!;
    
}

Console.WriteLine($"Seu nome é: {nome}");