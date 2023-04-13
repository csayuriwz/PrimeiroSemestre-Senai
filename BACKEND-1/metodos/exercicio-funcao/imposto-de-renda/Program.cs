//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda


Console.WriteLine($"Qual sua renda?");
float rendimento = float.Parse(Console.ReadLine()!)!;

static float impostoderenda(float rendimento)
{
    if (rendimento <= 1500)
    {
        return 0;
        Console.WriteLine($"voce esta isento do imposto de renda, sua taxa sera R$ 0,00 !");
    }

    else if (rendimento < 1500 && rendimento <= 3500)
    {
        return rendimento / 100 * 20;
    }
    else if (rendimento > 3500 && rendimento <= 6000)
    {
        return rendimento / 100 * 25;
    }
    else
    {
        return rendimento / 100 * 35;
    }
}

float resultado = impostoderenda(rendimento);

Console.WriteLine($"voce vai pagar R${resultado} de imposto!");
