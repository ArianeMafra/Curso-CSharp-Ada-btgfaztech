namespace Biblioteca
{
    public class Livro
    {       
        public string Titulo { get; set; }
        public string Ibsn { get; set; }
        public string Editora { get; set; }
        public int NumeroPaginas { get; set; }
        public string Autor { get; set; }

        public Livro (string titulo, string ibsn, string editora, int numeroPaginas, string autor)
        {
            Titulo = titulo;
            Ibsn = ibsn;
            Editora = editora;
            NumeroPaginas = numeroPaginas;
            Autor = autor;
        }
    }
}
