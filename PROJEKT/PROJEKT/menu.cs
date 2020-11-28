using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT
{
    public class Menu
    {
        enum Admin
        {
           
        };

        enum Pacjent
        {
            Skonsultuj_swoje_objawy = 1,
            Kurs_pierwszej_pomocy,
            Dowiedz_sie_wiecej_na_temat_COVID_19,
            Obecne_obostrzenia,
            Wyjdź
        };

        public void menuAdmina()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();
                Console.WriteLine("Admin:");
                int i = 1;

                foreach (Admin admin in (Admin[])Enum.GetValues(typeof(Admin)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

                Admin start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');
                bool AdminConfirmed = Enum.TryParse<Admin>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    
                }
            }
        }

        public void menuUsera()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();

                Console.WriteLine("User:");

                int i = 1;

                foreach (Pacjent admin in (Pacjent[])Enum.GetValues(typeof(Pacjent)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

                Pacjent start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');


                bool AdminConfirmed = Enum.TryParse<Pacjent>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case Pacjent.Skonsultuj_swoje_objawy:
                        break;
                    case Pacjent.Kurs_pierwszej_pomocy:
                        break;
                    case Pacjent.Dowiedz_sie_wiecej_na_temat_COVID_19:
                        break;
                    case Pacjent.Obecne_obostrzenia:
                        break;
                    case Pacjent.Wyjdź:
                        break;
                }
            }
        }
    }

}
