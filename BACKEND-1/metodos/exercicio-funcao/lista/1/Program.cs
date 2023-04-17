//- Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite o ano atual:");
int ano = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu ano de nascimento:");
int nascimento = int.Parse(Console.ReadLine()!);

int idade = ano - nascimento;

if (idade >= 16)
{
    Console.WriteLine($"Você poderá votar esse ano!");
}
else
{
    Console.WriteLine($"Você não poderá votar esse ano!");

}


