//1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Qual sua nota?");
int nota = int.Parse (Console.ReadLine()!);

while (nota < 0 || nota > 10)
{
    Console.WriteLine($"Nota negada! Digite uma nota valida.");
    idade = int.Parse(Console.ReadLine()!);
    
}

Console.WriteLine($"Sua Nota é válida!");