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
namespace PROJEKT.Classes
{
    class logowanie
    {


        public UserList Login()
        {

            Console.Clear();
            UserList _oLista = new UserList();
            User _oUser = new User();
            Menu menu = new Menu();




            if (File.Exists(@"baza_uzytkownikow.xml"))
            {
                _oLista.LoadFromXml(@"baza_uzytkownikow.xml");
            }
            else
            {
                Console.WriteLine("Błąd bazy danych");
            }
            do
            {
                Console.WriteLine("Zaloguj się jako:");
                Console.WriteLine("1 - Lekarz/Administrator.");
                Console.WriteLine("2 - Pacjent");
                int _odp;
                int.TryParse(Console.ReadLine(), out _odp);


                if (_odp == 1 )
                {
                    do
                    {

                        Console.WriteLine("Podaj login:");
                        _oUser.Login = Console.ReadLine().ToLower();

                        if (string.IsNullOrEmpty(_oUser.Login))
                        {
                            Console.WriteLine("Login nie może być pusty!");


                        }
                        else if (_oLista.Collection.Exists(x => x.Login == _oUser.Login))
                        {
                            do
                            {
                                Console.WriteLine("Podaj hasło:");

                                _oUser.Password = Console.ReadLine().ToLower();

                                if (string.IsNullOrEmpty(_oUser.Password))
                                {
                                    Console.WriteLine("Hasło nie może być puste!");

                                }
                                else if (_oLista.Collection.Exists(x => x.Password == _oUser.Password))
                                {
                                    if (_oLista.Collection.Exists(x => x.Login == _oUser.Login && x.Permission == 1))
                                    {
                                        _oLista.Add(new User() { Login = _oUser.Login, Permission = 1 } );

                                        return _oLista;

                                    }
                                    if (_oLista.Collection.Exists(x => x.Login == _oUser.Login && x.Permission == 2))
                                    {
                                        _oLista.Add(new User { Login = _oUser.Login, Permission = 2 });

                                        return _oLista;

                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Błędne hasło");
                                    Console.WriteLine("Czy chcesz sie cofnąć (T/N) ?");
                                    string odp = Console.ReadLine().ToUpper();
                                    if (odp == "T" || odp == "TAK" || odp == "Y" || odp == "YES")
                                    {
                                        break;
                                    }
                                }
                            } while (true);


                        }
                        else
                        {
                            Console.WriteLine("Błedny login");
                            Console.WriteLine("Czy chcesz wyjść z programu (T/N) ?");
                            string odp = Console.ReadLine().ToUpper();
                            if (odp == "T" || odp == "TAK" || odp == "Y" || odp == "YES")
                            {
                                break;
                            }
                        }



                    }
                    while (true);
                }
                else if (_odp == 2)
                {

                    Console.WriteLine("Podaj login:");
                    _oUser.Login = Console.ReadLine().ToLower();

                    if (string.IsNullOrEmpty(_oUser.Login))
                    {
                        Console.WriteLine("Login nie może być pusty!");
                        

                    }
                    else if (!string.IsNullOrEmpty(_oUser.Login))
                    {

                        _oLista.Add(new User { Login = _oUser.Login, Permission = 3 });

                        return _oLista;
                    }
                }
                else
                {
                    Console.WriteLine("Błąd podaj cyfrę 1 lub 2");
                }
            } while (true);
            
            


       

        }

    }
}
