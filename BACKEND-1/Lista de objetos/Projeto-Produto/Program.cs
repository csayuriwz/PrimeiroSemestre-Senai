// instancia do objeto carrinho

using Projeto_Produto;

Carrinho carrinho = new Carrinho();

// instanciar objeto(s) da classe Produto
Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza Orizon", 100f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Após a remocao de um item");

carrinho.Remover(p2);
carrinho.Remover(p2);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

// criar um objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1,_novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();




