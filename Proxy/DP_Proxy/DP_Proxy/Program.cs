using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Proxy
{
    class Program
    {
        class User
        {
            public string Username { get; set; }

            public bool IsAdmin { get; set; }

        }

        interface ILoginService
        {
            void Login(User user);
        }

        class Server : ILoginService
        {
            public void Login(User user)
            {
                Console.WriteLine("login successfuly");
            }
        }

        class ProxyServer : ILoginService
        {
            private Server _server;

            public ProxyServer()
            {
                _server = new Server();
            }

            public void Login(User user)
            {
                if (user.IsAdmin)
                    _server.Login(user);
                else
                    Console.WriteLine("Incorrect account");
            }
        }
        static void Main(string[] args)
        {
            User user = new User { IsAdmin = false, Username = "user" };
            User admin = new User { IsAdmin = true, Username = "admin" };
            ProxyServer proxy = new ProxyServer();
            proxy.Login(admin);
        }
    }
}
