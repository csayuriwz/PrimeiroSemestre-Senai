// // Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// // Os produtos terão os seguintes atributos:
// // string Nome
// // float Preco
// // bool Promocao (se está em promoção ou não)

// // O sistema deverá ter as seguintes funcionalidades:
// // CadastrarProduto
// // ListarProdutos
// // MostrarMenu
// // Crie função(ões) para otimizar o código.
// // Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

// // algoritimo:
// // funcao de login
// // menu
// // switch case p selecionar oq qr dentro do menu


// string[] nome = new string [2];
// float[] preco = new float [2];
// bool[] promocoes = new bool [2];

// int escolha;

// do
// {
//    Console.WriteLine(

// @$"Selecione a opção desejada:   

//     //////////////////////////////////
//     / 1- Cadastrar produtos          /
//     / 2- Listar produtos             / 
//     / 0- Menu                        /
//     / ////////////////////////////////                             

// ");

//    escolha = int.Parse (Console.ReadLine()!);

//    switch (escolha)
//    {
//     case 1:

//         char opcao;

//         do
//         {


//             for (var i = 0; i < 2; i++)
//             {
//                 Console.WriteLine($"Qual o nome do produto");
//                 nome[i] = Console.ReadLine()!;

//                 Console.WriteLine($"Qual o preco do produto?");
//                 preco [i] = float.Parse(Console.ReadLine()!);



//                 string promocao;

//                 do
//                 {
//                 Console.WriteLine($"O produto esta em promocao? s/n");
//                 promocao = Console.ReadLine()!;
//                 if (promocao == "s")
//                 {
//                  promocoes[i] = true;   
//                 }
//                 else
//                 {
//                     promocoes[i] = false;
//                 }

//                 }while (promocao!= "s" && promocao != "n");
//             }

//             Console.WriteLine($"VOce deseja cadastrar mais produtos?");
//             opcao = char.Parse(Console.ReadLine()!);

//         } while (opcao == 's');

//         break;



//     case 2:

//             for (var i = 0; i < 2; i++)
//         {
//                  Console.WriteLine(@$"
//              //////////////////////////////////////////
//              /  Produto {i + 1}                            /
//              /                                        /
//              /  Nome do produto: {nome[i]},                             /
//              /                                        /
//              /  Preco do produto: {preco[i]};
//              /  
//              /  O produto está em promocao? {promocoes[i]}                  
//              ////////////////////////////////////////// ");
//         }



//         break;
//     case 0:










//         break;    
//     default:
//         break;
//    }


// } while (true);





string[] nome = new string[2];
float[] preco = new float[2];
bool[] promocoes = new bool[2];

int escolha;

static void Cadastrar(string[] nome, float[] preco, bool[] promocoes)
{
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine($"Qual o nome do produto");
        nome[i] = Console.ReadLine()!;

        Console.WriteLine($"Qual o preço do produto?");
        preco[i] = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"O produto está em promoção?");
        string promocoesp = Console.ReadLine()!;

        while (promocoesp != "s" && promocoesp != "n")
        {
            Console.WriteLine($"O produto está em promoção?");
            promocoesp = Console.ReadLine()!;
        }

        if (promocoesp == "s")
        {
            promocoes[i] = true;
        }
        else
        {
            promocoes[i] = false;
        }




    }

}


static void Listar(string[] nome, float[] preco, bool[] promocoes) 
{
    string promocoesp;

    for (var i = 0; i < 2; i++)
    {
       if (promocoes[i] == true)
        {
            promocoesp = "Sim, ele está!! :) ";
        }
        else
        {
            promocoesp = "Não, ele não está. :( ";
        }

        Console.WriteLine(@$"
            -----------------------------------------------------------
               Produto {i + 1} 

               Nome do produto: {nome[i]}                             
                                                  
               Preco do produto: {preco[i]}
               
                O produto está em promocao? {promocoesp}                  
            ---------------------------------------------------------- ");


    }
}

do
{
   Console.WriteLine(

@$"Selecione a opção desejada:   

    -----------------------------
     [1]- Cadastrar produtos          
     [2]- Listar produtos             
     [0]- Sair                        
    -----------------------------                            

");

   escolha = int.Parse (Console.ReadLine()!);

   switch (escolha)
   {
    case 1:
        Cadastrar(nome, preco, promocoes);
        break;



    case 2:
        Console.Clear();
        Listar(nome, preco, promocoes);
        break;
    case 0:

        break;    
    
    default:
    Console.WriteLine($"opção inválida! Tente novamente.");
    Console.Clear();
    
        break;
   }


} while (escolha != 0);