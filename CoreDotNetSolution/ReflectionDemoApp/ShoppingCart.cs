using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemoApp
{
    public  class ShoppingCart
    {
        public List<Item> Items =new List<Item>();      
        public ShoppingCart() { 
            this.Items = new List<Item>();
        }

        public bool AddToCart(Item item)
        {
            Items.Add(item);
            return true;
        }

        public bool RemoveFromCart(Item item) { 
            Items.Remove(item);
            return true;
        }
    }
}
