// Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno. 
// Sendo que:    
// − Triângulo Equilátero: possui os 3 lados iguais.
// − Triângulo Isóscele: possui 2 lados iguais.
// − Triângulo Escaleno: possui 3 lados diferentes.

Console.WriteLine($"Qual e o tamanho de um dos lados do triangulo? ");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual e o tamanho de um dos lados do triangulo? ");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual e o tamanho de um dos lados do triangulo? ");
int lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2  && lado1 == lado3)
{
    Console.WriteLine($"Triângulo Equilátero: possui os 3 lados iguais.");
}

else if (lado1 != lado2  && lado1 != lado3)
{
    Console.WriteLine($"Triângulo Escaleno: possui 3 lados diferentes.");
}

else 
{
    Console.WriteLine($"Triângulo Isóscele: possui 2 lados iguais.");
}