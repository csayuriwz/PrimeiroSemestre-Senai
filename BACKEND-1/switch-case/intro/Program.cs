// introducao a switch case

Console.WriteLine($"Informe o numero correspondente ao da semana");
int diasemana = int.Parse(Console.ReadLine()!);

switch (diasemana)
{
    case 1:
        Console.WriteLine($"Hoje é domingo!!");
        break;

    case 2:
        Console.WriteLine($"Hoje é segunda!!");
        break;

    case 3:
        Console.WriteLine($"Hoje é terca-feira!!");
        break;

    case 4:
        Console.WriteLine($"Hoje é quarta-feira!!");
        break;

    case 5:
        Console.WriteLine($"Hoje é quinta-feira!!");
        break;

    case 6:
        Console.WriteLine($"Hoje é sexta-feira!!");
        break;

    case 7:
        Console.WriteLine($"Hoje é sabado!!");
        break;

    default:
        Console.WriteLine($"O dia da indicado nao corresponde a nenhum dia da semana");
        break;
}

// Desenvolvido por Gabriel Silva e Sasa nakandakare