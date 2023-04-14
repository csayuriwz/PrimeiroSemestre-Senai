// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

int[] num = new int[10] ;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite O {i + 1}º valor:");
    num[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"O maior valor é {num.Max()} e o menor é {num.Min()}");







