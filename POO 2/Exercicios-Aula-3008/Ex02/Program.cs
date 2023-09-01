/*Exercício 2
Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista.*/

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> listaEmpresas = new List<Empresa>
            {
                new Varejo("Loja XV", "12.345.678/0001-90", "Rua XV, 123, Boa Vista, São Paulo - SP"),

                new Empreiteira("Águia Empreiteira", "67.345.123/0001-12", "Avenida das Aves, 456, Centro, São Paulo -SP")
            };

            Console.WriteLine("Empresas: ");
            foreach(var empresa in listaEmpresas)
            {
                if (empresa is IImprimirInformacoes informacoes)
                {
                    informacoes.ImprimirInformacoes();
                }
                if (empresa is IRealizarVenda venda)
                {
                    venda.RealizarVenda();
                }               
                Console.WriteLine();
            }
        }
    }



}

