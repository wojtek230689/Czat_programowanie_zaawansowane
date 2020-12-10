using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PROJEKT.Interfaces
{
     public interface ISerializaer
    {
        bool FromXml(Stream Stream);
        MemoryStream ToXml();
    }
}
