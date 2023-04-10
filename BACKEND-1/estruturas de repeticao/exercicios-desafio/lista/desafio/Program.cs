// Pesquise como funciona o algoritmo Fibonacci.
// Faça um programa que gere a série até que o valor seja maior que 500. 


int num1, num2, resultado;
num1 = 1;
num2 = 1;
Console.WriteLine($"{num1}");
Console.WriteLine($"{num2}");

do
{

    resultado = num1 + num2;
    Console.WriteLine($"{resultado}");
    num2 = num1;
    num1 = resultado;


} while (resultado < 500);