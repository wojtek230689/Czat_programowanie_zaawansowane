using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using PROJEKT.Classes;
using PROJEKT.Classes.Messages;
using PROJEKT.Classes.Services;
using PROJEKT.Interfaces;


namespace PROJEKT
{
    public class addUser : XmlStorage<addUser>
    {
        private string Login;
       private SecureString securePwd;
        private int _permisson;

        public string NewLogin1 { get => Login; set => Login = value; }
        public SecureString NewPassword { get => securePwd; set => securePwd = value; }
        public int Permission { get => _permisson; set => _permisson = value; }

        public void Adiing()
        {


            bool t = true;
            while (t)
            {
                Console.WriteLine("Podaj Numer opcji: \n1 - Dodaj użytkownika\n2 - cofnij");
                int j;
                int.TryParse(Console.ReadLine(), out j);
                if (j == 1)
                {
                    string newLogin = "";
                    SecureString newPassword;
                    int permission = 0;




                    if (newLogin.Length > 2)
                    {
                        Console.WriteLine("Wprowadź login:");
                        Console.WriteLine();
                        newLogin = Console.ReadLine().ToLower();


                    }

                    bool k = true;
                    int i;
                    if (i >= 1 && i <= 2)
                    {
                        Console.WriteLine("Nadaj uprawnienia \n1 - admin \n2 - lekarz");
                        int.TryParse(Console.ReadLine(), out i);

                        permission = i;
                        k = false;


                        if (i > 2)
                        {
                            Console.WriteLine("Uprawnienia: \n1- admin \n2-użytkownik ");
                        }
                    }


                    if (newPassword.Length > 2)
                    {
                        Console.WriteLine("Wprowadź hasło:");
                        Console.WriteLine();


                        string passwd = Console.ReadLine();
                     
                        passwd = new System.Net.NetworkCredential(string.Empty, newPassword).Password;




                    }



                }

            }
            NewLogin();

            if (j != 1)
            {
                t = false;
            }
        }


        public override bool InitializeFromObject(addUser Object)
        {
            Login = Object.Login;
            securePwd = Object.securePwd;
            _permisson = Object._permisson;

            return true;
        }



        public NetworkData NewLogin(int a_iBufferSize = NetworkService.BUFFER_SIZE)
        {

            return new NetworkData(a_iBufferSize)
            {
                Buffer = ToXml("login.xml").ToArray()
            };


        }


        public override string ToString()
        {
            return $"[Login={Login}\nPassword={securePwd}\nPermmison={_permisson}]";
        }
    }    } 

