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


            User Test = new User(username);
            biglist.Add(Test);

            Console.WriteLine($"Added username: {Test.name}");

        }
    }
}
