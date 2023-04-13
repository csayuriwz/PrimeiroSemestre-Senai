// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Qual o produto que você quer comprar?");
string produto = Console.ReadLine()!;

Console.WriteLine($"Qual o preço da unidade desse produto?");
float preco = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Certo! Agora digite a quantidade que você quer:");
int quantidade = int.Parse(Console.ReadLine()!);

float total = preco * quantidade;

float desconto;

if (quantidade <= 5)
{
    desconto = 2/100;
}
else if (quantidade > 5 && quantidade <=10)
{
    desconto = 3/100;
}
else if (quantidade > 10)
{
    desconto = 5/100;
}
else
{
    desconto = 0;
}

float valortotal = (total - (total * desconto));

Console.WriteLine($"O preco total será de {total}, porem com o desconde de: {desconto} o valor a pagar sera de: {valortotal}");






