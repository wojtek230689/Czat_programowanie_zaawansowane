using PROJEKT.Classes.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PROJEKT.Classes
{
    class addUser
    {
        private string newLogin;
        private string newPassword;
        private int newPermission;

        public void adding()
        {
             
            bool lo = true;
            do
            {
                Console.WriteLine("Wprowadź login:");
                Console.WriteLine();
                newLogin = Console.ReadLine().ToLower();

                if (newLogin.Length > 2)
                {
                    lo = false;
                }
            } while (lo);

            bool k = true;
            int i;
            do
            {
                Console.WriteLine("Nadaj uprawnienia \n1 - admin \n2 - lekarz");
                int.TryParse(Console.ReadLine(), out i);
                if (i >= 1 && i <= 2)
                {
                    newPermission = i;
                    k = false;
                }

                if (i > 2)
                {
                    Console.WriteLine("Uprawnienia: \n1- admin \n2-lekarz ");
                }
            } while (k);


            bool pa = true;
            do
            {
                Console.WriteLine("Wprowadź hasło:");
                Console.WriteLine();
                newPassword = Console.ReadLine().ToLower();

                if (newPassword.Length > 2)
                {
                    pa = false;
                }

            }
            while (pa);


            Console.Clear();

            UserList _oLista = new UserList();

            if (File.Exists(@"baza_uzytkownikow.xml"))
            {
                _oLista.LoadFromXml(@"baza_uzytkownikow.xml");

                _oLista.Add(new User { Login = newLogin, Password = newPassword, Permission = newPermission });


                _oLista.SaveAsXml(@"baza_uzytkownikow.xml");
            }
            else
            {
                Console.WriteLine("Błąd wczytywania bazy danych przy próbie dodania użytkownika");
            }


        }

    }
}
