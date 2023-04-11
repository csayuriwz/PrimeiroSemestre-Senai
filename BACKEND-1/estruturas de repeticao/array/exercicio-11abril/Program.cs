//exercício de fixação 

//escreva um programa que receba e imprima o nome e idade de 5 pessoas

//personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//exemplo de exibição: 

//1) nome: Carlos
//idade: 36 anos

//2) nome: Eduardo
//idade: 40 anos

//3) nome: Allan
//idade: 30 anos

//4) nome: Julia
//idade: 18 anos

//5) nome: Gustavo
//idade: 16 anos

string[] nomes = new string[5];

int[] idade = new int[5];

int i;

for (i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa:");
    nomes[i] = Console.ReadLine()!;

    Console.WriteLine($"Digite a idade da respectiva pessoa:");
    idade[i] = int.Parse(Console.ReadLine()!);

}

for (i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($" {i + 1}) nome: {nomes[i]} ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idade[i]} \n");
    Console.ResetColor();

}

