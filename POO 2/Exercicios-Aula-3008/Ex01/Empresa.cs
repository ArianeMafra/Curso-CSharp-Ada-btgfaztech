using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public abstract class Empresa
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set;}

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CNPJ: {Cnpj}, Endereço: {Endereco}");
        }

        public abstract void RealizarVenda();
    }
}
