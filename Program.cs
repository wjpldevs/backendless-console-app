using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendless_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.WriteLine("Correo del usuario: ");
            string emailUsuario = Console.ReadLine();

            Console.WriteLine("Contrasenia del usuario: ");
            string passUsuario = Console.ReadLine();

            BackendlessInstance backendless = new BackendlessInstance();

            var usuario = backendless.AgregarUsuario(nombreUsuario, emailUsuario, passUsuario);

            Console.WriteLine("Usuario registrado {0}", usuario.Properties["objectId"]);

            Console.ReadKey();
        }
    }
}
