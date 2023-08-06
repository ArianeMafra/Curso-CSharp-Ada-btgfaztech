/*4- Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e 
identifique o maior e o menor número gerados, e respectivas posições. */

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            Random random = new Random();
            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next();
            }

            int maiorNum = int.MinValue;
            int maiorNumPosicao = 0;
            int menorNum = int.MaxValue;           
            int menorNumPosicao = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNum)
                {
                    maiorNum = numeros[i];
                    maiorNumPosicao = i;
                }

                if (numeros[i] < menorNum)
                {
                    menorNum = numeros[i];
                    menorNumPosicao = i;
                }
            }

            Console.WriteLine($"O maior número é o {maiorNum}, que esta na posição {maiorNumPosicao}.");
            Console.WriteLine($"O menor número é o {menorNum}, que esta na posição {menorNumPosicao}.");
        
        }
    }
}