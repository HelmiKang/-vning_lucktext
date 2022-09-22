// variabler
string name = "";
int point = 0;
string igen = "ja";
string[] answers = { "1", "2", "3" };
string[] answers2 = { "ja", "nej"};
int vinst = 0;
int antal = 0;


// rätt och fel
static int Congrats(int p)
{
    p ++;
    Console.WriteLine($"Det var rätt svar, Du har nu {p} poäng.");
    return p;
}

static int Wrong(int p)
{
    Console.WriteLine($"Det var fel svar, Du har nu {p} poäng.");
    return p;
}


while (igen == "ja")
{
    point = 0;

    // start
    if (antal == 0)
    {
        Console.WriteLine("Skriv ditt namn:");
        name = Console.ReadLine();
        Console.WriteLine($"Välkommen {name} till min frågesport om katter!");
        Console.WriteLine(" ");
    }

    // fråga 1
    Console.WriteLine("Vi börjar lätt, vad är en katt?");
    Console.WriteLine("1) Ett djur. 2) En hund. 3) Inte en katt.");
    string svar1 = Console.ReadLine();

    while (!answers.Contains(svar1))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        svar1 = Console.ReadLine();
    }

    if (svar1 == "1")
    {
        point = Congrats(point);
    }
    else
    {
        point = Wrong(point);
    }
    Console.WriteLine(" ");


    // fråga 2
    Console.WriteLine("Nu blir det svårare, fråga 2: Varför har katter en svans?");
    Console.WriteLine("1) För att fläkta sig med. 2) För att slå andra katter. 3) För att hålla balansen.");
    string svar2 = Console.ReadLine();

    while (!answers.Contains(svar2))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        svar2 = Console.ReadLine();
    }

    if (svar2 == "3")
    {
        point = Congrats(point);
    }
    else
    {
        point = Wrong(point);
    }
    Console.WriteLine(" ");


    // fråga 3
    Console.WriteLine("Fråga 3: Hur stor del av sitt liv spenderar katter på att sova?");
    Console.WriteLine("1) 70%. 2) 50%. 3) 33%");
    string svar3 = Console.ReadLine();

    while (!answers.Contains(svar3))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        svar3 = Console.ReadLine();
    }

    if (svar3 == "1")
    {
        point = Congrats(point);
    }
    else
    {
        point = Wrong(point);
    }
    Console.WriteLine(" ");


    // fråga 4
    Console.WriteLine("Fråga 4: Hur lång var den längsta katten någonsin?");
    Console.WriteLine("1) 52 cm. 2) 123 cm. 3) 90 cm");
    string svar4 = Console.ReadLine();

    while (!answers.Contains(svar4))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        svar4 = Console.ReadLine();
    }

    if (svar4 == "2")
    {
        point = Congrats(point);
    }
    else
    {
        point = Wrong(point);
    }
    Console.WriteLine(" ");

    // fråga 5
    Console.WriteLine("Sista frågan! Fråga 5: Hur många tamkatter finns det i världen?");
    Console.WriteLine("1) Mer än 100 miljoner. 2) Mer än 500 miljoner. 3) Mer än det finns människor.");
    string svar5 = Console.ReadLine();

    while (!answers.Contains(svar5))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        svar5 = Console.ReadLine();
    }

    if (svar5 == "2")
    {
        point = Congrats(point);
    }
    else
    {
        point = Wrong(point);
    }
    Console.WriteLine(" ");


    // Slut
    if (point == 5)
    {
        Console.WriteLine($"Grattis {name}! Du fick alla rätt. Du är verkligen ett proffs på katter.");
        vinst++;
    }
     else
    {
        Console.WriteLine($"{name}, du fick {point} av 5 poäng.");
        
    }
    if (point == 0)
    {
        Console.WriteLine($"Du fick alla fel. Du vet verkligen ingenting om katter.");
    }

    antal++;

    Console.WriteLine("Vill du testa igen? Skriv 'ja' eller 'nej'");
    igen = Console.ReadLine();

    while(!answers2.Contains(igen))
    {
        Console.WriteLine("Fel svarstyp, försök igen:");
        igen = Console.ReadLine();
    }
    if (igen == "nej")
    {             
        Console.WriteLine("                   .-.");
        Console.WriteLine(@"                    \ \");
        Console.WriteLine(@"                     \ \");
        Console.WriteLine("                      | |");
        Console.WriteLine("                       | |");
        Console.WriteLine(@"     /\---/\   _,---._ | |");
        Console.WriteLine(@"    /^   ^  \,'       `. ;");
        Console.WriteLine("   ( O   O   )           ;");
        Console.WriteLine(@"    `.=o=__,'             \");
        Console.WriteLine(@"     /        _,--.        \");
        Console.WriteLine(@"    /  _ )   ,'    `-. `-. \");
        Console.WriteLine(@"   /  ,' /  ,'        \ \ \ \");
        Console.WriteLine("  / /  / ,'           (,_)(,_)");
        Console.WriteLine(" (,;)  (,,)");        
        Console.WriteLine(" ");
        Console.WriteLine($"Tack {name } för att du spelade! Du vann {vinst} av {antal} spel.");
        Console.ReadLine();
    }
}
Console.ReadLine();