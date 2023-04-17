// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// algoritimo:
// do while pra senha
// c a senha correta entrar no menu
// criar um array para 5 cadastro
// cada item no menu de cadastro é um outro array


static void Login()
{
    Console.WriteLine($"Olá! Digite sua senha para ter acesso ao menu da nossa agência:");
    int senha = int.Parse(Console.ReadLine()!);

    while (senha != 123456)
    {
        Console.WriteLine($"Acesso negado, tente outra:");
        senha = int.Parse(Console.ReadLine()!);
    }
    Console.Clear();
    Console.WriteLine($"Acesso permitido!!!!");
}

{
    Login();
    menu();
}




static void menu()
{
    Console.WriteLine(@$"\nEscolha a opção desejada:
    1- Cadastrar passagem
    2- Listar Passagens
    0- Sair
");
    int escolha = int.Parse(Console.ReadLine()!);
    string[] nome = new string[5];
    string[] origem = new string[5];
    string[] destino = new string[5];
    string[] data = new string[5];
    switch (escolha)
    {
        case 1:
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Digite seu nome:");
                nome[i] = Console.ReadLine()!;

                Console.WriteLine($"Digite seu local de origem:");
                origem[i] = Console.ReadLine()!;

                Console.WriteLine($"Digite seu local de destino:");
                destino[i] = Console.ReadLine()!;

                Console.WriteLine($"Digite a data atual:");
                data[i] = Console.ReadLine()!;
                Console.Clear();

                Console.WriteLine($"Voce deseja cadastrar uma nova passagem? s/n");
                char opcao = char.Parse(Console.ReadLine()!);

                while (opcao != 'n' && opcao != 's')
                {
                    Console.WriteLine($"Opção invalida, tente outra:");
                    opcao = char.Parse(Console.ReadLine()!);

                }

                if (opcao == 'n')
                {
                    menu();
                }
            }

            break;

        case 2:

            break;
        case 0:

            break;
        default:

            break;
    }
}




