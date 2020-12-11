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

        public static void Register<T>() where T : class
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
        public abstract bool InitializeFromObject(T Object);

        public virtual MemoryStream ToXml()
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oStream = new MemoryStream();

            using var _oWriter = XmlDictionaryWriter.CreateTextWriter(_oStream, Encoding.UTF8);

            _oSerializer.WriteObject(_oWriter, this);



            using (FileStream file = new FileStream("file.TXT", FileMode.Create, FileAccess.Write))
                _oStream.CopyTo(file);


            return _oStream;
        }

        public virtual bool FromXml(Stream a_sStream)
        {
            DataContractSerializer _oSerializer = new DataContractSerializer(typeof(T), XmlStorageTypes.GetArray());

            using var _oReader = XmlDictionaryReader.CreateTextReader(a_sStream, new XmlDictionaryReaderQuotas());

            return InitializeFromObject((T)_oSerializer.ReadObject(_oReader, false));
        }
    }
}
