int resultado;
Console.WriteLine($"Aqui esta a tabuada de 1 a 10");

for (int pMultiplicador = 0; pMultiplicador <= 10; pMultiplicador++)
{
    for (int sMultiplicador = 0; sMultiplicador <= 10; sMultiplicador++)
    {
        
        
        resultado = sMultiplicador*pMultiplicador;
        Console.WriteLine($"{pMultiplicador}x{sMultiplicador} = {resultado}");
    }
}
