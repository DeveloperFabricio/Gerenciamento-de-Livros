using Gerenciamento_de_Livros;

class Program
{
    static void Main()
    {
        Options options = new();
        Book book = new();
        Users users = new();
        Loan loan = new();

        do
        {
            options.ShowOptions();
            int choice = options.ReadChoose();

            switch (choice)
            {
                case 1:
                    book.BookRegister();
                    break;
                case 2: 
                    book.BooksList();
                    break;
                case 3:
                    book.BookSearch();
                    break;
                case 4:
                    book.BookRemove();
                    break;
                case 5:
                    users.UserRegister();
                    break;
                case 6:
                    loan.LoanRegister(users.Id, book.Id);
                    break;
                case 7:
                    loan.BookReturn();
                    break;
                case 0:
                    Console.WriteLine("Sair, Até logo!!");
                    break;
                default:
                    Console.WriteLine("Número Inválido, digite novamente.");
                    break;


            }
        } while (true);
    }
}