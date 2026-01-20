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

            Console.WriteLine("kirjuta oma pikkust");
            int pikkust = Convert.ToInt32 (Console.ReadLine());
            if (pikkust <= 0)
            {
                Console.WriteLine("võimatu pikkus");
            }
            else if (pikkust == 1)
            {
                Console.WriteLine("juntsu");
            }
            else if (pikkust == 2)
            {
                Console.WriteLine("tavaline kolge");
            }
            else if (pikkust > 2)
            {
                Console.WriteLine("hiiglane");
            }
            Console.WriteLine("kui vana sa oled");
            int vanus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kirjuta oma aastaarvu");
            int aeg = Convert.ToInt32(Console.ReadLine());
            int kod = aeg - vanus;
            if (kod >= 2020 && kod <= 2025)
            {
                Console.WriteLine(" kes sulle arvuti juba andis");
            }
            else if (kod >= 2015 && kod <= 2019)
            {
                Console.WriteLine("skibidi sigmaless");
            }
            else if (kod <= 2015 && kod >= 2010)
            {                
                while (true)
                {
                    Console.WriteLine("kas ta tahab saada programmeerijaks (JAH/EI)");
                    string tahab = Console.ReadLine();
                    if (tahab == "JAH")
                    {
                        Console.WriteLine("tubli");
                        break;
                    }
                    else if (tahab == "EI")
                    {
                        Console.WriteLine("kahju");
                        break;
                    }
                    
                }
            }
            while (true)
            {
                Console.WriteLine("kuidas sinu suunakood?");
                int suunakood = Convert.ToInt32(Console.ReadLine());
                if (suunakood <= 9999)
                {
                    Console.WriteLine("1 täht on puudu");
                    
                }
                else if (suunakood >= 1000000)
                {
                    Console.WriteLine("1 täht on üle");
                    
                }
                else
                {
                    Console.WriteLine("ahha nüüd tean kus elad");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("kas ta töötab? (JAH/EI)");
                string töö = Console.ReadLine();
                if (töö == "JAH")
                {
                    Console.WriteLine("tubli");
                    break;
                }
                else if (töö == "EI")
                {
                    Console.WriteLine("kahju");
                    Console.WriteLine("miks sa siis töökohta ei otsi?");
                    string otsin = Console.ReadLine();
                    if (otsin == "otsin")
                    {
                        Console.WriteLine("loodan et saad varsti tööle c:");
                        
                    }                               
                        break;      
                }
                
            }           

                       
            while (true)
            {
                Console.WriteLine("kirjuta oma parool");
                string parool = Console.ReadLine();
                if (parool == "parool")
                {
                    Console.WriteLine("kirjuta oma 2FA koodi");
                    int kood = Convert.ToInt32(Console.ReadLine());
                    if (kood >= 999999)
                    {
                        Console.WriteLine("kood on liiga pikk");
                        
                    }
                    else if (kood <= 99999)
                    {
                        Console.WriteLine("kood on liiga lühike");
                        
                    }
                    else
                    {
                        Console.WriteLine("oled sissepääsenud");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("sissepääs keelatud");
                    
                }
            }
               
        }
    }
}
