// Criar um projeto de console
// Criar uma classe Carro
// -Marca
// -Cor
// Criar um construtor vazio e outro completo
// Receber dados no cosole para adicionar 2 objetos em uma lista 
// Exibir os dois obejetos da lista no console

using exercicio_lista;

// Criar a lista de onjetos (carros)

List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a marca do carro:");
    carro.Marca = Console.ReadLine()!;

    Console.WriteLine($"Informe a cor do carro:");
    carro.Cor = Console.ReadLine()!;
    

    // carros é a lista, a cada laco de repeticao os itens colocados em carro serao adicionados em carros.
    carros.Add (carro);
}

foreach (var item in carros)
{
   Console.WriteLine($" Marca: {item.Marca} Cor: {item.Cor}");
   
}