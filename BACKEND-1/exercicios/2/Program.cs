//Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
//e semanas e imprima o resultado no console.

Console.WriteLine($"Digite seu ano de nascimento");
int ano = int.Parse(Console.ReadLine());

int idade = DateTime.Now.Year - ano;
int semana = idade*52;

Console.WriteLine($"sua idade é: {idade}");
Console.WriteLine($"sua idade em semanas é: {semana}");


