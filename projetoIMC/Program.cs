
// Programa IMC

// Faça um programa que calcule o imc de uma pessoa recebendo ow dados
// no console, ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
----------------
Programa para 
calcular o IMC
----------------");
Console.ResetColor();

Console.WriteLine($"Informe o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente:");
float altura = float.Parse(Console.ReadLine());


float imc = peso / ((float)Math.Pow(altura,2));

// concatenação
//System.Console.WriteLine("O paciente " + nome + " tem o IMC igual a: " + imc);

// interpolação
Console.WriteLine($"O paciente {nome} tem o imc igual á {imc}");