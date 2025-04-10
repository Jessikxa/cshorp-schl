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
            string username = Console.ReadLine(); //user kan gebruikersnaam invullen 
            int x;

            if (Int32.TryParse(username, out x)) // checkt of er geen nummers bij username worden ingevuld
            {
                Console.WriteLine("Username invalid. please type try again");
            }
            //same for adress and phone number

            Console.WriteLine("Enter your phone number");  
            string value = Console.ReadLine();  // user kan 
            int phoneNumber;


            if (!Int32.TryParse(value, out phoneNumber))
            {
                //Console.WriteLine("Phone number is invalid. Please try again");
                while (!Int32.TryParse(value, out phoneNumber))
                {
                    Console.Clear();
                    Console.WriteLine("Phone number is invalid. Please try again");

                    value = Console.ReadLine();
                    if (Int32.TryParse(value, out phoneNumber))
                    {
                        break;
                    }
                    //while((Int32.TryParse(value, out phoneNumber)))
                    //{
                    //    if (value.Length != 10)
                    //    {
                    //        Console.WriteLine("Phone number is invalid. please type in 10 numbers");
                    //        value = Console.ReadLine();
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }

                    //}
                }
            }
            else if (Int32.TryParse(username, out phoneNumber)) 
            {
                while ((Int32.TryParse(value, out phoneNumber)))
                {
                    if (value.Length != 10)
                    {
                        Console.WriteLine("Phone number is invalid. please type in 10 numbers");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //while (!Int32.TryParse(value, out phoneNumber))
            //{
            //    Console.Clear();
            //    Console.WriteLine("Phone number is invalid. Please try again");
                
            //    value = Console.ReadLine();
            //    if (Int32.TryParse(value,out phoneNumber))
            //    {
            //        break;
            //    }
            //    //while((Int32.TryParse(value, out phoneNumber)))
            //    //{
            //    //    if (value.Length != 10)
            //    //    {
            //    //        Console.WriteLine("Phone number is invalid. please type in 10 numbers");
            //    //        value = Console.ReadLine();
            //    //    }
            //    //    else
            //    //    {
            //    //        break;
            //    //    }
                   
            //    //}
            //}

            //while ((Int32.TryParse(value, out phoneNumber)))
            //{
            //    if (value.Length != 10)
            //    {
            //        Console.WriteLine("Phone number is invalid. please type in 10 numbers");
            //        value = Console.ReadLine();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


                Console.WriteLine("Enter your adress");
            string adress = Console.ReadLine();

            User Test = new User(username, phoneNumber, adress);
            biglist.Add(Test);

            Console.WriteLine($"Added username: {Test.name} phone number: {Test.phoneNumber} adress: {Test.adress}");

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();

        }
    }
}
