//3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Qual é tabuada necessaria?");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}









