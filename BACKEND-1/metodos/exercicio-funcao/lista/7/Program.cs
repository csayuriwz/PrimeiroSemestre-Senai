// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

float[] nums = new float[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero");
    nums[i] = float.Parse(Console.ReadLine()!);
}

foreach (var valor in nums.Reverse())
{
    Console.WriteLine($"{valor}");
}

