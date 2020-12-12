using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT
{
    class MENU_
    {

        enum Menu
        {
            Skonsultuj_swoje_objawy = 1,
            Kurs_pierwszej_pomocy,
            Dowiedz_się_więcej_na_temat_COVID19,
            Obecne_obostrzenia,
            Wyjdź
        };
        static void MENU_GLOWNE()
        {
            bool k = true;
            Obecne_obostrzeżenia obecne_Obostrzeżenia = new Obecne_obostrzeżenia();
            Cov_19 cov_19 = new Cov_19();
            while (k)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                int i = 1;

                foreach (Menu menu in (Menu[])Enum.GetValues(typeof(Menu)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(menu.ToString().Replace('_', ' ')));
                }

                Menu start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');
                bool MenuConfirmed = Enum.TryParse<Menu>(choosenOption, out start);

                if (!MenuConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case Menu.Obecne_obostrzenia:
                        obecne_Obostrzeżenia.printInfo();
                        Console.ReadKey();


                        break;
                    case Menu.Kurs_pierwszej_pomocy:


                        break;

                    case Menu.Dowiedz_się_więcej_na_temat_COVID19:
                        cov_19.printInfo();
                        Console.ReadKey();

                        break;
                    case Menu.Wyjdź:

                        k = false;
                        break;
                }
            }
        }
    }
}
