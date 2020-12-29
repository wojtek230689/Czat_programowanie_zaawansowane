using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using PROJEKT.Classes;
using PROJEKT.Classes.Database.Objects;
using PROJEKT.Classes.Messages;
using PROJEKT.Classes.Exceptions;
using PROJEKT.Classes.System;
using PROJEKT.Classes.Database;
using System.Collections.Generic;
using PROJEKT.Classes.Business;
namespace PROJEKT
{
    class Program
    {
        static void Main(string[] args)
        {
            



            Console.Clear();



            logowanie logowanie = new logowanie();

            logowanie.Login();


            //UserList _oLista = new UserList();

            //if (File.Exists(@"baza_uzytkownikow.xml"))
            //{
            //    _oLista.LoadFromXml(@"baza_uzytkownikow.xml");
            //}
            //else
            //{
            //    _oLista.Add(new User { Login = "jkuzmicz", Password = "test123", Permission = 2 });
            //    _oLista.Add(new User { Login = "zdyrman", Password = "test123", Permission = 1 });
            //    _oLista.Add(new User { Login = "rochucki", Password = "test123", Permission = 2 });

            //    _oLista.SaveAsXml(@"baza_uzytkownikow.xml");
            //}

            //foreach (var _user in _oLista.Collection)
            //{
            //    Console.WriteLine(_user);
            //}

            //XmlStorageTypes.Register<Exception>();
            //XmlStorageTypes.Register<StateObject>();
            //XmlStorageTypes.Register<Response>();

            //MessageFactory.Instance.Register<LoginMessage>();
            //MessageFactory.Instance.Register<TextMessage>();

            //Console.Clear();
            //var _oUser = User.LoadFromXml(@"user.xml");
            //Console.WriteLine(_oUser);


            //User.Add().SaveAsXml("user.xml");



            //User.Add().text("user.txt");



            /*

            Console.Clear();

            if ((args?.Length ?? 0) < 1)
            {
                Console.WriteLine("Brak argumentu uruchomieniowego!\n1 - serwer\n2 - klient");
            }
            else
            {
                int _iMode = 0;

                int.TryParse(args[0], out _iMode);

                XmlStorageTypes.Register<Exception>();

                MessageFactory.Instance.Register<LoginMessage>();
                MessageFactory.Instance.Register<TextMessage>();

                switch (_iMode)
                {
                    case 1:
                        new TestServer().Run(); break;

                    case 2:
                        new TestClient().Run(); break;
                }
            }
            */
        }
    }
}
