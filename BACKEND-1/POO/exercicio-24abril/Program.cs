// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using calculadora;

Operador calc = new Operador();

String opcao;

do
{
    
// Console.Clear();    
Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine(@$"


Seja bem-vindo a CALCULADORA 3000!
Selecione uma das seguingtes operações:
=========================================
[1] - SOMAR
[2] - SUBTRAIR
[3] - MULTIPLICAR
[4] - DIVIDIR
[0] - Sair.
==========================================

");
opcao = Console.ReadLine()!;

Console.WriteLine($"Digite um número: ");
calc.num1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite um outro número: ");
calc.num2 = float.Parse(Console.ReadLine()!);
Console.ResetColor();



switch (opcao)
{
    case "0":  
    {
        break;
    }

    case "1":
    {
        calc.Somar();
        break;
    }

    case "2":
    {
        calc.Subtrair();
        break;
    }

    case "3":
    {
        calc.Multiplicar();
        break;
    }

    case "4":
    {
        calc.Dividir();
        break;
    }

    default:
    Console.WriteLine($"Opcao invalida.");
    
        break;
}
} while (opcao != "0");