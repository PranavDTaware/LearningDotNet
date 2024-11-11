using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    public class Product
    {
        private string title;
        private string description;
        private int quantity;
        private float unitPrice;
        private int id;

        public string Title //capital T is property and t is private variable(data member)
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Description
        { 
            get { return this.description; }
            set { this.description = value; } 
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public float UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int Id  //Readonly property(only get block)
        {
            get { return this.id; }
        }
    }
}
