//Console.WriteLine("Hello, World!");
//var randomNum = Random(100 + 1);

using System;
using System.ComponentModel.Design.Serialization;


//if (randomNum / 3 && > 0)
//{
//    Console.WriteLine("Hoi");      
//}

using System.Data;

Console.WriteLine("hoi");
    Console.ForegroundColor = ConsoleColor.Cyan;


//background change
Console.WriteLine("what is your favourite colour?");
string userColour = Console.ReadLine();

Console.WriteLine("favourite colour is: " + userColour);

if (userColour == "groen")
{
    Console.ForegroundColor = ConsoleColor.Green;
}
else if (userColour == "rood")
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
}

//random num
Random rnd = new Random();

int randoNum = rnd.Next(1, 100);
Console.WriteLine("Random number: " + randoNum);


if (randoNum % 3 == 0)
{
    Console.WriteLine("hoi");
}
else if (randoNum % 5 == 0)
{
    Console.WriteLine("daar");
}
else
{
    Console.WriteLine("neither");
}
