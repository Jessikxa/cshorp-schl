using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_app
{
    internal class userOefening
    {

        private string nameTag;
        private string number;
        private string email;
        public userOefening(string tag) => nameTag = tag;

        public override string ToString() => $"user: {nameTag}";

        public userOefening(string tagName, string NoombderD, string modelEmail)
        {
            tagName = Console.ReadLine();
            NoombderD = Console.ReadLine();
            modelEmail = Console.ReadLine();


            nameTag = tagName;
            number = NoombderD;
            email = modelEmail;


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


            userOefening oeser = new userOefening("nameTag", "", "");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" what is your name? \n what is your phone number? \n what is your email?");
            userOefening bak = new userOefening("nameTag", "", "");

            Console.WriteLine();

            Console.WriteLine("what is your phone number?");
            Console.ReadLine();

            Console.WriteLine("what is your email?");




            Console.WriteLine("User Name: " + oeser.nameTag + "  Phone Number: " + oeser.number + "  User Email: " + oeser.email);
        }

        
    }
}
//    }

//}


