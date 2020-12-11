using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT.Classes.Exceptions
{
    public class MessageFactoryTypeNotFound : Exception
    {
        public MessageFactoryTypeNotFound(string a_sTypeName) 
            :base($"Nie odnaleziono typu <{a_sTypeName}> w kolekcji fabryki!")
        {

        }
    }
}
