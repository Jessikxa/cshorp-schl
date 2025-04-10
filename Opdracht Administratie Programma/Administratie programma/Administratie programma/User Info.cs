using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class User_Info
    {
        public void ShowUserInfo(List<User> biglist)
        {
            foreach (User wa in biglist) //loopt door de lijst(biglist) en checkt voor gebruikers
            {
                Console.WriteLine($"Gevonden: {wa.name}");  // print alle gegevens van elke gebruiker in lijst
            }

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();
        }
    }
}
