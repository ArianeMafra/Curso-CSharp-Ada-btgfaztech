/*5- Um Posto de combustiveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
Escreva um algoritmo para ler o tipo de combustivel abastecido (codificado da seguinte forma: 1.Álcool 
2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser 
solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o 
número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quan0dade de clientes que abasteceram 
cada tipo de combustivel.
*/

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool sair = false;
                
            do
            {               
                Console.WriteLine("Digite o número da opção de combustível abastecido:");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Fim");

                bool entrada = int.TryParse(Console.ReadLine(), out int escolha);
                
                if (entrada)
                {
                    switch (escolha)
                    {
                        case 1:
                            alcool += 1;
                            break;
                        case 2:
                            gasolina += 1; 
                            break;
                        case 3:
                            diesel += 1;
                            break;
                        case 4:
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Entre com uma opção válida!");
                            break;
                    }
                }           

            } while (sair == false);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}