// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele.

//  A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using exercicio_elevador;

Elevador elevador =  new Elevador();

elevador.Andar = 10;
elevador.Capacidade = 20;

elevador.Inicializa(elevador.Andar, elevador.Capacidade);

string opcao;

do
{
    Console.WriteLine(@$"
 [1] - Subir
 [2] - Descer
 [3] - Entrar
 [4] - Sair
 
 [0] - Desligar
 
 ");
 opcao = Console.ReadLine()!;


    switch (opcao)
    {
        case "Subir":
            elevador.Subir();
            break;
        case "Descer":
            elevador.Descer();
            break;
        case "Entrar":
            elevador.Entrar();
            break;
        case "Sair":
            elevador.Sair();
            break;
        case "0":
            Console.WriteLine($"Encerrando, ou desligando o elevador");
            break;
        default:
            break;
    }

}while (opcao != "0");    

