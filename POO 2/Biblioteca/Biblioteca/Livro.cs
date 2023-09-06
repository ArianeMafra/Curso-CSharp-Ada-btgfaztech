using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        private const double MultaPorDia = 1.00;
        public bool Disponivel { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
            Disponivel = true;   
        }
        public void EmprestarItem()
        {
            if (Disponivel)
            {
                Disponivel = false;
                DataEmprestimo = DateTime.Now;
                DataDevolucaoPrevista = DataEmprestimo.AddDays(14);
                Console.WriteLine($"Livro {Titulo} emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro {Titulo} já encontra-se emprestado.");
            }
        }

        public void DevolverItem()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                DataDevolucao = DateTime.Now;
                if (DataDevolucao > DataDevolucaoPrevista)
                {
                    CalcularMulta();
                }
                else
                {
                    Console.WriteLine($"Livro {Titulo} devolvido com sucesso.");
                }
            }
            else
            {
                Console.WriteLine($"Livro {Titulo} não encontra-se emprestado.");
            }         
        }

        public string CalcularMulta()
        {
            double multa = (DataDevolucao - DataDevolucaoPrevista).Days * MultaPorDia;

            return "Devolução realizada após o prazo! Valor de multa a pagar: R$ " + multa;
        }
    }
}
