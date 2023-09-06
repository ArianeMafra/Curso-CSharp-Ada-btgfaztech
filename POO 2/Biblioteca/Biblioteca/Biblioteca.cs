using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> itensBiblioteca;

        public Biblioteca()
        {
            itensBiblioteca = new List<ItemBiblioteca>();
        }

        public void AdicionarItem(ItemBiblioteca item)
        {
            itensBiblioteca.Add(item);
        }

        public void EmprestarItem(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestavel)
            {
                itemEmprestavel.EmprestarItem();
            }
            else
            {
                Console.WriteLine("Este tipo de item não pode ser emprestado");
            }
        }

        public void DevolverItem(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestavel)
            {
                itemEmprestavel.DevolverItem();
            }
            else
            {
                Console.WriteLine("Este item não pode ser devolvido.");
            }
        }
    }
}
