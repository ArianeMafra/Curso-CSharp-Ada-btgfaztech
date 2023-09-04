/*Exercício 3
Vamos pegar o projeto de vcs da Empresa com interfaces!
Crie uma interface EnviarNotificacao com um método void EnviarMensagemCliente.
Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";

Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
Após Realizar a venda, utilizaremos o método de EnviarNotificacao..*/

using Ex03;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnviarNotificacaoWhatsApp notificacaoWhatsApp = new EnviarNotificacaoWhatsApp();
            List<Empresa> listaEmpresas = new List<Empresa>
            {
                new Varejo("Loja XV", "12.345.678/0001-90", "Rua XV, 123, Boa Vista, São Paulo - SP", notificacaoWhatsApp),

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

