using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Test
{
    internal class Manager
    {
        private static Manager instance;

        public string Name;
        private Manager() 
        {

        }

        public static Manager GetInstance()
        {
            if (instance == null) 
            {
                instance = new Manager();
            }
            return instance;
        } 
    }
}
