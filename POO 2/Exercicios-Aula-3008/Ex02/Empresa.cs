using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    public class Empresa
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }

        public Empresa(string nome, string endereco, string cnpj)
        {
            Nome = nome;
            Endereco = endereco;
            Cnpj = cnpj;           
        }


    }
}
