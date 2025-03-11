using Administratie_programma;

namespace readLineTest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Add_User> biglist = new List<Add_User>(); //Lijst waar alle informatie over de Users in komt te staan

            bool BBreak = false;
            while (!BBreak)
            {

                Console.Clear(); // verwijdert informatie dat in de console zat
                
                //Login page
                Console.WriteLine("0 - Nieuwe gebruiker aanmaken");
                Console.WriteLine("1 - Gebruiker bekijken");
                Console.WriteLine("2 - Gebruiker verwijderen");
                Console.WriteLine("3 - Applicatie sluiten");


                string input = Console.ReadLine();
                int.TryParse(input, out int result); // veranderd string input in een getal

                switch (result)
                {
                    
                    case 0: // nieuwe gebruikers aanmaken

                        Console.WriteLine("Enter your username:");
                        string username = Console.ReadLine();


                        Add_User Test = new Add_User(username);
                        biglist.Add(Test);

                        Console.WriteLine($"Added username: {Test.onk}");

                        //Console.WriteLine($"Added user: {Test}"); 
                        

                        break;
                    //Main(args);
                    //return;

                    case 1: // gebruiker bekijken

                        foreach (Add_User wa in biglist)
                        {
                            Console.WriteLine($"Gevonden: {wa.onk}");
                        }
                        break;

                    case 2: // gebruiker verwijderen

                        Console.WriteLine("Which user would you like to delete?");

                        //biglist eek;

                        foreach (Add_User wa in biglist)
                        {
                            Console.WriteLine($"Gevonden: {wa.onk}");
                            string DeleteUser = Console.ReadLine().ToLower();
                            //biglist.Remove(DeleteUser, out eek);
                        }
                        //either can ma

                        break;

                    case 3:

                        BBreak = true;
                        Console.WriteLine("Program will be ended shortly");
                        break;
                        

                }
                Task.Delay(2000).Wait();
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
