using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
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

        public virtual MemoryStream ToXml()
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oStream = new MemoryStream();

            using var _oWriter = XmlDictionaryWriter.CreateTextWriter(_oStream, Encoding.UTF8);
            
            _oSerializer.WriteObject(_oWriter, this);

            using var _oTextStrem = new FileStream("plik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using var _oTextWriter = XmlDictionaryWriter.CreateTextWriter(_oTextStrem, Encoding.UTF8);

            _oSerializer.WriteObject(_oTextWriter, this);


            return _oStream;
        }

        public virtual bool FromXml(Stream a_oStream)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oReader = XmlDictionaryReader.CreateTextReader(a_oStream, new XmlDictionaryReaderQuotas());

            return InitializeFromObject((T)_oSerializer.ReadObject(_oReader, false));
        }

        public abstract bool InitializeFromObject(T Object); 
    }
}
