using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Varejo : Empresa, IImprimirInformacoes, IRealizarVenda
    {

        public Varejo(string nome, string cnpj, string endereco) : base (nome, cnpj, endereco)
        {
            
        }
        
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CNPJ: {Cnpj}, Endereço: {Endereco}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vende produtos.");
        }


    }
}
