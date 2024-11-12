using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        private List<Item> items = new List<Item>(); //generic list collection of Items
        public List<Item> Items 
        { 
            get { return items;}
}
