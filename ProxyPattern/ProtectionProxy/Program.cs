using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectionProxy
{
    interface IServer
    {
        void LogIn();
    }

    class Server : IServer
    {
        public void LogIn()
        {
            Console.WriteLine("User logged in");
        }
    }

    public class User
    {
        public string Password { get; set; }

        public User(string password)
        {
            Password = password;
        }
    }

    public class ServerProxy : IServer
    {
        private User _user;
        private IServer server = new Server();
        public ServerProxy(User user)
        {
            _user = user;
        }

        public void LogIn()
        {
            if (_user.Password == "valid")
                server.LogIn();
            else
                Console.WriteLine("User is unable to log in - wrong password");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IServer server = new Server();

            server.LogIn();

            IServer serverProxy = new ServerProxy(new User("valid"));

            serverProxy.LogIn();

            serverProxy = new ServerProxy(new User("invalid"));

            serverProxy.LogIn();

            Console.ReadKey();
        }
    }
}
