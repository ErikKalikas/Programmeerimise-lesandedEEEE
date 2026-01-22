using System.Security.Cryptography;

namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Küsi kasutajalt tema pikkust
            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            //kui ta on lühem kui 1m, ütle juntsu
            //kui ta on lühem kui 2m, ütle tavaline kolge
            //kui ta on pikem kui 2m, ütle hiiglane

            //küsi kasutajalt kui vana ta on
            //küsi kasutajalt praegust aastaarvu
            //lahuta aastast kasutaja vanus
            //kui kasutaja on sündinud 2025-2020, ütle talle, kes sulle arvuti juba andis
            //kui kasutaja on sündinud 2020-2015, ütle talle, skibidi sigmaless
            //kui kasutaja on sündinud 2015-2010, küsi talt kas ta tahab saada programmeerijaks
            //    kui jah, ütle tubli
            //    kui ei, ütle kahju
            //kui kasutaja on sündinud enne 2010, küsi mitu rage comicsit ta täna oma redditi lugemise ajal leidis 

            //küsi kasutajalt tema elukoha suunakoodi
            //kui suunakood on väiksem kui 5 tähte, ütle talle, 1 täht on puudu
            //kui suunakood on suurem kui 5 tähte, ütle talle, 1 täht on üle
            //kui suunakoodis on 5 tähte, ütle "ahha nüüd tean kus elad"

            //küsi kasutajalt kas ta töötab
            //kui kasutaja vastab jah, siis ütle tubli
            //kui kasutaja vastab ei, siis ütle, kahju, miks sa siis töökohta ei otsi?
            //kui kasutaja vastab otsin, siis ütle, loodan et saad varsti tööle c:

            //küsi kasutajalt tema parooli
            //seejärel küsi kasutajalt tema 2FA koodi,
            //kui parool on vale, ütle sissepääs keelatud
            //kui parool on õige, kontrolli 2FA koodi:
            //  kui 2FA kood on lühem kui 6 tähte, ütle sissepääs keelatud, kood on liiga lühike
            //  kui 2FA kood on pikem kui 6 tähte, ütle sissepääs keelatud, kood on liiga pikk
            //  kui 2FA kood on 6 tähte, siis lase sisse, öeldes "oled sissepääsenud"
            //NB: 2FA kood ei pea matchima eksisteeriva näitega nagu parool.

            Console.WriteLine("kirjuta oma pikkust"); //väljastab teksti: "kirjuta oma pikkust"
            int pikkust = Convert.ToInt32 (Console.ReadLine()); //luuakse muutuja tüübiga int, mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine()-st.      
            if (pikkust <= 0) //Kas „pikust“ on väiksem või võrdne 0-ga?
            {
                Console.WriteLine("võimatu pikkus"); //väljastab teksti: "võimatu pikkus"
            }
            else if (pikkust == 1) //Kas „pikust“ on võrdne 1 - ga ?
            {
                Console.WriteLine("juntsu"); //väljastab teksti: "juntsu"
            }
            else if (pikkust == 2) //Kas „pikust“ on võrdne 2 - ga ?
            {
                Console.WriteLine("tavaline kolge"); //väljastab teksti: "tavaline kolge"
            }
            else if (pikkust > 2) //Kas „pikust“ on rohkem kui 2 ?
            {
                Console.WriteLine("hiiglane"); //väljastab teksti: "hiiglane"
            }
            Console.WriteLine("kui vana sa oled"); //väljastab teksti: "kui vana sa oled"
            int vanus = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "vanus", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st.           
            Console.WriteLine("kirjuta oma aastaarvu"); //väljastab teksti: "kirjuta oma aastaarvu"
            int aeg = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "aeg", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st.  
            int kod = aeg - vanus; //luuakse muutuja kood, milles salvestatakse arvutuse aeg - vanus tulemus;
            if (kod >= 2020 && kod <= 2025) //Kas „kod“ on suurem või võrdne 2015-ga? Ja kas „kod“ on väiksem või võrdne 2025 - ga ?             
            {
                Console.WriteLine(" kes sulle arvuti juba andis"); //väljastab teksti: " kes sulle arvuti juba andis"
            }
            else if (kod >= 2015 && kod <= 2019) //Kas „kod“ on suurem või võrdne 2015-ga? Ja kas „kod“ on väiksem või võrdne 2019 - ga ?                
            {
                Console.WriteLine("skibidi sigmaless"); //väljastab teksti: "skibidi sigmaless"
            }
            else if (kod <= 2015 && kod >= 2010) //Kas „kod“ on väiksem või võrdne 2015-ga? Ja kas „kod“ on suurem või võrdne 2010-ga?
            {                
                while (true) //sisenemine tsüklisse while. tingimused väljumiseks „true“
                {
                    Console.WriteLine("kas ta tahab saada programmeerijaks (JAH/EI)"); //väljastab teksti: "kas ta tahab saada programmeerijaks (JAH/EI)"
                    string tahab = Console.ReadLine(); //luuakse string-tüüpi muutuja "tahab", kuhu kirjutatakse vastus Console.ReadLine();
                    if (tahab == "JAH") //Kas „tahab“ on võrdne sõnaga „JAH“?
                    {
                        Console.WriteLine("tubli"); //väljastab teksti: "tubli"
                        break; //tsükli väljumine
                    }
                    else if (tahab == "EI") ////Kas „tahab“ on võrdne sõnaga „JAH“?
                    {
                        Console.WriteLine("kahju"); //väljastab teksti: "kahju"
                        break; //tsükli väljumine
                    }
                    
                }
            }
            while (true)
            {
                Console.WriteLine("kuidas sinu suunakood?"); //väljastab teksti: "kuidas sinu suunakood?"
                int suunakood = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "suunakood", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st. 
                if (suunakood <= 9999) //Kas „suunakood“ on väiksem või võrdne 9999-ga?
                {
                    Console.WriteLine("1 täht on puudu"); //väljastab teksti: "1 täht on puudu"

                }
                else if (suunakood >= 1000000) //Kas „suunakood“ on suurem või võrdne 1000000-ga?
                {
                    Console.WriteLine("1 täht on üle"); //väljastab teksti: "1 täht on üle"

                }
                else
                {
                    Console.WriteLine("ahha nüüd tean kus elad"); //väljastab teksti: "ahha nüüd tean kus elad"
                    break; //tsükli väljumine
                }
            }

            while (true)
            {
                Console.WriteLine("kas ta töötab? (JAH/EI)"); //väljastab teksti: "kas ta töötab? (JAH/EI)"
                string töö = Console.ReadLine(); //luuakse string-tüüpi muutuja "töö", kuhu kirjutatakse vastus Console.ReadLine();
                if (töö == "JAH")  //Kas „tahab“ on võrdne sõnaga „JAH“?
                {
                    Console.WriteLine("tubli"); //väljastab teksti: "tubli"
                    break; //tsükli väljumine
                }
                else if (töö == "EI") //Kas „tahab“ on võrdne sõnaga „EI“?
                {
                    Console.WriteLine("kahju"); //väljastab teksti: "kahju"
                    Console.WriteLine("miks sa siis töökohta ei otsi?"); //väljastab teksti: "miks sa siis töökohta ei otsi?"
                    string otsin = Console.ReadLine(); //luuakse string-tüüpi muutuja "otsin", kuhu kirjutatakse vastus Console.ReadLine();
                    if (otsin == "Otsin")  //Kas „tahab“ on võrdne sõnaga „otsin“?
                    {
                        Console.WriteLine("loodan et saad varsti tööle c:"); //väljastab teksti: "loodan et saad varsti tööle c:"

                    }                               
                        break;      //tsükli väljumine
                }
                
            }           

                       
            while (true)
            {
                Console.WriteLine("kirjuta oma parool"); //väljastab teksti: "kirjuta oma parool"
                string parool = Console.ReadLine(); //luuakse string-tüüpi muutuja "parool", kuhu kirjutatakse vastus Console.ReadLine();
                if (parool == "Parool") 
                {
                    Console.WriteLine("kirjuta oma 2FA koodi"); //väljastab teksti: "kirjuta oma 2FA koodi"
                    int kood = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "kood", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st.
                    if (kood >= 999999) //Kas „kood“ on suurem või võrdne 999999-ga?
                    {
                        Console.WriteLine("kood on liiga pikk"); //väljastab teksti: "kood on liiga pikk"

                    }
                    else if (kood <= 99999) //Kas „kood“ on väiksem või võrdne 99999-ga?
                    {
                        Console.WriteLine("kood on liiga lühike"); //väljastab teksti: "kood on liiga lühike"

                    }
                    else
                    {
                        Console.WriteLine("oled sissepääsenud"); //väljastab teksti: "oled sissepääsenud"
                        break; //tsükli väljumine
                    }
                }
                else
                {
                    Console.WriteLine("sissepääs keelatud"); //väljastab teksti: "sissepääs keelatud"

                }

                //Lõpp
            }
               
        }
    }
}
