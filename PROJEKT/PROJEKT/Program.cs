using System;
using System.IO;
using System.Linq;
using System.Text;
using PROJEKT.Classes;
using PROJEKT.Classes.Exceptions;
using PROJEKT.Classes.Messages;
using PROJEKT.Interfaces;

namespace PROJEKT
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlStorageTypes.Register<Exception>();
            XmlStorageTypes.Register<StateObject>();
            XmlStorageTypes.Register<Response>();

            MessageFactory.Instance.Register<LoginMessage>();

            Console.Clear();

            if ((args?.Length ?? 0) < 1)
            {
                Console.WriteLine("Brak argumentu uruchomieniowego!\n1 - serwer\n2 - klient");
            }
            else
            {
                int _iMode = 0;

                int.TryParse(args[0], out _iMode);

                switch (_iMode)
                {
                    case 1:
                        new TestServer().Run();  break;

                    case 2:
                        new TestClient().Run(); break;
                }
            }
        }
    }
}
