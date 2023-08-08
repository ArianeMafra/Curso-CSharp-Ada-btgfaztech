namespace Exercicio_aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com as informações do produto.");

            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Entre com o número de produtos que serão adicionados ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Entre com o número de produtos que serão removidos do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(produto);

            Console.ReadKey();
        }
    }
}