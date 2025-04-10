using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class Remove_User
    {
        public void SelectDeleteUser(List<User> biglist) 
        {
            Console.WriteLine("Which user would you like to delete?");

            for (int i = 0; i < biglist.Count; i++)
            {
                Console.WriteLine($"{i} - User: {biglist[i].name}");
            }


            string deleteUserInfo = Console.ReadLine().ToLower();
            int.TryParse(deleteUserInfo, out int indexDelete);


            for (int i = 0; i < biglist.Count; i++)
            {
                if (indexDelete == biglist.IndexOf(biglist[i]))
                {
                    biglist.RemoveAt(indexDelete);
                    Console.WriteLine($"User deleted: {indexDelete}"); //i want to show the name but i

                    Task.Delay(2000).Wait();
                    Console.Clear();
                }
            }

            for (int i = 0; i < biglist.Count; i++)
            {
                Console.WriteLine($"{i} - User currently in list: {biglist[i].name}");
            }

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();
        }
    }
}
