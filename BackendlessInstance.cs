using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendlessAPI;

namespace backendless_console_app
{
    public class BackendlessInstance
    {
        public BackendlessInstance() {
            string appID = ""; // ingrese su app ID aquí
            string apiKey = ""; // ingrese su api key de .NET
            Backendless.InitApp(appID, apiKey);
        }

        public BackendlessUser AgregarUsuario (string name, string email, string pass) { 
            BackendlessUser newUser = new BackendlessUser();
            newUser.SetProperty("login", name);
            newUser.SetProperty("email", email);
            newUser.Password = pass;
            return Backendless.UserService.Register(newUser);
        }
    }
}
