using Domain.Entities;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Domain.Services
{
    public class UserService
    {
        public List<User> Users { get; set; } = new List<User>()
        {   new User()
            {
                Id = 1,
                Name = "Nicolas",
                Mail = "nicolas@gmail.com",
                Password = "Nico1234",
            },
            new User()
            {
                Id = 2,
                Name = "Ariel",
                Mail = "ariel@gmail.com",
                Password = "Ariel1234"
            },
            new User()
            {
                Id = 3,
                Name = "Jonathan",
                Mail = "jonathan@gmail.com",
                Password = "Jona1234"
            }
        };
        public void Create()
        {
            var idPosition = Users[Users.Count - 1].Id;
            var user = new User();

            Console.Write("\nIngresar nombre: ");
            user.Name = Console.ReadLine();
            Console.Write("Ingresar Mail: ");
            user.Mail = Console.ReadLine();
            Console.Write("Ingresar contraseña: ");
            user.Password = Console.ReadLine();

            user.Id = idPosition + 1;

            Users.Add(user);
        }

        public void Get()
        {
            var users = Users.ToList();
            foreach (var user in users)
            {
                Console.WriteLine("Id: " + user.Id + " // " + "Nombre: " + user.Name + " // " + "Mail: " + user.Mail + " // " + "Contraseña: " + user.Password);
            }
        }

        public void Update()
        {
            Console.Write("\nIngresar Id: ");
            var id = int.TryParse(Console.ReadLine(), out int trueId);
            var user = Users.Where(x => x.Id == trueId).FirstOrDefault();
            Console.WriteLine("Id: " + user.Id + " // " + "Nombre: " + user.Name + " // " + "Mail: " + user.Mail + " // " + "Contraseña: " + user.Password);
            Console.WriteLine("Desea modificar este usuario? Si/No");
            var respuesta = Console.ReadLine();

            if(respuesta.ToLower() == "si")
            {
                Console.Write("\nIngresar nombre: ");
                user.Name = Console.ReadLine();
                Console.Write("Ingresar Mail: ");
                user.Mail = Console.ReadLine();
                Console.Write("Ingresar contraseña: ");
                user.Password = Console.ReadLine();
            }
            Console.WriteLine("Id: " + user.Id + " // " + "Nombre: " + user.Name + " // " + "Mail: " + user.Mail + " // " + "Contraseña: " + user.Password);
        }

        public void Delete()
        {
            Console.Write("\nIngresar Id: ");
            var id = int.TryParse(Console.ReadLine(), out int trueId);
            var user = Users.Where(x => x.Id == trueId).FirstOrDefault();
            Console.WriteLine("Id: " + user.Id + " // " + "Nombre: " + user.Name + " // " + "Mail: " + user.Mail + " // " + "Contraseña: " + user.Password);
            Console.Write("Realmente desea eliminar este usuario? Si/No: ");
            var respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Users.Remove(user);

                Console.WriteLine("\nEl usuario ha sido eliminado");
            }
        }

    }
}
