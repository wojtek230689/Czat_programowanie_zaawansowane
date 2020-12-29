using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using PROJEKT.Classes.Services;
using PROJEKT.Classes;
using PROJEKT.Interfaces;
using PROJEKT.Classes.Business;



namespace PROJEKT
{
    public class Menu 
    {
        enum Admin
        {
            Dodaj_lekarza = 1,
            Odczytaj_wiadomość_od_lekarza,
            Wyjdź


        };

        enum Pacjent
        {
            Skonsultuj_swoje_objawy = 1,
            Kurs_pierwszej_pomocy,
            Dowiedz_sie_wiecej_na_temat_COVID_19,
            Obecne_obostrzenia,
            Wyjdź
        };

        enum Lekarz
        {
            Zostaw_wiadomość_administratorowi = 1,
            Wejdź_do_czatu,
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
                    case Admin.Dodaj_lekarza:
                        break;
                    case Admin.Odczytaj_wiadomość_od_lekarza:
                        break;
                    case Admin.Wyjdź:
                        k = false;
                        break;
                }
            }
        }

        public void menuUsera()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();

                Console.WriteLine("Menu:");

                int i = 1;

                foreach (Pacjent user in (Pacjent[])Enum.GetValues(typeof(Pacjent)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(user.ToString().Replace('_', ' ')));
                }

                Pacjent start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');


                bool AdminConfirmed = Enum.TryParse<Pacjent>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                    Thread.Sleep(1000);

                }
                int wybor = 0;
                switch (start)
                {
                    case Pacjent.Skonsultuj_swoje_objawy:
                        {
                            Console.WriteLine("Jakie masz objawy?");
                            Console.WriteLine("1. Przeziębienie lub grypa");
                            Console.WriteLine("2. Złamanie/stłuczenie");
                            Console.WriteLine("3. Zatrucie");
                            Console.WriteLine("4. Inne");
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor == 1)
                            {
                                Console.WriteLine("Czy masz gorączkę, kaszel i katar? Czy miałeś kontakt z osobą zarażoną COVID-19?");
                                Console.WriteLine("1. Tak");
                                Console.WriteLine("2. Nie");
                                int grypa1 = int.Parse(Console.ReadLine());
                                if (grypa1 == 1)
                                {
                                    Console.WriteLine("Prawdopodobnie jesteś zarażony koronawirusem. Łączymy z lekarzem.");
                                    // POŁĄCZENIE Z LEKARZEM //
                                }
                                else if (grypa1 == 2)
                                {
                                    Console.WriteLine("To prawdopodobnie grypa lub przeziębienie. Jeżeli objawy są nasilone zalecamy kontakt z lekarzem");
                                    Console.WriteLine("1. Chcę porozmawiać z lekarzem");
                                    Console.WriteLine("2. Kończymy na dzisiaj");
                                    int grypa2 = int.Parse(Console.ReadLine());
                                    if (grypa2 == 1)
                                    {
                                        // POŁĄCZENIE Z LEKARZEM //
                                    }
                                    else if (grypa2 == 2)
                                    {
                                        Console.WriteLine("Dziękujemy za skorzystanie z czatu, wracam do menu. Naciśnij przycisk, żeby zakończyć");

                                        k = false;
                                    }
                                }

                            }
                            else if (wybor == 2)
                            {
                                Console.WriteLine("1. Podejrzewasz złamanie?");
                                Console.WriteLine("2. Podejrzewasz stłuczenie?");
                                int grypa1 = int.Parse(Console.ReadLine());
                                if (grypa1 == 1)
                                {
                                    Console.WriteLine("Czy możesz ruszać");
                                    Console.WriteLine("1. Tak");
                                    Console.WriteLine("2. Nie");
                                    int zlamanie1 = int.Parse(Console.ReadLine());
                                    if (zlamanie1 == 1)
                                    {

                                        Console.WriteLine("To najprawdopodobniej stłuczenie.Przy większym bólu należy posmarować miejsce maścią przeciwbólową.Jeżeli po tygodniu ból nie zmniejszy się to skontaktuj się z lekarzem w sprawie prześwietlenia");
                                        Console.WriteLine("Czy chcesz skonsultować się z lekarzem teraz?");
                                        Console.WriteLine("1. Tak");
                                        Console.WriteLine("2. Nie");
                                        int zlamanie2 = int.Parse(Console.ReadLine());
                                        if (zlamanie2 == 1)
                                        {
                                            //POŁĄCZENIE Z LEKARZEM//
                                        }
                                        else if (zlamanie2 == 2)
                                        {
                                            Console.WriteLine("Dziękujemy za skorzystanie z czatu, wracam do menu. Naciśnij przycisk, żeby zakończyć");
                                            Console.ReadKey();
                                            k = false;
                                        }
                                    }
                                }
                                else if (grypa1 == 2)
                                {
                                    Console.WriteLine("Czy możesz ruszać");
                                    Console.WriteLine("1. Tak");
                                    Console.WriteLine("2. Nie");
                                    int zlamanie1 = int.Parse(Console.ReadLine());
                                    if (zlamanie1 == 1)
                                    {

                                        Console.WriteLine("To może być złamanie. Należy skonsultować się z lekarzem");
                                        //POŁĄCZENIE Z LEKARZEM//
                                    }
                                    else if (zlamanie1 == 2)
                                    {
                                        Console.WriteLine("To najprawdopodobniej stłuczenie. Przy większym bólu należy posmarować miejsce maścią przeciwbólową. Jeżeli po tygodniu ból nie zmniejszy się to skontaktuj się z lekarzem w sprawie prześwietlenia");
                                        Console.WriteLine("Dziękujemy za skorzystanie z czatu, wracam do menu. Naciśnij przycisk, żeby zakończyć");

                                        Console.ReadKey();
                                        k = false;
                                    }
                                }

                            }
                            else if (wybor == 3)
                            {
                                Console.WriteLine("Jakie są objawy?");
                                Console.WriteLine("1. nudności, wymioty, ból brzucha i biegunka");
                                Console.WriteLine("2. gorączka, wzdęcia, złe samopoczucie, bóle mięśni, ogólne osłabienie, krwawe stolce, dreszcze, zimne poty, skąpomocz oraz odwodnienie");
                                int zatrucie = int.Parse(Console.ReadLine());
                                if (zatrucie == 1)
                                {
                                    Console.WriteLine("Czy objawy są silne lub występują dłuższy czas (48h+)");
                                    Console.WriteLine("1. Tak");
                                    Console.WriteLine("2. Nie");
                                    int zatrucie1 = int.Parse(Console.ReadLine());
                                    if (zatrucie1 == 1)
                                    {

                                        Console.WriteLine("Jeżeli objawy występują dłużej lub są nasilone należy skonsultować sprawę z lekarzem");
                                        Console.WriteLine("Połączymy Cię teraz z lekarzem");
                                        //POŁĄCZENIE Z LEKARZEM//

                                    }
                                    else if (zatrucie1 == 2)
                                    {
                                        Console.WriteLine("Zatrucie pokarmowe z delikatnymi objawami nie wymaga specjalistycznego leczenia. W celu poprawienia samopoczucia zaleca się częste spożywanie małej ilości płynów, najlepiej zawierających elektrolity. Przy zatruciach bakteryjnych pomocne są preparaty przywracające prawidłową florę bakteryjną (probiotyki). oraz preparaty adsorbujące z przewodu pokarmowego szkodliwe substancje (w tym toksyny i bakterie). Osoby dorosłe mogą doraźnie przyjąć leki zapierające, hamujące perystaltykę jelit. Jeśli objawy są uciążliwe i nie ustępują po kilku dniach należy zwrócić się do lekarza.");
                                        Console.WriteLine("Czy połączyć z lekarzem?");
                                        Console.WriteLine("1. Tak");
                                        Console.WriteLine("2. Nie");
                                        int zatrucieLekarz = int.Parse(Console.ReadLine());
                                        if (zatrucieLekarz == 1)
                                        {
                                            //POŁĄCZENIE Z LEKARZEM//
                                        }
                                        else if (zatrucieLekarz == 2)
                                        {
                                            Console.WriteLine("Dziękujemy za skorzystanie z czatu, wracam do menu. Naciśnij przycisk, żeby zakończyć");

                                            k = false;
                                        }

                                    }
                                }
                                else if (zatrucie == 2)
                                {
                                    Console.WriteLine("Te objawy wskazują na silne zatrucie i należy skontaktować się z lekarzem. Następuje łączenie...");
                                    //POŁĄCZENIE Z LEKARZEM//

                                }

                            }
                            else if (wybor == 4)
                            {
                                Console.WriteLine("Łączę z dostępnym lekarzem");

                                // POŁĄCZENIE Z LEKARZEM //


                            }
                        }
                        break;
                    case Pacjent.Kurs_pierwszej_pomocy:
                        break;
                    case Pacjent.Dowiedz_sie_wiecej_na_temat_COVID_19:
                        break;
                    case Pacjent.Obecne_obostrzenia:
                        break;
                    case Pacjent.Wyjdź:
                        k = false;
                        break;
                }
            }
        }
        public void menuLekarza()
        {

            bool k = true;
            while (k)
            {
                Console.Clear();
                Console.WriteLine("Lekarz:");
                int i = 1;

                foreach (Lekarz lekarz in (Lekarz[])Enum.GetValues(typeof(Lekarz)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(lekarz.ToString().Replace('_', ' ')));
                }

                Lekarz start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');
                bool LekarzConfirmed = Enum.TryParse<Lekarz>(choosenOption, out start);

                if (!LekarzConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case Lekarz.Zostaw_wiadomość_administratorowi:
                        break;
                    case Lekarz.Wejdź_do_czatu:
                        break;
                    case Lekarz.Wyjdź:
                        k = false;
                        break;
                }
            }
        }
    }

}
