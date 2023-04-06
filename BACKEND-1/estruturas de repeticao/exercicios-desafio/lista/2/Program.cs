//2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.WriteLine($"Qual deu nome?");
string nome = Console.ReadLine()!;

Console.WriteLine($"Defina uma senha?");
string senha = (Console.ReadLine()!);

while (nome == senha)
{
    Console.WriteLine($"Digite uma senha válida:");
    senha = (Console.ReadLine()!);
    
}

