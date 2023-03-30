//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"Qual o seu sálario liquido?");
float salário = float.Parse (Console.ReadLine());

Console.WriteLine($"Quanto você gastou esse mês?");
float gasto = float.Parse (Console.ReadLine());

if (gasto > salário)
{
    Console.WriteLine($"Ops! Seu orcamento desse mes foi estourado :( ");
}

else if (gasto < salário);
{
    Console.WriteLine($"Os gastos desse mês estão dentro do orcamento! Parabens!");
}