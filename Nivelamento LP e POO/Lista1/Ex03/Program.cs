/*3 - Faça um algoritmo para ler: quantidade atual em estoque, quan0dade máxima em estoque e quantidade 
mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade média = 
quantidade máxima + quantidade mínima)/ 2). Se a quantidade em estoque for maior ou igual a quantidade 
média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'.*/

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade atual em estoque do produto: ");
            bool entrada1 = int.TryParse(Console.ReadLine(), out int qntAtual);          

            Console.Write("Entre com a quantidade máxima em estoque do produto: ");
            bool entrada2 = int.TryParse(Console.ReadLine(), out int qntMax);

            Console.Write("Entre com a quantidade mínima em estoque do produto: ");
            bool entrada3 = int.TryParse(Console.ReadLine(), out int qntMin);

            if (entrada1 && entrada2 && entrada3)
            {
                double qntMedia = (qntMax + qntMin) / 2;

                if (qntAtual >= qntMedia)
                {
                    Console.WriteLine("Não efetuar compra");
                }
                else
                {
                    Console.WriteLine("Efetuar compra");
                }
            }
            else
            {
                Console.WriteLine("Entrada de dados inválida!");
            }
        }
    }
}