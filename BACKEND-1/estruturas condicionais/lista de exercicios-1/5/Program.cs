// As    maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Olá querido, quantas maçãs você comprou hoje? ");
int maca = int.Parse(Console.ReadLine());

if (maca < 12)
{
    Console.WriteLine($"O valor da sua compra é R${0.30 * maca}");
}

else
{
    Console.WriteLine($"O valor de sua compre é R${0.25 * maca}");
}


