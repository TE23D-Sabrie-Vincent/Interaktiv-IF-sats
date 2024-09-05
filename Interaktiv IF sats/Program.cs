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
    System.Console.WriteLine("BONUS lore: Du insåg att du hade mäkta sparkar och började att träna på taekwondo när ditt hem");
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
    System.Console.WriteLine("Du letar efter något annat som kunde hjälpa dig och hittade 2 föremål: ");
    System.Console.WriteLine("En penna och en gammal rutten ostbit");
    System.Console.WriteLine("Vilken objekt ska du använda för att ta ned kidnapparen?");
}
if (Decision == "penna || pennan")
{
    System.Console.WriteLine("Du kastade pennan mot kidnapparen vilket distraherade honom och kraschade bilen in i en lyktstolpe ");
    System.Console.WriteLine("Du vaknade efter det hemska upplevelsen och insåg att han dog... Men du haltar iväg med ditt brutna vänstra ben som om det vore inget");
}

if (Decision == "rutten osbit || ostbit")
{
    System.Console.WriteLine("Du kastar ostbiten och träffade kidnapparens hår");
    System.Console.WriteLine("Kidnapparen skrek och stannade bilen för att se på inspektera den");
    System.Console.WriteLine("Det slutade med att han har alltid letat efter den legendariska ostbiten från hans barndom");
    System.Console.WriteLine("Han lät dig gå utan att skada dig + du fick tillbaka din mobil! ");
}
else  
{
    Console.WriteLine("Aja baja, det får du inte göra för att jag tycker de XD");
}


Console.ReadLine();
