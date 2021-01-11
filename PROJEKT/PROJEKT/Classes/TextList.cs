using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using PROJEKT.Classes.System;

namespace PROJEKT.Classes.Business
{
    [DataContract]
    public class TextList : XmlStorage<TextList>
    {
        [DataMember]
        private List<Text> TextCollection { get; set; }

        public TextList()
        {
            TextCollection = new List<Text>();
        }

        public override bool InitializeFromObject(TextList Object)
        {
            this.TextCollection = new List<Text>(Object.TextCollection);

            return true;
        }

        public virtual void SaveAsXml(string a_sFileName)
        {
            using var _log = Log.DEB(this, "SaveAsXml");

            try
            {
                using (var _file = new StreamWriter(a_sFileName))
                {
                    var _sStrBuff = Encoding.UTF8.GetString(ToXml().ToArray());

                    _log.PR_DEB(_sStrBuff);

                    _file.Write(_sStrBuff);
                }
            }
            catch (Exception e)
            {
                _log.PR_DEB($"Błąd! {e.Message}");
            }
        }

        public virtual void LoadFromXml(string a_sFileName)
        {
            using var _log = Log.DEB(this, "LoadFromXml");

            try
            {
                _log.PR_DEB($"próba odczytu wiadomości z pliku <{a_sFileName}>...");

                using (var _file = new StreamReader(a_sFileName))
                {
                    var _sStrBuff = _file.ReadToEnd();

                    var _oBuffer = Encoding.UTF8.GetBytes(_sStrBuff);

                    var _oTextList = new TextList();

                    _oTextList.FromXml(new MemoryStream(_oBuffer));

                    this.InitializeFromObject(_oTextList);

                }
            }
            catch (Exception e)
            {
                _log.PR_DEB($"Błąd! {e.Message}");
            }
        }

        public virtual Text Add(Text a_oText)
        {
            TextCollection.Add(a_oText);

            return a_oText;
        }
        public virtual Text Add() => Add(Text.Add());
        public virtual Text Get(int a_iIndex) => TextCollection[a_iIndex];
        public virtual int Count => TextCollection.Count;
        public List<Text> Collection => TextCollection;
    }
}