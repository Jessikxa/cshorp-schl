namespace Inventory_class_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory MyInventory = new Inventory();  //instantieren/ instantiate
            Item one = new Item("- cool cool");
            Item two = new Item("- WHU WHUT");
            Item three = new Item("- Golden Apple");
            Item foour = new Item("- Iron Sword");
            Item foive = new Item("- Oak Slabs");
            Item sic = new Item("- Zombie Egg");
            

            MyInventory.AddItem(two);
            MyInventory.AddItem(one);
            MyInventory.AddItem(three);
            MyInventory.AddItem(foour);
            MyInventory.AddItem(foive);
            MyInventory.AddItem(sic);

            Console.WriteLine("Items in your Inventory:");

            foreach (Item utom in MyInventory.GetItems())
            {
                Console.WriteLine(utom.ItemsCollected);
            }
        }
    }   
} 
