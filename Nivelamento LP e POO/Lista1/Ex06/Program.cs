/*6- Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para 
fora do intervalo). */

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            Console.Write("Entre com um número inteiro positivo: ");
            bool entrada1 = int.TryParse(Console.ReadLine(), out int n);
            
            if (entrada1 && n >0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Entre com o {i + 1}º número: ");
                    bool entrada2 = int.TryParse(Console.ReadLine(), out int x);
                    
                    if (entrada2)
                    {
                        if (x >= 10 && x <= 20)
                        {
                            dentro++;
                        }
                        else
                        {
                            fora++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida!");
                        Environment.Exit(0);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Entrada inválida! Entre com um número inteiro positivo.");
                Environment.Exit(0);
            }            

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}