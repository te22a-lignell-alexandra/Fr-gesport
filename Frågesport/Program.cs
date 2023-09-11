// See https://aka.ms/new-console-template for more information
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