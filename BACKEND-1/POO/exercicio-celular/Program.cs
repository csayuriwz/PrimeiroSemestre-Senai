// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using exercicio_celular;

celular celular = new celular();

String escolha;

do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@$"
=========================================
Selecione uma das seguingte opcoes:
[1] - Ligar o aparelho
[2] - Desligar o aparelho
[3] - Fazer uma ligacao
[4] - Enviar mensagens
[0] - Sair
==========================================
");
    escolha = Console.ReadLine()!;

    switch (escolha)
    {
        case "1":
            {
                if (celular.Ligado)
                {
                    Console.WriteLine($"O celular já está ligado!");
                }
                else
                {
                    celular.Ligar();

                }
                break;

            }

        case "2":
            {
                if (celular.Ligado == false)
                {
                    Console.WriteLine($"O celular já está desligado!");
                }
                else
                {
                    celular.Desligar();

                }
                break;
            }
        case "3":
            {
                if (celular.Ligado)
                {
                    celular.FazerLigacao();
                }
                else
                {
                    Console.WriteLine($"O celular já está desligado!");
                }
                break;
            }
        case "4":
            {
                if (celular.Ligado)
                {
                    celular.EnviarMensagem();
                }
                else
                {
                    Console.WriteLine($"O celular já está desligado!");
                }
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

