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
        public string adress;
        public int phoneNumber;


            public User(string userName, int PhoneNumber, string Adress )
            {
                //userName = Console.ReadLine();
                name = userName;
                phoneNumber = PhoneNumber;
                adress = Adress;
            }

            public string? UserName { get; }


    }
}

