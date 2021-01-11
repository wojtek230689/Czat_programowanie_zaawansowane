using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using PROJEKT.Classes.System;
using System.Globalization;

namespace PROJEKT.Classes.Business
{
    [DataContract]
    public class Text : XmlStorage<Text>
    {
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string Submit { get; set; }
        [DataMember]
        public string _Text { get; set; }
        [DataMember]

        public DateTime time { get; set; }



        public override bool InitializeFromObject(Text Object)
        {
            this.From = Object.From;
            this.Submit = Object.Submit;
            this._Text = Object._Text;

            return true;
        }

        public void  SaveAsXml(string a_sFileName)
        {


            using var _log = Log.DEB("Text", a_sFileName);

            try
            {
                using (var _file = new StreamWriter(a_sFileName, append: true))
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



        public static Text LoadFromXml(string a_sFileName)
        {
            using var _log = Log.DEB("Text", "LoadFromXml");



            Text _otext = null;
            try
            {
                _log.PR_DEB($"próba odczytu wiadomości z pliku <{a_sFileName}>...");

                using (var _file = new StreamReader(a_sFileName))
                {
                    var _sStrBuff = _file.ReadToEnd();

                    var _oBuffer = Encoding.UTF8.GetBytes(_sStrBuff);

                    _otext = new Text();

                    _otext.FromXml(new MemoryStream(_oBuffer));


                }

            }
            catch (Exception e)
            {
                _log.PR_DEB($"Błąd! {e.Message}");
            }

            return _otext;
        }



        public static Text Add()
        {
            Text _otext = new Text();


            do
            {

                Console.Write("Podaj Nadawce wiadomości:");
                Console.WriteLine();

                _otext.From = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(_otext.From))
                {
                    Console.WriteLine("Nadawca nie może być pusty!");
                }
                else
                    break;
            }
            while (true);

            do
            {

                Console.Write("Podaj temat wiadomości:");
                Console.WriteLine();
                _otext.Submit = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(_otext.Submit))
                {
                    Console.WriteLine("Temat nie może być pusty!");
                }
                else
                    break;
            }
            while (true);

            do
            {

                Console.Write("Podaj treść wiadomości:");
                Console.WriteLine();

                _otext._Text = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(_otext._Text))
                {
                    Console.WriteLine("Treść nie może być pusta!");
                }
                else
                    break;
            }
            while (true);

            return _otext;
        }

        public override string ToString()
        {
            return $"Czas:{time}Od:={From} \nTytuł:={Submit}\nWiadomość:={_Text}";
        }


    }
}
