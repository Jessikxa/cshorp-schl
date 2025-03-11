using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{
    internal class Add_User
    {

            public string onk;
            public string pass;

            public Add_User(string userName)
            {
                //userName = Console.ReadLine();
                onk = userName;

            }

            public string? UserName { get; }
        
    }
}

