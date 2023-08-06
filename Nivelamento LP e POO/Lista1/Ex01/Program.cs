/*1 - Um imposto é calculado com base na seguinte tabela: 
Até 1.200,00 isento 
de 1.201,00 a 2.500,00 10% 
de 2.501,00 a 5.000,00 15% 
acima de 5.000,00 20%. 
Implemente um programa que leia o valor base e calcule o imposto a pagar.*/

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de calculo de imposto.");
            Console.Write("Entre com o valor base: ");
        
            bool entrada = double.TryParse(Console.ReadLine(), out double valorBase);

            if (entrada)
            {
                double imposto = CalculaImposto(valorBase);

                Console.WriteLine($"O imposto a ser pago é de R$ {imposto:F2}.");
            }
            else
            {
                Console.WriteLine("Entrada de dados inválida!");
            }   
        }

        static double CalculaImposto(double valorBase)
        {
            double imposto = 0;

            if (valorBase <= 1200)
            {
                imposto = 0;
            }
            else if (valorBase <= 2500)
            {               
                imposto = valorBase * 0.10;
            }
            else if (valorBase <= 5000)
            {
                imposto = valorBase * 0.15;
            }
            else
            {
                imposto = valorBase * 0.20;
            }

            return imposto;
        }
    }
}