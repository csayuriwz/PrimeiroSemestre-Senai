//criar um programa em c# que receba 5 numeros inteiros e ao final exiba o seu dobro
//vc deve utilizar a estrutura array com tamanho 5 para o armazenamento dos numeros, a estrutura for para a leitura dos numeros e a estrutura foreach para exibilos.

int[]nums = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero:");
    nums[i] = int.Parse(Console.ReadLine()!);

}

foreach (int i in nums)
{
    Console.WriteLine($"O dobro de {i} é {i*2}");
}
