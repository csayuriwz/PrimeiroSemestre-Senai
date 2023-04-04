//calculadora

//Algoritmo

//1. informar a operacao 
//2. informar o primeiro numero
//3. informar o segundo numero
//4. processar os dados
//5. exibir o resultado


//entrada 

// Console.WriteLine(@$"
// -------------------------------------
// | Programa de calculadora           |   
// |                                   | 
// |   Informe a operação              |
// |                                   |
// |    (+) soma                       |
// |    (-) subtração                  |
// |    (*) multiplicação              |
// |    (/) divisão                    |
// -------------------------------------
// ");

// char operacao = char.Parse(Console.ReadLine()!);

// Console.WriteLine($"Informe o primeiro número: ");
// double num1 = double.Parse(Console.ReadLine()!);

// Console.WriteLine($"Informe o segundo número: ");
// double num2 = double.Parse(Console.ReadLine()!);

// double resultado = 0;

// //processamento
// //saida

// switch (operacao)
// {
//     case '+':
//         resultado = (num1 + num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '-':
//         resultado = (num1 - num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '*':
//         resultado = (num1 * num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     case '/':
//         resultado = (num1 / num2);
//         Console.WriteLine($"O resultado da conta é igual á : {resultado}");
//         break;
//     default:
//         Console.WriteLine($"Operação inválida, repita o processo!");        
//         break;
// }




//****************************************


//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional


Console.WriteLine(@$"Escolha uma opção de bebida: '


 ---------------------------
 |  1- café                |
 |  2- milkshake           |
 |  3- frappuccino         |
 |  4- espresso macchiato  |
 ---------------------------
");

int cafés = int.Parse(Console.ReadLine()!);
int gelo = 0;

switch (cafés)
{
    case 1:
        Console.WriteLine($"Você escolheu café");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu um café com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você escolheu uma café sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    case 2:
        Console.WriteLine($"Você escolheu um milkshake ");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu um milkshake com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você escolheu um milkshake sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    case 3:
        Console.WriteLine($"Você escolheu frappuccino");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu uma frappuccino com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você escolheu uma frappuccino sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    case 4:
        Console.WriteLine($"Você escolheu espresso macchiato");
        Console.WriteLine(@$"Gostaria de adicionar gelo?
        1- Com gelo
        2- Sem gelo");
        gelo = int.Parse(Console.ReadLine()!);
        switch (gelo)
        {
            case 1:
                Console.WriteLine($"Você escolheu um espresso macchiato com gelo.");
                break;
            case 2:
                Console.WriteLine($"Você escolheu um espresso macchiato sem gelo.");
                break;
            default:
                Console.WriteLine($"Escolha inválida.");
                break;
        }
        break;
    default:
        Console.WriteLine($"Escolha inválida.");
        break;
}

