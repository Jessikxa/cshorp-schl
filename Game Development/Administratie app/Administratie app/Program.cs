using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_app
{
    internal class Program
    {
        public Program(string boing)
        {

        }
        static void Main(string[] args)
        {
            //menu for users
            Console.WriteLine("welcome to your administation program");
            Console.WriteLine("type in corresponding word to wanted action");

            Console.WriteLine("\t \t \tw - login");
            Console.WriteLine("\t \t \ta - register");
            Console.WriteLine("\t \t \ts - edit");
            Console.WriteLine("\t \t \td - logout");

            string userInput = Console.ReadLine();


            if (userInput == "login")
            {
                    Console.WriteLine("You are now logged in");
            }
            


            string user = Console.ReadLine();

            Console.WriteLine("is this what you are waiting for, " + user + "?");
            string godLike = Console.ReadLine();

            Console.WriteLine(godLike + "? \n  Are there anymore out there?");
            string yN = Console.ReadLine();

            Console.WriteLine(yN + "\n" + user + " is that true or false?");
            string trueOrFalse = Console.ReadLine();
            Console.WriteLine(trueOrFalse + ". I see..");
        }
    }
}
