// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine($"Qual tipo de combustivel vc prefere?");
char combustivel = char.Parse(Console.ReadLine()!.ToUpper());

while (combustivel != 'A' && combustivel != 'G')
{
    Console.WriteLine($"Qual tipo de combustivel vc prefere?");
    combustivel = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"Quantos litros vc vai por?");
float litros = float.Parse(Console.ReadLine()!);

while (litros <= 0)
{
    Console.WriteLine($"Quantos litros vc vai por?");
    litros = float.Parse(Console.ReadLine()!);
}

float valor = 0;

switch (combustivel)
{
    case 'A':

        if (litros >= 0 && litros <= 20)
        {
            valor = (float)((4.90 - (4.90 * 0.03)) * litros);
        }

        else
        {
            valor = (float)((4.90 - (4.90 * 0.05)) * litros);
        }
    break;

    case 'G':

        if (litros >= 0 && litros <= 20)
        {
            valor = (float)((5.30 - (5.30 * 0.04)) * litros);
        }

        else
        {
            valor = (float)((5.30 - (5.30 * 0.06)) * litros);
        }
    break; 
    
    default:

        break; 
    
}

Console.WriteLine($"O valor total é de: {valor}");

