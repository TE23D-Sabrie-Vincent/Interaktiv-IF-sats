﻿// bool test = true || false;

// Console.WriteLine(test);

using System.Reflection;
using System.Runtime.CompilerServices;

System.Console.WriteLine("Du vaknar i en misstänksam lastbil och inser att du har blivit kidnappad ");
System.Console.WriteLine("Vad gör du?");
System.Console.WriteLine("Skrika för hjälp        försök att ringa 112");
string Decision = Console.ReadLine().ToLower();
// Gör sina val (variabeln Decision alltså) från CAPS till små bokstäver 


    if (Decision == "skrika för hjälp")
// om ditt val är "Skrika för hjälp" gör denna kod under mig >.<
{ 
System.Console.WriteLine("Du skriker för hjälp tills kidnapparen blev sur, han stannade bilen och kommer emot dig");
// 
System.Console.WriteLine("Vad gör du nu?");
System.Console.WriteLine("Sparka kidnapparen        Spela död");
     Decision = Console.ReadLine().ToLower();


}
    if (Decision == "sparka kidnapparen")
{
    System.Console.WriteLine("Du sparkade kidnapparen tills han svimmade och sprang iväg");
    System.Console.WriteLine("BONUS lore: Du insåg att du hade mäkta sparkar och började att träna på taekwondo");
    Decision = Console.ReadLine();
}
    else if (Decision == "spela död")
{
    System.Console.WriteLine("Kidnapparen såg att du lev och slog dig tills du svimmade.");
    Decision = Console.ReadLine().ToLower();
}

    else if (Decision == "försök att ringa 112" || Decision == "ring 112")
    
{
    System.Console.WriteLine("Du letar efter din mobil och insåg att kidnapparen tog den (bruh)");
    System.Console.WriteLine("Vill du leta efter andra föremål?");
    Decision = Console.ReadLine().ToLower();

}
    if (Decision == "ja")
{
    System.Console.WriteLine("Du letar efter något annat som kunde hjälpa dig och hittade 2 föremål: ");
    System.Console.WriteLine("En penna        rutten ostbit");
    System.Console.WriteLine("Vilken objekt ska du använda för att ta ned kidnapparen?");
    Decision = Console.ReadLine().ToLower();
}
    else if (Decision == "nej")
    {
      System.Console.WriteLine("Jaha, det var inte så smart... Du är nu kidnappad och kommer att dö (säkert). ");
      Decision = Console.ReadLine().ToLower();
    }



    if (Decision == "penna" || Decision == "pennan")
{
    System.Console.WriteLine("Du kastade pennan mot kidnapparen vilket distraherade honom och kraschade bilen in i en lyktstolpe ");
    System.Console.WriteLine("Du vaknade efter det hemska upplevelsen och insåg att han dog... Men du haltar iväg med ditt brutna vänstra hemåt");
}

    else if (Decision == "rutten ostbit" || Decision == "ostbit")
{
    System.Console.WriteLine("Du kastar ostbiten och träffade kidnapparens hår");
    System.Console.WriteLine("Kidnapparen skrek och stannade bilen för att se på inspektera den");
    System.Console.WriteLine("Det slutade med att han har alltid letat efter den legendariska ostbiten från sedan barndom");
    System.Console.WriteLine("Han lät dig gå utan att skada dig + du fick tillbaka din mobil! ");
    Decision = Console.ReadLine().ToLower();
}

else  
{
    Console.WriteLine("Aja baja, det får du inte göra för att jag tycker de XD (eller så är du dåeligt att stvava som jagh :p)");
}


Console.ReadLine();
