namespace Exercicio_aula3
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do Produto \nNome: " + Nome + ", Preço: R$" + Preco.ToString("F2") + ", Quantidade em Estoque: " + Quantidade +
                ", Valor total em estoque: R$" + ValorTotalEmEstoque().ToString("F2") + ".";
        }
    }

}
