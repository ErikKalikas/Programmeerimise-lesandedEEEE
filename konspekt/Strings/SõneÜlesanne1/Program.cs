namespace SõneÜlesanne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis
            //küsib kasutajalt tsüklis, millised mängud talle meeldivad
            List<string> kasutajaMängud = new List<string>();

            string mängunimi = "";
            Console.WriteLine("Millised mängud sulle meeldivad?");

            while (mängunimi != "ei ole")
            {
                Console.WriteLine("palun sisesta järgmine mäng, kui rohkem ei ole, kirjuta \"ei ole\"");
                mängunimi = Console.ReadLine();
                if (mängunimi != "ei ole")
                {
                    //küsimiste tulemus hoia järjendis
                    kasutajaMängud.Add(mängunimi);
                }

            }

            //kui järjend sisaldab (.Contains()) "mario kart", siis küsi kui vana ta on, sarkastiliselt.
            
            if (kasutajaMängud.Contains("mario kart"))
            {
                Console.WriteLine("MIKS SA MARIO KARTI MÄNGID, MINGI 5 OLED VÄ!??!?!");
            }

            //kui järjend sisaldab "gta 6", siis küsi kust ta ajamasina sai, et rockstar lõpuks asjaga valmis sai

            if (kasutajaMängud.Contains("gta 6"))
            {
                Console.WriteLine("kust ajamasina said? kuidas rockstar sellega juba valmis sai? o_õ");
            }

            //kui järjend sisaldab "pong", siis ütle "80ndad tahavad vanureid tagasi, toimub boomerite recall"

            if (kasutajaMängud.Contains("pong"))
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi, toimub boomerite recall");
            }

            //kui järjend on tühi, siis programm läheb edasi ->

            if (!kasutajaMängud.Any())
            {
                //küsi kasutajalt kas talle ei meeldi mängud, ning lase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestust .ToUpper() või .ToLower()iga
                Console.WriteLine("Kas sulle ei meeldi mängud? vasta kas jah või ei:");
                string jahvõiei = Console.ReadLine().ToLower();
                //kui ta vastab jah, siis ütle, "aga miks siis ei sisestanud?"
                if (jahvõiei.Contains("jah")) // "        jah"
                {
                    Console.WriteLine("aga miks siis ei sisestanud?");
                }
                //kui talle ei meeldi, siis ütle, kahju
                else if (jahvõiei.Contains("ei")) // 
                {
                    Console.WriteLine("kahju :c");
                }
                //kui vastus on midagi muud, siis ütle "ei saa aru :/".
                else
                {
                    Console.WriteLine("ei saa aru :/");
                }
            }
        }
    }
}
