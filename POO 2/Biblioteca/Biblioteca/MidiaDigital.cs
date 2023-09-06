using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool Disponivel { get; set; }
        public MidiaDigital(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
            Disponivel = true;
        }

        public void EmprestarItem()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"Mídia Digital {Titulo} emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Mídia Digital {Titulo} já encontra-se emprestado.");
            }
        }

        public void DevolverItem()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine($"Mídia Digital {Titulo} devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Mídia Digital {Titulo} não encontra-se emprestado.");
            }
        }
    }
}
