using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using PROJEKT.Interfaces;

namespace PROJEKT.Classes
{
    public static class XmlStorageTypes
    {
        private static readonly List<Type> KnowingTypes = new List<Type>() { typeof(object) };

        public static void Register<T>()
        {
            Type _oType = typeof(T);

            if (!KnowingTypes.Contains(_oType))
            {
                KnowingTypes.Add(_oType);
            }
        }
        public static Type[] GetArray() => KnowingTypes.ToArray();
    }

    [DataContract]
    public abstract class XmlStorage<T> : IXmlStorage where T : class
    {
        [IgnoreDataMember]
        public T BaseObject { get; protected set; }

        public virtual MemoryStream ToXml(string plik)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oStream = new MemoryStream();

            using var _oWriter = XmlDictionaryWriter.CreateTextWriter(_oStream, Encoding.UTF8);
            
            _oSerializer.WriteObject(_oWriter, this);

            ToFile(_oStream, plik);

            return _oStream;
        }

        public virtual FileStream ToFile(Stream a_oStream, string plik)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());


            using var _oTextStrem = new FileStream(plik, FileMode.Append, FileAccess.Write);

            using var _oTextWriter = XmlDictionaryWriter.CreateTextWriter(_oTextStrem, Encoding.UTF8);

            _oSerializer.WriteObject(_oTextWriter, this);

            return _oTextStrem;

        }

        public virtual bool FromXml(Stream a_oStream)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oReader = XmlDictionaryReader.CreateTextReader(a_oStream, new XmlDictionaryReaderQuotas());


            return InitializeFromObject((T)_oSerializer.ReadObject(_oReader, false));
        }

        public virtual bool FromFile(string filName)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            MemoryStream ms = new MemoryStream();
            using (FileStream fs = File.OpenRead(filName))
            {
                fs.CopyTo(ms);
            }

            using var _oReader = XmlDictionaryReader.CreateTextReader(ms, new XmlDictionaryReaderQuotas());



            return InitializeFromObject((T)_oSerializer.ReadObject(_oReader, false));
        }




        public abstract bool InitializeFromObject(T Object); 
    }
}
