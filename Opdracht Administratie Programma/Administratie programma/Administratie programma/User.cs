using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class User
    {

            public string name;
            public string pass;

            public User(string userName)
            {
                //userName = Console.ReadLine();
                name = userName;
                
            }

            public string? UserName { get; }


    }
}

