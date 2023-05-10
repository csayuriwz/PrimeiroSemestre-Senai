// crie uma classe produto
// com as propriedades : int código, string nome, float preco
// crie um construtor vazio
// crie um construtor completo

using exercicio_exemplo;

//  criar a lista de objetos(produtos)

List<Produto> produtos = new List<Produto>();


// adicionar os objetos na lista, existem dois modos.

// 1 modo
produtos.Add(
    new Produto(2563, "camisa QuickSilver", 19.90f)
);

produtos.Add(
    new Produto(1025, "tenis Nike", 50f)
);

// 2 modo
Produto calca = new Produto(1526, "calca Diesel", 15f);
produtos.Add(calca);

// exibir lista
Console.WriteLine($"Lista antiga:");

foreach (var item in produtos)
{
    Console.WriteLine($"Código:{item.Código}, Nome:{item.Nome} Preço:{item.Preço:C} {produtos.IndexOf(item)}");

}

// .find para buscar na lista produtos, o x simboliza qualquer coisa, x,Código para buscar pelo código, 2563 é o código que procuramos. Outro exemplo seria com nome ou preco. produtos.Find(x => x.Nome == Catarina) = procuraria por item com nome de Catarina e ele puxaria o 1 indice compativel. (a expressao se chama expressao lâmbida)

// Produto produtobuscado é utilizado para podermos manuzear o produto que pegamos, pois agr ele esta em uma caixinha

Produto produtoBuscado = produtos.Find(x => x.Código == 2563);

// index é um nome qualquer, nesse caso é a caixinba que guarda o numero do indice que queremos alterar

int index = produtos.IndexOf(produtoBuscado);

// alteracao do indice, agora que está "fora" (foi clonado) da lista
produtoBuscado.Preço = 199.90f;

// removendo o objeto antigo
produtos.RemoveAt(index);
//  com o objeto apagado, os outros indices se reajustaram, agora precisamos inserir o objeto modificado no seu indice de origem.

produtos.Insert (index, produtoBuscado);
// objeto inserido


Console.WriteLine($"Lista atualizada:");

foreach (var item in produtos)
{
    Console.WriteLine($"Código:{item.Código}, Nome:{item.Nome} Preço:{item.Preço:C} {produtos.IndexOf(item)}");

}


