using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class Add_User
    {
        public void AddUser(List<User> biglist)
        {

            Console.WriteLine("Enter your username:");  //no numbers
            string username = Console.ReadLine();
            //same for adress and phone number

            Console.WriteLine("Enter your phone number");  //no letter
            string value = Console.ReadLine();
            int phoneNumber;
            Int32.TryParse(value, out phoneNumber);
             while (!Int32.TryParse(value, out phoneNumber))
            {
                Console.WriteLine("swoop moop");
                value = Console.ReadLine();
                if (Int32.TryParse(value, out phoneNumber))
                {
                    Console.WriteLine("wee");
                    break;
                }
            }

            Console.WriteLine("Enter your adress");
            string adress = Console.ReadLine();

            User Test = new User(username, phoneNumber, adress);
            biglist.Add(Test);

            Console.WriteLine($"Added username: {Test.name} phone number: {Test.phoneNumber} adress: {Test.adress}");

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();

        }
    }
}
