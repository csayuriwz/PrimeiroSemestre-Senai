﻿//criar um metodo para somar 2 numeros

static float Soma(float n1, float n2){
    float r = n1 + n2;
    return r;
}






//////////////SUBTRACAO//////////////////////

static float Sub(float n1, float n2)
{
    Console.WriteLine($"Digite o primeiro valor");
    float n1 = float.Parse(Console.ReadLine());
    
}

float resultado = Sub(500,12);

Console.WriteLine($"Resultado: {resultado}");

////////////////MULTIPLICACAO///////////////////

static float Mult(float n1, float n2)
{

    return (n1 * n2);
}

float resultadoM = Mult(500,12);

Console.WriteLine($"Resultado: {resultadoM}");

/////////////DIVISAO/////////////////////////////

static float Div(float n1, float n2)
{
    return (n1 / n2);
}

float resultadoD = Div(500,12);

Console.WriteLine($"Resultado: {resultadoD}");

////////////////////////////////////////////

