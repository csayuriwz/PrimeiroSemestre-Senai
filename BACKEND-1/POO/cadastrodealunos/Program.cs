// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

using ProjetoAlunos;

Aluno aluno = new Aluno();

Console.WriteLine($"Informe o nome do aluno:");
aluno.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe o curso do aluno:");
aluno.Curso = Console.ReadLine()!;

Console.WriteLine($"Qual a idade do aluno?");
aluno.Idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual é o RG do aluno?");
aluno.Rg = Console.ReadLine()!;

Console.WriteLine($"O aluno é bolsista? s/n");
string resposta = Console.ReadLine()!.ToLower();

if (resposta == "s")
{
    aluno.Bolsista = true;
}
else
{
    aluno.Bolsista = false;
}
Console.WriteLine($"Qual é a média final do aluno?");
aluno.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual é o valor da mensalidade do aluno?");
aluno.ValorMensalidade = float.Parse(Console.ReadLine()!);

String escolha;

do
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
=========================================
Selecione uma das seguingte opcoes:
[1] - Ver média final do aluno 
[2] - Ver mensalidade total á pagar
[0] - Sair
==========================================
");
    escolha = Console.ReadLine()!;

    switch (escolha)
    {
        case "1":
            {
                aluno.VerMediaFinal();
                break;
            }

        case "2":
            {
                aluno.VerMensalidade();
                break;
            }

        case "0":
            {
                break;
            }

        default:
            Console.WriteLine($"Entrada inválida. Tente novamente");
            break;
    }
} while (escolha != "0");

