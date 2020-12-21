using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
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
        public Response Response { get; private set; }

        public LoginMessage()
        {
            Login = string.Empty;
            Response = null;
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

            if (_client.HasRegisteredServer)
            {
                var _server = _client.GetRegisteredServer<ServerService<ClientService>>();

                if (_server.ConnectedClients.Find(x => x.Identifier == Login) == null)
                {
                    _client.Identifier = Login;
                    Response = new Response(1, "Zalogowano poprawne\n");

                    TextMessage _msg = new TextMessage
                    {
                        From = "Server\n",
                        To = "*",
                        Text = $"Na serwerze zalogował się użytkownik <{Login}>\n"
                    };

                    _server.AsyncSendBroadcast(_msg.AsNetworkData());
                }
                else
                {
                    Response = new Response(0, "Uzytkownik o takim loginie juz zalogowany!\n");
                }
            }
            else
                Response = new Response(0, new Exception("Wyjątek krytyczny\n"));

            return this;
        }

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

            Buffer = ToXml("system.xml").ToArray()
            };
        }
        public override string ToString()
        {
            return $"[Login={Login}\n|Response={Response}]\n";
        }
    }
}
