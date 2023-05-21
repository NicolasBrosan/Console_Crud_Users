using Domain.Services;

namespace PracticeNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a la aplicación de usuario!!\n");

            Console.Write("Seleccione una de las siguientes opciones:\n1- Crear usuario\n2- Obtener usuario\n3- Modificar usuario\n4- Eliminar usuario\n5- Terminar el programa\n");
            Console.Write("\nIngrese la opción deseada: ");
            var opcion = Console.ReadLine();
            var opcionConvert = int.TryParse(opcion, out int opcionB);

            var newUser = new UserService();

            while (opcionB < 5)
            {

                switch (opcionB)
                {
                    case 1:
                        newUser.Create();
                        break;
                    case 2:
                        newUser.Get();
                        break;
                    case 3:
                        newUser.Update();
                        break;
                    case 4:
                        newUser.Delete();
                        break;
                    default:
                        Console.WriteLine("Gracias! Vuelvas pronto!!");
                        break;
                }

                Console.Write("\nSeleccione una de las siguientes opciones:\n1- Crear usuario\n2- Obtener usuario\n3- Modificar usuario\n4- Eliminar usuario\n5- Terminar el programa\n");
                Console.Write("\nIngrese la opción deseada: ");
                opcion = Console.ReadLine();
                opcionConvert = int.TryParse(opcion, out opcionB);
            }

        }

    }
}