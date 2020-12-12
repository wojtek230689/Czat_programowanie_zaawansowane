using System;

namespace PROJEKT
{
    internal class Cov_19
    {
        public string nazwa = "COVID-19 - ostra choroba zakaźna układu oddechowego wywołana zakażeniem wirusem SARS-CoV-2.\nZostała po raz pierwszy rozpoznana i opisana w listopadzie 2019r. w środkowych Chinach(W mieście Wuhan).\n";
        public string objawy = "Większość pacjętów ma łągodne objawy i dobre rokowania.\nDo typowych objawów choroby zalicza się: GORĄCZKĘ, SUCHY KASZEL, ZMĘCZENIE, PŁYTKI ODDECH oraz UTRATA WĘCHU ORAZ SMAKU.\n";
        public string symptomy = "Rzadko: ODKRZTUSZANIE PLWOCINY, KRWIOPLUCIE, KATAR, DRESZCZE, SPLĄTANIE, BÓL GŁOWY, BIEGUNKA NUDNOŚCI, WYMIOTY, BÓL PLECÓW, UTRATA/ZABURZENIA WĘCHU ORAZ SMAKU\nCzęsto: GORĄCZKA, DUSZNOŚCI, SUCHY KASZEL, BÓL MIĘŚNI LUB ZMĘCZENIE, OSŁABIENIE\nW ostrych przypadkach: INFEKCJA DOLNYCH DRÓG ODDECHOWYCH, ATOPOWE ZAPALENIE PŁUC, PROBLEMY Z ODDYCHANIEM, UTRZYMUJĄCY SIĘ BÓL LUB UCISK W KLATCE PIERSIOWEJ.\n";
        public string przebieg = "Przebieg choroby może być różnorodny.\nWiększość pacjentów (ok. 81%) może przechodzić ją bezobjawowo lub mieć łagodne objawy.\nCzęść pacjentów może mieć ostrą (14%) lub krytyczną (5%) postać choroby co wymaga 3 do 6 tygodniu do wyleczenia.\nU pacjentów z postacią krytyczną, którzy zmarli, czas od wystąpienia objawów do śmierci wynisoł od 2 do 8 tygodni.\n";
        public string leczenie = "Obecnie nie istnieje zatwierdzona do stosowania szczepionka ani celowana metoda leczenia choroby.\nStosuje się leczenie objawowe, podtrzymujące i eksperymentalne.\nLeczenie objawowe zwykle ma na celu opanowanie objawów i wsparcie funkcjonowania organizmu.\n";
        public string powiklania = "Powikłania: ZESPÓŁ OSTREJ NIEWYDOLNOŚCI ODDECHOWEJ, NIEWYDOLNOŚĆ WIELONARZĄDOWA, WIREMIA, OSTRA NIEWYDOLNOŚĆ SERCA, ZABURZENIE ŚWIADOMOŚCI, OSTRE USZKODZENIE NEREK, ZABURZENIE CZYNNOŚCI WĄTROBY, ZAKPRZEPICA ŻYLNA, INFEKCJE WTÓRNE, SEPSA\n";
        public string zapobieganie = "Do podstawowych metod zapobiegania zakażeniom zalicza się:\nDOKŁADNE I CZĘSTE MYCIE DŁONI, UTRZYMYWANIE DYSTANSU FIZYCZNEGO OD OSÓB Z OBJAWAMI GRYPODOPODOBNYMI ORAZ UNIKANIE DOTYKANIA TWARZY NIEMYTYMI DŁOŃMI.\nZaleca się zakrywanie ust oraz nosa podczas kaszlu chusteczką lub zgięciem łokcia.\n ";


        internal void printInfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Nazwa:\n" + nazwa);
            System.Console.WriteLine();
            System.Console.WriteLine("Objawy:\n" + objawy);
            System.Console.WriteLine();
            System.Console.WriteLine("Symptomy:\n" + symptomy);
            System.Console.WriteLine();
            System.Console.WriteLine("Możliwe powikłania:\n" + powiklania);
            System.Console.WriteLine();
            System.Console.WriteLine("Przebieg choroby:\n" + przebieg);
            System.Console.WriteLine();
            System.Console.WriteLine("Leczenie:\n" + leczenie);
            System.Console.WriteLine();
            System.Console.WriteLine("Zapobieganie:\n" + zapobieganie);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Aby wrócić do głównego menu wciśnij dowolny klawisz");
        }
    }
    }
