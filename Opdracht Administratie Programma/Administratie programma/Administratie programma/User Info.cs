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
            foreach (User wa in biglist)
            {
                Console.WriteLine($"Gevonden: {wa.name}");
            }
        }
    }
}
