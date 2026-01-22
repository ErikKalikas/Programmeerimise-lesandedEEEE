namespace SõneÜlesanne2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm kus on kaks kasutajat (kasutajanime ja parooliga)
            //küsi kasutajalt tema kasutajanime, otsi kasutajate järjendist vastav kasutaja, ja kui kasutajat ei leita, ütle et kasutaja ei eksisteeri
            //kui kasutaja eksisteerib, vaata kasutaja parooli, küsi kasutajalt tema parool ja võrdle neid
            //kui paroolid ühtivad, ütle tere tulemast
            //kui aga ei ühti, küsi kasutajalt parooli uuesti.
            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string>() { "user1", "password1"});
            kasutajad.Add(new List<string>() { "user2", "password2"});

            string kasutajanimi = "";
            Console.WriteLine("Palun sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesUserExist = false;
            string õigeparool = "";

            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi) 
                {
                    doesUserExist = true;
                    õigeparool = user[1];
                }
            }
            if (doesUserExist == true)
            {
                string sisestus = "";
                do
                {
                    Console.WriteLine("palun sisesta oma parool:");
                    sisestus = Console.ReadLine();
                } while (sisestus != õigeparool);
                //
                Console.WriteLine($"Tere tulemast {kasutajanimi}");
            }
            else
            {
                Console.WriteLine("kasutaja ei eksisteeri");
            }
        }
    }
}
