
Console.WriteLine("Hello, World!");


// alert waar je je naam in kan vullen 

Console.WriteLine("Enter name:");

string inputName = Console.ReadLine();
string CorrectName = "jessica"; // ik wil ook dat het met hoofdletter kan werken

while (inputName != CorrectName)
{
    Console.WriteLine("Enter name:");
    inputName = Console.ReadLine();
    Console.WriteLine("Name doesn't match");
    if (inputName == CorrectName)
    {
        Console.WriteLine("Your name is:" + CorrectName);
    }
}



//if (inputName == CorrectName)
//{
//    Console.WriteLine("Your name is:" + CorrectName);
//}
//else
//{
//    Console.WriteLine("Name doesn't match")
//}
    




//how to check naaaaaaaaaaaaaaaaameee