using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Livros
{
    public class Users
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Users> User { get; set; } = new List<Users>();

        public void UserRegister()
        {
            Console.WriteLine("#### Cadastre um usuário ####");

            Console.WriteLine("Digite o nome do usuário:");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Campo nome vazio, por favor digite um nome.");
                name = Console.ReadLine();
            }

            Console.WriteLine("Dgite seu e-mail:");
            var email = Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Campo e-mail vazio, por favor, digite um e-maisl.");
                email = Console.ReadLine();
            }

            Users user = new()
            {
                Id = Id,
                Name = name,
                Email = email,
            };

            User.Add(user);

            Console.WriteLine($"Usuário cadastrado com sucesso!! ID: {user.Id}, Nome: {user.Name}, E-mail: {user.Email}");
        }
    }
}
