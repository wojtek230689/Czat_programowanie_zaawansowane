using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT
{



   public class Menu_Pomoc
    {
        enum Pomoc
        {
            Porażenie_prądem = 1,
            Zawał_serca,
            Oparzenie,
            Zadławienie,
            Pozycja_bezpieczna,
            Wyjdź


        };

        public void MenuPomocy()
                        

        {
            Console.Clear();
            Pierwsza_pomoc pomoc1 = new Pierwsza_pomoc();

            bool k = true;
            while (k)
            {
               
                Console.WriteLine("Pierwsza Pomoc:");
                int i = 1;

                foreach (Pomoc pomoc in (Pomoc[])Enum.GetValues(typeof(Pomoc)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(pomoc.ToString().Replace('_', ' ')));
                }

                Pomoc start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');
                bool PomocConfirmed = Enum.TryParse<Pomoc>(choosenOption, out start);

                if (!PomocConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }
                switch (start)
                {
                    case Pomoc.Porażenie_prądem:
                        Console.Clear();
                        pomoc1.porazenie_pradem();
                        break;
                    case Pomoc.Zawał_serca:
                        Console.Clear();
                        pomoc1.zawal_serca();
                        break;
                    case Pomoc.Oparzenie:
                        Console.Clear();
                        pomoc1.oparzenia();
                        break;
                    case Pomoc.Zadławienie:
                        Console.Clear();
                        pomoc1.zadlawienie();
                        break;
                    case Pomoc.Pozycja_bezpieczna:
                        Console.Clear();
                        pomoc1.pozycjabezpiecznia();
                        break;
                    case Pomoc.Wyjdź:
                        Console.Clear();
                        k = false;
                        break;
                    
                }
            }

        }
    }
}
