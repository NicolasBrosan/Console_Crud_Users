using Domain.Entities;

namespace Domain.Services
{
    public class CreateUser
    {
        public List<User> Create()
        {
            foreach (var user in User)
            {
                User userCreate = new User();

                Console.WriteLine($"Ingresar nombre: {user.Name}");

            }


        }
    }
}
