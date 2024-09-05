// bool test = true || false;

// Console.WriteLine(test);

using System.Reflection;
using System.Runtime.CompilerServices;

System.Console.WriteLine("Du vaknar i en misstänksam lastbil och inser att du har blivit kidnappad ");
System.Console.WriteLine("Vad gör du?");
System.Console.WriteLine("Skrika för hjälp        försöka att ringa 112");
string Decision = Console.ReadLine().ToLower();


    if (Decision == "skrika för hjälp")
{ 
System.Console.WriteLine("Du skriker för hjälp tills kidnapparen blev sur, han stannade bilen och kommer emot dig");

System.Console.WriteLine("Vad gör du nu?");
System.Console.WriteLine("Sparka kidnapparen        Spela död");
     Decision = Console.ReadLine().ToLower();


}
     if (Decision == "sparka kidnapparen")
{
    System.Console.WriteLine("Du sparkade kidnapparen tills han svimmade och sprang iväg");
}
// {
//     Desicion = Console.ReadLine();
//     else if (Desicion == "försök att rymma")
//     {
//         Console.WriteLine("Är du dum? Såklart tog han din mobil! ahem, jag menar du insåg att mobilen var inte i dina fickor");
//     }

if (Decision == "försöka att ringa 112")
{
    System.Console.WriteLine("Du letar efter din mobil och insåg att kidnapparen tog den (bruh)");
}
// else 
// {
//     Console.WriteLine("Aja baja, det får du inte göra för att jag tycker de XD");
// }


Console.ReadLine();
