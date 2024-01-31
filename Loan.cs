using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Livros
{
    public class Loan
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }        
        public DateTime DateLoan { get; set; }
        public DateTime DateReturn { get; set; }    



        public void LoanRegister(Guid userId, Guid bookId)
        {
            Console.WriteLine("Resgistre a data de retirada do livro:");

            Console.Write("Dia: ");
            int day;

            while(!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Dia inexistente, por favor digite novamente.");
            }

            Console.WriteLine("Mês: ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Mês inexistente, por favor digite novamente.");
            }

            Console.Write("Ano: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Ano inexistente, por favor digite novamente.");
            }

            DateTime dateLoan = new DateTime (year, month, day); 
            DateReturn = dateLoan.AddDays(5);

            Loan loan = new()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                BookId = bookId,
                DateLoan = dateLoan,
            };

            Console.WriteLine($"Empréstimo registrado com sucesso ID: {loan.Id}, Usuário: {loan.UserId}, Livro: {loan.BookId}, Data de Retirada: {loan.DateLoan}, Data de Devolução: {DateReturn}");

        }   

        public void BookReturn()
        {
            Console.WriteLine("Registre o livro a ser devolvido");

            Console.Write("Dia: ");
            int day;
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Dia inexistente, por favor digite novamente.");
            }

            Console.Write("Mês: ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Mês inexistente, por favor digite novamente.");
            }

            Console.Write("Ano: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Ano inexistente, por favor digite novamente.");
            }

            DateTime dateReturn = new (year, month, day);

            int delayDays = (int)(dateReturn - DateReturn!).TotalDays;

            if (delayDays > 0)
            {
                Console.WriteLine($"Devolução com {delayDays} dia(s) de atraso.");
            }
            else
            {
                Console.WriteLine("Devolução realizada em dia.");
            }
        }

    }
}
