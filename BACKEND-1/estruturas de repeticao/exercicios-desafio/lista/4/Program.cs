//4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
//produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
//A.O número de pessoas que responderam SIM.
//B.O número de pessoas que responderam NÃO;
//C.O número de mulheres que responderam SIM;
//D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.



int sim = 0;

int nao = 0;

//mulheres q responderam sim 
int msim = 0;

int hnao = 0;


string sexo = "";
string opn = "";

for (int i = 1; i <= 10; i++)
{
     Console.WriteLine($"Digite seu sexo:");
      sexo = Console.ReadLine()!;

Console.WriteLine($"Você gostou do produto? responda com sim ou não:");
     opn = Console.ReadLine()!;

    
     if (opn == "sim")
     {
        sim ++;        
     }
     else if (true)
     {
        
     }
     else
     {
        nao ++;
     }


}

Console.WriteLine($"Pessoas que responderam SIM: {sim} pessoas");

