using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PROJEKT.Classes
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public int Code { get; private set; }
        [DataMember]
        public object Object { get; private set; }

        public Response(int Code, object Object)
        {
            this.Code = Code;
            this.Object = Object;
        }

        public override string ToString()
        {
            return $"[Kod={Code}\n|Obiekt={Object}]";
        }
    }
}
