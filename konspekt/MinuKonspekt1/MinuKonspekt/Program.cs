using System.Diagnostics.SymbolStore;
using System.Runtime.Serialization;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");


            ////Muutujad, Matemaatilised tehted, IF, ELSE IF ja ELSE:

            ////1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
            //Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            //string nimi = Console.ReadLine();

            //if (nimi == "")
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}
            //else if (nimi != "")
            //{
            //    Console.WriteLine("Tere " + nimi + "!");

            //}
            //else
            //{
            //    Console.WriteLine("Kasutaja ei sisestanud oma nime");
            //}

            ////2.tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            //Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            //int kasutajavanus = int.Parse(Console.ReadLine());

            ////2.1 mitu tingimust pesastatud if-ide abil
            ////if (kasutajavanus > 0)
            ////{
            ////    if (kasutajavanus < 18)
            ////    {
            ////        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😔");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("Saad osta Monsterit, YIPPIE ✨✨");
            ////    }
            ////}

            ////2.2 mitu tingimust ühe ifi sees kasutades loogilist tehet "and", vältides pesastamist
            //if (kasutajavanus > 0 && kasutajavanus < 18)
            //{
            //    Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😔");
            //}
            //else 
            //{
            //    Console.WriteLine("Saad osta Monsterit, YIPPIE ✨✨");
            //}
            ////2.3 mitu vahemikku, if-elseif abil, double/float
            //Console.WriteLine("Sisesta oma pikkus ka, palun, "+nimi+":");
            //double pikkus = double.Parse(Console.ReadLine());
            //if (pikkus < 1.00d)
            //{
            //    Console.WriteLine("Oled juntsu");
            //}
            //else if (pikkus <1.25d && pikkus > 1.00d)
            //{
            //    Console.WriteLine("Oled peaaegu allameetrimees");
            //}
            //else if (pikkus <1.50d && pikkus >1.25d)
            //{
            //    Console.WriteLine("Oioi, päkapikk enam ei olegi "+nimi+" !");
            //}
            //else if (pikkus <1.75d && pikkus >1.5d)
            //{
            //    Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            //}
            //else if (pikkus <2.00d && pikkus >1.75d)
            //{
            //    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            //}
            //else if (pikkus > 2.00d)
            //{
            //    Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            //}
            //else
            //{
            //    Console.WriteLine("pikkust ei tunta");
            //}

            ////3 kalkulaator ifi ja elsifidega
            //Console.WriteLine("Tere. Sisesta esimene arv");
            //int arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere. Sisesta teine arv");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            //string tehtetyyp = Console.ReadLine();

            //int tulemus = 0;
            //if (tehtetyyp == "+")
            //{
            //    tulemus = arv1 + arv2;
            //}
            //else if (tehtetyyp == "-")
            //{
            //    tulemus = arv1 - arv2;
            //}
            //else if (tehtetyyp == "/")
            //{
            //    tulemus = arv1 / arv2;
            //}
            //else if (tehtetyyp == "*")
            //{
            //    tulemus = arv1 * arv2;
            //}
            //else if (tehtetyyp == "*")
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);
            //}
            //else
            //{
            //    Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
            //}

            //if (tulemus != 0)
            //{
            //    Console.WriteLine(tulemus);
            //}
            //else
            //{
            //    Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            //}

            ////4 parool, if ja string andmetüüp
            //Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            //string password = Console.ReadLine();

            //if (password == "simsalabim")
            //{
            //    Console.WriteLine("Parool on õige, aarete laegas avaneb");
            //}
            //else if (password == "saatana" || password == "1234")
            //{
            //    Console.WriteLine("Parool on sobimatu, palun mingi muu");
            //}
            //else
            //{
            //    Console.WriteLine("Parool on vale, proovi uuesti");
            //}

            ////5 värvituvastus
            //Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            //string favouriteColour = Console.ReadLine();
            //if(favouriteColour == "punane")
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //}
            //if (favouriteColour == "oranz")
            //{
            //    Console.WriteLine("Kahjuks oranzi ei ole");
            //}
            //if(favouriteColour == "kollane")
            //{
            //    Console.BackgroundColor = ConsoleColor.Yellow;
            //}
            //if (favouriteColour == "roheline")
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //}
            //else 
            //{
            //    Console.WriteLine("Värvi ei tunne");
            //}
            //Console.WriteLine("Värv muudetud!");

            ////    |
            ////   \v/ ISESEISEV TÖÖ LÄHEB SIIA

            ////# Kolija kalkulaator - Kirjuta programm mis:
            ////#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //Console.WriteLine("Kas sa tahad mõõta kasti või tünni?");
            //string sisend = Console.ReadLine();
            ////#    - olenevalt kasutaja sisestusest küsib ta:

            ////#    - - tünni jaoks:
            //if (sisend == "tünn")
            //{
            ////#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //    Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
            //    string rvõid = Console.ReadLine();
            //    Console.WriteLine("Mis on selle raadius/läbimõõt? meetrites");
            //    double kasutajamõõt = double.Parse(Console.ReadLine());
            ////#    - - - tünni kõrgust
            //    Console.WriteLine("Kui kõrge on su tünn? meetrites");
            //    double kõrgus = double.Parse(Console.ReadLine());
            ////#    - - - kaane paksus, kuna kaan võtab tünni sisust natuke ruumi)
            //    Console.WriteLine("Kui paks on su tünni kaas? meetrites");
            //    double kaanepaksus = double.Parse(Console.ReadLine());
            //    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //    double Sp = 0;
            //    if (rvõid == "R")
            //    {
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            //    }
            //    else if (rvõid == "D")
            //    {
            //        kasutajamõõt = kasutajamõõt / 2;
            //        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            //    }
            //    double V = 0;
            //    kõrgus = kõrgus - kaanepaksus;
            //    V = Sp * kõrgus;
            //    //Tünni ruumala on olemas. arvutame küljepindala
            //    kõrgus += kaanepaksus;
            //    double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;
            //    //Tünni küljepindala on olemas. arvutame tünni kogupindala
            //    double S = Sp + Sk;
            //    Console.WriteLine($"Sinu tünn mahutab {V}\nTünni küljepindala on{Sk}\nTünni kogupindala on{S}");
            //}

            ////#    - - kasti jaoks:
            //else if (sisend == "kast")
            //{
            ////#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            ////#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            ////#    - - - - kui on risttahukas siis küsib kasutajalt:
            ////#    - - - - - pikima külje pikkust, 
            ////#    - - - - - lühima külje pikkust ja
            ////#    - - - - - kasti kõrgust
            ////#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
            //}

            Console.WriteLine(/*abc*/"hapukapsas");
            // "Console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsureal
            // .            -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
            //                 mooduli "Console" seest.
            // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.
            // ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
            // []           -> tähistab massiive
            // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või
            //                 funktsiooni kirjeldust
            // "hapukapsas" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
            //          -> Taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood
            //             asub, see on vajalik ka kompilaatorile samal eesmärgil.
            // ;            -> kõik koodilaused lõppevad komakooloniga, mis tähistavad lause lõppu
            // //           -> tähistab üherealist kommentaari
            // /**/         -> tähistab mitmerealist kommentaari või kommentaariregiooni

            int muutuja = 3;
            // int          -> on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist
            //                 tüüpi andmed selle muutuja sees on.
            // "muutuja"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
            //                 sõnaga, ja mille abil saab neid addresseerida koodi sees.
            // =            -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub
            //                 teiselpool võrdusmärki.
            // 3            -> muutujale omistatav väärtus.

            /* Võimalikud andmetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M; // decimal on kümnendsüsteemis olev komakohaga arv
            float c = 3.9f; // float on 32-bitine komakohaga arv
            double d = 5.6d; // double on 64-bitine komakohaga arv
            char c1 = 'a'; // üksainus täht või tähemärk mis tähistatakse ülakomadga ''
            string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "abc"; //var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;   //ta võib omada endas teisi andmetüüpe
            const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only
            //void - on andmetüüp, mida muutuja tekitamisel kasutada ei saa. Kasutatakse ainult meetodite signatuurides väljendamaks et
            //meetod ei tagasta midagi.

            /* Võimalikud komposiitandmetüübid */
            // 1. massiiv:
            // [] - > Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
            //        Massive saab olla ükskõik millist lihtandmetüüpi massiive.
            //        Massiivi tekitamisel tuleb ära öelda kui pikk või kui suur see massiiv on.
            //        Massiiv ei pea olema koostatud ainult lihtandmetüüpidest, vaid massiive saab olla ka tehtud teistest komposiitandmetüüpidest
            //        Sealhulgas massiiv ise.
            // Esimene tekitusviis:
            int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et ühtlasi on
                                            // tegu ka massiiviga. muutuja nimeks on "arvuMassiiv" ja võrdusmärgi abil on omistatud muutujasse
                                            // uus tühi massiiv kasutades kaitstud sõna "new", millele järgneb selle massiivi andmetüübi ja
                                            // pikkuse sätestus "int[3]". See täghendab et siin massiivis on 3 elementi, mis on täisarvud.
            // Teine tekitusviis:
            int[] arvuMassiiv2 = [1,2,3];   // teine massiivi tekitusviis kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe
                                            // järjendit omava muutuja sisse, järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator
                                            // sinna sisse pandud elementide koguse järgi.

            // -- massiivi sisemised meetodid:
            int hasThisMany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku
                                                  // mitu elementi, adresseeritav massiiv omab, omistatakse ainult järjendi pikkus, mitte
                                                  // järjendi sees olevaid elemente.
            //2. Loend:
            // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
            //            täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüüpi andmed seal loendis on.
            //            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde lisada,
            //            ehk tema pikkus ei ole fikseeritud. Sarnaselt massiiviga saab temas hoida ka teisi loendeid.
            // Esimene tekitusviis:
            List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga. Listi noolsulgude <> vahel on loendis
                                                      //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. Muutuja enda
                                                      //nimeks on "arvuNimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja
                                                      //täisarvuloendi sätestusega "List<int>()".
            // Teine tekitusviis:
            List<int> arvuNimekiri2 = new List<int>() {1,2,3 }; //Teine loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi
                                                                //noolsulgude vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int"
                                                                //mis tähistab täisarve. Muutuja enda nimeks on "arvuNimekiri2". Omistame selle muutujasse 
                                                                //kaitstud sõna "new" abil uue täisarvuloendi, aga seekord, peale sätestust "List<int>()" saame
                                                                //instantsieerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid
                                                                //"1", "2" ja "3". Elemendid sisestatakse nimekirja loogeliste sulgude vahel. Enam ei ole tegu
                                                                //tühja nimekirjaga, vaid loendiga kus on kolm elementi juba sees.
            // kolmas tekitusviis:
            List<int> arvuNimekiri3 = new List<int>(3); //Kolmas loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude
                                                        //vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve.
                                                        //Muutuja enda nimeks on "arvuNimekiri3". Omistame sellesse muutujasse kaitstud sõna "new" abil uue
                                                        //täisarvuloendi, aga tavaliste sulgude vahele paneme arvu "3". Sarnaselt massiiviga ütleb see, et
                                                        //loend on 3 elemendi suurune. Loend ise ja tema elemendid on tühjad, aga seal on 3 elementi. Arv "3"
                                                        //on parameeter mida Listi konstruktor pikkuse määramiseks kasutab. Nimekiri säilitab oma omaduse muuta
                                                        //pikkust elementide lisamise-eemaldamisega, aga vajadusel saab nii anda talle pikkuse.
            int aa = 9001;
            // -- Loendi sisemised meetodid:
            arvuNimekiri.Add(99); //Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisatakse on Add meetodi sulgude
                                  //vahel. Elementi saab lisada otse (antud juhul täisarv "99")
            arvuNimekiri.Add(aa); //või muutujana.
            int loendiPikkus = arvuNimekiri3.Count(); //Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu mis vastab
                                                      //elementide kogusele.
            bool KasSeeArvOn = arvuNimekiri3.Contains(3); //Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel olevale
                                                          //parameetrile. Meetod tagastab kas "true" või "false" - on leitud või ei ole. Tegemist on
                                                          //põhimõtteliselt foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi.
            arvuNimekiri3.Remove(4); //Loendi meetod "Remove()"eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude vahel on parameetriks
                                     //eemaldatava elemendi asukohajärjekorranumber.

            //põhilised matemaatilised tehted
            int liitmine = 1 + 1; //liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine
            double korrutamine = 1 * 2; //korrutamine, kus teine arv korrutatakse esimese arvu kordi.
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.

            //Matemaatilised tehted moodulist "Math"
            double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
            double juurimine = Math.Sqrt(2); //ruutjuur, parameetrina juuritav arv
            double newD = 4.0000001d;
            Math.Round(newD); //Moodulist "Math" kutsutakse esile punkti abil meetod "Round", sulgude vahel on esimese parameetrina 
                              //ümardatav arv, teise parameetrina komakohtade arv. Round ümardab sulgude vahel oleva arvväärtuse
                              //teises parameetris oleva komakohtadeni. Kui komakohti ei ole seatud, ümardatakse lähima täisarvuni.
                              //0-4 ümardatakse allapoole, 5-9 ümardatakse ülespoole.
            double newPI = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitstud väärtus, PI, mis väljendab mate
                                    //maatilist pi-d ja seda saab kasutada nagu tavaline arv.

            //Castimine, ehk arvu teisendus ühest andmetüübist teise

            //Castimine on viis, kuidas ühest andmetüübist teist saada, Castimist ennast on kahte eri liiki - Automaatne ja
            //manuaalne. Automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse, aga manuaalselt
            //on vaja castida siis, kui üritame suuremast andmetüübist väiksemat saada. Manuaalne castimine käib nii, et
            //sihtmuutuja võrdusmärgi taga oleva muutuja nimetuse ette, pannakse sulgudes soovitava andmetüübi nimetus.

            //Manuaalne Castimine
            double newData1 = 1.23d; //tekitame, või on kuskil olemas, suure mahuga andmed muutujas "newData1" kus on tegu double
                                     //andmetüübiga
            float data1float = (float)newData1; //"(float)" teisendab double tüüpi andmed float tüüpi andmeteks.
            long data1Long = (long)newData1; //"(long)" teisendab double tüüpi andmed float tüüpi andmeteks.
            int data1Int = (int)newData1; //"(int)" teisendab double tüüpi andmed täisarvu andmeteks tüüpi andmeteks.
            char data1Char = (char)newData1;//"(char)" teisendab double tüüpi andmed char tüüpi andmeteks.

            //Automaatne Castimine
            int backToInt = data1Char; //char andmetüübist, suuremasse, int tüüpi andmeteks muutmisel ei ole vaja muutuja ette casti panna
            long backToLong = backToInt; //int andmetüübist suuremasse, long tüüpi andmeteks teisendamisel, casti panna ei ole vaja
            float backToFloat = backToLong; //long andmetüübist suuremasse, float tüüpi andmeteks teisendamisel, casti panna ei ole vaja
            double backToDouble = backToFloat; //float andmetüübist suuremasse, double tüüpi andmeteks teisendamisel, casti panna ei ole vaja

            //muutuja nimed
            int arv = 0; //sobib
            string sõne = "abc"; //sobib
            //string string = "abc"; //kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnevad sõnad:
            //abstract, as, base, bool, break, byte, case,
            //catch, char, checked, class, count, continue, decimal,
            //default, delegate, do, double, else, enum, event,
            //explicit, extern, false, finally, fixed, float, for
            //foreach, goto, if, implicit, in, int, interface, internal
            //is, lock, long, namespace, new, null, object, operator,
            //out, override, params, private, protected, public, readonly,
            //ref, return, sbyte, sealed, short, sizeof, stackalloc,
            //static, string, struct, switch, this, throw, try, typeof,
            //uint, ulong, unchecked, unsafe, ushort, using, virtual, 
            //void, volatile, while.

            ////3 kalkulaator ifi ja elsifidega
            //Console.WriteLine("Tere. Sisesta esimene arv");
            ////Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            ////selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            ////ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta esimene arv".
            ////Lause lõppeb lauselõpumärgiga ";".

            //int arv1 = int.Parse(Console.ReadLine());
            ////instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            ////ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            ////väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            ////Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            ////tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            ////ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõpumärgiga ";".

            //Console.WriteLine("Tere. Sisesta teine arv");
            ////Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            ////selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            ////ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            ////Lause lõppeb lauselõpumärgiga ";".

            //int arv2 = int.Parse(Console.ReadLine());
            ////instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see
            ////ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            ////väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            ////Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            ////tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            ////ReadLine funktsiooni Parse() sulgude vahele. Lause lõppeb lauselõpumärgiga ";".

            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            ////Adresseerime moodulit "Console" koos "WriteLine" funktsiooniga, et esitada kasutajale
            ////küsimuse "Sisesta tehtemärk: / * + -". Punkti abil saame moodulist Console, funktsiooni
            ////WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            ////jutumärkidega. Lause lõppeb lauselõpumärgiga ";".

            //string tehtetyyp = Console.ReadLine();
            ////instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string".
            ////Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            ////"Console" moodulis oleva ReadLine() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

            //int tulemus = 0;
            ////instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse
            ////väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".

            //if (tehtetyyp == "+")
            //    //teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on
            //    //võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
            //    //nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
            //    //ole koodiga mis midagi kindlalt veel ära teeb.
            //{
            //    tulemus = arv1 + arv2;
            //}
            ////peale tingimust on koodiplokk {} sulgude vahel, mis sialdab endas ühte koodirida.
            ////selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            ////kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";".

            //else if (tehtetyyp == "-")
            //    //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //    //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid 
            //    //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
            //    //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 - arv2;
            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            ////koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            ////tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            ////oleva väärtuse. Lause lõppeb lauselõpumärgiga ";".

            //else if (tehtetyyp == "/")
            //    //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //    //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //    //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus ei
            //    //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 / arv2;
            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            ////koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil jagamistehte
            ////tulemuse, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga 
            ////Lause lõppeb lauselõpumärgiga ";".

            //else if (tehtetyyp == "*")
            //    //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //    //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //    //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
            //    //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 * arv2;
            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            ////koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            ////tulemuse, kus korrutame muutujas "arv2" oleva väärtuse muutujas "arv1" oleva väärtuse
            ////kordi. Lause lõppeb lauselõpumärgiga ";".
            //else if (tehtetyyp == "^")
            //    //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //    //Sulgude vahel on võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid
            //    //samal kujul nagu võrdusmärkidest teisel pool olev tekst "^" kui eelnev tingimus ei
            //    //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);
            //}
            ////peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            ////koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
            ////"Math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena
            ////sisse muutjad "arv1" ja "arv2". Esimene parameeter on astendatav, teine parameeter
            ////on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja
            ////"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks.
            ////Lause lõppeb lauselõpumärgiga ";".
            //else
            //    //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide
            //    //muude tingimuslause osade mittetäitumisel. Siin eraldi tingimust välja ei kirjutada
            //    //ning sellest tulenevalt ei ole ka sulge. Järgneb ainult koodiplokk.
            //{
            //    Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
            //}
            ////peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            ////koodirida. Selles koodireas kasutame moodulist "Console" punkti abil funktsiooni
            ////"WriteLine" et öelda kasutajale "Palun sisesta tehe, mida kalkulaator tuvastada
            ////oskab". Koodirida lõppeb lauselõpumärgiga ";".

            //Console.WriteLine(tulemus);
            ////Kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
            ////tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            ////"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ";".

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust!!!!!!!!!!!!!!!OMFGZEROONE!!!!!!!!!!!!!!!!!!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestatud on vigane arv");
            }

            //string kasutajaNimi = "";
            //do
            //{
            //    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
            //    kasutajaNimi = Console.ReadLine();
            //} while (kasutajaNimi != "user1");
            //if (kasutajaNimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruutu saada tahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

            //    char reaKujund = '▓';
            //    string üksRida = "";
            //    int tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        üksRida = üksRida + "_" + reaKujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //}

            /* Tingimuslause osad */
            if (true) { } //kaitstud sõna "if" kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
                          //koodiplokk tingimuse täitumisel teostatava koodiga
            else if (true) { } //kaitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                               //on samamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if". Tingimuse täitumisel
                               //ja eelneva tingimuse mittetäitumisel, teostatakse koodiploki sees olev kood.
            else { } //kaitstud sõna "else" kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiploki sisu
                     //täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel.

            int option = 3; // -------
            switch (option) //"switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab ef else-if asemel kasutada.
                            //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
                            //ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
                            //pärast lülitusvalikut tuleb koodiplokk.
            {
                case 1:     //koodiploki sees on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse,
                            //kas muutujas "option" on väärtus 1, millele järgned koolon ":" väljendades tingimuse täitumisel tehtava
                            //kooditegevuse algust
                    break;  //Kui tegevus on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingimustikust kaitstud
                            //sõnaga "break". Peale breaki on läuselõpumärk ";".
                case 2:     //Juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt.
                    break;
                case 3:
                    Console.WriteLine(option); //tehtav kooditegevus.
                    break;
                default:    //Default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;  //Ka default lõppeb sõnaga break.
            }

            /* sõne tööriistad ja muud tekstiga seotut */
            string alfa = "a\nb";        // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
            string beta = $"a {alfa} b"; // $  -> lubab kasutada muutjaid loogeliste sulgudega otse teksti sees. On variant
                                         //       formateeritud stringist.

            /* Loogilised tehted */

            // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) juhul kui
            //       mõlemal pool "&&" märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
            //       vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
            // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks (true),
            //       hüüumärgi abil tagastab (false), ja vastupidi - tulemus mis muidu tagastaks (false), hüüumärgi abil tagastab (true)

            /* Võrdlusoperaatorid */

            // == -> "on võrdne". Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //       objektiga. ei ole sama nagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //       Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul. Võrdlusoperaator on kombinatsioon
            //       "on võrdne operaatorist, ja loogilisest tehtest "not".
            // >  -> "on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui paremal pool olev objekt.
            // <  -> "on väiksem kui". Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
            // >= -> "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            //       Võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            // <= -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parempoolne objekt.
            //       Võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

            /* omistusoperaatorid ja kiirtehted */

            int thing = 1;// =  -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                          //       asendab tehet "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lauhtab muutujast maha võrdusmärgi teisel pool oleva arvu.
                          //       asendab tehet "thing = thing - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "=".
            thing *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                          //       oleva arvu kordi. asendab tehet "thing = thing * 2". on kombinatsioon matemaatilisest tehtest "*" ja
                          //       omistamisest "=".
            thing /= 2;   // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                          //       arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon matemaatilisest tehtest "/" ja
                          //       omistamisest "=".
            thing++;      // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe.
            thing--;      // -- -> on spetsiifiliselt ühe maha lahutamiseks kiirtehe.

            /* Tsüklid */
            // 1. do-while
            int dew = 0;
            do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi
            {
                dew++;
            } while (dew != 5); //niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.

            // 2. while
            int i = 1;    //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel
            while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist
                          //tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel,
                          //siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                          // antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel
                          //katkeb.
            {
                //koodiplokk kus midagi tehakse
                i++;      //ning seejärel muudetakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehtega "++".
            }
            // 3. for
            int kogus = 6; // muutuja mida tsükkel kasutab oma töö tegemiseks - teisisõnu, töödeldav materjal
            for (int k = 0; k < kogus; k++) // kaitstud sõnaa "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
                                             // töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli töö jaoks kohaliku muutuja
                                             // "int k = 0;" mida tsükli ENDA töö juhtimiseks. Teine parameeter on tingimuslause, mis kontrollib
                                             // tingimuse täitumist "k < kogus;" ning mille täitumisel tsükli töö jätkub, aga mille
                                             // mitte-täitumisel tsükkel katkeb. Kolmas parameeter on tsüklimuutuja inkrementeerimine kiirtehtega
                                             // "k++". Pane tähele, et iga sulgude vahel oleva osa järel (välja arvatud viimase) on
                                             // lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest
                                             // nagu "while" või "do-while" puhul.
            {                                // sulgudele järgneb, loogeliste sulgude vahel ole koodiplokk {}
                Console.WriteLine(k);        // töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.
            }
            // 4. foreach
            int[] arvuLoend = { 3, 67, 420, 69, 42 }; //massiiv mida foreach kasutab või töötleb mingil kujul
            foreach (var arvInLoend in arvuLoend) //kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                                  //ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                                  //kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend"
                                                  //muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtasvat
                                                  //tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub, ehk tsükli töö käib
                                                  //iga üksiku elemendi kohta andmekogumis individuaalselt. Tsüklil ei ole vaja tsüklimuutujat , kuna talle on
                                                  //sisse ehitatud vaikimisi elemendi järjestuse jälgimine.Niipalju kui andmeid loendis on, ongi see
                                                  //mis ütleb ära, mitu korda tsükkel käivitatakse.
            {                                     //peale sulge, on koodiplokk {} kus tehakse mingi tegevus
                Console.WriteLine(arvInLoend);    //Antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi, hetkel tsüklis olev element.
            }
            


        }
        /* Meetodid */

        // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid spetsiifilisi funktsioone või tegevusi.
        // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
        // Meetodeid on kahte liiki - Ühed, mis tagastavad mingisuguse töö või tegevuse tagajärjel või tulemusena andmeid, ja teised
        // mis ei tagasta midagi, kuid omavad siiski mingit tegevust.

        // Meetodi signatuur & selle kompositsioon:

        // Meetodi sgnatuur on kõige esimene rida, mis meetodi tekitamiseks kirjutatakse, ning mis kirjeldab meetodit ennast, ning selle
        // omadusi.
        //
        // Meetodi signatuur koosneb mitmest kindlast äramääratud omadusest. Nendeks on juurdepääsu modifikaator, tagastustüüp,
        // meetodi enda nimi, olenevalt meetodi liigist ka parameetrid mis on sulgude vahel (), ning koodiplokist mis on meetodi sisu.
        //
        // - Juurdepääsu modifikaator ütleb ära, kust ja kuidas seda meetodit välja kutsuda või adresseerida saab. Juurdepääsu modi-
        //   fikaatoreid on tähtsamatest 4-5 tükki.
        // 1 - public --- meetod on avalik ja kättesaadav ka teistes klassides, peale selle klassi, kus meetod ise asub.
        // 2 - private --- meetod on saadav ainult selles klassis kus meetod ise asub.
        // 3 - protected --- meetod on saadav ainult selles klassis kus meetod ise asub ja klassis mis pärilusega saab
        //     selle klassi andmed kaasa.
        // 4 - internal --- meetod on saadav ainult selles klassis ja ainult selles failis.
        // 5 - static --- vahest võib olla pandud ka static, see ütleb lihtsalt et see meetod asub siin.
        //
        // - Tagastustüüp on meetodi omadus, mis ütleb ära millise tüübiga andmed, meetodi väljakutsumise asukohta tagastatakse, kui üldse.
        // Andmetüüp, mida tagastada, võib olla ükskõik milline liht- või kombinatsioonandmetüüp. Aga kui meetod ei tagasta üldse andmeid
        // pannakse selle asemel andmetüübiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui void, on meetodi sees, iga toimiva
        // koodisuuna lõpus kaitstud sõna "return", return ütleb, et just see asi on vaja tagastada. peale returni on alati mingisugune kindel
        // muutuja, või tegevuse tulemus, mis tagastatakse meetodi väljakutseasukohta. peale käivitatud returni, ei teostata mitte ühtegi
        // muud meetodis olevat koodi, sest meetod on leidnud oma tagastatava objekti, ning meetodi töö sellel hetkel katkestatakse.
        // Return on osaliselt ka kui break.
        //
        // - Meetodi enda nimi on midgi mille järgi arendaja meetodit kasutab, kutsub koodis välja, ning meetodi nimi peaks kuvama
        //üldsõnaliselt mida see meetod teeb. Näites meetod nimega "A();" ei ole hea, sest sõna "A" ei ütle programmeerijale mitte midagi.
        //Aga näiteks meetod, nimega "ArvutaArvudKokku();" Ütleb arendajale ära, mida see meetod teeb. Ta ei raiska oma aega, selle
        //meetodi enda koodi lugemisele.
        //
        // - Parameetrid on need, mis ütlevad, mis meetodil tema tääks vaja on. Parameeter, meetodi signatuuris võib olla teistmoodi
        //väljendatud, kui on kirjutatud muutuja mis on koodi sees, mille jaoks seda kasutada vaja on.

        // 1. tüüpi meetod - ei tagasta midagi:
        public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et ta kuulub sellesse
                                       //klassi. Tagastustüüp on "void" mis ütleb et andmeid meie meetod ei tagasta. Pärast omadusi on selle
                                       //meetodi nimi "UusMeetod" peale mida on sulud, kus parameetreid ei ole.
                                       //pärast signatuuri on koodiplokk selle meetodi koodiga, loogeliste sulgude vahel {}
        {
            Console.WriteLine("Tere"); //antud juhul on meetodi sisuks sõnumi kuvamine, mooduli "Console" abiga, mille seest punkti abil "."
                                       //adresseerime Console meetodit "WriteLine" ning mille parameetriks on sõne "Tere", parameeter asub
                                       //peale meetodi nime olevate sulgude vahel. Lause lõppeb lauselõpumärgiga ";"
                                       //See arendaja poold kirjutatud meetod rohkem koodi ei oma.
        }

        // 2. tüüpi meetod - tagastab väärtuse:
        int[] arvutatavadArvud = new int[] { 67, 69, 420, 9001 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                                  //"arvutatavadArvud".
        public static int ArvutaKokku(int[] arvud) //Meetod mille signatuuris on juurdepääsumodifikaator "public", "static" ütleb et ta kuulub
                                                   //sellesse klassi, tagastustüüp "int" ütleb, et programmis tagastatakse täisarv asukohta
                                                   //koodis kus meetod algselt välja kutsuti. Siis on meetodi nimi "ArvutaKokku", ning sulgude
                                                   //vahel ootab meetod täisarvumassiivi. Sellele massiivile pannakse meetodi siseselt ajutine
                                                   //nimi "arvud". Meetod ootab esimese parameetri asukohal just arvumassiivi olenemata mis
                                                   //tema muutuja nimi on. Peale signatuuri on koodiplokk tehtava koodiga.
        {
            int summa = 0; //tekitasme täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse võrdusmärgi abil arv 0. Lause
                           //lõppeb lauselõpumärgiga ";".
            foreach (var arv in arvud) //tekitame "foreach" tsükli, mille kogumikuks on meetodisisene arvudemassiiv nimega "arvud", mille
                                       //iga elemendi ajutise muutja nimi on "arv"
            { //peale seda on koodiplokk
                summa += arv; //muutujale summa omistatakse += märgiga juurde hetkel tsüklis kasutuselolev arv. asendab tehet summa = summa + arv
            }
            return summa; //pärast tsükli töö lõppu on kaitstud sõna "return" mille järel on muutuja "summa", ning tagastatakse täisarv,
                          //mis asub muutujas summa, meetodi töö lõppeb.
        }

    }
}
