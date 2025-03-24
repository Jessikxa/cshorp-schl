using System.Linq;
using Administratie_programma;

namespace readLineTest
{

    internal class Program
    {

        static void Main(string[] args)
        {
            bool BBreak;
            List<User> biglist = new List<User>(); //Lijst waar alle informatie over de Users in komt te staan

            Close_Program close_Program = new Close_Program();
            BBreak = close_Program.closeProgram();

            while (!BBreak)
            {

                Console.Clear(); // verwijdert informatie dat in de console zat
                
                //menu page
                Console.WriteLine("0 - Nieuwe gebruiker aanmaken");
                Console.WriteLine("1 - Gebruiker bekijken");
                Console.WriteLine("2 - Gebruiker verwijderen");
                Console.WriteLine("3 - Applicatie sluiten");


                string input = Console.ReadLine();
                int.TryParse(input, out int result); // verandert string input naar een getal

                switch (result) // leest de resultaat van de input van user
                {
                    
                    case 0: // nieuwe gebruikers aanmaken

                        Add_User newUser = new Add_User();
                        newUser.AddUser(biglist);
                        break;
                    

                    case 1: // gebruiker bekijken

                        User_Info User = new User_Info(); 
                        User.ShowUserInfo(biglist);
                        break;

                    case 2: // gebruiker verwijderen

                        Remove_User remove_User = new Remove_User();
                        remove_User.SelectDeleteUser(biglist);

                        break;

                    case 3: // eindigt de programma

                        BBreak = true;
                        Console.WriteLine("Program will be ended shortly...");
                        break;
                        

                }
                Task.Delay(2000).Wait(); // laat programma 2 seconden wachten voordat het weer opnieuw loopt
            }
            //Console.WriteLine("Enter your username:");
            //string username = Console.ReadLine();
            //readdddd Test = new readdddd(Console.ReadLine());
            //biglist.Add(Test);

            //Console.WriteLine("enter another username:");
            //readdddd doWork = new readdddd(Console.ReadLine());
            //biglist.Add(doWork);



            //Console.WriteLine($"your username is: {username


            //foreach (Add_User wa in biglist)
            //{
            //    Console.WriteLine($"Gevonden: {wa.onk}");
            //}
        }
    }
}
