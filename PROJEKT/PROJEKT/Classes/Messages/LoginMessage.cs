using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using PROJEKT.Classes.Services;
using PROJEKT.Interfaces;
namespace PROJEKT.Classes.Messages
{
    [DataContract]
    public class LoginMessage : XmlStorage<LoginMessage>, IMessage
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        private int _permisson { get; set; }

        [DataMember]
        private SecureString securePwd { get; set; }
        [DataMember]
        public Response Response { get; private set; }

        public LoginMessage()
        {
            Login = string.Empty;
            Response = null;
        }

        public LoginMessage(string Login, SecureString securePwd, int _permisson)
        {
            this.Login = Login;
            this.securePwd = securePwd;
            this._permisson = _permisson;
        }
   

        public override bool InitializeFromObject(LoginMessage Object)
        {
            Login = Object.Login;
            Response = Object.Response;

            return true;
        }

        public IMessage ProcessRequest(StateObject Object = null)
        {
            var _client = Object.GetObject<ClientService>();

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


              
                try
                {
                    if (//deserializacja loginu)
                    {
                        if (//deserializacja hasła
                        {
                            Password = Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd))
                        }) == true)
                        {
                            if (loginn.deserialize().IndexOf(new userLogin(login)) == passs.deserialize()
                                    .IndexOf(new userPassword(
                                        Marshal.PtrToStringUni(Marshal.SecureStringToGlobalAllocUnicode(securePwd)))))
                            {

                                //if (_client.HasRegisteredServer)
                                //{
                                //    var _server = _client.GetRegisteredServer<ServerService<ClientService>>();

                                //    if (_server.ConnectedClients.Find(x => x.Identifier == Login) == null)
                                //    {
                                //        _client.Identifier = Login;
                                //        Response = new Response(1, "Zalogowano poprawne\n");

                                //        TextMessage _msg = new TextMessage
                                //        {
                                //            From = "Server\n",
                                //            To = "*",
                                //            Text = $"Na serwerze zalogował się użytkownik <{Login}>\n"
                                //        };

                                //        _server.AsyncSendBroadcast(_msg.AsNetworkData());
                                //    }
                                //    else
                                //    {
                                //        Response = new Response(0, "Uzytkownik o takim loginie juz zalogowany!\n");
                                //    }
                                //}
                                //else
                                //    Response = new Response(0, new Exception("Wyjątek krytyczny\n"));

                                //return this;
                            }
                            if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 1))
                                {
                                    MENU_ menu = new MENU_();
                                    menu.menuAdmina();
                                }

                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 2))
                                {
                                    MENU_ menu = new MENU_();
                                    menu.menuUsera();
                                }
                                if (loginn.deserialize().Exists(x => x.Login == login && x.Permisson == 1))
                                {
                                    MENU_ menu = new MENU_();
                                    menu.menuGoscia();
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
        


        //public IMessage ProcessRequest(StateObject Object = null)
        //{
        //    var _client = Object.GetObject<ClientService>();

        //    if (_client.HasRegisteredServer)
        //    {
        //        var _server = _client.GetRegisteredServer<ServerService<ClientService>>();

        //        if (_server.ConnectedClients.Find(x => x.Identifier == Login) == null)
        //        {
        //            _client.Identifier = Login;
        //            Response = new Response(1, "Zalogowano poprawne\n");

        //            TextMessage _msg = new TextMessage
        //            {
        //                From = "Server\n",
        //                To = "*",
        //                Text = $"Na serwerze zalogował się użytkownik <{Login}>\n"
        //            };

        //            _server.AsyncSendBroadcast(_msg.AsNetworkData());
        //        }
        //        else
        //        {
        //            Response = new Response(0, "Uzytkownik o takim loginie juz zalogowany!\n");
        //        }
        //    }
        //    else
        //        Response = new Response(0, new Exception("Wyjątek krytyczny\n"));

        //    return this;
        //}


        public IMessage ProcessResponse(StateObject Object = null)
        {
            var _client = Object.GetObject<ClientService>();

            if (Response.Object is Exception)
                throw Response.Object as Exception;

            if (Response.Code == 0)
                throw new Exception($"Błąd podczas logowania! {Response}\n");

            if (Response.Code == 1)
            {
                _client.Identifier = Login;

                Console.WriteLine("Zalogowano do systemu!\n");
            }

            return this;                   
        }
        public NetworkData AsNetworkData(int a_iBufferSize = 100000)
        {
            return new NetworkData(a_iBufferSize)
            {

            Buffer = ToXml("plik.xml").ToArray()
            };
        }

 
        public override string ToString()
            {
                return $"[Login={Login}\n|Response={Response}]\n";
            }
    }
} 
