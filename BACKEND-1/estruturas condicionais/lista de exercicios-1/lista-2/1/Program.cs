//Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Qual o dia do seu aniversario?");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o mes do seu aniversario?");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o ano do seu nascimento?");
int ano = int.Parse(Console.ReadLine());

if( (dia <= 0 || dia >= 32)) 
{
    Console.WriteLine($"Data invalida, digite um dia valido, o dia escolhido não existe");
}

else if (mes <= 0 || mes >= 13)
{
    Console.WriteLine($"Data invalida, digite um mes valido, o mes escolhido não existe");
}

else if (ano > 2013)
{
    Console.WriteLine($"Data invalida, digite um mes valido, o ano escolhido não existe");
}

else
{
    Console.WriteLine($"Data valida! Sua data de aniversario e: {dia}/{mes}/{ano}");
}

