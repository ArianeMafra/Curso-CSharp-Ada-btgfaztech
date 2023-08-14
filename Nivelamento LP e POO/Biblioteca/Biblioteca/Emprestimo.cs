namespace Biblioteca
{
    public class Emprestimo
    {
        private const double MultaPorDia = 1.00;
        private Pessoa Pessoa { get; set; }
        private DateTime DataEmprestimo { get; set; }
        private DateTime DataDevolucaoPrevista { get; set; } = new();
        private DateTime DataDevoluacao { get; set; } = new();
        private List<Livro>? LivrosEmprestados { get; set; }
        private bool Finalizado { get; set; } = false;      


        public string EmprestarLivros(Pessoa pessoa, List<Livro> livros) 
        {            
            Pessoa = pessoa;
            DataEmprestimo = DateTime.Now;
            DataDevolucaoPrevista = DataEmprestimo.AddDays(14);           
            LivrosEmprestados = livros;
            Finalizado = false;

            return "Emprestimo realizado com sucesso!";
        }

        public string DevolverLivros(Pessoa pessoa)
        {           
            Finalizado = true;
            DataDevoluacao = DateTime.Now;

            if (DataDevoluacao > DataDevolucaoPrevista)
            {
                return CalcularMulta();
            } else
            {
                return "Devolução realizada com sucesso!";
            }  
        }

        public string CalcularMulta()
        {
            double multa = (DataDevoluacao - DataDevolucaoPrevista).Days * MultaPorDia;

            return "Devolução realizada com sucesso! Valor de multa a pagar: R$ " + multa;
        }
   
         
    }
}
