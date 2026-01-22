using System;

namespace SWITCHCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt kas ta soovib omale uut autot
            //kui ei, siis programm lõppeb kasutajale sõnumiga "headaega"
            //kui jah, siis küsi kasutajalt milline automudel talle meeldib
            //erista switch case abil:
            //  kui talle meeldib audi - siis ütle audi on noormuttidele
            //  kui talle meeldib volkswagen - siis ütle autobahn on su elu ja armastus
            //  kui talle meeldib lada - siis ütle ah käi potilaadale!
            //  kui talle meeldib mustang - hobustele autokuuris asja pole
            //  kui talle meeldib opel - siis ütle opeleeri kuskil mujal
            //  kui talle meeldib programmi kirjutaja lemmikmark - OPPA, SEE JUBA LÄHEB
            //(kui eelnevalt oli ülesande kirjelduses programmeerija lemmikmark, siis asenda seal see mark millegi muuga)

            //küsi kasutajalt millises riigis talle meeldiks elada
            //valikuteks anna talle: ei tea, Eesti, Läti, Leedu, saksamaa, poola, ukraina.
            //erista switch case abil riik, ning prindi konsooli selle riigi lipu jagu ridu, mis on värvitud console.backgroundcolor meetodiga
            //lipuvärve vaata googlest, kasuta võimalikult sarnaseid vasteid, üks lipp on 6 rida,
            //et kolmese triibuga lippe saaks teha (&/3=2 rida per triip)ja kahe triibuga lippe saaks teha (6/2 =3 rida per triip

            //küsi kasutajalt kas ta õpib koolis
            //kui ei, siis programm lõppeb kasutajale sõnumiga "edu tööturul"
            //kui jah, siis küsi kasutajalt mitmendas klassis ta käib
            //tee muutuja "vastus" mis hoiab meeles kasutaja vastust
            //kui klass, kus õpilane parasjagu on, asub vahemikus 1-4, siis
            //      erista switch case abil:
            //          esimeses klassis - küsi muutujasse "vastus" küsimusele "kelleks sa saada tahad?" sisend.
            //          teises klassis - küsi muutujasse "vastus" küsimusele "kas sulle koolis meeldib õppida?" sisend.
            //          kolmandas klassis - küsi muutujasse "vastus" küsimusele "kuidas kolmandas klassis läheb?" sisend.
            //          neljandas klassis - küsi muutujasse "vastus" küsimusele "kas koolis kiusatakse sind?" sisend.
            //kui klass, kus õpilane parasjagu on, asub vahemikus 5-8, siis
            //      erista switch case abil:
            //          viiendas klassis - küsi muutujasse "vastus" küsimusele "kirjuta oma sõnadega murdvõrrandi valem" sisend.
            //          kuuendas klassis - küsi muutujasse "vastus" küsimusele "kas kohustuslik kirjandus meeldib, või on ajaraiskamine?" sisend.
            //          seitsmendas klassis - küsi muutujasse "vastus" küsimusele "Kas põhikool on raske, või lihtne" sisend.
            //          kaheksandas klassis - küsi muutujasse "vastus" küsimusele "kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?" sisend.
            //kui klass, kus õpilane parasjagu on, asub kõrgemal kui 8 klass, siis:
            //küsi kasutajalt niikaua kuni muutuja "vastus" tühi ei ole (tsüklis) "mis pärast kooli lõpetamist plaanis on?"
            //anna talle valikuks "ei tea", "ei kavatse kooli lõpetada", "oma vastus"
            //tsükkel käib niikaua kuni vastuses midagi on.
            //erista switch case abil:
            //  kui ta ei tea - kuva sõnum "loodan et see idee ka ükspäev tuleb"
            //  kui ei kavatse - kuva sõnum "see on halb otsus. mul on sinust kahju :c"
            //  kõige muu puhul - "oh, see on hea asi teha :D" ja sõnumisse kuvatakse kasutaja vastus muutujast vastus
            //viimase sõnumina kuva "Küsitlusprogramm sulgub, viimane sisestatud vastus" ning lisa juurde muutuja vastus sisu
            
            Console.WriteLine("kas ta soovib omale uut autot (JAH/EI)");
            string küsi = Console.ReadLine();
            if (küsi == "JAH" || küsi == "jah")
            {
                Console.WriteLine("hästi");
            }
            else 
            {
                Console.WriteLine("headaega");
                Environment.Exit(0);  //see on exit programm
            }
            Console.WriteLine("kasutajalt milline automudel talle meeldib?");
            Console.WriteLine("1. Audi");
            Console.WriteLine("2. Volkswagen");
            Console.WriteLine("3. Lada");
            Console.WriteLine("4. Mustang");
            Console.WriteLine("5. Opel");
            Console.WriteLine("6. Buss");
            int auto = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (auto <= 6 && auto > 0) { break; }
                else 
                {
                    Console.WriteLine("proovi veel");
                    auto = Convert.ToInt32(Console.ReadLine());
                }
                
            }


            switch (auto)
            {
                case 1:
                    Console.WriteLine("audi on noormuttidele");
                    break;
                case 2:
                    Console.WriteLine("autobahn on su elu ja armastus");
                    break;
                case 3:
                    Console.WriteLine("ah käi potilaadale!");
                    break;
                case 4:
                    Console.WriteLine("hobustele autokuuris asja pole");
                    break;
                case 5:
                    Console.WriteLine("opeleeri kuskil mujal");
                    break;
                case 6:
                    Console.WriteLine("OPPA, SEE JUBA LÄHEB");
                    break;
                default:
                    Console.WriteLine("vale");
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("millises riigis talle meeldiks elada?");
            Console.WriteLine("1. Eesti");
            Console.WriteLine("2. Läti");
            Console.WriteLine("3. Leedu");
            Console.WriteLine("4. saksamaa");
            Console.WriteLine("5. poola");
            Console.WriteLine("6. ukraina");
            int riigis = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (riigis <= 6 && riigis > 0) { break; }
                else
                {
                    Console.WriteLine("proovi veel");
                    riigis = Convert.ToInt32(Console.ReadLine());
                }

            }


            switch (riigis)
            {
                case 1:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Blue);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.DarkGreen);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.DarkRed);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 4:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 5:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Blue);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
          
            Console.WriteLine("kas ta õpib koolis? (JAH/EI)");
            string õpima = Console.ReadLine();
            if (õpima == "JAH" || õpima == "jah")
            {
                
            }
            else //EI
            {
                Console.WriteLine("edu tööturul");
                Environment.Exit(0);  //see on exit programm
            }


            while (true)
            {
                Console.WriteLine("mitmendas klassis sa käib");
                int vastus = Convert.ToInt32(Console.ReadLine());
                if (vastus >= 1 && vastus <= 8)
                {
                    switch (vastus)
                    {
                        case 1:
                            Console.WriteLine("kelleks sa saada tahad?");
                            break;
                        case 2:
                            Console.WriteLine("kas sulle koolis meeldib õppida");
                            break;
                        case 3:
                            Console.WriteLine("kuidas kolmandas klassis läheb?");
                            break;
                        case 4:
                            Console.WriteLine("kas koolis kiusatakse sind?");
                            break;
                        case 5:
                            Console.WriteLine("kirjuta oma sõnadega murdvõrrandi valem");
                            break;
                        case 6:
                            Console.WriteLine("kas kohustuslik kirjandus meeldib, või on ajaraiskamine?");
                            break;
                        case 7:
                            Console.WriteLine("Kas põhikool on raske, või lihtne");
                            break;
                        case 8:
                            Console.WriteLine("kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?");
                            break;
                    }
                    break;
                }
                
            }

            Console.WriteLine("mis pärast kooli lõpetamist plaanis on?");
            Console.WriteLine("1. ei tea");
            Console.WriteLine("2. ei kavatse kooli lõpetada");
            Console.WriteLine("3. Ma õpin tehnikumis.");
            Console.WriteLine("4. oma vastus");
            string result = "";
            while (true)
            {
                int vastus2 = Convert.ToInt32(Console.ReadLine());
                if (vastus2 == 4)
                {
                   string vastus3 = Console.ReadLine();
                    Console.WriteLine($"Küsitlusprogramm sulgub, viimane sisestatud vastus on {vastus2}");
                    result = "Küsitlusprogramm sulgub, viimane sisestatud vastus on {vastus2}";
                    break;
                }
                if (vastus2 >= 1 && vastus2 <= 3)
                {
                    switch (vastus2)
                    {
                        case 1:
                           Console.WriteLine("loodan et see idee ka ükspäev tuleb");
                            result = "(loodan et see idee ka ükspäev tuleb)";
                            break;
                        case 2:
                            Console.WriteLine("see on halb otsus. mul on sinust kahju :c");
                            result = "(see on halb otsus. mul on sinust kahju :c)";
                            break;
                        case 3:
                            Console.WriteLine("oh, see on hea asi teha :D");
                            result = "(oh, see on hea asi teha :D)";
                            break;
                        

                    }
                    break;
                }
                else { continue; }
            }
            Console.WriteLine($"Küsitlusprogramm sulgub, viimane sisestatud vastus on {result}");



        }
    }
}
