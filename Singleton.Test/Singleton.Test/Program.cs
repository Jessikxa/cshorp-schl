namespace Singleton.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = Manager.GetInstance(); // gotta add smth to manager
            manager.Name = "Test";


            Console.WriteLine(manager.Name);
        }
        
    }
}