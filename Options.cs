using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Livros
{
    public class Options
    {
        public void ShowOptions()
        {
            Console.WriteLine("##### Menu ##### \n");
            Console.WriteLine("1. Cadastrar um Livro");
            Console.WriteLine("2. Consultar Todos Livros");
            Console.WriteLine("3. Consultar um Livro");
            Console.WriteLine("4. Remover um Livro ");
            Console.WriteLine("5. Cadastrar Um Usuário");
            Console.WriteLine("6. Cadastrar um Empréstimo");
            Console.WriteLine("7. Devolver um Livro");
            Console.WriteLine("0. Sair \n");
            Console.WriteLine("################ \n");
        }

        public int ReadChoose()
        {
            Console.Write("Digite um número:");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Por favor, digite um número válido.\n");
                Console.Write("Digite um número:\n");
            }
            return choice;
        }
    }
}