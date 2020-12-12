using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT.Classes.Exceptions
{
    public class StateObjectReferenceIsNull : Exception
    {
        public StateObjectReferenceIsNull() : 
            base("Referencja do obiektu ma wartość null!")
        {
        }
    }
}
