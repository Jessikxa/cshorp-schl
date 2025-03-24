using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class Edit_User_Info
    {
        public void Edit(List<User> biglist) 
        {
            Console.WriteLine("Which User would you like to edit?");

            for (int i = 0; i < biglist.Count; i++)
            {
                Console.WriteLine($"{i} - User: {biglist[i].name}");
            }


            string EditedInfo = Console.ReadLine().ToLower();
            int.TryParse(EditedInfo, out int indexEdit);


            Console.WriteLine($"what would you like to change?");

            for (int i = 0; i < biglist.Count; i++)
            {
                if (indexEdit == biglist.IndexOf(biglist[i]))
                {
                    Console.WriteLine(biglist[i]);
                    //change info

                    Console.WriteLine($"{i} - changed info:"); // display info that has been changed

                    Task.Delay(2000).Wait();
                    Console.Clear();
                }
            }

            for (int i = 0; i < biglist.Count; i++)
            {
                Console.WriteLine($"{i} - User: {biglist[i].name}"); // show user info again
            }
        }
    }
}
