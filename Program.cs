Estoque estoque1 = new Estoque();
Console.WriteLine("Informe o nome do produto para adicionar ao estoque: ");
estoque1.produto = Console.ReadLine();
Console.WriteLine("Informe a quantidade de produtos em estoque:");
int quantidade = Convert.ToInt32(Console.ReadLine());
estoque1.AdicionarEstoque(quantidade);
Console.WriteLine("Informe o valor do produto: ");
estoque1.preco = Convert.ToDouble(Console.ReadLine());
estoque1.ExibeInformacao();
