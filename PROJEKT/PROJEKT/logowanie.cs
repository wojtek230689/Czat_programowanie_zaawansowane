using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using PROJEKT.Classes.Services;
using PROJEKT.Interfaces;

namespace PROJEKT
{
    [DataContract]

    class logowanie
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        private int _permisson { get; set; }

        [DataMember]
        private SecureString securePwd { get; set; }

        public logowanie()
        {
        }

   
        public void log()
        {
            bool t = true;
            while (t)
            {
                Console.Clear();
                Console.WriteLine("Enter Login: ");
                Login = Console.ReadLine();
                Console.WriteLine("Enter Password: ");

                securePwd = new SecureString();
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);

                    // Ignore any key out of range.
                    if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
                    {
                        // Append the character to the password.
                        securePwd.AppendChar(key.KeyChar);
                        Console.Write("*");
                    }

                    // Exit if Enter key is pressed.
                } while (key.Key != ConsoleKey.Enter);

                Console.WriteLine();
                Console.WriteLine();
                SerializationLogin loginn = new SerializationLogin();
                SerializationPassword passs = new SerializationPassword();
                Console.WriteLine(loginn.deserialize().Contains(new userLogin { Login = login }));
                try
                {
                    if (loginn.deserialize().Contains(new userLogin { Login = login }) == true)
                    {
                        if (passs.deserialize().Contains(new userPassword
                        {
                            Password = Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd))
                        }) == true)
                        {
                            if (loginn.deserialize().IndexOf(new userLogin(login)) == passs.deserialize()
                                    .IndexOf(new userPassword(
                                        Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd)))))
                            {

                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 1))
                                {
                                    Menu menu = new Menu();
                                    menu.menuAdmina();
                                }

                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 2))
                                {
                                    Menu menu = new Menu();
                                    menu.menuUsera();
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect login or password");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect login or password");
                    }
                }
                catch (Win32Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    securePwd.Dispose();
                }
            }
        }
    }
}
