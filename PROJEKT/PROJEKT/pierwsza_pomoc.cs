using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT
{
    class Pierwsza_pomoc
    {

        public void porazenie_pradem()
        {

            Console.WriteLine();
            Console.WriteLine("Porażenie Prądem:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Nigdy nie dotykaj osoby porażonej prądem, zanim nie odłączy się jej od źródła prądu! ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("Odłącz bezpieczniki, wyjmij z gniazdka wtyczkę urządzenia elektrycznego, które spowodowało porażenie. " +
                "\nJeśli poziom napięcia jest mniejszy niż 1kV, odsuń kabel elektryczny od poszkodowanego. Użyj do tego przedmiotu, który nie " +
                "\nprzewodzi prądu (np. drewnianego kija od szczotki). ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sprawdź stan poszkodowanego");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Delikatnie dotknij i głośno zapytaj 'Czy wszystko w porządku ?'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Jeśli jest przytomny i oddycha");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Zadzwoń na 112, wezwij pogotowie. ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Zostań z poszkodowanym do czasu przybycia pogotowia i przejęcia opieki nad poszkodowanym. " +
                "\nW miarę możliwości zapewnij mu ciepło, okryj kocem, kurtką. Mów do niego, staraj się go uspokoić, ale i sprawić, " +
                "by nie zasypiał. \nZadawaj pytania. Jeśli nie reaguje udrożnij drogi oddechowe i sprawdź oddech.Jeśli nie jest przytomny, " +
                "ale oddycha ułóż go w pozycji bocznej ustalonej \ni wezwij pogotowie ratunkowe 999 lub 112.Regularnie oceniaj oddech.eśli brak " +
                "oddechu lub nie oddycha prawidłowo poproś kogoś innego o wezwanie pogotowia, \na sam rozpocznij resuscytację.Nie przerywaj jej pod " +
                "żadnym pozorem, aż do odzyskania oddechu lub przybycia Pogotowia Ratunkowego.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Masaż serca jest KONIECZNYM warunkiem przeżycia tej osoby.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Natychmiast rozpocznij reanimację połóż ręce na środku klatki piersiowej." +
                 "Uciskaj mocno na głębokość 5 cm i z częstotliwością 100 / minutę\nPo 30 uciśnięciach wykonaj" +
                 " dwa wdechy - przyłóż szczelnie usta wokół ust poszkodowanego, jednocześnie zaciśnij nos poszkodowanego palcami.\nWdmuchuj powietrze" +
                 " jednostajnie, aż klatka piersiowa się uniesie, gdy klatka piersiowa opadnie, wykonaj następny oddech. 30 uciśnięć 2 wdechy. " +
                 "\nJeśli poszkodowany zaczyna reagować, porusza się, otwiera oczy, oddycha prawidłowo, przerwij resuscytację. Gdy z jakichś względów nie jesteś " +
                 "\nw stanie robić sztucznego oddychania, rób tylko masaż serca. ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Nie przerywaj go, aż do przyjazdu ratowników!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            Console.WriteLine();

            
        }

        public void zawal_serca()
        {
            Console.WriteLine();
            Console.WriteLine("Zawał serca:");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("W przypadku zawału serca najważniejsze jest, aby poszkodowany " +
                 "jak najszybciej znalazł się pod profesjonalną opieką lekarską. \nZanim zacznie się udzielać " +
                 "doraźnej pomocy, należy wezwać pogotowie. Można to zrobić, dzwoniąc na bezpłatny numer 112." +
                 " \nPriorytetem jest natychmiastowe przyjęcie pacjenta do szpitala i wdrożenie profesjonalnej procedury " +
                 "ratunkowej \nz zakresu kardiologii interwencyjnej. Wzywając pogotowie, należy dokładnie opisać objawy " +
                 "poszkodowanego. \nOsoby, które zauważą u siebie objawy zawału serca, a znajdują się same w domu, po zadzwonieniu" +
                 " po karetkę \npowinny otworzyć od razu drzwi do mieszkania, aby ułatwić ratownikom dostanie się do nieruchomości. " +
                 "Przy zawale serca w każdej chwili można stracić przytomność.");

            Console.WriteLine();
            Console.WriteLine("Po wezwaniu karetki pogotowia można przejść do udzielania " +
                 "poszkodowanemu pomocy doraźnej. Jakie są kroki pierwszej pomocy przy ataku serca?");

            Console.WriteLine();

            Console.WriteLine("Poszkodowanego należy ułożyć w pozycji półsiedzącej z uniesionym " +
                  "nieznacznie tułowiem, jego plecy powinny być oparte o coś stabilnego i wygodnego.");

            Console.WriteLine();
            Console.WriteLine("Należy poluzować ubranie np. rozpiąć pasek u spodni, biustonosz, " +
                "zdjąć krawat oraz otworzyć okna – ułatwi to oddychanie; następnie \nwarto zadbać o komfort " +
                "cieplny poszkodowanego, przykrywając go kocem.");


            Console.WriteLine();
            Console.WriteLine("Poszkodowanemu nie można podawać nic do jedzenia ani picia; wskazane jest " +
                 "natomiast podanie leków ograniczających postęp \nmartwicy serca oraz łagodzących dolegliwości bólowe," +
                 " czyli aspiryny, jeśli mamy do niej dostęp. Leki można podać, tylko jeśli pacjent jest przytomny i świadomy.");

            Console.WriteLine();
            Console.WriteLine("W przypadku, gdy nastąpi zatrzymanie czynności życiowych, natychmiast należy rozpocząć resuscytację" +
                 " oddechowo-krążeniową \ni nie przerywać jej do czasu przyjazdu karetki pogotowia; szansę na przeżycie zwiększa już samo uciskanie" +
                 " klatki piersiowej (należy wykonać co najmniej 100 uciśnięć na minutę).");

            Console.WriteLine();
            Console.WriteLine("W miejscach publicznych (dworce, centra handlowe itp.) często można skorzystać z automatycznego" +
                " defibrylatora zewnętrznego (AED); \njeśli jest taka możliwość, należy z niej skorzystać i dążyć do wykonania defibrylacji.");

            Console.WriteLine();
            Console.WriteLine("Przez cały czas udzielania pierwszej pomocy przy zawale (o ile poszkodowany jest świadomy) " +
                "należy zachować spokój i nie straszyć poszkodowanego. \nU wielu osób przy wystąpieniu objawów ataku serca występuje" +
                " bardzo silny lęk przed śmiercią, który może przerodzić się nawet w atak paniki.");

            Console.WriteLine();
            Console.WriteLine();

            


        }

        public void oparzenia()
        {

            Console.WriteLine();
            Console.WriteLine("Oparzenie:");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Pierwszą pomocą przy oparzeniach, niezależnie od rodzaju oparzenia, powinno być " +
                "jak najszybsze schłodzenie oparzonej powierzchni pod zimną, bieżącą wodą przez około 20 minut lub do " +
                "ustania bólu. \nW przypadku kontaktu z powierzchnią oparzoną należy używać rękawiczek. Jeżeli oparzenie dotyczy" +
                " jamy ustnej zaleca się płukanie zimną wodą lub ssanie kostek lodu. Należy pamiętać, \nże chłodzenie oparzonych " +
                "obszarów może powodować dreszcze. Chłodzenie jest tym bardziej skuteczne, im szybciej jest zastosowane od momentu" +
                " oparzenia. W sytuacji gdy dochodzi do oparzenia skóry \ndłoni przed chłodzeniem oparzonej powierzchni należy zdjąć " +
                "biżuterię. Po schłodzeniu należy założyć na oparzone miejsce jałowy opatrunek. Można także stosować opatrunki hydrożelowe, " +
                "\nktóre nie przyklejają się do ran i przyspieszają gojenie.");

            Console.WriteLine();
            Console.WriteLine("W przypadku rozległych oparzeń zewnętrznych lub oparzeń wewnętrznych nie wolno pić i jeść." +
                " Nie należy także zanurzać oparzonej osoby w zbiorniku z wodą ani okładać miejsc oparzonych \nśniegiem lub lodem.");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Błędem jest stosowanie na oparzoną skórę białka jaja kurzego, czy tłuszczu zwierzęcego np.smalcu ponieważ możemy" +
                    " doprowadzić do zakażenia bakteryjnego oparzonej powierzchni skóry.");

            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine();
            Console.WriteLine();

            
        }


        public void zadlawienie()
        {
            Console.WriteLine();
            Console.WriteLine("Zadławienie:");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Pierwszym krokiem jest kontakt z poszkodowanym. " +
                "Należy ocenić jego stan ogólny, jeżelikaszle, trzeba stwierdzić, czy jest on " +
                "efektywny, czyli taki, przy którym reaguje \ni może nabrać powietrza czy kaszel jest " +
                "nieefektywny, w którego trakcie występuje niemożność mówienia, oddychania oraz sinienie." +
                " W drugim przypadku natychmiast \nnależy udzielić osobie pierwszej pomocy. Najistotniejszym" +
                " warunkiem jest sprawdzenie czy poszkodowany jest przytomny. Osobę dorosłą warto najpierw" +
                " skłonić \ndo wymuszenia intensywnego kaszlu. Jeśli jest przytomny i przestał kaszleć to należy " +
                "pochylić go do przodu i pięciokrotnie energicznie uderzyć w okolicę \nmiędzy łopatkami. Jeżeli" +
                " to nie przynosi skutku, trzeba przejść do uciśnięć nadbrzusza, czyli tzw. chwytu " +
                "Heimlicha – nie stosuje się go u kobiet w ciąży. \nNależy pochylić poszkodowanego, objąć go " +
                "rękoma, kładąc jedną rękę pod mostkiem na nadbrzuszu, drugą ręką objąć zaciśniętą w pięść, " +
                "a następnie energicznie \npociągnąć do wnętrza i ku górze. Jeżeli w jamie ustnej  znajdzie się " +
                "tkwiący przedmiot, trzeba go wyjąć. Warto też zabezpieczyć pacjenta przed upadkiem, \numieszczając" +
                " mu stopę między jego stopami i oprzeć go na swym biodrze. Obie opisane powyżej czynności należy " +
                "stosować jedynie w sytuacji, gdy poszkodowany \njest przytomny.W każdym innym przypadku trzeba niezwłocznie " +
                "przystąpić do resuscytacji krążeniowo-oddechowej i wezwać pogotowie ratunkowe.");

            Console.WriteLine();


            Console.WriteLine();

           
        }

        public void pozycjabezpiecznia()
        {
            Console.WriteLine();
            Console.WriteLine("Pozycja bezpieczna:");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine(" - Jeśli poszkodowany nosi okulary - zdejmij je, " +
                "sparwdź także kieszenie czy nie znajdują się w nich np. kluczyki czy inne " +
                "elementy, które mogłyby utrudniać lub przeszkadzać poszkodowanemu!");

            Console.WriteLine();
            Console.WriteLine(" - Ułóż poszkodowanego na plecach, upewnij się czy poszkodowany " +
                "ma wyprostowane nogi i siądź przy nim od tej strony na którą będziesz chciał go obrócić" +
                " \n(kobiety w widocznej ciąży układamy na ich lewy bok);");

            Console.WriteLine();
            Console.WriteLine(" - Rękę z Twojej strony ułóż pod kątem prostym w stosunku do ciała, " +
                "a następnie zegnij do góry w łokciu pod kątem prostym tak, aby dłoń ręki była skierowana" +
                " do góry");

            Console.WriteLine();
            Console.WriteLine(" - Drugą rękę przełóż w poprzek klatki piersiowej i ułóż dłonią w kierunku " +
                "twarzy, tak aby jej zewnętrzna część dotykała brody od Twojej strony;");

            Console.WriteLine();
            Console.WriteLine(" - Drugą swoją ręką złap za dalszą kończynę dolną (noga od drugiej strony) tuż " +
                "powyżej kolana i podciągnij ją ku górze, nie odrywając stopy od podłoża.");

            Console.WriteLine();
            Console.WriteLine(" - Przytrzymując jedną ręką dłoń dociśniętą do policzka, drugą ręką - pociągnij za dalszą" +
                " kończynę dolną tak, by poszkodowany obrócił się na bok w Twoim kierunku.");

            Console.WriteLine();
            Console.WriteLine(" - Ułóż kończynę, za którą pociągnąłeś poszkodowanego w ten sposób, zarówno staw kolanowy" +
                " jak i biodrowy były zgięte pod kątem prostym;");

            Console.WriteLine();
            Console.WriteLine(" - Odchyl lekko do tyłu głowę poszkodowanego, aby udrożnić drogi oddechowe;");

            Console.WriteLine();
            Console.WriteLine(" - W razie potrzeby popraw dłoń pod policzkiem, gdy jest to konieczne by utrzymać głowę w odgięciu;");

            Console.WriteLine();
            Console.WriteLine(" - Regularnie sprawdzaj stan poszkodowanego aż do przyjazdu służb ratowniczych (szczególnie oddech) !!!");

            Console.WriteLine();


            Console.WriteLine();

            
        }
    }
}
