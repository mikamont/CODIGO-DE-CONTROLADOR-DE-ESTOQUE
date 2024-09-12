using System.Diagnostics.Contracts;

class Estoque
{
    public string produto;
    public int quantidade;
    public double preco;

    public void AdicionarEstoque(int valor)
    {
        quantidade = quantidade + valor;

    }

    public void RemoverDoEstoque(int quantidade)
    {
        this.quantidade -= quantidade;
    }

    public double RetornaValorTotalDoEstoque()
    {
        return quantidade * preco;
    }

    public void ExibeInformacao()
    {
        Console.WriteLine($"Nome do protudo: {produto} ");
        Console.WriteLine($"Quantidade de Produtos: {quantidade} ");
        Console.WriteLine($"Valor do Produto: {preco} ");
        Console.WriteLine($"Valor total do estoque: {RetornaValorTotalDoEstoque()} ");
    }
}