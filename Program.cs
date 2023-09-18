// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

string startagain = "ja";

while (startagain == "ja")
{

    int poäng = 0;

    Console.WriteLine("Välkommen till frågesport!");
    Console.ReadLine();
    Console.WriteLine("Du kommer få fem stycken papegoj-relaterade frågor med tre svarsalternativ var.");
    Console.ReadLine();
    Console.WriteLine("Ditt jobb är att skriva A, B, eller C för att svara på frågorna. Lätt, eller hur?");
    Console.ReadLine();
    Console.WriteLine("Då börjar vi.");
    Console.ReadLine();
    Console.WriteLine("Fråga nummer 1:");
    Console.ReadLine();
    Console.WriteLine("Vilken är den största papegojan?");
    Console.WriteLine("A: Kakadua");
    Console.WriteLine("B: Undulat");
    Console.WriteLine("C: Ara");
    string första = Console.ReadLine().ToLower();

    if (första == "a")
    {
        Console.WriteLine("Fel. Kakaduan må vara en stor fågel men det är definitivt inte den största.");
        Console.WriteLine("Inget poäng den här gången.");
    }
    else if (första == "b")
    {
        Console.WriteLine("Fel. Undulater är väldigt små.");
        Console.WriteLine("Inget poäng den här gången.");
    }
    else if (första == "c")
    {
        Console.WriteLine("Korekt!");
        Console.WriteLine("Aran, och specifikt hyacintaran som kan bli ungefär en meter lång.");
        Console.WriteLine("Ett poäng till dig.");
        poäng++;
    }

    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Fråga nummer 2:");
    Console.ReadLine();
    Console.WriteLine("Vilka färger finns det på kakaduor?");
    Console.WriteLine("A: Vit, bara vit");
    Console.WriteLine("B: Vit, rosa, och svart");
    Console.WriteLine("C: Vit, grå, och blå");
    string andra = Console.ReadLine().ToLower();

    if (andra == "a")
    {
        Console.WriteLine("Fel. Många av dem är vita men de kan ha andra färger också.");
        Console.WriteLine("Inget poäng den här gången.");
    }
    else if (andra == "b")
    {
        Console.WriteLine("Rätt svar!");
        Console.WriteLine("Ett poäng till dig!");
        poäng++;
    }
    else if (andra == "c")
    {
        Console.WriteLine("Fel. Det finns varken gråa eller blåa kakaduor");
        Console.WriteLine("Inget poäng den här gången.");
    }

    Console.ReadLine();
    Console.WriteLine("Fråga nummer 3:");
    Console.ReadLine();
    Console.WriteLine("Ungefär hur gammal blir en ara");
    Console.WriteLine("A: 100 år");
    Console.WriteLine("B: 50 år");
    Console.WriteLine("C: 15 år");
    string tredje = Console.ReadLine().ToLower();

    if (tredje == "a")
    {
        Console.WriteLine("Korrekt.");
        Console.WriteLine("Aror blir ofta ungefär lika gamla som människor. Många aror lever till och med ofta längre än sina första ägare.");
        Console.WriteLine("Ett poäng till dig!");
        poäng++;
    }
    else if (tredje == "b")
    {
        Console.WriteLine("Fel svar.");
        Console.WriteLine("Inget poäng den här gången.");
    }
    else if (tredje == "c")
    {
        Console.WriteLine("Fel svar.");
        Console.WriteLine("Inget poäng den här gången.");
    }

    Console.ReadLine();
    Console.WriteLine("Fråga nummer 4:");
    Console.ReadLine();
    Console.WriteLine("Vilken papegoja har det största ordförrådet? Vilken är bäst på att prata?");
    Console.WriteLine("A: Nymfkakadua");
    Console.WriteLine("B: Gråjako");
    Console.WriteLine("C: Solparakit");
    string fjärde = Console.ReadLine().ToLower();

    if (fjärde == "a")
    {
        Console.WriteLine("Fel. Nymfkakaduor är väldigt bra på att vissla men de är inte så bra på att prata.");
        Console.WriteLine("Inget poäng den här gången.");
    }
    else if (fjärde == "b")
    {
        Console.WriteLine("Rätt svar!");
        Console.WriteLine("Gråjakon, eller African Grey på engelska, är känd för att vara den bästa talaren bland papegojorna. Rekorded för störst ordförråd ligger hos gråjakon Alex som hade ett ordförråd på över 100 ord och kunde även förstå dess betydelse.");
        Console.WriteLine("Ett poäng till dig!");
        poäng++;
    }
    else if (fjärde == "c")
    {
        Console.WriteLine("Fel. Solparakiter är bra på att skrika, men titeln 'bästa talaren' går därimot till en annan fågel.");
        Console.WriteLine("Inget poäng den här gången.");
    }

    Console.ReadLine();
    Console.WriteLine("Fråga nummer 5:");
    Console.ReadLine();
    Console.WriteLine("Vad bör en papegoja äta?");
    Console.WriteLine("A: Frukt");
    Console.WriteLine("B: Frön och nötter");
    Console.WriteLine("C: Grönsaker");
    string femte = Console.ReadLine().ToLower();

    if (femte == "a")
    {
        Console.WriteLine("Rätt svar, fast det var lite av en trickfråga. Alla svaren är rätt, till olika grader. En papegoja bör äta en variation av frukt och grönsaker, mest grönsaker, och många använder frön och nötter som belöning vis till exempel trickövning");
        Console.WriteLine("Ett poäng till dig.");
        poäng++;
    }
    else if (femte == "b")
    {
        Console.WriteLine("Hmm, ja, delvis, men inte bara det. Fåglar som lever på bara frön och nötter blir oftast överviktiga och får sjukdommar som gör att de dör alldeles för tidigt. Det är en anledning till att många till exempel tänker att undulater, som egentligen kan leva tills de är 15, har en livslängd på 2 år. Frön pch nötter är bättre som belöning vid trickövning en som en full diet.");
        Console.WriteLine("Du får tyvärr inget poäng för det svaret.");
    }
    else if (femte == "c")
    {
        Console.WriteLine("Yep. Korrekt. Fast alla svaren är egentligen rätt, vissa mer än andra. Dock är det här det mest rätta svaret. Papegojor bör äta en varierad diet av frukt och grönsaker med lite frön och nötter som belöning ibland.");
        Console.WriteLine("Du får två poäng för det svaret. Grattis.");
        poäng += 2;
    }

    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("");

    if (poäng <= 2)
    {
        Console.WriteLine($"Ditt resultat är {poäng}/5.");
        Console.WriteLine("Hmmm. Du behöver nog öva lite mer på det där. Testa igen och se om du kan få ett bättre resultat den här gången.");
    }
    else if (poäng <= 4 )
    {
        Console.WriteLine($"Ditt resultat är {poäng}/5.");
        Console.WriteLine("Bra jobbat! Du fick godkänt på quizzet.");   
    }
    else if (poäng == 5)
    {
        Console.WriteLine($"Ditt resultat är {poäng}/5.");
        Console.WriteLine("Bra gjort! Du fick alla rätt!");
    }
    else if (poäng > 5)
    {
        Console.WriteLine($"Ditt resultat är {poäng}/5.");
        Console.WriteLine("Aha, alla rätt och bonuspoänget på sista frågan. Du kan dina papegojfakta. I'm impressed.");
    }
    Console.ReadLine();
    Console.WriteLine("Vill du testa igen?");
    Console.WriteLine("Ja eller nej");
    startagain = Console.ReadLine().ToLower();
    Console.WriteLine("");
}