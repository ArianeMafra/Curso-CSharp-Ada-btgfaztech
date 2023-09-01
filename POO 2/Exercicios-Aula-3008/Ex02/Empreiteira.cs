using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Empreiteira : Empresa, IImprimirInformacoes, IRealizarVenda
    {
        public Empreiteira(string nome, string cnpj, string endereco) : base(nome, cnpj, endereco)
        {

        }
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CNPJ: {Cnpj}, Endereço: {Endereco}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vende serviços.");
        }
    }
}
