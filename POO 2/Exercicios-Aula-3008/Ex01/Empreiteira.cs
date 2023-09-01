using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Empreiteira : Empresa
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Vende serviços.");
        }
    }
}
