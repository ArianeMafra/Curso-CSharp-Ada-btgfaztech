using Ex03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Varejo : Empresa, IImprimirInformacoes, IRealizarVenda
    {
        private readonly EnviarNotificacaoWhatsApp notificacao;
        public Varejo(string nome, string cnpj, string endereco, EnviarNotificacaoWhatsApp notificacao) : base (nome, cnpj, endereco)
        {
            this.notificacao = notificacao; 
        }
        
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CNPJ: {Cnpj}, Endereço: {Endereco}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vende produtos.");
            notificacao.EnviarMensagemCliente();
        }


    }
}
