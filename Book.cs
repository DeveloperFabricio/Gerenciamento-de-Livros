using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Livros
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Author { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public string YearOfPublication { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

        public void BookRegister()
        {
            Console.WriteLine("Cadastro do Livro\n");

            Console.WriteLine("Digite o Título:");
            var title = Console.ReadLine();

            if (string.IsNullOrEmpty(Title))
            {
                Console.WriteLine("Título vazio, por favor digite um título válido.");
                title = Console.ReadLine();
            }
            Console.WriteLine("Digite o nome do Autor:");
            var author = Console.ReadLine();

            if (string.IsNullOrEmpty(Author))
            {
                Console.WriteLine("Autor vazio, por favor digite um Autor válido.");
                author = Console.ReadLine();
            }
            Console.WriteLine("Digite a ISBN do livro:");
            var iSBN = Console.ReadLine();

            if (string.IsNullOrEmpty(iSBN))
            {
                Console.WriteLine("ISBN vazia, por favir digite uma ISBN válida.");
                iSBN = Console.ReadLine();
            }
            Console.WriteLine("Digite o ano da publicação:");
            var yearOfPublication = Console.ReadLine();

            int soughtYear;
            while (!int.TryParse(yearOfPublication, out soughtYear) || soughtYear < 0)
            {
                Console.WriteLine("Ano inválido, por favor digite um ano válido.");
                yearOfPublication = Console.ReadLine();
            }

            Book newBook = new()
            {
                Id = Id,
                Title = title,
                Author = author,
                ISBN = iSBN,
                YearOfPublication = yearOfPublication
            };

            Books.Add(newBook);

            Console.WriteLine("Livro cadastrado com sucesso.\n");
        }

        public void BooksList()
        {
            if(Books.Count > 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }

            Console.WriteLine("===== Livros que já foram cadastrados =====");
            foreach(var book in Books)
            {
                Console.WriteLine($"ID: {book.Id}, Título: {book.Title}, Autor: {book.Author}, ISBN: {book.ISBN}, Ano de Publicação: {book.YearOfPublication}");
            }
            
        }

        public void BookSearch()
        {
            Console.WriteLine("Digite o Nome do Livro:");
            var titleSearch = Console.ReadLine();

            if (string.IsNullOrEmpty (titleSearch))
            {
                Console.WriteLine("Nome vazio, por favor digite um título válido.");
                titleSearch = Console.ReadLine();
            }

            bool foundBook = false;

            foreach (var book in Books)
            {
                if (book.Title.Equals (titleSearch, StringComparison.InvariantCultureIgnoreCase) == true) 
                {
                    Console.WriteLine($"Livro:\nID: {book.Id}, Título: {book.Title}, Autor: {book.Author}, ISBN: {book.ISBN}, Ano de Publicação: {book.YearOfPublication}");
                    foundBook = true;
                    break;
                }
            }
            if (!foundBook)
            {
                Console.WriteLine("Livro naõ econtrado.");
            }
        }

        public void BookRemove()
        {
            Console.WriteLine("Digite o Nome do Livro:");
            var bookRemove = Console.ReadLine();

            if(string.IsNullOrEmpty(bookRemove))
            {
                Console.WriteLine("Nome vazio, por favor digite um nome válido.");
                return;
            }

            Book BookToRemove = null;

            for(int i = Books.Count - 1; i >= 0;  i--) 
            {
                var book = Books[i];

                if(book.Title.Equals (bookRemove, StringComparison.OrdinalIgnoreCase)== true)
                {
                    BookToRemove = book;
                    Books.RemoveAt(i);

                    Console.WriteLine($"Livro deletado:\nID: {book.Id}, Título: {book.Title}, Autor: {book.Author}, ISBN: {book.ISBN}, Ano de Publicação: {book.YearOfPublication}");
                    break;
                }
            }
            if (BookToRemove == null) 
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}
