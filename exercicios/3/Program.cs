//faca um programa q tire a media aritimetica de um aluno com 5 notas

Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Olá querida (o), {nome}. Digite sua n1");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá querido, {nome}. Digite sua n2");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá querido, {nome}. Digite sua n3");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá querido, {nome}. Digite sua n4");
int n4 = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá querido, {nome}. Digite sua n5");
int n5 = int.Parse(Console.ReadLine());

int media = (n1 + n2 + n3 + n4 + n5) / 5;

Console.WriteLine($"Parabens! Sua média é {media}");

