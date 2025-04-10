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

            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            //same for adress and phone number

            User Test = new User(username);
            biglist.Add(Test);

            Console.WriteLine($"Added username: {Test.name}");

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();

        }
    }
}
