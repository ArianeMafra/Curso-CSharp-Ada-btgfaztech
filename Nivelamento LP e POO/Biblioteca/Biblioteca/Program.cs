namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Pessoa pessoa1 = new("Ana", "Souza", "12345678900");
            List<Livro> livros = new List<Livro>();
            
            Livro livro1 = new("Flores para Algernon", "8576573938", "Aleph", 288, "Daniel Keyes");
            livros.Add(livro1);
            Livro livro2 = new("It, a coisa", "8560280944", "Suma", 1104, "Stephen king");
            livros.Add(livro2);                  

            Emprestimo emprestimo1 = new();
            Console.WriteLine(emprestimo1.EmprestarLivros(pessoa1, livros));

            Console.WriteLine(emprestimo1.DevolverLivros(pessoa1));            

        }
    }
}