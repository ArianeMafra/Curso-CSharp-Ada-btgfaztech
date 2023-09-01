/*Exercício 1

Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
Construa um método para imprimir as informações da empresa.
Construa um método abstrato void RealizarVenda()

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.*/

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresaVarejo = new Varejo()
            {
                Nome = "Loja XV",
                Cnpj = "12.345.678/0001-90",
                Endereco = "Rua XV, 123, Boa Vista, São Paulo - SP"
            };

            Empresa empresaEmpreiteira = new Empreiteira()
            {
                Nome = "Águia Empreiteira",
                Cnpj = "67.345.123/0001-12",
                Endereco = "Avenida das Aves, 456, Centro, São Paulo -SP"
            };

            Console.WriteLine("Empresa Varejo:");
            empresaVarejo.ImprimirInformacoes();
            empresaVarejo.RealizarVenda();

            Console.WriteLine();

            Console.WriteLine("Empresa Empreiteira:");
            empresaEmpreiteira.ImprimirInformacoes();
            empresaEmpreiteira.RealizarVenda();
        }
    }
}