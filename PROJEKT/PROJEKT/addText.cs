using PROJEKT.Classes.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PROJEKT.Classes
{
   public class addText
    {
        private string newFrom;
        private string newSubmit;
        private string newText;

        public void adding()
        {
            addText _otext = new addText();


            do
            {

                Console.Write("Podaj Nadawce wiadomości:");
                Console.WriteLine();

              newFrom = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(newFrom))
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
                newSubmit = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(newSubmit))
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

                newText = Console.ReadLine().ToLower();


                if (string.IsNullOrEmpty(newText))
                {
                    Console.WriteLine("Treść nie może być pusta!");
                }
                else
                    break;
            }
            while (true);
            
            


            Console.Clear();
            TextList _oLista = new TextList();

            if (File.Exists(@"wiadomosci.xml"))
            {
                _oLista.LoadFromXml(@"wiadomosci.xml");

                _oLista.Add(new Text { From = newFrom, Submit = newSubmit, _Text = newText, time = DateTime.Today }); 


                _oLista.SaveAsXml(@"wiadomosci.xml");
            }
            else
            {
                Console.WriteLine("Błąd wczytywania wiadomosci");
            }


        }


      


    }
}
