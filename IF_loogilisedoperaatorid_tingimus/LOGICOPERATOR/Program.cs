namespace LOGICOPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tee neli bool-tüüpi muutujat,

            //nimedeks pane neile pliiatsid, paber, saag, lauad

            //küsi kasutajalt muutujasse "sisestus" vastus iga objekti
            //kohta küsimus "kas tal on X?" millele kasutaja saab vastata jah või ei
            //küsimine EI PEA olema tsüklis, võib ka teha 4 küsimust järjest

            //kui ta on mingi objekti kohta vastanud ei, siis pane vastavasse muutujasse false
            //samamoodi kui ta on mingi objekti kohta vastanud jah, siis pane vastavasse muutujasse true

            //"kas sul on paber?" on vastus = "jah" siis paber = true jne

            //kui kõikides muutujates on vastus olemas, tee järgnevad tingimuslaused kombineerides mitu tingimust korraga
            //ja kasutades and, or ja not operaatoreid && || !

            //kui tal on saag ja lauad aga paberit ja pliiatsit ei ole, siis ütle "võiksid õppida tisleriks"
            //kui tal on pliiatsid ja paber aga saagi ja laudu ei ole, siis ütle "võiksid õppida arhitektiks"
            //kui tal on pliiatsid ja paber ning ka saag ja lauad, siis ütle "võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud"
            //kui tal on pliiatsid ja saag aga paberit ja laudu ei ole, siis ütle "sul on tööriistad, aga materjali mitte, ma ei oska öelda"
            //kui tal on paber ja lauad, aga pliiatsit ja saagi ei ole, siis ütle "sul on materjal, aga tööriistu mitte, mine k-rautasse"
            //kõikidel muudel juhtudel ütle - "tühjade kätega ei tee mitte midagi :c"

            //siin on sama tingimuste nimekiri tabelivormis:
            //      |Pliiatsid  |paber      |lauad      |saag       ||tulemus
            //------+-----------+-----------+-----------+-----------++-------------------------
            //      |   ei      |   ei      |   jah     |   jah     ||  "võiksid õppida tisleriks"
            //      |   jah     |   jah     |   ei      |   ei      ||  "võiksid õppida arhitektiks"
            //      |   jah     |   jah     |   jah     |   jah     ||  "võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud"
            //      |   jah     |   ei      |   ei      |   jah     ||  "sul on tööriistad, aga materjali mitte, ma ei oska öelda"
            //      |   ei      |   jah     |   jah     |   ei      ||  "sul on materjal, aga tööriistu mitte, mine k-rautasse"
            //      |  < kõik muud kombinatsoonid tingimustest >    ||  "tühjade kätega ei tee mitte midagi :c"
            bool pliiatsid;
            string pliiatsid2;
            bool paber;
            string paber2;
            bool saag;
            string saag2;
            bool lauad;
            string lauad2;


            // pliiatsid
            Console.WriteLine("kas sul on pliat (JAH/EI)?");
            pliiatsid2 = Console.ReadLine();
            if (pliiatsid2 == "JAH" || pliiatsid2 == "jah")
            {
                Console.WriteLine("sa valisid pliatsid");
                pliiatsid = true;
            }
            else 
            {
                Console.WriteLine("mitte pliatsid");
                pliiatsid = false;
            }
            
            
            //paber
            Console.WriteLine("kas sul on paber (JAH/EI)?");
            paber2 = Console.ReadLine();
            if (paber2 == "JAH" || paber2 == "jah")
            {
                Console.WriteLine("sa valisid pliatsid");
                paber = true;
            }
            else 
            {
                Console.WriteLine("mitte pliatsid");
                paber = false;
            }
            

            //saag
            Console.WriteLine("kas sul on saag (JAH/EI)?");           
            saag2 = Console.ReadLine();
            if (saag2 == "JAH" || saag2 == "jah")
            {
                Console.WriteLine("sa valisid pliatsid");
                saag = true;
            }
            else 
            {
                Console.WriteLine("mitte pliatsid");
                saag = false;
            }
            

            //laud
            Console.WriteLine("kas sul on lauad (JAH/EI)?");
            lauad2 = Console.ReadLine().ToLower();
            if (lauad2 == "JAH" || lauad2 == "jah")
            {
                Console.WriteLine("sa valisid pliatsid");
                lauad = true;
            }
            else 
            {
                Console.WriteLine("mitte pliatsid");
                lauad = false;
            }

            if (saag && lauad)
            {
                Console.WriteLine("võiksid õppida tisleriks");
            }
            else if (pliiatsid && paber )
            {
                Console.WriteLine("võiksid õppida arhitektiks");
            }
            else if (pliiatsid && paber && saag && lauad )
            {
                Console.WriteLine("võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud");
            }
            else if (pliiatsid  && saag )
            {
                Console.WriteLine("sul on tööriistad, aga materjali mitte, ma ei oska öelda");
            }
            else if (paber  && lauad )
            {
                Console.WriteLine("sul on materjal, aga tööriistu mitte, mine k-rautasse");
            }
            else Console.WriteLine("tühjade kätega ei tee mitte midagi :c");





        }
    }
}
