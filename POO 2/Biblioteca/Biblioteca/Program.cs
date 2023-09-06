/*
Imagine um sistema de gerenciamento de uma biblioteca. Neste sistema, você deve usar classes abstratas e interfaces para modelar diferentes tipos de itens da biblioteca, como livros, revistas e mídias digitais (por exemplo, e-books).

Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido, enquanto uma mídia digital pode ser emprestada indefinidamente.

Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca". 
*/
namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro("Flores para Algernon", "Daniel Keyes", 1966, 288);
            biblioteca.AdicionarItem(livro1);

            Livro livro2 = new Livro("Talvez você deva conversar com alguém", "Lori Gottlieb", 2022, 448);
            biblioteca.AdicionarItem(livro2);

            Revista revista1 = new Revista("Veja ed. 2854", "Veja", 2023, 85);
            biblioteca.AdicionarItem(revista1);

            Revista revista2 = new Revista("Saúde ed. 445", "Veja", 2019, 90);
            biblioteca.AdicionarItem(revista2);

            MidiaDigital midiaDigital1 = new MidiaDigital("E-book: Um estranho sonhador", "Laini Taylor", 2019, 544);
            biblioteca.AdicionarItem(midiaDigital1);

            MidiaDigital midiaDigital2 = new MidiaDigital("E-book: Daisy Jones & The Six", "Taylor Jenkins Reid", 2019, 360);
            biblioteca.AdicionarItem(midiaDigital2);

            biblioteca.EmprestarItem(livro1);
            biblioteca.DevolverItem(livro1);
          
            biblioteca.DevolverItem(livro2);

            biblioteca.EmprestarItem(revista2);

            biblioteca.DevolverItem(midiaDigital2);
        }
    }
}


