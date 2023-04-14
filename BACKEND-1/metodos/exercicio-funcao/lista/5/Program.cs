// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

int resultado;
Console.WriteLine($"Aqui esta a tabuada de 1 a 10");

for (int pMultiplicador = 0; pMultiplicador <= 10; pMultiplicador++)
{
    for (int sMultiplicador = 0; sMultiplicador <= 10; sMultiplicador++)
    {


        resultado = sMultiplicador * pMultiplicador;
        Console.WriteLine($"{pMultiplicador}x{sMultiplicador} = {resultado}");
    }
}

