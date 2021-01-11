namespace PROJEKT
{
    internal class Obecne_obostrzenia
    {
        public string ograniczenia = "1,5 METRA – MINIMALNA ODLEGŁOŚĆ MIĘDZY PIESZYMI";
        public string maseczki = "Zasłanianie ust i nosa w miejscach publicznych jest obowiązkowe w całym kraju.";
        public string kwarantanna = "Kwarantanna trwa 10 dni, jeśli w jej trakcie nie wystąpiły objawy COVID-19.\nOdstąpiono od testowania osób bezobjawowych w kwarantannie. Jeśli dana osoba nie miała bezpośredniego kontaktu z osobą zakażoną koronawirusem nie zostanie skierowana na kwarantannę.\nZgodnie z obowiązującym prawem osoby współzamieszkujące z osobą na kwarantannie nie podlegają już kwarantannie.\nOsoba współzamieszkująca z osobą zakażoną wirusem SARS-CoV-2 (pozytywny wynik testu) ma obowiązek poddania się kwarantannie od dnia uzyskania pozytywnego wyniku testu do 7 dni po zakończeniu izolacji osoby zakażonej.\nPoddania się kwarantannie nie stosuje się do osoby wykonującej zawód medyczny.\nPrzez ten czas: NIE MOŻNA OPUSZCZAĆ DOMU, SPACERY Z PSEM, WYJŚCIE DO SKLEPU CZY DO LEKARZA SĄ ZAKAZANE. ";
        public string zycie_spoleczne = "Działalność placówek kultury w tym min. teatrów, kin, muzeów, galerii sztuk, domów kultury, jest zawieszona.";
        public string opieka_i_edukacja = "Uczniowie wszystkich klas szkół podstawowych, wszystkich klas szkół ponadpodstawowych, słuchacze placówek kształcenia ustawicznego oraz centrów kształcenia zawodowego, uczą się zdalnie.\n!UWAGA! Przedszkola funkcjonują bez zmian.";
        public string granice_miedzynarodowe = "W Polska obowiązuje ruch graniczny w ramach granic wewnętrznych Unii Europejskiej.\nOznacza to, że można podróżować i przekraczać granice wewnętrzne UE.\nPodróżni mają prawo do swobodnego wjazdu, wyjazdu oraz tranzytu przez terytorium RP. Nie muszą odbywać kwarantanny.\nPlanując podróż zagraniczną, należy uwzględnić obostrzenia obowiązujące w kraju sąsiednim.Ograniczenie dotyczy przekraczania zewnętrznej granicy UE przez cudzoziemców.";
        public string gospodarka = "Zostaje ograniczone funkcjonowanie galerii handlowych i parków handlowych.\nOtwarte pozostają tylko niektóre punkty usługowe, które mają istotne znaczenia dla życia codziennego (np. usługi fryzjerskie, kosmetyczne, medyczne)\noraz apteki, punkty apteczne, sklepy z artykułami spożywczymi, kosmetycznymi, toaletowymi oraz środkami czystości, artykułami remontowo-budowlanymi, artykułami dla zwierząt, gazetami lub książkami.";
        public string seniorzy = "Od poniedziałku do piątku w godzinach 10:00 – 12:00 w sklepie, drogerii, aptece oraz na poczcie mogą przebywać wyłącznie osoby powyżej 60. roku życia.";


        public void printInfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Ograniczenia na dzień 12 grudnia 2020");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Ograniczenia: " + ograniczenia);
            System.Console.WriteLine();
            System.Console.WriteLine("Maseczki: " + maseczki);
            System.Console.WriteLine();
            System.Console.WriteLine("Kwarantanna: " + kwarantanna);
            System.Console.WriteLine();
            System.Console.WriteLine("Życie Społeczne: " + zycie_spoleczne);
            System.Console.WriteLine();
            System.Console.WriteLine("Opieka i Edukacja: " + opieka_i_edukacja);
            System.Console.WriteLine();
            System.Console.WriteLine("Granice: " + granice_miedzynarodowe);
            System.Console.WriteLine();
            System.Console.WriteLine("Gospodarka: " + gospodarka);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("*Seniorzy: " + seniorzy);
            System.Console.WriteLine();
            

        }

    }
}