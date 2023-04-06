//1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Qual sua nota?");
int idade = int.Parse (Console.ReadLine()!);

while (idade < 0 || idade > 10)
{
    Console.WriteLine($"Nota negada! Digite uma idade valida.");
    idade = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Sua Nota é válida!");