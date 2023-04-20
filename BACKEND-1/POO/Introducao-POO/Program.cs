using Introducao_POO;

// instanciar um objeto da classe personagem
personagens p1 = new personagens();

Console.WriteLine($"Informe o nome do personagem:");
p1.nome = Console.ReadLine()!;

Console.WriteLine($"Informe a idade do personagem:");
p1.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a armadura do persinagem:");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Informe a IA do personagem:");
p1.IA = Console.ReadLine();

// exibir o nome do objeto
Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.IA}
");

p1.Atacar();
p1.Defender();
p1.RestaurarArmadura();






































// List<Personagem> list = new List<Personagem>();

// list.Add(p1);