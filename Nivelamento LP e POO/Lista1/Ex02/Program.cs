/*2- A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 
horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um 
algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do 
funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês 
possua 4 semanas exatas). */

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de salário total.");
            Console.Write("Entre com o número de horas trabalhadas no mês: ");
            bool entrada1 = double.TryParse(Console.ReadLine(), out double horasTrabalhadas);

            Console.Write("Entre com o salário por hora: ");
            bool entrada2 = double.TryParse(Console.ReadLine(), out double salarioHora);

            if (entrada1 && entrada2)
            {               
                Console.WriteLine($"O salário total do é: R$ {CalculaSalarioTotal(horasTrabalhadas, salarioHora):F2}.");
            }
            else
            {
                Console.WriteLine("Entrada de dados inválida!");
            }
        }

        static double CalculaSalarioTotal(double horasTrabalhadas, double salarioHora)
        {
            int horasMensais = 40 * 4;
            double salario = salarioHora * horasTrabalhadas;

            double horaExtra = 0;
            if (horasTrabalhadas > horasMensais)
            {
                horaExtra = ((horasTrabalhadas - horasMensais) * salarioHora) * 0.5;
            }         

            return salario + horaExtra;
        }
    }
}