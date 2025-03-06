using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_class_Practice
{
    internal class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item) // als list private is kan zo oplossen
        {
            items.Add(item);
        }

        public List<Item> GetItems() 
        { 
            return items; 
        }
    }
}
