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



            //Спроси у пользователя его рост.
            //Если он ниже 0 см, скажи «невозможный рост».
            //Если он ниже 1 м, скажи «юнцу».
            //Если он ниже 2 м, скажи «обычный коротышка».
            //Если он выше 2 м, скажи «великан».

            //спросите пользователя, сколько ему лет
            //спросите пользователя, какой сейчас год
            //вычтите из года возраст пользователя
            //если пользователь родился в 2025-2020 годах, скажите ему, кто уже дал вам компьютер
            //если пользователь родился в 2020-2015 годах, скажи ему: «Скибиди сигмалесс»
            //если пользователь родился в 2015-2010 годах, спроси его, хочет ли он стать программистом
            //    если да, скажи «молодец»
            //    если нет, скажи «жаль»
            //если пользователь родился до 2010 года, спроси, сколько rage comics он нашел сегодня, читая Reddit 

            //спроси у пользователя код его местоположения
            //если код направления меньше 5 символов, скажи ему, что не хватает 1 символа
            //если код направления больше 5 символов, скажи ему, что лишний 1 символ
            //если код направления состоит из 5 символов, скажи «ага, теперь я знаю, где ты живешь»

            //спросите пользователя, работает ли он
            //если пользователь отвечает «да», скажите «молодец»
            //если пользователь отвечает «нет», скажите «жаль, почему же вы не ищете работу?»
            //если пользователь отвечает «ищу», скажите «надеюсь, вы скоро найдете работу c:

            //спросите у пользователя его пароль
            //затем спросите у пользователя его код 2FA,
            //если пароль неверный, скажите «доступ запрещен»
            //если пароль верный, проверьте код 2FA:
            //  если код 2FA короче 6 символов, скажите «доступ запрещен, код слишком короткий»
            //  если код 2FA длиннее 6 символов, сообщите, что доступ запрещен, код слишком длинный
            //  если код 2FA состоит из 6 символов, разрешите доступ, сообщив «Вы вошли»
            //NB: код 2FA не должен совпадать с существующим примером, таким как пароль.


            Console.WriteLine("kirjuta oma pikkust"); //väljastab teksti: "kirjuta oma pikkust" - выводит текст: «напишите свой рост»
            int pikkust = Convert.ToInt32 (Console.ReadLine()); //luuakse muutuja tüübiga int, mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine()-st. - создается переменная типа int, которая преобразует ответ, введенный с помощью Convert.ToInt32, из Console.ReadLine().
            if (pikkust <= 0) //Kas „pikust“ on väiksem või võrdne 0-ga? - Является ли «длина» меньше или равна 0?
            {
                Console.WriteLine("võimatu pikkus"); //väljastab teksti: "võimatu pikkus" - выдает текст: «невозможная длина»
            }
            else if (pikkust == 1) //Kas „pikust“ on võrdne 1 - ga ? - Является ли «длина» равной 1?
            {
                Console.WriteLine("juntsu"); //väljastab teksti: "juntsu" - выводит текст: «juntsu»
            }
            else if (pikkust == 2) //Kas „pikust“ on võrdne 2 - ga ? - Является ли «длина» равной 2?
            {
                Console.WriteLine("tavaline kolge"); //väljastab teksti: "tavaline kolge" - выдает текст: «обычный холод»
            }
            else if (pikkust > 2) //Kas „pikust“ on rohkem kui 2 ? - Есть ли «длина» больше 2?
            {
                Console.WriteLine("hiiglane"); //väljastab teksti: "hiiglane" - выдает текст: «великан»
            }
            Console.WriteLine("kui vana sa oled"); //väljastab teksti: "kui vana sa oled" - выводит текст: «сколько тебе лет» 
            int vanus = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "vanus", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st.  - создается переменная типа int «возраст», которая преобразует введенный ответ с помощью Convert.ToInt32 Console.ReadLine() - st.        
            Console.WriteLine("kirjuta oma aastaarvu"); //väljastab teksti: "kirjuta oma aastaarvu" - выводит текст: «введите свой год рождения»
            int aeg = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "aeg", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st.  - создается переменная типа int «время», которая с помощью Convert.ToInt32 преобразует введенный ответ Console.ReadLine() - st
            int kod = aeg - vanus; //luuakse muutuja kood, milles salvestatakse arvutuse aeg - vanus tulemus; -
            if (kod >= 2020 && kod <= 2025) //Kas „kod“ on suurem või võrdne 2015-ga? Ja kas „kod“ on väiksem või võrdne 2025 - ga ?       -  luuakse muutuja kood, milles salvestatakse arvutuse aeg - vanus tulemus;     
            {
                Console.WriteLine(" kes sulle arvuti juba andis"); //väljastab teksti: " kes sulle arvuti juba andis" - выводит текст: «кто уже дал тебе компьютер»
            }
            else if (kod >= 2015 && kod <= 2019) //Kas „kod“ on suurem või võrdne 2015-ga? Ja kas „kod“ on väiksem või võrdne 2019 - ga ?  -  Является ли «kod» больше или равным 2015 году? И является ли «kod» меньше или равным 2019 году?            
            {
                Console.WriteLine("skibidi sigmaless"); //väljastab teksti: "skibidi sigmaless" - выводит текст: «skibidi sigmaless» 
            }
            else if (kod <= 2015 && kod >= 2010) //Kas „kod“ on väiksem või võrdne 2015-ga? Ja kas „kod“ on suurem või võrdne 2010-ga? - Kas „kod“ on väiksem või võrdne 2015-ga? Ja kas „kod“ on suurem või võrdne 2010-ga
            {                
                while (true) //sisenemine tsüklisse while. tingimused väljumiseks „true“ - вход в цикл while. условия выхода «true» 
                {
                    Console.WriteLine("kas ta tahab saada programmeerijaks (JAH/EI)"); //väljastab teksti: "kas ta tahab saada programmeerijaks (JAH/EI)" - выводит текст: «хочет ли он стать программистом (ДА/НЕТ)»
                    string tahab = Console.ReadLine(); //luuakse string-tüüpi muutuja "tahab", kuhu kirjutatakse vastus Console.ReadLine(); - создается переменная типа string «хочет», в которую записывается ответ Console.ReadLine(); 
                    if (tahab == "JAH") //Kas „tahab“ on võrdne sõnaga „JAH“? - «Хочет» равнозначно слову «ДА»?
                    {
                        Console.WriteLine("tubli"); //väljastab teksti: "tubli" - выдает текст: «хорошо»
                        break; //tsükli väljumine
                    }
                    else if (tahab == "EI") ////Kas „tahab“ on võrdne sõnaga „JAH“? - «Хочет» равнозначно слову «ДА»?
                    {
                        Console.WriteLine("kahju"); //väljastab teksti: "kahju" - выводит текст: «ущерб»
                        break; //tsükli väljumine - выход из цыкла
                    }
                    
                }
            }
            while (true)
            {
                Console.WriteLine("kuidas sinu suunakood?"); //väljastab teksti: "kuidas sinu suunakood?" -
                int suunakood = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "suunakood", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st. - создается переменная типа int «код направления», которая преобразует введенный ответ с помощью Convert.ToInt32 Console.ReadLine() - st.
                if (suunakood <= 9999) //Kas „suunakood“ on väiksem või võrdne 9999-ga? - Является ли «код направления» меньше или равен 9999?
                {
                    Console.WriteLine("1 täht on puudu"); //väljastab teksti: "1 täht on puudu" - выдает текст: «Не хватает 1 буквы»

                }
                else if (suunakood >= 1000000) //Kas „suunakood“ on suurem või võrdne 1000000-ga? - Является ли «код направления» больше или равен 1000000?
                {
                    Console.WriteLine("1 täht on üle"); //väljastab teksti: "1 täht on üle" - выводит текст: «1 буква лишняя» 

                }
                else
                {
                    Console.WriteLine("ahha nüüd tean kus elad"); //väljastab teksti: "ahha nüüd tean kus elad" - выдает текст: «ага, теперь я знаю, где ты живешь»
                    break; //tsükli väljumine - выход из цыкла
                }
            }

            while (true)
            {
                Console.WriteLine("kas ta töötab? (JAH/EI)"); //väljastab teksti: "kas ta töötab? (JAH/EI)" - выводит текст: «работает ли он (ДА/НЕТ)»
                string töö = Console.ReadLine(); //luuakse string-tüüpi muutuja "töö", kuhu kirjutatakse vastus Console.ReadLine(); - создается переменная типа string «работа», в которую записывается ответ Console.ReadLine();
                if (töö == "JAH")  //Kas „tahab“ on võrdne sõnaga „JAH“? - «Хочет» равнозначно слову «ДА»?
                {
                    Console.WriteLine("tubli"); //väljastab teksti: "tubli" - выдает текст: «молодец»
                    break; //tsükli väljumine -
                }
                else if (töö == "EI") //Kas „tahab“ on võrdne sõnaga „EI“? -
                {
                    Console.WriteLine("kahju"); //väljastab teksti: "kahju" -
                    Console.WriteLine("miks sa siis töökohta ei otsi?"); //väljastab teksti: "miks sa siis töökohta ei otsi?" -
                    string otsin = Console.ReadLine(); //luuakse string-tüüpi muutuja "otsin", kuhu kirjutatakse vastus Console.ReadLine(); -
                    if (otsin == "Otsin")  //Kas „tahab“ on võrdne sõnaga „otsin“? -
                    {
                        Console.WriteLine("loodan et saad varsti tööle c:"); //väljastab teksti: "loodan et saad varsti tööle c:" -

                    }                               
                        break;      //tsükli väljumine - выход из цыкла
                }
                
            }           

                       
            while (true)
            {
                Console.WriteLine("kirjuta oma parool"); //väljastab teksti: "kirjuta oma parool" - выводит текст: «введите свой пароль»
                string parool = Console.ReadLine(); //luuakse string-tüüpi muutuja "parool", kuhu kirjutatakse vastus Console.ReadLine(); - создается переменная типа string «пароль», в которую записывается ответ Console.ReadLine();
                if (parool == "Parool") 
                {
                    Console.WriteLine("kirjuta oma 2FA koodi"); //väljastab teksti: "kirjuta oma 2FA koodi" - выдает текст: «введите свой код 2FA»
                    int kood = Convert.ToInt32(Console.ReadLine()); //luuakse muutuja tüübiga int "kood", mis teisendab Convert.ToInt32 abil sisestatud vastuse Console.ReadLine() - st. - создается переменная типа int «код», которая преобразует введенный ответ с помощью Convert.ToInt32 Console.ReadLine() - st.
                    if (kood >= 999999) //Kas „kood“ on suurem või võrdne 999999-ga? - «Код» больше или равен 999999?
                    {
                        Console.WriteLine("kood on liiga pikk"); //väljastab teksti: "kood on liiga pikk" - выдает текст: «код слишком длинный»

                    }
                    else if (kood <= 99999) //Kas „kood“ on väiksem või võrdne 99999-ga? - «Код» меньше или равен 99999?
                    {
                        Console.WriteLine("kood on liiga lühike"); //väljastab teksti: "kood on liiga lühike" - выдает текст: «код слишком короткий»

                    }
                    else
                    {
                        Console.WriteLine("oled sissepääsenud"); //väljastab teksti: "oled sissepääsenud" - выдает текст: «Вы вошли»
                        break; //tsükli väljumine - выход из цыкла
                    }
                }
                else
                {
                    Console.WriteLine("sissepääs keelatud"); //väljastab teksti: "sissepääs keelatud" - выдает текст: «вход запрещен»

                }

                //Lõpp
            }
               
        }
    }
}
